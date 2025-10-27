// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Generates code related to serialization.
    /// </summary>
    internal static class SerializationGeneration
    {
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

            var codeTemplate = typeof(SerializationGeneration).GetCodeTemplate(CodeTemplateKind.Test, KeyMethodKinds.Both);

            var bsonTests = typeof(SerializationGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.SerializationBsonTests);

            var jsonTests = typeof(SerializationGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.SerializationJsonTests);

            var serializationTests = bsonTests + Environment.NewLine + Environment.NewLine + jsonTests;

            var result = codeTemplate
                .Replace(Tokens.SerializationTestsToken, serializationTests)
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString);

            return result;
        }
    }
}