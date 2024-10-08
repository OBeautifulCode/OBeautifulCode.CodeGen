﻿// --------------------------------------------------------------------------------------------------------------------
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
    using global::OBeautifulCode.DateTime.Recipes;
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Math.Recipes;
    using global::OBeautifulCode.Reflection.Recipes;
    using global::OBeautifulCode.Representation.System;
    using global::OBeautifulCode.Serialization;
    using global::OBeautifulCode.Serialization.Recipes;
    using global::OBeautifulCode.Type;

    using global::Xunit;

    using static global::System.FormattableString;

    public static partial class ModelCloningPublicSetMiscTest
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
            public static void ModelCloningPublicSetMisc___Should_implement_IDeepCloneable_of_ModelCloningPublicSetMisc___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetMisc);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPublicSetMisc>).GetInterfaceDeclaredAndImplementedMethods();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethodsFiltered(MemberRelationships.DeclaredOrInherited, MemberOwners.Instance, MemberAccessModifiers.Public).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPublicSetMisc>));
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
            public static void ModelCloningPublicSetMisc___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetMisc);

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetMisc>();

                // Act
                var actual = (ModelCloningPublicSetMisc)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetMisc>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

                if (systemUnderTest.CollectionInterfaceOfStringProperty == null)
                {
                    actual.CollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else if (!actual.CollectionInterfaceOfStringProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.CollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.CollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.ListInterfaceOfStringProperty == null)
                {
                    actual.ListInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ListInterfaceOfStringProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ListInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ListInterfaceOfStringProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty == null)
                {
                    actual.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else if (!actual.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty);
                }

                if (systemUnderTest.ListInterfaceOfCollectionInterfaceOfStringProperty == null)
                {
                    actual.ListInterfaceOfCollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ListInterfaceOfCollectionInterfaceOfStringProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ListInterfaceOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ListInterfaceOfCollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfListInterfaceOfStringProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfListInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ReadOnlyListInterfaceOfListInterfaceOfStringProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ReadOnlyListInterfaceOfListInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfListInterfaceOfStringProperty);
                }

                if (systemUnderTest.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty == null)
                {
                    actual.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else if (!actual.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty == null)
                {
                    actual.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                }
            }
        }
    }
}