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

            var deepCloneWithCode = modelType.DeclaresDeepCloneMethodDirectlyOrInDerivative
                ? string.Empty
                : modelType.GenerateDeepCloneWithCode();

            var codeTemplate = typeof(CloningGeneration).GetCodeTemplate(modelType.HierarchyKind, CodeTemplateKind.Model, modelType.DeepCloneKeyMethodKinds);

            var result = codeTemplate
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeReadableString)
                .Replace(Tokens.ModelRootAncestorTypeNameToken, modelType.InheritancePathCompilableStrings.LastOrDefault())
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

            if (modelType.DeclaresDeepCloneMethodDirectlyOrInDerivative || (!modelType.PropertiesOfConcern.Any()) || (modelType.ClassifiedHierarchyKind == ClassifiedHierarchyKind.Abstract))
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
                        .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                        .Replace(Tokens.PropertyNameToken, property.Name)
                        .Replace(Tokens.ParameterNameToken, property.ToParameterName());

                    deepCloneWithScenarios.Add(scenario);
                }
            }

            var deepCloneWithScenariosCode = deepCloneWithScenarios.Any() ? Environment.NewLine + string.Join(Environment.NewLine, deepCloneWithScenarios) : string.Empty;

            var result = typeof(CloningGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.TestSnippet, modelType.DeepCloneKeyMethodKinds, CodeSnippetKind.DeepCloneWithTestFields)
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
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
            var assertDeepCloneStatements = modelType.PropertiesOfConcern.Where(_ => !_.PropertyType.IsValueType && _.PropertyType != typeof(string)).Select(_ => Invariant($"actual.{_.Name}.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.{_.Name});")).ToList();

            var assertDeepCloneStatementsCode = assertDeepCloneStatements.Any()
                ? Environment.NewLine + "                " + string.Join(Environment.NewLine + "                ", assertDeepCloneStatements)
                : string.Empty;

            var deepCloneWithTestCode = (modelType.DeclaresDeepCloneMethodDirectlyOrInDerivative || (!modelType.PropertiesOfConcern.Any()) || (modelType.ClassifiedHierarchyKind == ClassifiedHierarchyKind.Abstract))
                ? string.Empty
                : Environment.NewLine + Environment.NewLine + typeof(CloningGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.TestSnippet, modelType.DeepCloneKeyMethodKinds, CodeSnippetKind.DeepCloneWithTest);

            var propertiesOfConcernNames = modelType.PropertiesOfConcern.Select(_ => "\"" + _.Name + "\"").ToDelimitedString(", ");

            var deepCloneWithThrowsTestMethods = new List<string>();

            foreach (var property in modelType.PropertiesOfConcern)
            {
                if (modelType.IsMissingCorrespondingConstructorParameter(property))
                {
                    var deepCloneWithThrowsTestMethod =
                        typeof(CloningGeneration).GetCodeTemplate(modelType.HierarchyKind, CodeTemplateKind.TestSnippet, modelType.DeepCloneKeyMethodKinds, CodeSnippetKind.DeepCloneWithThrows)
                            .Replace(Tokens.PropertyNameToken, property.Name)
                            .Replace(Tokens.PropertyTypeNameToken, property.PropertyType.ToStringCompilable())
                            .Replace(Tokens.ParameterNameToken, property.ToParameterName());

                    deepCloneWithThrowsTestMethods.Add(deepCloneWithThrowsTestMethod);
                }
            }

            var deepCloneWithThrowsTestMethodsCode = (modelType.DeclaresDeepCloneMethodDirectlyOrInDerivative || (!modelType.PropertiesOfConcern.Any()) || (!deepCloneWithThrowsTestMethods.Any()))
                ? string.Empty
                : Environment.NewLine + Environment.NewLine + deepCloneWithThrowsTestMethods.ToDelimitedString(Environment.NewLine + Environment.NewLine);

            var codeTemplate = typeof(CloningGeneration).GetCodeTemplate(CodeTemplateKind.Test, KeyMethodKinds.Both);

            var result = codeTemplate
                .Replace(Tokens.AssertDeepCloneToken, assertDeepCloneStatementsCode)
                .Replace(Tokens.DeepCloneWithTestToken, deepCloneWithTestCode)
                .Replace(Tokens.DeepCloneWithThrowsTestsToken, deepCloneWithThrowsTestMethodsCode)
                .Replace(Tokens.PropertiesOfConcernNamesHereToken, propertiesOfConcernNames)
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString);

            return result;
        }

        private static string GenerateDeepCloneCode(
            this ModelType modelType)
        {
            var deepCloneCodeForEachProperty = modelType
                .PropertiesOfConcern
                .Select(_ => new MemberCode(_.Name, _.PropertyType.GenerateCloningLogicCodeForType("this." + _.Name)))
                .ToList();

            var result = modelType.GenerateModelInstantiation(deepCloneCodeForEachProperty, parameterPaddingLength: 33);

            return result;
        }

        private static string GenerateDeepCloneWithCode(
            this ModelType modelType)
        {
            var deepCloneWithMethods = new List<string>();

            if (modelType.PropertiesOfConcern.Any())
            {
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
                        .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                        .Replace(Tokens.ModelAncestorTypeNameToken, property.DeclaringType.ToStringReadable())
                        .Replace(Tokens.PropertyNameToken, property.Name)
                        .Replace(Tokens.ParameterNameToken, property.ToParameterName())
                        .Replace(Tokens.ParameterNameInXmlDocToken, property.ToParameterName(forXmlDoc: true))
                        .Replace(Tokens.PropertyTypeNameToken, property.PropertyType.ToStringCompilable())
                        .Replace(Tokens.DeepCloneWithModelInstantiationToken, deepCloneWithModelInstantiationCode);

                    deepCloneWithMethods.Add(deepCloneWithMethod);
                }
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
            if (type.IsAssignableTo(deepCloneableType))
            {
                result = type.IsValueType
                    ? Invariant($"{cloneCode}.DeepClone()")
                    : Invariant($"{cloneCode}?.DeepClone()");
            }
            else if (type.IsClosedSystemDictionaryType())
            {
                var keyType = type.GetClosedSystemDictionaryKeyType();
                var valueType = type.GetClosedSystemDictionaryValueType();

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
            else if (type.IsClosedSystemCollectionType())
            {
                var elementType = type.GetClosedSystemCollectionElementType();

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
            else if (type == typeof(string))
            {
                // string should be cloned using it's existing interface.
                // note that this just returns the same reference, it doesn't result in a new reference
                // the ToString() is needed because Clone() returns an Object.
                // https://stackoverflow.com/questions/3465377/whats-the-use-of-string-clone
                result = Invariant($"{cloneCode}?.Clone().ToString()");
            }
            else if (type.IsClosedNullableType())
            {
                var underlyingType = Nullable.GetUnderlyingType(type);

                var deepCloneableUnderlyingType = typeof(IDeepCloneable<>).MakeGenericType(underlyingType);

                result = underlyingType.IsAssignableTo(deepCloneableUnderlyingType)
                    ? Invariant($"{cloneCode}?.DeepClone()")
                    : cloneCode;
            }
            else if (type.IsValueType)
            {
                // this is just a copy of the item anyway (like bool, int, Enumerations, structs like DateTime, etc.).
                result = cloneCode;
            }
            else
            {
                // assume that we are driving the DeepClone convention and it exists.
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
    }
}