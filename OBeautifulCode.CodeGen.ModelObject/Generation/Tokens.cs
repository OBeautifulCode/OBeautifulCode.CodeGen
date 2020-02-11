﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tokens.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    /// <summary>
    /// Replacement tokens.
    /// </summary>
    public static class Tokens
    {
        /// <summary>
        /// The name of the model Type.
        /// </summary>
        public const string ModelTypeNameToken = "[model-type-name-here]";

        /// <summary>
        /// The name of the root ancestor Type of the model.
        /// </summary>
        public const string ModelRootAncestorTypeNameToken = "[model-root-ancestor-type-name-here]";

        /// <summary>
        /// The name of an ancestor Type of the model.
        /// </summary>
        public const string ModelAncestorTypeNameToken = "[model-ancestor-type-name-here]";

        /// <summary>
        /// The deep clone code.
        /// </summary>
        public const string DeepCloneToken = "[deep-clone-here]";

        /// <summary>
        /// The DeepCloneWith... code.
        /// </summary>
        public const string DeepCloneWithToken = "[deep-clone-with-here]";

        /// <summary>
        /// The DeepCloneWith... model instantiation code.
        /// </summary>
        public const string DeepCloneWithModelInstantiationToken = "[deep-clone-with-model-instantiation-here]";

        /// <summary>
        /// The property name.
        /// </summary>
        public const string PropertyNameToken = "[property-name-here]";

        /// <summary>
        /// The parameter name.
        /// </summary>
        public const string ParameterNameToken = "[parameter-name-here]";

        /// <summary>
        /// The property Type name.
        /// </summary>
        public const string PropertyTypeNameToken = "[property-type-name-here]";

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
        /// The constructor tests.
        /// </summary>
        public const string ConstructorTestsToken = "[constructor-tests-here]";

        /// <summary>
        /// Constructs an object.
        /// </summary>
        public const string ConstructObjectToken = "[construct-object-here]";

        /// <summary>
        /// Sets a dictionary value to null.
        /// </summary>
        public const string SetDictionaryValueToNullToken = "[set-dictionary-value-to-null-here]";

        /// <summary>
        /// Asserts a property getter.
        /// </summary>
        public const string AssertPropertyGetterToken = "[assert-property-getter-here]";

        /// <summary>
        /// Asserts deep cloning.
        /// </summary>
        public const string AssertDeepCloneToken = "[assert-deep-clone-here]";

        /// <summary>
        /// Asserts deep cloning.
        /// </summary>
        public const string DeepCloneWithTestsToken = "[deep-clone-with-tests-here]";

        /// <summary>
        /// Asserts deep cloning.
        /// </summary>
        public const string AssertDeepCloneWithToken = "[assert-deep-clone-with-here]";

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
    }
}
