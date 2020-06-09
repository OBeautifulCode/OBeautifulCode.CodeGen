// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenModelObjectTestJsonConfiguration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Serialization.Json;

    /// <inheritdoc />
    public class CodeGenModelObjectTestJsonConfiguration : JsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForJson> TypesToRegisterForJson =>
            typeof(CodeGeneratorTest)
                .Assembly
                .GetTypes()
                .Where(_ => _.Name.StartsWith(Settings.ModelBaseName, StringComparison.Ordinal))
                .Where(_ => !_.Name.EndsWith(Settings.TestNameSuffix, StringComparison.Ordinal))
                .Select(_ => _.ToTypeToRegisterForJson())
                .ToList();
    }
}
