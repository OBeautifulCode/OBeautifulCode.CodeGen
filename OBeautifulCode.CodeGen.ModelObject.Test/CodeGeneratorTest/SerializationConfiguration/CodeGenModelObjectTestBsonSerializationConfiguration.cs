// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenModelObjectTestBsonSerializationConfiguration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Serialization.Bson;

    /// <inheritdoc />
    public class CodeGenModelObjectTestBsonSerializationConfiguration : BsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForBson> TypesToRegisterForBson =>
            CodeGeneratorTestExtensions
                .GetModelTypes()
                .Select(_ => _.ToTypeToRegisterForBson())
                .ToList();
    }
}
