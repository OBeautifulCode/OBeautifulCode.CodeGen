﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstructingGeneration.cs" company="OBeautifulCode">
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

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.Reflection.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to constructing a model object.
    /// </summary>
    internal static class ConstructingGeneration
    {
        private const string UnknownEnumValueName = "Unknown";

        private static readonly ConcurrentDictionary<Type, bool> EnumTypeToHasUnknownValueMapCache = new ConcurrentDictionary<Type, bool>();

        /// <summary>
        /// Generates fields required to test a model's constructor.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test fields.
        /// </returns>
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA_ALL_SeeOtherSuppressionMessages)]
        [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = ObcSuppressBecause.CA_ALL_SeeOtherSuppressionMessages)]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        public static string GenerateConstructorTestFields(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            if ((modelType.Constructor == null) || modelType.Constructor.IsDefaultConstructor())
            {
                return null;
            }

            var argumentValidationScenarios = new List<string>();

            var parameters = modelType.Constructor.GetParameters();

            var referenceObjectDummyCode = "var referenceObject = A.Dummy<[model-type-name-in-code-here]>();" + Environment.NewLine + Environment.NewLine + "                        ";

            foreach (var parameter in parameters)
            {
                // If the parameter is optional and it's default value is null
                // then we don't generate a constructor argument validation scenario.
                // If the default value is not null then we assume the rules below apply
                // (e.g. if a string is set to a constant value then we validate that it cannot be assigned to null).
                if (parameter.IsOptional && (parameter.RawDefaultValue == null))
                {
                    continue;
                }

                // Don't test for null value on Nullable types; often enough it's ok for those to be null.
                var parameterType = parameter.ParameterType;

                if (!parameterType.IsValueType)
                {
                    var referenceObjectUsed = false;

                    var parametersCode = parameters.Select(_ =>
                    {
                        var propertyOfConcern = modelType.CaseInsensitivePropertyNameToPropertyOfConcernMap[_.Name];

                        var referenceObject = modelType.CastIfConstructorParameterIsOfDifferentType(propertyOfConcern) + "referenceObject." + _.ToPropertyName();

                        string code;
                        if (_.Name == parameter.Name)
                        {
                            code = "null";
                        }
                        else
                        {
                            code = referenceObject;
                            referenceObjectUsed = true;
                        }

                        return new MemberCode(_.Name, code);
                    }).ToList();

                    var objectInstantiationCode = modelType.GenerateModelInstantiation(parametersCode, parameterPaddingLength: 45);

                    var scenario = typeof(ConstructingGeneration)
                        .GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioNullObject)
                        .Replace(Tokens.ReferenceObjectToken, referenceObjectUsed ? referenceObjectDummyCode : null)
                        .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                        .Replace(Tokens.ParameterNameToken, parameter.Name)
                        .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                    argumentValidationScenarios.Add(scenario);
                }

                if (parameterType == typeof(string))
                {
                    var referenceObjectUsed = false;

                    var stringParameterCode = parameters.Select(_ =>
                    {
                        var propertyOfConcern = modelType.CaseInsensitivePropertyNameToPropertyOfConcernMap[_.Name];

                        var referenceProperty = modelType.CastIfConstructorParameterIsOfDifferentType(propertyOfConcern) + "referenceObject." + _.ToPropertyName();

                        string code;

                        if (_.Name == parameter.Name)
                        {
                            code = "Invariant($\"  {Environment.NewLine}  \")";
                        }
                        else
                        {
                            code = referenceProperty;
                            referenceObjectUsed = true;
                        }

                        return new MemberCode(_.Name, code);
                    }).ToList();

                    var objectInstantiationCode = modelType.GenerateModelInstantiation(stringParameterCode, parameterPaddingLength: 45);

                    var scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioWhiteSpaceString)
                        .Replace(Tokens.ReferenceObjectToken, referenceObjectUsed ? referenceObjectDummyCode : null)
                        .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                        .Replace(Tokens.ParameterNameToken, parameter.Name)
                        .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                    argumentValidationScenarios.Add(scenario);
                }

                if (parameterType.IsClosedSystemCollectionType() || parameterType.IsArray)
                {
                    // add test for empty collection or array
                    var referenceObjectUsed = false;

                    var collectionParameterCode = parameters.Select(_ =>
                    {
                        var propertyOfConcern = modelType.CaseInsensitivePropertyNameToPropertyOfConcernMap[_.Name];

                        var referenceProperty = modelType.CastIfConstructorParameterIsOfDifferentType(propertyOfConcern) + "referenceObject." + _.ToPropertyName();

                        string code;

                        if (_.Name == parameter.Name)
                        {
                            code = parameterType.GenerateSystemTypeInstantiationCode();
                        }
                        else
                        {
                            code = referenceProperty;
                            referenceObjectUsed = true;
                        }

                        return new MemberCode(_.Name, code);
                    }).ToList();

                    var objectInstantiationCode = modelType.GenerateModelInstantiation(collectionParameterCode, parameterPaddingLength: 45);

                    var scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioEmptyEnumerable)
                        .Replace(Tokens.ReferenceObjectToken, referenceObjectUsed ? referenceObjectDummyCode : null)
                        .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                        .Replace(Tokens.ParameterNameToken, parameter.Name)
                        .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                    argumentValidationScenarios.Add(scenario);

                    // add test for collection or array containing null element
                    // we are specifically EXCLUDING nullable types here
                    var elementType = parameterType.IsArray
                        ? parameterType.GetElementType()
                        : parameterType.GetClosedSystemCollectionElementType();

                    // ReSharper disable once PossibleNullReferenceException
                    if (!elementType.IsValueType)
                    {
                        collectionParameterCode = parameters.Select(_ =>
                        {
                            var propertyOfConcern = modelType.CaseInsensitivePropertyNameToPropertyOfConcernMap[_.Name];

                            var referenceProperty = modelType.CastIfConstructorParameterIsOfDifferentType(propertyOfConcern) + "referenceObject." + _.ToPropertyName();

                            if (_.Name == parameter.Name)
                            {
                                referenceProperty = Invariant($"new {elementType.ToStringReadable()}[0].Concat({referenceProperty}).Concat(new {elementType.ToStringReadable()}[] {{ null }}).Concat({referenceProperty})");

                                referenceProperty = parameterType.IsArray
                                    ? referenceProperty + ".ToArray()"
                                    : referenceProperty + ".ToList()";

                                if (parameterType.IsGenericType && ((parameterType.GetGenericTypeDefinition() == typeof(Collection<>)) || (parameterType.GetGenericTypeDefinition() == typeof(ReadOnlyCollection<>))))
                                {
                                    referenceProperty = parameterType.GenerateSystemTypeInstantiationCode(referenceProperty);
                                }
                            }

                            return new MemberCode(_.Name, referenceProperty);
                        }).ToList();

                        objectInstantiationCode = modelType.GenerateModelInstantiation(collectionParameterCode, parameterPaddingLength: 45);

                        scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioEnumerableWithNullElement)
                            .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                            .Replace(Tokens.ParameterNameToken, parameter.Name)
                            .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                        argumentValidationScenarios.Add(scenario);
                    }
                }

                if (parameterType.IsClosedSystemDictionaryType())
                {
                    // add test for empty dictionary
                    var referenceObjectUsed = false;

                    var dictionaryParameterCode = parameters.Select(_ =>
                    {
                        var propertyOfConcern = modelType.CaseInsensitivePropertyNameToPropertyOfConcernMap[_.Name];

                        var referenceProperty = modelType.CastIfConstructorParameterIsOfDifferentType(propertyOfConcern) + "referenceObject." + _.ToPropertyName();

                        string code;

                        if (_.Name == parameter.Name)
                        {
                            code = parameterType.GenerateSystemTypeInstantiationCode();
                        }
                        else
                        {
                            code = referenceProperty;
                            referenceObjectUsed = true;
                        }

                        return new MemberCode(_.Name, code);
                    }).ToList();

                    var objectInstantiationCode = modelType.GenerateModelInstantiation(dictionaryParameterCode, parameterPaddingLength: 45);

                    var scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioEmptyDictionary)
                        .Replace(Tokens.ReferenceObjectToken, referenceObjectUsed ? referenceObjectDummyCode : null)
                        .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                        .Replace(Tokens.ParameterNameToken, parameter.Name)
                        .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                    argumentValidationScenarios.Add(scenario);

                    // add test for dictionary containing null value
                    // we are specifically EXCLUDING nullable types here
                    var valueType = parameterType.GetClosedSystemDictionaryValueType();

                    if (!valueType.IsValueType)
                    {
                        dictionaryParameterCode = parameters.Select(_ =>
                        {
                            var propertyOfConcern = modelType.CaseInsensitivePropertyNameToPropertyOfConcernMap[_.Name];

                            var referenceProperty = modelType.CastIfConstructorParameterIsOfDifferentType(propertyOfConcern) + "referenceObject." + _.ToPropertyName();

                            if (_.Name == parameter.Name)
                            {
                                referenceProperty = "dictionaryWithNullValue";

                                if (parameterType.IsGenericType && ((parameterType.GetGenericTypeDefinition() == typeof(ReadOnlyDictionary<,>)) || (parameterType.GetGenericTypeDefinition() == typeof(ConcurrentDictionary<,>))))
                                {
                                    referenceProperty = parameterType.GenerateSystemTypeInstantiationCode(referenceProperty);
                                }
                            }

                            return new MemberCode(_.Name, referenceProperty);
                        }).ToList();

                        var setDictionaryValueToNullCode = Invariant($"var dictionaryWithNullValue = referenceObject.{parameter.ToPropertyName()}.ToDictionary(_ => _.Key, _ => _.Value);");

                        objectInstantiationCode = modelType.GenerateModelInstantiation(dictionaryParameterCode, parameterPaddingLength: 45);

                        scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioDictionaryWithNullValue)
                            .Replace(Tokens.SetDictionaryValueToNullToken, setDictionaryValueToNullCode)
                            .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                            .Replace(Tokens.ParameterNameToken, parameter.Name)
                            .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                        argumentValidationScenarios.Add(scenario);
                    }
                }

                // For Enum or Nullable Enum, check that it doesn't equal "Unknown".
                var enumTypeToCheck = parameterType.IsNullableType()
                    ? Nullable.GetUnderlyingType(parameterType)
                    : parameterType;

                // ReSharper disable once PossibleNullReferenceException
                if (enumTypeToCheck.IsEnum && (!enumTypeToCheck.IsFlagsEnum()))
                {
                    var referenceObjectUsed = false;

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
                        var enumParameterCode = parameters.Select(_ =>
                        {
                            var propertyOfConcern = modelType.CaseInsensitivePropertyNameToPropertyOfConcernMap[_.Name];

                            var referenceProperty = modelType.CastIfConstructorParameterIsOfDifferentType(propertyOfConcern) + "referenceObject." + _.ToPropertyName();

                            string code;

                            if (_.Name == parameter.Name)
                            {
                                code = Invariant($"{enumTypeToCheck.ToStringReadable()}.{UnknownEnumValueName}");
                            }
                            else
                            {
                                code = referenceProperty;
                                referenceObjectUsed = true;
                            }

                            return new MemberCode(_.Name, code);
                        }).ToList();

                        var objectInstantiationCode = modelType.GenerateModelInstantiation(enumParameterCode, parameterPaddingLength: 45);

                        var scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioEnumValueNamedUnknown)
                            .Replace(Tokens.ReferenceObjectToken, referenceObjectUsed ? referenceObjectDummyCode : null)
                            .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                            .Replace(Tokens.ParameterNameToken, parameter.Name)
                            .Replace(Tokens.PropertyTypeNameToken, enumTypeToCheck.ToStringReadable())
                            .Replace(Tokens.ConstructObjectToken, objectInstantiationCode)
                            .Replace(Tokens.EnumValueNamedUnknownToken, UnknownEnumValueName);

                        argumentValidationScenarios.Add(scenario);
                    }
                }
            }

            var propertyAssignmentScenarios = new List<string>();

            foreach (var parameter in parameters)
            {
                var parameterCode = parameters
                    .Select(_ =>
                    {
                        var propertyOfConcern = modelType.CaseInsensitivePropertyNameToPropertyOfConcernMap[_.Name];

                        var referenceProperty = modelType.CastIfConstructorParameterIsOfDifferentType(propertyOfConcern) + "referenceObject." + _.ToPropertyName();

                        return new MemberCode(_.Name, referenceProperty);
                    })
                    .ToList();

                var newObjectCode = modelType.GenerateModelInstantiation(parameterCode, parameterPaddingLength: 54);

                var scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorParameterAssignmentScenario)
                    .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                    .Replace(Tokens.PropertyNameToken, parameter.ToPropertyName())
                    .Replace(Tokens.ParameterNameToken, parameter.Name)
                    .Replace(Tokens.ConstructObjectToken, newObjectCode);

                propertyAssignmentScenarios.Add(scenario);
            }

            var argumentValidationScenariosCode = argumentValidationScenarios.Any() ? Environment.NewLine + string.Join(Environment.NewLine, argumentValidationScenarios) : string.Empty;

            var propertyAssignmentScenariosCode = propertyAssignmentScenarios.Any() ? Environment.NewLine + string.Join(Environment.NewLine, propertyAssignmentScenarios) : string.Empty;

            var result = typeof(ConstructingGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorTestFields)
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                .Replace(Tokens.ConstructorArgumentValidationTestScenariosToken, argumentValidationScenariosCode)
                .Replace(Tokens.ConstructorPropertyAssignmentTestScenariosToken, propertyAssignmentScenariosCode);

            return result;
        }

        /// <summary>
        /// Generates test methods that test a model's constructor.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test a model's constructor.
        /// </returns>
        public static string GenerateConstructorTestMethods(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            if ((modelType.Constructor == null) || modelType.Constructor.IsDefaultConstructor())
            {
                return null;
            }

            var result = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.Test, KeyMethodKinds.Both);

            return result;
        }
    }
}