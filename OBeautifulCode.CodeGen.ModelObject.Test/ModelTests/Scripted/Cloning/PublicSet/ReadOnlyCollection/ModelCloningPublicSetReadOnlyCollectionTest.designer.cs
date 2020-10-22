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

    public static partial class ModelCloningPublicSetReadOnlyCollectionTest
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
            public static void ModelCloningPublicSetReadOnlyCollection___Should_implement_IDeepCloneable_of_ModelCloningPublicSetReadOnlyCollection___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetReadOnlyCollection);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPublicSetReadOnlyCollection>).GetInterfaceDeclaredAndImplementedMethods();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlagsFor.DeclaredAndInheritedPublicInstanceMembers).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPublicSetReadOnlyCollection>));
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
            public static void ModelCloningPublicSetReadOnlyCollection___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetReadOnlyCollection);

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetReadOnlyCollection>();

                // Act
                var actual = (ModelCloningPublicSetReadOnlyCollection)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetReadOnlyCollection>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

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

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfCustomEnumProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfCustomEnumProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfCustomClassProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfCustomClassProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty);
                }

                if (systemUnderTest.ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty == null)
                {
                    actual.ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty);
                }
            }
        }
    }
}