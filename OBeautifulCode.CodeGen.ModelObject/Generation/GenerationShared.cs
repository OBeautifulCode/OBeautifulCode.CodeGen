// --------------------------------------------------------------------------------------------------------------------
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
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Reflection.Recipes;
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
        /// Converts a <see cref="HierarchyKind"/> to a <see cref="HierarchyKinds"/>.
        /// </summary>
        /// <param name="hierarchyKind">The hierarchy kind to convert.</param>
        /// <returns>
        /// The <see cref="HierarchyKinds"/> equivalent of the specified <see cref="HierarchyKind"/>.
        /// </returns>
        public static HierarchyKinds ToHierarchyKinds(
            this HierarchyKind hierarchyKind)
        {
            switch (hierarchyKind)
            {
                case HierarchyKind.Standalone:
                    return HierarchyKinds.Standalone;
                case HierarchyKind.AbstractBaseRoot:
                    return HierarchyKinds.AbstractBaseRoot;
                case HierarchyKind.AbstractBaseInherited:
                    return HierarchyKinds.AbstractBaseInherited;
                case HierarchyKind.ConcreteInherited:
                    return HierarchyKinds.ConcreteInherited;
                default:
                    throw new NotSupportedException("This hierarchy kind is not supported: " + hierarchyKind);
            }
        }

        /// <summary>
        /// Classifies the specified <see cref="HierarchyKind"/>
        /// into abstract or concrete.
        /// </summary>
        /// <param name="hierarchyKinds">The hierarchy kinds.</param>
        /// <returns>
        /// The specified hierarchy kinds, classified into abstract or concrete.
        /// </returns>
        public static HierarchyKinds Classify(
            this HierarchyKinds hierarchyKinds)
        {
            if ((hierarchyKinds & HierarchyKinds.Abstract) != 0)
            {
                return HierarchyKinds.Abstract;
            }

            if ((hierarchyKinds & HierarchyKinds.Concrete) != 0)
            {
                return HierarchyKinds.Concrete;
            }

            throw new InvalidOperationException("Cannot be classified");
        }

        /// <summary>
        /// Gets a code template.
        /// </summary>
        /// <param name="generationType">The type of the class containing the generation logic.</param>
        /// <param name="hierarchyKinds">The hierarchy kinds.</param>
        /// <param name="codeTemplateKind">The code template kind.</param>
        /// <param name="keyMethodKinds">The key method kinds.</param>
        /// <param name="codeSnippetKind">Optional code snippet kind.  Default is None (not treated as a code snippet).</param>
        /// <returns>
        /// The code template corresponding to the specified parameters.
        /// </returns>
        public static string GetCodeTemplate(
            this Type generationType,
            HierarchyKinds hierarchyKinds,
            CodeTemplateKind codeTemplateKind,
            KeyMethodKinds keyMethodKinds,
            CodeSnippetKind codeSnippetKind = CodeSnippetKind.None)
        {
            new { hierarchyKinds }.AsArg().Must().NotBeEqualTo(HierarchyKinds.Unknown);
            new { keyMethodKinds }.AsArg().Must().NotBeEqualTo(KeyMethodKinds.Unknown);

            var codeSnippetToken = codeSnippetKind == CodeSnippetKind.None
                ? string.Empty
                : codeSnippetKind + ".";

            var resourceNameSuffix = Invariant($"{generationType.Name}.{codeTemplateKind}.{codeSnippetToken}{hierarchyKinds}.{keyMethodKinds}.txt");

            var resourceName = typeof(GenerationShared).Assembly.GetManifestResourceNames().Single(_ => _.EndsWith(resourceNameSuffix));

            var result = AssemblyHelper.ReadEmbeddedResourceAsString(resourceName, addCallerNamespace: false);

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
            string result;

            if (type.IsArray)
            {
                var elementType = type.GetElementType();

                result = Invariant($"new {elementType.ToStringCompilable()}[0]");
            }
            else if (type.IsClosedSystemCollectionType())
            {
                var elementType = type.GetClosedSystemCollectionElementType();

                if (type.IsInterface || (type.GetGenericTypeDefinition() == typeof(List<>)))
                {
                    result = Invariant($"new List<{elementType.ToStringCompilable()}>({constructorParameterCode})");
                }
                else if (type.GetGenericTypeDefinition() == typeof(Collection<>))
                {
                    result = Invariant($"new Collection<{elementType.ToStringCompilable()}>({constructorParameterCode})");
                }
                else if (type.GetGenericTypeDefinition() == typeof(ReadOnlyCollection<>))
                {
                    constructorParameterCode = constructorParameterCode ?? Invariant($"new List<{elementType.ToStringCompilable()}>()");

                    result = Invariant($"new ReadOnlyCollection<{elementType.ToStringCompilable()}>({constructorParameterCode})");
                }
                else
                {
                    throw new NotSupportedException("This System Collection type is not supported: " + type);
                }
            }
            else if (type.IsClosedSystemDictionaryType())
            {
                var keyType = type.GetClosedSystemDictionaryKeyType();

                var valueType = type.GetClosedSystemDictionaryValueType();

                result = Invariant($"new Dictionary<{keyType.ToStringCompilable()}, {valueType.ToStringCompilable()}>({constructorParameterCode})");

                if (type.GetGenericTypeDefinition() == typeof(ReadOnlyDictionary<,>))
                {
                    constructorParameterCode = constructorParameterCode ?? result;

                    result = Invariant($"new ReadOnlyDictionary<{keyType.ToStringCompilable()}, {valueType.ToStringCompilable()}>({constructorParameterCode})");
                }
                else if (type.GetGenericTypeDefinition() == typeof(ConcurrentDictionary<,>))
                {
                    constructorParameterCode = constructorParameterCode ?? result;

                    result = Invariant($"new ConcurrentDictionary<{keyType.ToStringCompilable()}, {valueType.ToStringCompilable()}>({constructorParameterCode})");
                }
            }
            else
            {
                throw new NotSupportedException("This System type is not supported: " + type);
            }

            return result;
        }
    }
}