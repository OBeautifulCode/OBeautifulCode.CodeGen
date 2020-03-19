﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeepCloneWithTestScenario{T}.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.CodeGen.ModelObject.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Recipes
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Specifies a scenario for testing DeepCloneWith... methods.
    /// </summary>
    /// <typeparam name="T">The type of the object being tested.</typeparam>
#if !OBeautifulCodeCodeGenRecipesProject
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.CodeGen.ModelObject.Recipes", "See package version number")]
    internal
#else
    public
#endif
    class DeepCloneWithTestScenario<T>
        where T : class
    {
        /// <summary>
        /// Gets or sets the name of the scenario.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the property whose value is provided in the DeepCloneWith call.
        /// All other properties will be deep cloned EXCEPT this one.
        /// </summary>
        public string WithPropertyName { get; set; }

        /// <summary>
        /// Gets or sets a func that returns the object being tested and a value to deep clone that object with.
        /// </summary>
        public Func<SystemUnderTestDeepCloneWithValue<T>> SystemUnderTestDeepCloneWithValueFunc { get; set; }

        /// <summary>
        /// Gets a scenario to use when there are no DeepCloneWith... methods.
        /// </summary>
        public static DeepCloneWithTestScenario<T> NoDeepCloneWithMethodsScenario =>
            new DeepCloneWithTestScenario<T>
            {
                Name = "no DeepCloneWith... methods to test",
            };

        /// <summary>
        /// Gets a scenario to use when you need to force the consuming unit tests to pass and you intend to write your own unit tests.
        /// </summary>
        public static DeepCloneWithTestScenario<T> ForceGeneratedTestsToPassAndWriteMyOwnScenario =>
            new DeepCloneWithTestScenario<T>
            {
                Name = "force generated unit tests to pass, i'll write my own",
            };
    }
}
