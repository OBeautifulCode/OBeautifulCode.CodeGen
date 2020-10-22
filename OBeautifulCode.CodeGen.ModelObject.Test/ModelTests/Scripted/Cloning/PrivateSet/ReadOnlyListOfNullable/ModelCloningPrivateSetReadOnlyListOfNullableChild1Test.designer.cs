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
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Math.Recipes;
    using global::OBeautifulCode.Reflection.Recipes;
    using global::OBeautifulCode.Representation.System;
    using global::OBeautifulCode.Serialization;
    using global::OBeautifulCode.Serialization.Recipes;
    using global::OBeautifulCode.Type;

    using global::Xunit;

    using static global::System.FormattableString;

    public static partial class ModelCloningPrivateSetReadOnlyListOfNullableChild1Test
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
            public static void ModelCloningPrivateSetReadOnlyListOfNullableChild1___Should_implement_IDeepCloneable_of_ModelCloningPrivateSetReadOnlyListOfNullableChild1___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPrivateSetReadOnlyListOfNullableChild1);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPrivateSetReadOnlyListOfNullableChild1>).GetInterfaceDeclaredAndImplementedMethods();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlagsFor.DeclaredAndInheritedPublicInstanceMembers).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPrivateSetReadOnlyListOfNullableChild1>));
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
            public static void ModelCloningPrivateSetReadOnlyListOfNullableChild1___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPrivateSetReadOnlyListOfNullableChild1);

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
                var systemUnderTest = A.Dummy<ModelCloningPrivateSetReadOnlyListOfNullableChild1>();

                // Act
                var actual = (ModelCloningPrivateSetReadOnlyListOfNullableChild1)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPrivateSetReadOnlyListOfNullableChild1>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableBoolProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableBoolProperty);
                }

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableIntProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableIntProperty);
                }

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableGuidProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableGuidProperty);
                }

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableDateTimeProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableDateTimeProperty);
                }

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty);
                }

                if (systemUnderTest.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty == null)
                {
                    actual.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty);
                }

                if (systemUnderTest.Child1ReadOnlyListInterfaceOfNullableBoolProperty == null)
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableBoolProperty);
                }

                if (systemUnderTest.Child1ReadOnlyListInterfaceOfNullableIntProperty == null)
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableIntProperty);
                }

                if (systemUnderTest.Child1ReadOnlyListInterfaceOfNullableGuidProperty == null)
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableGuidProperty);
                }

                if (systemUnderTest.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty == null)
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty);
                }

                if (systemUnderTest.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty == null)
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty);
                }

                if (systemUnderTest.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty == null)
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty);
                }
            }
        }
    }
}