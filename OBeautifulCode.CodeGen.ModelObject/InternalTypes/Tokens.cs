// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tokens.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;

    /// <summary>
    /// Replacement tokens.
    /// </summary>
    internal static class Tokens
    {
        /// <summary>
        /// The name of the model type when used in code.
        /// </summary>
        public const string ModelTypeNameInCodeToken = "[model-type-name-in-code-here]";

        /// <summary>
        /// The name of the model type when used in XML Doc.
        /// </summary>
        public const string ModelTypeNameInXmlDocToken = "[model-type-name-in-xml-doc-here]";

        /// <summary>
        /// The name of the model type when used in an identifier.
        /// </summary>
        public const string ModelTypeNameInIdentifierToken = "[model-type-name-in-identifier-here]";

        /// <summary>
        /// The namespace of the model Type.
        /// </summary>
        public const string ModelTypeNamespaceToken = "[model-type-namespace-here]";

        /// <summary>
        /// The name of the root ancestor Type of the model.
        /// </summary>
        public const string ModelRootAncestorTypeNameInCodeToken = "[model-root-ancestor-type-name-in-code-here]";

        /// <summary>
        /// The name of an ancestor Type of the model.
        /// </summary>
        public const string ModelAncestorTypeNameToken = "[model-ancestor-type-name-in-code-here]";

        /// <summary>
        /// The concrete derivative types names used in code.
        /// </summary>
        public const string ConcreteDerivativeTypeNamesInCodeToken = "[concrete-derivative-type-names-in-code-here]";

        /// <summary>
        /// The deep clone code.
        /// </summary>
        public const string DeepCloneToken = "[deep-clone-here]";

        /// <summary>
        /// The DeepCloneWith code.
        /// </summary>
        public const string DeepCloneWithToken = "[deep-clone-with-here]";

        /// <summary>
        /// The DeepCloneWith model instantiation code.
        /// </summary>
        public const string DeepCloneWithModelInstantiationToken = "[deep-clone-with-model-instantiation-here]";

        /// <summary>
        /// The code to deep clone a generic.
        /// </summary>
        public const string DeepCloneGenericToken = "[deep-clone-generic-here]";

        /// <summary>
        /// The code to deep clone an interface.
        /// </summary>
        public const string DeepCloneInterfaceToken = "[deep-clone-interface-here]";

        /// <summary>
        /// The name of a generic type parameter.
        /// </summary>
        public const string GenericTypeParameterNameToken = "[generic-type-parameter-name-here]";

        /// <summary>
        /// The names of the generic type parameter.
        /// </summary>
        public const string GenericTypeParameterNamesToken = "[generic-type-parameter-names-here]";

        /// <summary>
        /// The property name.
        /// </summary>
        public const string PropertyNameToken = "[property-name-here]";

        /// <summary>
        /// The parameter name.
        /// </summary>
        public const string ParameterNameToken = "[parameter-name-here]";

        /// <summary>
        /// The parameter name in XML doc.
        /// </summary>
        public const string ParameterNameInXmlDocToken = "[parameter-name-in-xml-doc-here]";

        /// <summary>
        /// The property Type name.
        /// </summary>
        public const string PropertyTypeNameToken = "[property-type-name-here]";

        /// <summary>
        /// The names of the properties of concern.
        /// </summary>
        public const string PropertiesOfConcernNamesHereToken = "[properties-of-concern-names-here]";

        /// <summary>
        /// The CompareTo... code.
        /// </summary>
        public const string CompareToToken = "[compare-to-here]";

        /// <summary>
        /// The CompareToForRelativeSortOrder() code.
        /// </summary>
        public const string CompareToForRelativeSortOrderToken = "[compare-to-for-relative-sort-order-here]";

        /// <summary>
        /// The equality statements.
        /// </summary>
        public const string EqualityStatementsToken = "[equality-statements-here]";

        /// <summary>
        /// The hash statements.
        /// </summary>
        public const string HashStatementsToken = "[hash-statements-here]";

        /// <summary>
        /// The ToString() statement.
        /// </summary>
        public const string ToStringStatementToken = "[to-string-statement-here]";

        /// <summary>
        /// The constructor argument validation test scenarios.
        /// </summary>
        public const string ConstructorArgumentValidationTestScenariosToken = "[constructor-argument-validation-test-scenarios-here]";

        /// <summary>
        /// The constructor property assignment test scenarios.
        /// </summary>
        public const string ConstructorPropertyAssignmentTestScenariosToken = "[constructor-property-assignment-test-scenarios-here]";

        /// <summary>
        /// Constructs an object.
        /// </summary>
        public const string ConstructObjectToken = "[construct-object-here]";

        /// <summary>
        /// Sets a dictionary value to null.
        /// </summary>
        public const string SetDictionaryValueToNullToken = "[set-dictionary-value-to-null-here]";

        /// <summary>
        /// Asserts deep cloning.
        /// </summary>
        public const string AssertDeepCloneToken = "[assert-deep-clone-here]";

        /// <summary>
        /// The DeepCloneWith test.
        /// </summary>
        public const string DeepCloneWithTestToken = "[deep-clone-with-test-here]";

        /// <summary>
        /// The DeepCloneWith throwing tests.
        /// </summary>
        public const string DeepCloneWithThrowsTestsToken = "[deep-clone-with-throws-tests-here]";

        /// <summary>
        /// Objects that are not equal to reference object.
        /// </summary>
        public const string ObjectsNotEqualToReferenceObjectToken = "[objects-not-equal-to-reference-object-here]";

        /// <summary>
        /// Objects that are equal to but not the same as reference object.
        /// </summary>
        public const string ObjectsEqualToButNotTheSameAsReferenceObjectToken = "[object-equal-to-but-not-same-as-reference-object-here]";

        /// <summary>
        /// Objects that derive from scenario type but are not of the same type as the reference object.
        /// </summary>
        public const string ScenarioTypeDerivativeThatIsNotSameTypeAsReferenceObjectToken = "[objects-that-derive-from-scenario-type-but-are-not-of-the-same-type-as-reference-object-here]";

        /// <summary>
        /// Skips the GetHashCode() test for objects that are not equal.
        /// </summary>
        public const string SkipGetHashCodeTestForNotEqualObjectsToken = "[skip-get-hash-code-test-here]";

        /// <summary>
        /// The expected ToString() result.
        /// </summary>
        public const string ToStringExpectedToken = "[to-string-expected-here]";

        /// <summary>
        /// A new dummy object.
        /// </summary>
        public const string NewDummyToken = "[new-dummy-here]";

        /// <summary>
        /// The serialization tests.
        /// </summary>
        public const string SerializationTestsToken = "[serialization-tests-here]";

        /// <summary>
        /// The structural tests.
        /// </summary>
        public const string StructuralTestsToken = "[structural-tests-here]";

        /// <summary>
        /// The name of the expected interface.
        /// </summary>
        public const string ExpectedInterfaceToken = "[expected-interface-here]";

        /// <summary>
        /// The name of the expected interface to be used in a test method name.
        /// </summary>
        public const string ExpectedInterfaceTestMethodNameToken = "[expected-interface-test-method-name-here]";

        /// <summary>
        /// The name of the code gen assembly.
        /// </summary>
        public const string CodeGenAssemblyNameToken = "[code-gen-assembly-name-here]";

        /// <summary>
        /// The name of the code gen assembly.
        /// </summary>
        public const string CodeGenAssemblyVersionToken = "[code-gen-assembly-version-here]";

        /// <summary>
        /// The required interfaces.
        /// </summary>
        public const string RequiredInterfacesToken = "[required-interfaces-here]";

        /// <summary>
        /// The model implementation.
        /// </summary>
        public const string ModelImplementationToken = "[model-implementation-here]";

        /// <summary>
        /// The test implementation.
        /// </summary>
        public const string TestImplementationToken = "[test-implementation-here]";

        /// <summary>
        /// A cast.
        /// </summary>
        public const string CastToken = "[cast-here]";

        /// <summary>
        /// Dummy ancestor concrete derivatives.
        /// </summary>
        public const string DummyAncestorConcreteDerivativesToken = "[dummy-ancestor-concrete-derivatives-here]";

        /// <summary>
        /// CompareToForRelativeSortOrder() tests.
        /// </summary>
        public const string CompareToTestsToken = "[compare-to-tests-here]";

        /// <summary>
        /// CompareToForRelativeSortOrder() tests.
        /// </summary>
        public const string CompareToForRelativeSortOrderTestsToken = "[compare-to-for-relative-sort-order-tests-here]";

        /// <summary>
        /// Equals() tests.
        /// </summary>
        public const string EqualsTestsToken = "[equals-tests-here]";

        /// <summary>
        /// The namespace of the dummy factory type.
        /// </summary>
        public const string DummyFactoryTypeNamespaceToken = "[dummy-factory-type-namespace-here]";

        /// <summary>
        /// The name of the dummy factory type.
        /// </summary>
        public const string DummyFactoryTypeNameToken = "[dummy-factory-type-name-here]";

        /// <summary>
        /// The dummy factory snippets.
        /// </summary>
        public const string DummyFactorySnippetsToken = "[dummy-factory-snippets-here]";

        /// <summary>
        /// The code analysis suppressions to add to a nested test class.
        /// </summary>
        public const string NestedTestClassCodeAnalysisSuppressionsToken = "[nested-test-class-code-analysis-suppressions-here]";

        /// <summary>
        /// The code analysis suppressions to add to a test method.
        /// </summary>
        public const string TestMethodCodeAnalysisSuppressionsToken = "[test-method-code-analysis-suppressions-here]";

        /// <summary>
        /// The code analysis suppressions to add to a DeepCloneWith() method.
        /// </summary>
        public const string DeepCloneWithCodeAnalysisSuppressionsToken = "[deep-clone-with-code-analysis-suppressions-here]";

        /// <summary>
        /// The code analysis suppressions to add to an Equals() method.
        /// </summary>
        public const string EqualsCodeAnalysisSuppressionsToken = "[equals-code-analysis-suppressions-here]";

        /// <summary>
        /// The DeepConeWith... test scenarios.
        /// </summary>
        public const string DeepCloneWithTestScenariosToken = "[deep-clone-with-test-scenarios-here]";

        /// <summary>
        /// A reference object used in testing.
        /// </summary>
        public const string ReferenceObjectToken = "[reference-object-here]";

        /// <summary>
        /// Using statements.
        /// </summary>
        public const string UsingStatementsToken = "[using-statements-here]";

        /// <summary>
        /// Recipe conditional compilation symbol.
        /// </summary>
        public const string RecipeConditionalCompilationSymbol = "[recipe-conditional-compilation-symbol-here]";

        /// <summary>
        /// Checks whether <see cref="DateTime"/> is used as a key in a dictionary.
        /// </summary>
        public const string DateTimeUsedAsKeyInDictionaryCheck = "[date-time-used-as-key-in-dictionary-check-here]";

        /// <summary>
        /// Comments out a line of code.
        /// </summary>
        public const string CommentOutToken = "[comment-out-here]";
    }
}