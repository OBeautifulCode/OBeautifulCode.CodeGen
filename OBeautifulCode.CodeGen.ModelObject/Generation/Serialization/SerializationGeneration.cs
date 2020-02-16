// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;

    /// <summary>
    /// Generates code related to serialization.
    /// </summary>
    internal static class SerializationGeneration
    {
        /// <summary>
        /// Generates fields required for serialization tests.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated fields required for serialization tests.
        /// </returns>
        public static string GenerateSerializationTestFields(
            this ModelType modelType)
        {
            modelType.AsArg(nameof(modelType)).Must().NotBeNull();

            var prefix = modelType
                .TypeNamespace
                .Split('.')
                .Skip(1)
                .Take(1)
                .ToDelimitedString(string.Empty);

            var bsonSnippet = typeof(SerializationGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.SerializationBsonTestFields);

            var jsonSnippet = typeof(SerializationGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.SerializationJsonTestFields);

            var serializationFieldsCodeTemplate = modelType.PropertiesOfConcern.Any(_ => _.IsGetterOnly)
                ? jsonSnippet
                : bsonSnippet + Environment.NewLine + Environment.NewLine + jsonSnippet;

            var result = serializationFieldsCodeTemplate
                        .Replace(Tokens.SerializationConfigurationPrefixToken, prefix);

            return result;
        }

        /// <summary>
        /// Generates test methods to test serialization.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods to test serialization.
        /// </returns>
        public static string GenerateSerializationTestMethods(
            this ModelType modelType)
        {
            modelType.AsArg(nameof(modelType)).Must().NotBeNull();

            var codeTemplate = typeof(SerializationGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.Test, KeyMethodKinds.Both);

            var bsonTests = typeof(SerializationGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.SerializationBsonTests);

            var jsonTests = typeof(SerializationGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.SerializationJsonTests);

            var serializationTests = modelType.PropertiesOfConcern.Any(_ => _.IsGetterOnly)
                ? jsonTests
                : bsonTests + Environment.NewLine + Environment.NewLine + jsonTests;

            var result = codeTemplate
                .Replace(Tokens.SerializationTestsToken, serializationTests)
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString);

            return result;
        }
    }
}