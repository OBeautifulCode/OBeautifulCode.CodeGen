﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppDomainScenarios.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Serialization.Recipes
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Serialization.Recipes.Internal;

    /// <summary>
    /// Specifies various scenarios of serializing and de-serializing in the current App Domain or a new App Domain.
    /// </summary>
    [Flags]
#if !OBeautifulCodeSerializationRecipesProject
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Serialization.Recipes", "See package version number")]
    internal
#else
    public
#endif
    enum AppDomainScenarios
    {
        /// <summary>
        /// None (default).
        /// </summary>
        None = 0,

        /// <summary>
        /// Serialize and de-serialize in the current App Domain.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "InCurrent", Justification = ObcSuppressBecause.CA1702_CompoundWordsShouldBeCasedCorrectly_AnalyzerIsIncorrectlyDetectingCompoundWords)]
        RoundtripInCurrentAppDomain,

        /// <summary>
        /// Serialize and de-serialize in a new App Domain.
        /// </summary>
        RoundtripInNewAppDomain,

        /// <summary>
        /// Serialize in the current App Domain and de-serialize in a new App Domain.
        /// </summary>
        /// <remarks>
        /// This is specifically to test that an object can be de-serialized without first
        /// needing to be serialized - that there's no config or caching that serialization
        /// performs that de-serialization is dependent on.
        /// </remarks>
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "InCurrent", Justification = ObcSuppressBecause.CA1702_CompoundWordsShouldBeCasedCorrectly_AnalyzerIsIncorrectlyDetectingCompoundWords)]
        SerializeInCurrentAppDomainAndDeserializeInNewAppDomain,

        /// <summary>
        /// Serialize in a new App Domain and de-serialize in a new, but different App Domain.
        /// </summary>
        /// <remarks>
        /// This is specifically to test that an object can be de-serialized without first
        /// needing to be serialized - that there's no config or caching that serialization
        /// performs that de-serialization is dependent on.
        /// </remarks>
        SerializeInNewAppDomainAndDeserializeInNewAppDomain,
    }
}
