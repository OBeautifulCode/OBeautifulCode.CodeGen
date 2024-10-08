﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenerationShared.cs" company="OBeautifulCode">
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
    using System.Reflection;

    using Microsoft.CSharp;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Reflection.Recipes;
    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Shared methods for generation.
    /// </summary>
    internal static class GenerationShared
    {
        /// <summary>
        /// Gets the Code Gen assembly name.
        /// </summary>
        /// <returns>
        /// The Code Gen assembly name.
        /// </returns>
        public static string GetCodeGenAssemblyName()
        {
            var result = typeof(GenerationShared).Assembly.GetName().Name;

            return result;
        }

        /// <summary>
        /// Gets the Code Gen assembly version.
        /// </summary>
        /// <returns>
        /// The Code Gen assembly version.
        /// </returns>
        public static string GetCodeGenAssemblyVersion()
        {
            var result = typeof(GenerationShared).Assembly.GetName().Version.ToString();

            return result;
        }

        /// <summary>
        /// Gets a code template.
        /// </summary>
        /// <param name="generationType">The type of the class containing the generation logic.</param>
        /// <param name="codeTemplateKind">The code template kind.</param>
        /// <param name="keyMethodKinds">The key method kinds.</param>
        /// <param name="codeSnippetKind">Optional code snippet kind.  Default is None (not treated as a code snippet).</param>
        /// <param name="throwIfDoesNotExist">Throw if the code template does not exist.</param>
        /// <returns>
        /// The code template corresponding to the specified parameters.
        /// </returns>
        public static string GetCodeTemplate(
            this Type generationType,
            CodeTemplateKind codeTemplateKind,
            KeyMethodKinds keyMethodKinds,
            CodeSnippetKind codeSnippetKind = CodeSnippetKind.None,
            bool throwIfDoesNotExist = true)
        {
            var result = generationType.GetCodeTemplate("All", codeTemplateKind, keyMethodKinds, codeSnippetKind, throwIfDoesNotExist);

            return result;
        }

        /// <summary>
        /// Gets a code template.
        /// </summary>
        /// <param name="generationType">The type of the class containing the generation logic.</param>
        /// <param name="hierarchyKind">The hierarchy kind.</param>
        /// <param name="codeTemplateKind">The code template kind.</param>
        /// <param name="keyMethodKinds">The key method kinds.</param>
        /// <param name="codeSnippetKind">Optional code snippet kind.  Default is None (not treated as a code snippet).</param>
        /// <param name="throwIfDoesNotExist">Throw if the code template does not exist.</param>
        /// <returns>
        /// The code template corresponding to the specified parameters.
        /// </returns>
        public static string GetCodeTemplate(
            this Type generationType,
            HierarchyKind hierarchyKind,
            CodeTemplateKind codeTemplateKind,
            KeyMethodKinds keyMethodKinds,
            CodeSnippetKind codeSnippetKind = CodeSnippetKind.None,
            bool throwIfDoesNotExist = true)
        {
            var result = generationType.GetCodeTemplate(hierarchyKind.ToString(), codeTemplateKind, keyMethodKinds, codeSnippetKind, throwIfDoesNotExist);

            return result;
        }

        /// <summary>
        /// Gets a code template.
        /// </summary>
        /// <param name="generationType">The type of the class containing the generation logic.</param>
        /// <param name="classifiedHierarchyKind">The classified hierarchy kind.</param>
        /// <param name="codeTemplateKind">The code template kind.</param>
        /// <param name="keyMethodKinds">The key method kinds.</param>
        /// <param name="codeSnippetKind">Optional code snippet kind.  Default is None (not treated as a code snippet).</param>
        /// <param name="throwIfDoesNotExist">Throw if the code template does not exist.</param>
        /// <returns>
        /// The code template corresponding to the specified parameters.
        /// </returns>
        public static string GetCodeTemplate(
            this Type generationType,
            ClassifiedHierarchyKind classifiedHierarchyKind,
            CodeTemplateKind codeTemplateKind,
            KeyMethodKinds keyMethodKinds,
            CodeSnippetKind codeSnippetKind = CodeSnippetKind.None,
            bool throwIfDoesNotExist = true)
        {
            var result = generationType.GetCodeTemplate(classifiedHierarchyKind.ToString(), codeTemplateKind, keyMethodKinds, codeSnippetKind, throwIfDoesNotExist);

            return result;
        }

        /// <summary>
        /// Generates code that instantiates a model object.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <param name="memberCode">The code for the members.</param>
        /// <param name="parameterPaddingLength">The length of the padding to use for constructor or object initializer parameters.</param>
        /// <returns>
        /// Generated code that instantiates a model object.
        /// </returns>
        public static string GenerateModelInstantiation(
            this ModelType modelType,
            IReadOnlyList<MemberCode> memberCode,
            int parameterPaddingLength)
        {
            new { modelType }.AsArg().Must().NotBeNull();
            new { memberCode }.AsArg().Must().NotBeNull().And().NotContainAnyNullElements();

            string result;

            var memberNames = memberCode.Select(_ => _.Name).ToList();

            var parameterPadding = new string(' ', parameterPaddingLength);

            if ((modelType.Constructor == null) || modelType.Constructor.IsDefaultConstructor())
            {
                if (memberCode.Any())
                {
                    var curlyBracketPadding = new string(' ', parameterPaddingLength - 4);

                    var maxCharsInAnyPropertyName = memberNames.Any() ? memberNames.Select(_ => _.Length).Max() : 0;

                    var propertyInitializerCode = memberCode.Select(_ => Invariant($"{_.Name.PadRight(maxCharsInAnyPropertyName, ' ')} = {_.Code}")).ToDelimitedString("," + Environment.NewLine + parameterPadding);

                    result = "new " + modelType.TypeNameInCodeString + Environment.NewLine + curlyBracketPadding + "{" + Environment.NewLine + parameterPadding + propertyInitializerCode + "," + Environment.NewLine + curlyBracketPadding + "}";
                }
                else
                {
                    result = "new " + modelType.TypeNameInCodeString + "()";
                }
            }
            else
            {
                var propertyNameToCodeMap = memberCode.ToDictionary(_ => _.Name, _ => _.Code, StringComparer.OrdinalIgnoreCase);

                var parameters = modelType.Constructor.GetParameters();

                var parameterCode =
                    parameters
                        .Select(_ => propertyNameToCodeMap[_.Name])
                        .ToDelimitedString("," + Environment.NewLine + parameterPadding);

                result = "new " + modelType.TypeNameInCodeString + "(" + (parameters.Any() ? Environment.NewLine + parameterPadding : string.Empty) + parameterCode + ")";
            }

            return result;
        }

        /// <summary>
        /// Generates the code to instantiate a System type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="constructorParameterCode">The code to inject into the constructor.</param>
        /// <returns>
        /// The code to instantiate a System type.
        /// </returns>
        public static string GenerateSystemTypeInstantiationCode(
            this Type type,
            string constructorParameterCode = null)
        {
            new { type }.AsArg().Must().NotBeNull();

            string result;

            if (type.IsArray)
            {
                var elementType = type.GetElementType();

                result = Invariant($"new {elementType.ToStringReadable()}[0]");
            }
            else if (type.IsSystemCollectionType())
            {
                var elementType = type.GetGenericArguments().First();

                if (type.IsInterface || (type.GetGenericTypeDefinition() == typeof(List<>)))
                {
                    result = Invariant($"new List<{elementType.ToStringReadable()}>({constructorParameterCode})");
                }
                else if (type.GetGenericTypeDefinition() == typeof(Collection<>))
                {
                    result = Invariant($"new Collection<{elementType.ToStringReadable()}>({constructorParameterCode})");
                }
                else if (type.GetGenericTypeDefinition() == typeof(ReadOnlyCollection<>))
                {
                    constructorParameterCode = constructorParameterCode ?? Invariant($"new List<{elementType.ToStringReadable()}>()");

                    result = Invariant($"new ReadOnlyCollection<{elementType.ToStringReadable()}>({constructorParameterCode})");
                }
                else
                {
                    throw new NotSupportedException("This System Collection type is not supported: " + type);
                }
            }
            else if (type.IsSystemDictionaryType())
            {
                var keyType = type.GetGenericArguments().First();

                var valueType = type.GetGenericArguments().Last();

                result = Invariant($"new Dictionary<{keyType.ToStringReadable()}, {valueType.ToStringReadable()}>({constructorParameterCode})");

                if (type.GetGenericTypeDefinition() == typeof(ReadOnlyDictionary<,>))
                {
                    constructorParameterCode = constructorParameterCode ?? result;

                    result = Invariant($"new ReadOnlyDictionary<{keyType.ToStringReadable()}, {valueType.ToStringReadable()}>({constructorParameterCode})");
                }
                else if (type.GetGenericTypeDefinition() == typeof(ConcurrentDictionary<,>))
                {
                    constructorParameterCode = constructorParameterCode ?? result;

                    result = Invariant($"new ConcurrentDictionary<{keyType.ToStringReadable()}, {valueType.ToStringReadable()}>({constructorParameterCode})");
                }
            }
            else
            {
                throw new NotSupportedException("This System type is not supported: " + type);
            }

            return result;
        }

        /// <summary>
        /// Generates code that constructs a dummy model.
        /// </summary>
        /// <param name="typeCompilableString">The type's compilable string representation.</param>
        /// <param name="memberName">OPTIONAL name of the member.  DEFAULT is not applicable.</param>
        /// <returns>
        /// Generated code that constructs a dummy model.
        /// </returns>
        public static string GenerateDummyConstructionCodeForType(
            this string typeCompilableString,
            string memberName = null)
        {
            new { typeCompilableString }.AsArg().Must().NotBeNullNorWhiteSpace();

            // Here we intercept DateTime and DateTime? and use UtcDateTime when the member name contains "utc"
            // There's no easy to way handle the case where the type is a IReadOnlyCollection<DateTime> or other collection or nullable variations.
            // That's because a IReadOnlyCollection<UtcDateTime> is not assignable to a IReadOnlyCollection<DateTime>.
            if ((typeCompilableString == typeof(DateTime).ToStringReadable()) || (typeCompilableString == typeof(DateTime?).ToStringReadable()))
            {
                if ((memberName != null) && memberName.ToUpperInvariant().Contains("UTC"))
                {
                    typeCompilableString = "UtcDateTime";
                }
            }

            var result = "A.Dummy<" + typeCompilableString + ">()";

            return result;
        }

        /// <summary>
        /// Replaces all code analysis suppression tokens in test code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns>
        /// The code after tokens have been replace.
        /// </returns>
        public static string ReplaceCodeAnalysisSuppressionTokensInTestCode(
            this string code)
        {
            if (code == null)
            {
                return null;
            }

            var nestedTestClassCodeAnalysisSuppressions = typeof(ModelImplementationGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.NestedTestClassCodeAnalysisSuppressions);
            var testMethodCodeAnalysisSuppressions = typeof(ModelImplementationGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.TestMethodCodeAnalysisSuppressions);

            var result = code
                .Replace(Tokens.NestedTestClassCodeAnalysisSuppressionsToken, nestedTestClassCodeAnalysisSuppressions)
                .Replace(Tokens.TestMethodCodeAnalysisSuppressionsToken, testMethodCodeAnalysisSuppressions);

            return result;
        }

        /// <summary>
        /// Converts a property to it's corresponding parameter name
        /// in constructors and other methods.
        /// </summary>
        /// <param name="propertyOfConcern">The property of concern.</param>
        /// <param name="forXmlDoc">A value indicating whether the parameter name will be used used in XML doc.</param>
        /// <returns>
        /// The parameter name.
        /// </returns>
        public static string ToParameterName(
            this PropertyOfConcern propertyOfConcern,
            bool forXmlDoc = false)
        {
            new { propertyOfConcern }.AsArg().Must().NotBeNull();

            var result = propertyOfConcern.Name.ToLowerFirstCharacter(CultureInfo.InvariantCulture);

            if (!forXmlDoc)
            {
                using (var codeProvider = new CSharpCodeProvider())
                {
                    if (!codeProvider.IsValidIdentifier(result))
                    {
                        result = "@" + result;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Converts a parameter to it's corresponding property name.
        /// </summary>
        /// <param name="parameterInfo">The parameter of concern.</param>
        /// <returns>
        /// The property name.
        /// </returns>
        public static string ToPropertyName(
            this ParameterInfo parameterInfo)
        {
            new { parameterInfo }.AsArg().Must().NotBeNull();

            // note that parameters names don't have the leading @ if they are
            // reserved words. So if a constructor's parameter is defined as '@namespace' in code
            // then it's parameterInfo.Name is just 'namespace'.
            var result = parameterInfo.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

            return result;
        }

        /// <summary>
        /// Determines if the model's constructor is missing a parameter that corresponds
        /// to the specified property of concern.
        /// </summary>
        /// <remarks>
        /// This occurs when a base class property isn't a constructor parameter (so the concrete class is passing a compile-time constant to the base class).
        /// </remarks>
        /// <param name="modelType">The model type.</param>
        /// <param name="propertyOfConcern">The property of concern.</param>
        /// <returns>
        /// true if the model has a public, non-default constructor that is missing a parameter that corresponds to the specified property.
        /// </returns>
        public static bool IsMissingCorrespondingConstructorParameter(
            this ModelType modelType,
            PropertyOfConcern propertyOfConcern)
        {
            new { modelType }.AsArg().Must().NotBeNull();
            new { propertyOfConcern }.AsArg().Must().NotBeNull();

            var result = (modelType.HierarchyKind == HierarchyKind.ConcreteInherited)
                         && (!modelType.Constructor.IsDefaultConstructor())
                         && (!modelType.Constructor.GetParameters().Select(_ => _.Name).Contains(propertyOfConcern.Name, StringComparer.OrdinalIgnoreCase));

            return result;
        }

        /// <summary>
        /// Gets the required cast statement, if any, to use the value of a property when constructing the model.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <param name="propertyOfConcern">The property of concern.</param>
        /// <returns>
        /// The cast statement, if any is required.
        /// </returns>
        public static string CastIfConstructorParameterIsOfDifferentType(
            this ModelType modelType,
            PropertyOfConcern propertyOfConcern)
        {
            string result;

            var propertyName = propertyOfConcern.Name;

            if (modelType.PropertyNameToConstructorParameterTypeMap.ContainsKey(propertyName))
            {
                var constructorParameterType = modelType.PropertyNameToConstructorParameterTypeMap[propertyName];

                var propertyType = propertyOfConcern.PropertyType;

                result = propertyType != constructorParameterType
                    ? Invariant($"({constructorParameterType.ToStringReadable()})")
                    : string.Empty;
            }
            else
            {
                result = string.Empty;
            }

            return result;
        }

        private static string GetCodeTemplate(
            this Type generationType,
            string hierarchyKind,
            CodeTemplateKind codeTemplateKind,
            KeyMethodKinds keyMethodKinds,
            CodeSnippetKind codeSnippetKind = CodeSnippetKind.None,
            bool throwIfDoesNotExist = true)
        {
            new { keyMethodKinds }.AsArg().Must().NotBeEqualTo(KeyMethodKinds.Unknown);

            var codeSnippetToken = codeSnippetKind == CodeSnippetKind.None
                ? string.Empty
                : codeSnippetKind + ".";

            var resourceNameSuffix = Invariant($"{generationType.Name}.{codeTemplateKind}.{codeSnippetToken}{hierarchyKind}.{keyMethodKinds}.txt");

            var resourceName = typeof(GenerationShared).Assembly.GetManifestResourceNames().SingleOrDefault(_ => _.EndsWith(resourceNameSuffix, StringComparison.Ordinal));

            if (throwIfDoesNotExist)
            {
                if (resourceName == null)
                {
                    throw new InvalidOperationException("An embedded resource with this suffix does not exist: " + resourceNameSuffix);
                }
            }
            else
            {
                if (resourceName == null)
                {
                    return null;
                }
            }

            var result = AssemblyHelper.ReadEmbeddedResourceAsString(resourceName, addCallerNamespace: false);

            return result;
        }
    }
}