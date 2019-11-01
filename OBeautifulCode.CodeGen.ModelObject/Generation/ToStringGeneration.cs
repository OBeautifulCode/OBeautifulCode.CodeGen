// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToStringGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;

    using OBeautifulCode.Type.Recipes;

    /// <summary>
    /// Generates code related to string representation of model types.
    /// </summary>
    internal static class ToStringGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";
        private const string ToStringToken = "<<<ToStringConstructionHere>>>";
        private const string ToStringTestToken = "<<<ToStringConstructionForTestHere>>>";

        private const string ToStringMethodCodeTemplate = @"
        /// <inheritdoc />
        public override string ToString()
        {
            var result = " + ToStringToken + @";

            return result;
        }";

        private const string ToStringTestMethodCodeTemplate = @"
        [Fact]
        public static void ToString___Should_generate_friendly_string_representation_of_object___When_called()
        {
            // Arrange
            var systemUnderTest = A.Dummy<" + TypeNameToken + @">();

            var expected = " + ToStringTestToken + @";

            // Act
            var actual = systemUnderTest.ToString();

            // Assert
            actual.Should().Be(expected);
        }";

        /// <summary>
        /// Generates the <see cref="object.ToString"/> method override.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// Generated <see cref="object.ToString"/> method override.
        /// </returns>
        public static string GenerateToStringMethod(
            this Type type)
        {
            var toStringConstructionCode = type.GenerateToStringConstructionCode();
            var result = ToStringMethodCodeTemplate.Replace(ToStringToken, toStringConstructionCode);
            return result;
        }

        /// <summary>
        /// Generates test methods that test the <see cref="object.ToString"/> method override.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// Generated test methods that test the <see cref="object.ToString"/> method override.
        /// </returns>
        public static string GenerateToStringTestMethod(
            this Type type)
        {
            var toStringConstructionCode = type.GenerateToStringTestConstructionCode();
            var result = ToStringTestMethodCodeTemplate
                        .Replace(TypeNameToken, type.ToStringCompilable())
                        .Replace(ToStringTestToken, toStringConstructionCode);
            return result;
        }

        private static string GenerateToStringConstructionCode(
            this Type type)
        {
            var propertyNames = type.GetPropertiesOfConcernFromType().ToDictionary(_ => _.Name, _ => _);
            var result = "Invariant($\"{nameof("
                       + type.Namespace
                       + ")}.{nameof("
                       + type.ToStringCompilable()
                       + ")}: "
                       + string.Join(
                             ", ",
                             propertyNames.Select(
                                 _ =>
                                 {
                                     var localResult = _.Key
                                                     + " = {this."
                                                     + _.Key
                                                     + (!_.Value.PropertyType.IsValueType || _.Value.PropertyType == typeof(string)
                                                           ? "?"
                                                           : string.Empty)
                                                     + ".ToString("
                                                     + (_.Value.PropertyType == typeof(int) || _.Value.PropertyType == typeof(bool)
                                                           ? "CultureInfo.InvariantCulture"
                                                           : string.Empty)
                                                     + ") ?? \"<null>\"}";

                                     return localResult;
                                 }))
                       + ".\")";

            return result;
        }

        private static string GenerateToStringTestConstructionCode(
            this Type type)
        {
            var propertyNames = type.GetPropertiesOfConcernFromType().Select(_ => _.Name).ToList();
            var result = "Invariant($\""
                       + type.Namespace?.Split('.').Last()
                       + "."
                       + type.ToStringCompilable()
                       + ": "
                       + string.Join(
                             ", ",
                             propertyNames.Select(_ => _ + " = {systemUnderTest." + _ + "}"))
                       + ".\")";

            return result;
        }
    }
}