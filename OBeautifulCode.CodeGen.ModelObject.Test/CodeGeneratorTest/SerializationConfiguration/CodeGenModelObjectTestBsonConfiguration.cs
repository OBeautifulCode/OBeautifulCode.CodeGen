// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenModelObjectTestBsonConfiguration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Serialization.Bson;

    /// <inheritdoc />
    public class CodeGenModelObjectTestBsonConfiguration : BsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForBson> TypesToRegisterForBson =>
            typeof(CodeGeneratorTest)
                .Assembly
                .GetTypes()
                .Where(_ => _.Name.StartsWith(Settings.ModelBaseName, StringComparison.Ordinal))
                .Where(_ => !_.Name.EndsWith(Settings.TestNameSuffix, StringComparison.Ordinal))
                .Select(_ => _.ToTypeToRegisterForBson())
                .ToList();
    }
}
