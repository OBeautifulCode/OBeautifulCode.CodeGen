// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenModelObjectTestBsonConfiguration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Serialization.Bson;

    /// <inheritdoc />
    public class CodeGenModelObjectTestBsonConfiguration : BsonConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<Type> TypesToAutoRegister => new[]
        {
            typeof(MyModelGettersOnly),
            typeof(MyModelGettersOnlyParent),

            typeof(MyModelPrivateSetters),
            typeof(MyModelPrivateSettersParent),

            typeof(MyModelPublicSetters),
            typeof(MyModelPublicSettersParent),
        };
    }
}
