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
    using System.Reflection;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
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
            typeof(IValidatableViaCodeGen),
        };

        /// <summary>
        /// Generates code associated with a model object.
        /// </summary>
        /// <typeparam name="T">The type of the model object.</typeparam>
        /// <param name="kind">Specifies the kind of code to generate.</param>
        /// <param name="getAssemblyMissingLocationFunc">Function that gets the location from an assembly, when an assembly is missing a <see cref="Assembly.Location"/> or null if it cannot be determined.</param>
        /// <returns>
        /// The generated code.
        /// </returns>
        public static string GenerateForModel<T>(
            GenerateFor kind,
            Func<Assembly, string> getAssemblyMissingLocationFunc)
        {
            var type = typeof(T);

            var result = type.GenerateForModel(kind, getAssemblyMissingLocationFunc);

            return result;
        }

        /// <summary>
        /// Generates code associated with a model object.
        /// </summary>
        /// <param name="type">The type of the model object.</param>
        /// <param name="kind">Specifies the kind of code to generate.</param>
        /// <param name="getAssemblyMissingLocationFunc">Function that gets the location from an assembly, when an assembly is missing a <see cref="Assembly.Location"/> or null if it cannot be determined.</param>
        /// <returns>
        /// The generated code.
        /// </returns>
        public static string GenerateForModel(
            this Type type,
            GenerateFor kind,
            Func<Assembly, string> getAssemblyMissingLocationFunc)
        {
            new { type }.AsArg().Must().NotBeNull();

            var modelType = type.ToModelType(getAssemblyMissingLocationFunc);

            var generatedCode = new List<string>();

            if (kind.HasFlag(GenerateFor.ModelImplementationPartialClass))
            {
                var modelMethods = modelType.GenerateCodeForModelImplementation();

                generatedCode.Add(modelMethods);
            }

            if (kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithSerialization) || kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithoutSerialization))
            {
                var tests = modelType.ExampleClosedModelType.ToModelType(getAssemblyMissingLocationFunc).GenerateCodeForTests(kind);

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
        /// <param name="getAssemblyMissingLocationFunc">Function that gets the location from an assembly, when an assembly is missing a <see cref="Assembly.Location"/> or null if it cannot be determined.</param>
        /// <returns>
        /// The dummy factory code.
        /// </returns>
        public static string GenerateDummyFactory(
            IReadOnlyCollection<Type> types,
            string dummyFactoryTypeNamespace,
            string dummyFactoryTypeName,
            string recipeConditionalCompilationSymbol,
            Func<Assembly, string> getAssemblyMissingLocationFunc)
        {
            new { types }.Must().NotBeNull().And().NotContainAnyNullElements();
            new { dummyFactoryTypeNamespace }.Must().NotBeNullNorWhiteSpace();
            new { dummyFactoryTypeName }.Must().NotBeNullNorWhiteSpace();

            var modelTypes = types.Select(_ => _.ToModelType(getAssemblyMissingLocationFunc).ExampleClosedModelType.ToModelType(getAssemblyMissingLocationFunc)).ToList();

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
        /// <param name="getAssemblyMissingLocationFunc">Function that gets the location from an assembly, when an assembly is missing a <see cref="Assembly.Location"/> or null if it cannot be determined.</param>
        /// <returns>
        /// The equality test fields for use in user (non-designer) code.
        /// </returns>
        public static string GenerateEqualityTestFieldsInUserCode(
            this Type type,
            Func<Assembly, string> getAssemblyMissingLocationFunc)
        {
            new { type }.AsArg().Must().NotBeNull();

            var result = type.ToModelType(getAssemblyMissingLocationFunc).GenerateEqualityTestFieldsInUserCode();

            return result;
        }

        private static ModelType ToModelType(
            this Type type,
            Func<Assembly, string> getAssemblyMissingLocationFunc)
        {
            var result = new ModelType(type, getAssemblyMissingLocationFunc);

            return result;
        }
    }
}