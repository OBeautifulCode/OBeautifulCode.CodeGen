// --------------------------------------------------------------------------------------------------------------------
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
    }
}
