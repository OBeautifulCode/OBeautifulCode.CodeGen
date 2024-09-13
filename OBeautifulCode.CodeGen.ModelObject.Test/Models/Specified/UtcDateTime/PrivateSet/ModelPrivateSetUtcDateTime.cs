// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetUtcDateTime.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class ModelPrivateSetUtcDateTime : IModelViaCodeGen
    {
        public ModelPrivateSetUtcDateTime(
            DateTime item1,
            DateTime? item2,
            DateTime item3Utc,
            DateTime? item4Utc,
            IReadOnlyCollection<DateTime> item5Utc,
            IReadOnlyCollection<DateTime?> item6Utc,
            IReadOnlyCollection<DateTime> item7,
            IReadOnlyCollection<DateTime?> item8)
        {
            // Note that the non-UTC date times are included here in case we want to
            // add default(DateTime) or 0 ticks checks (see notes in ConstructingGeneration.cs).
            new { item3Utc }.AsArg().Must().BeUtcDateTime();
            new { item4Utc }.AsArg().Must().BeUtcDateTimeWhenNotNull();
            new { item5Utc }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { item6Utc }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { item7 }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { item8 }.AsArg().Must().NotBeNullNorEmptyEnumerable();

            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3Utc = item3Utc;
            this.Item4Utc = item4Utc;
            this.Item5Utc = item5Utc;
            this.Item6Utc = item6Utc;
            this.Item7 = item7;
            this.Item8 = item8;
        }

        public DateTime Item1 { get; private set; }

        public DateTime? Item2 { get; private set; }

        public DateTime Item3Utc { get; private set; }

        public DateTime? Item4Utc { get; private set; }

        public IReadOnlyCollection<DateTime> Item5Utc { get; private set; }

        public IReadOnlyCollection<DateTime?> Item6Utc { get; private set; }

        public IReadOnlyCollection<DateTime> Item7 { get; private set; }

        public IReadOnlyCollection<DateTime?> Item8 { get; private set; }
    }
}
