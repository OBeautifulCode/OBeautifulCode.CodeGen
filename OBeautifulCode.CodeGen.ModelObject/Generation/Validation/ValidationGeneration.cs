// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;
    using static System.FormattableString;

    /// <summary>
    /// Generates code related to validation.
    /// </summary>
    internal static class ValidationGeneration
    {
        /// <summary>
        /// Generates equality methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated validation methods.
        /// </returns>
        public static string GenerateValidationMethods(
            this ModelType modelType)
        {
            var codeTemplate = typeof(ValidationGeneration).GetCodeTemplate(
                modelType.ClassifiedHierarchyKind,
                CodeTemplateKind.Model,
                KeyMethodKinds.Both);

            var getSelfValidationFailuresMethod = string.Empty;

            if (!modelType.DeclaresGetSelfValidationFailuresMethod)
            {
                getSelfValidationFailuresMethod = typeof(ValidationGeneration).GetCodeTemplate(
                    modelType.HierarchyKind,
                    CodeTemplateKind.ModelSnippet,
                    modelType.ValidationKeyMethodKinds,
                    CodeSnippetKind.GetSelfValidationFailures);

                getSelfValidationFailuresMethod = Environment.NewLine + Environment.NewLine + getSelfValidationFailuresMethod;
            }

            string methodOverridingKeyword;
            switch (modelType.HierarchyKind)
            {
                case HierarchyKind.AbstractBaseInherited:
                case HierarchyKind.ConcreteInherited:
                    methodOverridingKeyword = "override ";
                    break;
                case HierarchyKind.AbstractBaseRoot:
                    methodOverridingKeyword = "virtual ";
                    break;
                case HierarchyKind.Standalone:
                    methodOverridingKeyword = string.Empty;
                    break;
                default:
                    throw new NotSupportedException(Invariant($"This {nameof(HierarchyKind)} is not supported: {modelType.HierarchyKind}."));
            }

            var validatePropertiesCode = string.Empty;

            if ((modelType.ClassifiedHierarchyKind == ClassifiedHierarchyKind.Concrete) && modelType.PropertiesOfConcern.Any())
            {
                validatePropertiesCode += Environment.NewLine;
                validatePropertiesCode += "                IReadOnlyList<ValidationFailure> localValidationFailures;";

                var validatePropertyTemplate = typeof(ValidationGeneration).GetCodeTemplate(
                    modelType.ClassifiedHierarchyKind,
                    CodeTemplateKind.ModelSnippet,
                    KeyMethodKinds.Both,
                    CodeSnippetKind.GetValidationFailuresSingleProperty);

                foreach (var property in modelType.PropertiesOfConcern)
                {
                    validatePropertiesCode += Environment.NewLine + Environment.NewLine;
                    validatePropertiesCode += validatePropertyTemplate.Replace(Tokens.PropertyNameToken, property.Name);
                }
            }

            var result = codeTemplate
                .Replace(Tokens.MethodOverridingKeywordToken, methodOverridingKeyword)
                .Replace(Tokens.GetSelfValidationFailuresMethodToken, getSelfValidationFailuresMethod)
                .Replace(Tokens.ValidatePropertiesToken, validatePropertiesCode);

            return result;
        }

        /// <summary>
        /// Generates fields required to test validation.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated fields required to test validation.
        /// </returns>
        public static string GenerateValidationTestFields(
            this ModelType modelType)
        {
            if (!modelType.IsConcrete)
            {
                return null;
            }

            var result = typeof(ValidationGeneration).GetCodeTemplate(
                    modelType.ClassifiedHierarchyKind,
                    CodeTemplateKind.TestSnippet,
                    KeyMethodKinds.Both,
                    CodeSnippetKind.ValidModelTestFields)
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString);

            return result;
        }

        /// <summary>
        /// Generates tests for validation methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated tests for the validation methods.
        /// </returns>
        public static string GenerateValidationTestMethods(
            this ModelType modelType)
        {
            if (!modelType.IsConcrete)
            {
                return null;
            }

            var result = typeof(ValidationGeneration).GetCodeTemplate(
                modelType.ClassifiedHierarchyKind,
                CodeTemplateKind.Test,
                KeyMethodKinds.Both);

            return result;
        }
    }
}