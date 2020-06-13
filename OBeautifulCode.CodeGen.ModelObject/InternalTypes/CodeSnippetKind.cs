// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeSnippetKind.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    /// <summary>
    /// Specifies a kind of code snippet.
    /// </summary>
    internal enum CodeSnippetKind
    {
        /// <summary>
        /// None; not a code snippet.
        /// </summary>
        None,

        /// <summary>
        /// A code snippet for a DeepClone() method.
        /// </summary>
        DeepClone,

        /// <summary>
        /// A code snippet for a DeepCloneWith() method.
        /// </summary>
        DeepCloneWith,

        /// <summary>
        /// A code snippet for a DeepCloneWith() method that throws.
        /// </summary>
        DeepCloneWithThrows,

        /// <summary>
        /// A code snippet for test fields used to test the DeepCloneWith() methods.
        /// </summary>
        DeepCloneWithTestFields,

        /// <summary>
        /// A code snippet for the DeepCloneWith test.
        /// </summary>
        DeepCloneWithTest,

        /// <summary>
        /// A code snippet for a CompareTo() method.
        /// </summary>
        CompareTo,

        /// <summary>
        /// A code snippet for a CompareToForRelativeSortOrder() method.
        /// </summary>
        CompareToForRelativeSortOrder,

        /// <summary>
        /// A code snippet for constructor test fields.
        /// </summary>
        ConstructorTestFields,

        /// <summary>
        /// A code snippet for a constructor argument validation scenario that tests a null argument.
        /// </summary>
        ConstructorArgumentValidationScenarioNullObject,

        /// <summary>
        /// A code snippet for a constructor argument validation scenario that tests a white space string.
        /// </summary>
        ConstructorArgumentValidationScenarioWhiteSpaceString,

        /// <summary>
        /// A code snippet for a constructor argument validation scenario that tests an empty enumerable.
        /// </summary>
        ConstructorArgumentValidationScenarioEmptyEnumerable,

        /// <summary>
        /// A code snippet for a constructor argument validation scenario that tests an enumerable with a null element.
        /// </summary>
        ConstructorArgumentValidationScenarioEnumerableWithNullElement,

        /// <summary>
        /// A code snippet for a constructor argument validation scenario that tests an empty dictionary.
        /// </summary>
        ConstructorArgumentValidationScenarioEmptyDictionary,

        /// <summary>
        /// A code snippet for a constructor argument validation scenario that tests a dictionary with a null value.
        /// </summary>
        ConstructorArgumentValidationScenarioDictionaryWithNullValue,

        /// <summary>
        /// A code snippet for a constructor property assignment test scenario.
        /// </summary>
        ConstructorParameterAssignmentScenario,

        /// <summary>
        /// A code snippet for comparability-related test fields.
        /// </summary>
        ComparableTestFields,

        /// <summary>
        /// A code snippet for equatable-related test fields.
        /// </summary>
        EquatableTestFields,

        /// <summary>
        /// A code snippet for equatable-related test fields in user (non designer) code.
        /// </summary>
        EquatableTestFieldsInUserCode,

        /// <summary>
        /// A code snippet for objects that derive from scenario type but are not of the same type as the reference object.
        /// </summary>
        EquatableTestFieldsScenarioTypeDerivativeThatIsNotSameTypeAsReferenceObject,

        /// <summary>
        /// A code snippet for an object that is not equal to reference object.
        /// </summary>
        EquatableTestFieldsObjectNotEqualToReferenceObject,

        /// <summary>
        /// A code snippet for the BSON serialization test fields.
        /// </summary>
        SerializationBsonTestFields,

        /// <summary>
        /// A code snippet for the JSON serialization test fields.
        /// </summary>
        SerializationJsonTestFields,

        /// <summary>
        /// A code snippet for the BSON serialization tests.
        /// </summary>
        SerializationBsonTests,

        /// <summary>
        /// A code snippet for the JSON serialization tests.
        /// </summary>
        SerializationJsonTests,

        /// <summary>
        /// A code snippet for an expected interface test.
        /// </summary>
        ExpectedInterfaceTest,

        /// <summary>
        /// A code snippet for a test that GetHashCode() is declared.
        /// </summary>
        DeclaresGetHashCodeTest,

        /// <summary>
        /// A code snippet for a test that ToString() is declared.
        /// </summary>
        DeclaresToStringTest,

        /// <summary>
        /// A code snippet that tests that the model type is attributed with Serializable.
        /// </summary>
        SerializableAttributeTest,

        /// <summary>
        /// A code snippet for testing CompareTo().
        /// </summary>
        CompareToTests,

        /// <summary>
        /// A code snippet for testing CompareToForRelativeSortOrder().
        /// </summary>
        CompareToForRelativeSortOrderTests,

        /// <summary>
        /// A code snippet for testing Equals().
        /// </summary>
        EqualsTests,

        /// <summary>
        /// A code snippet for the Code Analysis suppressions to apply on a nested test class.
        /// </summary>
        NestedTestClassCodeAnalysisSuppressions,

        /// <summary>
        /// A code snippet for the Code Analysis suppressions to apply on a test method.
        /// </summary>
        TestMethodCodeAnalysisSuppressions,

        /// <summary>
        /// A code snippet for the Code Analysis suppressions to apply on a DeepCloneWith() method.
        /// </summary>
        DeepCloneWithCodeAnalysisSuppressions,

        /// <summary>
        /// A code snippet for string representation test fields.
        /// </summary>
        StringRepresentationTestFields,

        /// <summary>
        /// A code snippet for a DeepCloneWith test scenario.
        /// </summary>
        DeepCloneWithScenario,
    }
}