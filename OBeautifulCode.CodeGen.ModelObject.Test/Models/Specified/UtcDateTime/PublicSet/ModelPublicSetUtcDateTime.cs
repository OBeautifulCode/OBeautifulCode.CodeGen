// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPublicSetUtcDateTime.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using OBeautifulCode.Type;

    public partial class ModelPublicSetUtcDateTime : IModelViaCodeGen
    {
        public DateTime Item1 { get; set; }

        public DateTime? Item2 { get; set; }

        public DateTime Item3Utc { get; set; }

        public DateTime? Item4Utc { get; set; }

        public IReadOnlyCollection<DateTime> Item5Utc { get; set; }

        public IReadOnlyCollection<DateTime?> Item6Utc { get; set; }

        public IReadOnlyCollection<DateTime> Item7 { get; set; }

        public IReadOnlyCollection<DateTime?> Item8 { get; set; }
    }
}