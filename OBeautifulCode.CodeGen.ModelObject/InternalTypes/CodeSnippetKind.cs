// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeSnippetKind.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    /// <summary>
    /// Specifies a kind of code snippet.
    /// </summary>
    internal enum CodeSnippetKind
    {
        /// <summary>
        /// None; not a code snippet.
        /// </summary>
        None,

        /// <summary>
        /// A code snippet for a DeepCloneWith() method.
        /// </summary>
        DeepCloneWith,
    }
}
