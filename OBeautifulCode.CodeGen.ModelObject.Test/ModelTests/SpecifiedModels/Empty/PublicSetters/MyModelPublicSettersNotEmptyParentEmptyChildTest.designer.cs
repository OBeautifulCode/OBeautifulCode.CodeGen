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
    public static partial class MyModelPublicSettersNotEmptyParentEmptyChildTest
    {
        private static readonly ISerializeAndDeserialize BsonSerializer = new ObcBsonSerializer(CodeGenModelObjectTestSerializationConfigurationTypes.BsonConfigurationType);

        private static readonly ISerializeAndDeserialize JsonSerializer = new ObcJsonSerializer(CodeGenModelObjectTestSerializationConfigurationTypes.JsonConfigurationType);

        private static readonly MyModelPublicSettersNotEmptyParentEmptyChild ReferenceObjectForEquatableTestScenarios = A.Dummy<MyModelPublicSettersNotEmptyParentEmptyChild>();

        private static readonly EquatableTestScenarios<MyModelPublicSettersNotEmptyParentEmptyChild> EquatableTestScenarios = new EquatableTestScenarios<MyModelPublicSettersNotEmptyParentEmptyChild>()
            .AddScenario(
                new EquatableTestScenario<MyModelPublicSettersNotEmptyParentEmptyChild>
                {
                    Name = "Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new MyModelPublicSettersNotEmptyParentEmptyChild[]
                    {
                        new MyModelPublicSettersNotEmptyParentEmptyChild
                            {
                                ParentReadOnlyDictionaryOfStringString = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryOfStringString,
                            },
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new MyModelPublicSettersNotEmptyParentEmptyChild[]
                    {
                        new MyModelPublicSettersNotEmptyParentEmptyChild
                            {
                                ParentReadOnlyDictionaryOfStringString = A.Dummy<IReadOnlyDictionary<string, string>>().ThatIsNot(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryOfStringString),
                            },
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                    },
                });

        public static class Structural
        {
            [Fact]
            public static void MyModelPublicSettersNotEmptyParentEmptyChild___Should_implement_IModel_of_MyModelPublicSettersNotEmptyParentEmptyChild___When_reflecting()
            {
                // Arrange
                var type = typeof(MyModelPublicSettersNotEmptyParentEmptyChild);

                var expectedModelMethods = typeof(IModel<MyModelPublicSettersNotEmptyParentEmptyChild>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IModel<MyModelPublicSettersNotEmptyParentEmptyChild>));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
            }
        }

        public static class StringRepresentation
        {
            [Fact]
            public static void ToString___Should_generate_friendly_string_representation_of_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelPublicSettersNotEmptyParentEmptyChild>();

                var expected = Invariant($"{nameof(OBeautifulCode.CodeGen.ModelObject.Test)}.{nameof(MyModelPublicSettersNotEmptyParentEmptyChild)}: ParentReadOnlyDictionaryOfStringString = {systemUnderTest.ParentReadOnlyDictionaryOfStringString?.ToString() ?? "<null>"}.");

                // Act
                var actual = systemUnderTest.ToString();

                // Assert
                actual.AsTest().Must().BeEqualTo(expected);
            }
        }

        public static class Cloning
        {
            [Fact]
            public static void Clone___Should_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelPublicSettersNotEmptyParentEmptyChild>();

                // Act
                var actual = (MyModelPublicSettersNotEmptyParentEmptyChild)systemUnderTest.Clone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);
            }

            [Fact]
            public static void DeepClone___Should_deep_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelPublicSettersNotEmptyParentEmptyChild>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);
                actual.ParentReadOnlyDictionaryOfStringString.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryOfStringString);
            }

            [Fact]
            public static void DeepCloneWithParentReadOnlyDictionaryOfStringString___Should_deep_clone_object_and_replace_ParentReadOnlyDictionaryOfStringString_with_the_provided_parentReadOnlyDictionaryOfStringString___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelPublicSettersNotEmptyParentEmptyChild>();

                var referenceObject = A.Dummy<MyModelPublicSettersNotEmptyParentEmptyChild>().ThatIsNot(systemUnderTest);

                // Act
                var actual = (MyModelPublicSettersNotEmptyParentEmptyChild)systemUnderTest.DeepCloneWithParentReadOnlyDictionaryOfStringString(referenceObject.ParentReadOnlyDictionaryOfStringString);

                // Assert
                actual.ParentReadOnlyDictionaryOfStringString.AsTest().Must().BeSameReferenceAs(referenceObject.ParentReadOnlyDictionaryOfStringString);
            }
        }

        public static class Serialization
        {
            [Fact]
            public static void Deserialize___Should_roundtrip_object___When_serializing_and_deserializing_using_ObcBsonSerializer()
            {
                // Arrange
                var expected = A.Dummy<MyModelPublicSettersNotEmptyParentEmptyChild>();

                var serializer = BsonSerializer;

                var serializedBson = serializer.SerializeToString(expected);

                // Act
                var actual = serializer.Deserialize<MyModelPublicSettersNotEmptyParentEmptyChild>(serializedBson);

                // Assert
                actual.AsTest().Must().BeEqualTo(expected);
            }

            [Fact]
            public static void Deserialize___Should_roundtrip_object___When_serializing_and_deserializing_using_ObcJsonSerializer()
            {
                // Arrange
                var expected = A.Dummy<MyModelPublicSettersNotEmptyParentEmptyChild>();

                var serializer = JsonSerializer;

                var serializedJson = serializer.SerializeToString(expected);

                // Act
                var actual = serializer.Deserialize<MyModelPublicSettersNotEmptyParentEmptyChild>(serializedJson);

                // Assert
                actual.AsTest().Must().BeEqualTo(expected);
            }
        }

        public static class Equality
        {
            [Fact]
            public static void EqualsOperator___Should_return_true___When_both_sides_of_operator_are_null()
            {
                // Arrange
                MyModelPublicSettersNotEmptyParentEmptyChild systemUnderTest1 = null;
                MyModelPublicSettersNotEmptyParentEmptyChild systemUnderTest2 = null;

                // Act
                var actual = systemUnderTest1 == systemUnderTest2;

                // Assert
                actual.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void EqualsOperator___Should_return_false___When_one_side_of_operator_is_null_and_the_other_side_is_not_null()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange
                    MyModelPublicSettersNotEmptyParentEmptyChild systemUnderTest = null;

                    // Act
                    var actual1 = systemUnderTest == scenario.ReferenceObject;
                    var actual2 = scenario.ReferenceObject == systemUnderTest;

                    // Assert
                    actual1.AsTest().Must().BeFalse(because: scenario.Id);
                    actual2.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void EqualsOperator___Should_return_true___When_same_object_is_on_both_sides_of_operator()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    #pragma warning disable CS1718 // Comparison made to same variable
                    var actual = scenario.ReferenceObject == scenario.ReferenceObject;
                    #pragma warning restore CS1718 // Comparison made to same variable

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void EqualsOperator___Should_return_false___When_objects_being_compared_derive_from_the_same_type_but_are_not_of_the_same_type()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => scenario.ReferenceObject == _).ToList();
                    var actuals2 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => _ == scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void EqualsOperator___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => scenario.ReferenceObject == _).ToList();
                    var actuals2 = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => _ == scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void EqualsOperator___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject == _).ToList();
                    var actuals2 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => _ == scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_both_sides_of_operator_are_null()
            {
                // Arrange
                MyModelPublicSettersNotEmptyParentEmptyChild systemUnderTest1 = null;
                MyModelPublicSettersNotEmptyParentEmptyChild systemUnderTest2 = null;

                // Act
                var actual = systemUnderTest1 != systemUnderTest2;

                // Assert
                actual.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_true___When_one_side_of_operator_is_null_and_the_other_side_is_not_null()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange
                    MyModelPublicSettersNotEmptyParentEmptyChild systemUnderTest = null;

                    // Act
                    var actual1 = systemUnderTest != scenario.ReferenceObject;
                    var actual2 = scenario.ReferenceObject != systemUnderTest;

                    // Assert
                    actual1.AsTest().Must().BeTrue(because: scenario.Id);
                    actual2.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_same_object_is_on_both_sides_of_operator()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    #pragma warning disable CS1718 // Comparison made to same variable
                    var actual = scenario.ReferenceObject != scenario.ReferenceObject;
                    #pragma warning restore CS1718 // Comparison made to same variable

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_true___When_objects_being_compared_derive_from_the_same_type_but_are_not_of_the_same_type()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => scenario.ReferenceObject != _).ToList();
                    var actuals2 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => _ != scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_true___When_objects_being_compared_have_different_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => scenario.ReferenceObject != _).ToList();
                    var actuals2 = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => _ != scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_objects_being_compared_have_same_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject != _).ToList();
                    var actuals2 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => _ != scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_MyModelPublicSettersNotEmptyParent___Should_return_false___When_parameter_other_is_null()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange
                    MyModelPublicSettersNotEmptyParent systemUnderTest = null;

                    // Act
                    var actual = scenario.ReferenceObject.Equals((MyModelPublicSettersNotEmptyParent)systemUnderTest);

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_MyModelPublicSettersNotEmptyParent___Should_return_true___When_parameter_other_is_same_object()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject.Equals((MyModelPublicSettersNotEmptyParent)scenario.ReferenceObject);

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_MyModelPublicSettersNotEmptyParent___Should_return_false___When_parameter_other_is_derived_from_the_same_type_but_is_not_of_the_same_type_as_this_object()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals((MyModelPublicSettersNotEmptyParent)_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_MyModelPublicSettersNotEmptyParent___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => scenario.ReferenceObject.Equals((MyModelPublicSettersNotEmptyParent)_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_MyModelPublicSettersNotEmptyParent___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals((MyModelPublicSettersNotEmptyParent)_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_MyModelPublicSettersNotEmptyParentEmptyChild___Should_return_false___When_parameter_other_is_null()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange
                    MyModelPublicSettersNotEmptyParentEmptyChild systemUnderTest = null;

                    // Act
                    var actual = scenario.ReferenceObject.Equals(systemUnderTest);

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_MyModelPublicSettersNotEmptyParentEmptyChild___Should_return_true___When_parameter_other_is_same_object()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject.Equals(scenario.ReferenceObject);

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_MyModelPublicSettersNotEmptyParentEmptyChild___Should_return_false___When_parameter_other_is_derived_from_the_same_type_but_is_not_of_the_same_type_as_this_object()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals(_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_MyModelPublicSettersNotEmptyParentEmptyChild___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => scenario.ReferenceObject.Equals(_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_MyModelPublicSettersNotEmptyParentEmptyChild___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals(_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_parameter_other_is_null()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject.Equals((object)null);

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_parameter_other_is_not_of_the_same_type()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals((object)_)).ToList();
                    var actuals2 = scenario.ObjectsThatAreNotOfTheSameTypeAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals((object)_)).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_Object___Should_return_true___When_parameter_other_is_same_object()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject.Equals((object)scenario.ReferenceObject);

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => scenario.ReferenceObject.Equals((object)_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_Object___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals((object)_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }
        }

        public static class Hashing
        {
            [Fact]
            public static void GetHashCode___Should_not_be_equal_for_two_objects___When_objects_have_different_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var unexpected = scenario.ReferenceObject.GetHashCode();

                    var actuals = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => _.GetHashCode()).ToList();

                    // Assert
                    actuals.AsTest().Must().NotContainElement(unexpected, because: scenario.Id);
                }
            }

            [Fact]
            public static void GetHashCode___Should_be_equal_for_two_objects___When_objects_have_the_same_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var expected = scenario.ReferenceObject.GetHashCode();

                    var actuals = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => _.GetHashCode()).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeEqualTo(expected, because: scenario.Id);
                }
            }
        }
    }
}