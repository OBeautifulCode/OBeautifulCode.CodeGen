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

    /// <summary>
    /// Specifies a scenario for constructor argument validation tests.
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
        private const string AlwaysPassingExceptionMessage = "Thrown by ConstructionFunc for a constructor argument validation test scenario that is guaranteed to pass because the ExpectedExceptionType and ExpectedExceptionMessageEquals are set to the type of this exception and this message, respectively.";

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

        /// <summary>
        /// Gets a scenario to use when the constructor cannot throw.
        /// </summary>
        public static ConstructorArgumentValidationTestScenario<T> ConstructorCannotThrowScenario =>
            new ConstructorArgumentValidationTestScenario<T>
            {
                Name = "constructor cannot throw",
                ConstructionFunc = () => throw new NotSupportedException(AlwaysPassingExceptionMessage),
                ExpectedExceptionType = typeof(NotSupportedException),
                ExpectedExceptionMessageEquals = AlwaysPassingExceptionMessage,
            };

        /// <summary>
        /// Gets a scenario to use when you need to force the consuming unit tests to pass and you intend to write your own unit tests.
        /// </summary>
        public static ConstructorArgumentValidationTestScenario<T> ForceGeneratedTestsToPassAndWriteMyOwnScenario =>
            new ConstructorArgumentValidationTestScenario<T>
            {
                Name = "force generated unit tests to pass, i'll write my own",
                ConstructionFunc = () => throw new NotSupportedException(AlwaysPassingExceptionMessage),
                ExpectedExceptionType = typeof(NotSupportedException),
                ExpectedExceptionMessageEquals = AlwaysPassingExceptionMessage,
            };
    }
}
