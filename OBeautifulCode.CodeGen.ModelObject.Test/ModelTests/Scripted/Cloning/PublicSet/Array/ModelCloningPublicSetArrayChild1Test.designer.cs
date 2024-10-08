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

    public static partial class ModelCloningPublicSetArrayChild1Test
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
            public static void ModelCloningPublicSetArrayChild1___Should_implement_IDeepCloneable_of_ModelCloningPublicSetArrayChild1___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetArrayChild1);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPublicSetArrayChild1>).GetInterfaceDeclaredAndImplementedMethods();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethodsFiltered(MemberRelationships.DeclaredOrInherited, MemberOwners.Instance, MemberAccessModifiers.Public).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPublicSetArrayChild1>));
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
            public static void ModelCloningPublicSetArrayChild1___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPublicSetArrayChild1);

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetArrayChild1>();

                // Act
                var actual = (ModelCloningPublicSetArrayChild1)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPublicSetArrayChild1>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

                if (systemUnderTest.ParentArrayOfBoolProperty == null)
                {
                    actual.ParentArrayOfBoolProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentArrayOfBoolProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentArrayOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfBoolProperty);
                }

                if (systemUnderTest.ParentArrayOfIntProperty == null)
                {
                    actual.ParentArrayOfIntProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentArrayOfIntProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentArrayOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfIntProperty);
                }

                if (systemUnderTest.ParentArrayOfStringProperty == null)
                {
                    actual.ParentArrayOfStringProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentArrayOfStringProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentArrayOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfStringProperty);
                }

                if (systemUnderTest.ParentArrayOfGuidProperty == null)
                {
                    actual.ParentArrayOfGuidProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentArrayOfGuidProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentArrayOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfGuidProperty);
                }

                if (systemUnderTest.ParentArrayOfDateTimeProperty == null)
                {
                    actual.ParentArrayOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentArrayOfDateTimeProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentArrayOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfDateTimeProperty);
                }

                if (systemUnderTest.ParentArrayOfCustomEnumProperty == null)
                {
                    actual.ParentArrayOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentArrayOfCustomEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentArrayOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfCustomEnumProperty);
                }

                if (systemUnderTest.ParentArrayOfCustomFlagsEnumProperty == null)
                {
                    actual.ParentArrayOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentArrayOfCustomFlagsEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentArrayOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.ParentArrayOfCustomClassProperty == null)
                {
                    actual.ParentArrayOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentArrayOfCustomClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentArrayOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfCustomClassProperty);
                }

                if (systemUnderTest.ParentArrayOfCustomBaseClassProperty == null)
                {
                    actual.ParentArrayOfCustomBaseClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentArrayOfCustomBaseClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentArrayOfCustomBaseClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfCustomBaseClassProperty);
                }

                if (systemUnderTest.ParentArrayOfCustomGenericClassOfCustomClassProperty == null)
                {
                    actual.ParentArrayOfCustomGenericClassOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentArrayOfCustomGenericClassOfCustomClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentArrayOfCustomGenericClassOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfCustomGenericClassOfCustomClassProperty);
                }

                if (systemUnderTest.Child1ArrayOfBoolProperty == null)
                {
                    actual.Child1ArrayOfBoolProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ArrayOfBoolProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ArrayOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfBoolProperty);
                }

                if (systemUnderTest.Child1ArrayOfIntProperty == null)
                {
                    actual.Child1ArrayOfIntProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ArrayOfIntProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ArrayOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfIntProperty);
                }

                if (systemUnderTest.Child1ArrayOfStringProperty == null)
                {
                    actual.Child1ArrayOfStringProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ArrayOfStringProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ArrayOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfStringProperty);
                }

                if (systemUnderTest.Child1ArrayOfGuidProperty == null)
                {
                    actual.Child1ArrayOfGuidProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ArrayOfGuidProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ArrayOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfGuidProperty);
                }

                if (systemUnderTest.Child1ArrayOfDateTimeProperty == null)
                {
                    actual.Child1ArrayOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ArrayOfDateTimeProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ArrayOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfDateTimeProperty);
                }

                if (systemUnderTest.Child1ArrayOfCustomEnumProperty == null)
                {
                    actual.Child1ArrayOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ArrayOfCustomEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ArrayOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfCustomEnumProperty);
                }

                if (systemUnderTest.Child1ArrayOfCustomFlagsEnumProperty == null)
                {
                    actual.Child1ArrayOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ArrayOfCustomFlagsEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ArrayOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.Child1ArrayOfCustomClassProperty == null)
                {
                    actual.Child1ArrayOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ArrayOfCustomClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ArrayOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfCustomClassProperty);
                }

                if (systemUnderTest.Child1ArrayOfCustomBaseClassProperty == null)
                {
                    actual.Child1ArrayOfCustomBaseClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ArrayOfCustomBaseClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ArrayOfCustomBaseClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfCustomBaseClassProperty);
                }

                if (systemUnderTest.Child1ArrayOfCustomGenericClassOfCustomClassProperty == null)
                {
                    actual.Child1ArrayOfCustomGenericClassOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ArrayOfCustomGenericClassOfCustomClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ArrayOfCustomGenericClassOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfCustomGenericClassOfCustomClassProperty);
                }
            }
        }
    }
}