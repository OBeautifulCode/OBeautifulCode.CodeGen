// --------------------------------------------------------------------------------------------------------------------
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
    using global::OBeautifulCode.Serialization.Bson;
    using global::OBeautifulCode.Serialization.Json;
    using global::OBeautifulCode.Type;

    using global::Xunit;

    using static global::System.FormattableString;

    public static partial class MyModelCloningPublicSettersChild1Test
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
            public static void MyModelCloningPublicSettersChild1___Should_implement_IDeepCloneable_of_MyModelCloningPublicSettersChild1___When_reflecting()
            {
                // Arrange
                var type = typeof(MyModelCloningPublicSettersChild1);

                var expectedModelMethods = typeof(IDeepCloneable<MyModelCloningPublicSettersChild1>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<MyModelCloningPublicSettersChild1>));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
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
                var systemUnderTest = A.Dummy<MyModelCloningPublicSettersChild1>();

                // Act
                var actual = (MyModelCloningPublicSettersChild1)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<MyModelCloningPublicSettersChild1>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);
                actual.ParentModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentModelClassProperty);
                actual.ParentArrayOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfBoolProperty);
                actual.ParentArrayOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfIntProperty);
                actual.ParentArrayOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfStringProperty);
                actual.ParentArrayOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfGuidProperty);
                actual.ParentArrayOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfDateTimeProperty);
                actual.ParentArrayOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfModelEnumProperty);
                actual.ParentArrayOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfModelFlagsEnumProperty);
                actual.ParentArrayOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfModelClassProperty);
                actual.ParentArrayOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableBoolProperty);
                actual.ParentArrayOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableIntProperty);
                actual.ParentArrayOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableGuidProperty);
                actual.ParentArrayOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableDateTimeProperty);
                actual.ParentArrayOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableModelEnumProperty);
                actual.ParentArrayOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentArrayOfNullableModelFlagsEnumProperty);
                actual.ParentReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfBoolProperty);
                actual.ParentReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfIntProperty);
                actual.ParentReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfStringProperty);
                actual.ParentReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfGuidProperty);
                actual.ParentReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfDateTimeProperty);
                actual.ParentReadOnlyCollectionInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfModelEnumProperty);
                actual.ParentReadOnlyCollectionInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfModelFlagsEnumProperty);
                actual.ParentReadOnlyCollectionInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfModelClassProperty);
                actual.ParentReadOnlyCollectionInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableBoolProperty);
                actual.ParentReadOnlyCollectionInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableIntProperty);
                actual.ParentReadOnlyCollectionInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableGuidProperty);
                actual.ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty);
                actual.ParentReadOnlyCollectionInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableModelEnumProperty);
                actual.ParentReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty);
                actual.ParentReadOnlyListInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfBoolProperty);
                actual.ParentReadOnlyListInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfIntProperty);
                actual.ParentReadOnlyListInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfStringProperty);
                actual.ParentReadOnlyListInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfGuidProperty);
                actual.ParentReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfDateTimeProperty);
                actual.ParentReadOnlyListInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfModelEnumProperty);
                actual.ParentReadOnlyListInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfModelFlagsEnumProperty);
                actual.ParentReadOnlyListInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfModelClassProperty);
                actual.ParentReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableBoolProperty);
                actual.ParentReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableIntProperty);
                actual.ParentReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableGuidProperty);
                actual.ParentReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableDateTimeProperty);
                actual.ParentReadOnlyListInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableModelEnumProperty);
                actual.ParentReadOnlyListInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfNullableModelFlagsEnumProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfBoolProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfIntProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfStringProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfGuidProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfModelEnumProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfModelClassProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfNullableBoolProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfNullableIntProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfNullableGuidProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfNullableModelEnumProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty);
                actual.ParentCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentCollectionInterfaceOfStringProperty);
                actual.ParentCollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentCollectionOfCollectionInterfaceOfStringProperty);
                actual.ParentListInterfaceOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentListInterfaceOfCollectionInterfaceOfStringProperty);
                actual.ParentListOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentListOfCollectionInterfaceOfStringProperty);
                actual.ParentReadOnlyCollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyCollectionOfCollectionInterfaceOfStringProperty);
                actual.ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.ParentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.ParentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.ParentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child1ModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ModelClassProperty);
                actual.Child1ArrayOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfBoolProperty);
                actual.Child1ArrayOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfIntProperty);
                actual.Child1ArrayOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfStringProperty);
                actual.Child1ArrayOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfGuidProperty);
                actual.Child1ArrayOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfDateTimeProperty);
                actual.Child1ArrayOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfModelEnumProperty);
                actual.Child1ArrayOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfModelFlagsEnumProperty);
                actual.Child1ArrayOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfModelClassProperty);
                actual.Child1ArrayOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableBoolProperty);
                actual.Child1ArrayOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableIntProperty);
                actual.Child1ArrayOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableGuidProperty);
                actual.Child1ArrayOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableDateTimeProperty);
                actual.Child1ArrayOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableModelEnumProperty);
                actual.Child1ArrayOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ArrayOfNullableModelFlagsEnumProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfBoolProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfIntProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfStringProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfGuidProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfModelEnumProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfModelClassProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableIntProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableModelEnumProperty);
                actual.Child1ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty);
                actual.Child1ReadOnlyListInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfBoolProperty);
                actual.Child1ReadOnlyListInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfIntProperty);
                actual.Child1ReadOnlyListInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfStringProperty);
                actual.Child1ReadOnlyListInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfGuidProperty);
                actual.Child1ReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child1ReadOnlyListInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfModelEnumProperty);
                actual.Child1ReadOnlyListInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfModelFlagsEnumProperty);
                actual.Child1ReadOnlyListInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfModelClassProperty);
                actual.Child1ReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableBoolProperty);
                actual.Child1ReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableIntProperty);
                actual.Child1ReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableGuidProperty);
                actual.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty);
                actual.Child1ReadOnlyListInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableModelEnumProperty);
                actual.Child1ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfBoolProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfIntProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfStringProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfGuidProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfModelEnumProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfModelClassProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfNullableBoolProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfNullableIntProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfNullableGuidProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty);
                actual.Child1CollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1CollectionInterfaceOfStringProperty);
                actual.Child1CollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1CollectionOfCollectionInterfaceOfStringProperty);
                actual.Child1ListInterfaceOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ListInterfaceOfCollectionInterfaceOfStringProperty);
                actual.Child1ListOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ListOfCollectionInterfaceOfStringProperty);
                actual.Child1ReadOnlyCollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyCollectionOfCollectionInterfaceOfStringProperty);
                actual.Child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child1DictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1DictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child1ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child1ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
            }
        }
    }
}