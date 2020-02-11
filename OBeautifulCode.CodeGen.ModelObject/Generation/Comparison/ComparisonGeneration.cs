// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComparisonGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;

    using OBeautifulCode.Collection.Recipes;

    /// <summary>
    /// Generates code related to comparisons.
    /// </summary>
    internal static class ComparisonGeneration
    {
        /// <summary>
        /// Generates comparable methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated comparable methods.
        /// </returns>
        public static string GenerateComparableMethods(
            this ModelType modelType)
        {
            var codeTemplate = typeof(ComparisonGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.Model, KeyMethodKinds.Both);

            var compareToSnippet = typeof(ComparisonGeneration).GetCodeTemplate(modelType.HierarchyKinds, CodeTemplateKind.ModelSnippet, modelType.CompareToKeyMethodKinds, CodeSnippetKind.CompareTo);

            var compareToForRelativeSortOrderSnippets = string.Empty;

            if (modelType.HierarchyKind == HierarchyKind.ConcreteInherited)
            {
                var compareToForRelativeSortOrderSnippet = typeof(ComparisonGeneration).GetCodeTemplate(modelType.HierarchyKinds, CodeTemplateKind.ModelSnippet, modelType.CompareToKeyMethodKinds, CodeSnippetKind.CompareToForRelativeSortOrder);

                compareToForRelativeSortOrderSnippets = Environment.NewLine + Environment.NewLine + modelType
                    .InheritancePathCompilableStrings
                    .Reverse()
                    .Select(_ => compareToForRelativeSortOrderSnippet.Replace(Tokens.ModelAncestorTypeNameToken, _))
                    .ToDelimitedString(Environment.NewLine + Environment.NewLine);
            }

            var result = codeTemplate
                .Replace(Tokens.CompareToToken, compareToSnippet)
                .Replace(Tokens.CompareToForRelativeSortOrderToken, compareToForRelativeSortOrderSnippets)
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString);

            return result;
        }

        /// <summary>
        /// Generates fields required to test comparability.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated fields required to test comparability.
        /// </returns>
        public static string GenerateComparableTestFields(
            this ModelType modelType)
        {
            var result = typeof(ComparisonGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ComparableTestFields)
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString);

            return result;
        }

        /// <summary>
        /// Generates test methods that test comparability.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test comparability.
        /// </returns>
        public static string GenerateComparabilityTestMethods(
            this ModelType modelType)
        {
            var result = typeof(ComparisonGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.Test, KeyMethodKinds.Both)
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString);

            return result;
        }
    }
}