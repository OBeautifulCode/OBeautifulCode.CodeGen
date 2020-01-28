// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenerator.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Generates code.
    /// </summary>
    public static class CodeGenerator
    {
        /// <summary>
        /// Gets the types that indicate that coded gen is required.
        /// </summary>
        public static readonly IReadOnlyCollection<Type> TypesThatIndicateCodeGenIsRequired = new[]
        {
            typeof(IComparableViaCodeGen),
            typeof(IDeepCloneableViaCodeGen),
            typeof(IEquatableViaCodeGen),
            typeof(IHashableViaCodeGen),
            typeof(IModelViaCodeGen),
            typeof(IStringRepresentableViaCodeGen),
        };

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

            var result = type.GenerateForModel(kind);

            return result;
        }

        /// <summary>
        /// Generates code associated with a model object.
        /// </summary>
        /// <param name="type">The type of the model object.</param>
        /// <param name="kind">Specifies the kind of code to generate.</param>
        /// <returns>
        /// The generated code.
        /// </returns>
        public static string GenerateForModel(
            this Type type,
            GenerateFor kind)
        {
            new { type }.AsArg().Must().NotBeNull();

            var modelType = new ModelType(type);

            var generatedCode = new List<string>();

            if (kind.HasFlag(GenerateFor.ModelImplementationPartialClass))
            {
                var modelMethods = modelType.GenerateCodeForModelImplementation();

                generatedCode.Add(modelMethods);
            }

            if (kind.HasFlag(GenerateFor.ModelDummyFactorySnippet))
            {
                var dummyFactorySnippet = modelType.GenerateCodeForDummyFactory();

                generatedCode.Add(dummyFactorySnippet);
            }

            if (kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithSerialization) || kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithoutSerialization))
            {
                var tests = modelType.GenerateCodeForTests(kind);

                generatedCode.Add(tests);
            }

            var result = string.Join(
                Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine,
                generatedCode);

            return result;
        }
    }
}