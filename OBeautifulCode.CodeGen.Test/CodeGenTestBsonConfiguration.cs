// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenTestBsonConfiguration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.Test
{
    using System;
    using System.Collections.Generic;

    using Naos.Serialization.Bson;

    /// <inheritdoc />
    public class CodeGenTestBsonConfiguration : BsonConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<Type> TypesToAutoRegister => new[]
        {
            typeof(InnerModel),
        };
    }
}
