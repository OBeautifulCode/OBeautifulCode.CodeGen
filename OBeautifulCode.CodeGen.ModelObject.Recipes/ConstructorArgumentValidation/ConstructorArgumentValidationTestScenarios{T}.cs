﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstructorArgumentValidationTestScenarios{T}.cs" company="OBeautifulCode">
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

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Specifies various scenarios for constructor argument validation tests.
    /// </summary>
    /// <typeparam name="T">The type of the object being tested.</typeparam>
#if !OBeautifulCodeCodeGenRecipesProject
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.CodeGen.ModelObject.Recipes", "See package version number")]
    internal
#else
    public
#endif
    class ConstructorArgumentValidationTestScenarios<T>
        where T : class
    {
        private readonly object lockScenarios = new object();

        private readonly List<Lazy<ConstructorArgumentValidationTestScenario<T>>> scenarios = new List<Lazy<ConstructorArgumentValidationTestScenario<T>>>();

        /// <summary>
        /// Adds the specified scenarios to the list of scenarios.
        /// </summary>
        /// <param name="scenario">The scenario to add.</param>
        /// <returns>
        /// This object.
        /// </returns>
        public ConstructorArgumentValidationTestScenarios<T> AddScenario(
            ConstructorArgumentValidationTestScenario<T> scenario)
        {
            new { scenario }.AsTest().Must().NotBeNull();

            this.AddScenario(() => scenario);

            return this;
        }

        /// <summary>
        /// Adds the specified scenarios to the list of scenarios.
        /// </summary>
        /// <param name="scenarioFunc">A func that returns the scenario to add.</param>
        /// <returns>
        /// This object.
        /// </returns>
        public ConstructorArgumentValidationTestScenarios<T> AddScenario(
            Func<ConstructorArgumentValidationTestScenario<T>> scenarioFunc)
        {
            new { scenarioFunc }.AsTest().Must().NotBeNull();

            lock (this.lockScenarios)
            {
                // We are wrapping in a Lazy<> because the code-generated scenarios may
                // throw based on assertions within the model object's constructor.  We want
                // the end-user to have an opportunity to clear-out the scenarios and specify
                // their own (via static constructor on the test class) before the code-generated
                // ones are evaluated and throw.
                var lazyScenario = new Lazy<ConstructorArgumentValidationTestScenario<T>>(scenarioFunc);

                this.scenarios.Add(lazyScenario);
            }

            return this;
        }

        /// <summary>
        /// Removes all scenarios.
        /// </summary>
        public void RemoveAllScenarios()
        {
            lock (this.lockScenarios)
            {
                this.scenarios.Clear();
            }
        }

        /// <summary>
        /// Validates the scenarios and prepares them for testing.
        /// </summary>
        /// <returns>
        /// The validated/prepared scenarios.
        /// </returns>
        public IReadOnlyList<ValidatedConstructorArgumentValidationTestScenario<T>> ValidateAndPrepareForTesting()
        {
            lock (this.lockScenarios)
            {
                var typeCompilableString = typeof(T).ToStringCompilable();

                var becauseNoScenarios = new[]
                {
                    "Use a static constructor on your test class to add scenarios by calling ConstructorArgumentValidationTestScenarios.AddScenario(...).",
                    Invariant($"If the constructor cannot throw, clear all scenarios by calling ConstructorArgumentValidationTestScenarios.RemoveAllScenarios() and add ConstructorArgumentValidationTestScenario<{typeCompilableString}>.ConstructorCannotThrowScenario."),
                    Invariant($"If you need to force the consuming unit tests to pass and you'll write your own unit tests, clear all scenarios and then add ConstructorArgumentValidationTestScenario<{typeCompilableString}>.ForceGeneratedTestsToPassAndWriteMyOwnScenario."),
                };

                this.scenarios.AsTest("ConstructorArgumentValidationTestScenarios.Scenarios").Must().NotBeEmptyEnumerable(because: string.Join(Environment.NewLine, becauseNoScenarios), applyBecause: ApplyBecause.SuffixedToDefaultMessage);

                var result = new List<ValidatedConstructorArgumentValidationTestScenario<T>>();

                var scenariosCount = this.scenarios.Count;

                for (var x = 0; x < scenariosCount; x++)
                {
                    var scenario = this.scenarios[x].Value;

                    var scenarioNumber = x + 1;

                    var scenarioName = string.IsNullOrWhiteSpace(scenario.Name) ? "<Unnamed Scenario>" : scenario.Name;

                    var scenarioId = Invariant($"{scenarioName} (ConstructorArgumentValidation test scenario #{scenarioNumber} of {scenariosCount}):");

                    var validatedScenario = new ValidatedConstructorArgumentValidationTestScenario<T>(
                        scenarioId,
                        scenario.ConstructionFunc,
                        scenario.ExpectedExceptionType,
                        scenario.ExpectedExceptionMessageContains,
                        scenario.ExpectedExceptionMessageEquals);

                    result.Add(validatedScenario);
                }

                return result;
            }
        }
    }
}