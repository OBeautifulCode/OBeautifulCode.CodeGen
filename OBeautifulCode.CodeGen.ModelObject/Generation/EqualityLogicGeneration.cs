// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EqualityLogicGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to equality.
    /// </summary>
    internal static class EqualityLogicGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";
        private const string PropertyNameToken = "<<<PropertyNameHere>>>";
        private const string PropertyTypeNameToken = "<<<PropertyTypeNameHere>>>";
        private const string EqualityToken = "<<<EqualityLogicHere>>>";
        private const string NewObjectForEquatableToken = "<<<NewObjectLogicForEquatableHere>>>";
        private const string UnequalObjectsToken = "<<<UnequalObjectsCreationHere>>>";

        private const string EqualityMethodsForConcreteTypeCodeTemplate = @"    /// <summary>
        /// Determines whether two objects of type <see cref=""" + TypeNameToken + @"""/> are equal.
        /// </summary>
        /// <param name=""left"">The object to the left of the equality operator.</param>
        /// <param name=""right"">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(" + TypeNameToken + @" left, " + TypeNameToken + @" right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = " + EqualityToken + @";

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref=""" + TypeNameToken + @"""/> are not equal.
        /// </summary>
        /// <param name=""left"">The object to the left of the equality operator.</param>
        /// <param name=""right"">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(" + TypeNameToken + @" left, " + TypeNameToken + @" right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(" + TypeNameToken + @" other) => this == other;

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as " + TypeNameToken + @");";

        private const string EqualityMethodsForAbstractBaseTypeCodeTemplate = @"    /// <summary>
        /// Determines whether two objects of type <see cref=""" + TypeNameToken + @"""/> are equal.
        /// </summary>
        /// <param name=""left"">The object to the left of the equality operator.</param>
        /// <param name=""right"">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(" + TypeNameToken + @" left, " + TypeNameToken + @" right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals((object)right);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref=""" + TypeNameToken + @"""/> are not equal.
        /// </summary>
        /// <param name=""left"">The object to the left of the equality operator.</param>
        /// <param name=""right"">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(" + TypeNameToken + @" left, " + TypeNameToken + @" right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(" + TypeNameToken + @" other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);";

        private const string EqualityTestFieldsForAbstractBaseTypeCodeTemplate = @"    private static readonly " + TypeNameToken + @" ObjectForEquatableTests = A.Dummy<" + TypeNameToken + @">();

        private static readonly " + TypeNameToken + @" ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests = ObjectForEquatableTests.DeepClone();

        private static readonly " + TypeNameToken + @"[] ObjectsThatAreNotEqualToObjectForEquatableTests =
        {
            " + UnequalObjectsToken + @"
        };

        private static readonly string ObjectThatIsNotTheSameTypeAsObjectForEquatableTests = A.Dummy<string>();";

        private const string UnequalObjectTokenForAbstractBaseTypeCodeTemplate = @"ObjectForEquatableTests.DeepCloneWith" + PropertyNameToken + @"(A.Dummy<" + PropertyTypeNameToken + @">().ThatIsNot(ObjectForEquatableTests." + PropertyNameToken + @"))";

        private const string EqualityTestFieldsForConcreteTypeCodeTemplate = @"    private static readonly " + TypeNameToken + @" ObjectForEquatableTests = A.Dummy<" + TypeNameToken + @">();

        private static readonly " + TypeNameToken + @" ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests =
            " + NewObjectForEquatableToken + @";

        private static readonly " + TypeNameToken + @"[] ObjectsThatAreNotEqualToObjectForEquatableTests =
        {
            " + UnequalObjectsToken + @"
        };

        private static readonly string ObjectThatIsNotTheSameTypeAsObjectForEquatableTests = A.Dummy<string>();";

        private const string EqualityTestMethodsCodeTemplate = @"
        [SuppressMessage(""Microsoft.Design"", ""CA1034:NestedTypesShouldNotBeVisible"", Justification = ""Grouping construct for unit test runner."")]
        public static class Equality
        {
            [Fact]
            public static void EqualsOperator___Should_return_true___When_both_sides_of_operator_are_null()
            {
                // Arrange
                " + TypeNameToken + @" systemUnderTest1 = null;
                " + TypeNameToken + @" systemUnderTest2 = null;

                // Act
                var result = systemUnderTest1 == systemUnderTest2;

                // Assert
                result.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void EqualsOperator___Should_return_false___When_one_side_of_operator_is_null_and_the_other_side_is_not_null()
            {
                // Arrange
                " + TypeNameToken + @" systemUnderTest = null;

                // Act
                var result1 = systemUnderTest == ObjectForEquatableTests;
                var result2 = ObjectForEquatableTests == systemUnderTest;

                // Assert
                result1.AsTest().Must().BeFalse();
                result2.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void EqualsOperator___Should_return_true___When_same_object_is_on_both_sides_of_operator()
            {
                // Arrange, Act
    #pragma warning disable CS1718 // Comparison made to same variable
                var result = ObjectForEquatableTests == ObjectForEquatableTests;
    #pragma warning restore CS1718 // Comparison made to same variable

                // Assert
                result.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void EqualsOperator___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                // Arrange, Act
                var actualCheckReferenceAgainstUnequalSet = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => ObjectForEquatableTests == _).ToList();
                var actualCheckAgainstOthersInUnequalSet = ObjectsThatAreNotEqualToObjectForEquatableTests.GetCombinations(2, 2).Select( _=>_ .First() == _.Last()).ToList();

                // Assert
                actualCheckReferenceAgainstUnequalSet.AsTest().Must().Each().BeFalse();
                actualCheckAgainstOthersInUnequalSet.AsTest().Must().Each().BeFalse();
            }

            [Fact]
            public static void EqualsOperator___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                // Arrange, Act
                var result = ObjectForEquatableTests == ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests;

                // Assert
                result.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_both_sides_of_operator_are_null()
            {
                // Arrange
                " + TypeNameToken + @" systemUnderTest1 = null;
                " + TypeNameToken + @" systemUnderTest2 = null;

                // Act
                var result = systemUnderTest1 != systemUnderTest2;

                // Assert
                result.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_true___When_one_side_of_operator_is_null_and_the_other_side_is_not_null()
            {
                // Arrange
                " + TypeNameToken + @" systemUnderTest = null;

                // Act
                var result1 = systemUnderTest != ObjectForEquatableTests;
                var result2 = ObjectForEquatableTests != systemUnderTest;

                // Assert
                result1.AsTest().Must().BeTrue();
                result2.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_same_object_is_on_both_sides_of_operator()
            {
                // Arrange, Act
    #pragma warning disable CS1718 // Comparison made to same variable
                var result = ObjectForEquatableTests != ObjectForEquatableTests;
    #pragma warning restore CS1718 // Comparison made to same variable

                // Assert
                result.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_true___When_objects_being_compared_have_different_property_values()
            {
                // Arrange, Act
                var actualCheckReferenceAgainstUnequalSet = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => ObjectForEquatableTests != _).ToList();
                var actualCheckAgainstOthersInUnequalSet = ObjectsThatAreNotEqualToObjectForEquatableTests.GetCombinations(2, 2).Select( _=>_ .First() != _.Last()).ToList();

                // Assert
                actualCheckReferenceAgainstUnequalSet.AsTest().Must().Each().BeTrue();
                actualCheckAgainstOthersInUnequalSet.AsTest().Must().Each().BeTrue();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_objects_being_compared_have_same_property_values()
            {
                // Arrange, Act
                var result = ObjectForEquatableTests != ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests;

                // Assert
                result.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void Equals_with_" + TypeNameToken + @"___Should_return_false___When_parameter_other_is_null()
            {
                // Arrange
                " + TypeNameToken + @" systemUnderTest = null;

                // Act
                var result = ObjectForEquatableTests.Equals(systemUnderTest);

                // Assert
                result.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void Equals_with_" + TypeNameToken + @"___Should_return_true___When_parameter_other_is_same_object()
            {
                // Arrange, Act
                var result = ObjectForEquatableTests.Equals(ObjectForEquatableTests);

                // Assert
                result.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void Equals_with_" + TypeNameToken + @"___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                // Arrange, Act
                var actualCheckReferenceAgainstUnequalSet = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => ObjectForEquatableTests.Equals(_)).ToList();
                var actualCheckAgainstOthersInUnequalSet = ObjectsThatAreNotEqualToObjectForEquatableTests.GetCombinations(2, 2).Select( _=> _.First().Equals(_.Last())).ToList();

                // Assert
                actualCheckReferenceAgainstUnequalSet.AsTest().Must().Each().BeFalse();
                actualCheckAgainstOthersInUnequalSet.AsTest().Must().Each().BeFalse();
            }

            [Fact]
            public static void Equals_with_" + TypeNameToken + @"___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                // Arrange, Act
                var result = ObjectForEquatableTests.Equals(ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests);

                // Assert
                result.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_parameter_other_is_null()
            {
                // Arrange, Act
                var result = ObjectForEquatableTests.Equals(null);

                // Assert
                result.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_parameter_other_is_not_of_the_same_type()
            {
                // Arrange, Act
                var result = ObjectForEquatableTests.Equals((object)ObjectThatIsNotTheSameTypeAsObjectForEquatableTests);

                // Assert
                result.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void Equals_with_Object___Should_return_true___When_parameter_other_is_same_object()
            {
                // Arrange, Act
                var result = ObjectForEquatableTests.Equals((object)ObjectForEquatableTests);

                // Assert
                result.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                // Arrange, Act
                var actualCheckReferenceAgainstUnequalSet = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => ObjectForEquatableTests.Equals((object)_)).ToList();
                var actualCheckAgainstOthersInUnequalSet = ObjectsThatAreNotEqualToObjectForEquatableTests.GetCombinations(2, 2).Select( _=>_ .First().Equals((object)_.Last())).ToList();

                // Assert
                actualCheckReferenceAgainstUnequalSet.AsTest().Must().Each().BeFalse();
                actualCheckAgainstOthersInUnequalSet.AsTest().Must().Each().BeFalse();
            }

            [Fact]
            public static void Equals_with_Object___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                // Arrange, Act
                var result = ObjectForEquatableTests.Equals((object)ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests);

                // Assert
                result.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void GetHashCode___Should_not_be_equal_for_two_objects___When_objects_have_different_property_values()
            {
                // Arrange, Act
                var actualHashCodeOfReference = ObjectForEquatableTests.GetHashCode();
                var actualHashCodesInNotEqualSet = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => _.GetHashCode()).ToList();
                var actualEqualityCheckOfHashCodesAgainstOthersInNotEqualSet = ObjectsThatAreNotEqualToObjectForEquatableTests.GetCombinations(2, 2).Select(_ => _.First().GetHashCode() == _.Last().GetHashCode()).ToList();

                // Assert
                actualHashCodesInNotEqualSet.AsTest().Must().NotContainElement(actualHashCodeOfReference);
                actualEqualityCheckOfHashCodesAgainstOthersInNotEqualSet.AsTest().Must().Each().BeFalse();
            }

            [Fact]
            public static void GetHashCode___Should_be_equal_for_two_objects___When_objects_have_the_same_property_values()
            {
                // Arrange, Act
                var hash1 = ObjectForEquatableTests.GetHashCode();
                var hash2 = ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests.GetHashCode();

                // Assert
                hash1.AsTest().Must().BeEqualTo(hash2);
            }
        }";

        /// <summary>
        /// Generates equality methods.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// Generated equality methods.
        /// </returns>
        public static string GenerateEqualityMethods(
            this Type type)
        {
            string result;

            var hierarchyKind = type.GetHierarchyKind();

            if (hierarchyKind == HierarchyKind.AbstractBase)
            {
                result = EqualityMethodsForAbstractBaseTypeCodeTemplate.Replace(TypeNameToken, type.ToStringCompilable());
            }
            else
            {
                var properties = type.GetPropertiesOfConcernFromType();

                var equalityLines = properties.Select(_ => _.GenerateEqualityLogicCodeForProperty()).ToList();

                var equalityToken = string.Join(Environment.NewLine + "                      && ", equalityLines);

                result = EqualityMethodsForConcreteTypeCodeTemplate
                    .Replace(TypeNameToken, type.ToStringCompilable())
                    .Replace(EqualityToken, equalityToken);
            }

            return result;
        }

        /// <summary>
        /// Generates fields required to test equality.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// Generated fields required to test equality.
        /// </returns>
        public static string GenerateEqualityTestFields(
            this Type type)
        {
            var properties = type.GetPropertiesOfConcernFromType();

            var hierarchyKind = type.GetHierarchyKind();

            string codeTemplate;
            switch (hierarchyKind)
            {
                case HierarchyKind.AbstractBase:
                    codeTemplate = EqualityTestFieldsForAbstractBaseTypeCodeTemplate;
                    break;
                case HierarchyKind.None:
                case HierarchyKind.ConcreteInherited:
                    codeTemplate = EqualityTestFieldsForConcreteTypeCodeTemplate;
                    break;
                default:
                    throw new NotSupportedException("This kind is not supported: " + hierarchyKind);
            }

            var unequalSet = new List<string>();

            var result = codeTemplate
                .Replace(TypeNameToken, type.ToStringCompilable());

            if (hierarchyKind == HierarchyKind.AbstractBase)
            {
                foreach (var property in properties)
                {
                    var code = UnequalObjectTokenForAbstractBaseTypeCodeTemplate
                        .Replace(PropertyNameToken, property.Name)
                        .Replace(PropertyTypeNameToken, property.PropertyType.ToStringCompilable());

                    unequalSet.Add(code);
                }
            }
            else
            {
                foreach (var property in properties)
                {
                    var propertiesCode = properties.Select(_ =>
                    {
                        var referenceObject = "ObjectForEquatableTests." + _.Name;

                        var memberCode = _.Name != property.Name
                            ? referenceObject
                            : _.PropertyType.GenerateDummyConstructionCodeForType(referenceObject);

                        return new MemberCode(_.Name, memberCode);
                    }).ToList();

                    var code = type.GenerateModelInstantiation(propertiesCode, parameterPaddingLength: 20);

                    unequalSet.Add(code);
                }

                var newEquatablePropertiesCode = properties.Select(_ => new MemberCode(_.Name, "ObjectForEquatableTests." + _.Name)).ToList();

                var newObjectFromEquatableToken = type.GenerateModelInstantiation(newEquatablePropertiesCode, parameterPaddingLength: 20);

                result = result.Replace(NewObjectForEquatableToken, newObjectFromEquatableToken);
            }

            var unequalObjectsCode = string.Join("," + Environment.NewLine + "            ", unequalSet) + ",";

            result = result.Replace(UnequalObjectsToken, unequalObjectsCode);

            return result;
        }

        /// <summary>
        /// Generates test methods that test equality.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// Generated test methods that test equality.
        /// </returns>
        public static string GenerateEqualityTestMethods(
            this Type type)
        {
            var result = EqualityTestMethodsCodeTemplate.Replace(TypeNameToken, type.ToStringCompilable());

            return result;
        }

        private static string GenerateEqualityLogicCodeForProperty(
            this PropertyInfo propertyInfo)
        {
            propertyInfo.AsArg(nameof(propertyInfo)).Must().NotBeNull();

            var propertyType = propertyInfo.PropertyType;

            string result;
            if (propertyType == typeof(string))
            {
                result = Invariant($"left.{propertyInfo.Name}.Equals(right.{propertyInfo.Name}, StringComparison.Ordinal)");
            }
            else
            {
                var equatableType = typeof(IEquatable<>).MakeGenericType(propertyType);

                if (propertyType.IsAssignableTo(equatableType) || propertyType.IsEnum)
                {
                    result = Invariant($"left.{propertyInfo.Name}.Equals(right.{propertyInfo.Name})");
                }
                else
                {
                    result = Invariant($"left.{propertyInfo.Name}.IsEqualTo(right.{propertyInfo.Name})");
                }
            }

            return result;
        }
    }
}