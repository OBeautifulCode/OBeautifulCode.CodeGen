// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StructuralGeneration.cs" company="OBeautifulCode">
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
    /// Generates code related to structural checks.
    /// </summary>
    internal static class StructuralGeneration
    {
        /// <summary>
        /// Generates test methods that test a model's structure.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test a model's structure.
        /// </returns>
        public static string GenerateStructuralTestMethods(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            var testMethodsCode = modelType
                .RequiredInterfaces
                .Select(_ => _.GetExpectedInterfaceTestMethodCode())
                .ToDelimitedString(Environment.NewLine + Environment.NewLine);

            if (modelType.DeclaresGetHashCodeMethod)
            {
                testMethodsCode = testMethodsCode + Environment.NewLine + Environment.NewLine + typeof(StructuralGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.DeclaresGetHashCodeTest);
            }

            if (modelType.DeclaresToStringMethod)
            {
                testMethodsCode = testMethodsCode + Environment.NewLine + Environment.NewLine + typeof(StructuralGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.DeclaresToStringTest);
            }

            testMethodsCode = testMethodsCode + Environment.NewLine + Environment.NewLine + typeof(StructuralGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.SerializableAttributeTest);

            var codeTemplate = typeof(StructuralGeneration).GetCodeTemplate(CodeTemplateKind.Test, KeyMethodKinds.Both);

            var result = codeTemplate
                        .Replace(Tokens.StructuralTestsToken, testMethodsCode)
                        .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                        .Replace(Tokens.ModelTypeNameInTestMethodNameToken, modelType.TypeNameInTestMethodNameString);

            return result;
        }

        private static string GetExpectedInterfaceTestMethodCode(
            this Type expectedInterfaceType)
        {
            var result =
                typeof(StructuralGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ExpectedInterfaceTest)
                .Replace(Tokens.ExpectedInterfaceToken, expectedInterfaceType.ToStringReadable())
                .Replace(Tokens.ExpectedInterfaceTestMethodNameToken, expectedInterfaceType.GetTypeNameInTestMethodName());

            return result;
        }
    }
}