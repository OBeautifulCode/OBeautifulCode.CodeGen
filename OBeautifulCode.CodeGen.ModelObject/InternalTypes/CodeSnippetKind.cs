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
        /// A code snippet for a DeepCloneWith test method where the type declares the property.
        /// </summary>
        DeepCloneWithForDeclaredPropertyTestMethod,

        /// <summary>
        /// A code snippet for a DeepCloneWith test method where the type does not declare the property.
        /// </summary>
        DeepCloneWithForNotDeclaredPropertyTestMethod,

        /// <summary>
        /// A code snippet for comparability-related test fields.
        /// </summary>
        ComparableTestFields,
    }
}
