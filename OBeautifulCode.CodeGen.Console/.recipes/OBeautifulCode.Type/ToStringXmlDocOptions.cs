﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToStringReadableOptions.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Type.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Type.Recipes
{
    using global::System;

    /// <summary>
    /// Options for generating a XML doc compatible string representation of a type.
    /// </summary>
    [Flags]
#if !OBeautifulCodeTypeSolution
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Type.Recipes", "See package version number")]
    internal
#else
    public
#endif
    enum ToStringXmlDocOptions
    {
        /// <summary>
        /// None (default).
        /// Use this option to generate the most succinct representation of the specified type.
        /// </summary>
        None = 0,

        /// <summary>
        /// Include the namespace of the type.
        /// If the type is generic then also include the namespace of all generic argument types.
        /// </summary>
        IncludeNamespace = 1
    }
}