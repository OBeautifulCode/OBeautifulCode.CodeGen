// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenModelObjectTestBsonConfiguration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;

    using Naos.Serialization.Bson;

    /// <inheritdoc />
    public class CodeGenModelObjectTestBsonConfiguration : BsonConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<Type> TypesToAutoRegister => new[]
        {
            typeof(MyModelParent),
        };
    }
}
