﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstructorArgumentValidationTestScenario{T}.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.CodeGen.ModelObject.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Recipes
{
    using System;
    using System.Collections.Generic;

    using static System.FormattableString;

    /// <summary>
    /// Specifies a scenario for construction argument validation tests.
    /// </summary>
    /// <typeparam name="T">The type of the object being tested.</typeparam>
#if !OBeautifulCodeCodeGenRecipesProject
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.CodeGen.ModelObject.Recipes", "See package version number")]
    internal
#else
    public
#endif
    class ConstructorArgumentValidationTestScenario<T>
        where T : class
    {
        /// <summary>
        /// Gets or sets the name of the scenario.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a func that constructs the object.
        /// </summary>
        public Func<T> ConstructionFunc { get; set; }

        /// <summary>
        /// Gets or sets the Type of the expected <see cref="Exception"/> that is thrown when the object is constructed.
        /// </summary>
        public Type ExpectedExceptionType { get; set; }

        /// <summary>
        /// Gets or sets a set strings that should each be contained within the expected <see cref="Exception.Message"/>.
        /// If the full message is known, leave null and set <see cref="ExpectedExceptionMessageEquals"/>.
        /// </summary>
        public IReadOnlyCollection<string> ExpectedExceptionMessageContains { get; set; }

        /// <summary>
        /// Gets or sets the expected <see cref="Exception.Message"/>.
        /// If the full message is not known, leave null and set <see cref="ExpectedExceptionMessageContains"/>.
        /// </summary>
        public string ExpectedExceptionMessageEquals { get; set; }
    }
}
