// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Reflection;

    using FakeItEasy;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Representation.System;
    using OBeautifulCode.Serialization;
    using OBeautifulCode.Serialization.Bson;
    using OBeautifulCode.Serialization.Json;
    using OBeautifulCode.Type;

    using Xunit;

    using static System.FormattableString;

    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.0.0")]
    public partial class MyModelPublicSettersTest
    {
        private static readonly ISerializeAndDeserialize BsonSerializer = new ObcBsonSerializer<CodeGenModelObjectTestBsonConfiguration>();
        
        private static readonly ISerializeAndDeserialize JsonSerializer = new ObcJsonSerializer<CodeGenModelObjectTestJsonConfiguration>();

        private static readonly MyModelPublicSetters ObjectForEquatableTests = A.Dummy<MyModelPublicSetters>();

        private static readonly MyModelPublicSetters ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests =
            new MyModelPublicSetters
                {
                    IntProperty                               = ObjectForEquatableTests.IntProperty,
                    StringProperty                            = ObjectForEquatableTests.StringProperty,
                    ModelEquatableClassProperty               = ObjectForEquatableTests.ModelEquatableClassProperty,
                    ReadOnlyListOfIntProperty                 = ObjectForEquatableTests.ReadOnlyListOfIntProperty,
                    ReadOnlyListOfStringProperty              = ObjectForEquatableTests.ReadOnlyListOfStringProperty,
                    ReadOnlyListOfModelEquatableClassProperty = ObjectForEquatableTests.ReadOnlyListOfModelEquatableClassProperty
                };

        private static readonly MyModelPublicSetters[] ObjectsThatAreNotEqualToObjectForEquatableTests =
        {
            new MyModelPublicSetters
                {
                    IntProperty                               = A.Dummy<int>().ThatIsNot(ObjectForEquatableTests.IntProperty),
                    StringProperty                            = ObjectForEquatableTests.StringProperty,
                    ModelEquatableClassProperty               = ObjectForEquatableTests.ModelEquatableClassProperty,
                    ReadOnlyListOfIntProperty                 = ObjectForEquatableTests.ReadOnlyListOfIntProperty,
                    ReadOnlyListOfStringProperty              = ObjectForEquatableTests.ReadOnlyListOfStringProperty,
                    ReadOnlyListOfModelEquatableClassProperty = ObjectForEquatableTests.ReadOnlyListOfModelEquatableClassProperty
                },
            new MyModelPublicSetters
                {
                    IntProperty                               = ObjectForEquatableTests.IntProperty,
                    StringProperty                            = A.Dummy<string>().ThatIsNot(ObjectForEquatableTests.StringProperty),
                    ModelEquatableClassProperty               = ObjectForEquatableTests.ModelEquatableClassProperty,
                    ReadOnlyListOfIntProperty                 = ObjectForEquatableTests.ReadOnlyListOfIntProperty,
                    ReadOnlyListOfStringProperty              = ObjectForEquatableTests.ReadOnlyListOfStringProperty,
                    ReadOnlyListOfModelEquatableClassProperty = ObjectForEquatableTests.ReadOnlyListOfModelEquatableClassProperty
                },
            new MyModelPublicSetters
                {
                    IntProperty                               = ObjectForEquatableTests.IntProperty,
                    StringProperty                            = ObjectForEquatableTests.StringProperty,
                    ModelEquatableClassProperty               = A.Dummy<ModelEquatableClass>().ThatIsNot(ObjectForEquatableTests.ModelEquatableClassProperty),
                    ReadOnlyListOfIntProperty                 = ObjectForEquatableTests.ReadOnlyListOfIntProperty,
                    ReadOnlyListOfStringProperty              = ObjectForEquatableTests.ReadOnlyListOfStringProperty,
                    ReadOnlyListOfModelEquatableClassProperty = ObjectForEquatableTests.ReadOnlyListOfModelEquatableClassProperty
                },
            new MyModelPublicSetters
                {
                    IntProperty                               = ObjectForEquatableTests.IntProperty,
                    StringProperty                            = ObjectForEquatableTests.StringProperty,
                    ModelEquatableClassProperty               = ObjectForEquatableTests.ModelEquatableClassProperty,
                    ReadOnlyListOfIntProperty                 = A.Dummy<IReadOnlyList<int>>().ThatIsNot(ObjectForEquatableTests.ReadOnlyListOfIntProperty),
                    ReadOnlyListOfStringProperty              = ObjectForEquatableTests.ReadOnlyListOfStringProperty,
                    ReadOnlyListOfModelEquatableClassProperty = ObjectForEquatableTests.ReadOnlyListOfModelEquatableClassProperty
                },
            new MyModelPublicSetters
                {
                    IntProperty                               = ObjectForEquatableTests.IntProperty,
                    StringProperty                            = ObjectForEquatableTests.StringProperty,
                    ModelEquatableClassProperty               = ObjectForEquatableTests.ModelEquatableClassProperty,
                    ReadOnlyListOfIntProperty                 = ObjectForEquatableTests.ReadOnlyListOfIntProperty,
                    ReadOnlyListOfStringProperty              = A.Dummy<IReadOnlyList<string>>().ThatIsNot(ObjectForEquatableTests.ReadOnlyListOfStringProperty),
                    ReadOnlyListOfModelEquatableClassProperty = ObjectForEquatableTests.ReadOnlyListOfModelEquatableClassProperty
                },
            new MyModelPublicSetters
                {
                    IntProperty                               = ObjectForEquatableTests.IntProperty,
                    StringProperty                            = ObjectForEquatableTests.StringProperty,
                    ModelEquatableClassProperty               = ObjectForEquatableTests.ModelEquatableClassProperty,
                    ReadOnlyListOfIntProperty                 = ObjectForEquatableTests.ReadOnlyListOfIntProperty,
                    ReadOnlyListOfStringProperty              = ObjectForEquatableTests.ReadOnlyListOfStringProperty,
                    ReadOnlyListOfModelEquatableClassProperty = A.Dummy<IReadOnlyList<ModelEquatableClass>>().ThatIsNot(ObjectForEquatableTests.ReadOnlyListOfModelEquatableClassProperty)
                },
        };

        private static readonly string ObjectThatIsNotTheSameTypeAsObjectForEquatableTests = A.Dummy<string>();
    
        [Fact]
        public static void ToString___Should_generate_friendly_string_representation_of_object___When_called()
        {
            // Arrange
            var systemUnderTest = A.Dummy<MyModelPublicSetters>();

            var expected = Invariant($"Test.MyModelPublicSetters: IntProperty = {systemUnderTest.IntProperty}, StringProperty = {systemUnderTest.StringProperty}, ModelEquatableClassProperty = {systemUnderTest.ModelEquatableClassProperty}, ReadOnlyListOfIntProperty = {systemUnderTest.ReadOnlyListOfIntProperty}, ReadOnlyListOfStringProperty = {systemUnderTest.ReadOnlyListOfStringProperty}, ReadOnlyListOfModelEquatableClassProperty = {systemUnderTest.ReadOnlyListOfModelEquatableClassProperty}.");

            // Act
            var actual = systemUnderTest.ToString();

            // Assert
            actual.AsTest().Must().BeEqualTo(expected);
        }
    
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Justification = "Grouping construct for unit test runner.")]
        public static class Constructing
        {
            [Fact]
            public static void MyModelPublicSetters___Should_implement_IModel___When_reflecting()
            {
                // Arrange
                var type = typeof(MyModelPublicSetters);
                var expectedModelMethods = typeof(IModel<MyModelPublicSetters>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();
                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IModel<MyModelPublicSetters>));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
            }
        }
    
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Justification = "Grouping construct for unit test runner.")]
        public static class Cloning
        {
            [Fact]
            public static void DeepClone___Should_deep_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelPublicSetters>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);
                actual.ModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ModelEquatableClassProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfModelEquatableClassProperty);
            }

            [Fact]
            public static void DeepCloneWithIntProperty___Should_deep_clone_object_and_replace_IntProperty_with_the_provided_intProperty___When_called()
            {
                // Arrange,
                var systemUnderTest = A.Dummy<MyModelPublicSetters>();

                var referenceObject = A.Dummy<MyModelPublicSetters>().ThatIsNot(systemUnderTest);
                
                // Act
                var actual = systemUnderTest.DeepCloneWithIntProperty(referenceObject.IntProperty);

                // Assert
                actual.IntProperty.AsTest().Must().BeEqualTo(referenceObject.IntProperty);
                actual.StringProperty.AsTest().Must().BeEqualTo(systemUnderTest.StringProperty);
                actual.ModelEquatableClassProperty.AsTest().Must().BeEqualTo(systemUnderTest.ModelEquatableClassProperty);
                actual.ModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ModelEquatableClassProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfModelEquatableClassProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfModelEquatableClassProperty);
            }

            [Fact]
            public static void DeepCloneWithStringProperty___Should_deep_clone_object_and_replace_StringProperty_with_the_provided_stringProperty___When_called()
            {
                // Arrange,
                var systemUnderTest = A.Dummy<MyModelPublicSetters>();

                var referenceObject = A.Dummy<MyModelPublicSetters>().ThatIsNot(systemUnderTest);
                
                // Act
                var actual = systemUnderTest.DeepCloneWithStringProperty(referenceObject.StringProperty);

                // Assert
                actual.IntProperty.AsTest().Must().BeEqualTo(systemUnderTest.IntProperty);
                actual.StringProperty.AsTest().Must().BeEqualTo(referenceObject.StringProperty);
                actual.ModelEquatableClassProperty.AsTest().Must().BeEqualTo(systemUnderTest.ModelEquatableClassProperty);
                actual.ModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ModelEquatableClassProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfModelEquatableClassProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfModelEquatableClassProperty);
            }

            [Fact]
            public static void DeepCloneWithModelEquatableClassProperty___Should_deep_clone_object_and_replace_ModelEquatableClassProperty_with_the_provided_modelEquatableClassProperty___When_called()
            {
                // Arrange,
                var systemUnderTest = A.Dummy<MyModelPublicSetters>();

                var referenceObject = A.Dummy<MyModelPublicSetters>().ThatIsNot(systemUnderTest);
                
                // Act
                var actual = systemUnderTest.DeepCloneWithModelEquatableClassProperty(referenceObject.ModelEquatableClassProperty);

                // Assert
                actual.IntProperty.AsTest().Must().BeEqualTo(systemUnderTest.IntProperty);
                actual.StringProperty.AsTest().Must().BeEqualTo(systemUnderTest.StringProperty);
                actual.ModelEquatableClassProperty.AsTest().Must().BeEqualTo(referenceObject.ModelEquatableClassProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfModelEquatableClassProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfModelEquatableClassProperty);
            }

            [Fact]
            public static void DeepCloneWithReadOnlyListOfIntProperty___Should_deep_clone_object_and_replace_ReadOnlyListOfIntProperty_with_the_provided_readOnlyListOfIntProperty___When_called()
            {
                // Arrange,
                var systemUnderTest = A.Dummy<MyModelPublicSetters>();

                var referenceObject = A.Dummy<MyModelPublicSetters>().ThatIsNot(systemUnderTest);
                
                // Act
                var actual = systemUnderTest.DeepCloneWithReadOnlyListOfIntProperty(referenceObject.ReadOnlyListOfIntProperty);

                // Assert
                actual.IntProperty.AsTest().Must().BeEqualTo(systemUnderTest.IntProperty);
                actual.StringProperty.AsTest().Must().BeEqualTo(systemUnderTest.StringProperty);
                actual.ModelEquatableClassProperty.AsTest().Must().BeEqualTo(systemUnderTest.ModelEquatableClassProperty);
                actual.ModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ModelEquatableClassProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().BeEqualTo(referenceObject.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfModelEquatableClassProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfModelEquatableClassProperty);
            }

            [Fact]
            public static void DeepCloneWithReadOnlyListOfStringProperty___Should_deep_clone_object_and_replace_ReadOnlyListOfStringProperty_with_the_provided_readOnlyListOfStringProperty___When_called()
            {
                // Arrange,
                var systemUnderTest = A.Dummy<MyModelPublicSetters>();

                var referenceObject = A.Dummy<MyModelPublicSetters>().ThatIsNot(systemUnderTest);
                
                // Act
                var actual = systemUnderTest.DeepCloneWithReadOnlyListOfStringProperty(referenceObject.ReadOnlyListOfStringProperty);

                // Assert
                actual.IntProperty.AsTest().Must().BeEqualTo(systemUnderTest.IntProperty);
                actual.StringProperty.AsTest().Must().BeEqualTo(systemUnderTest.StringProperty);
                actual.ModelEquatableClassProperty.AsTest().Must().BeEqualTo(systemUnderTest.ModelEquatableClassProperty);
                actual.ModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ModelEquatableClassProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().BeEqualTo(referenceObject.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfModelEquatableClassProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfModelEquatableClassProperty);
            }

            [Fact]
            public static void DeepCloneWithReadOnlyListOfModelEquatableClassProperty___Should_deep_clone_object_and_replace_ReadOnlyListOfModelEquatableClassProperty_with_the_provided_readOnlyListOfModelEquatableClassProperty___When_called()
            {
                // Arrange,
                var systemUnderTest = A.Dummy<MyModelPublicSetters>();

                var referenceObject = A.Dummy<MyModelPublicSetters>().ThatIsNot(systemUnderTest);
                
                // Act
                var actual = systemUnderTest.DeepCloneWithReadOnlyListOfModelEquatableClassProperty(referenceObject.ReadOnlyListOfModelEquatableClassProperty);

                // Assert
                actual.IntProperty.AsTest().Must().BeEqualTo(systemUnderTest.IntProperty);
                actual.StringProperty.AsTest().Must().BeEqualTo(systemUnderTest.StringProperty);
                actual.ModelEquatableClassProperty.AsTest().Must().BeEqualTo(systemUnderTest.ModelEquatableClassProperty);
                actual.ModelEquatableClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ModelEquatableClassProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfIntProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().BeEqualTo(systemUnderTest.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListOfStringProperty);
                actual.ReadOnlyListOfModelEquatableClassProperty.AsTest().Must().BeEqualTo(referenceObject.ReadOnlyListOfModelEquatableClassProperty);
            }
        }
    
        [SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Justification = "Name is correct.")]
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Justification = "Grouping construct for unit test runner.")]
        public static class Serialization
        {
            [Fact]
            public static void Deserialize___Should_roundtrip_object___When_serializing_and_deserializing_using_ObcBsonSerializer()
            {
                // Arrange
                var expected = A.Dummy<MyModelPublicSetters>();

                var serializer = BsonSerializer;

                var serializedBson = serializer.SerializeToString(expected);

                // Act
                var actual = serializer.Deserialize<MyModelPublicSetters>(serializedBson);

                // Assert
                actual.AsTest().Must().BeEqualTo(expected);
            }

            [Fact]
            public static void Deserialize___Should_roundtrip_object___When_serializing_and_deserializing_using_ObcJsonSerializer()
            {
                // Arrange
                var expected = A.Dummy<MyModelPublicSetters>();

                var serializer = JsonSerializer;

                var serializedJson = serializer.SerializeToString(expected);

                // Act
                var actual = serializer.Deserialize<MyModelPublicSetters>(serializedJson);

                // Assert
                actual.AsTest().Must().BeEqualTo(expected);
            }
        }
    
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Justification = "Grouping construct for unit test runner.")]
        public static class Equality
        {
            [Fact]
            public static void EqualsOperator___Should_return_true___When_both_sides_of_operator_are_null()
            {
                // Arrange
                MyModelPublicSetters systemUnderTest1 = null;
                MyModelPublicSetters systemUnderTest2 = null;

                // Act
                var result = systemUnderTest1 == systemUnderTest2;

                // Assert
                result.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void EqualsOperator___Should_return_false___When_one_side_of_operator_is_null_and_the_other_side_is_not_null()
            {
                // Arrange
                MyModelPublicSetters systemUnderTest = null;

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
                MyModelPublicSetters systemUnderTest1 = null;
                MyModelPublicSetters systemUnderTest2 = null;

                // Act
                var result = systemUnderTest1 != systemUnderTest2;

                // Assert
                result.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_true___When_one_side_of_operator_is_null_and_the_other_side_is_not_null()
            {
                // Arrange
                MyModelPublicSetters systemUnderTest = null;

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
            public static void Equals_with_MyModelPublicSetters___Should_return_false___When_parameter_other_is_null()
            {
                // Arrange
                MyModelPublicSetters systemUnderTest = null;

                // Act
                var result = ObjectForEquatableTests.Equals(systemUnderTest);

                // Assert
                result.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void Equals_with_MyModelPublicSetters___Should_return_true___When_parameter_other_is_same_object()
            {
                // Arrange, Act
                var result = ObjectForEquatableTests.Equals(ObjectForEquatableTests);

                // Assert
                result.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void Equals_with_MyModelPublicSetters___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                // Arrange, Act
                var actualCheckReferenceAgainstUnequalSet = ObjectsThatAreNotEqualToObjectForEquatableTests.Select(_ => ObjectForEquatableTests.Equals(_)).ToList();
                var actualCheckAgainstOthersInUnequalSet = ObjectsThatAreNotEqualToObjectForEquatableTests.GetCombinations(2, 2).Select( _=> _.First().Equals(_.Last())).ToList();

                // Assert
                actualCheckReferenceAgainstUnequalSet.AsTest().Must().Each().BeFalse();
                actualCheckAgainstOthersInUnequalSet.AsTest().Must().Each().BeFalse();
            }

            [Fact]
            public static void Equals_with_MyModelPublicSetters___Should_return_true___When_objects_being_compared_have_same_property_values()
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
        }
    }
}