// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToStringGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;
    using System.Reflection;

    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to string representation of model types.
    /// </summary>
    internal static class ToStringGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";
        private const string ToStringToken = "<<<ToStringConstructionHere>>>";
        private const string ToStringTestToken = "<<<ToStringConstructionForTestHere>>>";

        private const string ToStringMethodForConcreteTypeCodeTemplate = @"
        /// <inheritdoc />
        public override string ToString()
        {
            var result = " + ToStringToken + @";

            return result;
        }";

        private const string ToStringMethodForAbstractBaseTypeCodeTemplate = @"
        /// <inheritdoc />
        public abstract override string ToString();";

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
            actual.AsTest().Must().BeEqualTo(expected);
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
            string result;

            var hierarchyKind = type.GetHierarchyKind();

            if (hierarchyKind == HierarchyKind.AbstractBase)
            {
                result = ToStringMethodForAbstractBaseTypeCodeTemplate;
            }
            else
            {
                var toStringConstructionCode = type.GenerateToStringConstructionCode(useSystemUnderTest: false);

                result = ToStringMethodForConcreteTypeCodeTemplate.Replace(ToStringToken, toStringConstructionCode);
            }

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
            var hierarchyKind = type.GetHierarchyKind();

            string result = null;
            if (hierarchyKind != HierarchyKind.AbstractBase)
            {
                var toStringConstructionCode = type.GenerateToStringConstructionCode(useSystemUnderTest: true);

                result = ToStringTestMethodCodeTemplate
                    .Replace(TypeNameToken, type.ToStringCompilable())
                    .Replace(ToStringTestToken, toStringConstructionCode);
            }

            return result;
        }

        private static string GenerateToStringConstructionCode(
            this Type type,
            bool useSystemUnderTest)
        {
            var properties = type.GetPropertiesOfConcernFromType();

            var propertyToStrings = properties.Select(_ => _.GenerateToStringForProperty(useSystemUnderTest)).ToList();

            var result = Invariant($"Invariant($\"{{nameof({type.Namespace})}}.{{nameof({type.ToStringCompilable()})}}: {string.Join(", ", propertyToStrings)}.\")");

            return result;
        }

        private static string GenerateToStringForProperty(
            this PropertyInfo propertyInfo,
            bool useSystemUnderTest)
        {
            var name = propertyInfo.Name;
            var type = propertyInfo.PropertyType;

            var takesFormatProvider = type.GetMethods().Where(_ => _.Name == "ToString").Where(_ => !_.IsObsolete()).Where(_ => _.GetParameters().Length == 1).Any(_ => _.GetParameters().Single().ParameterType.IsAssignableTo(typeof(IFormatProvider)));

            var result = name + " = {" + (useSystemUnderTest ? "systemUnderTest" : "this") + "." + name + (type.IsAssignableToNull() ? "?" : string.Empty) + ".ToString(" + (takesFormatProvider ? "CultureInfo.InvariantCulture" : string.Empty) + ") ?? \"<null>\"}";

            return result;
        }

        private static bool IsObsolete(
            this MethodInfo methodInfo)
        {
            var result = methodInfo.GetCustomAttributes(false).OfType<ObsoleteAttribute>().Any();

            return result;
        }
    }
}