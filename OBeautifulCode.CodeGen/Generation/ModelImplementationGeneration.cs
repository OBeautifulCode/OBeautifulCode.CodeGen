// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelImplementationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen
{
    using System;

    using OBeautifulCode.Representation.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates model implementation code.
    /// </summary>
    internal static class ModelImplementationGeneration
    {
        /// <summary>
        /// Generates code that implements standard features of a model, including
        /// equality checks, hash code generation, cloning methods, and a friendly ToString().
        /// </summary>
        /// <param name="type">The type of model.</param>
        /// <returns>
        /// Generated code that implements the standard features for the specified model type.
        /// </returns>
        public static string GenerateCodeForModelImplementation(
            this Type type)
        {
            var items = new[]
            {
                Invariant($"public partial class {type.ToStringReadable()} : IModel<{type.ToStringReadable()}>"),
                "{",
                "    " + type.GenerateEqualityMethods(),
                "    " + type.GenerateGetHashCodeMethod(),
                "    " + type.GenerateCloningMethods(),
                "    " + type.GenerateToStringMethod(),
                "}",
            };

            var result = string.Join(
                Environment.NewLine,
                items);

            return result;
        }
    }
}