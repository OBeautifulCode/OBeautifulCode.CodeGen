// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidatableNumeric.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class ValidatableNumeric : IValidatableViaCodeGen, IDeclareGetSelfValidationFailuresMethod
    {
        public int NumericValue { get; set; }

        public IReadOnlyList<SelfValidationFailure> GetSelfValidationFailures()
        {
            var result = new[]
            {
                new { this.NumericValue }.ForRecording().Must().BeGreaterThan(0),
            }.ToSelfValidationFailures();

            return result;
        }
    }
}
