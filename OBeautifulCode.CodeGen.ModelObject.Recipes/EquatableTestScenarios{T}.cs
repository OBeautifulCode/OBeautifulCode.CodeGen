﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EquatableTestScenarios{T}.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.CodeGen.ModelObject.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Recipes
{
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Specifies various scenarios for equality tests.
    /// </summary>
    /// <typeparam name="T">The type of the object being tested.</typeparam>
#if !OBeautifulCodeCodeGenRecipesProject
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.CodeGen.ModelObject.Recipes", "See package version number")]
    internal
#else
    public
#endif
    class EquatableTestScenarios<T>
        where T : class
    {
        private readonly object lockObject = new object();

        private readonly List<EquatableTestScenario<T>> scenarios = new List<EquatableTestScenario<T>>();

        /// <summary>
        /// Gets the scenarios.
        /// </summary>
        public IReadOnlyList<EquatableTestScenario<T>> Scenarios
        {
            get
            {
                lock (this.lockObject)
                {
                    return this.scenarios.ToList();
                }
            }
        }

        /// <summary>
        /// Adds the specified scenarios to the list of scenarios.
        /// </summary>
        /// <param name="scenario">The scenario to add.</param>
        /// <returns>
        /// This object.
        /// </returns>
        public EquatableTestScenarios<T> AddScenario(
            EquatableTestScenario<T> scenario)
        {
            new { scenario }.AsTest().Must().NotBeNull();

            lock (this.lockObject)
            {
                new { this.Scenarios }.AsTest().Must().NotContainElement(scenario);

                this.scenarios.Add(scenario);
            }

            return this;
        }

        /// <summary>
        /// Removes all scenarios.
        /// </summary>
        public void RemoveAllScenarios()
        {
            lock (this.lockObject)
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
        public IReadOnlyList<ValidatedEquatableTestScenario<T>> ValidateAndPrepareForTesting()
        {
            lock (this.lockObject)
            {
                new { this.Scenarios }.AsTest().Must().NotBeEmptyEnumerable();

                var result = new List<ValidatedEquatableTestScenario<T>>();

                var scenariosCount = this.scenarios.Count;

                for (var x = 0; x < scenariosCount; x++)
                {
                    var scenario = this.scenarios[x];

                    var scenarioNumber = x + 1;

                    var scenarioName = string.IsNullOrWhiteSpace(scenario.Name) ? "<Unnamed Scenario>" : scenario.Name;

                    var scenarioId = Invariant($"{scenarioName} (equatable test scenario #{scenarioNumber} of {scenariosCount})");

                    new { scenario.ReferenceObject }.AsTest().Must().NotBeNull(scenarioId);

                    if (scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject != null)
                    {
                        new { scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject }.AsTest().Must().NotContainAnyNullElements(scenarioId);
                    }

                    if (scenario.ObjectsThatAreNotEqualToReferenceObject != null)
                    {
                        new { scenario.ObjectsThatAreNotEqualToReferenceObject }.AsTest().Must().NotContainAnyNullElements(scenarioId);
                    }

                    if (scenario.ObjectsThatAreNotOfTheSameTypeAsReferenceObject != null)
                    {
                        new { scenario.ObjectsThatAreNotOfTheSameTypeAsReferenceObject }.AsTest().Must().NotContainAnyNullElements(scenarioId);
                    }

                    var validatedScenario = new ValidatedEquatableTestScenario<T>(
                        scenarioId,
                        scenario.ReferenceObject,
                        scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject?.ToList() ?? new List<T>(),
                        scenario.ObjectsThatAreNotEqualToReferenceObject?.ToList() ?? new List<T>(),
                        scenario.ObjectsThatAreNotOfTheSameTypeAsReferenceObject?.ToList() ?? new List<object>());

                    result.Add(validatedScenario);
                }

                return result;
            }
        }
    }
}
