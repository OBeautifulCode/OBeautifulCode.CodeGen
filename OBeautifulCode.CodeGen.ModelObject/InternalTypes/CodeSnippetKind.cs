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
        /// A code snippet for a DeepCloneWith() method.
        /// </summary>
        DeepCloneWith,

        /// <summary>
        /// A code snippet for a CompareTo() method.
        /// </summary>
        CompareTo,

        /// <summary>
        /// A code snippet for a CompareToForRelativeSortOrder() method.
        /// </summary>
        CompareToForRelativeSortOrder,

        /// <summary>
        /// A code snippet for a constructor argument test method.
        /// </summary>
        ConstructorTestMethodForArgument,

        /// <summary>
        /// A code snippet for a constructor string argument test method.
        /// </summary>
        ConstructorTestMethodForStringArgument,

        /// <summary>
        /// A code snippet for a constructor collection is empty argument test method.
        /// </summary>
        ConstructorTestMethodForCollectionArgumentThatIsEmpty,

        /// <summary>
        /// A code snippet for a constructor collection contains null element argument test method.
        /// </summary>
        ConstructorTestMethodForCollectionArgumentThatContainsNullElement,

        /// <summary>
        /// A code snippet for a constructor dictionary that is empty argument test method.
        /// </summary>
        ConstructorTestMethodForDictionaryArgumentThatIsEmpty,

        /// <summary>
        /// A code snippet for a constructor dictionary that contains null value argument test method.
        /// </summary>
        ConstructorTestMethodForDictionaryArgumentThatContainsNullValue,

        /// <summary>
        /// A code snippet for a property getter test method.
        /// </summary>
        PropertyGetterTestMethod,

        /// <summary>
        /// A code snippet for a DeepCloneWith test method.
        /// </summary>
        DeepCloneWithTestMethod,

        /// <summary>
        /// A code snippet for comparability-related test fields.
        /// </summary>
        ComparableTestFields,

        /// <summary>
        /// A code snippet for equatable-related test fields.
        /// </summary>
        EquatableTestFields,

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
    }
}
