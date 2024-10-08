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

    public static partial class ModelCloningPublicSetReadOnlyCollectionOfNullableChild1Test
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
            public static void ModelCloningPublicSetReadOnlyCollectionOfNullableChild1___Should_implement_IDeepCloneable_of_ModelCloningPublicSetReadOnlyCollectionOfNullableChild1___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetReadOnlyCollectionOfNullableChild1);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPublicSetReadOnlyCollectionOfNullableChild1>).GetInterfaceDeclaredAndImplementedMethods();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethodsFiltered(MemberRelationships.DeclaredOrInherited, MemberOwners.Instance, MemberAccessModifiers.Public).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPublicSetReadOnlyCollectionOfNullableChild1>));
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
            public static void ModelCloningPublicSetReadOnlyCollectionOfNullableChild1___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetReadOnlyCollectionOfNullableChild1);

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetReadOnlyCollectionOfNullableChild1>();

                // Act
                var actual = (ModelCloningPublicSetReadOnlyCollectionOfNullableChild1)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetReadOnlyCollectionOfNullableChild1>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableBoolProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfNullableBoolProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfNullableBoolProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableBoolProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableIntProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfNullableIntProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfNullableIntProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableIntProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableGuidProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfNullableGuidProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfNullableGuidProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableGuidProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableIntProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableIntProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfNullableIntProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableIntProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty);
                }
            }
        }
    }
}