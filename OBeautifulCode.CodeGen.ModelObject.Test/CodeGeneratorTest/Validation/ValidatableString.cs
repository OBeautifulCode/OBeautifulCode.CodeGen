// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidatableString.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class ValidatableString : IValidatableViaCodeGen, IDeclareGetSelfValidationFailuresMethod
    {
        public const string GoodStringValue = "good-string-value";

        public string StringValue { get; set; }

        public IReadOnlyList<SelfValidationFailure> GetSelfValidationFailures()
        {
            var result = new[]
                {
                    new { this.StringValue }.ForRecording().Must().BeEqualTo(GoodStringValue),
                }
                .ToSelfValidationFailures();

            return result;
        }
    }
}
