// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGeneratorTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using Xunit;

    using static System.FormattableString;

    public class CodeGeneratorTest
    {
        private delegate void ExecuteForModelsEventHandler(GenerationKind generationKind, GeneratedModelKind generatedModelKind, SetterKind setterKind, HierarchyKind hierarchyKind, string childIdentifier, string modelName, string directoryPath);

        [Fact]
        public void GenerateModel___Should_generate_models___When_called()
        {
            // Arrange
            ExecuteForSpecifiedModels(GenerationKind.Test, ResetFile);

            ExecuteForGeneratedModels(GenerationKind.Model, ResetFile);

            ExecuteForGeneratedModels(GenerationKind.Test, ResetFile);

            WriteDummyFactory(string.Empty);

            // Act, Assert
            ExecuteForGeneratedModels(GenerationKind.Model, GenerateModel);
        }

        [Fact]
        public void GenerateForModel___Should_generate_model_implementation_partial_class___When_parameter_generateFor_is_ModelImplementationPartialClass()
        {
            // Arrange
            ExecuteForSpecifiedModels(GenerationKind.Test, ResetFile);

            ExecuteForGeneratedModels(GenerationKind.Test, ResetFile);

            WriteDummyFactory(string.Empty);

            // Act, Assert
            ExecuteForSpecifiedModels(GenerationKind.Model, RunCodeGen);
            ExecuteForGeneratedModels(GenerationKind.Model, RunCodeGen);
        }

        [Fact]
        public void GenerateForModel___Should_generate_dummy_factory___When_parameter_generateFor_is_ModelDummyFactorySnippet()
        {
            // Arrange
            ExecuteForSpecifiedModels(GenerationKind.Test, ResetFile);

            ExecuteForGeneratedModels(GenerationKind.Test, ResetFile);

            var types = typeof(CodeGeneratorTest).Assembly.GetTypes().Where(_ => _.Name.StartsWith(Settings.ModelBaseName, StringComparison.Ordinal)).Where(_ => !_.Name.EndsWith(Settings.TestNameSuffix, StringComparison.Ordinal)).ToList();

            var dummyFactoryCode = GenerateDummyFactory(types);

            // Act, Assert
            WriteDummyFactory(dummyFactoryCode);
        }

        [Fact]
        public void GenerateForModel___Should_generate_model_test_partial_class___When_parameter_generateFor_is_ModelImplementationTestsPartialClassWithSerialization()
        {
            // Arrange, Act, Assert
            ExecuteForSpecifiedModels(GenerationKind.Test, RunCodeGen);
            ExecuteForGeneratedModels(GenerationKind.Test, RunCodeGen);
        }

        private static void ExecuteForSpecifiedModels(
            GenerationKind generationKind,
            ExecuteForModelsEventHandler eventHandler)
        {
            var specifiedModelKinds = EnumExtensions.GetDefinedEnumValues<SpecifiedModelKind>();

            foreach (var specifiedModelKind in specifiedModelKinds)
            {
                var setterKinds = EnumExtensions.GetDefinedEnumValues<SetterKind>();

                foreach (var setterKind in setterKinds)
                {
                    var directoryPath = specifiedModelKind.GetSpecifiedModelsDirectoryPath(setterKind, generationKind);

                    var hierarchyKinds = EnumExtensions.GetDefinedEnumValues<HierarchyKind>();

                    foreach (var hierarchyKind in hierarchyKinds)
                    {
                        var hierarchyKindToModelNameSuffixMap = Settings.SpecifiedModelKindToHierarchyKindToModelNameSuffixMap[specifiedModelKind];

                        var modelNameSuffixes = hierarchyKindToModelNameSuffixMap[hierarchyKind];

                        foreach (var modelNameSuffix in modelNameSuffixes)
                        {
                            var modelName = Settings.ModelBaseName.BuildSpecifiedModelName(setterKind, modelNameSuffix);

                            eventHandler(generationKind, GeneratedModelKind.Unknown, setterKind, hierarchyKind, null, modelName, directoryPath);
                        }
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
                            foreach (var childIdentifier in Settings.ChildIdentifiers)
                            {
                                var modelName = Settings.ModelBaseName.BuildGeneratedModelName(generatedModelKind, setterKind, hierarchyKind, childIdentifier);

                                eventHandler(generationKind, generatedModelKind, setterKind, hierarchyKind, childIdentifier, modelName, directoryPath);
                            }
                        }
                        else
                        {
                            var modelName = Settings.ModelBaseName.BuildGeneratedModelName(generatedModelKind, setterKind, hierarchyKind, null);

                            eventHandler(generationKind, generatedModelKind, setterKind, hierarchyKind, null, modelName, directoryPath);
                        }
                    }
                }
            }
        }

        private static void ResetFile(
            GenerationKind generationKind,
            GeneratedModelKind generatedModelKind,
            SetterKind setterKind,
            HierarchyKind hierarchyKind,
            string childIdentifier,
            string modelName,
            string directoryPath)
        {
            var testToken = generationKind == GenerationKind.Test ? Settings.TestNameSuffix : null;

            var modelFilePath = directoryPath + modelName + $"{testToken}.designer.cs";

            if (Settings.WriteFiles)
            {
                var content = string.Empty;

                if (generationKind == GenerationKind.Test)
                {
                    if ((generatedModelKind == GeneratedModelKind.Equality) ||
                        (generatedModelKind == GeneratedModelKind.Hashing))
                    {
                        // this is necessary so that the project compiles when running unit
                        // tests that precede the unit test that creates code generated model tests
                        var codeLines = new List<string>
                            {
                                "namespace OBeautifulCode.CodeGen.ModelObject.Test.Test",
                                "{",
                                "    using OBeautifulCode.CodeGen.ModelObject.Recipes;",
                                Invariant($"    public static partial class {modelName}{testToken}"),
                                "    {",
                                Invariant($"        private static readonly EquatableTestScenarios<{modelName}> EquatableTestScenarios = new EquatableTestScenarios<{modelName}>();"),
                                "    }",
                                "}",
                            };

                        content = codeLines.ToNewLineDelimited();
                    }
                    else if (generatedModelKind == GeneratedModelKind.Comparing)
                    {
                        // this is necessary so that the project compiles when running unit
                        // tests that precede the unit test that creates code generated model tests
                        var codeLines = new List<string>
                            {
                                "namespace OBeautifulCode.CodeGen.ModelObject.Test.Test",
                                "{",
                                "    using OBeautifulCode.CodeGen.ModelObject.Recipes;",
                                Invariant($"    public static partial class {modelName}{testToken}"),
                                "    {",
                                Invariant($"        private static readonly ComparableTestScenarios<{modelName}> ComparableTestScenarios = new ComparableTestScenarios<{modelName}>();"),
                                "    }",
                                "}",
                            };

                        content = codeLines.ToNewLineDelimited();
                    }
                }

                File.WriteAllText(modelFilePath, content);
            }
        }

        private static void RunCodeGen(
            GenerationKind generationKind,
            GeneratedModelKind generatedModelKind,
            SetterKind setterKind,
            HierarchyKind hierarchyKind,
            string childIdentifier,
            string modelName,
            string directoryPath)
        {
            var modelType = typeof(CodeGeneratorTest).Assembly.GetTypes().Single(_ => _.Name == modelName);

            var testToken = generationKind == GenerationKind.Test ? Settings.TestNameSuffix : null;

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

            var generatedCode = modelType.GenerateForModel(generateFor);

            if (Settings.WriteFiles)
            {
                File.WriteAllText(modelFilePath, generatedCode);
            }
        }

        private static void GenerateModel(
            GenerationKind generationKind,
            GeneratedModelKind generatedModelKind,
            SetterKind setterKind,
            HierarchyKind hierarchyKind,
            string childIdentifier,
            string modelName,
            string directoryPath)
        {
            new { generatedModelKind }.AsArg().Must().NotBeEqualTo(GeneratedModelKind.Unknown);

            var modelFilePath = directoryPath + modelName + ".cs";

            IReadOnlyCollection<Type> typesToWrap, additionalTypes, blacklistTypes;
            IReadOnlyCollection<TypeWrapperKind> typeWrapperKinds;

            switch (generatedModelKind)
            {
                case GeneratedModelKind.Comparing:
                    typesToWrap = Settings.ComparabilityTypes;
                    typeWrapperKinds = new[] { TypeWrapperKind.None };
                    additionalTypes = new Type[0];
                    blacklistTypes = new Type[0];
                    break;
                default:
                    typesToWrap = Settings.TypesToWrap;
                    typeWrapperKinds = Settings.TypeWrapperKinds;
                    additionalTypes = Settings.AdditionalTypes;
                    blacklistTypes = Settings.BlacklistTypes;
                    break;
            }

            var baseName = Settings.ModelBaseName;

            var constructorParentParameterStatements = new List<string>();
            var constructorParentParameterNames = new List<string>();
            var constructorDeclarationStatement = string.Empty;
            var constructorParameterStatements = new List<string>();
            var constructorValidationStatements = new List<string>();
            var constructorPropertySettingStatements = new List<string>();
            var equalityStatements = new List<string>();
            var equalityParentStatements = new List<string>();
            var hashingStatements = new List<string>();
            var hashingParentStatements = new List<string>();

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
                hashingStatements.Add(Invariant($"                .Hash(this.{propertyName})"));

                if (hierarchyKind == HierarchyKind.ConcreteInherited)
                {
                    var parentPropertyName = typeToAddAsProperty.BuildPropertyName(HierarchyKind.AbstractBase, null);
                    equalityParentStatements.Add(Invariant($"                this.{parentPropertyName}.IsEqualTo(other.{parentPropertyName}) &&"));
                    hashingParentStatements.Add(Invariant($"                .Hash(this.{parentPropertyName})"));
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
                case GeneratedModelKind.Cloning:
                    interfaceStatement = hierarchyKind == HierarchyKind.AbstractBase
                        ? Invariant($"{nameof(IDeepCloneableViaCodeGen)}, {typeof(IEquatable<>).ToStringWithoutGenericComponent()}<{modelName}>")
                        : Invariant($"{nameof(IDeepCloneableViaCodeGen)}, {typeof(IDeclareDeepCloneMethod<>).ToStringWithoutGenericComponent()}<{modelName}>, {typeof(IEquatable<>).ToStringWithoutGenericComponent()}<{modelName}>");

                    pragmaDisableStatements.Add("#pragma warning disable CS0659");
                    pragmaDisableStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0659");

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
                case GeneratedModelKind.Hashing:
                    interfaceStatement = hierarchyKind == HierarchyKind.AbstractBase
                        ? nameof(IHashableViaCodeGen)
                        : Invariant($"{nameof(IHashableViaCodeGen)}, {nameof(IDeclareGetHashCodeMethod)}");
                    break;
                case GeneratedModelKind.StringRepresentation:
                    interfaceStatement = hierarchyKind == HierarchyKind.AbstractBase
                        ? nameof(IStringRepresentableViaCodeGen)
                        : Invariant($"{nameof(IStringRepresentableViaCodeGen)}, {nameof(IDeclareToStringMethod)}");
                    break;
                case GeneratedModelKind.Comparing:
                    interfaceStatement = hierarchyKind == HierarchyKind.AbstractBase
                        ? nameof(IComparableViaCodeGen)
                        : Invariant($"{nameof(IComparableViaCodeGen)}, {typeof(IDeclareCompareToForRelativeSortOrderMethod<>).ToStringWithoutGenericComponent()}<{modelName}>");
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

            var equalsMethodLines = new List<string>
            {
                string.Empty,
                Invariant($"        /// <inheritdoc />"),
                Invariant($"        public bool Equals({modelName} other)"),
                Invariant($"        {{"),
                Invariant($"            if (ReferenceEquals(this, other))"),
                Invariant($"            {{"),
                Invariant($"                return true;"),
                Invariant($"            }}"),
                string.Empty,
                Invariant($"            if (ReferenceEquals(other, null))"),
                Invariant($"            {{"),
                Invariant($"                return false;"),
                Invariant($"            }}"),
                string.Empty,
                Invariant($"            var result = "),
                new string[0].Concat(equalityParentStatements).Concat(equalityStatements).ToNewLineDelimited().TrimEnd('&', ' ') + ";",
                string.Empty,
                Invariant($"            return result;"),
                Invariant($"        }}"),
            };

            var equalsMethodCode = equalsMethodLines.ToNewLineDelimited();

            var methodStatements = new List<string>();

            if (generatedModelKind == GeneratedModelKind.Cloning)
            {
                if (hierarchyKind == HierarchyKind.AbstractBase)
                {
                    methodStatements.Add(string.Empty);
                    methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                    methodStatements.Add(Invariant($"        public abstract bool Equals({modelName} other);"));
                }
                else
                {
                    methodStatements.Add(equalsMethodCode);

                    if (hierarchyKind == HierarchyKind.ConcreteInherited)
                    {
                        methodStatements.Add(string.Empty);
                        methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                        methodStatements.Add(Invariant($"        public override bool Equals({baseClassName} other)"));
                        methodStatements.Add(Invariant($"        {{"));
                        methodStatements.Add(Invariant($"            var result = this.Equals(({modelName})other);"));
                        methodStatements.Add(string.Empty);
                        methodStatements.Add(Invariant($"            return result;"));
                        methodStatements.Add(Invariant($"        }}"));
                    }

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
            }
            else if ((generatedModelKind == GeneratedModelKind.Equality) && (hierarchyKind != HierarchyKind.AbstractBase))
            {
                methodStatements.Add(equalsMethodCode);
            }
            else if ((generatedModelKind == GeneratedModelKind.Hashing) && (hierarchyKind != HierarchyKind.AbstractBase))
            {
                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                methodStatements.Add(Invariant($"        public override int GetHashCode() => HashCodeHelper.Initialize()"));
                methodStatements.Add(new string[0].Concat(hashingParentStatements).Concat(hashingStatements).ToNewLineDelimited());
                methodStatements.Add("                .Value;");
            }
            else if ((generatedModelKind == GeneratedModelKind.StringRepresentation) && (hierarchyKind != HierarchyKind.AbstractBase))
            {
                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                methodStatements.Add(Invariant($"        public override string ToString()"));
                methodStatements.Add(Invariant($"        {{"));
                methodStatements.Add(Invariant($"            var result = \"not being tested\";"));
                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"            return result;"));
                methodStatements.Add(Invariant($"        }}"));
            }
            else if ((generatedModelKind == GeneratedModelKind.Comparing) && (hierarchyKind != HierarchyKind.AbstractBase))
            {
                if (hierarchyKind == HierarchyKind.None)
                {
                    methodStatements.Add(string.Empty);
                    methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                    methodStatements.Add(Invariant($"        public RelativeSortOrder CompareToForRelativeSortOrder({modelName} other)"));
                    methodStatements.Add(Invariant($"        {{"));
                    methodStatements.Add(Invariant($"            if (other == null)"));
                    methodStatements.Add(Invariant($"            {{"));
                    methodStatements.Add(Invariant($"                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;"));
                    methodStatements.Add(Invariant($"            }}"));
                    methodStatements.Add(Invariant($"            else if (this.IntProperty > other.IntProperty)"));
                    methodStatements.Add(Invariant($"            {{"));
                    methodStatements.Add(Invariant($"                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;"));
                    methodStatements.Add(Invariant($"            }}"));
                    methodStatements.Add(Invariant($"            else if (this.IntProperty < other.IntProperty)"));
                    methodStatements.Add(Invariant($"            {{"));
                    methodStatements.Add(Invariant($"                return RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;"));
                    methodStatements.Add(Invariant($"            }}"));
                    methodStatements.Add(Invariant($"            else"));
                    methodStatements.Add(Invariant($"            {{"));
                    methodStatements.Add(Invariant($"                return RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance;"));
                    methodStatements.Add(Invariant($"            }}"));
                    methodStatements.Add(Invariant($"        }}"));
                }
                else if (hierarchyKind == HierarchyKind.ConcreteInherited)
                {
                    methodStatements.Add(string.Empty);
                    methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                    methodStatements.Add(Invariant($"        public RelativeSortOrder CompareToForRelativeSortOrder({modelName} other)"));
                    methodStatements.Add(Invariant($"        {{"));
                    methodStatements.Add(Invariant($"            if (other == null)"));
                    methodStatements.Add(Invariant($"            {{"));
                    methodStatements.Add(Invariant($"                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;"));
                    methodStatements.Add(Invariant($"            }}"));
                    methodStatements.Add(string.Empty);
                    methodStatements.Add(Invariant($"            var thisSum = this.Child{childIdentifier}IntProperty + this.ParentIntProperty;"));
                    methodStatements.Add(Invariant($"            var otherSum = other.Child{childIdentifier}IntProperty + other.ParentIntProperty;"));
                    methodStatements.Add(string.Empty);
                    methodStatements.Add(Invariant($"            if (thisSum > otherSum)"));
                    methodStatements.Add(Invariant($"            {{"));
                    methodStatements.Add(Invariant($"                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;"));
                    methodStatements.Add(Invariant($"            }}"));
                    methodStatements.Add(string.Empty);
                    methodStatements.Add(Invariant($"            else if (thisSum < otherSum)"));
                    methodStatements.Add(Invariant($"            {{"));
                    methodStatements.Add(Invariant($"                return RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;"));
                    methodStatements.Add(Invariant($"            }}"));
                    methodStatements.Add(string.Empty);
                    methodStatements.Add(Invariant($"            else"));
                    methodStatements.Add(Invariant($"            {{"));
                    methodStatements.Add(Invariant($"                return RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance;"));
                    methodStatements.Add(Invariant($"            }}"));
                    methodStatements.Add(Invariant($"        }}"));
                }
                else
                {
                    throw new NotSupportedException("This hierarchy kind is not supported: " + hierarchyKind);
                }
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

            var modelCode = new string[0]
                .Concat(headerStatements)
                .Concat(constructorStatements)
                .Concat(propertyStatements)
                .Concat(methodStatements)
                .Concat(footerStatements)
                .Where(_ => _ != null)
                .ToNewLineDelimited();

            if (Settings.WriteFiles)
            {
                File.WriteAllText(modelFilePath, modelCode);
            }
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
            if (Settings.WriteFiles)
            {
                File.WriteAllText(Settings.DummyFactoryFilePath, code);
            }
        }
    }
}
