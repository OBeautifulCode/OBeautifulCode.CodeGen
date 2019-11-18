﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
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

        private const string SerializationFieldsCodeTemplate = @"    private static readonly ISerializeAndDeserialize BsonSerializer = new ObcBsonSerializer<" + SerializationConfigurationPrefixToken + @"BsonConfiguration>();
        
        private static readonly ISerializeAndDeserialize JsonSerializer = new ObcJsonSerializer<" + SerializationConfigurationPrefixToken + @"JsonConfiguration>();";

        private const string SerializationTestMethodsCodeTemplate = @"
        [SuppressMessage(""Microsoft.Naming"", ""CA1724:TypeNamesShouldNotMatchNamespaces"", Justification = ""Name is correct."")]
        [SuppressMessage(""Microsoft.Design"", ""CA1034:NestedTypesShouldNotBeVisible"", Justification = ""Grouping construct for unit test runner."")]
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
                actual.Should().Be(expected);
            }

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
            type.AsArg(nameof(type)).Must().NotBeNull();

            var prefix = type
                .Namespace?
                .Split('.')
                .Skip(1)
                .Where(_ => _ != "Serialization")
                .Where(_ => _ != "Bson")
                .Where(_ => _ != "Json")
                .ToDelimitedString(string.Empty);

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
            type.AsArg(nameof(type)).Must().NotBeNull();
            var result = SerializationTestMethodsCodeTemplate.Replace(TypeNameToken, type.ToStringCompilable());
            return result;
        }
    }
}