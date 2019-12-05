// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenerationShared.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
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
    }
}