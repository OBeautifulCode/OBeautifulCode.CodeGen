// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelImplementationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
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
                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(modelType.GenerateSerializationTestFields());
            }

            if (modelType.RequiresEquality || modelType.RequiresHashing)
            {
                var equalityFieldsCode = modelType.GenerateEqualityTestFields();

                if (equalityFieldsCode != null)
                {
                    testImplementationItems.Add(string.Empty);

                    testImplementationItems.Add(equalityFieldsCode);
                }
            }

            if (modelType.RequiresComparability)
            {
                var comparableTestFields = modelType.GenerateComparableTestFields();

                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(comparableTestFields);
            }

            testImplementationItems.Add(string.Empty);

            testImplementationItems.Add(modelType.GenerateStructuralTestMethods());

            if (modelType.RequiresStringRepresentation)
            {
                var stringTestMethodsCode = modelType.GenerateStringRepresentationTestMethods();

                if (!string.IsNullOrWhiteSpace(stringTestMethodsCode))
                {
                    testImplementationItems.Add(string.Empty);

                    testImplementationItems.Add(stringTestMethodsCode);
                }
            }

            if (modelType.RequiresModel)
            {
                var constructorTestMethodsCode = modelType.GenerateConstructorTestMethods();

                if (constructorTestMethodsCode != null)
                {
                    testImplementationItems.Add(string.Empty);

                    testImplementationItems.Add(constructorTestMethodsCode);
                }
            }

            if (modelType.RequiresDeepCloning)
            {
                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(modelType.GenerateCloningTestMethods());
            }

            if (kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithSerialization) && modelType.RequiresModel)
            {
                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(modelType.GenerateSerializationTestMethods());
            }

            if (modelType.RequiresEquality)
            {
                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(modelType.GenerateEqualityTestMethods());
            }

            if (modelType.RequiresHashing)
            {
                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(modelType.GenerateHashingTestMethods());
            }

            if (modelType.RequiresComparability)
            {
                testImplementationItems.Add(string.Empty);

                testImplementationItems.Add(modelType.GenerateComparabilityTestMethods());
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
    }
}