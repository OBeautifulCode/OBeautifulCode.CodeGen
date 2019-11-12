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

        private const string HashMethodForConcreteTypeCodeTemplate = @"
        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            ." + HashToken + @"
            .Value;";

        private const string HashMethodForAbstractTypeCodeTemplate = @"
        /// <inheritdoc />
        public abstract override int GetHashCode();";

        /// <summary>
        /// Generate hash code method.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// The generated hash code method.
        /// </returns>
        public static string GenerateGetHashCodeMethod(
            this Type type)
        {
            string result;

            if (type.IsAbstract)
            {
                result = HashMethodForAbstractTypeCodeTemplate;
            }
            else
            {
                var properties = type.GetPropertiesOfConcernFromType();

                var hashLines = properties.Select(_ => _.GenerateHashCodeMethodCodeForProperty()).ToList();

                var hashToken = string.Join(Environment.NewLine + "            .", hashLines);

                result = HashMethodForConcreteTypeCodeTemplate.Replace(HashToken, hashToken);
            }

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