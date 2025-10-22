// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.DateTime.Recipes;
    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.Type.Recipes;
    using static System.FormattableString;

    /// <summary>
    /// Generates code related to validation.
    /// </summary>
    internal static class ValidationGeneration
    {
        private const string UnknownEnumValueName = "Unknown";

        private static readonly ConcurrentDictionary<Type, bool> EnumTypeToHasUnknownValueMapCache = new ConcurrentDictionary<Type, bool>();

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

            if (modelType.DeclaresGetSelfValidationFailuresMethodInSelfOrInheritancePath)
            {
                var testScenarios = new List<string>();

                foreach (var propertyOfConcern in modelType.PropertiesOfConcern)
                {
                    var thisPropertyScenarios = BuildTestScenarios(
                        modelType,
                        propertyOfConcern);

                    testScenarios.AddRange(thisPropertyScenarios);
                }

                var scenariosCode = testScenarios.Any()
                    ? Environment.NewLine + testScenarios.ToNewLineDelimited()
                    : string.Empty;

                var selfValidationTestField = typeof(ValidationGeneration).GetCodeTemplate(
                        modelType.ClassifiedHierarchyKind,
                        CodeTemplateKind.TestSnippet,
                        KeyMethodKinds.Both,
                        CodeSnippetKind.SelfValidationTestFields)
                    .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                    .Replace(Tokens.SelfValidationTestScenariosToken, scenariosCode);

                // add scenarios here
                result += Environment.NewLine + Environment.NewLine + selfValidationTestField;
            }

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

            var selfValidationTestMethodCode = string.Empty;

            if (modelType.DeclaresGetSelfValidationFailuresMethodInSelfOrInheritancePath)
            {
                selfValidationTestMethodCode = typeof(ValidationGeneration).GetCodeTemplate(
                        modelType.ClassifiedHierarchyKind,
                        CodeTemplateKind.TestSnippet,
                        KeyMethodKinds.Both,
                        CodeSnippetKind.GetSelfValidationFailuresTest);

                selfValidationTestMethodCode = Environment.NewLine + Environment.NewLine + selfValidationTestMethodCode;
            }

            result = result
                .Replace(Tokens.SelfValidationTestMethodToken, selfValidationTestMethodCode);

            return result;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        private static IReadOnlyList<string> BuildTestScenarios(
            ModelType modelType,
            PropertyOfConcern propertyOfConcern)
        {
            var result = new List<string>();

            var propertyType = propertyOfConcern.PropertyType;

            // IMPORTANT: All of the below scenarios mirror the ones in constructor argument validation.
            // Maybe in the future we'll harmonize those code paths, but for now, if something changes here
            // it should be reflected back in the constructor scenarios.
            if (!propertyType.IsValueType)
            {
                // Test for null.
                // Don't test for null value on Nullable types; often enough it's ok for those to be null.
                var scenario = typeof(ValidationGeneration)
                    .GetCodeTemplate(
                        modelType.ClassifiedHierarchyKind,
                        CodeTemplateKind.TestSnippet,
                        KeyMethodKinds.Both,
                        CodeSnippetKind.SelfValidationTestScenario)
                    .Replace(Tokens.TestScenarioNameToken, Invariant($"GetSelfValidationFailures() should return a failure when property '{Tokens.PropertyNameToken}' is null scenario"))
                    .Replace(Tokens.InvalidPropertyValueToken, "null")
                    .Replace(Tokens.ValidationFailureMessageContainsToken, "\"null\"");

                result.Add(scenario);
            }

            if (propertyType == typeof(string))
            {
                // Test for white space string.
                var scenario = typeof(ValidationGeneration)
                    .GetCodeTemplate(
                        modelType.ClassifiedHierarchyKind,
                        CodeTemplateKind.TestSnippet,
                        KeyMethodKinds.Both,
                        CodeSnippetKind.SelfValidationTestScenario)
                    .Replace(Tokens.TestScenarioNameToken, Invariant($"GetSelfValidationFailures() should return a failure when property '{Tokens.PropertyNameToken}' is white space scenario"))
                    .Replace(Tokens.InvalidPropertyValueToken, "Invariant($\"  {Environment.NewLine}  \")")
                    .Replace(Tokens.ValidationFailureMessageContainsToken, "\"white space\"");

                result.Add(scenario);
            }

            if ((propertyType == typeof(DateTime)) || (propertyType == typeof(DateTime?)))
            {
                // Test DateTime is UTC.
                if (propertyOfConcern.Name.ToUpperInvariant().Contains("UTC"))
                {
                    var scenario = typeof(ValidationGeneration)
                        .GetCodeTemplate(
                            modelType.ClassifiedHierarchyKind,
                            CodeTemplateKind.TestSnippet,
                            KeyMethodKinds.Both,
                            CodeSnippetKind.SelfValidationTestScenario)
                        .Replace(Tokens.TestScenarioNameToken, Invariant($"GetSelfValidationFailures() should return a failure when property '{Tokens.PropertyNameToken}' is not a UTC DateTime (it's Local) scenario"))
                        .Replace(Tokens.InvalidPropertyValueToken, Invariant($"{nameof(DateTime)}.{nameof(DateTime.Now)}"))
                        .Replace(Tokens.ValidationFailureMessageContainsToken, "\"Kind that is not DateTimeKind.Utc\", \"DateTimeKind.Local\"");

                    result.Add(scenario);

                    scenario = typeof(ValidationGeneration)
                        .GetCodeTemplate(
                            modelType.ClassifiedHierarchyKind,
                            CodeTemplateKind.TestSnippet,
                            KeyMethodKinds.Both,
                            CodeSnippetKind.SelfValidationTestScenario)
                        .Replace(Tokens.TestScenarioNameToken, Invariant($"GetSelfValidationFailures() should return a failure when property '{Tokens.PropertyNameToken}' is not a UTC DateTime (it's Unspecified) scenario"))
                        .Replace(Tokens.InvalidPropertyValueToken, Invariant($"{nameof(DateTime)}.{nameof(DateTime.UtcNow)}.{nameof(DateTimeExtensions.ToUnspecified)}()"))
                        .Replace(Tokens.ValidationFailureMessageContainsToken, "\"Kind that is not DateTimeKind.Utc\", \"DateTimeKind.Unspecified\"");

                    result.Add(scenario);
                }
            }

            if (propertyType.IsClosedSystemCollectionType() || propertyType.IsArray)
            {
                // Test for empty collection or array.
                var scenario = typeof(ValidationGeneration)
                    .GetCodeTemplate(
                        modelType.ClassifiedHierarchyKind,
                        CodeTemplateKind.TestSnippet,
                        KeyMethodKinds.Both,
                        CodeSnippetKind.SelfValidationTestScenario)
                    .Replace(Tokens.TestScenarioNameToken, Invariant($"GetSelfValidationFailures() should return a failure when property '{Tokens.PropertyNameToken}' is an empty enumerable scenario"))
                    .Replace(Tokens.InvalidPropertyValueToken, propertyType.GenerateSystemTypeInstantiationCode())
                    .Replace(Tokens.ValidationFailureMessageContainsToken, "\"is an empty enumerable\"");

                result.Add(scenario);

                // Test for collection or array containing null element.
                // We are specifically EXCLUDING nullable types here.
                var elementType = propertyType.IsArray
                    ? propertyType.GetElementType()
                    : propertyType.GetClosedSystemCollectionElementType();

                // ReSharper disable once PossibleNullReferenceException
                if (!elementType.IsValueType)
                {
                    var referenceProperty = "systemUnderTest." + propertyOfConcern.Name;

                    var invalidPropertyValue = Invariant($"new {elementType.ToStringReadable()}[0].Concat({referenceProperty}).Concat(new {elementType.ToStringReadable()}[] {{ null }}).Concat({referenceProperty})");

                    invalidPropertyValue = propertyType.IsArray
                        ? invalidPropertyValue + ".ToArray()"
                        : invalidPropertyValue + ".ToList()";

                    if (propertyType.IsGenericType && ((propertyType.GetGenericTypeDefinition() == typeof(Collection<>)) || (propertyType.GetGenericTypeDefinition() == typeof(ReadOnlyCollection<>))))
                    {
                        invalidPropertyValue = propertyType.GenerateSystemTypeInstantiationCode(invalidPropertyValue);
                    }

                    scenario = typeof(ValidationGeneration)
                        .GetCodeTemplate(
                            modelType.ClassifiedHierarchyKind,
                            CodeTemplateKind.TestSnippet,
                            KeyMethodKinds.Both,
                            CodeSnippetKind.SelfValidationTestScenario)
                        .Replace(Tokens.TestScenarioNameToken, Invariant($"GetSelfValidationFailures() should return a failure when property '{Tokens.PropertyNameToken}' contains a null element scenario"))
                        .Replace(Tokens.InvalidPropertyValueToken, invalidPropertyValue)
                        .Replace(Tokens.ValidationFailureMessageContainsToken, "\"contains at least one null element\"");

                    result.Add(scenario);
                }

                // Test for collection of string having white space element
                if (elementType == typeof(string))
                {
                    var referenceProperty = "systemUnderTest." + propertyOfConcern.Name;

                    var invalidPropertyValue = Invariant($"new {elementType.ToStringReadable()}[0].Concat({referenceProperty}).Concat(new {elementType.ToStringReadable()}[] {{ \"  \\r\\n  \" }}).Concat({referenceProperty})");

                    invalidPropertyValue = propertyType.IsArray
                        ? invalidPropertyValue + ".ToArray()"
                        : invalidPropertyValue + ".ToList()";

                    if (propertyType.IsGenericType && ((propertyType.GetGenericTypeDefinition() == typeof(Collection<>)) || (propertyType.GetGenericTypeDefinition() == typeof(ReadOnlyCollection<>))))
                    {
                        invalidPropertyValue = propertyType.GenerateSystemTypeInstantiationCode(invalidPropertyValue);
                    }

                    scenario = typeof(ValidationGeneration)
                        .GetCodeTemplate(
                            modelType.ClassifiedHierarchyKind,
                            CodeTemplateKind.TestSnippet,
                            KeyMethodKinds.Both,
                            CodeSnippetKind.SelfValidationTestScenario)
                        .Replace(Tokens.TestScenarioNameToken, Invariant($"GetSelfValidationFailures() should return a failure when property '{Tokens.PropertyNameToken}' contain a white space element scenario"))
                        .Replace(Tokens.InvalidPropertyValueToken, invalidPropertyValue)
                        .Replace(Tokens.ValidationFailureMessageContainsToken, "\"contains an element that is white space\"");

                    result.Add(scenario);
                }
            }

            if (propertyType.IsClosedSystemDictionaryType())
            {
                // Test for empty dictionary.
                var scenario = typeof(ValidationGeneration)
                    .GetCodeTemplate(
                        modelType.ClassifiedHierarchyKind,
                        CodeTemplateKind.TestSnippet,
                        KeyMethodKinds.Both,
                        CodeSnippetKind.SelfValidationTestScenario)
                    .Replace(Tokens.TestScenarioNameToken, Invariant($"GetSelfValidationFailures() should return a failure when property '{Tokens.PropertyNameToken}' is an empty dictionary scenario"))
                    .Replace(Tokens.InvalidPropertyValueToken, propertyType.GenerateSystemTypeInstantiationCode())
                    .Replace(Tokens.ValidationFailureMessageContainsToken, "\"is an empty dictionary\"");

                result.Add(scenario);

                // Test for dictionary containing null value.
                // We are specifically EXCLUDING nullable types here
                var valueType = propertyType.GetClosedSystemDictionaryValueType();
                if (!valueType.IsValueType)
                {
                    var dictionaryWithNullValue = Invariant($@"

                    var dictionaryWithNullValue = systemUnderTest.{Tokens.PropertyNameToken}.ToDictionary(_ => _.Key, _ => _.Value);
                    var randomKey = dictionaryWithNullValue.Keys.ElementAt(ThreadSafeRandom.Next(0, dictionaryWithNullValue.Count));
                    dictionaryWithNullValue[randomKey] = null;");

                    var invalidPropertyValue = "dictionaryWithNullValue";

                    if (propertyType.IsGenericType && ((propertyType.GetGenericTypeDefinition() == typeof(ReadOnlyDictionary<,>)) || (propertyType.GetGenericTypeDefinition() == typeof(ConcurrentDictionary<,>))))
                    {
                        invalidPropertyValue += propertyType.GenerateSystemTypeInstantiationCode(invalidPropertyValue);
                    }

                    scenario = typeof(ValidationGeneration)
                        .GetCodeTemplate(
                            modelType.ClassifiedHierarchyKind,
                            CodeTemplateKind.TestSnippet,
                            KeyMethodKinds.Both,
                            CodeSnippetKind.SelfValidationTestScenario)
                        .Replace(Tokens.TestScenarioNameToken, Invariant($"GetSelfValidationFailures() should return a failure when property '{Tokens.PropertyNameToken}' contains a key-value pair with a null value"))
                        .Replace(Tokens.InvalidPropertyValueSetupToken, dictionaryWithNullValue)
                        .Replace(Tokens.InvalidPropertyValueToken, invalidPropertyValue)
                        .Replace(Tokens.ValidationFailureMessageContainsToken, "\"contains at least one key-value pair with a null value\"");

                    result.Add(scenario);
                }
            }

            var enumTypeToCheck = propertyType.IsNullableType()
                ? Nullable.GetUnderlyingType(propertyType)
                : propertyType;

            // ReSharper disable once PossibleNullReferenceException
            if (enumTypeToCheck.IsEnum && (!enumTypeToCheck.IsFlagsEnum()))
            {
                // For Enum or Nullable Enum, check that it doesn't equal "Unknown".
                if (!EnumTypeToHasUnknownValueMapCache.TryGetValue(enumTypeToCheck, out var hasUnknownValue))
                {
                    hasUnknownValue = enumTypeToCheck
                        .GetAllPossibleEnumValues()
                        .Select(_ => Enum.GetName(enumTypeToCheck, _))
                        .Contains(UnknownEnumValueName);

                    EnumTypeToHasUnknownValueMapCache.TryAdd(enumTypeToCheck, hasUnknownValue);
                }

                if (hasUnknownValue)
                {
                    var scenario = typeof(ValidationGeneration)
                        .GetCodeTemplate(
                            modelType.ClassifiedHierarchyKind,
                            CodeTemplateKind.TestSnippet,
                            KeyMethodKinds.Both,
                            CodeSnippetKind.SelfValidationTestScenario)
                        .Replace(Tokens.TestScenarioNameToken, Invariant($"GetSelfValidationFailures() should return a failure when property '{Tokens.PropertyNameToken}' is {enumTypeToCheck.ToStringReadable()}.{Tokens.EnumValueNamedUnknownToken} scenario"))
                        .Replace(Tokens.ValidationFailureMessageContainsToken, Invariant($"\"{Tokens.EnumValueNamedUnknownToken}\""))
                        .Replace(Tokens.EnumValueNamedUnknownToken, UnknownEnumValueName)
                        .Replace(Tokens.InvalidPropertyValueToken, Invariant($"{enumTypeToCheck.ToStringReadable()}.{UnknownEnumValueName}"));

                    result.Add(scenario);
                }
            }

            result = result
                .Select(_ => _
                    .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                    .Replace(Tokens.PropertyNameToken, propertyOfConcern.Name)
                    .Replace(Tokens.InvalidPropertyValueSetupToken, string.Empty))
                .ToList();

            return result;
        }
    }
}