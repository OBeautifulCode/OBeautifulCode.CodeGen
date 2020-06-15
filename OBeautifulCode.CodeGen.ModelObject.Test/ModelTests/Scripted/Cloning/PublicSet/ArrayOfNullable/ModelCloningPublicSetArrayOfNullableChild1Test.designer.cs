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

    public static partial class ModelCloningPublicSetArrayOfNullableChild1Test
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
            public static void ModelCloningPublicSetArrayOfNullableChild1___Should_implement_IDeepCloneable_of_ModelCloningPublicSetArrayOfNullableChild1___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetArrayOfNullableChild1);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPublicSetArrayOfNullableChild1>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPublicSetArrayOfNullableChild1>));
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
            public static void ModelCloningPublicSetArrayOfNullableChild1___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetArrayOfNullableChild1);

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetArrayOfNullableChild1>();

                // Act
                var actual = (ModelCloningPublicSetArrayOfNullableChild1)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetArrayOfNullableChild1>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

                if (systemUnderTest.ParentArrayOfNullableBoolProperty == null)
                {
                    actual.ParentArrayOfNullableBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableBoolProperty);
                }

                if (systemUnderTest.ParentArrayOfNullableIntProperty == null)
                {
                    actual.ParentArrayOfNullableIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableIntProperty);
                }

                if (systemUnderTest.ParentArrayOfNullableGuidProperty == null)
                {
                    actual.ParentArrayOfNullableGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableGuidProperty);
                }

                if (systemUnderTest.ParentArrayOfNullableDateTimeProperty == null)
                {
                    actual.ParentArrayOfNullableDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableDateTimeProperty);
                }

                if (systemUnderTest.ParentArrayOfNullableCustomEnumProperty == null)
                {
                    actual.ParentArrayOfNullableCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfNullableCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableCustomEnumProperty);
                }

                if (systemUnderTest.ParentArrayOfNullableCustomFlagsEnumProperty == null)
                {
                    actual.ParentArrayOfNullableCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.ParentArrayOfNullableCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableCustomFlagsEnumProperty);
                }

                if (systemUnderTest.Child1ArrayOfNullableBoolProperty == null)
                {
                    actual.Child1ArrayOfNullableBoolProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ArrayOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableBoolProperty);
                }

                if (systemUnderTest.Child1ArrayOfNullableIntProperty == null)
                {
                    actual.Child1ArrayOfNullableIntProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ArrayOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableIntProperty);
                }

                if (systemUnderTest.Child1ArrayOfNullableGuidProperty == null)
                {
                    actual.Child1ArrayOfNullableGuidProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ArrayOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableGuidProperty);
                }

                if (systemUnderTest.Child1ArrayOfNullableDateTimeProperty == null)
                {
                    actual.Child1ArrayOfNullableDateTimeProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ArrayOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableDateTimeProperty);
                }

                if (systemUnderTest.Child1ArrayOfNullableCustomEnumProperty == null)
                {
                    actual.Child1ArrayOfNullableCustomEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ArrayOfNullableCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableCustomEnumProperty);
                }

                if (systemUnderTest.Child1ArrayOfNullableCustomFlagsEnumProperty == null)
                {
                    actual.Child1ArrayOfNullableCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else
                {
                    actual.Child1ArrayOfNullableCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableCustomFlagsEnumProperty);
                }
            }
        }
    }
}