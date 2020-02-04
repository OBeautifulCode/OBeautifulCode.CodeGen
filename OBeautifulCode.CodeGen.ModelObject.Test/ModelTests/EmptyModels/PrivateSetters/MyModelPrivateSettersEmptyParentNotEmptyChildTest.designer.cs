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
    public static partial class MyModelPrivateSettersEmptyParentNotEmptyChildTest
    {
        private static readonly ISerializeAndDeserialize BsonSerializer = new ObcBsonSerializer(CodeGenModelObjectTestSerializationConfigurationTypes.BsonConfigurationType);
        
        private static readonly ISerializeAndDeserialize JsonSerializer = new ObcJsonSerializer(CodeGenModelObjectTestSerializationConfigurationTypes.JsonConfigurationType);

        private static readonly MyModelPrivateSettersEmptyParentNotEmptyChild ObjectForEquatableTests = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

        private static readonly IReadOnlyCollection<MyModelPrivateSettersEmptyParentNotEmptyChild> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new MyModelPrivateSettersEmptyParentNotEmptyChild[]
        {
            new MyModelPrivateSettersEmptyParentNotEmptyChild(
                    ObjectForEquatableTests.ChildReadOnlyDictionaryOfStringString),
        };

        private static readonly IReadOnlyCollection<MyModelPrivateSettersEmptyParentNotEmptyChild> ObjectsThatAreNotEqualToObjectForEquatableTests = new MyModelPrivateSettersEmptyParentNotEmptyChild[]
        {
            new MyModelPrivateSettersEmptyParentNotEmptyChild(
                    A.Dummy<IReadOnlyDictionary<string, string>>().ThatIsNot(ObjectForEquatableTests.ChildReadOnlyDictionaryOfStringString)),
        };

        private static readonly IReadOnlyCollection<object> ObjectsThatAreNotTheSameTypeAsObjectForEquatableTests = new object[]
        {
            A.Dummy<string>(),
        };

        public static class Structural
        {
            [Fact]
            public static void MyModelPrivateSettersEmptyParentNotEmptyChild___Should_implement_IModel_of_MyModelPrivateSettersEmptyParentNotEmptyChild___When_reflecting()
            {
                // Arrange
                var type = typeof(MyModelPrivateSettersEmptyParentNotEmptyChild);

                var expectedModelMethods = typeof(IModel<MyModelPrivateSettersEmptyParentNotEmptyChild>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IModel<MyModelPrivateSettersEmptyParentNotEmptyChild>));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
            }
        }

        public static class StringRepresentation
        {
            [Fact]
            public static void ToString___Should_generate_friendly_string_representation_of_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

                var expected = Invariant($"{nameof(OBeautifulCode.CodeGen.ModelObject.Test)}.{nameof(MyModelPrivateSettersEmptyParentNotEmptyChild)}: ChildReadOnlyDictionaryOfStringString = {systemUnderTest.ChildReadOnlyDictionaryOfStringString?.ToString() ?? "<null>"}.");

                // Act
                var actual = systemUnderTest.ToString();

                // Assert
                actual.AsTest().Must().BeEqualTo(expected);
            }
        }

        public static class Constructing
        {
            [Fact]
            public static void Constructor___Should_throw_ArgumentNullException___When_parameter_childReadOnlyDictionaryOfStringString_is_null()
            {
                // Arrange
                var referenceObject = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

                // Act
                var actual = Record.Exception(
                    () => new MyModelPrivateSettersEmptyParentNotEmptyChild(
                                  null));

                // Assert
                actual.AsTest().Must().BeOfType<ArgumentNullException>();
                actual.Message.AsTest().Must().ContainString("childReadOnlyDictionaryOfStringString");
            }

            [Fact]
            public static void Constructor___Should_throw_ArgumentException___When_parameter_childReadOnlyDictionaryOfStringString_is_empty()
            {
                // Arrange
                var referenceObject = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

                // Act
                var actual = Record.Exception(
                    () => new MyModelPrivateSettersEmptyParentNotEmptyChild(
                                  new Dictionary<string, string>()));

                // Assert
                actual.AsTest().Must().BeOfType<ArgumentException>();
                actual.Message.AsTest().Must().ContainString("childReadOnlyDictionaryOfStringString");
                actual.Message.AsTest().Must().ContainString("is an empty dictionary");
            }

            [Fact]
            public static void Constructor___Should_throw_ArgumentException___When_parameter_childReadOnlyDictionaryOfStringString_contains_a_null_value()
            {
                // Arrange
                var referenceObject = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

                var dictionaryWithNullValue = referenceObject.ChildReadOnlyDictionaryOfStringString.ToDictionary(_ => _.Key, _ => _.Value);
                var randomKey = dictionaryWithNullValue.Keys.ElementAt(ThreadSafeRandom.Next(0, dictionaryWithNullValue.Count));
                dictionaryWithNullValue[randomKey] = null;

                // Act
                var actual = Record.Exception(
                    () => new MyModelPrivateSettersEmptyParentNotEmptyChild(
                                  dictionaryWithNullValue));

                // Assert
                actual.AsTest().Must().BeOfType<ArgumentException>();
                actual.Message.AsTest().Must().ContainString("childReadOnlyDictionaryOfStringString");
                actual.Message.AsTest().Must().ContainString("contains at least one key-value pair with a null value");
            }

            [Fact]
            public static void ChildReadOnlyDictionaryOfStringString___Should_return_same_childReadOnlyDictionaryOfStringString_parameter_passed_to_constructor___When_getting()
            {
                // Arrange
                var referenceObject = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

                var systemUnderTest = new MyModelPrivateSettersEmptyParentNotEmptyChild(
                                              referenceObject.ChildReadOnlyDictionaryOfStringString);

                var expected = referenceObject.ChildReadOnlyDictionaryOfStringString;
                
                // Act
                var actual = systemUnderTest.ChildReadOnlyDictionaryOfStringString;

                // Assert
                actual.AsTest().Must().BeSameReferenceAs(expected);
            }
        }

        public static class Cloning
        {
            [Fact]
            public static void Clone___Should_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

                // Act
                var actual = (MyModelPrivateSettersEmptyParentNotEmptyChild)systemUnderTest.Clone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);
            }

            [Fact]
            public static void DeepClone_override___Should_deep_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

                // Act
                var actual = (MyModelPrivateSettersEmptyParentNotEmptyChild)systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);
                actual.ChildReadOnlyDictionaryOfStringString.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ChildReadOnlyDictionaryOfStringString);
            }

            [Fact]
            public static void DeepClone_explicit_interface___Should_deep_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

                // Act
                var actual = ((IDeepCloneable<MyModelPrivateSettersEmptyParentNotEmptyChild>)systemUnderTest).DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);
                actual.ChildReadOnlyDictionaryOfStringString.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ChildReadOnlyDictionaryOfStringString);
            }

            [Fact]
            public static void DeepCloneWithChildReadOnlyDictionaryOfStringString___Should_deep_clone_object_and_replace_ChildReadOnlyDictionaryOfStringString_with_the_provided_childReadOnlyDictionaryOfStringString___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

                var referenceObject = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>().ThatIsNot(systemUnderTest);
                
                // Act
                var actual = systemUnderTest.DeepCloneWithChildReadOnlyDictionaryOfStringString(referenceObject.ChildReadOnlyDictionaryOfStringString);

                // Assert
                actual.ChildReadOnlyDictionaryOfStringString.AsTest().Must().BeEqualTo(referenceObject.ChildReadOnlyDictionaryOfStringString);
            }
        }

        public static class Serialization
        {
            [Fact]
            public static void Deserialize___Should_roundtrip_object___When_serializing_and_deserializing_using_ObcBsonSerializer()
            {
                // Arrange
                var expected = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

                var serializer = BsonSerializer;

                var serializedBson = serializer.SerializeToString(expected);

                // Act
                var actual = serializer.Deserialize<MyModelPrivateSettersEmptyParentNotEmptyChild>(serializedBson);

                // Assert
                actual.AsTest().Must().BeEqualTo(expected);
            }

            [Fact]
            public static void Deserialize___Should_roundtrip_object___When_serializing_and_deserializing_using_ObcJsonSerializer()
            {
                // Arrange
                var expected = A.Dummy<MyModelPrivateSettersEmptyParentNotEmptyChild>();

                var serializer = JsonSerializer;

                var serializedJson = serializer.SerializeToString(expected);

                // Act
                var actual = serializer.Deserialize<MyModelPrivateSettersEmptyParentNotEmptyChild>(serializedJson);

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
                MyModelPrivateSettersEmptyParentNotEmptyChild systemUnderTest1 = null;
                MyModelPrivateSettersEmptyParentNotEmptyChild systemUnderTest2 = null;

                // Act
                var actual = systemUnderTest1 == systemUnderTest2;

                // Assert
                actual.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void EqualsOperator___Should_return_false___When_one_side_of_operator_is_null_and_the_other_side_is_not_null()
            {
                // Arrange
                MyModelPrivateSettersEmptyParentNotEmptyChild systemUnderTest = null;

                // Act
                var actual1 = systemUnderTest == ObjectForEquatableTests;
                var actual2 = ObjectForEquatableTests == systemUnderTest;

                // Assert
                actual1.AsTest().Must().BeFalse();
                actual2.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void EqualsOperator___Should_return_true___When_same_object_is_on_both_sides_of_operator()
            {
                // Arrange, Act
    #pragma warning disable CS1718 // Comparison made to same variable
                var actual = ObjectForEquatableTests == ObjectForEquatableTests;
    #pragma warning restore CS1718 // Comparison made to same variable

                // Assert
                actual.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void EqualsOperator___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                // Arrange, Act
                var actuals = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => ObjectForEquatableTests == _).ToList();

                // Assert
                actuals.AsTest().Must().Each().BeFalse();
            }

            [Fact]
            public static void EqualsOperator___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                // Arrange, Act
                var actuals = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.Select(_ => ObjectForEquatableTests == _).ToList();

                // Assert
                actuals.AsTest().Must().Each().BeTrue();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_both_sides_of_operator_are_null()
            {
                // Arrange
                MyModelPrivateSettersEmptyParentNotEmptyChild systemUnderTest1 = null;
                MyModelPrivateSettersEmptyParentNotEmptyChild systemUnderTest2 = null;

                // Act
                var actual = systemUnderTest1 != systemUnderTest2;

                // Assert
                actual.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_true___When_one_side_of_operator_is_null_and_the_other_side_is_not_null()
            {
                // Arrange
                MyModelPrivateSettersEmptyParentNotEmptyChild systemUnderTest = null;

                // Act
                var actual1 = systemUnderTest != ObjectForEquatableTests;
                var actual2 = ObjectForEquatableTests != systemUnderTest;

                // Assert
                actual1.AsTest().Must().BeTrue();
                actual2.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_same_object_is_on_both_sides_of_operator()
            {
                // Arrange, Act
    #pragma warning disable CS1718 // Comparison made to same variable
                var actual = ObjectForEquatableTests != ObjectForEquatableTests;
    #pragma warning restore CS1718 // Comparison made to same variable

                // Assert
                actual.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_true___When_objects_being_compared_have_different_property_values()
            {
                // Arrange, Act
                var actuals = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => ObjectForEquatableTests != _).ToList();

                // Assert
                actuals.AsTest().Must().Each().BeTrue();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_objects_being_compared_have_same_property_values()
            {
                // Arrange, Act
                var actuals = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.Select(_ => ObjectForEquatableTests != _).ToList();

                // Assert
                actuals.AsTest().Must().Each().BeFalse();
            }

            [Fact]
            public static void Equals_with_MyModelPrivateSettersEmptyParentNotEmptyChild___Should_return_false___When_parameter_other_is_null()
            {
                // Arrange
                MyModelPrivateSettersEmptyParentNotEmptyChild systemUnderTest = null;

                // Act
                var actual = ObjectForEquatableTests.Equals(systemUnderTest);

                // Assert
                actual.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void Equals_with_MyModelPrivateSettersEmptyParentNotEmptyChild___Should_return_true___When_parameter_other_is_same_object()
            {
                // Arrange, Act
                var actual = ObjectForEquatableTests.Equals(ObjectForEquatableTests);

                // Assert
                actual.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void Equals_with_MyModelPrivateSettersEmptyParentNotEmptyChild___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                // Arrange, Act
                var actuals = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => ObjectForEquatableTests.Equals(_)).ToList();

                // Assert
                actuals.AsTest().Must().Each().BeFalse();
            }

            [Fact]
            public static void Equals_with_MyModelPrivateSettersEmptyParentNotEmptyChild___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                // Arrange, Act
                var actuals = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.Select(_ => ObjectForEquatableTests.Equals(_)).ToList();

                // Assert
                actuals.AsTest().Must().Each().BeTrue();
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_parameter_other_is_null()
            {
                // Arrange, Act
                var actual = ObjectForEquatableTests.Equals(null);

                // Assert
                actual.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_parameter_other_is_not_of_the_same_type()
            {
                // Arrange, Act
                var actuals = ObjectsThatAreNotTheSameTypeAsObjectForEquatableTests.Select(_ => ObjectForEquatableTests.Equals((object)_)).ToList();

                // Assert
                actuals.AsTest().Must().Each().BeFalse();
            }

            [Fact]
            public static void Equals_with_Object___Should_return_true___When_parameter_other_is_same_object()
            {
                // Arrange, Act
                var actual = ObjectForEquatableTests.Equals((object)ObjectForEquatableTests);

                // Assert
                actual.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                // Arrange, Act
                var actuals = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => ObjectForEquatableTests.Equals((object)_)).ToList();

                // Assert
                actuals.AsTest().Must().Each().BeFalse();
            }

            [Fact]
            public static void Equals_with_Object___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                // Arrange, Act
                var actuals = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.Select(_ => ObjectForEquatableTests.Equals((object)_)).ToList();

                // Assert
                actuals.AsTest().Must().Each().BeTrue();
            }
        }

        public static class Hashing
        {
            [Fact]
            public static void GetHashCode___Should_not_be_equal_for_two_objects___When_objects_have_different_property_values()
            {
                // Arrange, Act
                var unexpected = ObjectForEquatableTests.GetHashCode();

                var actuals = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => _.GetHashCode()).ToList();

                // Assert
                actuals.AsTest().Must().NotContainElement(unexpected);
            }

            [Fact]
            public static void GetHashCode___Should_be_equal_for_two_objects___When_objects_have_the_same_property_values()
            {
                // Arrange, Act
                var expected = ObjectForEquatableTests.GetHashCode();

                var actuals = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.Select(_ => _.GetHashCode()).ToList();

                // Assert
                actuals.AsTest().Must().Each().BeEqualTo(expected);
            }
        }
    }
}