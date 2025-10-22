// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPublicSetUtcDateTime.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class ModelPublicSetUtcDateTime : IModelViaCodeGen, IDeclareGetSelfValidationFailuresMethod
    {
        public DateTime Item1 { get; set; }

        public DateTime? Item2 { get; set; }

        public DateTime Item3Utc { get; set; }

        public DateTime? Item4Utc { get; set; }

        public IReadOnlyCollection<DateTime> Item5Utc { get; set; }

        public IReadOnlyCollection<DateTime?> Item6Utc { get; set; }

        public IReadOnlyCollection<DateTime> Item7 { get; set; }

        public IReadOnlyCollection<DateTime?> Item8 { get; set; }

        /// <inheritdoc />
        public IReadOnlyList<SelfValidationFailure> GetSelfValidationFailures()
        {
            var result = new[]
                {
                    new { this.Item3Utc }.ForRecording().Must().BeUtcDateTime(),
                    new { this.Item4Utc }.ForRecording().Must().BeUtcDateTimeWhenNotNull(),
                    new { this.Item5Utc }.ForRecording().Must().NotBeNullNorEmptyEnumerable(),
                    new { this.Item6Utc }.ForRecording().Must().NotBeNullNorEmptyEnumerable(),
                    new { this.Item7 }.ForRecording().Must().NotBeNullNorEmptyEnumerable(),
                    new { this.Item8 }.ForRecording().Must().NotBeNullNorEmptyEnumerable(),
                }
                .ToSelfValidationFailures();

            return result;
        }
    }
}