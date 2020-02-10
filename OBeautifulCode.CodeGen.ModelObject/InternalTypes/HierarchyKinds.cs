// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HierarchyKinds.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;

    /// <summary>
    /// Specifies one or more <see cref="HierarchyKind"/> to consider.
    /// </summary>
    [Flags]
    internal enum HierarchyKinds
    {
        /// <summary>
        /// Unknown (default).
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// No participation in a hierarchy.
        /// </summary>
        Standalone = 1,

        /// <summary>
        /// Is an abstract base root class.
        /// </summary>
        AbstractBaseRoot = 2,

        /// <summary>
        /// Is an abstract base class that inherits from
        /// an abstract base class (root or not).
        /// </summary>
        AbstractBaseInherited = 4,

        /// <summary>
        /// Is abstract.
        /// </summary>
        Abstract  = AbstractBaseRoot | AbstractBaseInherited,

        /// <summary>
        /// Is a concrete, inherited class.
        /// </summary>
        ConcreteInherited = 8,

        /// <summary>
        /// Is a concrete class.
        /// </summary>
        Concrete = Standalone | ConcreteInherited,

        /// <summary>
        /// All kinds.
        /// </summary>
        All = Abstract | Concrete,
    }
}
