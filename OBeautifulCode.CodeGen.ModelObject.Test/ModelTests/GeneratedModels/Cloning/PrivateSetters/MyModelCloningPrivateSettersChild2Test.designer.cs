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

    public static partial class MyModelCloningPrivateSettersChild2Test
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
            public static void MyModelCloningPrivateSettersChild2___Should_implement_IDeepCloneable_of_MyModelCloningPrivateSettersChild2___When_reflecting()
            {
                // Arrange
                var type = typeof(MyModelCloningPrivateSettersChild2);

                var expectedModelMethods = typeof(IDeepCloneable<MyModelCloningPrivateSettersChild2>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<MyModelCloningPrivateSettersChild2>));
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
                var systemUnderTest = A.Dummy<MyModelCloningPrivateSettersChild2>();

                // Act
                var actual = (MyModelCloningPrivateSettersChild2)systemUnderTest.Clone();

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
                var systemUnderTest = A.Dummy<MyModelCloningPrivateSettersChild2>();

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
                actual.Child2ModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ModelClassProperty);
                actual.Child2ArrayOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfBoolProperty);
                actual.Child2ArrayOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfIntProperty);
                actual.Child2ArrayOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfStringProperty);
                actual.Child2ArrayOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfGuidProperty);
                actual.Child2ArrayOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfDateTimeProperty);
                actual.Child2ArrayOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfModelEnumProperty);
                actual.Child2ArrayOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfModelFlagsEnumProperty);
                actual.Child2ArrayOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfModelClassProperty);
                actual.Child2ArrayOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfNullableBoolProperty);
                actual.Child2ArrayOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfNullableIntProperty);
                actual.Child2ArrayOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfNullableGuidProperty);
                actual.Child2ArrayOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfNullableDateTimeProperty);
                actual.Child2ArrayOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfNullableModelEnumProperty);
                actual.Child2ArrayOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ArrayOfNullableModelFlagsEnumProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfBoolProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfIntProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfStringProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfGuidProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfDateTimeProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfModelEnumProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfModelClassProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfNullableBoolProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfNullableIntProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfNullableGuidProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfNullableDateTimeProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfNullableModelEnumProperty);
                actual.Child2ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty);
                actual.Child2ReadOnlyListInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfBoolProperty);
                actual.Child2ReadOnlyListInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfIntProperty);
                actual.Child2ReadOnlyListInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfStringProperty);
                actual.Child2ReadOnlyListInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfGuidProperty);
                actual.Child2ReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child2ReadOnlyListInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfModelEnumProperty);
                actual.Child2ReadOnlyListInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfModelFlagsEnumProperty);
                actual.Child2ReadOnlyListInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfModelClassProperty);
                actual.Child2ReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfNullableBoolProperty);
                actual.Child2ReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfNullableIntProperty);
                actual.Child2ReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfNullableGuidProperty);
                actual.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty);
                actual.Child2ReadOnlyListInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfNullableModelEnumProperty);
                actual.Child2ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfBoolProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfIntProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfStringProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfGuidProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfModelEnumProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfModelClassProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfNullableIntProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty);
                actual.Child2CollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2CollectionInterfaceOfStringProperty);
                actual.Child2CollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2CollectionOfCollectionInterfaceOfStringProperty);
                actual.Child2ListInterfaceOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ListInterfaceOfCollectionInterfaceOfStringProperty);
                actual.Child2ListOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ListOfCollectionInterfaceOfStringProperty);
                actual.Child2ReadOnlyCollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyCollectionOfCollectionInterfaceOfStringProperty);
                actual.Child2DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child2DictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2DictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child2ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child2ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child2ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.Child2ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.Child2ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
            }
        }
    }
}