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
    using System.Globalization;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Internal;
    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to constructing a model object.
    /// </summary>
    internal static class ConstructingGeneration
    {
        /// <summary>
        /// Generates test methods that test a model's constructor.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test a model's constructor.
        /// </returns>
        [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = ObcSuppressBecause.CA_ALL_SeeOtherSuppressionMessages)]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        public static string GenerateConstructorTestFields(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            if ((modelType.Constructor == null) || modelType.IsDefaultConstructor)
            {
                return null;
            }

            var scenarios = new List<string>();

            var parameters = modelType.Constructor.GetParameters();

            foreach (var parameter in parameters.Where(_ => !_.ParameterType.IsValueType))
            {
                var parametersCode = parameters.Select(_ =>
                {
                    var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                    return new MemberCode(_.Name, _.Name == parameter.Name ? "null" : referenceObject);
                }).ToList();

                var objectInstantiationCode = modelType.GenerateModelInstantiation(parametersCode, parameterPaddingLength: 34);

                var scenario = typeof(ConstructingGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioNullObject)
                                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                                .Replace(Tokens.ParameterNameToken, parameter.Name)
                                .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                scenarios.Add(scenario);

                if (parameter.ParameterType == typeof(string))
                {
                    var stringParameterCode = parameters.Select(_ =>
                    {
                        var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                        return new MemberCode(_.Name, _.Name == parameter.Name ? "Invariant($\"  {Environment.NewLine}  \")" : referenceObject);
                    }).ToList();

                    objectInstantiationCode = modelType.GenerateModelInstantiation(stringParameterCode, parameterPaddingLength: 34);

                    scenario = typeof(ConstructingGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioWhiteSpaceString)
                                            .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                                            .Replace(Tokens.ParameterNameToken, parameter.Name)
                                            .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                    scenarios.Add(scenario);
                }

                if (parameter.ParameterType.IsClosedSystemCollectionType() || parameter.ParameterType.IsArray)
                {
                    // add test for empty collection or array
                    var collectionParameterCode = parameters.Select(_ =>
                    {
                        var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                        return new MemberCode(_.Name, _.Name == parameter.Name ? parameter.ParameterType.GenerateSystemTypeInstantiationCode() : referenceObject);
                    }).ToList();

                    objectInstantiationCode = modelType.GenerateModelInstantiation(collectionParameterCode, parameterPaddingLength: 34);

                    scenario = typeof(ConstructingGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioEmptyEnumerable)
                        .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                        .Replace(Tokens.ParameterNameToken, parameter.Name)
                        .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                    scenarios.Add(scenario);

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
                            var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                            if (_.Name == parameter.Name)
                            {
                                referenceObject = Invariant($"new {elementType.ToStringCompilable()}[0].Concat({referenceObject}).Concat(new {elementType.ToStringCompilable()}[] {{ null }}).Concat({referenceObject})");

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

                        objectInstantiationCode = modelType.GenerateModelInstantiation(collectionParameterCode, parameterPaddingLength: 34);

                        scenario = typeof(ConstructingGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioEnumerableWithNullElement)
                            .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                            .Replace(Tokens.ParameterNameToken, parameter.Name)
                            .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                        scenarios.Add(scenario);
                    }
                }

                if (parameter.ParameterType.IsClosedSystemDictionaryType())
                {
                    // add test for empty dictionary
                    var dictionaryParameterCode = parameters.Select(_ =>
                    {
                        var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                        return new MemberCode(_.Name, _.Name == parameter.Name ? parameter.ParameterType.GenerateSystemTypeInstantiationCode() : referenceObject);
                    }).ToList();

                    objectInstantiationCode = modelType.GenerateModelInstantiation(dictionaryParameterCode, parameterPaddingLength: 34);

                    scenario = typeof(ConstructingGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioEmptyDictionary)
                        .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                        .Replace(Tokens.ParameterNameToken, parameter.Name)
                        .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                    scenarios.Add(scenario);

                    // add test for dictionary containing null value
                    // we are specifically EXCLUDING nullable types here
                    var valueType = parameter.ParameterType.GetClosedSystemDictionaryValueType();

                    if (!valueType.IsValueType)
                    {
                        dictionaryParameterCode = parameters.Select(_ =>
                        {
                            var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

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

                        var setDictionaryValueToNullCode = Invariant($"var dictionaryWithNullValue = referenceObject.{parameter.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture)}.ToDictionary(_ => _.Key, _ => _.Value);");

                        objectInstantiationCode = modelType.GenerateModelInstantiation(dictionaryParameterCode, parameterPaddingLength: 34);

                        scenario = typeof(ConstructingGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationScenarioDictionaryWithNullValue)
                            .Replace(Tokens.SetDictionaryValueToNullToken, setDictionaryValueToNullCode)
                            .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                            .Replace(Tokens.ParameterNameToken, parameter.Name)
                            .Replace(Tokens.ConstructObjectToken, objectInstantiationCode);

                        scenarios.Add(scenario);
                    }
                }
            }

            var scenariosCode = scenarios.Any() ? Environment.NewLine + string.Join(Environment.NewLine, scenarios) : string.Empty;

            var result = typeof(ConstructingGeneration).GetCodeTemplate(modelType.HierarchyKinds.Classify(), CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.ConstructorArgumentValidationTestFields)
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                .Replace(Tokens.ConstructorArgumentValidationTestScenariosToken, scenariosCode);

            return result;
        }

        /// <summary>
        /// Generates test methods that test a model's constructor.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test a model's constructor.
        /// </returns>
        [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = ObcSuppressBecause.CA_ALL_SeeOtherSuppressionMessages)]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        public static string GenerateConstructorTestMethods(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            if ((modelType.Constructor == null) || modelType.IsDefaultConstructor)
            {
                return null;
            }

            var parameters = modelType.Constructor.GetParameters();

            var testMethods = new List<string>();

            foreach (var parameter in parameters)
            {
                var parameterCode = parameters.Select(_ => new MemberCode(_.Name, "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture))).ToList();

                var newObjectCode = modelType.GenerateModelInstantiation(parameterCode, parameterPaddingLength: 46);

                var assertPropertyGetterToken = parameter.ParameterType.GenerateObcAssertionsEqualityStatement(
                    "actual",
                    "expected",
                    sameReferenceExpected: true);

                var testMethod = typeof(ConstructingGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.PropertyGetterTestMethod)
                                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                                .Replace(Tokens.PropertyNameToken, parameter.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture))
                                .Replace(Tokens.ParameterNameToken,  parameter.Name)
                                .Replace(Tokens.AssertPropertyGetterToken,  assertPropertyGetterToken)
                                .Replace(Tokens.ConstructObjectToken, newObjectCode);

                testMethods.Add(testMethod);
            }

            var constructorTestInflationToken = string.Join(Environment.NewLine + Environment.NewLine, testMethods);

            var result = typeof(ConstructingGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.Test, KeyMethodKinds.Both)
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                .Replace(Tokens.ConstructorTestsToken, constructorTestInflationToken);

            return result;
        }
    }
}