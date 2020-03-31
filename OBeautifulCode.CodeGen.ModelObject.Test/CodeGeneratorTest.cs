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

    using OBeautifulCode.Assertion.Recipes;
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
        public static readonly bool WriteFiles = false;

        private delegate void ExecuteForModelsEventHandler(GenerationKind generationKind, SpecifiedModelKind specifiedModelKind, GeneratedModelScenario generatedModelScenario, SetterKind setterKind, GeneratedModelPosition generatedModelPosition, string childIdentifier, string modelName, string directoryPath);

        [Fact(Skip = "for local testing only")]
        public void GenerateModel___Should_generate_models___When_called()
        {
            // Arrange
            ExecuteForSpecifiedModels(GenerationKind.Model, ResetFile);

            ExecuteForSpecifiedModels(GenerationKind.Test, ResetFile);

            ExecuteForGeneratedModels(GenerationKind.Model, ResetFile);

            ExecuteForGeneratedModels(GenerationKind.Test, ResetFile);

            WriteDummyFactory(string.Empty);

            // Act, Assert
            ExecuteForGeneratedModels(GenerationKind.Model, GenerateModel);
        }

        [Fact(Skip = "for local testing only")]
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

        [Fact(Skip = "for local testing only")]
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

        [Fact(Skip = "for local testing only")]
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
            var specifiedModelKinds = EnumExtensions.GetDefinedEnumValues<SpecifiedModelKind>().Where(_ => _ != SpecifiedModelKind.NotApplicable).ToList();

            foreach (var specifiedModelKind in specifiedModelKinds)
            {
                var setterKinds = EnumExtensions.GetDefinedEnumValues<SetterKind>();

                foreach (var setterKind in setterKinds)
                {
                    if (((specifiedModelKind == SpecifiedModelKind.MultipleConstructors) || (specifiedModelKind == SpecifiedModelKind.ConstructorMissingProperty)) && (setterKind != SetterKind.PrivateSetters))
                    {
                        continue;
                    }

                    var directoryPath = specifiedModelKind.GetSpecifiedModelsDirectoryPath(setterKind, generationKind);

                    var modelNameSuffixes = Settings.SpecifiedModelKindToModelNameSuffixMap[specifiedModelKind];

                    foreach (var modelNameSuffix in modelNameSuffixes)
                    {
                        var modelName = setterKind.BuildSpecifiedModelName(modelNameSuffix);

                        eventHandler(generationKind, specifiedModelKind, GeneratedModelScenario.NotApplicable, setterKind, GeneratedModelPosition.NotApplicable, null, modelName, directoryPath);
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
                var generatedModelScenarios = EnumExtensions.GetDefinedEnumValues<GeneratedModelScenario>().Where(_ => _ != GeneratedModelScenario.NotApplicable).ToList();

                foreach (var generatedModelScenario in generatedModelScenarios)
                {
                    var directoryPath = generationKind.GetGeneratedModelsDirectoryPath(generatedModelScenario, setterKind);

                    var generatedModelPositions = EnumExtensions.GetDefinedEnumValues<GeneratedModelPosition>().Where(_ => _ != GeneratedModelPosition.NotApplicable).ToList();

                    foreach (var generatedModelPosition in generatedModelPositions)
                    {
                        if (generatedModelPosition == GeneratedModelPosition.Child)
                        {
                            foreach (var childIdentifier in Settings.ChildIdentifiers)
                            {
                                var modelName = generatedModelScenario.BuildGeneratedModelName(setterKind, generatedModelPosition, childIdentifier);

                                eventHandler(generationKind, SpecifiedModelKind.NotApplicable, generatedModelScenario, setterKind, generatedModelPosition, childIdentifier, modelName, directoryPath);
                            }
                        }
                        else
                        {
                            var modelName = generatedModelScenario.BuildGeneratedModelName(setterKind, generatedModelPosition, null);

                            eventHandler(generationKind, SpecifiedModelKind.NotApplicable, generatedModelScenario, setterKind, generatedModelPosition, null, modelName, directoryPath);
                        }
                    }
                }
            }
        }

        private static void ResetFile(
            GenerationKind generationKind,
            SpecifiedModelKind specifiedModelKind,
            GeneratedModelScenario generatedModelScenario,
            SetterKind setterKind,
            GeneratedModelPosition generatedModelPosition,
            string childIdentifier,
            string modelName,
            string directoryPath)
        {
            var testToken = generationKind == GenerationKind.Test ? Settings.TestNameSuffix : null;

            var modelFilePath = directoryPath + modelName + $"{testToken}.designer.cs";

            if (WriteFiles)
            {
                var content = string.Empty;

                if (generationKind == GenerationKind.Test)
                {
                    if ((generatedModelScenario == GeneratedModelScenario.Equality) ||
                        (generatedModelScenario == GeneratedModelScenario.Hashing))
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
                    else if (generatedModelScenario == GeneratedModelScenario.Comparing)
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
                    else if (specifiedModelKind == SpecifiedModelKind.Multilevel)
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
                            Invariant($"        private static readonly StringRepresentationTestScenarios<{modelName}> StringRepresentationTestScenarios = new StringRepresentationTestScenarios<{modelName}>();"),
                            string.Empty,
                            Invariant($"        private static readonly ConstructorArgumentValidationTestScenarios<{modelName}> ConstructorArgumentValidationTestScenarios = new ConstructorArgumentValidationTestScenarios<{modelName}>();"),
                            string.Empty,
                            Invariant($"        private static readonly ComparableTestScenarios<{modelName}> ComparableTestScenarios = new ComparableTestScenarios<{modelName}>();"),
                            "    }",
                            "}",
                        };

                        content = codeLines.ToNewLineDelimited();
                    }
                    else if (generatedModelScenario == GeneratedModelScenario.StringRepresentation)
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
                            Invariant($"        private static readonly StringRepresentationTestScenarios<{modelName}> StringRepresentationTestScenarios = new StringRepresentationTestScenarios<{modelName}>();"),
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
            SpecifiedModelKind specifiedModelKind,
            GeneratedModelScenario generatedModelScenario,
            SetterKind setterKind,
            GeneratedModelPosition generatedModelPosition,
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

            if (WriteFiles)
            {
                File.WriteAllText(modelFilePath, generatedCode);
            }
        }

        [SuppressMessage("Microsoft.Performance", "CA1809:AvoidExcessiveLocals", Justification = ObcSuppressBecause.CA_ALL_AgreeWithAssessmentAndNeedsRefactoring)]
        private static void GenerateModel(
            GenerationKind generationKind,
            SpecifiedModelKind specifiedModelKind,
            GeneratedModelScenario generatedModelScenario,
            SetterKind setterKind,
            GeneratedModelPosition generatedModelPosition,
            string childIdentifier,
            string modelName,
            string directoryPath)
        {
            new { generatedModelScenario }.AsArg().Must().NotBeEqualTo(GeneratedModelScenario.NotApplicable);
            new { generatedModelPosition }.AsArg().Must().NotBeEqualTo(GeneratedModelPosition.NotApplicable);

            var modelFilePath = directoryPath + modelName + ".cs";

            IReadOnlyCollection<Type> typesToWrap, additionalTypes, blacklistTypes;
            IReadOnlyCollection<TypeWrapperKind> typeWrapperKinds;

            switch (generatedModelScenario)
            {
                case GeneratedModelScenario.Comparing:
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
                var constructorAccessorModifier = generatedModelPosition == GeneratedModelPosition.Parent ? "protected" : "public";

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

                var propertyName = typeToAddAsProperty.BuildPropertyName(generatedModelPosition, childIdentifier);

                propertyStatements.Add("        [SuppressMessage(\"Microsoft.Design\", \"CA1002: DoNotExposeGenericLists\")]");
                propertyStatements.Add("        [SuppressMessage(\"Microsoft.Naming\", \"CA1720: IdentifiersShouldNotContainTypeNames\")]");
                propertyStatements.Add("        [SuppressMessage(\"Microsoft.Naming\", \"CA1726:UsePreferredTerms\")]");
                propertyStatements.Add("        [SuppressMessage(\"Microsoft.Performance\", \"CA1819:PropertiesShouldNotReturnArrays\")]");
                propertyStatements.Add("        [SuppressMessage(\"Microsoft.Usage\", \"CA2227:CollectionPropertiesShouldBeReadOnly\")]");
                propertyStatements.Add(Invariant($"        public {typeCompilableString} {propertyName} {{ get; {setterKind.ToSetterString()}}}"));
                propertyStatements.Add(string.Empty);

                if (setterKind.RequiresConstructor())
                {
                    var constructorParameterName = propertyName.ToLowerFirstCharacter();
                    constructorParameterStatements.Add(Invariant($"            {typeCompilableString} {constructorParameterName},"));

                    if (generatedModelPosition == GeneratedModelPosition.Child)
                    {
                        var constructorParentParameterName = typeToAddAsProperty.BuildPropertyName(GeneratedModelPosition.Parent, null).ToLowerFirstCharacter();
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

                if (generatedModelPosition == GeneratedModelPosition.Child)
                {
                    var parentPropertyName = typeToAddAsProperty.BuildPropertyName(GeneratedModelPosition.Parent, null);
                    equalityParentStatements.Add(Invariant($"                this.{parentPropertyName}.IsEqualTo(other.{parentPropertyName}) &&"));
                    hashingParentStatements.Add(Invariant($"                .Hash(this.{parentPropertyName})"));
                }
            }

            propertyStatements.RemoveAt(propertyStatements.Count - 1);

            var abstractStatement = generatedModelPosition == GeneratedModelPosition.Parent ? "abstract " : string.Empty;

            string baseClassName = null;
            if (generatedModelPosition == GeneratedModelPosition.Child)
            {
                baseClassName = $"{generatedModelScenario.BuildGeneratedModelName(setterKind, GeneratedModelPosition.Parent, childIdentifier: null)}";
            }

            var derivativeStatement = baseClassName == null ? string.Empty : baseClassName + ", ";

            string interfaceStatement;
            var pragmaDisableStatements = new List<string>();
            var pragmaRestoreStatements = new List<string>();
            string classLevelCodeAnalysisSuppressions = null;

            switch (generatedModelScenario)
            {
                case GeneratedModelScenario.All:
                    interfaceStatement = nameof(IModelViaCodeGen);

                    break;
                case GeneratedModelScenario.Cloning:
                    interfaceStatement = generatedModelPosition == GeneratedModelPosition.Parent
                        ? Invariant($"{nameof(IDeepCloneableViaCodeGen)}, {typeof(IEquatable<>).ToStringWithoutGenericComponent()}<{modelName}>")
                        : Invariant($"{nameof(IDeepCloneableViaCodeGen)}, {typeof(IDeclareDeepCloneMethod<>).ToStringWithoutGenericComponent()}<{modelName}>, {typeof(IEquatable<>).ToStringWithoutGenericComponent()}<{modelName}>");

                    pragmaDisableStatements.Add("#pragma warning disable CS0659");
                    pragmaDisableStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0659");

                    break;
                case GeneratedModelScenario.Equality:
                    interfaceStatement = generatedModelPosition == GeneratedModelPosition.Parent
                        ? nameof(IEquatableViaCodeGen)
                        : Invariant($"{nameof(IEquatableViaCodeGen)}, {typeof(IDeclareEqualsMethod<>).ToStringWithoutGenericComponent()}<{modelName}>");

                    pragmaDisableStatements.Add("#pragma warning disable CS0659");
                    pragmaDisableStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0659");

                    classLevelCodeAnalysisSuppressions = "    [SuppressMessage(\"Microsoft.Usage\", \"CA2218: OverrideGetHashCodeOnOverridingEquals\")]" + Environment.NewLine;
                    break;
                case GeneratedModelScenario.Hashing:
                    interfaceStatement = generatedModelPosition == GeneratedModelPosition.Parent
                        ? nameof(IHashableViaCodeGen)
                        : Invariant($"{nameof(IHashableViaCodeGen)}, {nameof(IDeclareGetHashCodeMethod)}");
                    break;
                case GeneratedModelScenario.StringRepresentation:
                    interfaceStatement = generatedModelPosition == GeneratedModelPosition.Parent
                        ? nameof(IStringRepresentableViaCodeGen)
                        : Invariant($"{nameof(IStringRepresentableViaCodeGen)}, {nameof(IDeclareToStringMethod)}");
                    break;
                case GeneratedModelScenario.Comparing:
                    interfaceStatement = generatedModelPosition == GeneratedModelPosition.Parent
                        ? nameof(IComparableViaCodeGen)
                        : Invariant($"{nameof(IComparableViaCodeGen)}, {typeof(IDeclareCompareToForRelativeSortOrderMethod<>).ToStringWithoutGenericComponent()}<{modelName}>");
                    classLevelCodeAnalysisSuppressions = "    [SuppressMessage(\"Microsoft.Design\", \"CA1036: OverrideMethodsOnComparableTypes\")]" + Environment.NewLine;
                    break;
                default:
                    throw new NotSupportedException("This generated model kind is not supported: " + generatedModelScenario);
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
                "    using System.Diagnostics.CodeAnalysis;",
                string.Empty,
                "    using FakeItEasy;",
                string.Empty,
                "    using OBeautifulCode.Assertion.Recipes;",
                "    using OBeautifulCode.Equality.Recipes;",
                "    using OBeautifulCode.Type;",
                string.Empty,
                pragmaDisableStatements.Any() ? pragmaDisableStatements.ToNewLineDelimited() : null,
                Invariant($"{classLevelCodeAnalysisSuppressions}    public {abstractStatement}partial class {modelName} : {derivativeStatement}{interfaceStatement}"),
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

            if (generatedModelScenario == GeneratedModelScenario.Cloning)
            {
                if (generatedModelPosition == GeneratedModelPosition.Parent)
                {
                    methodStatements.Add(string.Empty);
                    methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                    methodStatements.Add(Invariant($"        public abstract bool Equals({modelName} other);"));
                }
                else
                {
                    methodStatements.Add(equalsMethodCode);

                    if (generatedModelPosition == GeneratedModelPosition.Child)
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

                    var generatedModelScenarioAllName = modelName.Replace(generatedModelScenario.ToString(), nameof(GeneratedModelScenario.All));

                    var getEquivalentAllModelMethodStatements = new List<string>
                    {
                        string.Empty,
                        Invariant($"        private {modelName} DeepCloneImplementation()"),
                        Invariant($"        {{"),
                        Invariant($"            var referenceModel = A.Dummy<{generatedModelScenarioAllName}>();"),
                        string.Empty,
                        Invariant($"            var referenceModelProperties = referenceModel.GetType().GetProperties();"),
                        string.Empty,
                        Invariant($"            foreach (var referenceModelProperty in referenceModelProperties)"),
                        Invariant($"            {{"),
                        Invariant($"                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));"),
                        Invariant($"            }}"),
                        string.Empty,
                        Invariant($"            referenceModel = ({generatedModelScenarioAllName})referenceModel.GetType().GetMethod(\"DeepClone\").Invoke(referenceModel, new object[0]);"),
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
                        generatedModelPosition == GeneratedModelPosition.Standalone
                            ? Invariant($"        public {modelName} DeepClone()")
                            : Invariant($"        {modelName} {typeof(IDeclareDeepCloneMethod<>).ToStringWithoutGenericComponent()}<{modelName}>.DeepClone()"));
                    methodStatements.Add(Invariant($"        {{"));
                    methodStatements.Add(Invariant($"            var result = this.DeepCloneImplementation();"));
                    methodStatements.Add(string.Empty);
                    methodStatements.Add(Invariant($"            return result;"));
                    methodStatements.Add(Invariant($"        }}"));

                    methodStatements.AddRange(getEquivalentAllModelMethodStatements);
                }
            }
            else if ((generatedModelScenario == GeneratedModelScenario.Equality) && (generatedModelPosition != GeneratedModelPosition.Parent))
            {
                methodStatements.Add(equalsMethodCode);
            }
            else if ((generatedModelScenario == GeneratedModelScenario.Hashing) && (generatedModelPosition != GeneratedModelPosition.Parent))
            {
                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                methodStatements.Add(Invariant($"        public override int GetHashCode() => HashCodeHelper.Initialize()"));
                methodStatements.Add(new string[0].Concat(hashingParentStatements).Concat(hashingStatements).ToNewLineDelimited());
                methodStatements.Add("                .Value;");
            }
            else if ((generatedModelScenario == GeneratedModelScenario.StringRepresentation) && (generatedModelPosition != GeneratedModelPosition.Parent))
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
            else if ((generatedModelScenario == GeneratedModelScenario.Comparing) && (generatedModelPosition != GeneratedModelPosition.Parent))
            {
                if (generatedModelPosition == GeneratedModelPosition.Standalone)
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
                else if (generatedModelPosition == GeneratedModelPosition.Child)
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
                    throw new NotSupportedException("This generated model position is not supported: " + generatedModelPosition);
                }
            }

            var constructorStatements = new List<string>();
            if (setterKind.RequiresConstructor())
            {
                constructorStatements.Add("        [SuppressMessage(\"Microsoft.Design\", \"CA1002: DoNotExposeGenericLists\")]");
                constructorStatements.Add("        [SuppressMessage(\"Microsoft.Naming\", \"CA1720: IdentifiersShouldNotContainTypeNames\")]");
                constructorStatements.Add("        [SuppressMessage(\"Microsoft.Naming\", \"CA1726:UsePreferredTerms\")]");
                constructorStatements.Add(constructorDeclarationStatement);

                constructorStatements.AddRange(constructorParentParameterStatements);

                constructorParameterStatements[constructorParameterStatements.Count - 1] = constructorParameterStatements.Last().TrimEnd(',') + ")";
                constructorStatements.AddRange(constructorParameterStatements);

                if (generatedModelPosition == GeneratedModelPosition.Child)
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

            if (WriteFiles)
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
            if (WriteFiles)
            {
                File.WriteAllText(Settings.DummyFactoryFilePath, code);
            }
        }
    }
}
