// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HashCodeGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;
    using System.Reflection;

    using OBeautifulCode.Assertion.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to hash codes.
    /// </summary>
    internal static class HashCodeGeneration
    {
        private const string HashToken = "<<<HashMethodStackHere>>>";
        private const string UnequalHashCodeToken = "<<<UnequalHashCodeHere>>>";

        private const string HashMethodForConcreteTypeCodeTemplate = @"
        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()" + HashToken + @"
            .Value;";

        private const string HashMethodForAbstractBaseTypeCodeTemplate = @"
        /// <inheritdoc />
        public abstract override int GetHashCode();";

        private const string HashingTestMethodsCodeTemplate = @"    public static class Hashing
        {
            [Fact" + UnequalHashCodeToken + @"]
            public static void GetHashCode___Should_not_be_equal_for_two_objects___When_objects_have_different_property_values()
            {
                // Arrange, Act
                var actualHashCodeOfReference = ObjectForEquatableTests.GetHashCode();
                var actualHashCodesInNotEqualSet = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => _.GetHashCode()).ToList();
                var actualEqualityCheckOfHashCodesAgainstOthersInNotEqualSet = ObjectsThatAreNotEqualToObjectForEquatableTests.GetCombinations(2, 2).Select(_ => _.First().GetHashCode() == _.Last().GetHashCode()).ToList();

                // Assert
                actualHashCodesInNotEqualSet.AsTest().Must().NotContainElement(actualHashCodeOfReference);
                actualEqualityCheckOfHashCodesAgainstOthersInNotEqualSet.AsTest().Must().Each().BeFalse();
            }

            [Fact]
            public static void GetHashCode___Should_be_equal_for_two_objects___When_objects_have_the_same_property_values()
            {
                // Arrange, Act
                var hash1 = ObjectForEquatableTests.GetHashCode();
                var hash2 = ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests.GetHashCode();

                // Assert
                hash1.AsTest().Must().BeEqualTo(hash2);
            }
        }";

        /// <summary>
        /// Generate hash code method.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// The generated hash code method.
        /// </returns>
        public static string GenerateGetHashCodeMethod(
            this ModelType modelType)
        {
            string result;

            if (modelType.HierarchyKind == HierarchyKind.AbstractBase)
            {
                result = HashMethodForAbstractBaseTypeCodeTemplate;
            }
            else
            {
                var hashLines = modelType.PropertiesOfConcern.Select(_ => _.GenerateHashCodeMethodCodeForProperty()).ToList();

                string hashToken = null;

                if (hashLines.Any())
                {
                    hashLines = new string[0].Concat(new[] { string.Empty }).Concat(hashLines).ToList();

                    hashToken = string.Join(Environment.NewLine + "            .", hashLines);
                }

                result = HashMethodForConcreteTypeCodeTemplate.Replace(HashToken, hashToken);
            }

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

            var result = HashingTestMethodsCodeTemplate
                .Replace(UnequalHashCodeToken, skipUnequalHashCodeTestCode);

            return result;
        }

        private static string GenerateHashCodeMethodCodeForProperty(
            this PropertyInfo propertyInfo)
        {
            propertyInfo.AsArg(nameof(propertyInfo)).Must().NotBeNull();

            var result = Invariant($"Hash(this.{propertyInfo.Name})");

            return result;
        }
    }
}