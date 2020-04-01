// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClassifiedHierarchyKind.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    /// <summary>
    /// A classified version of <see cref="HierarchyKind"/>.
    /// </summary>
    internal enum ClassifiedHierarchyKind
    {
        /// <summary>
        /// Is abstract.
        /// </summary>
        Abstract,

        /// <summary>
        /// Is a concrete class.
        /// </summary>
        Concrete,
    }
}
