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
                    .InheritancePathTypeNamesInCode
                    .Reverse()
                    .Select(_ => compareToForRelativeSortOrderSnippet.Replace(Tokens.ModelAncestorTypeNameToken, _))
                    .ToDelimitedString(Environment.NewLine + Environment.NewLine);
            }

            var result = codeTemplate
                .Replace(Tokens.CompareToToken, compareToSnippet)
                .Replace(Tokens.CompareToForRelativeSortOrderToken, compareToForRelativeSortOrderSnippets)
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                .Replace(Tokens.ModelTypeNameInXmlDocToken, modelType.TypeNameInXmlDocString)
                .Replace(Tokens.ModelTypeNameInIdentifierToken, modelType.TypeNameInIdentifierString);

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
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString);

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

            for (int x = 0; x < modelType.DerivativePathTypesNamesInCodeFromRootToSelf.Count; x++)
            {
                var derivativeTypeNameInCode = modelType.DerivativePathTypesNamesInCodeFromRootToSelf[x];
                var derivativeTypeNameInIdentifier = modelType.DerivativePathTypesNamesInIdentifierFromRootToSelf[x];

                var compareToItem = compareToTestTemplate
                    .Replace(Tokens.ModelTypeNameInCodeToken, derivativeTypeNameInCode)
                    .Replace(Tokens.ModelTypeNameInTestMethodNameToken, derivativeTypeNameInIdentifier)
                    .Replace(Tokens.CastToken, derivativeTypeNameInCode == modelType.TypeNameInCodeString ? string.Empty : Invariant($"({derivativeTypeNameInCode})"));

                var compareToForRelativeSortOrderItem = compareToForRelativeSortOrderTestTemplate
                    .Replace(Tokens.ModelTypeNameInCodeToken, derivativeTypeNameInCode)
                    .Replace(Tokens.ModelTypeNameInTestMethodNameToken, derivativeTypeNameInIdentifier)
                    .Replace(Tokens.CastToken, derivativeTypeNameInCode == modelType.TypeNameInCodeString ? string.Empty : Invariant($"({derivativeTypeNameInCode})"));

                compareToItems.Add(compareToItem);
                compareToForRelativeSortOrderItems.Add(compareToForRelativeSortOrderItem);
            }

            var codeTemplate = typeof(ComparisonGeneration).GetCodeTemplate(CodeTemplateKind.Test, KeyMethodKinds.Both);

            var result = codeTemplate
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                .Replace(Tokens.ModelTypeNameInTestMethodNameToken, modelType.TypeNameInIdentifierString)
                .Replace(Tokens.CompareToTestsToken, compareToItems.ToDelimitedString(Environment.NewLine + Environment.NewLine) + Environment.NewLine)
                .Replace(Tokens.CompareToForRelativeSortOrderTestsToken, compareToForRelativeSortOrderItems.ToDelimitedString(Environment.NewLine + Environment.NewLine));

            return result;
        }
    }
}