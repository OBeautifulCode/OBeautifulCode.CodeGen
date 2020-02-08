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
        /// Is an abstract base root class.
        /// </summary>
        AbstractBaseRoot,

        /// <summary>
        /// Is an abstract base class that inherits from
        /// an abstract base class (root or not).
        /// </summary>
        AbstractBaseInherited,

        /// <summary>
        /// Is a concrete, inherited class.
        /// </summary>
        ConcreteInherited,
    }
}
