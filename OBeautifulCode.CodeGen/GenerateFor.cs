// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenerateFor.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Determines which code should be generated.
    /// </summary>
    [Flags]
    [SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames", Justification = "Name/spelling is correct.")]
    public enum GenerateFor
    {
        /// <summary>
        /// None (default).
        /// </summary>
        None = 0,

        /// <summary>
        /// The model dummy factory snippet.
        /// </summary>
        ModelDummyFactorySnippet = 1,

        /// <summary>
        /// The model implementation partial class.
        /// </summary>
        ModelImplementationPartialClass = 2,

        /// <summary>
        /// The model implementation tests partial class with serialization.
        /// </summary>
        ModelImplementationTestsPartialClassWithSerialization = 4,

        /// <summary>
        /// The model implementation tests partial class without serialization.
        /// </summary>
        ModelImplementationTestsPartialClassWithoutSerialization = 8,
    }
}