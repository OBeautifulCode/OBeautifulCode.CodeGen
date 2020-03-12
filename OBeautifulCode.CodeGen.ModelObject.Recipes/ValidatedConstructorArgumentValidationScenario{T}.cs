﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidatedConstructorArgumentValidationTestScenario{T}.cs" company="OBeautifulCode">
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
    class ValidatedConstructorArgumentValidationTestScenario<T>
        where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">The identifier of the scenario.</param>
        /// <param name="constructionFunc">A func that constructs the object</param>
        /// <param name="expectedExceptionType">The Type of the expected <see cref="Exception"/> that is thrown when the object is constructed.</param>
        /// <param name="expectedExceptionMessageContains">A set strings that should each be contained within the expected <see cref="Exception.Message"/>.</param>
        /// <param name="expectedExceptionMessageEquals">The expected <see cref="Exception.Message"/>.</param>
        public ValidatedConstructorArgumentValidationTestScenario(
            string id,
            Func<T> constructionFunc,
            Type expectedExceptionType,
            IReadOnlyCollection<string> expectedExceptionMessageContains,
            string expectedExceptionMessageEquals)
        {
            new { id }.AsTest().Must().NotBeNullNorWhiteSpace();
            new { constructionFunc }.AsTest().Must().NotBeNull(id);
            expectedExceptionType.IsAssignableTo(typeof(Exception)).AsTest(Invariant($"{nameof(expectedExceptionType)}.{nameof(TypeExtensions.IsAssignableTo)}(typeof({nameof(Exception)}))")).Must().BeTrue();
            
            if (expectedExceptionMessageContains != null)
            {
                new { expectedExceptionMessageContains }.AsTest().Must().NotBeEmptyEnumerable(id).And().Each().NotBeNullNorWhiteSpace(id);
            }
            else
            {
                new { expectedExceptionMessageEquals }.AsTest().Must().NotBeNullNorWhiteSpace(id);
            }

            this.Id = id;
            this.ConstructionFunc = constructionFunc;
            this.ExpectedExceptionType = expectedExceptionType;
            this.ExpectedExceptionMessageContains = expectedExceptionMessageContains;
            this.ExpectedExceptionMessageEquals = expectedExceptionMessageEquals;
        }

        /// <summary>
        /// Gets the identifier of the scenario.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets a func that constructs the object.
        /// </summary>
        public Func<T> ConstructionFunc { get; }

        /// <summary>
        /// Gets the Type of the expected <see cref="Exception"/> that is thrown when the object is constructed.
        /// </summary>
        public Type ExpectedExceptionType { get; }

        /// <summary>
        /// Gets a set strings that should each be contained within the expected <see cref="Exception.Message"/>.
        /// </summary>
        public IReadOnlyCollection<string> ExpectedExceptionMessageContains { get; }

        /// <summary>
        /// Gets the expected <see cref="Exception.Message"/>.
        /// </summary>
        public string ExpectedExceptionMessageEquals { get; }
    }
}
