﻿// --------------------------------------------------------------------------------------------------------------------
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

        private delegate void ExecuteForModelsEventHandler(ModelOrTest modelOrTest, SpecifiedModelKind specifiedModelKind, DeclaredKeyMethod declaredKeyMethod, SetterKind setterKind, HierarchyKind hierarchyKind, TypeWrapperKind typeWrapperKind, string childIdentifier, string modelName, string directoryPath);

        [Fact(Skip = "for local testing only")]
        public void GenerateModel___Should_generate_models___When_called()
        {
            // Arrange
            ExecuteForGeneratedModels(ModelOrTest.Model, ResetFile);

            ExecuteForGeneratedModels(ModelOrTest.Test, ResetFile);

            ExecuteForSpecifiedModels(ModelOrTest.Model, ResetFile);

            ExecuteForSpecifiedModels(ModelOrTest.Test, ResetFile);

            WriteDummyFactory(string.Empty);

            // Act, Assert
            ExecuteForGeneratedModels(ModelOrTest.Model, GenerateModel);
        }

        [Fact(Skip = "for local testing only")]
        public void GenerateForModel___Should_generate_model_implementation_partial_class___When_parameter_generateFor_is_ModelImplementationPartialClass()
        {
            // Arrange
            ExecuteForSpecifiedModels(ModelOrTest.Test, ResetFile);

            ExecuteForGeneratedModels(ModelOrTest.Test, ResetFile);

            WriteDummyFactory(string.Empty);

            // Act, Assert
            ExecuteForSpecifiedModels(ModelOrTest.Model, RunCodeGen);
            ExecuteForGeneratedModels(ModelOrTest.Model, RunCodeGen);
        }

        [Fact(Skip = "for local testing only")]
        public void GenerateForModel___Should_generate_dummy_factory___When_parameter_generateFor_is_ModelDummyFactorySnippet()
        {
            // Arrange
            ExecuteForSpecifiedModels(ModelOrTest.Test, ResetFile);

            ExecuteForGeneratedModels(ModelOrTest.Test, ResetFile);

            var types = CodeGeneratorTestExtensions.GetModelTypes();

            var dummyFactoryCode = GenerateDummyFactory(types);

            // Act, Assert
            WriteDummyFactory(dummyFactoryCode);
        }

        [Fact(Skip = "for local testing only")]
        public void GenerateForModel___Should_generate_model_test_partial_class___When_parameter_generateFor_is_ModelImplementationTestsPartialClassWithSerialization()
        {
            // Arrange, Act, Assert
            ExecuteForSpecifiedModels(ModelOrTest.Test, GenerateModelTest);

            ExecuteForSpecifiedModels(ModelOrTest.Test, RunCodeGen);

            ExecuteForGeneratedModels(ModelOrTest.Test, GenerateModelTest);

            ExecuteForGeneratedModels(ModelOrTest.Test, RunCodeGen);
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
            ModelOrTest modelOrTest,
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

                    var directoryPath = specifiedModelKind.GetSpecifiedModelsDirectoryPath(setterKind, modelOrTest);

                    var modelNameSuffixes = Settings.SpecifiedModelKindToModelNameSuffixMap[specifiedModelKind];

                    foreach (var modelNameSuffix in modelNameSuffixes)
                    {
                        var modelName = setterKind.BuildSpecifiedModelName(modelNameSuffix);

                        eventHandler(modelOrTest, specifiedModelKind, DeclaredKeyMethod.NotApplicable, setterKind, HierarchyKind.NotApplicable, TypeWrapperKind.NotApplicable, null, modelName, directoryPath);
                    }
                }
            }
        }

        private static void ExecuteForGeneratedModels(
            ModelOrTest modelOrTest,
            ExecuteForModelsEventHandler eventHandler)
        {
            var setterKinds = EnumExtensions.GetDefinedEnumValues<SetterKind>();

            foreach (var typeWrapperKind in Settings.TypeWrapperKinds)
            {
                foreach (var setterKind in setterKinds)
                {
                    var generatedModelDeclaredFeatures = EnumExtensions.GetDefinedEnumValues<DeclaredKeyMethod>().Where(_ => _ != DeclaredKeyMethod.NotApplicable).ToList();

                    foreach (var generatedModelDeclaredFeature in generatedModelDeclaredFeatures)
                    {
                        if ((generatedModelDeclaredFeature == DeclaredKeyMethod.Comparing) && (typeWrapperKind != TypeWrapperKind.NotWrapped))
                        {
                            break;
                        }

                        var directoryPath = modelOrTest.GetGeneratedModelsDirectoryPath(generatedModelDeclaredFeature, setterKind, typeWrapperKind);

                        var generatedModelHierarchyKinds = EnumExtensions.GetDefinedEnumValues<HierarchyKind>().Where(_ => _ != HierarchyKind.NotApplicable).ToList();

                        foreach (var generatedModelHierarchyKind in generatedModelHierarchyKinds)
                        {
                            if (generatedModelHierarchyKind == HierarchyKind.ConcreteInherited)
                            {
                                foreach (var childIdentifier in Settings.ChildIdentifiers)
                                {
                                    var modelName = generatedModelDeclaredFeature.BuildGeneratedModelName(setterKind, generatedModelHierarchyKind, typeWrapperKind, childIdentifier);

                                    eventHandler(modelOrTest, SpecifiedModelKind.NotApplicable, generatedModelDeclaredFeature, setterKind, generatedModelHierarchyKind, typeWrapperKind, childIdentifier, modelName, directoryPath);
                                }
                            }
                            else
                            {
                                var modelName = generatedModelDeclaredFeature.BuildGeneratedModelName(setterKind, generatedModelHierarchyKind, typeWrapperKind, null);

                                eventHandler(modelOrTest, SpecifiedModelKind.NotApplicable, generatedModelDeclaredFeature, setterKind, generatedModelHierarchyKind, typeWrapperKind, null, modelName, directoryPath);
                            }
                        }
                    }
                }
            }
        }

        private static void ResetFile(
            ModelOrTest modelOrTest,
            SpecifiedModelKind specifiedModelKind,
            DeclaredKeyMethod declaredKeyMethod,
            SetterKind setterKind,
            HierarchyKind hierarchyKind,
            TypeWrapperKind typeWrapperKind,
            string childIdentifier,
            string modelName,
            string directoryPath)
        {
            var modelFilePath = modelName.GetUserCodeFilePath(modelOrTest, directoryPath);

            var modelDesignerFilePath = modelName.GetDesignerFilePath(modelOrTest, directoryPath);

            if (WriteFiles)
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                if (modelOrTest == ModelOrTest.Model)
                {
                    // if this is a generated model, then write an empty model class file,
                    // specified models should not be touched because we have hand-coded model file
                    if (specifiedModelKind == SpecifiedModelKind.NotApplicable)
                    {
                        File.WriteAllBytes(modelFilePath, new byte[0]);
                    }
                }
                else if (modelOrTest == ModelOrTest.Test)
                {
                    // we have hand-coded some test class files specified models
                    // so for those we want to comment-out the file, otherwise we want to write an empty file
                    if (!File.Exists(modelFilePath))
                    {
                        File.WriteAllBytes(modelFilePath, new byte[0]);
                    }

                    if (specifiedModelKind == SpecifiedModelKind.NotApplicable)
                    {
                        File.WriteAllBytes(modelFilePath, new byte[0]);
                    }
                    else
                    {
                        modelFilePath.CommentOutFile();
                    }
                }
                else
                {
                    throw new NotSupportedException("This model or test is not supported: " + modelOrTest);
                }

                // for both generated and specified models, write an empty model/test designer file
                File.WriteAllBytes(modelDesignerFilePath, new byte[0]);
            }
        }

        private static void RunCodeGen(
            ModelOrTest modelOrTest,
            SpecifiedModelKind specifiedModelKind,
            DeclaredKeyMethod declaredKeyMethod,
            SetterKind setterKind,
            HierarchyKind hierarchyKind,
            TypeWrapperKind typeWrapperKind,
            string childIdentifier,
            string modelName,
            string directoryPath)
        {
            var modelType = modelName.GetModelType();

            var modelFilePath = modelName.GetDesignerFilePath(modelOrTest, directoryPath);

            GenerateFor generateFor;
            switch (modelOrTest)
            {
                case ModelOrTest.Model:
                    generateFor = GenerateFor.ModelImplementationPartialClass;
                    break;
                case ModelOrTest.Test:
                    generateFor = GenerateFor.ModelImplementationTestsPartialClassWithSerialization;
                    break;
                default:
                    throw new NotSupportedException("This kind is not supported: " + modelOrTest);
            }

            var generatedCode = modelType.GenerateForModel(generateFor);

            if (WriteFiles)
            {
                File.WriteAllText(modelFilePath, generatedCode, Settings.Encoding);
            }
        }

        [SuppressMessage("Microsoft.Performance", "CA1809:AvoidExcessiveLocals", Justification = ObcSuppressBecause.CA_ALL_AgreeWithAssessmentAndNeedsRefactoring)]
        private static void GenerateModel(
            ModelOrTest modelOrTest,
            SpecifiedModelKind specifiedModelKind,
            DeclaredKeyMethod declaredKeyMethod,
            SetterKind setterKind,
            HierarchyKind hierarchyKind,
            TypeWrapperKind typeWrapperKind,
            string childIdentifier,
            string modelName,
            string directoryPath)
        {
            new { declaredKeyMethod }.AsArg().Must().NotBeEqualTo(DeclaredKeyMethod.NotApplicable);
            new { hierarchyKind }.AsArg().Must().NotBeEqualTo(HierarchyKind.NotApplicable);

            var modelFilePath = directoryPath + modelName + ".cs";

            IReadOnlyCollection<Type> typesToWrap, blacklistTypes;

            switch (declaredKeyMethod)
            {
                case DeclaredKeyMethod.Comparing:
                    typesToWrap = Settings.ComparabilityTypes;
                    blacklistTypes = new Type[0];
                    break;
                default:
                    typesToWrap = Settings.TypesToWrap;
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
                var constructorAccessorModifier = hierarchyKind == HierarchyKind.AbstractBaseRoot ? "protected" : "public";

                constructorDeclarationStatement = Invariant($"        {constructorAccessorModifier} {modelName}(");
            }

            var typesToAddAsProperties = new List<Type>();

            typesToAddAsProperties.AddRange(typeWrapperKind == TypeWrapperKind.AdditionalTypes
                ? Settings.AdditionalTypes
                : typesToWrap.Select(_ => _.ToFullyWrappedType(typeWrapperKind)).Where(_ => _ != null));

            typesToAddAsProperties = typesToAddAsProperties.Where(_ => !blacklistTypes.Contains(_)).ToList();

            foreach (var typeToAddAsProperty in typesToAddAsProperties)
            {
                var typeCompilableString = typeToAddAsProperty.ToStringCompilable();

                var propertyName = typeToAddAsProperty.BuildPropertyName(hierarchyKind, childIdentifier);

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

                    if (hierarchyKind == HierarchyKind.ConcreteInherited)
                    {
                        var constructorParentParameterName = typeToAddAsProperty.BuildPropertyName(HierarchyKind.AbstractBaseRoot, null).ToLowerFirstCharacter();
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
                    var parentPropertyName = typeToAddAsProperty.BuildPropertyName(HierarchyKind.AbstractBaseRoot, null);
                    equalityParentStatements.Add(Invariant($"                this.{parentPropertyName}.IsEqualTo(other.{parentPropertyName}) &&"));
                    hashingParentStatements.Add(Invariant($"                .Hash(this.{parentPropertyName})"));
                }
            }

            propertyStatements.RemoveAt(propertyStatements.Count - 1);

            var abstractStatement = hierarchyKind == HierarchyKind.AbstractBaseRoot ? "abstract " : string.Empty;

            string baseClassName = null;
            if (hierarchyKind == HierarchyKind.ConcreteInherited)
            {
                baseClassName = $"{declaredKeyMethod.BuildGeneratedModelName(setterKind, HierarchyKind.AbstractBaseRoot, typeWrapperKind, childIdentifier: null)}";
            }

            var derivativeStatement = baseClassName == null ? string.Empty : baseClassName + ", ";

            string interfaceStatement;
            var pragmaDisableStatements = new List<string>();
            var pragmaRestoreStatements = new List<string>();
            string classLevelCodeAnalysisSuppressions = null;

            switch (declaredKeyMethod)
            {
                case DeclaredKeyMethod.NoneDeclared:
                    interfaceStatement = nameof(IModelViaCodeGen);
                    break;
                case DeclaredKeyMethod.Cloning:
                    interfaceStatement = hierarchyKind == HierarchyKind.AbstractBaseRoot
                        ? Invariant($"{nameof(IDeepCloneableViaCodeGen)}, {typeof(IEquatable<>).ToStringWithoutGenericComponent()}<{modelName}>")
                        : Invariant($"{nameof(IDeepCloneableViaCodeGen)}, {typeof(IDeclareDeepCloneMethod<>).ToStringWithoutGenericComponent()}<{modelName}>, {typeof(IEquatable<>).ToStringWithoutGenericComponent()}<{modelName}>");

                    pragmaDisableStatements.Add("#pragma warning disable CS0659");
                    pragmaDisableStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0659");

                    break;
                case DeclaredKeyMethod.Equality:
                    interfaceStatement = hierarchyKind == HierarchyKind.AbstractBaseRoot
                        ? nameof(IEquatableViaCodeGen)
                        : Invariant($"{nameof(IEquatableViaCodeGen)}, {typeof(IDeclareEqualsMethod<>).ToStringWithoutGenericComponent()}<{modelName}>");

                    pragmaDisableStatements.Add("#pragma warning disable CS0659");
                    pragmaDisableStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0661");
                    pragmaRestoreStatements.Add("#pragma warning disable CS0659");

                    classLevelCodeAnalysisSuppressions = "    [SuppressMessage(\"Microsoft.Usage\", \"CA2218: OverrideGetHashCodeOnOverridingEquals\")]" + Environment.NewLine;
                    break;
                case DeclaredKeyMethod.Hashing:
                    interfaceStatement = hierarchyKind == HierarchyKind.AbstractBaseRoot
                        ? nameof(IHashableViaCodeGen)
                        : Invariant($"{nameof(IHashableViaCodeGen)}, {nameof(IDeclareGetHashCodeMethod)}");
                    break;
                case DeclaredKeyMethod.StringRepresentation:
                    interfaceStatement = hierarchyKind == HierarchyKind.AbstractBaseRoot
                        ? nameof(IStringRepresentableViaCodeGen)
                        : Invariant($"{nameof(IStringRepresentableViaCodeGen)}, {nameof(IDeclareToStringMethod)}");
                    break;
                case DeclaredKeyMethod.Comparing:
                    interfaceStatement = hierarchyKind == HierarchyKind.AbstractBaseRoot
                        ? nameof(IComparableViaCodeGen)
                        : Invariant($"{nameof(IComparableViaCodeGen)}, {typeof(IDeclareCompareToForRelativeSortOrderMethod<>).ToStringWithoutGenericComponent()}<{modelName}>");
                    classLevelCodeAnalysisSuppressions = "    [SuppressMessage(\"Microsoft.Design\", \"CA1036: OverrideMethodsOnComparableTypes\")]" + Environment.NewLine;
                    break;
                default:
                    throw new NotSupportedException("This generated model kind is not supported: " + declaredKeyMethod);
            }

            var headerStatements = new List<string>
            {
                modelName.GetFileHeader(),
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

            if (declaredKeyMethod == DeclaredKeyMethod.Cloning)
            {
                if (hierarchyKind == HierarchyKind.AbstractBaseRoot)
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

                    var generatedModelDeclaredFeatureNoneName = modelName.Replace(declaredKeyMethod.BuildNameToken(), DeclaredKeyMethod.NoneDeclared.BuildNameToken());

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
                        hierarchyKind == HierarchyKind.Standalone
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
            else if ((declaredKeyMethod == DeclaredKeyMethod.Equality) && (hierarchyKind != HierarchyKind.AbstractBaseRoot))
            {
                methodStatements.Add(equalsMethodCode);
            }
            else if ((declaredKeyMethod == DeclaredKeyMethod.Hashing) && (hierarchyKind != HierarchyKind.AbstractBaseRoot))
            {
                methodStatements.Add(string.Empty);
                methodStatements.Add(Invariant($"        /// <inheritdoc />"));
                methodStatements.Add(Invariant($"        public override int GetHashCode() => HashCodeHelper.Initialize()"));
                methodStatements.Add(new string[0].Concat(hashingParentStatements).Concat(hashingStatements).ToNewLineDelimited());
                methodStatements.Add("                .Value;");
            }
            else if ((declaredKeyMethod == DeclaredKeyMethod.StringRepresentation) && (hierarchyKind != HierarchyKind.AbstractBaseRoot))
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
            else if ((declaredKeyMethod == DeclaredKeyMethod.Comparing) && (hierarchyKind != HierarchyKind.AbstractBaseRoot))
            {
                if (hierarchyKind == HierarchyKind.Standalone)
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
                constructorStatements.Add("        [SuppressMessage(\"Microsoft.Design\", \"CA1002: DoNotExposeGenericLists\")]");
                constructorStatements.Add("        [SuppressMessage(\"Microsoft.Naming\", \"CA1720: IdentifiersShouldNotContainTypeNames\")]");
                constructorStatements.Add("        [SuppressMessage(\"Microsoft.Naming\", \"CA1726:UsePreferredTerms\")]");
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

            if (WriteFiles)
            {
                File.WriteAllText(modelFilePath, modelCode, Settings.Encoding);
            }
        }

        private static void GenerateModelTest(
            ModelOrTest modelOrTest,
            SpecifiedModelKind specifiedModelKind,
            DeclaredKeyMethod declaredKeyMethod,
            SetterKind setterKind,
            HierarchyKind hierarchyKind,
            TypeWrapperKind typeWrapperKind,
            string childIdentifier,
            string modelName,
            string directoryPath)
        {
            var testCodeFilePath = modelName.GetUserCodeFilePath(modelOrTest, directoryPath);

            var testClassName = modelName.GetClassName(modelOrTest);

            if (specifiedModelKind != SpecifiedModelKind.NotApplicable)
            {
                testCodeFilePath.UncommentFile();
            }

            if (declaredKeyMethod == DeclaredKeyMethod.NoneDeclared)
            {
                if ((typeWrapperKind == TypeWrapperKind.Nullable) && (setterKind == SetterKind.PrivateSetters) && (hierarchyKind != HierarchyKind.AbstractBaseRoot))
                {
                    var statements = new List<string>
                    {
                        testClassName.GetFileHeader(),
                        "namespace OBeautifulCode.CodeGen.ModelObject.Test.Test",
                        "{",
                        "    using System.Diagnostics.CodeAnalysis;",
                        string.Empty,
                        "    using OBeautifulCode.CodeGen.ModelObject.Recipes;",
                        "    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;",
                        string.Empty,
                        Invariant($"    public static partial class {testClassName}"),
                        "    {",
                        "        [SuppressMessage(\"Microsoft.Performance\", \"CA1810:InitializeReferenceTypeStaticFieldsInline\", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]",
                        Invariant($"        static {testClassName}()"),
                        "        {",
                        Invariant($"            ConstructorArgumentValidationTestScenarios.AddScenario(ConstructorArgumentValidationTestScenario<{modelName}>.ConstructorCannotThrowScenario);"),
                        "        }",
                        "    }",
                        "}",
                    };

                    File.WriteAllText(testCodeFilePath, statements.ToNewLineDelimited());
                }
            }
            else if (declaredKeyMethod == DeclaredKeyMethod.StringRepresentation)
            {
                if (hierarchyKind != HierarchyKind.AbstractBaseRoot)
                {
                    var statements = new List<string>
                    {
                        testClassName.GetFileHeader(),
                        "namespace OBeautifulCode.CodeGen.ModelObject.Test.Test",
                        "{",
                        "    using System.Diagnostics.CodeAnalysis;",
                        string.Empty,
                        "    using OBeautifulCode.CodeGen.ModelObject.Recipes;",
                        "    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;",
                        string.Empty,
                        Invariant($"    public static partial class {testClassName}"),
                        "    {",
                        "        [SuppressMessage(\"Microsoft.Performance\", \"CA1810:InitializeReferenceTypeStaticFieldsInline\", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]",
                        Invariant($"        static {testClassName}()"),
                        "        {",
                        Invariant($"            StringRepresentationTestScenarios.AddScenario(StringRepresentationTestScenario<{modelName}>.ForceGeneratedTestsToPassAndWriteMyOwnScenario);"),
                        "        }",
                        "    }",
                        "}",
                    };

                    File.WriteAllText(testCodeFilePath, statements.ToNewLineDelimited());
                }
            }
            else if ((declaredKeyMethod == DeclaredKeyMethod.Equality) || (declaredKeyMethod == DeclaredKeyMethod.Hashing))
            {
                var equalityTestFields = modelName.GetModelType().GenerateEqualityTestFieldsInUserCode();

                var constructorStatements = new List<string>();

                if (hierarchyKind == HierarchyKind.AbstractBaseRoot)
                {
                    constructorStatements.Add(string.Empty);
                    constructorStatements.Add("            var properties = ObjectThatIsEqualToButNotTheSameAsReferenceObject.GetType().GetProperties();");
                    constructorStatements.Add(string.Empty);
                    constructorStatements.Add("            foreach (var property in properties)");
                    constructorStatements.Add("            {");
                    constructorStatements.Add("                property.DeclaringType.GetProperty(property.Name).SetValue(ObjectThatIsEqualToButNotTheSameAsReferenceObject, property.GetValue(ReferenceObjectForEquatableTestScenarios));");
                    constructorStatements.Add("            }");
                    constructorStatements.Add(string.Empty);
                }

                var statements = new List<string>
                {
                    testClassName.GetFileHeader(),
                    "namespace OBeautifulCode.CodeGen.ModelObject.Test.Test",
                    "{",
                    "    using System;",
                    "    using System.Diagnostics.CodeAnalysis;",
                    string.Empty,
                    "    using FakeItEasy;",
                    string.Empty,
                    "    using OBeautifulCode.AutoFakeItEasy;",
                    "    using OBeautifulCode.CodeGen.ModelObject.Recipes;",
                    "    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;",
                    "    using OBeautifulCode.Equality.Recipes;",
                    string.Empty,
                    Invariant($"    public static partial class {testClassName}"),
                    "    {",
                    equalityTestFields,
                    string.Empty,
                    "        [SuppressMessage(\"Microsoft.Performance\", \"CA1810:InitializeReferenceTypeStaticFieldsInline\", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]",
                    Invariant($"        static {testClassName}()"),
                    Invariant($"        {{{constructorStatements.ToNewLineDelimited()}"),
                    Invariant($"            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);"),
                    "        }",
                    "    }",
                    "}",
                };

                File.WriteAllText(testCodeFilePath, statements.ToNewLineDelimited());
            }
            else if (declaredKeyMethod == DeclaredKeyMethod.Comparing)
            {
                var scenarioStatements = new List<string>();

                if (setterKind == SetterKind.PrivateSetters)
                {
                    if (hierarchyKind == HierarchyKind.ConcreteInherited)
                    {
                        var otherChildIdentifier = childIdentifier == "1" ? "2" : "1";
                        var otherChildModelName = modelName.Replace(childIdentifier, otherChildIdentifier);

                        scenarioStatements.Add(Invariant($"                ReferenceObject = new {modelName}(5, 4),"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] {{ new {modelName}(4, 5), new {modelName}(0, 9), new {modelName}(5, 4) }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreLessThanReferenceObject = new[] {{ new {modelName}(8, 0), new {modelName}(-5, -4), new {modelName}(3, 4) }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreGreaterThanReferenceObject = new[] {{ new {modelName}(9, 1), new {modelName}(5, 5), new {modelName}(-50, 100) }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] {{ 1, \"dummy - string\", new {otherChildModelName}(5, 4) }},"));
                    }
                    else if (hierarchyKind == HierarchyKind.AbstractBaseRoot)
                    {
                        var childModelName1 = modelName.Replace("Parent", "Child1");
                        var childModelName2 = modelName.Replace("Parent", "Child2");

                        scenarioStatements.Add(Invariant($"                ReferenceObject = new {childModelName1}(5, 4),"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] {{ new {childModelName1}(4, 5), new {childModelName1}(0, 9), new {childModelName1}(5, 4) }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreLessThanReferenceObject = new[] {{ new {childModelName1}(8, 0), new {childModelName1}(-5, -4), new {childModelName1}(3, 4) }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreGreaterThanReferenceObject = new[] {{ new {childModelName1}(9, 1), new {childModelName1}(5, 5), new {childModelName1}(-50, 100) }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[] {{ new {childModelName2}(5, 4) }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] {{ 1, \"dummy - string\" }},"));
                    }
                    else if (hierarchyKind == HierarchyKind.Standalone)
                    {
                        var childModelName1 = modelName + "Child1";
                        var childModelName2 = modelName + "Child2";

                        scenarioStatements.Add(Invariant($"                ReferenceObject = new {modelName}(5),"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] {{ new {modelName}(5) }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreLessThanReferenceObject = new[] {{ new {modelName}(4), new {modelName}(-5), new {modelName}(0) }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreGreaterThanReferenceObject = new[] {{ new {modelName}(6), new {modelName}(10) }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] {{ 1, \"dummy - string\", new {childModelName1}(5, 4), new {childModelName2}(5, 4) }},"));
                    }
                    else
                    {
                        throw new NotSupportedException("This hierarchy kind is not supported: " + hierarchyKind);
                    }
                }
                else if (setterKind == SetterKind.PublicSetters)
                {
                    if (hierarchyKind == HierarchyKind.ConcreteInherited)
                    {
                        var otherChildIdentifier = childIdentifier == "1" ? "2" : "1";
                        var otherChildModelName = modelName.Replace(childIdentifier, otherChildIdentifier);

                        scenarioStatements.Add(Invariant($"                ReferenceObject = new {modelName} {{ Child{childIdentifier}IntProperty = 5, ParentIntProperty = 4 }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] {{ new {modelName} {{ Child{childIdentifier}IntProperty = 4, ParentIntProperty = 5 }}, new {modelName} {{ Child{childIdentifier}IntProperty = 0, ParentIntProperty = 9 }}, new {modelName} {{ Child{childIdentifier}IntProperty = 5, ParentIntProperty = 4 }} }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreLessThanReferenceObject = new[] {{ new {modelName} {{ Child{childIdentifier}IntProperty = 8, ParentIntProperty = 0 }}, new {modelName} {{ Child{childIdentifier}IntProperty = -5, ParentIntProperty = -4 }}, new {modelName} {{ Child{childIdentifier}IntProperty = 3, ParentIntProperty = 4 }} }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreGreaterThanReferenceObject = new[] {{ new {modelName} {{ Child{childIdentifier}IntProperty = 9, ParentIntProperty = 1 }}, new {modelName} {{ Child{childIdentifier}IntProperty = 5, ParentIntProperty = 5 }}, new {modelName} {{ Child{childIdentifier}IntProperty = -50, ParentIntProperty = 100 }} }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] {{ 1, \"dummy-string\", new {otherChildModelName} {{ Child{otherChildIdentifier}IntProperty = 5, ParentIntProperty = 4 }} }},"));
                    }
                    else if (hierarchyKind == HierarchyKind.AbstractBaseRoot)
                    {
                        var childModelName1 = modelName.Replace("Parent", "Child1");
                        var childModelName2 = modelName.Replace("Parent", "Child2");

                        scenarioStatements.Add(Invariant($"                ReferenceObject = new {childModelName1} {{ Child1IntProperty = 5, ParentIntProperty = 4 }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] {{ new {childModelName1} {{ Child1IntProperty = 4, ParentIntProperty = 5 }}, new {childModelName1} {{ Child1IntProperty = 0, ParentIntProperty = 9 }}, new {childModelName1} {{ Child1IntProperty = 5, ParentIntProperty = 4 }} }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreLessThanReferenceObject = new[] {{ new {childModelName1} {{ Child1IntProperty = 8, ParentIntProperty = 0 }}, new {childModelName1} {{ Child1IntProperty = -5, ParentIntProperty = -4 }}, new {childModelName1} {{ Child1IntProperty = 3, ParentIntProperty = 4 }} }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreGreaterThanReferenceObject = new[] {{ new {childModelName1} {{ Child1IntProperty = 9, ParentIntProperty = 1 }}, new {childModelName1} {{ Child1IntProperty = 5, ParentIntProperty = 5 }}, new {childModelName1} {{ Child1IntProperty = -50, ParentIntProperty = 100 }} }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[] {{ new {childModelName2} {{ Child2IntProperty = 5, ParentIntProperty = 4 }} }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] {{ 1, \"dummy-string\" }},"));
                    }
                    else if (hierarchyKind == HierarchyKind.Standalone)
                    {
                        var childModelName1 = modelName + "Child1";
                        var childModelName2 = modelName + "Child2";

                        scenarioStatements.Add(Invariant($"                ReferenceObject = new {modelName} {{ IntProperty = 5 }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] {{ new {modelName} {{ IntProperty = 5 }} }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreLessThanReferenceObject = new[] {{ new {modelName} {{ IntProperty = 4 }}, new {modelName} {{ IntProperty = -5 }} }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreGreaterThanReferenceObject = new[] {{ new {modelName} {{ IntProperty = 6 }}, new {modelName} {{ IntProperty = 50 }} }},"));
                        scenarioStatements.Add(Invariant($"                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] {{ 1, \"dummy-string\", new {childModelName1} {{ Child1IntProperty = 5, ParentIntProperty = 4 }}, new {childModelName2} {{ Child2IntProperty = 5, ParentIntProperty = 4 }} }},"));
                    }
                    else
                    {
                        throw new NotSupportedException("This hierarchy kind is not supported: " + hierarchyKind);
                    }
                }
                else
                {
                    throw new NotSupportedException("this setter kind is not supported: " + setterKind);
                }

                var statements = new List<string>
                {
                    testClassName.GetFileHeader(),
                    "namespace OBeautifulCode.CodeGen.ModelObject.Test.Test",
                    "{",
                    "    using System.Diagnostics.CodeAnalysis;",
                    string.Empty,
                    "    using OBeautifulCode.CodeGen.ModelObject.Recipes;",
                    "    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;",
                    string.Empty,
                    Invariant($"    public static partial class {testClassName}"),
                    "    {",
                    string.Empty,
                    "        [SuppressMessage(\"Microsoft.Performance\", \"CA1810:InitializeReferenceTypeStaticFieldsInline\", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]",
                    Invariant($"        static {testClassName}()"),
                    "        {",
                    Invariant($"            ComparableTestScenarios.AddScenario(new ComparableTestScenario<{modelName}>"),
                    "            {",
                    "                Name = \"Scenario 1\",",
                    scenarioStatements.ToNewLineDelimited(),
                    "            });",
                    "        }",
                    "    }",
                    "}",
                };

                File.WriteAllText(testCodeFilePath, statements.ToNewLineDelimited());
            }
        }

        private static string GenerateDummyFactory(
            IReadOnlyCollection<Type> types)
        {
            var snippetsToken = "<<SNIPPETS_HERE>>";

            var statements = new List<string>
            {
                "DummyFactory".GetFileHeader(),
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
                File.WriteAllText(Settings.DummyFactoryFilePath, code, Settings.Encoding);
            }
        }
    }
}
