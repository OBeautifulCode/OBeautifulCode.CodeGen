// --------------------------------------------------------------------------------------------------------------------
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
    using OBeautifulCode.CodeGen.ModelObject.Internal;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to constructing a model object.
    /// </summary>
    internal static class ConstructingGeneration
    {
        /// <summary>
        /// Generates fields required to test a model's constructor.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test fields.
        /// </returns>
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

            foreach (var parameter in parameters.Where(_ => !_.ParameterType.IsValueType))
            {
                var referenceObjectUsed = false;

                var parametersCode = parameters.Select(_ =>
                {
                    var referenceObject = "referenceObject." + _.ToPropertyName();

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

                var scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioNullObject)
                                .Replace(Tokens.ReferenceObjectToken, referenceObjectUsed ? referenceObjectDummyCode : null)
                                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                                .Replace(Tokens.ParameterNameToken, parameter.Name)
                                .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                argumentValidationScenarios.Add(scenario);

                if (parameter.ParameterType == typeof(string))
                {
                    referenceObjectUsed = false;

                    var stringParameterCode = parameters.Select(_ =>
                    {
                        var referenceObject = "referenceObject." + _.ToPropertyName();

                        string code;

                        if (_.Name == parameter.Name)
                        {
                            code = "Invariant($\"  {Environment.NewLine}  \")";
                        }
                        else
                        {
                            code = referenceObject;
                            referenceObjectUsed = true;
                        }

                        return new MemberCode(_.Name, code);
                    }).ToList();

                    objectInstantiationCode = modelType.GenerateModelInstantiation(stringParameterCode, parameterPaddingLength: 45);

                    scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioWhiteSpaceString)
                        .Replace(Tokens.ReferenceObjectToken, referenceObjectUsed ? referenceObjectDummyCode : null)
                        .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                        .Replace(Tokens.ParameterNameToken, parameter.Name)
                        .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                    argumentValidationScenarios.Add(scenario);
                }

                if (parameter.ParameterType.IsClosedSystemCollectionType() || parameter.ParameterType.IsArray)
                {
                    // add test for empty collection or array
                    referenceObjectUsed = false;

                    var collectionParameterCode = parameters.Select(_ =>
                    {
                        var referenceObject = "referenceObject." + _.ToPropertyName();

                        string code;

                        if (_.Name == parameter.Name)
                        {
                            code = parameter.ParameterType.GenerateSystemTypeInstantiationCode();
                        }
                        else
                        {
                            code = referenceObject;
                            referenceObjectUsed = true;
                        }

                        return new MemberCode(_.Name, code);
                    }).ToList();

                    objectInstantiationCode = modelType.GenerateModelInstantiation(collectionParameterCode, parameterPaddingLength: 45);

                    scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioEmptyEnumerable)
                        .Replace(Tokens.ReferenceObjectToken, referenceObjectUsed ? referenceObjectDummyCode : null)
                        .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                        .Replace(Tokens.ParameterNameToken, parameter.Name)
                        .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                    argumentValidationScenarios.Add(scenario);

                    // add test for collection or array containing null element
                    // we are specifically EXCLUDING nullable types here
                    var elementType = parameter.ParameterType.IsArray
                        ? parameter.ParameterType.GetElementType()
                        : parameter.ParameterType.GetClosedSystemCollectionElementType();

                    // ReSharper disable once PossibleNullReferenceException
                    if (!elementType.IsValueType)
                    {
                        collectionParameterCode = parameters.Select(_ =>
                        {
                            var referenceObject = "referenceObject." + _.ToPropertyName();

                            if (_.Name == parameter.Name)
                            {
                                referenceObject = Invariant($"new {elementType.ToStringReadable()}[0].Concat({referenceObject}).Concat(new {elementType.ToStringReadable()}[] {{ null }}).Concat({referenceObject})");

                                referenceObject = parameter.ParameterType.IsArray
                                    ? referenceObject + ".ToArray()"
                                    : referenceObject + ".ToList()";

                                if (parameter.ParameterType.IsGenericType && ((parameter.ParameterType.GetGenericTypeDefinition() == typeof(Collection<>)) || (parameter.ParameterType.GetGenericTypeDefinition() == typeof(ReadOnlyCollection<>))))
                                {
                                    referenceObject = parameter.ParameterType.GenerateSystemTypeInstantiationCode(referenceObject);
                                }
                            }

                            return new MemberCode(_.Name, referenceObject);
                        }).ToList();

                        objectInstantiationCode = modelType.GenerateModelInstantiation(collectionParameterCode, parameterPaddingLength: 45);

                        scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioEnumerableWithNullElement)
                            .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                            .Replace(Tokens.ParameterNameToken, parameter.Name)
                            .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                        argumentValidationScenarios.Add(scenario);
                    }
                }

                if (parameter.ParameterType.IsClosedSystemDictionaryType())
                {
                    // add test for empty dictionary
                    referenceObjectUsed = false;

                    var dictionaryParameterCode = parameters.Select(_ =>
                    {
                        var referenceObject = "referenceObject." + _.ToPropertyName();

                        string code;

                        if (_.Name == parameter.Name)
                        {
                            code = parameter.ParameterType.GenerateSystemTypeInstantiationCode();
                        }
                        else
                        {
                            code = referenceObject;
                            referenceObjectUsed = true;
                        }

                        return new MemberCode(_.Name, code);
                    }).ToList();

                    objectInstantiationCode = modelType.GenerateModelInstantiation(dictionaryParameterCode, parameterPaddingLength: 45);

                    scenario = typeof(ConstructingGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioEmptyDictionary)
                        .Replace(Tokens.ReferenceObjectToken, referenceObjectUsed ? referenceObjectDummyCode : null)
                        .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                        .Replace(Tokens.ParameterNameToken, parameter.Name)
                        .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                    argumentValidationScenarios.Add(scenario);

                    // add test for dictionary containing null value
                    // we are specifically EXCLUDING nullable types here
                    var valueType = parameter.ParameterType.GetClosedSystemDictionaryValueType();

                    if (!valueType.IsValueType)
                    {
                        dictionaryParameterCode = parameters.Select(_ =>
                        {
                            var referenceObject = "referenceObject." + _.ToPropertyName();

                            if (_.Name == parameter.Name)
                            {
                                referenceObject = "dictionaryWithNullValue";

                                if (parameter.ParameterType.IsGenericType && ((parameter.ParameterType.GetGenericTypeDefinition() == typeof(ReadOnlyDictionary<,>)) || (parameter.ParameterType.GetGenericTypeDefinition() == typeof(ConcurrentDictionary<,>))))
                                {
                                    referenceObject = parameter.ParameterType.GenerateSystemTypeInstantiationCode(referenceObject);
                                }
                            }

                            return new MemberCode(_.Name, referenceObject);
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
            }

            var propertyAssignmentScenarios = new List<string>();

            foreach (var parameter in parameters)
            {
                var parameterCode = parameters.Select(_ => new MemberCode(_.Name, "referenceObject." + _.ToPropertyName())).ToList();

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