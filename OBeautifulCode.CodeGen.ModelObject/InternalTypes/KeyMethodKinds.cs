// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KeyMethodKinds.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;

    /// <summary>
    /// Specifies the kinds of key method.
    /// </summary>
    [Flags]
    internal enum KeyMethodKinds
    {
        /// <summary>
        /// Unknown (default).
        /// </summary>
        Unknown,

        /// <summary>
        /// The key method is declared.
        /// </summary>
        Declared = 1,

        /// <summary>
        /// The key method is generated.
        /// </summary>
        Generated = 2,

        /// <summary>
        /// The key method is declared or generated.
        /// </summary>
        Both = Declared | Generated,
    }
}
