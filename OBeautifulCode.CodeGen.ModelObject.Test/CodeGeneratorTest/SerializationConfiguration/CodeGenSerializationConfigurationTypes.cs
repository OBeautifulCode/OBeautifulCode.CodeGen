// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenSerializationConfigurationTypes.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    public static class CodeGenSerializationConfigurationTypes
    {
        public static Type BsonConfigurationType => typeof(CodeGenModelObjectTestBsonConfiguration);

        public static Type JsonConfigurationType => typeof(CodeGenModelObjectTestJsonConfiguration);
    }
}
