﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidatedConstructorPropertyAssignmentTestScenario{T}.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.CodeGen.ModelObject.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Recipes
{
    using System;

    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Specifies a scenario for testing when a constructor sets a property values.
    /// </summary>
    /// <typeparam name="T">The type of the object being tested.</typeparam>
#if !OBeautifulCodeCodeGenRecipesProject
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.CodeGen.ModelObject.Recipes", "See package version number")]
    internal
#else
    public
#endif
    class ValidatedConstructorPropertyAssignmentTestScenario<T>
        where T : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatedConstructorPropertyAssignmentTestScenario{T}"/> class.
        /// </summary>
        /// <param name="id">The identifier of the scenario.</param>
        /// <param name="systemUnderTestExpectedPropertyValueFunc">A func that returns the object to test and the expected value of the property being tested.</param>
        /// <param name="propertyGetterFunc">A func that calls the getter of the property that is assigned a value by the constructor.</param>
        public ValidatedConstructorPropertyAssignmentTestScenario(
            string id,
            Func<SystemUnderTestExpectedPropertyValue<T>> systemUnderTestExpectedPropertyValueFunc,
            Func<T, object> propertyGetterFunc)
        {
            new { id }.AsTest().Must().NotBeNullNorWhiteSpace();
            new { systemUnderTestExpectedPropertyValueFunc }.AsTest().Must().NotBeNull(id);
            new { propertyGetterFunc }.AsTest().Must().NotBeNull(id);

            this.Id = id;
            this.SystemUnderTestExpectedPropertyValueFunc = systemUnderTestExpectedPropertyValueFunc;
            this.PropertyGetterFunc = propertyGetterFunc;
        }

        /// <summary>
        /// Gets the identifier of the scenario.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets a func that returns the object to test and the expected value of the property being tested.
        /// </summary>
        public Func<SystemUnderTestExpectedPropertyValue<T>> SystemUnderTestExpectedPropertyValueFunc { get; }

        /// <summary>
        /// Gets a func that calls the getter of the property that is assigned a value by the constructor.
        /// </summary>
        public Func<T, object> PropertyGetterFunc { get; }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = this.Id;

            return result;
        }
    }
}
