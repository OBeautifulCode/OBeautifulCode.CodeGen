// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Extensions.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;
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

        /// <summary>
        /// Gets the name of a type when used in the name of a test method.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// The name of the specified type when used in the name of a test method.
        /// </returns>
        public static string GetTypeNameInTestMethodName(
            this Type type)
        {
            new { type }.AsArg().Must().NotBeNull();

            string result;

            if (type.IsGenericType)
            {
                result = type.ToStringWithoutGenericComponent() + "_of_" + type.GetGenericArguments().Select(_ => _.GetTypeNameInTestMethodName()).ToDelimitedString("_");
            }
            else
            {
                result = type.ToStringReadable();
            }

            return result;
        }
    }
}
