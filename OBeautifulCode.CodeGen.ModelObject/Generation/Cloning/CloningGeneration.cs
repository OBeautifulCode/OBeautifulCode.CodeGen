// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CloningGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Type;
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

            var deepCloneGenericCode = modelType.GenerateDeepCloneGenericCode();

            var deepCloneInterfaceCode = deepCloneCode.Contains("DeepCloneInterface(")
                ? typeof(CloningGeneration).GetCodeTemplate(ClassifiedHierarchyKind.Concrete, CodeTemplateKind.ModelSnippet, KeyMethodKinds.Both, CodeSnippetKind.DeepCloneInterface)
                : string.Empty;

            var deepCloneWithCode = modelType.ShouldGenerateDeepCloneWithMethods()
                ? modelType.GenerateDeepCloneWithCode()
                : string.Empty;

            var codeTemplate = typeof(CloningGeneration).GetCodeTemplate(modelType.HierarchyKind, CodeTemplateKind.Model, modelType.DeepCloneKeyMethodKinds);

            var result = codeTemplate
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                .Replace(Tokens.ModelRootAncestorTypeNameInCodeToken, modelType.InheritancePathTypeNamesInCode.LastOrDefault())
                .Replace(Tokens.DeepCloneToken, deepCloneCode)
                .Replace(Tokens.DeepCloneWithToken, deepCloneWithCode)
                .Replace(Tokens.DeepCloneGenericToken, deepCloneGenericCode)
                .Replace(Tokens.DeepCloneInterfaceToken, deepCloneInterfaceCode);

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
            string cloneCode,
            int recursionDepth = 0)
        {
            type.AsArg(nameof(type)).Must().NotBeNull();
            recursionDepth++;

            var deepCloneableType = typeof(IDeepCloneable<>).MakeGenericType(type);

            string result;
            if (deepCloneableType.IsAssignableFrom(type))
            {
                result = type.IsValueType
                    ? Invariant($"{cloneCode}.DeepClone()")
                    : Invariant($"{cloneCode}?.DeepClone()");
            }
            else if (type.IsSystemDictionaryType())
            {
                var keyType = type.GetGenericArguments().First();
                var valueType = type.GetGenericArguments().Last();

                var keyExpressionParameter = "k".ToExpressionParameter(recursionDepth);
                var valueExpressionParameter = "v".ToExpressionParameter(recursionDepth);

                var keyClone = keyType.GenerateCloningLogicCodeForType(Invariant($"{keyExpressionParameter}.Key"), recursionDepth);
                var valueClone = valueType.GenerateCloningLogicCodeForType(Invariant($"{valueExpressionParameter}.Value"), recursionDepth);

                string cast = null;
                if (recursionDepth > 1)
                {
                    cast = "(" + type.ToStringReadable() + ")";
                }

                result = Invariant($"{cloneCode}?.ToDictionary({keyExpressionParameter} => {keyClone}, {valueExpressionParameter} => {valueClone})");

                if ((type.GetGenericTypeDefinition() == typeof(ReadOnlyDictionary<,>)) || (type.GetGenericTypeDefinition() == typeof(ConcurrentDictionary<,>)))
                {
                    result = type.GenerateSystemTypeInstantiationCode(result);
                }
                else
                {
                    result = cast + result;
                }
            }
            else if (type.IsSystemCollectionType())
            {
                var elementType = type.GetGenericArguments().First();

                var expressionParameter = "i".ToExpressionParameter(recursionDepth);

                var valueClone = elementType.GenerateCloningLogicCodeForType(expressionParameter, recursionDepth);

                string cast = null;
                if (recursionDepth > 1)
                {
                    cast = "(" + type.ToStringReadable() + ")";
                }

                // note: List<T> is assignable to all System collection types except Collection<T> and ReadOnlyCollection<T>.
                // In general no properties of a model should use those types.  If we do want to support this in the future,
                // we need to wrap the List<T>:
                // - cloneCode == null ? null : new Collection<T>(cloneCode.Select(...).ToList())
                // - cloneCode == null ? null : new ReadOnlyCollection<T>(cloneCode.Select(...).ToList())
                result = Invariant($"{cloneCode}?.Select({expressionParameter} => {valueClone}).ToList()");

                if ((type.GetGenericTypeDefinition() == typeof(Collection<>)) || (type.GetGenericTypeDefinition() == typeof(ReadOnlyCollection<>)))
                {
                    result = type.GenerateSystemTypeInstantiationCode(result);
                }
                else
                {
                    result = cast + result;
                }
            }
            else if (type.IsArray)
            {
                var elementType = type.GetElementType();

                var expressionParameter = "i".ToExpressionParameter(recursionDepth);

                var valueClone = elementType.GenerateCloningLogicCodeForType(expressionParameter, recursionDepth);

                result = Invariant($"{cloneCode}?.Select({expressionParameter} => {valueClone}).ToArray()");
            }
            else if (type.IsNullableType())
            {
                var underlyingType = Nullable.GetUnderlyingType(type);

                var deepCloneableUnderlyingType = typeof(IDeepCloneable<>).MakeGenericType(underlyingType);

                result = deepCloneableUnderlyingType.IsAssignableFrom(underlyingType)
                    ? Invariant($"{cloneCode}?.DeepClone()")
                    : cloneCode;
            }
            else if (type.IsValueType)
            {
                // this is just a copy of the item anyway (like bool, int, Enumerations, structs like DateTime, etc.).
                result = cloneCode;
            }
            else if (type.IsInterface)
            {
                result = Invariant($"({type.ToStringReadable()})DeepCloneInterface({cloneCode})");
            }
            else if (type.IsGenericParameter)
            {
                result = Invariant($"DeepCloneGeneric({cloneCode})");
            }
            else
            {
                // Assume that we are driving the DeepClone() convention and it exists.
                // Could be an extension method in OBC.Type.Recipes.DeepCloneExtensions.
                result = Invariant($"{cloneCode}?.DeepClone()");
            }

            return result;
        }

        private static string ToExpressionParameter(
            this string expressionParameter,
            int recursionDepth)
        {
            string result;
            if (recursionDepth == 1)
            {
                result = expressionParameter;
            }
            else
            {
                result = expressionParameter + recursionDepth.ToString(CultureInfo.InvariantCulture);
            }

            return result;
        }

        private static string GenerateDeepCloneGenericCode(
            this ModelType modelType)
        {
            var codeSnippet = typeof(CloningGeneration).GetCodeTemplate(ClassifiedHierarchyKind.Concrete, CodeTemplateKind.ModelSnippet, KeyMethodKinds.Both, CodeSnippetKind.DeepCloneGeneric);

            var result = string.Empty;

            foreach (var genericParameter in modelType.GenericParameters)
            {
                // if the generic parameter is constrained to struct (e.g. public class MyClass<T> : where T : struct)
                // then IsValueType will be true.  We do not need the CloneGeneric method because in GenerateCloningLogicCodeForType
                // we first check IsValueType before we check type.IsGenericParameter
                if (!genericParameter.IsValueType)
                {
                    result = result + Environment.NewLine + Environment.NewLine + codeSnippet.Replace(Tokens.GenericTypeParameterNameToken, genericParameter.Name);
                }
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