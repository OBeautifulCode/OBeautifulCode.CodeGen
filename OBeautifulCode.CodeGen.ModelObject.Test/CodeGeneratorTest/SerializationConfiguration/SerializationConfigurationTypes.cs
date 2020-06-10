// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationConfigurationTypes.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Serialization.Bson;
    using OBeautifulCode.Serialization.Json;

    public static class SerializationConfigurationTypes
    {
        public static BsonSerializationConfigurationType BsonConfigurationType => typeof(CodeGenModelObjectTestBsonConfiguration).ToBsonSerializationConfigurationType();

        public static JsonSerializationConfigurationType JsonConfigurationType => typeof(CodeGenModelObjectTestJsonConfiguration).ToJsonSerializationConfigurationType();
    }
}
