// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Type.Recipes;

    /// <summary>
    /// Generates code related to serialization.
    /// </summary>
    internal static class SerializationGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";

        private const string SerializationConfigurationPrefixToken = "<<<SerializationConfigurationPrefixHere>>>";

        private const string JsonOnlySerializationFieldsCodeTemplate = @"    private static readonly ISerializeAndDeserialize JsonSerializer = new ObcJsonSerializer(" + SerializationConfigurationPrefixToken + @"SerializationConfigurationTypes.JsonConfigurationType);";

        private const string BsonAndJsonSerializationFieldsCodeTemplate = @"    private static readonly ISerializeAndDeserialize BsonSerializer = new ObcBsonSerializer(" + SerializationConfigurationPrefixToken + @"SerializationConfigurationTypes.BsonConfigurationType);
        
        private static readonly ISerializeAndDeserialize JsonSerializer = new ObcJsonSerializer(" + SerializationConfigurationPrefixToken + @"SerializationConfigurationTypes.JsonConfigurationType);";

        private const string JsonOnlySerializationTestMethodsCodeTemplate = @"
        public static class Serialization
        {
            [Fact]
            public static void Deserialize___Should_roundtrip_object___When_serializing_and_deserializing_using_ObcJsonSerializer()
            {
                // Arrange
                var expected = A.Dummy<" + TypeNameToken + @">();

                var serializer = JsonSerializer;

                var serializedJson = serializer.SerializeToString(expected);

                // Act
                var actual = serializer.Deserialize<" + TypeNameToken + @">(serializedJson);

                // Assert
                actual.AsTest().Must().BeEqualTo(expected);
            }
        }";

        private const string BsonAndJsonSerializationTestMethodsCodeTemplate = @"
        public static class Serialization
        {
            [Fact]
            public static void Deserialize___Should_roundtrip_object___When_serializing_and_deserializing_using_ObcBsonSerializer()
            {
                // Arrange
                var expected = A.Dummy<" + TypeNameToken + @">();

                var serializer = BsonSerializer;

                var serializedBson = serializer.SerializeToString(expected);

                // Act
                var actual = serializer.Deserialize<" + TypeNameToken + @">(serializedBson);

                // Assert
                actual.AsTest().Must().BeEqualTo(expected);
            }

            [Fact]
            public static void Deserialize___Should_roundtrip_object___When_serializing_and_deserializing_using_ObcJsonSerializer()
            {
                // Arrange
                var expected = A.Dummy<" + TypeNameToken + @">();

                var serializer = JsonSerializer;

                var serializedJson = serializer.SerializeToString(expected);

                // Act
                var actual = serializer.Deserialize<" + TypeNameToken + @">(serializedJson);

                // Assert
                actual.AsTest().Must().BeEqualTo(expected);
            }
        }";

        /// <summary>
        /// Generates fields required for serialization tests.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated fields required for serialization tests.
        /// </returns>
        public static string GenerateSerializationTestFields(
            this ModelType modelType)
        {
            modelType.AsArg(nameof(modelType)).Must().NotBeNull();

            var prefix = modelType
                .Type
                .Namespace?
                .Split('.')
                .Skip(1)
                .Where(_ => _ != "Serialization")
                .Where(_ => _ != "Bson")
                .Where(_ => _ != "Json")
                .ToDelimitedString(string.Empty);

            var serializationFieldsCodeTemplate = modelType.HasAnyGetterOnlyProperties()
                ? JsonOnlySerializationFieldsCodeTemplate
                : BsonAndJsonSerializationFieldsCodeTemplate;

            var result = serializationFieldsCodeTemplate
                        .Replace(TypeNameToken, modelType.Type.ToStringCompilable())
                        .Replace(SerializationConfigurationPrefixToken, prefix);

            return result;
        }

        /// <summary>
        /// Generates test methods to test serialization.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods to test serialization.
        /// </returns>
        public static string GenerateSerializationTestMethods(
            this ModelType modelType)
        {
            modelType.AsArg(nameof(modelType)).Must().NotBeNull();

            var serializationTestMethodsCodeTemplate = modelType.HasAnyGetterOnlyProperties()
                ? JsonOnlySerializationTestMethodsCodeTemplate
                : BsonAndJsonSerializationTestMethodsCodeTemplate;

            var result = serializationTestMethodsCodeTemplate.Replace(TypeNameToken, modelType.Type.ToStringCompilable());

            return result;
        }

        private static bool HasAnyGetterOnlyProperties(
            this ModelType modelType)
        {
            var result = modelType.PropertiesOfConcern.Any(_ => _.GetSetMethod(true) == null);

            return result;
        }
    }
}