// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenerationShared.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Reflection.Recipes;

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
    }
}