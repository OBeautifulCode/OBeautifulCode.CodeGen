// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelImplementationGeneration.cs" company="OBeautifulCode">
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
                .Replace(Tokens.UsingStatementsToken, modelType.GetUsingStatementsForModelObject())
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
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
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

            if (modelType.RequiresStringRepresentation)
            {
                var stringFieldsCode = modelType.GenerateStringRepresentationTestFields().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                if (!string.IsNullOrWhiteSpace(stringFieldsCode))
                {
                    testImplementationItems.Add(string.Empty);

                    testImplementationItems.Add(stringFieldsCode);
                }
            }

            if (modelType.RequiresModel)
            {
                var constructorFieldsCode = modelType.GenerateConstructorTestFields().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                if (constructorFieldsCode != null)
                {
                    testImplementationItems.Add(string.Empty);

                    testImplementationItems.Add(constructorFieldsCode);
                }
            }

            if (modelType.RequiresDeepCloning)
            {
                var deepCloneWithFieldsCode = modelType.GenerateDeepCloneWithTestFields().ReplaceCodeAnalysisSuppressionTokensInTestCode();

                if (!string.IsNullOrWhiteSpace(deepCloneWithFieldsCode))
                {
                    testImplementationItems.Add(string.Empty);

                    testImplementationItems.Add(deepCloneWithFieldsCode);
                }
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
                .Replace(Tokens.UsingStatementsToken, modelType.GetUsingStatementsForTestClass(kind))
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
        /// <param name="modelTypes">The model types.</param>
        /// <param name="dummyFactoryTypeNamespace">The dummy factory type's namespace.</param>
        /// <param name="dummyFactoryTypeName">The dummy factory type name.</param>
        /// <returns>
        /// The dummy factory code.
        /// </returns>
        public static string GenerateCodeForDummyFactory(
            IReadOnlyCollection<ModelType> modelTypes,
            string dummyFactoryTypeNamespace,
            string dummyFactoryTypeName)
        {
            var codeTemplate = typeof(ModelImplementationGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.DummyFactory, KeyMethodKinds.Both);

            var dummyFactorySnippets = modelTypes.Select(_ => _.GenerateCodeForDummyFactory()).ToList();

            var result = codeTemplate
                .Replace(Tokens.UsingStatementsToken, modelTypes.GetUsingStatementsForDummyFactory(dummyFactoryTypeNamespace))
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

        private static string GetUsingStatementsForModelObject(
            this ModelType modelType)
        {
            var statements = new[]
            {
                "System",
                "System.CodeDom.Compiler",
                "System.Collections.Concurrent",
                "System.Collections.Generic",
                "System.Collections.ObjectModel",
                "System.Diagnostics.CodeAnalysis",
                "System.Globalization",
                "System.Linq",
                "OBeautifulCode.Equality.Recipes",
                "OBeautifulCode.Type",
                "OBeautifulCode.Type.Recipes",
            };

            var staticStatements = new[]
            {
                "System.FormattableString",
            };

            var result = modelType.PropertiesOfConcern.GetUsingStatements(modelType.TypeNamespace, statements, staticStatements);

            return result;
        }

        private static string GetUsingStatementsForTestClass(
            this ModelType modelType,
            GenerateFor kind)
        {
            var statements = new List<string>
            {
                "System",
                "System.CodeDom.Compiler",
                "System.Collections.Concurrent",
                "System.Collections.Generic",
                "System.Collections.ObjectModel",
                "System.Diagnostics.CodeAnalysis",
                "System.Globalization",
                "System.Linq",
                "System.Reflection",
                "FakeItEasy",
                "OBeautifulCode.Assertion.Recipes",
                "OBeautifulCode.AutoFakeItEasy",
                "OBeautifulCode.CodeGen.ModelObject.Recipes",
                "OBeautifulCode.Equality.Recipes",
                "OBeautifulCode.Math.Recipes",
                "OBeautifulCode.Representation.System",
                "OBeautifulCode.Type",
                "Xunit",
            };

            if (kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithSerialization))
            {
                statements.AddRange(
                    new[]
                    {
                        "OBeautifulCode.Serialization",
                        "OBeautifulCode.Serialization.Bson",
                        "OBeautifulCode.Serialization.Json",
                    });
            }

            var staticStatements = new[]
            {
                "System.FormattableString",
            };

            var result = modelType.PropertiesOfConcern.GetUsingStatements(modelType.TypeNamespace, statements, staticStatements);

            return result;
        }

        private static string GetUsingStatementsForDummyFactory(
            this IReadOnlyCollection<ModelType> modelTypes,
            string containingNamespace)
        {
            var statements = new[]
            {
                "System",
                "System.CodeDom.Compiler",
                "System.Collections.Concurrent",
                "System.Collections.Generic",
                "System.Collections.ObjectModel",
                "System.Diagnostics.CodeAnalysis",
                "FakeItEasy",
                "OBeautifulCode.AutoFakeItEasy",
            };

            var staticStatements = new string[0];

            var result = modelTypes.SelectMany(_ => _.PropertiesOfConcern).ToList().GetUsingStatements(containingNamespace, statements, staticStatements);

            return result;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        private static string GetUsingStatements(
            this IReadOnlyList<PropertyOfConcern> propertiesOfConcern,
            string containingNamespace,
            IReadOnlyCollection<string> statements,
            IReadOnlyCollection<string> staticStatements)
        {
            statements = new string[0]
                .Concat(statements)
                .Concat(propertiesOfConcern.Select(_ => _.PropertyType.Namespace))
                .Where(_ => _ != containingNamespace)
                .Distinct()
                .ToList();

            staticStatements = staticStatements.Distinct().ToList();

            var systemStatementsInOrder = statements.Where(_ => _.Split('.').First() == "System").OrderBy(_ => _).ToList();

            var nonSystemStatementsGroupedByProject = statements.Where(_ => _.Split('.').First() != "System").GroupBy(_ => _.Split('.').First()).OrderBy(_ => _.Key).ToList();

            var result = systemStatementsInOrder.Select(_ => _.ToUsingStatement(isStatic: false)).ToNewLineDelimited();

            foreach (var nonSystemStatements in nonSystemStatementsGroupedByProject)
            {
                result = result + Environment.NewLine + Environment.NewLine + nonSystemStatements.OrderBy(_ => _).Select(_ => _.ToUsingStatement(isStatic: false)).ToNewLineDelimited();
            }

            if (staticStatements.Any())
            {
                result = result + Environment.NewLine + Environment.NewLine + staticStatements.OrderBy(_ => _).Select(_ => _.ToUsingStatement(isStatic: true)).ToNewLineDelimited();
            }

            return result;
        }

        private static string ToUsingStatement(
            this string statement,
            bool isStatic)
        {
            var result = "global::" + statement + ";";

            if (isStatic)
            {
                result = "static " + result;
            }

            result = "    using " + result;

            return result;
        }
    }
}