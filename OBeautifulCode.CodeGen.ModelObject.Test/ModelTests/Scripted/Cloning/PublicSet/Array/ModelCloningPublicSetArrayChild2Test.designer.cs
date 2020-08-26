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

    public static partial class ModelCloningPublicSetArrayChild2Test
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
            public static void ModelCloningPublicSetArrayChild2___Should_implement_IDeepCloneable_of_ModelCloningPublicSetArrayChild2___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetArrayChild2);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPublicSetArrayChild2>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPublicSetArrayChild2>));
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
            public static void ModelCloningPublicSetArrayChild2___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetArrayChild2);

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetArrayChild2>();

                // Act
                var actual = (ModelCloningPublicSetArrayChild2)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetArrayChild2>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

                if (systemUnderTest.ParentArrayOfBoolProperty == null)
                {
                    actual.ParentArrayOfBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfBoolProperty);
                }

                if (systemUnderTest.ParentArrayOfIntProperty == null)
                {
                    actual.ParentArrayOfIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfIntProperty);
                }

                if (systemUnderTest.ParentArrayOfStringProperty == null)
                {
                    actual.ParentArrayOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfStringProperty);
                }

                if (systemUnderTest.ParentArrayOfGuidProperty == null)
                {
                    actual.ParentArrayOfGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfGuidProperty);
                }

                if (systemUnderTest.ParentArrayOfDateTimeProperty == null)
                {
                    actual.ParentArrayOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfDateTimeProperty);
                }

                if (systemUnderTest.ParentArrayOfCustomEnumProperty == null)
                {
                    actual.ParentArrayOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfCustomEnumProperty);
                }

                if (systemUnderTest.ParentArrayOfCustomFlagsEnumProperty == null)
                {
                    actual.ParentArrayOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.ParentArrayOfCustomClassProperty == null)
                {
                    actual.ParentArrayOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfCustomClassProperty);
                }

                if (systemUnderTest.ParentArrayOfCustomBaseClassProperty == null)
                {
                    actual.ParentArrayOfCustomBaseClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfCustomBaseClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfCustomBaseClassProperty);
                }

                if (systemUnderTest.ParentArrayOfCustomGenericClassOfCustomClassProperty == null)
                {
                    actual.ParentArrayOfCustomGenericClassOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfCustomGenericClassOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfCustomGenericClassOfCustomClassProperty);
                }

                if (systemUnderTest.Child2ArrayOfBoolProperty == null)
                {
                    actual.Child2ArrayOfBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ArrayOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfBoolProperty);
                }

                if (systemUnderTest.Child2ArrayOfIntProperty == null)
                {
                    actual.Child2ArrayOfIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ArrayOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfIntProperty);
                }

                if (systemUnderTest.Child2ArrayOfStringProperty == null)
                {
                    actual.Child2ArrayOfStringProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ArrayOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfStringProperty);
                }

                if (systemUnderTest.Child2ArrayOfGuidProperty == null)
                {
                    actual.Child2ArrayOfGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ArrayOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfGuidProperty);
                }

                if (systemUnderTest.Child2ArrayOfDateTimeProperty == null)
                {
                    actual.Child2ArrayOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ArrayOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfDateTimeProperty);
                }

                if (systemUnderTest.Child2ArrayOfCustomEnumProperty == null)
                {
                    actual.Child2ArrayOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ArrayOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfCustomEnumProperty);
                }

                if (systemUnderTest.Child2ArrayOfCustomFlagsEnumProperty == null)
                {
                    actual.Child2ArrayOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ArrayOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.Child2ArrayOfCustomClassProperty == null)
                {
                    actual.Child2ArrayOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ArrayOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfCustomClassProperty);
                }

                if (systemUnderTest.Child2ArrayOfCustomBaseClassProperty == null)
                {
                    actual.Child2ArrayOfCustomBaseClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ArrayOfCustomBaseClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfCustomBaseClassProperty);
                }

                if (systemUnderTest.Child2ArrayOfCustomGenericClassOfCustomClassProperty == null)
                {
                    actual.Child2ArrayOfCustomGenericClassOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child2ArrayOfCustomGenericClassOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfCustomGenericClassOfCustomClassProperty);
                }
            }
        }
    }
}