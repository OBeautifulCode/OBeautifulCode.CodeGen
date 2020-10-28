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

    public static partial class ModelCloningPrivateSetReadOnlyCollectionChild2Test
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
            public static void ModelCloningPrivateSetReadOnlyCollectionChild2___Should_implement_IDeepCloneable_of_ModelCloningPrivateSetReadOnlyCollectionChild2___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPrivateSetReadOnlyCollectionChild2);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPrivateSetReadOnlyCollectionChild2>).GetInterfaceDeclaredAndImplementedMethods();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethodsFiltered(MemberRelationships.DeclaredOrInherited, MemberOwners.Instance, MemberAccessModifiers.Public).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPrivateSetReadOnlyCollectionChild2>));
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
            public static void ModelCloningPrivateSetReadOnlyCollectionChild2___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPrivateSetReadOnlyCollectionChild2);

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
                var systemUnderTest = A.Dummy<ModelCloningPrivateSetReadOnlyCollectionChild2>();

                // Act
                var actual = (ModelCloningPrivateSetReadOnlyCollectionChild2)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPrivateSetReadOnlyCollectionChild2>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfBoolProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfBoolProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfIntProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfIntProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfStringProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfGuidProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfGuidProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfDateTimeProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomClassProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomClassProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty);
                }

                if (systemUnderTest.Child2ReadOnlyCollectionInterfaceOfBoolProperty == null)
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfBoolProperty);
                }

                if (systemUnderTest.Child2ReadOnlyCollectionInterfaceOfIntProperty == null)
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfIntProperty);
                }

                if (systemUnderTest.Child2ReadOnlyCollectionInterfaceOfStringProperty == null)
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.Child2ReadOnlyCollectionInterfaceOfGuidProperty == null)
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfGuidProperty);
                }

                if (systemUnderTest.Child2ReadOnlyCollectionInterfaceOfDateTimeProperty == null)
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.Child2ReadOnlyCollectionInterfaceOfCustomEnumProperty == null)
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfCustomEnumProperty);
                }

                if (systemUnderTest.Child2ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty == null)
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.Child2ReadOnlyCollectionInterfaceOfCustomClassProperty == null)
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfCustomClassProperty);
                }

                if (systemUnderTest.Child2ReadOnlyCollectionInterfaceOfCustomBaseClassProperty == null)
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfCustomBaseClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfCustomBaseClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfCustomBaseClassProperty);
                }

                if (systemUnderTest.Child2ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty == null)
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty);
                }
            }
        }
    }
}