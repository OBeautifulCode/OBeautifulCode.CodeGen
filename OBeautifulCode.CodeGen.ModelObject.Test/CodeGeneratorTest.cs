// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGeneratorTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;

    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Type.Recipes;

    using Xunit;

    using static System.FormattableString;

    public class CodeGeneratorTest
    {
        public const string ModelBaseName = "MyModel";

        public const string TestNameSuffix = "Test";

        public static readonly bool WriteFiles = true;

        public static readonly string SourceRoot = IsRunningInAppVeyor() ? Directory.GetCurrentDirectory().AppendMissing("\\") : "d:\\src\\OBeautifulCode\\OBeautifulCode.CodeGen\\OBeautifulCode.CodeGen.ModelObject.Test\\";

        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyList<string> ChildIdentifiers = new[] { "1", "2" };

        public static readonly string GeneratedModelsPath = IsRunningInAppVeyor() ? SourceRoot : (SourceRoot + "Models\\GeneratedModels\\");

        public static readonly string GeneratedTestsPath = IsRunningInAppVeyor() ? SourceRoot : (SourceRoot + "ModelTests\\GeneratedModels\\");

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
            typeof(ICollection<IReadOnlyList<DateTime>>),
            typeof(IReadOnlyList<ICollection<string>>),
            typeof(IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>>),
            typeof(IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyDictionary<ModelClass, IReadOnlyList<DateTime>>>>),
        };

        private static readonly Type[] BlacklistTypes =
        {
            typeof(IReadOnlyDictionary<DateTime, DateTime>),
            typeof(IReadOnlyDictionary<DateTime?, DateTime?>),
        };

        private delegate void ExecuteForModelsEventHandler(GenerationKind generationKind, SetterKind setterKind, HierarchyKind hierarchyKind, string directoryPath, string childIdentifier = null);

        [Fact]
        public void GenerateModel___Should_generate_the_model___When_called()
        {
            void GenerateModelEventHandler(GenerationKind generationKind, SetterKind setterKind, HierarchyKind hierarchyKind, string directoryPath, string childIdentifier = null)
            {
                var modelName = ModelBaseName.BuildModelName(setterKind, hierarchyKind, childIdentifier);

                var modelFilePath = directoryPath + modelName + ".cs";

                var modelCode = GenerateModel(ModelBaseName, setterKind, TypesToWrap, TypeWrapperKinds, AdditionalTypes, BlacklistTypes, hierarchyKind, childIdentifier);

                if (WriteFiles)
                {
                    File.WriteAllText(modelFilePath, modelCode);
                }
            }

            var createBlankFilesEventHandler = BuildCreateBlankFilesEventHandler();

            // blank out downstream files
            ExecuteForModels(GenerationKind.Model, createBlankFilesEventHandler);
            ExecuteForModels(GenerationKind.Test, createBlankFilesEventHandler);
            File.WriteAllText(DummyFactoryFilePath, string.Empty);

            // generate new files
            ExecuteForModels(GenerationKind.Model, GenerateModelEventHandler);
        }

        [Fact]
        public void GenerateForModel___Should_generate_model_implementation_partial_class___When_parameter_generateFor_is_ModelImplementationPartialClass()
        {
            // blank out downstream files
            var createBlankFilesEventHandler = BuildCreateBlankFilesEventHandler();
            ExecuteForModels(GenerationKind.Test, createBlankFilesEventHandler);
            File.WriteAllText(DummyFactoryFilePath, string.Empty);

            // generate new files
            var generateForModelEventHandler = BuildGenerateForModelEventHandler();

            ExecuteForModels(GenerationKind.Model, generateForModelEventHandler);
        }

        [Fact]
        public void GenerateForModel___Should_generate_dummy_factory___When_parameter_generateFor_is_ModelDummyFactorySnippet()
        {
            // blank out downstream files
            var createBlankFilesEventHandler = BuildCreateBlankFilesEventHandler();
            ExecuteForModels(GenerationKind.Test, createBlankFilesEventHandler);

            // generate new files
            var types = typeof(CodeGeneratorTest).Assembly.GetTypes().Where(_ => _.Name.StartsWith(ModelBaseName, StringComparison.Ordinal)).Where(_ => !_.Name.EndsWith(TestNameSuffix, StringComparison.Ordinal)).ToList();

            var code = GenerateDummyFactory(types);

            File.WriteAllText(DummyFactoryFilePath, code);
        }

        [Fact]
        public void GenerateForModel___Should_generate_model_test_partial_class___When_parameter_generateFor_is_ModelImplementationTestsPartialClassWithSerialization()
        {
            var generateForModelEventHandler = BuildGenerateForModelEventHandler();

            ExecuteForModels(GenerationKind.Test, generateForModelEventHandler);
        }

        private static void ExecuteForModels(
            GenerationKind generationKind,
            ExecuteForModelsEventHandler eventHandler)
        {
            var setterKinds = EnumExtensions.GetDefinedEnumValues<SetterKind>();

            foreach (var setterKind in setterKinds)
            {
                var directoryPath = IsRunningInAppVeyor()
                    ? SourceRoot
                    : setterKind.GetGeneratedCodePath(generationKind);

                var hierarchyKinds = EnumExtensions.GetDefinedEnumValues<HierarchyKind>();

                foreach (var hierarchyKind in hierarchyKinds)
                {
                    if (hierarchyKind == HierarchyKind.ConcreteInherited)
                    {
                        foreach (var childIdentifier in ChildIdentifiers)
                        {
                            eventHandler(generationKind, setterKind, hierarchyKind, directoryPath, childIdentifier);
                        }
                    }
                    else
                    {
                        eventHandler(generationKind, setterKind, hierarchyKind, directoryPath);
                    }
                }
            }
        }

        private static ExecuteForModelsEventHandler BuildCreateBlankFilesEventHandler()
        {
            void ExecuteForModelsEventHandler(GenerationKind generationKind, SetterKind setterKind, HierarchyKind hierarchyKind, string directoryPath, string childIdentifier = null)
            {
                var modelName = ModelBaseName.BuildModelName(setterKind, hierarchyKind, childIdentifier);

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
            void ExecuteForModelsEventHandler(GenerationKind generationKind, SetterKind setterKind, HierarchyKind hierarchyKind, string directoryPath, string childIdentifier = null)
            {
                var modelName = ModelBaseName.BuildModelName(setterKind, hierarchyKind, childIdentifier);

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
            SetterKind setterKind,
            IReadOnlyCollection<Type> typesToWrap,
            IReadOnlyCollection<TypeWrapperKind> typeWrapperKinds,
            IReadOnlyCollection<Type> additionalTypes,
            IReadOnlyCollection<Type> blacklistTypes,
            HierarchyKind hierarchyKind,
            string childIdentifier = null)
        {
            var modelName = baseName.BuildModelName(setterKind, hierarchyKind, childIdentifier);

            var constructorParentParameterStatements = new List<string>();
            var constructorParentParameterNames = new List<string>();
            var constructorDeclarationStatement = string.Empty;
            var constructorParameterStatements = new List<string>();
            var constructorValidationStatements = new List<string>();
            var constructorPropertySettingStatements = new List<string>();

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

                propertyStatements.Add(string.Empty);
                propertyStatements.Add(Invariant($"        public {typeCompilableString} {propertyName} {{ get; {setterKind.ToSetterString()}}}"));

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
            }

            var abstractStatement = hierarchyKind == HierarchyKind.AbstractBase ? "abstract " : string.Empty;

            var derivativeStatement = hierarchyKind == HierarchyKind.ConcreteInherited ? $"{baseName.BuildModelName(setterKind, HierarchyKind.AbstractBase, childIdentifier: null)}, " : string.Empty;

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
                "    using System.Collections.Generic;",
                string.Empty,
                "    using OBeautifulCode.Assertion.Recipes;",
                "    using OBeautifulCode.Type;",
                string.Empty,
                Invariant($"    public {abstractStatement}partial class {modelName} : {derivativeStatement}IModelViaCodeGen"),
                "    {",
            };

            var footerStatements = new List<string>
            {
                "    }",
                "}",
            };

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
            }

            var result = new string[0]
                .Concat(headerStatements)
                .Concat(constructorStatements)
                .Concat(propertyStatements)
                .Concat(footerStatements)
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
                "    using System.Collections.Generic;",
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

        private static bool IsRunningInAppVeyor()
        {
            var result = Environment.GetEnvironmentVariable("APPVEYOR") != null;

            return result;
        }
    }
}
