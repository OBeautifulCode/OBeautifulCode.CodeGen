// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidatableObject.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class ValidatableObject : IValidatableViaCodeGen, IDeclareGetSelfValidationFailuresMethod
    {
        public ValidatableNumeric ValidatableNumber1 { get; set; }

        public ValidatableString ValidatableText1 { get; set; }

        public ValidatableNumeric ValidatableNumber2 { get; set; }

        public ValidatableString ValidatableText2 { get; set; }

        public IReadOnlyCollection<ValidatableNumeric> ValidatableNumbers1 { get; set; }

        public IReadOnlyCollection<ValidatableString> ValidatableTexts1 { get; set; }

        public IReadOnlyCollection<ValidatableNumeric> ValidatableNumbers2 { get; set; }

        public IReadOnlyCollection<ValidatableString> ValidatableTexts2 { get; set; }

        public IReadOnlyList<SelfValidationFailure> GetSelfValidationFailures()
        {
            var result = new[]
            {
                new { this.ValidatableNumber1 }.ForRecording().Must().NotBeNull(),
                new { this.ValidatableText1 }.ForRecording().Must().NotBeNull(),
                new { this.ValidatableNumber2 }.ForRecording().Must().NotBeNull(),
                new { this.ValidatableText2 }.ForRecording().Must().NotBeNull(),
                new { this.ValidatableNumbers1 }.ForRecording().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls(),
                new { this.ValidatableTexts1 }.ForRecording().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls(),
                new { this.ValidatableNumbers2 }.ForRecording().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls(),
                new { this.ValidatableTexts2 }.ForRecording().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls(),
            }.ToSelfValidationFailures();

            return result;
        }
    }
}
