// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenTestJsonConfiguration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.Test
{
    using System;
    using System.Collections.Generic;

    using Naos.Serialization.Json;

    /// <inheritdoc />
    public class CodeGenTestJsonConfiguration : JsonConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<Type> TypesToAutoRegister => new[]
        {
            typeof(InnerModel),
        };
    }
}
