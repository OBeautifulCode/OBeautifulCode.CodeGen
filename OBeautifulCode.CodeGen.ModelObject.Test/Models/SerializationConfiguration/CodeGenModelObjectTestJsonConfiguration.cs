// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenModelObjectTestJsonConfiguration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Serialization.Json;

    /// <inheritdoc />
    public class CodeGenModelObjectTestJsonConfiguration : JsonConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<Type> TypesToAutoRegister => new Type[]
        {
            ////typeof(MyModelGettersOnly),
            ////typeof(MyModelGettersOnlyParent),

            typeof(MyModelPrivateSetters),
            typeof(MyModelPrivateSettersParent),

            typeof(MyModelPublicSetters),
            typeof(MyModelPublicSettersParent),
        };
    }
}
