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

    public static partial class ModelCloningPrivateSetReadOnlyCollectionChild1Test
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
            public static void ModelCloningPrivateSetReadOnlyCollectionChild1___Should_implement_IDeepCloneable_of_ModelCloningPrivateSetReadOnlyCollectionChild1___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPrivateSetReadOnlyCollectionChild1);

                var expectedModelMethods = typeof(IDeepCloneable<ModelCloningPrivateSetReadOnlyCollectionChild1>).GetInterfaceDeclaredAndImplementedMethods();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethodsFiltered(MemberRelationships.DeclaredOrInherited, MemberOwners.Instance, MemberAccessModifiers.Public).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<ModelCloningPrivateSetReadOnlyCollectionChild1>));
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
            public static void ModelCloningPrivateSetReadOnlyCollectionChild1___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelCloningPrivateSetReadOnlyCollectionChild1);

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
                var systemUnderTest = A.Dummy<ModelCloningPrivateSetReadOnlyCollectionChild1>();

                // Act
                var actual = (ModelCloningPrivateSetReadOnlyCollectionChild1)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<ModelCloningPrivateSetReadOnlyCollectionChild1>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfBoolProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfBoolProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfBoolProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfIntProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfIntProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfIntProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfStringProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfStringProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfGuidProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfGuidProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfGuidProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfDateTimeProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfDateTimeProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomClassProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfCustomClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomClassProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty);
                }

                if (systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty == null)
                {
                    actual.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfBoolProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfBoolProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfBoolProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfIntProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfIntProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfIntProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfStringProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfStringProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfStringProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfGuidProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfGuidProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfGuidProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfCustomClassProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfCustomClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfCustomClassProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfCustomBaseClassProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfCustomBaseClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfCustomBaseClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfCustomBaseClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfCustomBaseClassProperty);
                }

                if (systemUnderTest.Child1ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty == null)
                {
                    actual.Child1ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().BeNull();
                }
                else if (!actual.Child1ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.GetType().IsValueType)
                {
                    // When the declared type is a reference type, we still have to check the runtime type.
                    // The object could be a boxed value type, which will fail this asseration because
                    // a deep clone of a value type object is the same object.
                    actual.Child1ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty);
                }
            }
        }
    }
}