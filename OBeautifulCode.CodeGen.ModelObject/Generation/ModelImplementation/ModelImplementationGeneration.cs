// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelImplementationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Type.Recipes;

    /// <summary>
    /// Generates model implementation code.
    /// </summary>
    internal static class ModelImplementationGeneration
    {
        /// <summary>
        /// Generates code that implements standard features of a model, including
        /// equality checks, hash code generation, cloning methods, and a friendly ToString().
        /// </summary>
        /// <param name="modelType">The type of model.</param>
        /// <returns>
        /// Generated code that implements the standard features for the specified model type.
        /// </returns>
        public static string GenerateCodeForModelImplementation(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            var modelImplementationItems = new List<string>();

            if (modelType.RequiresEquality)
            {
                modelImplementationItems.Add(string.Empty);

                modelImplementationItems.Add(modelType.GenerateEqualityMethods());
            }

            if (modelType.RequiresComparability)
            {
                modelImplementationItems.Add(string.Empty);

                modelImplementationItems.Add(modelType.GenerateComparableMethods());
            }

            if (modelType.RequiresHashing)
            {
                var hashingMethods = modelType.GenerateHashingMethods();

                if (!string.IsNullOrWhiteSpace(hashingMethods))
                {
                    modelImplementationItems.Add(string.Empty);

                    modelImplementationItems.Add(hashingMethods);
                }
            }

            if (modelType.RequiresDeepCloning)
            {
                modelImplementationItems.Add(string.Empty);

                modelImplementationItems.Add(modelType.GenerateCloningMethods());
            }

            if (modelType.RequiresStringRepresentation)
            {
                var stringRepresentationMethods = modelType.GenerateStringRepresentationMethods();

                if (!string.IsNullOrWhiteSpace(stringRepresentationMethods))
                {
                    modelImplementationItems.Add(string.Empty);

                    modelImplementationItems.Add(stringRepresentationMethods);
                }
            }

            var modelImplementationCode = modelImplementationItems.Where(_ => _ != null).ToNewLineDelimited();

            var codeTemplate = typeof(ModelImplementationGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.Model, KeyMethodKinds.Both);

            var result = codeTemplate
                .Replace(Tokens.CodeGenAssemblyNameToken, GenerationShared.GetCodeGenAssemblyName())
                .Replace(Tokens.CodeGenAssemblyVersionToken, GenerationShared.GetCodeGenAssemblyVersion())
                .Replace(Tokens.ModelTypeNamespaceToken, modelType.TypeNamespace)
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                .Replace(Tokens.RequiredInterfacesToken, modelType.RequiredInterfaces.Select(_ => _.ToStringCompilable()).ToDelimitedString(", "))
                .Replace(Tokens.ModelImplementationToken, modelImplementationCode);

            return result;
        }

        /// <summary>
        /// Generates unit test code.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <param name="kind">Specifies the kind of code to generate.</param>
        /// <returns>
        /// Generated equality methods.
        /// </returns>
        public static string GenerateCodeForTests(
            this ModelType modelType,
            GenerateFor kind)
        {
            var testImplementationItems = new List<string>();

            if (kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithSerialization) && modelType.RequiresModel)
            {
                var serializationFieldsCode = modelType.GenerateSerializationTestFields().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(serializationFieldsCode);
            }

            if (modelType.RequiresEquality || modelType.RequiresHashing)
            {
                var equalityFieldsCode = modelType.GenerateEqualityTestFields().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                if (equalityFieldsCode != null)
                {
                    testImplementationItems.Add(string.Empty);

                    testImplementationItems.Add(equalityFieldsCode);
                }
            }

            if (modelType.RequiresComparability)
            {
                var comparableTestFields = modelType.GenerateComparableTestFields().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(comparableTestFields);
            }

            var structuralTestMethodsCode = modelType.GenerateStructuralTestMethods().ReplaceCodeAnalysisSuppressionTokensInTestCode();

            testImplementationItems.Add(string.Empty);

            testImplementationItems.Add(structuralTestMethodsCode);

            if (modelType.RequiresStringRepresentation)
            {
                var stringTestMethodsCode = modelType.GenerateStringRepresentationTestMethods().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                if (!string.IsNullOrWhiteSpace(stringTestMethodsCode))
                {
                    testImplementationItems.Add(string.Empty);

                    testImplementationItems.Add(stringTestMethodsCode);
                }
            }

            if (modelType.RequiresModel)
            {
                var constructorTestMethodsCode = modelType.GenerateConstructorTestMethods().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                if (constructorTestMethodsCode != null)
                {
                    testImplementationItems.Add(string.Empty);

                    testImplementationItems.Add(constructorTestMethodsCode);
                }
            }

            if (modelType.RequiresDeepCloning)
            {
                var cloningTestMethodsCode = modelType.GenerateCloningTestMethods().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(cloningTestMethodsCode);
            }

            if (kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithSerialization) && modelType.RequiresModel)
            {
                var serializationTestMethodsCode = modelType.GenerateSerializationTestMethods().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(serializationTestMethodsCode);
            }

            if (modelType.RequiresEquality)
            {
                var equalityTestMethodsCode = modelType.GenerateEqualityTestMethods().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(equalityTestMethodsCode);
            }

            if (modelType.RequiresHashing)
            {
                var hashingTestMethodsCode = modelType.GenerateHashingTestMethods().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(hashingTestMethodsCode);
            }

            if (modelType.RequiresComparability)
            {
                var comparabilityTestMethodsCode = modelType.GenerateComparabilityTestMethods().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(comparabilityTestMethodsCode);
            }

            var testImplementationCode = testImplementationItems.Where(_ => _ != null).ToNewLineDelimited();

            var codeTemplate = typeof(ModelImplementationGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.Test, KeyMethodKinds.Both);

            var result = codeTemplate
                .Replace(Tokens.CodeGenAssemblyNameToken, GenerationShared.GetCodeGenAssemblyName())
                .Replace(Tokens.CodeGenAssemblyVersionToken, GenerationShared.GetCodeGenAssemblyVersion())
                .Replace(Tokens.ModelTypeNamespaceToken, modelType.TypeNamespace)
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                .Replace(Tokens.TestImplementationToken, testImplementationCode);

            return result;
        }

        /// <summary>
        /// Generates the code for the dummy factory.
        /// </summary>
        /// <param name="dummyFactoryTypeNamespace">The dummy factory type's namespace.</param>
        /// <param name="dummyFactoryTypeName">The dummy factory type name.</param>
        /// <param name="dummyFactorySnippets">The dummy factory snippets.</param>
        /// <returns>
        /// The dummy factory code.
        /// </returns>
        public static string GenerateCodeForDummyFactory(
            string dummyFactoryTypeNamespace,
            string dummyFactoryTypeName,
            IReadOnlyList<string> dummyFactorySnippets)
        {
            var codeTemplate = typeof(ModelImplementationGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.DummyFactory, KeyMethodKinds.Both);

            var result = codeTemplate
                .Replace(Tokens.CodeGenAssemblyNameToken, GenerationShared.GetCodeGenAssemblyName())
                .Replace(Tokens.CodeGenAssemblyVersionToken, GenerationShared.GetCodeGenAssemblyVersion())
                .Replace(Tokens.DummyFactoryTypeNamespaceToken, dummyFactoryTypeNamespace)
                .Replace(Tokens.DummyFactoryTypeNameToken, dummyFactoryTypeName)
                .Replace(Tokens.DummyFactorySnippetsToken, dummyFactorySnippets.Any() ? Environment.NewLine + dummyFactorySnippets.ToDelimitedString(Environment.NewLine + Environment.NewLine) : string.Empty);

            return result;
        }

        /// <summary>
        /// Generates the code for the dummy factory tests.
        /// </summary>
        /// <param name="dummyFactoryTypeNamespace">The dummy factory type's namespace.</param>
        /// <param name="dummyFactoryTypeName">The dummy factory type name.</param>
        /// <returns>
        /// The dummy factory code.
        /// </returns>
        public static string GenerateCodeForDummyFactoryTests(
            string dummyFactoryTypeNamespace,
            string dummyFactoryTypeName)
        {
            var codeTemplate = typeof(ModelImplementationGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.DummyFactoryTest, KeyMethodKinds.Both);

            var result = codeTemplate
                .Replace(Tokens.CodeGenAssemblyNameToken, GenerationShared.GetCodeGenAssemblyName())
                .Replace(Tokens.CodeGenAssemblyVersionToken, GenerationShared.GetCodeGenAssemblyVersion())
                .Replace(Tokens.DummyFactoryTypeNamespaceToken, dummyFactoryTypeNamespace)
                .Replace(Tokens.DummyFactoryTypeNameToken, dummyFactoryTypeName);

            return result;
        }
    }
}