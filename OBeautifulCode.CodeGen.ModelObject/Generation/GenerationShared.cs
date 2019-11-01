// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenerationShared.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Reflection;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Shared methods for generation.
    /// </summary>
    internal static class GenerationShared
    {
        private const string TypeNameToken = "<<<<TypeNameHere>>>";

        /// <summary>
        /// Generates a FluentAssertions equality statement.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="expected">The expected value.</param>
        /// <returns>
        /// Generated FluentAssertions equality statement.
        /// </returns>
        public static string GenerateFluentAssertionsEqualityStatement(
            this Type type,
            string actual,
            string expected)
        {
            var result = Invariant($"{actual}.Should().{(type.IsSystemDictionaryType() || type.IsSystemCollectionType() ? "Equal" : "Be")}({expected});");
            return result;
        }

        /// <summary>
        /// Gets the properties of concern from a type.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// The properties of concern for the specified type.
        /// </returns>
        public static PropertyInfo[] GetPropertiesOfConcernFromType(
            this Type type)
        {
            type.AsArg(nameof(type)).Must().NotBeNull();

            var result = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.FlattenHierarchy);

            return result;
        }

        /// <summary>
        /// Gets the Code Gen assembly name.
        /// </summary>
        /// <returns>
        /// The Code Gen assembly name.
        /// </returns>
        public static string GetCodeGenAssemblyName()
        {
            var result = typeof(GenerationShared).Assembly.GetName().Name;

            return result;
        }

        /// <summary>
        /// Gets the Code Gen assembly version.
        /// </summary>
        /// <returns>
        /// The Code Gen assembly version.
        /// </returns>
        public static string GetCodeGenAssemblyVersion()
        {
            var result = typeof(GenerationShared).Assembly.GetName().Version.ToString();

            return result;
        }
    }
}