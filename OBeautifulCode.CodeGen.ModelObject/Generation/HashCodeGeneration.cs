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
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to hash codes.
    /// </summary>
    internal static class HashCodeGeneration
    {
        private const string HashToken = "<<<HashMethodStackHere>>>";

        private const string HashMethodCodeTemplate = @"
        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            ." + HashToken + @"
            .Value;";

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
            var properties = type.GetPropertiesOfConcernFromType();
            var hashLines = properties.Select(_ => _.GenerateHashCodeMethodCodeForProperty()).ToList();
            var hashToken = string.Join(Environment.NewLine + "            .", hashLines);
            var result = HashMethodCodeTemplate.Replace(HashToken, hashToken);

            return result;
        }

        private static string GenerateHashCodeMethodCodeForProperty(
            this PropertyInfo propertyInfo)
        {
            propertyInfo.AsArg(nameof(propertyInfo)).Must().NotBeNull();

            if (propertyInfo.PropertyType.IsSystemDictionaryType())
            {
                return Invariant($"HashDictionary(this.{propertyInfo.Name})");
            }
            else if (propertyInfo.PropertyType.IsSystemCollectionType())
            {
                return Invariant($"HashElements(this.{propertyInfo.Name})");
            }
            else if (propertyInfo.PropertyType == typeof(string))
            {
                return Invariant($"Hash(this.{propertyInfo.Name})");
            }
            else
            {
                return Invariant($"Hash(this.{propertyInfo.Name})");
            }
        }
    }
}