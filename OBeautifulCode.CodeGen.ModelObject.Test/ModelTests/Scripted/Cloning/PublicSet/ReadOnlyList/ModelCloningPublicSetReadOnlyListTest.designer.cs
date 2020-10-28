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

    public static partial class ModelCloningPublicSetReadOnlyListTest
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
            public static void ModelCloningPublicSetReadOnlyList___Should_implement_IDeepCloneable_of_ModelCloningPublicSetReadOnlyList___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetReadOnlyList);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPublicSetReadOnlyList>).GetInterfaceDeclaredAndImplementedMethods();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethodsFiltered(MemberRelationships.DeclaredOrInherited, MemberOwners.Instance, MemberAccessModifiers.Public).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPublicSetReadOnlyList>));
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
            public static void ModelCloningPublicSetReadOnlyList___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetReadOnlyList);

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetReadOnlyList>();

                // Act
                var actual = (ModelCloningPublicSetReadOnlyList)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetReadOnlyList>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

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

                if (systemUnderTest.ReadOnlyListInterfaceOfCustomEnumProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfCustomEnumProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfCustomFlagsEnumProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfCustomClassProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfCustomClassProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfCustomBaseClassProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfCustomBaseClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfCustomBaseClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfCustomBaseClassProperty);
                }

                if (systemUnderTest.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty == null)
                {
                    actual.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty);
                }
            }
        }
    }
}