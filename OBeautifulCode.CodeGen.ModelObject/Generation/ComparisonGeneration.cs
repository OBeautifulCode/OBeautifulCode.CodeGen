// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComparisonGeneration.cs" company="OBeautifulCode">
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
    /// Generates code related to comparisons.
    /// </summary>
    internal static class ComparisonGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";
        private const string BaseTypeNameToken = "<<<BaseTypeNameHere>>>";
        private const string OverrideModifierToken = "<<<OverrideModifierHere>>>";

        private const string ComparableTestFieldsForDeclaredTypeCodeTemplate = @"    private static readonly ComparableTestScenarios<" + TypeNameToken + @"> ComparableTestScenarios = new ComparableTestScenarios<" + TypeNameToken + @">();";

        private const string ComparableOperatorsAndMethodsCodeTemplate = @"    /// <summary>
        /// Determines whether an object of type <see cref=""" + TypeNameToken + @"""/> is less than another object of that type.
        /// </summary>
        /// <param name=""left"">The object to the left of the less-than operator.</param>
        /// <param name=""right"">The object to the right of the less-than operator.</param>
        /// <returns>true if <paramref name=""left""/> is less than <paramref name=""right""/>; otherwise false.</returns>
        public static bool operator <(" + TypeNameToken + @" left, " + TypeNameToken + @" right)
        {
            if (ReferenceEquals(left, right))
            {
                return false;
            }

            if (ReferenceEquals(left, null))
            {
                return true;
            }

            if (ReferenceEquals(right, null))
            {
                return false;
            }

            if (left.GetType() != right.GetType())
            {
                throw new ArgumentException(Invariant($""" + TypeMismatchOperatorArgumentExceptionMessage + @"""));
            }

            var relativeSortOrder = left.CompareToForRelativeSortOrder(right);

            var result = relativeSortOrder == RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;

            return result;
        }

        /// <summary>
        /// Determines whether an object of type <see cref=""" + TypeNameToken + @"""/> is greater than another object of that type.
        /// </summary>
        /// <param name=""left"">The object to the left of the greater-than operator.</param>
        /// <param name=""right"">The object to the right of the greater-than operator.</param>
        /// <returns>true if <paramref name=""left""/> is greater than <paramref name=""right""/>; otherwise false.</returns>
        public static bool operator >(" + TypeNameToken + @" left, " + TypeNameToken + @" right)
        {
            if (ReferenceEquals(left, right))
            {
                return false;
            }

            if (ReferenceEquals(left, null))
            {
                return false;
            }

            if (ReferenceEquals(right, null))
            {
                return true;
            }

            if (left.GetType() != right.GetType())
            {
                throw new ArgumentException(Invariant($""" + TypeMismatchOperatorArgumentExceptionMessage + @"""));
            }

            var relativeSortOrder = left.CompareToForRelativeSortOrder(right);

            var result = relativeSortOrder == RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;

            return result;
        }

        /// <summary>
        /// Determines whether an object of type <see cref=""" + TypeNameToken + @"""/> is less than or equal to another object of that type.
        /// </summary>
        /// <param name=""left"">The object to the left of the less-than-or-equal-to operator.</param>
        /// <param name=""right"">The object to the right of the less-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name=""left""/> is less than or equal to <paramref name=""right""/>; otherwise false.</returns>
        public static bool operator <=(" + TypeNameToken + @" left, " + TypeNameToken + @" right) => !(left > right);

        /// <summary>
        /// Determines whether an object of type <see cref=""" + TypeNameToken + @"""/> is greater than or equal to another object of that type.
        /// </summary>
        /// <param name=""left"">The object to the left of the greater-than-or-equal-to operator.</param>
        /// <param name=""right"">The object to the right of the greater-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name=""left""/> is greater than or equal to <paramref name=""right""/>; otherwise false.</returns>
        public static bool operator >=(" + TypeNameToken + @" left, " + TypeNameToken + @" right) => !(left < right);

        /// <inheritdoc />
        public int CompareTo(" + TypeNameToken + @" other)
        {
            if (ReferenceEquals(other, null))
            {
                return 1;
            }

            var relativeSortOrder = this.CompareToForRelativeSortOrder(other);

            switch(relativeSortOrder)
            {
                case RelativeSortOrder.ThisInstancePrecedesTheOtherInstance:
                    return -1;
                case RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance:
                    return 0;
                case RelativeSortOrder.ThisInstanceFollowsTheOtherInstance:
                    return 1;
                default:
                    throw new NotSupportedException(Invariant($""This {nameof(RelativeSortOrder)} is not supported: {relativeSortOrder}.""));
            }
        }";

        private const string ComparableMethodsForConcreteTypeCodeTemplate = @"        
        /// <inheritdoc />
        public " + OverrideModifierToken + @"int CompareTo(object obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return 1;
            }

            if (!(obj is " + TypeNameToken + @" other))
            {
                throw new ArgumentException(Invariant($""" + TypeMismatchInstanceMethodArgumentExceptionMessage + @" '{obj.GetType().ToStringReadable()}'.""));
            }

            var result = this.CompareTo(other);

            return result;
        }";

        private const string ComparableMethodsForInheritedTypeCodeTemplate = @"
        public override RelativeSortOrder CompareToForRelativeSortOrder(" + BaseTypeNameToken + @" other)
        {
            if (ReferenceEquals(other, null))
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            if (!(other is " + TypeNameToken + @" otherAs" + TypeNameToken + @"))
            {
                throw new ArgumentException(Invariant($""" + TypeMismatchInstanceMethodArgumentExceptionMessage + @" '{other.GetType().ToStringReadable()}'.""));
            }

            var result = this.CompareToForRelativeSortOrder(otherAs" + TypeNameToken + @");

            return result;
        }";

        private const string TypeMismatchArgumentExceptionMessagePrefixTemplate = @"Attempting to compare objects of different types.";

        private const string TypeMismatchInstanceMethodArgumentExceptionMessage = TypeMismatchArgumentExceptionMessagePrefixTemplate + @"  This object is of type '{nameof(" + TypeNameToken + @")}' whereas the other object is of type";

        private const string TypeMismatchOperatorArgumentExceptionMessage = TypeMismatchArgumentExceptionMessagePrefixTemplate + @"  The left operand is of type '{left.GetType().ToStringReadable()}' whereas the right operand is of type '{right.GetType().ToStringReadable()}'.";

        private const string ComparableMethodsForAbstractTypeCodeTemplate = @"    
        /// <inheritdoc />
        public abstract int CompareTo(object obj);

        /// <inheritdoc />
        public abstract RelativeSortOrder CompareToForRelativeSortOrder(" + TypeNameToken + @" other);";

        private const string ComparableTestMethodsCodeTemplate = @"    public static class Comparability
        {
            [Fact]
            public static void LessThanOperator___Should_return_false___When_both_sides_of_operator_are_null()
            {
                // Arrange
                " + TypeNameToken + @" systemUnderTest1 = null;
                " + TypeNameToken + @" systemUnderTest2 = null;

                // Act
                var actual = systemUnderTest1 < systemUnderTest2;

                // Assert
                actual.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void LessThanOperator___Should_return_true___When_parameter_left_is_null_and_parameter_right_is_not_null()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = null < scenario.ReferenceObject;

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void LessThanOperator___Should_return_false___When_parameter_right_is_null_and_parameter_left_is_not_null()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject < null;

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void LessThanOperator___Should_return_false___When_same_object_is_on_both_sides_of_operator()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    #pragma warning disable CS1718 // Comparison made to same variable
                    var actual = scenario.ReferenceObject < scenario.ReferenceObject;
                    #pragma warning restore CS1718 // Comparison made to same variable

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void LessThanOperator___Should_return_false___When_parameter_left_and_right_are_equal_but_not_the_same_object()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => _ < scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject < _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void LessThanOperator___Should_return_true___When_parameter_left_is_less_than_parameter_right()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => _ < scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => scenario.ReferenceObject < _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }
            
            [Fact]
            public static void LessThanOperator___Should_return_false___When_parameter_left_is_greater_than_parameter_right()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => _ < scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => scenario.ReferenceObject < _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void LessThanOperator___Should_throw_ArgumentException___When_objects_being_compared_are_of_different_types()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => _ < scenario.ReferenceObject)).ToList();
                    var actuals2 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => scenario.ReferenceObject < _ )).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals1.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));

                    actuals2.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals2.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));
                }
            }

            [Fact]
            public static void GreaterThanOperator___Should_return_false___When_both_sides_of_operator_are_null()
            {
                // Arrange
                " + TypeNameToken + @" systemUnderTest1 = null;
                " + TypeNameToken + @" systemUnderTest2 = null;

                // Act
                var actual = systemUnderTest1 > systemUnderTest2;

                // Assert
                actual.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void GreaterThanOperator___Should_return_false___When_parameter_left_is_null_and_parameter_right_is_not_null()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = null > scenario.ReferenceObject;

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void GreaterThanOperator___Should_return_true___When_parameter_right_is_null_and_parameter_left_is_not_null()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject > null;

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void GreaterThanOperator___Should_return_false___When_same_object_is_on_both_sides_of_operator()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    #pragma warning disable CS1718 // Comparison made to same variable
                    var actual = scenario.ReferenceObject > scenario.ReferenceObject;
                    #pragma warning restore CS1718 // Comparison made to same variable

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void GreaterThanOperator___Should_return_false___When_parameter_left_and_right_are_equal_but_not_the_same_object()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => _ > scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject > _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void GreaterThanOperator___Should_return_false___When_parameter_left_is_less_than_parameter_right()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => _ > scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => scenario.ReferenceObject > _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }
            
            [Fact]
            public static void GreaterThanOperator___Should_return_true___When_parameter_left_is_greater_than_parameter_right()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => _ > scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => scenario.ReferenceObject > _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void GreaterThanOperator___Should_throw_ArgumentException___When_objects_being_compared_are_of_different_types()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => _ > scenario.ReferenceObject)).ToList();
                    var actuals2 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => scenario.ReferenceObject > _ )).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals1.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));

                    actuals2.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals2.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));
                }
            }

            [Fact]
            public static void LessThanOrEqualToOperator___Should_return_true___When_both_sides_of_operator_are_null()
            {
                // Arrange
                " + TypeNameToken + @" systemUnderTest1 = null;
                " + TypeNameToken + @" systemUnderTest2 = null;

                // Act
                var actual = systemUnderTest1 <= systemUnderTest2;

                // Assert
                actual.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void LessThanOrEqualToOperator___Should_return_true___When_parameter_left_is_null_and_parameter_right_is_not_null()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = null <= scenario.ReferenceObject;

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void LessThanOrEqualToOperator___Should_return_false___When_parameter_right_is_null_and_parameter_left_is_not_null()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject <= null;

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void LessThanOrEqualToOperator___Should_return_true___When_same_object_is_on_both_sides_of_operator()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    #pragma warning disable CS1718 // Comparison made to same variable
                    var actual = scenario.ReferenceObject <= scenario.ReferenceObject;
                    #pragma warning restore CS1718 // Comparison made to same variable

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void LessThanOrEqualToOperator___Should_return_true___When_parameter_left_and_right_are_equal_but_not_the_same_object()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => _ <= scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject <= _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void LessThanOrEqualToOperator___Should_return_true___When_parameter_left_is_less_than_parameter_right()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => _ <= scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => scenario.ReferenceObject <= _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }
            
            [Fact]
            public static void LessThanOrEqualToOperator___Should_return_false___When_parameter_left_is_greater_than_parameter_right()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => _ <= scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => scenario.ReferenceObject <= _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void LessThanOrEqualToOperator___Should_throw_ArgumentException___When_objects_being_compared_are_of_different_types()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => _ <= scenario.ReferenceObject)).ToList();
                    var actuals2 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => scenario.ReferenceObject <= _ )).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals1.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));

                    actuals2.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals2.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));
                }
            }

            [Fact]
            public static void GreaterThanOrEqualToOperator___Should_return_true___When_both_sides_of_operator_are_null()
            {
                // Arrange
                " + TypeNameToken + @" systemUnderTest1 = null;
                " + TypeNameToken + @" systemUnderTest2 = null;

                // Act
                var actual = systemUnderTest1 >= systemUnderTest2;

                // Assert
                actual.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void GreaterThanOrEqualToOperator___Should_return_false___When_parameter_left_is_null_and_parameter_right_is_not_null()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = null >= scenario.ReferenceObject;

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void GreaterThanOrEqualToOperator___Should_return_true___When_parameter_right_is_null_and_parameter_left_is_not_null()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject >= null;

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void GreaterThanOrEqualToOperator___Should_return_true___When_same_object_is_on_both_sides_of_operator()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    #pragma warning disable CS1718 // Comparison made to same variable
                    var actual = scenario.ReferenceObject >= scenario.ReferenceObject;
                    #pragma warning restore CS1718 // Comparison made to same variable

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void GreaterThanOrEqualToOperator___Should_return_true___When_parameter_left_and_right_are_equal_but_not_the_same_object()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => _ >= scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject >= _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void GreaterThanOrEqualToOperator___Should_return_false___When_parameter_left_is_less_than_parameter_right()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => _ >= scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => scenario.ReferenceObject >= _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }
            
            [Fact]
            public static void GreaterThanOrEqualToOperator___Should_return_true___When_parameter_left_is_greater_than_parameter_right()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => _ >= scenario.ReferenceObject).ToList();
                    var actuals2 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => scenario.ReferenceObject >= _ ).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void GreaterThanOrEqualToOperator___Should_throw_ArgumentException___When_objects_being_compared_are_of_different_types()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => _ >= scenario.ReferenceObject)).ToList();
                    var actuals2 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => scenario.ReferenceObject >= _ )).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals1.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));

                    actuals2.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals2.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));
                }
            }

            [Fact]
            public static void CompareTo_with_" + TypeNameToken + @"___Should_return_1___When_parameter_other_is_null()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange
                    " + TypeNameToken + @" other = null;

                    // Act
                    var actual = scenario.ReferenceObject.CompareTo(other);

                    // Assert
                    actual.AsTest().Must().BeEqualTo(1, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareTo_with_" + TypeNameToken + @"___Should_return_0___When_parameter_other_is_same_object()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject.CompareTo(scenario.ReferenceObject);

                    // Assert
                    actual.AsTest().Must().BeEqualTo(0, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareTo_with_" + TypeNameToken + @"___Should_return_0___When_objects_being_compared_are_equal()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject.CompareTo(_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeEqualTo(0, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareTo_with_" + TypeNameToken + @"___Should_return_negative_1___When_object_is_less_than_parameter_other()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => _.CompareTo(scenario.ReferenceObject)).ToList();
                    var actuals2 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => scenario.ReferenceObject.CompareTo(_)).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeEqualTo(-1, because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeEqualTo(-1, because: scenario.Id);
                }
            }
            
            [Fact]
            public static void CompareTo_with_" + TypeNameToken + @"___Should_return_1___When_object_is_greater_than_parameter_other()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => _.CompareTo(scenario.ReferenceObject)).ToList();
                    var actuals2 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => scenario.ReferenceObject.CompareTo(_)).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeEqualTo(1, because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeEqualTo(1, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareTo_with_" + TypeNameToken + @"___Should_throw_ArgumentException___When_objects_being_compared_are_of_different_types()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => scenario.ReferenceObject.CompareTo(_))).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));
                }
            }

            [Fact]
            public static void CompareTo_with_Object___Should_return_1___When_parameter_obj_is_null()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject.CompareTo((object)null);

                    // Assert
                    actual.AsTest().Must().BeEqualTo(1, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareTo_with_Object___Should_return_0___When_parameter_obj_is_same_object()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject.CompareTo((object)scenario.ReferenceObject);

                    // Assert
                    actual.AsTest().Must().BeEqualTo(0, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareTo_with_Object___Should_return_0___When_objects_being_compared_are_equal()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject.CompareTo((object)_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeEqualTo(0, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareTo_with_Object___Should_return_negative_1___When_object_is_less_than_parameter_obj()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => _.CompareTo((object)scenario.ReferenceObject)).ToList();
                    var actuals2 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => scenario.ReferenceObject.CompareTo((object)_)).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeEqualTo(-1, because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeEqualTo(-1, because: scenario.Id);
                }
            }
            
            [Fact]
            public static void CompareTo_with_Object___Should_return_1___When_object_is_greater_than_parameter_obj()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => _.CompareTo((object)scenario.ReferenceObject)).ToList();
                    var actuals2 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => scenario.ReferenceObject.CompareTo((object)_)).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeEqualTo(1, because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeEqualTo(1, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareTo_with_Object___Should_throw_ArgumentException___When_objects_being_compared_are_of_different_types()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => scenario.ReferenceObject.CompareTo((object)_))).ToList();
                    var actuals2 = scenario.ObjectsThatAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => scenario.ReferenceObject.CompareTo((object)_))).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals1.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));

                    actuals2.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals2.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));
                }
            }

            [Fact]
            public static void CompareToForRelativeSortOrder_with_" + TypeNameToken + @"___Should_return_RelativeSortOrder_ThisInstanceFollowsTheOtherInstance___When_parameter_other_is_null()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange
                    " + TypeNameToken + @" other = null;

                    // Act
                    var actual = scenario.ReferenceObject.CompareToForRelativeSortOrder(other);

                    // Assert
                    actual.AsTest().Must().BeEqualTo(RelativeSortOrder.ThisInstanceFollowsTheOtherInstance, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareToForRelativeSortOrder_with_" + TypeNameToken + @"___Should_return_RelativeSortOrder_ThisInstanceOccursInTheSamePositionAsTheOtherInstance___When_parameter_other_is_same_object()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject.CompareToForRelativeSortOrder(scenario.ReferenceObject);

                    // Assert
                    actual.AsTest().Must().BeEqualTo(RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareToForRelativeSortOrder_with_" + TypeNameToken + @"___Should_return_RelativeSortOrder_ThisInstanceOccursInTheSamePositionAsTheOtherInstance___When_objects_being_compared_are_equal()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject.CompareToForRelativeSortOrder(_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeEqualTo(RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareToForRelativeSortOrder_with_" + TypeNameToken + @"___Should_return_RelativeSortOrder_ThisInstancePrecedesTheOtherInstance___When_object_is_less_than_parameter_other()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => _.CompareToForRelativeSortOrder(scenario.ReferenceObject)).ToList();
                    var actuals2 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => scenario.ReferenceObject.CompareToForRelativeSortOrder(_)).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeEqualTo(RelativeSortOrder.ThisInstancePrecedesTheOtherInstance, because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeEqualTo(RelativeSortOrder.ThisInstancePrecedesTheOtherInstance, because: scenario.Id);
                }
            }
            
            [Fact]
            public static void CompareToForRelativeSortOrder_with_" + TypeNameToken + @"___Should_return_RelativeSortOrder_ThisInstanceFollowsTheOtherInstance___When_object_is_greater_than_parameter_other()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => _.CompareToForRelativeSortOrder(scenario.ReferenceObject)).ToList();
                    var actuals2 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => scenario.ReferenceObject.CompareToForRelativeSortOrder(_)).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeEqualTo(RelativeSortOrder.ThisInstanceFollowsTheOtherInstance, because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeEqualTo(RelativeSortOrder.ThisInstanceFollowsTheOtherInstance, because: scenario.Id);
                }
            }

            [Fact]
            public static void CompareToForRelativeSortOrder_with_" + TypeNameToken + @"___Should_throw_ArgumentException___When_objects_being_compared_are_of_different_types()
            {
                var scenarios = ComparableTestScenarios.ValidateAndPrepareForTesting();

                foreach(var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => scenario.ReferenceObject.CompareToForRelativeSortOrder(_))).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($""" + TypeMismatchArgumentExceptionMessagePrefixTemplate + @"""));
                }
            }
        }";

        /// <summary>
        /// Generates fields required to test comparability.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated fields required to test comparability.
        /// </returns>
        public static string GenerateComparableTestFields(
            this ModelType modelType)
        {
            var result = ComparableTestFieldsForDeclaredTypeCodeTemplate
                .Replace(TypeNameToken, modelType.TypeCompilableString);

            return result;
        }

        /// <summary>
        /// Generates comparable methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated comparable methods.
        /// </returns>
        public static string GenerateComparableMethods(
            this ModelType modelType)
        {
            string codeTemplate;

            string overrideModifier = null;

            if (modelType.HierarchyKind == HierarchyKind.AbstractBase)
            {
                if (modelType.DeclaresCompareToMethod)
                {
                    throw new NotSupportedException(Invariant($"Abstract type {modelType.TypeReadableString} cannot declare CompareTo method."));
                }

                codeTemplate = ComparableOperatorsAndMethodsCodeTemplate + Environment.NewLine + ComparableMethodsForAbstractTypeCodeTemplate;
            }
            else
            {
                if (!modelType.DeclaresCompareToMethod)
                {
                    throw new NotSupportedException(Invariant($"Type {modelType.TypeReadableString} must declare CompareTo method."));
                }

                codeTemplate = ComparableOperatorsAndMethodsCodeTemplate + Environment.NewLine + ComparableMethodsForConcreteTypeCodeTemplate;

                if (modelType.HierarchyKind == HierarchyKind.ConcreteInherited)
                {
                    overrideModifier = "override ";

                    codeTemplate = codeTemplate + Environment.NewLine + ComparableMethodsForInheritedTypeCodeTemplate;
                }
            }

            var result = codeTemplate
                .Replace(TypeNameToken, modelType.TypeCompilableString)
                .Replace(BaseTypeNameToken, modelType.BaseTypeCompilableString)
                .Replace(OverrideModifierToken, overrideModifier);

            return result;
        }

        /// <summary>
        /// Generates test methods that test comparability.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test comparability.
        /// </returns>
        public static string GenerateComparabilityTestMethods(
            this ModelType modelType)
        {
            var result = ComparableTestMethodsCodeTemplate
                .Replace(TypeNameToken, modelType.TypeCompilableString);

            return result;
        }
    }
}