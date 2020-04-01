// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComparisonGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Collection.Recipes;

    using static System.FormattableString;

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
            var codeTemplate = typeof(ComparisonGeneration).GetCodeTemplate(CodeTemplateKind.Model, KeyMethodKinds.Both);

            var compareToSnippet = typeof(ComparisonGeneration).GetCodeTemplate(modelType.HierarchyKind, CodeTemplateKind.ModelSnippet, modelType.CompareToKeyMethodKinds, CodeSnippetKind.CompareTo);

            var compareToForRelativeSortOrderSnippets = string.Empty;

            if (modelType.HierarchyKind == HierarchyKind.ConcreteInherited)
            {
                var compareToForRelativeSortOrderSnippet = typeof(ComparisonGeneration).GetCodeTemplate(modelType.HierarchyKind, CodeTemplateKind.ModelSnippet, modelType.CompareToKeyMethodKinds, CodeSnippetKind.CompareToForRelativeSortOrder);

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
            var result = typeof(ComparisonGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ComparableTestFields)
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
            var compareToTestTemplate = typeof(ComparisonGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.CompareToTests);
            var compareToForRelativeSortOrderTestTemplate = typeof(ComparisonGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.CompareToForRelativeSortOrderTests);

            var compareToItems = new List<string>();
            var compareToForRelativeSortOrderItems = new List<string>();

            foreach (var typeCompilableString in modelType.DerivativePathFromRootToSelfCompilableStrings)
            {
                var compareToItem = compareToTestTemplate
                    .Replace(Tokens.ModelTypeNameToken, typeCompilableString)
                    .Replace(Tokens.CastToken, typeCompilableString == modelType.TypeCompilableString ? string.Empty : Invariant($"({typeCompilableString})"));

                var compareToForRelativeSortOrderItem = compareToForRelativeSortOrderTestTemplate
                    .Replace(Tokens.ModelTypeNameToken, typeCompilableString)
                    .Replace(Tokens.CastToken, typeCompilableString == modelType.TypeCompilableString ? string.Empty : Invariant($"({typeCompilableString})"));

                compareToItems.Add(compareToItem);
                compareToForRelativeSortOrderItems.Add(compareToForRelativeSortOrderItem);
            }

            var codeTemplate = typeof(ComparisonGeneration).GetCodeTemplate(CodeTemplateKind.Test, KeyMethodKinds.Both);

            var result = codeTemplate
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                .Replace(Tokens.CompareToTestsToken, compareToItems.ToDelimitedString(Environment.NewLine + Environment.NewLine) + Environment.NewLine)
                .Replace(Tokens.CompareToForRelativeSortOrderTestsToken, compareToForRelativeSortOrderItems.ToDelimitedString(Environment.NewLine + Environment.NewLine));

            return result;
        }
    }
}