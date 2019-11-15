// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenerator.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Generates code.
    /// </summary>
    public static class CodeGenerator
    {
        /// <summary>
        /// Generates code associated with a model object.
        /// </summary>
        /// <typeparam name="T">The type of the model object.</typeparam>
        /// <param name="kind">Specifies the kind of code to generate.</param>
        /// <returns>
        /// The generated code.
        /// </returns>
        public static string GenerateForModel<T>(
            GenerateFor kind)
        {
            var type = typeof(T);

            type.ThrowIfNotSupported();

            var generatedCode = new List<string>();

            if (kind.HasFlag(GenerateFor.ModelImplementationPartialClass))
            {
                var modelMethods = type.GenerateCodeForModelImplementation();

                generatedCode.Add(modelMethods);
            }

            if (kind.HasFlag(GenerateFor.ModelDummyFactorySnippet))
            {
                var dummyFactorySnippet = type.GenerateCodeForDummyFactory();

                generatedCode.Add(dummyFactorySnippet);
            }

            if (kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithSerialization) || kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithoutSerialization))
            {
                var tests = type.GenerateCodeForTests(kind);

                generatedCode.Add(tests);
            }

            var result = string.Join(
                Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine,
                generatedCode);

            return result;
        }
    }
}