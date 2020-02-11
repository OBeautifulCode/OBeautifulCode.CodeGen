// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HashCodeGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to hash codes.
    /// </summary>
    internal static class HashCodeGeneration
    {
        /// <summary>
        /// Generate hashing methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// The generated hashing methods.
        /// </returns>
        public static string GenerateHashingMethods(
            this ModelType modelType)
        {
            var codeTemplate = typeof(HashCodeGeneration).GetCodeTemplate(modelType.HierarchyKinds.Classify(), CodeTemplateKind.Model, modelType.GetHashCodeKeyMethodKinds);

            var hashStatements = modelType.PropertiesOfConcern.Select(_ => _.GenerateHashCodeMethodCodeForProperty()).ToList();

            var hashStatementsCode = hashStatements.Any()
                ? new string[0].Concat(new[] { string.Empty }).Concat(hashStatements).ToDelimitedString(Environment.NewLine + "            .")
                : string.Empty;

            var result = codeTemplate
                .Replace(Tokens.HashStatementsToken, hashStatementsCode);

            return result;
        }

        /// <summary>
        /// Generates test methods that test hashing.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test hashing.
        /// </returns>
        public static string GenerateHashingTestMethods(
            this ModelType modelType)
        {
            var skipUnequalHashCodeTestCode = string.Empty;
            if (modelType.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode)
            {
                skipUnequalHashCodeTestCode = "(Skip = \"It's possible (and even probable after a few runs of this test) that two dummy, unequal models will have the same hash code.  The model being tested contains at least one property who's type (or a type nested within the generic type, or a property of the IModel type) is a dictionary with keys that are not comparable or an unordered collection with elements that are not comparable.  In these cases the hashing method cannot hash the elements and must resort to hashing the element count.  Two dummies could easily have the same element count for such a type.\")";
            }

            var result = typeof(HashCodeGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.Test, KeyMethodKinds.Both)
                .Replace(Tokens.SkipGetHashCodeTestForNotEqualObjectsToken, skipUnequalHashCodeTestCode);

            return result;
        }

        private static string GenerateHashCodeMethodCodeForProperty(
            this PropertyOfConcern propertyOfConcern)
        {
            new { propertyOfConcern }.AsArg().Must().NotBeNull();

            var result = Invariant($"Hash(this.{propertyOfConcern.Name})");

            return result;
        }
    }
}