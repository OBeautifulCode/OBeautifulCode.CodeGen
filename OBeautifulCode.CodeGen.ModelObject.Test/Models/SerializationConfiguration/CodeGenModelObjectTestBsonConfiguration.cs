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
    public class CodeGenModelObjectTestBsonConfiguration : BsonConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<Type> TypesToAutoRegister =>
            typeof(CodeGeneratorTest)
                .Assembly
                .GetTypes()
                .Where(_ => _.Name.StartsWith(CodeGeneratorTest.ModelBaseName, StringComparison.Ordinal))
                .Where(_ => !_.Name.EndsWith(CodeGeneratorTest.TestNameSuffix, StringComparison.Ordinal))
                .ToList();
    }
}
