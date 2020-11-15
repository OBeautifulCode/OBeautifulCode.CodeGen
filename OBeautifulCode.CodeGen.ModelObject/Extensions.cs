// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Extensions.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type.Recipes;

    /// <summary>
    /// Model object code generation extension methods.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Gets the name of the test class associated with the specified model type.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// The test class name to use for the specified model type.
        /// </returns>
        public static string GetTestClassName(
            this Type type)
        {
            new { type }.AsArg().Must().NotBeNull();

            var result = type
                .GetGenericTypeDefinitionOrSpecifiedType()
                .ToStringXmlDoc()
                .GetTestClassName();

            return result;
        }

        /// <summary>
        /// Gets the name of the test class associated with the specified model name.
        /// </summary>
        /// <param name="modelName">The model name.</param>
        /// <returns>
        /// The test class name to use for the specified model name.
        /// </returns>
        public static string GetTestClassName(
            this string modelName)
        {
            new { modelName }.AsArg().Must().NotBeNullNorWhiteSpace();

            var result = modelName
                .Replace("{", string.Empty)
                .Replace("}", string.Empty)
                .Replace(",", string.Empty)
                .Replace(" ", string.Empty);

            result = result + "Test";

            return result;
        }
    }
}
