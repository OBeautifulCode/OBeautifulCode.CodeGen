// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenModelObjectTestJsonConfiguration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Serialization.Json;

    /// <inheritdoc />
    public class CodeGenModelObjectTestJsonConfiguration : JsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForJson> TypesToRegisterForJson =>
            CodeGeneratorTestExtensions
                .GetModelTypes()
                .Select(_ => _.ToTypeToRegisterForJson())
                .ToList();
    }
}
