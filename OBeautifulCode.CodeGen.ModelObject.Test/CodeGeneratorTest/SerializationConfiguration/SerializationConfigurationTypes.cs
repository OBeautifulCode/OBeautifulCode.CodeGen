// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationConfigurationTypes.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    public static class SerializationConfigurationTypes
    {
        public static Type BsonConfigurationType => typeof(CodeGenModelObjectTestBsonConfiguration);

        public static Type JsonConfigurationType => typeof(CodeGenModelObjectTestJsonConfiguration);
    }
}
