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

        private delegate void ExecuteForModelsEventHandler(GenerationKind generationKind, SpecifiedModelKind specifiedModelKind, GeneratedModelDeclaredFeature generatedModelDeclaredFeature, SetterKind setterKind, GeneratedModelHierarchyKind generatedModelHierarchyKind, string childIdentifier, string modelName, string directoryPath);

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

        [Fact]
        public void GenerateForModel___Should_throw_NotSupportedException___When_model_type_not_supported()
        {
            // Arrange
            var tests = new[]
            {
                new { Type = typeof(List<>), ExpectedExceptionMessageContains = "it is an open type" },
                new { Type = typeof(List<>).MakeArrayType(), ExpectedExceptionMessageContains = "it is an open type" },
                new { Type = typeof(List<>).MakeGenericType(typeof(List<>)), ExpectedExceptionMessageContains = "it is an open type" },
                new { Type = typeof(Dictionary<,>).GetGenericArguments()[0], ExpectedExceptionMessageContains = "it is an open type" },
                new { Type = typeof(DoesNotImplementInterfaceThatIndicatesCodeGenIsRequired), ExpectedExceptionMessageContains = "it does not implement one of the following interfaces" },
                new { Type = typeof(List<string>), ExpectedExceptionMessageContains = "it does not implement one of the following interfaces" },
                new { Type = typeof(IList<string>), ExpectedExceptionMessageContains = "it does not implement one of the following interfaces" },
                new { Type = typeof(IBad), ExpectedExceptionMessageContains = "it is a value type or interface type" },
                new { Type = typeof(IGenericInterface<string>), ExpectedExceptionMessageContains = "it is a value type or interface type" },
                new { Type = typeof(Struct), ExpectedExceptionMessageContains = "it is a value type or interface type" },
                new { Type = typeof(GenericStruct<string>), ExpectedExceptionMessageContains = "it is a value type or interface type" },
                new { Type = typeof(GenericClass<string>), ExpectedExceptionMessageContains = "it is a generic type" },
                new { Type = typeof(GenericClass<IReadOnlyList<string>>), ExpectedExceptionMessageContains = "it is a generic type" },
                new { Type = typeof(ConcreteBaseClass), ExpectedExceptionMessageContains = "it is a base class of one or more other classes but it is not abstract" },
                new { Type = typeof(AbstractClassWithConcreteBaseClass), ExpectedExceptionMessageContains = "it is abstract but has a concrete type in its inheritance path" },
                new { Type = typeof(ConcreteClassWithConcreteBaseClass), ExpectedExceptionMessageContains = "it is concrete and has a concrete type in its inheritance path" },
                new { Type = typeof(MissingCodeGenInterfacesGrandchild1), ExpectedExceptionMessageContains = "there is a type in its inheritance path (MissingCodeGenInterfacesParent1) that does not implement all of the following code gen interfaces which are implemented by this type: IDeepCloneableViaCodeGen, IEquatableViaCodeGen, IHashableViaCodeGen, IModelViaCodeGen, IStringRepresentableViaCodeGen" },
                new { Type = typeof(MissingCodeGenInterfacesGrandchild2), ExpectedExceptionMessageContains = "there is a type in its inheritance path (MissingCodeGenInterfacesParent2) that does not implement all of the following code gen interfaces which are implemented by this type: IDeepCloneableViaCodeGen, IEquatableViaCodeGen, IStringRepresentableViaCodeGen" },
                new { Type = typeof(GetterOnlyProperties1), ExpectedExceptionMessageContains = "it contains the following getter-only properties: Property1" },
                new { Type = typeof(GetterOnlyProperties2), ExpectedExceptionMessageContains = "it contains the following getter-only properties: Property1, Property2" },
                new { Type = typeof(GetterOnlyProperties3), ExpectedExceptionMessageContains = "it contains the following getter-only properties: Property1, Property2" },
                new { Type = typeof(GetterOnlyProperties4), ExpectedExceptionMessageContains = "it contains the following getter-only properties: Property1" },
                new { Type = typeof(NotPrivateNotPublicProperties1), ExpectedExceptionMessageContains = "it contains properties of concern are neither private nor public; only private and public setters are supported" },
                new { Type = typeof(NotPrivateNotPublicProperties2), ExpectedExceptionMessageContains = "it contains properties of concern are neither private nor public; only private and public setters are supported" },
                new { Type = typeof(NotPrivateNotPublicProperties3), ExpectedExceptionMessageContains = "it contains properties of concern are neither private nor public; only private and public setters are supported" },
                new { Type = typeof(MixedAccessProperties1), ExpectedExceptionMessageContains = "it contains properties of concern with inconsistent access modifiers on its setters" },
                new { Type = typeof(MixedAccessProperties2), ExpectedExceptionMessageContains = "it contains properties of concern with inconsistent access modifiers on its setters" },
                new { Type = typeof(MixedAccessProperties3), ExpectedExceptionMessageContains = "it contains properties of concern with inconsistent access modifiers on its setters" },
                new { Type = typeof(DictionaryKeyedOnDateTimeProperty1), ExpectedExceptionMessageContains = "it contains one or more properties that are OR have within their generic argument tree or array element type a Dictionary that is keyed on DateTime" },
                new { Type = typeof(DictionaryKeyedOnDateTimeProperty2), ExpectedExceptionMessageContains = "it contains one or more properties that are OR have within their generic argument tree or array element type a Dictionary that is keyed on DateTime" },
                new { Type = typeof(DictionaryKeyedOnDateTimeProperty3), ExpectedExceptionMessageContains = "it contains one or more properties that are OR have within their generic argument tree or array element type a Dictionary that is keyed on DateTime" },
                new { Type = typeof(DictionaryKeyedOnDateTimeProperty4), ExpectedExceptionMessageContains = "it contains one or more properties that are OR have within their generic argument tree or array element type a Dictionary that is keyed on DateTime" },
                new { Type = typeof(EnumerableKeyedOnDateTimeProperty1), ExpectedExceptionMessageContains = "it contains one or more properties that are OR have within their generic argument tree or array element type an IEnumerable<T>" },
                new { Type = typeof(EnumerableKeyedOnDateTimeProperty2), ExpectedExceptionMessageContains = "it contains one or more properties that are OR have within their generic argument tree or array element type an IEnumerable<T>" },
                new { Type = typeof(EnumerableKeyedOnDateTimeProperty3), ExpectedExceptionMessageContains = "it contains one or more properties that are OR have within their generic argument tree or array element type an IEnumerable<T>" },
                new { Type = typeof(EnumerableKeyedOnDateTimeProperty4), ExpectedExceptionMessageContains = "it contains one or more properties that are OR have within their generic argument tree or array element type an IEnumerable<T>" },
                new { Type = typeof(AbstractDeclaredCompareTo), ExpectedExceptionMessageContains = "it is an abstract class that implements one or more of the IDeclare... interfaces" },
                new { Type = typeof(AbstractDeclaredDeepClone), ExpectedExceptionMessageContains = "it is an abstract class that implements one or more of the IDeclare... interfaces" },
                new { Type = typeof(AbstractDeclaredEquals), ExpectedExceptionMessageContains = "it is an abstract class that implements one or more of the IDeclare... interfaces" },
                new { Type = typeof(AbstractDeclaredGetHashCode), ExpectedExceptionMessageContains = "it is an abstract class that implements one or more of the IDeclare... interfaces" },
                new { Type = typeof(AbstractDeclaredToString), ExpectedExceptionMessageContains = "it is an abstract class that implements one or more of the IDeclare... interfaces" },
                new { Type = typeof(ComparableViaCodeGenWithoutDeclaredCompareTo), ExpectedExceptionMessageContains = "it is a concrete class that implements IComparableViaCodeGen but does not implement IDeclareCompareToForRelativeSortOrderMethod" },
                new { Type = typeof(AbstractClassWithConstructor1), ExpectedExceptionMessageContains = "there is at least one public constructor, but the class is abstract" },
                new { Type = typeof(AbstractClassWithConstructor2), ExpectedExceptionMessageContains = "there is at least one public constructor, but the class is abstract" },
                new { Type = typeof(ConstructorParameterWithoutMatchingProperty1), ExpectedExceptionMessageContains = "none of its public constructors have parameters where all parameters have a matching property by name and type" },
                new { Type = typeof(ConstructorParameterWithoutMatchingProperty2), ExpectedExceptionMessageContains = "none of its public constructors have parameters where all parameters have a matching property by name and type" },
                new { Type = typeof(ConstructorParameterWithoutMatchingProperty3), ExpectedExceptionMessageContains = "none of its public constructors have parameters where all parameters have a matching property by name and type" },
                new { Type = typeof(ConstructorParameterWithoutMatchingProperty4), ExpectedExceptionMessageContains = "none of its public constructors have parameters where all parameters have a matching property by name and type" },
                new { Type = typeof(MultipleCandidateConstructors1), ExpectedExceptionMessageContains = "there are 2 public constructors having 3 parameters that have a matching property by name type" },
                new { Type = typeof(MultipleCandidateConstructors2), ExpectedExceptionMessageContains = "there are 3 public constructors having 3 parameters that have a matching property by name type" },
                new { Type = typeof(DefaultConstructorWithPrivateSetters), ExpectedExceptionMessageContains = "the constructor to use is the default constructor but there are properties declared on the type that have private setters" },
                new { Type = typeof(ParameterizedConstructorWithPublicSetters), ExpectedExceptionMessageContains = "the constructor to use is parameterized but there are properties declared on the type with a public setter" },
                new { Type = typeof(DeclaredPropertyNotInConstructor), ExpectedExceptionMessageContains = "the constructor to use is parameterized but one or more of the properties declared on the type does not match a parameter in that constructor" },
            };

            // Act
            var actuals = tests.Select(_ => Record.Exception(() => _.Type.GenerateForModel(GenerateFor.AllPossibleCode))).ToList();

            // Assert
            for (int x = 0; x < tests.Length; x++)
            {
                actuals[x].AsTest().Must().BeOfType<NotSupportedException>();
                actuals[x].Message.AsTest().Must().ContainString(tests[x].ExpectedExceptionMessageContains);
            }
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

                        eventHandler(generationKind, specifiedModelKind, GeneratedModelDeclaredFeature.NotApplicable, setterKind, GeneratedModelHierarchyKind.NotApplicable, TypeWrapperKind.NotApplicable, null, modelName, directoryPath);
                    }
                }
            }
        }

        private static void ExecuteForGeneratedModels(
            GenerationKind generationKind,
            ExecuteForModelsEventHandler eventHandler)
        {
            var setterKinds = EnumExtensions.GetDefinedEnumValues<SetterKind>();

            foreach (var typeWrapperKind in Settings.TypeWrapperKinds)
            {
                foreach (var setterKind in setterKinds)
                {
                    var generatedModelDeclaredFeatures = EnumExtensions.GetDefinedEnumValues<GeneratedModelDeclaredFeature>().Where(_ => _ != GeneratedModelDeclaredFeature.NotApplicable).ToList();

                    foreach (var generatedModelDeclaredFeature in generatedModelDeclaredFeatures)
                    {
                        if ((generatedModelDeclaredFeature == GeneratedModelDeclaredFeature.Comparing) && (typeWrapperKind != TypeWrapperKind.NotWrapped))
                        {
                            break;
                        }

                        var directoryPath = generationKind.GetGeneratedModelsDirectoryPath(generatedModelDeclaredFeature, setterKind, typeWrapperKind);

                        var generatedModelHierarchyKinds = EnumExtensions.GetDefinedEnumValues<GeneratedModelHierarchyKind>().Where(_ => _ != GeneratedModelHierarchyKind.NotApplicable).ToList();

                        foreach (var generatedModelHierarchyKind in generatedModelHierarchyKinds)
                        {
                            if (generatedModelHierarchyKind == GeneratedModelHierarchyKind.ConcreteInherited)
                            {
                                foreach (var childIdentifier in Settings.ChildIdentifiers)
                                {
                                    var modelName = generatedModelDeclaredFeature.BuildGeneratedModelName(setterKind, generatedModelHierarchyKind, typeWrapperKind, childIdentifier);

                                    eventHandler(generationKind, SpecifiedModelKind.NotApplicable, generatedModelDeclaredFeature, setterKind, generatedModelHierarchyKind, typeWrapperKind, childIdentifier, modelName, directoryPath);
                                }
                            }
                            else
                            {
                                var modelName = generatedModelDeclaredFeature.BuildGeneratedModelName(setterKind, generatedModelHierarchyKind, typeWrapperKind, null);

                                eventHandler(generationKind, SpecifiedModelKind.NotApplicable, generatedModelDeclaredFeature, setterKind, generatedModelHierarchyKind, typeWrapperKind, null, modelName, directoryPath);
                            }
                        }
                    }
                }
            }
        }

        private static void ResetFile(
            GenerationKind generationKind,
            SpecifiedModelKind specifiedModelKind,
            GeneratedModelDeclaredFeature generatedModelDeclaredFeature,
            SetterKind setterKind,
            GeneratedModelHierarchyKind generatedModelHierarchyKind,
            TypeWrapperKind typeWrapperKind,
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
                    if ((generatedModelDeclaredFeature == GeneratedModelDeclaredFeature.Equality) ||
                        (generatedModelDeclaredFeature == GeneratedModelDeclaredFeature.Hashing))
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
                    else if (generatedModelDeclaredFeature == GeneratedModelDeclaredFeature.Comparing)
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
                    else if (generatedModelDeclaredFeature == GeneratedModelDeclaredFeature.StringRepresentation)
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
            GeneratedModelDeclaredFeature generatedModelDeclaredFeature,
            SetterKind setterKind,
            GeneratedModelHierarchyKind generatedModelHierarchyKind,
            TypeWrapperKind typeWrapperKind,
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
            GeneratedModelDeclaredFeature generatedModelDeclaredFeature,
            SetterKind setterKind,
            GeneratedModelHierarchyKind generatedModelHierarchyKind,
            TypeWrapperKind typeWrapperKind,
            string childIdentifier,
            string modelName,
            string directoryPath)
        {
            new { generatedModelDeclaredFeature }.AsArg().Must().NotBeEqualTo(GeneratedModelDeclaredFeature.NotApplicable);
            new { generatedModelHierarchyKind }.AsArg().Must().NotBeEqualTo(GeneratedModelHierarchyKind.NotApplicable);

            var modelFilePath = directoryPath + modelName + ".cs";

            IReadOnlyCollection<Type> typesToWrap, additionalTypes, blacklistTypes;

            switch (generatedModelDeclaredFeature)
            {
                case GeneratedModelDeclaredFeature.Comparing:
                    typesToWrap = Settings.ComparabilityTypes;
                    additionalTypes = new Type[0];
                    blacklistTypes = new Type[0];
                    break;
                default:
                    typesToWrap = Settings.TypesToWrap;
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
                var constructorAccessorModifier = generatedModelHierarchyKind == GeneratedModelHierarchyKind.AbstractBaseRoot ? "protected" : "public";

                constructorDeclarationStatement = Invariant($"        {constructorAccessorModifier} {modelName}(");
            }

            var typesToAddAsProperties = new List<Type>();

            typesToAddAsProperties.AddRange(typesToWrap.Select(_ => _.ToFullyWrappedType(typeWrapperKind)).Where(_ => _ != null));

            typesToAddAsProperties.AddRange(additionalTypes);

            typesToAddAsProperties = typesToAddAsProperties.Where(_ => !blacklistTypes.Contains(_)).ToList();

            foreach (var typeToAddAsProperty in typesToAddAsProperties)
            {
                var typeCompilableString = typeToAddAsProperty.ToStringCompilable();

                var propertyName = typeToAddAsProperty.BuildPropertyName(generatedModelHierarchyKind, childIdentifier);

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

                    if (generatedModelHierarchyKind == GeneratedModelHierarchyKind.ConcreteInherited)
                    {
                        var constructorParentParameterName = typeToAddAsProperty.BuildPropertyName(GeneratedModelHierarchyKind.AbstractBaseRoot, null).ToLowerFirstCharacter();
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

                if (generatedModelHierarchyKind == GeneratedModelHierarchyKind.ConcreteInherited)
                {
                    var parentPropertyName = typeToAddAsProperty.BuildPropertyName(GeneratedModelHierarchyKind.AbstractBaseRoot, null);
                    equalityParentStatements.Add(Invariant($"                this.{parentPropertyName}.IsEqualTo(other.{parentPropertyName}) &&"));
                    hashingParentStatements.Add(Invariant($"                .Hash(this.{parentPropertyName})"));
                }
            }

            propertyStatements.RemoveAt(propertyStatements.Count - 1);

            var abstractStatement = generatedModelHierarchyKind == GeneratedModelHierarchyKind.AbstractBaseRoot ? "abstract " : string.Empty;

            string baseClassName = null;
            if (generatedModelHierarchyKind == GeneratedModelHierarchyKind.ConcreteInherited)
            {
                baseClassName = $"{generatedModelDeclaredFeature.BuildGeneratedModelName(setterKind, GeneratedModelHierarchyKind.AbstractBaseRoot, typeWrapperKind, childIdentifier: null)}";
            }

            var derivativeStatement = baseClassName == null ? string.Empty : baseClassName + ", ";

            string interfaceStatement;
            var pragmaDisableStatements = new List<string>();
            var pragmaRestoreStatements = new List<string>();
            string classLevelCodeAnalysisSuppressions = null;

            switch (generatedModelDeclaredFeature)
            {
                case GeneratedModelDeclaredFeature.NoneDeclared:
                    interfaceStatement = nameof(IModelViaCodeGen);
                    break;
                case GeneratedModelDeclaredFeature.Cloning:
                    interfaceStatement = generatedModelHierarchyKind == GeneratedModelHierarchyKind.AbstractBaseRoot
                        ? Invariant($"{nameof(IDeepCloneableViaCodeGen)}, {typeof(IEquatable<>).ToStringWithoutGenericComponent()}<{modelName}>")
                        : Invariant($"{nameof(IDeepCloneableViaCodeGen)}, {typeof(IDeclareDeepCloneMethod<>).ToStringWithoutGenericComponent()}<{modelName}>, {typeof(IEquatable<>).ToStringWithoutGenericComponent()}<{modelName}>");

                    pragmaDisableStatements.Add("#pragma warning disable CS0659");
                    pragmaDisableStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0659");

                    break;
                case GeneratedModelDeclaredFeature.Equality:
                    interfaceStatement = generatedModelHierarchyKind == GeneratedModelHierarchyKind.AbstractBaseRoot
                        ? nameof(IEquatableViaCodeGen)
                        : Invariant($"{nameof(IEquatableViaCodeGen)}, {typeof(IDeclareEqualsMethod<>).ToStringWithoutGenericComponent()}<{modelName}>");

                    pragmaDisableStatements.Add("#pragma warning disable CS0659");
                    pragmaDisableStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0659");

                    classLevelCodeAnalysisSuppressions = "    [SuppressMessage(\"Microsoft.Usage\", \"CA2218: OverrideGetHashCodeOnOverridingEquals\")]" + Environment.NewLine;
                    break;
                case GeneratedModelDeclaredFeature.Hashing:
                    interfaceStatement = generatedModelHierarchyKind == GeneratedModelHierarchyKind.AbstractBaseRoot
                        ? nameof(IHashableViaCodeGen)
                        : Invariant($"{nameof(IHashableViaCodeGen)}, {nameof(IDeclareGetHashCodeMethod)}");
                    break;
                case GeneratedModelDeclaredFeature.StringRepresentation:
                    interfaceStatement = generatedModelHierarchyKind == GeneratedModelHierarchyKind.AbstractBaseRoot
                        ? nameof(IStringRepresentableViaCodeGen)
                        : Invariant($"{nameof(IStringRepresentableViaCodeGen)}, {nameof(IDeclareToStringMethod)}");
                    break;
                case GeneratedModelDeclaredFeature.Comparing:
                    interfaceStatement = generatedModelHierarchyKind == GeneratedModelHierarchyKind.AbstractBaseRoot
                        ? nameof(IComparableViaCodeGen)
                        : Invariant($"{nameof(IComparableViaCodeGen)}, {typeof(IDeclareCompareToForRelativeSortOrderMethod<>).ToStringWithoutGenericComponent()}<{modelName}>");
                    classLevelCodeAnalysisSuppressions = "    [SuppressMessage(\"Microsoft.Design\", \"CA1036: OverrideMethodsOnComparableTypes\")]" + Environment.NewLine;
                    break;
                default:
                    throw new NotSupportedException("This generated model kind is not supported: " + generatedModelDeclaredFeature);
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

            if (generatedModelDeclaredFeature == GeneratedModelDeclaredFeature.Cloning)
            {
                if (generatedModelHierarchyKind == GeneratedModelHierarchyKind.AbstractBaseRoot)
                {
                    methodStatements.Add(string.Empty);
                    methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                    methodStatements.Add(Invariant($"        public abstract bool Equals({modelName} other);"));
                }
                else
                {
                    methodStatements.Add(equalsMethodCode);

                    if (generatedModelHierarchyKind == GeneratedModelHierarchyKind.ConcreteInherited)
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

                    var generatedModelDeclaredFeatureNoneName = modelName.Replace(generatedModelDeclaredFeature.BuildNameToken(), GeneratedModelDeclaredFeature.NoneDeclared.BuildNameToken());

                    var getEquivalentAllModelMethodStatements = new List<string>
                    {
                        string.Empty,
                        Invariant($"        private {modelName} DeepCloneImplementation()"),
                        Invariant($"        {{"),
                        Invariant($"            var referenceModel = A.Dummy<{generatedModelDeclaredFeatureNoneName}>();"),
                        string.Empty,
                        Invariant($"            var referenceModelProperties = referenceModel.GetType().GetProperties();"),
                        string.Empty,
                        Invariant($"            foreach (var referenceModelProperty in referenceModelProperties)"),
                        Invariant($"            {{"),
                        Invariant($"                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));"),
                        Invariant($"            }}"),
                        string.Empty,
                        Invariant($"            referenceModel = ({generatedModelDeclaredFeatureNoneName})referenceModel.GetType().GetMethod(\"DeepClone\").Invoke(referenceModel, new object[0]);"),
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
                        generatedModelHierarchyKind == GeneratedModelHierarchyKind.Standalone
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
            else if ((generatedModelDeclaredFeature == GeneratedModelDeclaredFeature.Equality) && (generatedModelHierarchyKind != GeneratedModelHierarchyKind.AbstractBaseRoot))
            {
                methodStatements.Add(equalsMethodCode);
            }
            else if ((generatedModelDeclaredFeature == GeneratedModelDeclaredFeature.Hashing) && (generatedModelHierarchyKind != GeneratedModelHierarchyKind.AbstractBaseRoot))
            {
                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                methodStatements.Add(Invariant($"        public override int GetHashCode() => HashCodeHelper.Initialize()"));
                methodStatements.Add(new string[0].Concat(hashingParentStatements).Concat(hashingStatements).ToNewLineDelimited());
                methodStatements.Add("                .Value;");
            }
            else if ((generatedModelDeclaredFeature == GeneratedModelDeclaredFeature.StringRepresentation) && (generatedModelHierarchyKind != GeneratedModelHierarchyKind.AbstractBaseRoot))
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
            else if ((generatedModelDeclaredFeature == GeneratedModelDeclaredFeature.Comparing) && (generatedModelHierarchyKind != GeneratedModelHierarchyKind.AbstractBaseRoot))
            {
                if (generatedModelHierarchyKind == GeneratedModelHierarchyKind.Standalone)
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
                else if (generatedModelHierarchyKind == GeneratedModelHierarchyKind.ConcreteInherited)
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
                    throw new NotSupportedException("This generated model hierarchy kind is not supported: " + generatedModelHierarchyKind);
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

                if (generatedModelHierarchyKind == GeneratedModelHierarchyKind.ConcreteInherited)
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
