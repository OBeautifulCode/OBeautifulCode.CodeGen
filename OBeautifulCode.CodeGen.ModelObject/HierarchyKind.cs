// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HierarchyKind.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    /// <summary>
    /// Determine how a user-defined class participates in a hierarchy.
    /// </summary>
    public enum HierarchyKind
    {
        /// <summary>
        /// No participation in a hierarchy.
        /// </summary>
        None,

        /// <summary>
        /// Is an abstract base class.
        /// </summary>
        AbstractBase,

        /// <summary>
        /// Is a concrete, inherited class.
        /// </summary>
        ConcreteInherited,
    }
}
