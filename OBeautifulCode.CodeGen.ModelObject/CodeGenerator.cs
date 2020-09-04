// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenerator.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Internal;
    using OBeautifulCode.Type;

    /// <summary>
    /// Generates code.
    /// </summary>
    public static class CodeGenerator
    {
        /// <summary>
        /// Gets the types that indicate that coded gen is required.
        /// </summary>
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
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

            var modelType = type.ToModelType();

            var generatedCode = new List<string>();

            if (kind.HasFlag(GenerateFor.ModelImplementationPartialClass))
            {
                var modelMethods = modelType.GenerateCodeForModelImplementation();

                generatedCode.Add(modelMethods);
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

        /// <summary>
        /// Generates the dummy factory.
        /// </summary>
        /// <param name="types">The types to generic dummy factory snippets for.</param>
        /// <param name="dummyFactoryTypeNamespace">The dummy factory type's namespace.</param>
        /// <param name="dummyFactoryTypeName">The dummy factory type name.</param>
        /// <param name="recipeConditionalCompilationSymbol">The conditional compilation symbol to use for recipes.</param>
        /// <returns>
        /// The dummy factory code.
        /// </returns>
        public static string GenerateDummyFactory(
            IReadOnlyCollection<Type> types,
            string dummyFactoryTypeNamespace,
            string dummyFactoryTypeName,
            string recipeConditionalCompilationSymbol)
        {
            new { types }.Must().NotBeNull().And().NotContainAnyNullElements();
            new { dummyFactoryTypeNamespace }.Must().NotBeNullNorWhiteSpace();
            new { dummyFactoryTypeName }.Must().NotBeNullNorWhiteSpace();

            var modelTypes = types.Select(_ => _.ToModelType().ExampleClosedModelType.ToModelType()).ToList();

            var result = ModelImplementationGeneration.GenerateCodeForDummyFactory(modelTypes, dummyFactoryTypeNamespace, dummyFactoryTypeName, recipeConditionalCompilationSymbol);

            return result;
        }

        /// <summary>
        /// Generates the dummy factory tests.
        /// </summary>
        /// <param name="dummyFactoryTypeNamespace">The dummy factory type's namespace.</param>
        /// <param name="dummyFactoryTypeName">The dummy factory type name.</param>
        /// <returns>
        /// The dummy factory code.
        /// </returns>
        public static string GenerateDummyFactoryTests(
            string dummyFactoryTypeNamespace,
            string dummyFactoryTypeName)
        {
            new { dummyFactoryTypeNamespace }.Must().NotBeNullNorWhiteSpace();
            new { dummyFactoryTypeName }.Must().NotBeNullNorWhiteSpace();

            var result = ModelImplementationGeneration.GenerateCodeForDummyFactoryTests(dummyFactoryTypeNamespace, dummyFactoryTypeName);

            return result;
        }

        /// <summary>
        /// Generates equality test fields for use in user (non-designer) code.
        /// </summary>
        /// <param name="type">The type of the model object.</param>
        /// <returns>
        /// The equality test fields for use in user (non-designer) code.
        /// </returns>
        public static string GenerateEqualityTestFieldsInUserCode(
            this Type type)
        {
            new { type }.AsArg().Must().NotBeNull();

            var result = type.ToModelType().GenerateEqualityTestFieldsInUserCode();

            return result;
        }

        private static ModelType ToModelType(
            this Type type)
        {
            var result = new ModelType(type);

            return result;
        }
    }
}