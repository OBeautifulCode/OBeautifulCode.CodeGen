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
    public partial class MyModelHashingPrivateSettersChild1Test
    {
        public static class Structural
        {
            [Fact]
            public static void MyModelHashingPrivateSettersChild1___Should_implement_IHashable___When_reflecting()
            {
                // Arrange
                var type = typeof(MyModelHashingPrivateSettersChild1);

                var expectedModelMethods = typeof(IHashable)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IHashable));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
            }

            [Fact]
            public static void MyModelHashingPrivateSettersChild1___Should_declare_GetHashCode_method___When_reflecting()
            {
                // Arrange
                var expected = typeof(MyModelHashingPrivateSettersChild1);

                // Act
                var actual = expected.GetMethod(nameof(GetHashCode));

                // Assert
                actual.DeclaringType.AsTest().Must().BeEqualTo(expected);
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