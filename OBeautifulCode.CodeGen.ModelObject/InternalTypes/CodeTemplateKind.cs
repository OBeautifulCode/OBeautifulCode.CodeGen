// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeTemplateKind.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    /// <summary>
    /// Specifies a kind of code template.
    /// </summary>
    internal enum CodeTemplateKind
    {
        /// <summary>
        /// A template for code that goes in the model.
        /// </summary>
        Model,

        /// <summary>
        /// A template for code that goes in the test class.
        /// </summary>
        Test,

        /// <summary>
        /// A template for a snippet of code that goes in the model.
        /// </summary>
        ModelSnippet,

        /// <summary>
        /// A template for a snippet of code that goes in the test class.
        /// </summary>
        TestSnippet,
    }
}
