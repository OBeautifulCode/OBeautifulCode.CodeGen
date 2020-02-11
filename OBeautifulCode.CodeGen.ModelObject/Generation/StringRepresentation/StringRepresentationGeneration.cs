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

    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to string representation of model types.
    /// </summary>
    internal static class StringRepresentationGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";
        private const string ToStringTestToken = "<<<ToStringConstructionForTestHere>>>";

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
            var codeTemplate = typeof(StringRepresentationGeneration).GetCodeTemplate(modelType.HierarchyKinds.Classify(), CodeTemplateKind.Model, modelType.ToStringKeyMethodKinds);

            var toStringStatement = modelType.GenerateToStringConstructionCode(useSystemUnderTest: false);

            var result = codeTemplate
                .Replace(Tokens.ToStringStatementToken, toStringStatement);

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
            string result = null;

            if ((!modelType.DeclaresToStringMethodDirectlyOrInDerivative) && modelType.IsConcrete)
            {
                var toStringConstructionCode = modelType.GenerateToStringConstructionCode(useSystemUnderTest: true);

                result = typeof(StringRepresentationGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.Test, KeyMethodKinds.Both)
                    .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                    .Replace(Tokens.ToStringExpectedToken, toStringConstructionCode);
            }

            return result;
        }

        private static string GenerateToStringConstructionCode(
            this ModelType modelType,
            bool useSystemUnderTest)
        {
            var propertyToStrings = modelType.PropertiesOfConcern.Select(_ => _.GenerateToStringForProperty(useSystemUnderTest)).ToList();

            var propertyToString = propertyToStrings.Any()
                ? string.Join(", ", propertyToStrings)
                : "<no properties>";

            var result = Invariant($"Invariant($\"{{nameof({modelType.TypeNamespace})}}.{{nameof({modelType.TypeCompilableString})}}: {propertyToString}.\")");

            return result;
        }

        private static string GenerateToStringForProperty(
            this PropertyOfConcern propertyOfConcern,
            bool useSystemUnderTest)
        {
            var name = propertyOfConcern.Name;
            var type = propertyOfConcern.PropertyType;

            var takesFormatProvider = type.GetMethods().Where(_ => _.Name == "ToString").Where(_ => !_.IsObsolete()).Where(_ => _.GetParameters().Length == 1).Any(_ => _.GetParameters().Single().ParameterType.IsAssignableTo(typeof(IFormatProvider)));

            var result = name + " = {" + (useSystemUnderTest ? "systemUnderTest" : "this") + "." + name + (type.IsAssignableToNull() ? "?" : string.Empty) + ".ToString(" + (takesFormatProvider ? "CultureInfo.InvariantCulture" : string.Empty) + ") ?? \"<null>\"}";

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