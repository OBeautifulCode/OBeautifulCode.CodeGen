﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringRepresentationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;
    using System.Reflection;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to string representation of model types.
    /// </summary>
    internal static class StringRepresentationGeneration
    {
        /// <summary>
        /// Generates the string representation methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated string representation methods.
        /// </returns>
        public static string GenerateStringRepresentationMethods(
            this ModelType modelType)
        {
            var codeTemplate = typeof(StringRepresentationGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.Model, modelType.ToStringKeyMethodKinds);

            var toStringStatement = modelType.GenerateToStringConstructionCode(useSystemUnderTest: false, forModelObject: true);

            var result = codeTemplate
                .Replace(Tokens.ToStringStatementToken, toStringStatement);

            return result;
        }

        /// <summary>
        /// Generates fields required to test a model's string representation.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test fields.
        /// </returns>
        public static string GenerateStringRepresentationTestFields(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            if (!modelType.IsConcrete)
            {
                return null;
            }

            var toStringConstructionCode = modelType.GenerateToStringConstructionCode(useSystemUnderTest: true, forModelObject: false);

            var result = typeof(StringRepresentationGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.TestSnippet, modelType.ToStringKeyMethodKinds, CodeSnippetKind.StringRepresentationTestFields)
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                .Replace(Tokens.ToStringExpectedToken, toStringConstructionCode);

            return result;
        }

        /// <summary>
        /// Generates tests for the string representation methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated tests for the string representation methods.
        /// </returns>
        public static string GenerateStringRepresentationTestMethods(
            this ModelType modelType)
        {
            if (!modelType.IsConcrete)
            {
                return null;
            }

            var result = typeof(StringRepresentationGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.Test, KeyMethodKinds.Both);

            return result;
        }

        private static string GenerateToStringConstructionCode(
            this ModelType modelType,
            bool useSystemUnderTest,
            bool forModelObject)
        {
            var propertyToStrings = modelType.PropertiesOfConcern.Select(_ => _.GenerateToStringForProperty(useSystemUnderTest)).ToList();

            var propertyToString = propertyToStrings.Any()
                ? string.Join(", ", propertyToStrings)
                : "<no properties>";

            var typeNameToUse = modelType.GenericParameters.Any() && forModelObject
                ? Invariant($"{{this.GetType().ToStringReadable()}}")
                : modelType.TypeNameInCodeString;

            var result = Invariant($"Invariant($\"{modelType.TypeNamespace}.{typeNameToUse}: {propertyToString}.\")");

            return result;
        }

        private static string GenerateToStringForProperty(
            this PropertyOfConcern propertyOfConcern,
            bool useSystemUnderTest)
        {
            var name = propertyOfConcern.Name;
            var type = propertyOfConcern.PropertyType;

            var takesFormatProviderType = type;

            // an open nullable type will just result in the generic parameter as it's underlying type,
            // which is why we purposefully only check for closed nullable types here.
            if (type.IsClosedNullableType())
            {
                takesFormatProviderType = Nullable.GetUnderlyingType(type);
            }

            // ReSharper disable once PossibleNullReferenceException
            var takesFormatProvider = takesFormatProviderType.GetMethods().Where(_ => _.Name == "ToString").Where(_ => !_.IsObsolete()).Where(_ => _.GetParameters().Length == 1).Any(_ => typeof(IFormatProvider).IsAssignableFrom(_.GetParameters().Single().ParameterType));

            var result = name + " = {" + (useSystemUnderTest ? "systemUnderTest" : "this") + "." + name + (type.IsTypeAssignableToNull() ? "?" : string.Empty) + ".ToString(" + (takesFormatProvider ? "CultureInfo.InvariantCulture" : string.Empty) + ") ?? \"<null>\"}";

            return result;
        }

        private static bool IsObsolete(
            this MethodInfo methodInfo)
        {
            var result = methodInfo.GetCustomAttributes(false).OfType<ObsoleteAttribute>().Any();

            return result;
        }
    }
}