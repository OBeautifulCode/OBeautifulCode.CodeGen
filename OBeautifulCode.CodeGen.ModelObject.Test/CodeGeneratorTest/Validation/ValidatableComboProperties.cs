// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidatableComboProperties.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    public partial class ValidatableComboProperties : IValidatableViaCodeGen, IDeclareGetSelfValidationFailuresMethod
    {
        public const string GoodStringValue = "good-string-value";

        public const string FailureMessage = "Properties don't have good string values";

        public string StringValue1 { get; set; }

        public string StringValue2 { get; set; }

        public IReadOnlyList<SelfValidationFailure> GetSelfValidationFailures()
        {
            var result = new List<SelfValidationFailure>();

            if ((this.StringValue1 != GoodStringValue) || (this.StringValue2 != GoodStringValue))
            {
                var failure = new SelfValidationFailure(new[] { nameof(this.StringValue1), nameof(this.StringValue2) }, FailureMessage);

                result.Add(failure);
            }

            return result;
        }
    }
}
