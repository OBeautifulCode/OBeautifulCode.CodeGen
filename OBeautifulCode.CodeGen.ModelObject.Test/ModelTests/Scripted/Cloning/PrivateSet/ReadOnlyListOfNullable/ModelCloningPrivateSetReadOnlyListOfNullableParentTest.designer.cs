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

    public static partial class ModelCloningPrivateSetReadOnlyListOfNullableParentTest
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
            public static void ModelCloningPrivateSetReadOnlyListOfNullableParent___Should_implement_IDeepCloneable_of_ModelCloningPrivateSetReadOnlyListOfNullableParent___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPrivateSetReadOnlyListOfNullableParent);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPrivateSetReadOnlyListOfNullableParent>).GetInterfaceDeclaredAndImplementedMethods();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethodsFiltered(MemberRelationships.DeclaredOrInherited, MemberOwners.Instance, MemberAccessModifiers.Public).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPrivateSetReadOnlyListOfNullableParent>));
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
            public static void ModelCloningPrivateSetReadOnlyListOfNullableParent___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPrivateSetReadOnlyListOfNullableParent);

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
                var systemUnderTest = A.Dummy<ModelCloningPrivateSetReadOnlyListOfNullableParent>();

                // Act
                var actual = (ModelCloningPrivateSetReadOnlyListOfNullableParent)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPrivateSetReadOnlyListOfNullableParent>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableBoolProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyListInterfaceOfNullableBoolProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableBoolProperty);
                }

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableIntProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyListInterfaceOfNullableIntProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableIntProperty);
                }

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableGuidProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyListInterfaceOfNullableGuidProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableGuidProperty);
                }

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableDateTimeProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyListInterfaceOfNullableDateTimeProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableDateTimeProperty);
                }

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty);
                }

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty);
                }
            }
        }
    }
}