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
    using global::OBeautifulCode.Representation.System;
    using global::OBeautifulCode.Serialization;
    using global::OBeautifulCode.Serialization.Recipes;
    using global::OBeautifulCode.Type;

    using global::Xunit;

    using static global::System.FormattableString;

    public static partial class ModelCloningPublicSetReadOnlyDictionaryChild2Test
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
            public static void ModelCloningPublicSetReadOnlyDictionaryChild2___Should_implement_IDeepCloneable_of_ModelCloningPublicSetReadOnlyDictionaryChild2___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetReadOnlyDictionaryChild2);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPublicSetReadOnlyDictionaryChild2>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPublicSetReadOnlyDictionaryChild2>));
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
            public static void ModelCloningPublicSetReadOnlyDictionaryChild2___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetReadOnlyDictionaryChild2);

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetReadOnlyDictionaryChild2>();

                // Act
                var actual = (ModelCloningPublicSetReadOnlyDictionaryChild2)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetReadOnlyDictionaryChild2>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

                if (systemUnderTest.ParentReadOnlyDictionaryInterfaceOfBoolProperty == null)
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfBoolProperty);
                }

                if (systemUnderTest.ParentReadOnlyDictionaryInterfaceOfIntProperty == null)
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfIntProperty);
                }

                if (systemUnderTest.ParentReadOnlyDictionaryInterfaceOfStringProperty == null)
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfStringProperty);
                }

                if (systemUnderTest.ParentReadOnlyDictionaryInterfaceOfGuidProperty == null)
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfGuidProperty);
                }

                if (systemUnderTest.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty == null)
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty);
                }

                if (systemUnderTest.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty == null)
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty == null)
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty);
                }

                if (systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfBoolProperty == null)
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfBoolProperty);
                }

                if (systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfIntProperty == null)
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfIntProperty);
                }

                if (systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfStringProperty == null)
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfStringProperty);
                }

                if (systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfGuidProperty == null)
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfGuidProperty);
                }

                if (systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfCustomEnumProperty == null)
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfCustomEnumProperty);
                }

                if (systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty == null)
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfCustomClassProperty == null)
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ReadOnlyDictionaryInterfaceOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfCustomClassProperty);
                }
            }
        }
    }
}