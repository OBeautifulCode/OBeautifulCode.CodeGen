// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenerationShared.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;

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
        /// Gets a code template.
        /// </summary>
        /// <param name="generationType">The type of the class containing the generation logic.</param>
        /// <param name="hierarchyKind">The hierarchy kind.</param>
        /// <param name="codeTemplateKind">The code template kind.</param>
        /// <param name="declaresMethod">A value indicating whether the key method is declared.</param>
        /// <param name="codeSnippetKind">Optional code snippet kind.  Default is None (not treated as a code snippet).</param>
        /// <returns>
        /// The code template corresponding to the specified parameters.
        /// </returns>
        public static string GetCodeTemplate(
            this Type generationType,
            HierarchyKind hierarchyKind,
            CodeTemplateKind codeTemplateKind,
            bool declaresMethod,
            CodeSnippetKind codeSnippetKind = CodeSnippetKind.None)
        {
            var declaredDesignation = declaresMethod ? "declared" : "default";

            var codeSnippetToken = codeSnippetKind == CodeSnippetKind.None
                ? string.Empty
                : codeSnippetKind + ".";

            var resourceNameSuffix = Invariant($"{generationType.Name}.{codeTemplateKind}.{codeSnippetToken}{hierarchyKind}.{declaredDesignation}.txt");

            var resourceName = typeof(GenerationShared).Assembly.GetManifestResourceNames().Single(_ => _.EndsWith(resourceNameSuffix));

            var result = AssemblyHelper.ReadEmbeddedResourceAsString(resourceName, addCallerNamespace: false);

            return result;
        }
    }
}