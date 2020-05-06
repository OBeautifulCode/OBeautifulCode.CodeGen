// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;
    using global::System.Reflection;

    using global::FakeItEasy;

    using global::OBeautifulCode.Assertion.Recipes;
    using global::OBeautifulCode.AutoFakeItEasy;
    using global::OBeautifulCode.CodeGen.ModelObject.Recipes;
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Math.Recipes;
    using global::OBeautifulCode.Representation.System;
    using global::OBeautifulCode.Serialization;
    using global::OBeautifulCode.Serialization.Bson;
    using global::OBeautifulCode.Serialization.Json;
    using global::OBeautifulCode.Type;

    using global::Xunit;

    using static global::System.FormattableString;

    public static partial class MyModelCloningPrivateSettersTest
    {
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
        public static class Structural
        {
            [Fact]
            [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
            [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
            [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
            [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
            [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
            [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
            public static void MyModelCloningPrivateSetters___Should_implement_IDeepCloneable_of_MyModelCloningPrivateSetters___When_reflecting()
            {
                // Arrange
                var type = typeof(MyModelCloningPrivateSetters);

                var expectedModelMethods = typeof(IDeepCloneable<MyModelCloningPrivateSetters>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<MyModelCloningPrivateSetters>));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
            }

            [Fact]
            [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
            [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
            [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
            [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
            [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
            [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
            public static void MyModelCloningPrivateSetters___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(MyModelCloningPrivateSetters);

                // Act
                var actualAttributes = type.GetCustomAttributes(typeof(SerializableAttribute), false);

                // Assert
                actualAttributes.AsTest().Must().NotBeEmptyEnumerable();
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
        public static class Cloning
        {
            [Fact]
            [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
            [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
            [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
            [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
            [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
            [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
            public static void Clone___Should_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelCloningPrivateSetters>();

                // Act
                var actual = (MyModelCloningPrivateSetters)systemUnderTest.Clone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);
            }

            [Fact]
            [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
            [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
            [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
            [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
            [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
            [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
            public static void DeepClone___Should_deep_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelCloningPrivateSetters>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

                if (systemUnderTest.ModelClassProperty == null)
                {
                    actual.ModelClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ModelClassProperty);
                }

                if (systemUnderTest.ArrayOfBoolProperty == null)
                {
                    actual.ArrayOfBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfBoolProperty);
                }

                if (systemUnderTest.ArrayOfIntProperty == null)
                {
                    actual.ArrayOfIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfIntProperty);
                }

                if (systemUnderTest.ArrayOfStringProperty == null)
                {
                    actual.ArrayOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfStringProperty);
                }

                if (systemUnderTest.ArrayOfGuidProperty == null)
                {
                    actual.ArrayOfGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfGuidProperty);
                }

                if (systemUnderTest.ArrayOfDateTimeProperty == null)
                {
                    actual.ArrayOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfDateTimeProperty);
                }

                if (systemUnderTest.ArrayOfModelEnumProperty == null)
                {
                    actual.ArrayOfModelEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfModelEnumProperty);
                }

                if (systemUnderTest.ArrayOfModelFlagsEnumProperty == null)
                {
                    actual.ArrayOfModelFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfModelFlagsEnumProperty);
                }

                if (systemUnderTest.ArrayOfModelClassProperty == null)
                {
                    actual.ArrayOfModelClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfModelClassProperty);
                }

                if (systemUnderTest.ArrayOfNullableBoolProperty == null)
                {
                    actual.ArrayOfNullableBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableBoolProperty);
                }

                if (systemUnderTest.ArrayOfNullableIntProperty == null)
                {
                    actual.ArrayOfNullableIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableIntProperty);
                }

                if (systemUnderTest.ArrayOfNullableGuidProperty == null)
                {
                    actual.ArrayOfNullableGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableGuidProperty);
                }

                if (systemUnderTest.ArrayOfNullableDateTimeProperty == null)
                {
                    actual.ArrayOfNullableDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableDateTimeProperty);
                }

                if (systemUnderTest.ArrayOfNullableModelEnumProperty == null)
                {
                    actual.ArrayOfNullableModelEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableModelEnumProperty);
                }

                if (systemUnderTest.ArrayOfNullableModelFlagsEnumProperty == null)
                {
                    actual.ArrayOfNullableModelFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ArrayOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableModelFlagsEnumProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfBoolProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfBoolProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfIntProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfIntProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfStringProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfGuidProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfGuidProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfDateTimeProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfModelEnumProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfModelEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfModelEnumProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfModelClassProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfModelClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfModelClassProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfNullableBoolProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableBoolProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfNullableIntProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableIntProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfNullableGuidProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableGuidProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfNullableDateTimeProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableDateTimeProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfNullableModelEnumProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableModelEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableModelEnumProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfBoolProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfBoolProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfIntProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfIntProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfStringProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfStringProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfGuidProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfGuidProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfDateTimeProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfModelEnumProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfModelEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfModelEnumProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfModelFlagsEnumProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfModelFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfModelFlagsEnumProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfModelClassProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfModelClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfModelClassProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfNullableBoolProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableBoolProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfNullableIntProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableIntProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfNullableGuidProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableGuidProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfNullableDateTimeProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableDateTimeProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfNullableModelEnumProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfNullableModelEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableModelEnumProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfBoolProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfBoolProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfIntProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfIntProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfStringProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfStringProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfGuidProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfGuidProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfModelEnumProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfModelEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfModelEnumProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfModelClassProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfModelClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfModelClassProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableBoolProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfNullableBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableBoolProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableIntProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfNullableIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableIntProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableGuidProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfNullableGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableGuidProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty);
                }

                if (systemUnderTest.CollectionInterfaceOfStringProperty == null)
                {
                    actual.CollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.CollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.CollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.CollectionOfCollectionInterfaceOfStringProperty == null)
                {
                    actual.CollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.CollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.CollectionOfCollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.ListInterfaceOfCollectionInterfaceOfStringProperty == null)
                {
                    actual.ListInterfaceOfCollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ListInterfaceOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ListInterfaceOfCollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.ListOfCollectionInterfaceOfStringProperty == null)
                {
                    actual.ListOfCollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ListOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ListOfCollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty == null)
                {
                    actual.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty == null)
                {
                    actual.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty == null)
                {
                    actual.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty == null)
                {
                    actual.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty == null)
                {
                    actual.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                }
            }
        }
    }
}