// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen
{
    using System;
    using System.Linq;

    using OBeautifulCode.Representation.System.Recipes;
    using OBeautifulCode.Validation.Recipes;

    /// <summary>
    /// Generates code related to serialization.
    /// </summary>
    internal static class SerializationGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";

        private const string SerializationConfigurationPrefixToken = "<<<SerializationConfigurationPrefixHere>>>";

        private const string SerializationFieldsCodeTemplate = @"private static readonly ISerializeAndDeserialize BsonSerializer = new NaosBsonSerializer<" + SerializationConfigurationPrefixToken + @"BsonConfiguration>();
        
        private static readonly ISerializeAndDeserialize JsonSerializer = new NaosJsonSerializer<" + SerializationConfigurationPrefixToken + @"JsonConfiguration>();";

        private const string SerializationTestMethodsCodeTemplate = @"
        [SuppressMessage(""Microsoft.Naming"", ""CA1724:TypeNamesShouldNotMatchNamespaces"", Justification = ""Name is correct."")]
        [SuppressMessage(""Microsoft.Design"", ""CA1034:NestedTypesShouldNotBeVisible"", Justification = ""Grouping construct for unit test runner."")]
        public static class Serialization
        {
            [Fact]
            public static void Deserialize___Should_roundtrip_object___When_serializing_and_deserializing_using_NaosJsonSerializer()
            {
                // Arrange
                var expected = A.Dummy<" + TypeNameToken + @">();

                var serializer = JsonSerializer;

                var serializedJson = serializer.SerializeToString(expected);

                // Act
                var actual = serializer.Deserialize<" + TypeNameToken + @">(serializedJson);

                // Assert
                actual.Should().Be(expected);
            }

            [Fact]
            public static void Deserialize___Should_roundtrip_object___When_serializing_and_deserializing_using_NaosBsonSerializer()
            {
                // Arrange
                var expected = A.Dummy<" + TypeNameToken + @">();

                var serializer = BsonSerializer;

                var serializedBson = serializer.SerializeToString(expected);

                // Act
                var actual = serializer.Deserialize<" + TypeNameToken + @">(serializedBson);

                // Assert
                actual.Should().Be(expected);
            }
        }";

        /// <summary>
        /// Generates fields required for serialization tests.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// Generated fields required for serialization tests.
        /// </returns>
        public static string GenerateSerializationTestFields(
            this Type type)
        {
            type.Named(nameof(type)).Must().NotBeNull();

            var namespaceTokens = type.Namespace?.Split('.');

            var prefix = namespaceTokens.Last() != "Test"
                ? namespaceTokens.Last()
                : namespaceTokens.Reverse().Skip(1).First() + "Test";

            var result = SerializationFieldsCodeTemplate
                        .Replace(TypeNameToken, type.ToStringCompilable())
                        .Replace(SerializationConfigurationPrefixToken, prefix);

            return result;
        }

        /// <summary>
        /// Generates test methods to test serialization.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// Generated test methods to test serialization.
        /// </returns>
        public static string GenerateSerializationTestMethods(
            this Type type)
        {
            type.Named(nameof(type)).Must().NotBeNull();
            var result = SerializationTestMethodsCodeTemplate.Replace(TypeNameToken, type.ToStringCompilable());
            return result;
        }
    }
}