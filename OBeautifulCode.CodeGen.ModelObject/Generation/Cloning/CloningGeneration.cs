﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CloningGeneration.cs" company="OBeautifulCode">
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

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to cloning.
    /// </summary>
    internal static class CloningGeneration
    {
        /// <summary>
        /// Generates cloning methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated cloning methods.
        /// </returns>
        public static string GenerateCloningMethods(
            this ModelType modelType)
        {
            var deepCloneCode = modelType.GenerateDeepCloneCode();

            var deepCloneWithCode = modelType.ShouldGenerateDeepCloneWithMethods()
                ? modelType.GenerateDeepCloneWithCode()
                : string.Empty;

            var codeTemplate = typeof(CloningGeneration).GetCodeTemplate(modelType.HierarchyKind, CodeTemplateKind.Model, modelType.DeepCloneKeyMethodKinds);

            var result = codeTemplate
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                .Replace(Tokens.ModelRootAncestorTypeNameInCodeToken, modelType.InheritancePathTypeNamesInCode.LastOrDefault())
                .Replace(Tokens.DeepCloneToken, deepCloneCode)
                .Replace(Tokens.DeepCloneWithToken, deepCloneWithCode);

            return result;
        }

        /// <summary>
        /// Generates fields required to test a model's DeepCloneWith methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test fields.
        /// </returns>
        public static string GenerateDeepCloneWithTestFields(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            if (!modelType.ShouldGenerateDeepCloneWithTesting())
            {
                return null;
            }

            var deepCloneWithScenarios = new List<string>();

            var properties = modelType.PropertiesOfConcern;

            foreach (var property in properties)
            {
                if (!modelType.IsMissingCorrespondingConstructorParameter(property))
                {
                    var scenario = typeof(CloningGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.TestSnippet, modelType.DeepCloneKeyMethodKinds, CodeSnippetKind.DeepCloneWithScenario)
                        .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                        .Replace(Tokens.PropertyNameToken, property.Name)
                        .Replace(Tokens.ParameterNameToken, property.ToParameterName());

                    deepCloneWithScenarios.Add(scenario);
                }
            }

            var deepCloneWithScenariosCode = deepCloneWithScenarios.Any() ? Environment.NewLine + string.Join(Environment.NewLine, deepCloneWithScenarios) : string.Empty;

            var result = typeof(CloningGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.TestSnippet, modelType.DeepCloneKeyMethodKinds, CodeSnippetKind.DeepCloneWithTestFields)
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                .Replace(Tokens.DeepCloneWithTestScenariosToken, deepCloneWithScenariosCode);

            return result;
        }

        /// <summary>
        /// Generates test methods that test cloning.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test cloning.
        /// </returns>
        public static string GenerateCloningTestMethods(
            this ModelType modelType)
        {
            var assertDeepCloneTemplate = typeof(CloningGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.DeepClone);

            var assertDeepCloneStatements = modelType
                .PropertiesOfConcern
                .Where(_ => !_.PropertyType.IsValueType && _.PropertyType != typeof(string))
                .Select(_ => assertDeepCloneTemplate.Replace(Tokens.PropertyNameToken, _.Name))
                .ToList();

            var assertDeepCloneStatementsCode = assertDeepCloneStatements.Any()
                ? Environment.NewLine + Environment.NewLine + string.Join(Environment.NewLine + Environment.NewLine, assertDeepCloneStatements)
                : string.Empty;

            var deepCloneWithTestCode = modelType.ShouldGenerateDeepCloneWithTesting()
                ? Environment.NewLine + Environment.NewLine + typeof(CloningGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.TestSnippet, modelType.DeepCloneKeyMethodKinds, CodeSnippetKind.DeepCloneWithTest)
                : string.Empty;

            var propertiesOfConcernNames = modelType.PropertiesOfConcern.Select(_ => "\"" + _.Name + "\"").ToDelimitedString(", ");

            var deepCloneWithThrowsTestMethods = new List<string>();

            foreach (var property in modelType.PropertiesOfConcern)
            {
                if (modelType.IsMissingCorrespondingConstructorParameter(property))
                {
                    var deepCloneWithThrowsTestMethod =
                        typeof(CloningGeneration).GetCodeTemplate(modelType.HierarchyKind, CodeTemplateKind.TestSnippet, modelType.DeepCloneKeyMethodKinds, CodeSnippetKind.DeepCloneWithThrows)
                            .Replace(Tokens.PropertyNameToken, property.Name)
                            .Replace(Tokens.PropertyTypeNameToken, property.PropertyType.ToStringReadable())
                            .Replace(Tokens.ParameterNameToken, property.ToParameterName());

                    deepCloneWithThrowsTestMethods.Add(deepCloneWithThrowsTestMethod);
                }
            }

            var deepCloneWithThrowsTestMethodsCode = (modelType.DeclaresDeepCloneMethod || (!modelType.PropertiesOfConcern.Any()) || (!deepCloneWithThrowsTestMethods.Any()))
                ? string.Empty
                : Environment.NewLine + Environment.NewLine + deepCloneWithThrowsTestMethods.ToDelimitedString(Environment.NewLine + Environment.NewLine);

            var codeTemplate = typeof(CloningGeneration).GetCodeTemplate(CodeTemplateKind.Test, KeyMethodKinds.Both);

            var result = codeTemplate
                .Replace(Tokens.AssertDeepCloneToken, assertDeepCloneStatementsCode)
                .Replace(Tokens.DeepCloneWithTestToken, deepCloneWithTestCode)
                .Replace(Tokens.DeepCloneWithThrowsTestsToken, deepCloneWithThrowsTestMethodsCode)
                .Replace(Tokens.PropertiesOfConcernNamesHereToken, propertiesOfConcernNames)
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString);

            return result;
        }

        private static string GenerateDeepCloneCode(
            this ModelType modelType)
        {
            var deepCloneCodeForEachProperty = modelType
                .PropertiesOfConcern
                .Select(_ => new MemberCode(_.Name, Invariant($"{modelType.CastIfConstructorParameterIsOfDifferentType(_)}{_.PropertyType.GenerateCloningLogicCodeForType("this." + _.Name)}")))
                .ToList();

            var result = modelType.GenerateModelInstantiation(deepCloneCodeForEachProperty, parameterPaddingLength: 33);

            return result;
        }

        private static string GenerateDeepCloneWithCode(
            this ModelType modelType)
        {
            var deepCloneWithMethods = new List<string>();

            foreach (var property in modelType.PropertiesOfConcern)
            {
                if (modelType.IsAbstractBase && (!modelType.DeclaresProperty(property)))
                {
                    continue;
                }

                var propertiesCode = modelType.PropertiesOfConcern.Select(_ =>
                {
                    var referenceItemCloned = _.PropertyType.GenerateCloningLogicCodeForType("this." + _.Name);

                    var code = _.Name == property.Name
                        ? property.ToParameterName()
                        : referenceItemCloned;

                    code = modelType.CastIfConstructorParameterIsOfDifferentType(_) + code;

                    return new MemberCode(_.Name, code);
                }).ToList();

                var deepCloneWithModelInstantiationCode = modelType.GenerateModelInstantiation(propertiesCode, parameterPaddingLength: 33);

                var effectiveHierarchyKind = (modelType.HierarchyKind == HierarchyKind.ConcreteInherited) && modelType.DeclaresProperty(property)
                    ? HierarchyKind.Standalone
                    : modelType.HierarchyKind;

                var deepCloneWithMethodTemplate = modelType.IsMissingCorrespondingConstructorParameter(property)
                    ? typeof(CloningGeneration).GetCodeTemplate(modelType.HierarchyKind, CodeTemplateKind.ModelSnippet, modelType.DeepCloneKeyMethodKinds, CodeSnippetKind.DeepCloneWithThrows)
                    : typeof(CloningGeneration).GetCodeTemplate(effectiveHierarchyKind, CodeTemplateKind.ModelSnippet, modelType.DeepCloneKeyMethodKinds, CodeSnippetKind.DeepCloneWith);

                var deepCloneWithMethod = deepCloneWithMethodTemplate
                    .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                    .Replace(Tokens.ModelTypeNameInXmlDocToken, modelType.TypeNameInXmlDocString)
                    .Replace(Tokens.ModelAncestorTypeNameToken, property.DeclaringType.ToStringReadable())
                    .Replace(Tokens.PropertyNameToken, property.Name)
                    .Replace(Tokens.ParameterNameToken, property.ToParameterName())
                    .Replace(Tokens.ParameterNameInXmlDocToken, property.ToParameterName(forXmlDoc: true))
                    .Replace(Tokens.PropertyTypeNameToken, property.PropertyType.ToStringReadable())
                    .Replace(Tokens.DeepCloneWithModelInstantiationToken, deepCloneWithModelInstantiationCode);

                deepCloneWithMethods.Add(deepCloneWithMethod);
            }

            var result = deepCloneWithMethods.Any()
                ? Environment.NewLine + Environment.NewLine + string.Join(Environment.NewLine + Environment.NewLine, deepCloneWithMethods)
                : string.Empty;

            result = result
                .Replace(Tokens.DeepCloneWithCodeAnalysisSuppressionsToken, typeof(CloningGeneration).GetCodeTemplate(CodeTemplateKind.ModelSnippet, KeyMethodKinds.Both, CodeSnippetKind.DeepCloneWithCodeAnalysisSuppressions));

            return result;
        }

        private static string GenerateCloningLogicCodeForType(
            this Type type,
            string cloneCode)
        {
            type.AsArg(nameof(type)).Must().NotBeNull();

            string result;

            if (type.IsGenericParameter)
            {
                result = Invariant($"{cloneCode} == null ? default : {cloneCode}.DeepClone()");
            }
            else if (type.IsTypeAssignableToNull())
            {
                result = Invariant($"{cloneCode}?.DeepClone()");
            }
            else
            {
                result = Invariant($"{cloneCode}.DeepClone()");
            }

            return result;
        }

        private static bool ShouldGenerateDeepCloneWithMethods(
            this ModelType modelType)
        {
            var result =
                (!modelType.DeclaresDeepCloneMethod) &&
                (!modelType.ForsakesDeepCloneWithVariantMethods) &&
                modelType.PropertiesOfConcern.Any();

            return result;
        }

        private static bool ShouldGenerateDeepCloneWithTesting(
            this ModelType modelType)
        {
            var result = modelType.ShouldGenerateDeepCloneWithMethods() && (!modelType.IsAbstractBase);

            return result;
        }
    }
}