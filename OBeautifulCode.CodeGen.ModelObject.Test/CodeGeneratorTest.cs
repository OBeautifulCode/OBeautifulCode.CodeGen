// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGeneratorTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;

    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using Xunit;

    using static System.FormattableString;

    public class CodeGeneratorTest
    {
        public const string ModelBaseName = "MyModel";

        public const string TestNameSuffix = "Test";

        public static readonly bool WriteFiles = true;

        public static readonly string SourceRoot = "d:\\src\\OBeautifulCode\\OBeautifulCode.CodeGen\\OBeautifulCode.CodeGen.ModelObject.Test\\";

        // ReSharper disable once InconsistentNaming
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyList<string> ChildIdentifiers = new[] { "1", "2" };

        public static readonly string ModelsPath = SourceRoot + "Models\\";

        public static readonly string EmptyModelsPath = ModelsPath + "EmptyModels\\";

        public static readonly string GeneratedModelsPath = ModelsPath + "GeneratedModels\\";

        public static readonly string TestsPath = SourceRoot + "ModelTests\\";

        public static readonly string EmptyModelsTestsPath = TestsPath + "EmptyModels\\";

        public static readonly string GeneratedModelsTestsPath = TestsPath + "GeneratedModels\\";

        public static readonly string DummyFactoryFilePath = SourceRoot + "DummyFactory.cs";

        private static readonly Type[] TypesToWrap =
        {
            typeof(bool),
            typeof(int),
            typeof(string),
            typeof(Guid),
            typeof(DateTime),
            typeof(ModelEnum),
            typeof(ModelFlagsEnum),
            typeof(ModelClass),

            // OBC.Serialization doesn't support structs
            // typeof(ModelStruct),
        };

        private static readonly IReadOnlyList<TypeWrapperKind> TypeWrapperKinds = EnumExtensions.GetDefinedEnumValues<TypeWrapperKind>().ToList();

        private static readonly Type[] AdditionalTypes =
        {
            typeof(ICollection<string>), // elements must be comparable for generated hashing unequal test to NOT be skipped
            typeof(Collection<ICollection<string>>),
            typeof(IList<ICollection<string>>),
            typeof(List<ICollection<string>>),
            typeof(ReadOnlyCollection<ICollection<string>>),
            typeof(IDictionary<string, IReadOnlyList<DateTime>>),
            typeof(Dictionary<string, IReadOnlyList<DateTime>>),
            typeof(ReadOnlyDictionary<string, IReadOnlyList<DateTime>>),
            typeof(ConcurrentDictionary<string, IReadOnlyList<DateTime>>),
            typeof(IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>>),
            typeof(IReadOnlyDictionary<string, IReadOnlyDictionary<string, ReadOnlyDictionary<ModelClass, IReadOnlyList<DateTime>>>>),
        };

        private static readonly Type[] BlacklistTypes =
        {
            typeof(IReadOnlyDictionary<DateTime, DateTime>),
            typeof(IReadOnlyDictionary<DateTime?, DateTime?>),
        };

        private static readonly IReadOnlyDictionary<HierarchyKind, IReadOnlyCollection<string>> HierarchyKindToEmptyModelNameSuffixes = new Dictionary<HierarchyKind, IReadOnlyCollection<string>>
        {
            { HierarchyKind.None, new[] { "Empty" } },
            { HierarchyKind.AbstractBase, new[] { "EmptyParent", "NotEmptyParent" } },
            { HierarchyKind.ConcreteInherited, new[] { "EmptyParentEmptyChild", "EmptyParentNotEmptyChild", "NotEmptyParentEmptyChild" } },
        };

        private delegate void ExecuteForModelsEventHandler(GenerationKind generationKind, GeneratedModelKind? generatedModelKind, SetterKind setterKind, HierarchyKind hierarchyKind, string childIdentifier, string modelName, string directoryPath);

        [Fact]
        public void GenerateModel___Should_generate_models___When_called()
        {
            void GenerateModelEventHandler(GenerationKind generationKind, GeneratedModelKind? generatedModelKind, SetterKind setterKind, HierarchyKind hierarchyKind, string childIdentifier, string modelName, string directoryPath)
            {
                var modelFilePath = directoryPath + modelName + ".cs";

                var modelCode = GenerateModel(ModelBaseName, (GeneratedModelKind)generatedModelKind, setterKind, TypesToWrap, TypeWrapperKinds, AdditionalTypes, BlacklistTypes, hierarchyKind, childIdentifier, modelName);

                if (WriteFiles)
                {
                    File.WriteAllText(modelFilePath, modelCode);
                }
            }

            var createBlankFilesEventHandler = BuildCreateBlankFilesEventHandler();

            // blank out downstream files
            ExecuteForEmptyModels(GenerationKind.Test, createBlankFilesEventHandler);
            ExecuteForGeneratedModels(GenerationKind.Model, createBlankFilesEventHandler);
            ExecuteForGeneratedModels(GenerationKind.Test, createBlankFilesEventHandler);
            WriteDummyFactory(string.Empty);

            // generate new files
            ExecuteForGeneratedModels(GenerationKind.Model, GenerateModelEventHandler);
        }

        [Fact]
        public void GenerateForModel___Should_generate_model_implementation_partial_class___When_parameter_generateFor_is_ModelImplementationPartialClass()
        {
            // blank out downstream files
            var createBlankFilesEventHandler = BuildCreateBlankFilesEventHandler();

            ExecuteForEmptyModels(GenerationKind.Test, createBlankFilesEventHandler);
            ExecuteForGeneratedModels(GenerationKind.Test, createBlankFilesEventHandler);
            WriteDummyFactory(string.Empty);

            // generate new files
            var generateForModelEventHandler = BuildGenerateForModelEventHandler();

            ExecuteForEmptyModels(GenerationKind.Model, generateForModelEventHandler);
            ExecuteForGeneratedModels(GenerationKind.Model, generateForModelEventHandler);
        }

        [Fact]
        public void GenerateForModel___Should_generate_dummy_factory___When_parameter_generateFor_is_ModelDummyFactorySnippet()
        {
            // blank out downstream files
            var createBlankFilesEventHandler = BuildCreateBlankFilesEventHandler();

            ExecuteForEmptyModels(GenerationKind.Test, createBlankFilesEventHandler);
            ExecuteForGeneratedModels(GenerationKind.Test, createBlankFilesEventHandler);

            // generate new files
            var types = typeof(CodeGeneratorTest).Assembly.GetTypes().Where(_ => _.Name.StartsWith(ModelBaseName, StringComparison.Ordinal)).Where(_ => !_.Name.EndsWith(TestNameSuffix, StringComparison.Ordinal)).ToList();
            var dummyFactoryCode = GenerateDummyFactory(types);
            WriteDummyFactory(dummyFactoryCode);
        }

        [Fact]
        public void GenerateForModel___Should_generate_model_test_partial_class___When_parameter_generateFor_is_ModelImplementationTestsPartialClassWithSerialization()
        {
            var generateForModelEventHandler = BuildGenerateForModelEventHandler();

            ExecuteForEmptyModels(GenerationKind.Test, generateForModelEventHandler);
            ExecuteForGeneratedModels(GenerationKind.Test, generateForModelEventHandler);
        }

        private static void ExecuteForEmptyModels(
            GenerationKind generationKind,
            ExecuteForModelsEventHandler eventHandler)
        {
            var setterKinds = EnumExtensions.GetDefinedEnumValues<SetterKind>();

            foreach (var setterKind in setterKinds)
            {
                var directoryPath = setterKind.GetEmptyModelsDirectoryPath(generationKind);

                var hierarchyKinds = EnumExtensions.GetDefinedEnumValues<HierarchyKind>();

                foreach (var hierarchyKind in hierarchyKinds)
                {
                    var emptyModelNameSuffixes = HierarchyKindToEmptyModelNameSuffixes[hierarchyKind];

                    foreach (var emptyModelNameSuffix in emptyModelNameSuffixes)
                    {
                        var modelName = ModelBaseName.BuildEmptyModelName(setterKind, emptyModelNameSuffix);

                        eventHandler(generationKind, null, setterKind, hierarchyKind, null, modelName, directoryPath);
                    }
                }
            }
        }

        private static void ExecuteForGeneratedModels(
            GenerationKind generationKind,
            ExecuteForModelsEventHandler eventHandler)
        {
            var setterKinds = EnumExtensions.GetDefinedEnumValues<SetterKind>();

            foreach (var setterKind in setterKinds)
            {
                var generatedModelKinds = EnumExtensions.GetDefinedEnumValues<GeneratedModelKind>();

                foreach (var generatedModelKind in generatedModelKinds)
                {
                    var directoryPath = generationKind.GetGeneratedModelsDirectoryPath(generatedModelKind, setterKind);

                    var hierarchyKinds = EnumExtensions.GetDefinedEnumValues<HierarchyKind>();

                    foreach (var hierarchyKind in hierarchyKinds)
                    {
                        if (hierarchyKind == HierarchyKind.ConcreteInherited)
                        {
                            foreach (var childIdentifier in ChildIdentifiers)
                            {
                                var modelName = ModelBaseName.BuildGeneratedModelName(generatedModelKind, setterKind, hierarchyKind, childIdentifier);

                                eventHandler(generationKind, generatedModelKind, setterKind, hierarchyKind, childIdentifier, modelName, directoryPath);
                            }
                        }
                        else
                        {
                            var modelName = ModelBaseName.BuildGeneratedModelName(generatedModelKind, setterKind, hierarchyKind, null);

                            eventHandler(generationKind, generatedModelKind, setterKind, hierarchyKind, null, modelName, directoryPath);
                        }
                    }
                }
            }
        }

        private static ExecuteForModelsEventHandler BuildCreateBlankFilesEventHandler()
        {
            void ExecuteForModelsEventHandler(GenerationKind generationKind, GeneratedModelKind? generatedModelKind, SetterKind setterKind, HierarchyKind hierarchyKind, string childIdentifier, string modelName, string directoryPath)
            {
                var testToken = generationKind == GenerationKind.Test ? TestNameSuffix : null;

                var modelFilePath = directoryPath + modelName + $"{testToken}.designer.cs";

                if (WriteFiles)
                {
                    File.WriteAllText(modelFilePath, string.Empty);
                }
            }

            return ExecuteForModelsEventHandler;
        }

        private static ExecuteForModelsEventHandler BuildGenerateForModelEventHandler()
        {
            void ExecuteForModelsEventHandler(GenerationKind generationKind, GeneratedModelKind? generatedModelKind, SetterKind setterKind, HierarchyKind hierarchyKind, string childIdentifier, string modelName, string directoryPath)
            {
                var modelType = typeof(CodeGeneratorTest).Assembly.GetTypes().Single(_ => _.Name == modelName);

                var testToken = generationKind == GenerationKind.Test ? TestNameSuffix : null;

                var modelFilePath = directoryPath + modelName + $"{testToken}.designer.cs";

                GenerateFor generateFor;
                switch (generationKind)
                {
                    case GenerationKind.Model:
                        generateFor = GenerateFor.ModelImplementationPartialClass;
                        break;
                    case GenerationKind.Test:
                        generateFor = GenerateFor.ModelImplementationTestsPartialClassWithSerialization;
                        break;
                    default:
                        throw new NotSupportedException("This kind is not supported: " + generationKind);
                }

                var modelCode = modelType.GenerateForModel(generateFor);

                if (WriteFiles)
                {
                    File.WriteAllText(modelFilePath, modelCode);
                }
            }

            return ExecuteForModelsEventHandler;
        }

        private static string GenerateModel(
            string baseName,
            GeneratedModelKind generatedModelKind,
            SetterKind setterKind,
            IReadOnlyCollection<Type> typesToWrap,
            IReadOnlyCollection<TypeWrapperKind> typeWrapperKinds,
            IReadOnlyCollection<Type> additionalTypes,
            IReadOnlyCollection<Type> blacklistTypes,
            HierarchyKind hierarchyKind,
            string childIdentifier,
            string modelName)
        {
            var constructorParentParameterStatements = new List<string>();
            var constructorParentParameterNames = new List<string>();
            var constructorDeclarationStatement = string.Empty;
            var constructorParameterStatements = new List<string>();
            var constructorValidationStatements = new List<string>();
            var constructorPropertySettingStatements = new List<string>();
            var equalityStatements = new List<string>();
            var equalityParentStatements = new List<string>();

            var propertyStatements = new List<string>();

            if (setterKind.RequiresConstructor())
            {
                var constructorAccessorModifier = hierarchyKind == HierarchyKind.AbstractBase ? "protected" : "public";

                constructorDeclarationStatement = Invariant($"        {constructorAccessorModifier} {modelName}(");
            }

            var typesToAddAsProperties = new List<Type>();
            foreach (var typeWrapperKind in typeWrapperKinds)
            {
                typesToAddAsProperties.AddRange(typesToWrap.Select(_ => _.ToFullyWrappedType(typeWrapperKind)).Where(_ => _ != null));
            }

            typesToAddAsProperties.AddRange(additionalTypes);

            typesToAddAsProperties = typesToAddAsProperties.Where(_ => !blacklistTypes.Contains(_)).ToList();

            foreach (var typeToAddAsProperty in typesToAddAsProperties)
            {
                var typeCompilableString = typeToAddAsProperty.ToStringCompilable();

                var propertyName = typeToAddAsProperty.BuildPropertyName(hierarchyKind, childIdentifier);

                propertyStatements.Add(Invariant($"        public {typeCompilableString} {propertyName} {{ get; {setterKind.ToSetterString()}}}"));
                propertyStatements.Add(string.Empty);

                if (setterKind.RequiresConstructor())
                {
                    var constructorParameterName = propertyName.ToLowerFirstCharacter();
                    constructorParameterStatements.Add(Invariant($"            {typeCompilableString} {constructorParameterName},"));

                    if (hierarchyKind == HierarchyKind.ConcreteInherited)
                    {
                        var constructorParentParameterName = typeToAddAsProperty.BuildPropertyName(HierarchyKind.AbstractBase, null).ToLowerFirstCharacter();
                        constructorParentParameterNames.Add(constructorParentParameterName);

                        constructorParentParameterStatements.Add(Invariant($"            {typeCompilableString} {constructorParentParameterName},"));
                    }

                    constructorPropertySettingStatements.Add(Invariant($"            this.{propertyName} = {constructorParameterName};"));

                    var mustValidationMethodName = typeToAddAsProperty.GetMustValidationMethodName();
                    if (mustValidationMethodName != null)
                    {
                        constructorValidationStatements.Add(Invariant($"            new {{ {constructorParameterName} }}.AsArg().Must().{mustValidationMethodName}();"));
                    }
                }

                equalityStatements.Add(Invariant($"                this.{propertyName}.IsEqualTo(other.{propertyName}) &&"));
                if (hierarchyKind == HierarchyKind.ConcreteInherited)
                {
                    var parentPropertyName = typeToAddAsProperty.BuildPropertyName(HierarchyKind.AbstractBase, null);
                    equalityParentStatements.Add(Invariant($"                this.{parentPropertyName}.IsEqualTo(other.{parentPropertyName}) &&"));
                }
            }

            propertyStatements.RemoveAt(propertyStatements.Count - 1);

            var abstractStatement = hierarchyKind == HierarchyKind.AbstractBase ? "abstract " : string.Empty;

            string baseClassName = null;
            if (hierarchyKind == HierarchyKind.ConcreteInherited)
            {
                baseClassName = $"{baseName.BuildGeneratedModelName(generatedModelKind, setterKind, HierarchyKind.AbstractBase, childIdentifier: null)}";
            }

            var derivativeStatement = baseClassName == null ? string.Empty : baseClassName + ", ";

            string interfaceStatement;
            var pragmaDisableStatements = new List<string>();
            var pragmaRestoreStatements = new List<string>();
            switch (generatedModelKind)
            {
                case GeneratedModelKind.All:
                    interfaceStatement = nameof(IModelViaCodeGen);
                    break;
                case GeneratedModelKind.Equality:
                    interfaceStatement = hierarchyKind == HierarchyKind.AbstractBase
                        ? nameof(IEquatableViaCodeGen)
                        : Invariant($"{nameof(IEquatableViaCodeGen)}, {typeof(IDeclareEqualsMethod<>).ToStringWithoutGenericComponent()}<{modelName}>");
                    pragmaDisableStatements.Add("#pragma warning disable CS0659");
                    pragmaDisableStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0659");

                    break;
                case GeneratedModelKind.Cloning:
                    interfaceStatement = hierarchyKind == HierarchyKind.AbstractBase
                        ? nameof(IDeepCloneableViaCodeGen)
                        : Invariant($"{nameof(IDeepCloneableViaCodeGen)}, {typeof(IDeclareDeepCloneMethod<>).ToStringWithoutGenericComponent()}<{modelName}>");
                    break;
                default:
                    throw new NotSupportedException("This generated model kind is not supported: " + generatedModelKind);
            }

            var headerStatements = new List<string>
            {
                "// --------------------------------------------------------------------------------------------------------------------",
                Invariant($"// <copyright file=\"{modelName}.cs\" company=\"OBeautifulCode\">"),
                "//   Copyright (c) OBeautifulCode 2018. All rights reserved.",
                "// </copyright>",
                "// <auto-generated>",
                "//   Sourced OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest.GenerateModel()",
                "// </auto-generated>",
                "// --------------------------------------------------------------------------------------------------------------------",
                string.Empty,
                Invariant($"namespace {typeof(CodeGeneratorTest).Namespace}"),
                "{",
                "    using System;",
                "    using System.Collections.Concurrent;",
                "    using System.Collections.Generic;",
                "    using System.Collections.ObjectModel;",
                string.Empty,
                "    using FakeItEasy;",
                string.Empty,
                "    using OBeautifulCode.Assertion.Recipes;",
                "    using OBeautifulCode.Equality.Recipes;",
                "    using OBeautifulCode.Type;",
                string.Empty,
                pragmaDisableStatements.Any() ? pragmaDisableStatements.ToNewLineDelimited() : null,
                Invariant($"    public {abstractStatement}partial class {modelName} : {derivativeStatement}{interfaceStatement}"),
                pragmaRestoreStatements.Any() ? pragmaDisableStatements.ToNewLineDelimited() : null,
                "    {",
            };

            var footerStatements = new List<string>
            {
                "    }",
                "}",
            };

            var methodStatements = new List<string>();

            var generatedModelKindAllName = modelName.Replace(generatedModelKind.ToString(), nameof(GeneratedModelKind.All));

            var getEquivalentAllModelMethodStatements = new List<string>
            {
                string.Empty,
                Invariant($"        private {modelName} DeepCloneInternal()"),
                Invariant($"        {{"),
                Invariant($"            var referenceModel = A.Dummy<{generatedModelKindAllName}>();"),
                string.Empty,
                Invariant($"            var referenceModelProperties = referenceModel.GetType().GetProperties();"),
                string.Empty,
                Invariant($"            foreach (var referenceModelProperty in referenceModelProperties)"),
                Invariant($"            {{"),
                Invariant($"                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));"),
                Invariant($"            }}"),
                string.Empty,
                Invariant($"            referenceModel = ({generatedModelKindAllName})referenceModel.GetType().GetMethod(\"DeepClone\").Invoke(referenceModel, new object[0]);"),
                string.Empty,
                Invariant($"            var thisModelProperties = this.GetType().GetProperties();"),
                string.Empty,
                Invariant($"            var result = A.Dummy<{modelName}>();"),
                string.Empty,
                Invariant($"            foreach (var thisModelProperty in thisModelProperties)"),
                Invariant($"            {{"),
                Invariant($"                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));"),
                Invariant($"            }}"),
                string.Empty,
                Invariant($"            return result;"),
                Invariant($"        }}"),
            };

            if ((generatedModelKind == GeneratedModelKind.Cloning) && (hierarchyKind != HierarchyKind.AbstractBase))
            {
                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                methodStatements.Add(
                    hierarchyKind == HierarchyKind.None
                        ? Invariant($"        public {modelName} DeepClone()")
                        : Invariant($"        {modelName} {typeof(IDeclareDeepCloneMethod<>).ToStringWithoutGenericComponent()}<{modelName}>.DeepClone()"));
                methodStatements.Add(Invariant($"        {{"));
                methodStatements.Add(Invariant($"            var result = this.DeepCloneInternal();"));
                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"            return result;"));
                methodStatements.Add(Invariant($"        }}"));

                methodStatements.AddRange(getEquivalentAllModelMethodStatements);
            }
            else if ((generatedModelKind == GeneratedModelKind.Equality) && (hierarchyKind != HierarchyKind.AbstractBase))
            {
                var equalityCode = new string[0].Concat(equalityParentStatements).Concat(equalityStatements).ToNewLineDelimited().TrimEnd('&', ' ') + ";";

                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                methodStatements.Add(Invariant($"        public bool Equals({modelName} other)"));
                methodStatements.Add(Invariant($"        {{"));
                methodStatements.Add(Invariant($"            if (ReferenceEquals(this, other))"));
                methodStatements.Add(Invariant($"            {{"));
                methodStatements.Add(Invariant($"                return true;"));
                methodStatements.Add(Invariant($"            }}"));
                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"            if (ReferenceEquals(other, null))"));
                methodStatements.Add(Invariant($"            {{"));
                methodStatements.Add(Invariant($"                return false;"));
                methodStatements.Add(Invariant($"            }}"));
                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"            var result = "));
                methodStatements.Add(equalityCode);
                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"            return result;"));
                methodStatements.Add(Invariant($"        }}"));
            }

            var constructorStatements = new List<string>();
            if (setterKind.RequiresConstructor())
            {
                constructorStatements.Add(constructorDeclarationStatement);

                constructorStatements.AddRange(constructorParentParameterStatements);

                constructorParameterStatements[constructorParameterStatements.Count - 1] = constructorParameterStatements.Last().TrimEnd(',') + ")";
                constructorStatements.AddRange(constructorParameterStatements);

                if (hierarchyKind == HierarchyKind.ConcreteInherited)
                {
                    constructorStatements.Add(Invariant($"            : base({constructorParentParameterNames.ToDelimitedString(", ")})"));
                }

                constructorStatements.Add("        {");
                constructorStatements.AddRange(constructorValidationStatements);
                constructorStatements.Add(string.Empty);
                constructorStatements.AddRange(constructorPropertySettingStatements);
                constructorStatements.Add("        }");
                constructorStatements.Add(string.Empty);
            }

            var result = new string[0]
                .Concat(headerStatements)
                .Concat(constructorStatements)
                .Concat(propertyStatements)
                .Concat(methodStatements)
                .Concat(footerStatements)
                .Where(_ => _ != null)
                .ToNewLineDelimited();

            return result;
        }

        private static string GenerateDummyFactory(
            IReadOnlyCollection<Type> types)
        {
            var snippetsToken = "<<SNIPPETS_HERE>>";

            var statements = new List<string>
            {
                "// --------------------------------------------------------------------------------------------------------------------",
                Invariant($"// <copyright file=\"DummyFactory.cs\" company=\"OBeautifulCode\">"),
                "//   Copyright (c) OBeautifulCode 2018. All rights reserved.",
                "// </copyright>",
                "// <auto-generated>",
                "//   Sourced OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest.GenerateDummyFactory()",
                "// </auto-generated>",
                "// --------------------------------------------------------------------------------------------------------------------",
                string.Empty,
                Invariant($"namespace {typeof(CodeGeneratorTest).Namespace}"),
                "{",
                "    using System;",
                "    using System.Collections.Concurrent;",
                "    using System.Collections.Generic;",
                "    using System.Collections.ObjectModel;",
                string.Empty,
                "    using FakeItEasy;",
                string.Empty,
                "    using OBeautifulCode.AutoFakeItEasy;",
                string.Empty,
                "    public class DummyFactory : IDummyFactory",
                "    {",
                "        public DummyFactory()",
                "        {",
                snippetsToken,
                "        }",
                string.Empty,
                "        /// <inheritdoc />",
                "        public Priority Priority => new FakeItEasy.Priority(1);",
                string.Empty,
                "        /// <inheritdoc />",
                "        public bool CanCreate(Type type)",
                "        {",
                "            return false;",
                "        }",
                string.Empty,
                "        /// <inheritdoc />",
                "        public object Create(Type type)",
                "        {",
                "            return null;",
                "        }",
                "    }",
                "}",
            };

            var snippets = types.Select(_ => _.GenerateForModel(GenerateFor.ModelDummyFactorySnippet)).ToDelimitedString(Environment.NewLine + Environment.NewLine);

            var result = statements
                    .ToNewLineDelimited()
                    .Replace(snippetsToken, snippets);

            return result;
        }

        private static void WriteDummyFactory(
            string code)
        {
            if (WriteFiles)
            {
                File.WriteAllText(DummyFactoryFilePath, code);
            }
        }
    }
}
