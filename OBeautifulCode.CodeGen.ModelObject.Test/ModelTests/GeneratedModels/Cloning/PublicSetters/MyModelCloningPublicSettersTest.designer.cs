// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    using FakeItEasy;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Math.Recipes;
    using OBeautifulCode.Representation.System;
    using OBeautifulCode.Serialization;
    using OBeautifulCode.Serialization.Bson;
    using OBeautifulCode.Serialization.Json;
    using OBeautifulCode.Type;

    using Xunit;

    using static System.FormattableString;

    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.0.0")]
    public partial class MyModelCloningPublicSettersTest
    {
        public static class Structural
        {
            [Fact]
            public static void MyModelCloningPublicSetters___Should_implement_IDeepCloneable_of_MyModelCloningPublicSetters___When_reflecting()
            {
                // Arrange
                var type = typeof(MyModelCloningPublicSetters);
                var expectedModelMethods = typeof(IDeepCloneable<MyModelCloningPublicSetters>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();
                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IDeepCloneable<MyModelCloningPublicSetters>));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
            }
        }

        public static class Cloning
        {
            [Fact]
            public static void DeepClone___Should_deep_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<MyModelCloningPublicSetters>();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);
                actual.ModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ModelClassProperty);
                actual.ArrayOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfBoolProperty);
                actual.ArrayOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfIntProperty);
                actual.ArrayOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfStringProperty);
                actual.ArrayOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfGuidProperty);
                actual.ArrayOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfDateTimeProperty);
                actual.ArrayOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfModelEnumProperty);
                actual.ArrayOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfModelFlagsEnumProperty);
                actual.ArrayOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfModelClassProperty);
                actual.ArrayOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableBoolProperty);
                actual.ArrayOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableIntProperty);
                actual.ArrayOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableGuidProperty);
                actual.ArrayOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableDateTimeProperty);
                actual.ArrayOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableModelEnumProperty);
                actual.ArrayOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ArrayOfNullableModelFlagsEnumProperty);
                actual.ReadOnlyCollectionInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfBoolProperty);
                actual.ReadOnlyCollectionInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfIntProperty);
                actual.ReadOnlyCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfStringProperty);
                actual.ReadOnlyCollectionInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfGuidProperty);
                actual.ReadOnlyCollectionInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfDateTimeProperty);
                actual.ReadOnlyCollectionInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfModelEnumProperty);
                actual.ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty);
                actual.ReadOnlyCollectionInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfModelClassProperty);
                actual.ReadOnlyCollectionInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableBoolProperty);
                actual.ReadOnlyCollectionInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableIntProperty);
                actual.ReadOnlyCollectionInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableGuidProperty);
                actual.ReadOnlyCollectionInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableDateTimeProperty);
                actual.ReadOnlyCollectionInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableModelEnumProperty);
                actual.ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty);
                actual.ReadOnlyListInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfBoolProperty);
                actual.ReadOnlyListInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfIntProperty);
                actual.ReadOnlyListInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfStringProperty);
                actual.ReadOnlyListInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfGuidProperty);
                actual.ReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfDateTimeProperty);
                actual.ReadOnlyListInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfModelEnumProperty);
                actual.ReadOnlyListInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfModelFlagsEnumProperty);
                actual.ReadOnlyListInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfModelClassProperty);
                actual.ReadOnlyListInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableBoolProperty);
                actual.ReadOnlyListInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableIntProperty);
                actual.ReadOnlyListInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableGuidProperty);
                actual.ReadOnlyListInterfaceOfNullableDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableDateTimeProperty);
                actual.ReadOnlyListInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableModelEnumProperty);
                actual.ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty);
                actual.ReadOnlyDictionaryInterfaceOfBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfBoolProperty);
                actual.ReadOnlyDictionaryInterfaceOfIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfIntProperty);
                actual.ReadOnlyDictionaryInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfStringProperty);
                actual.ReadOnlyDictionaryInterfaceOfGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfGuidProperty);
                actual.ReadOnlyDictionaryInterfaceOfModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfModelEnumProperty);
                actual.ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty);
                actual.ReadOnlyDictionaryInterfaceOfModelClassProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfModelClassProperty);
                actual.ReadOnlyDictionaryInterfaceOfNullableBoolProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableBoolProperty);
                actual.ReadOnlyDictionaryInterfaceOfNullableIntProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableIntProperty);
                actual.ReadOnlyDictionaryInterfaceOfNullableGuidProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableGuidProperty);
                actual.ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty);
                actual.ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty);
                actual.CollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.CollectionInterfaceOfStringProperty);
                actual.CollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.CollectionOfCollectionInterfaceOfStringProperty);
                actual.ListInterfaceOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ListInterfaceOfCollectionInterfaceOfStringProperty);
                actual.ListOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ListOfCollectionInterfaceOfStringProperty);
                actual.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty);
                actual.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);
                actual.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);
            }
        }
    }
}