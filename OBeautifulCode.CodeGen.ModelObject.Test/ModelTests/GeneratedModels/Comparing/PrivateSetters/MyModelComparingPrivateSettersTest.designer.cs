// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    using FakeItEasy;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Math.Recipes;
    using OBeautifulCode.Representation.System;
    using OBeautifulCode.Serialization;
    using OBeautifulCode.Serialization.Bson;
    using OBeautifulCode.Serialization.Json;
    using OBeautifulCode.Type;

    using Xunit;

    using static System.FormattableString;

    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.0.0")]
    public static partial class MyModelComparingPrivateSettersTest
    {
        private static readonly ComparableTestScenarios<MyModelComparingPrivateSetters> ComparableTestScenarios = new ComparableTestScenarios<MyModelComparingPrivateSetters>();

        public static class Structural
        {
            [Fact]
            public static void MyModelComparingPrivateSetters___Should_implement_IComparableForRelativeSortOrder_of_MyModelComparingPrivateSetters___When_reflecting()
            {
                // Arrange
                var type = typeof(MyModelComparingPrivateSetters);

                var expectedModelMethods = typeof(IComparableForRelativeSortOrder<MyModelComparingPrivateSetters>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IComparableForRelativeSortOrder<MyModelComparingPrivateSetters>));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
            }
        }

        public static class Comparability
        {
            [Fact]
            public static void LessThanOperator___Should_return_false___When_both_sides_of_operator_are_null()
            {
                // Arrange
                MyModelComparingPrivateSetters systemUnderTest1 = null;
                MyModelComparingPrivateSetters systemUnderTest2 = null;

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
                    var actuals1 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => _ < scenario.ReferenceObject);
                    var actuals2 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject < _ );

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
                    var actuals1 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => _ < scenario.ReferenceObject);
                    var actuals2 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => scenario.ReferenceObject < _ );

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
                    var actuals1 = scenario.ObjectsThatAreGreaterThanReferenceObject.Select(_ => _ < scenario.ReferenceObject);
                    var actuals2 = scenario.ObjectsThatAreLessThanReferenceObject.Select(_ => scenario.ReferenceObject < _ );

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
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => _ < scenario.ReferenceObject));
                    var actuals2 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => Record.Exception(() => scenario.ReferenceObject < _ ));

                    // Assert
                    actuals1.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals1.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($"Attempting to compare objects of different types."));

                    actuals2.AsTest().Must().Each().BeOfType<ArgumentException>(because: scenario.Id);
                    actuals2.Select(_ => _.Message).AsTest().Must().Each().StartWith(Invariant($"Attempting to compare objects of different types."));
                }
            }
        }
    }
}