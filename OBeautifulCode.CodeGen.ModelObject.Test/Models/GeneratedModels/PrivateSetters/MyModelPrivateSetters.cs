// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSetters.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest.GenerateModel()
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class MyModelPrivateSetters : IModelViaCodeGen
    {
        public MyModelPrivateSetters(
            bool boolProperty,
            int intProperty,
            string stringProperty,
            Guid guidProperty,
            DateTime dateTimeProperty,
            ModelEnum modelEnumProperty,
            ModelFlagsEnum modelFlagsEnumProperty,
            ModelStruct modelStructProperty,
            ModelClass modelClassProperty,
            bool? nullableBoolProperty,
            int? nullableIntProperty,
            Guid? nullableGuidProperty,
            DateTime? nullableDateTimeProperty,
            ModelEnum? nullableModelEnumProperty,
            ModelFlagsEnum? nullableModelFlagsEnumProperty,
            ModelStruct? nullableModelStructProperty,
            bool[] arrayOfBoolProperty,
            int[] arrayOfIntProperty,
            string[] arrayOfStringProperty,
            Guid[] arrayOfGuidProperty,
            DateTime[] arrayOfDateTimeProperty,
            ModelEnum[] arrayOfModelEnumProperty,
            ModelFlagsEnum[] arrayOfModelFlagsEnumProperty,
            ModelStruct[] arrayOfModelStructProperty,
            ModelClass[] arrayOfModelClassProperty,
            bool?[] arrayOfNullableBoolProperty,
            int?[] arrayOfNullableIntProperty,
            Guid?[] arrayOfNullableGuidProperty,
            DateTime?[] arrayOfNullableDateTimeProperty,
            ModelEnum?[] arrayOfNullableModelEnumProperty,
            ModelFlagsEnum?[] arrayOfNullableModelFlagsEnumProperty,
            ModelStruct?[] arrayOfNullableModelStructProperty,
            IReadOnlyCollection<bool> readOnlyCollectionOfBoolProperty,
            IReadOnlyCollection<int> readOnlyCollectionOfIntProperty,
            IReadOnlyCollection<string> readOnlyCollectionOfStringProperty,
            IReadOnlyCollection<Guid> readOnlyCollectionOfGuidProperty,
            IReadOnlyCollection<DateTime> readOnlyCollectionOfDateTimeProperty,
            IReadOnlyCollection<ModelEnum> readOnlyCollectionOfModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum> readOnlyCollectionOfModelFlagsEnumProperty,
            IReadOnlyCollection<ModelStruct> readOnlyCollectionOfModelStructProperty,
            IReadOnlyCollection<ModelClass> readOnlyCollectionOfModelClassProperty,
            IReadOnlyCollection<bool?> readOnlyCollectionOfNullableBoolProperty,
            IReadOnlyCollection<int?> readOnlyCollectionOfNullableIntProperty,
            IReadOnlyCollection<Guid?> readOnlyCollectionOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> readOnlyCollectionOfNullableDateTimeProperty,
            IReadOnlyCollection<ModelEnum?> readOnlyCollectionOfNullableModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum?> readOnlyCollectionOfNullableModelFlagsEnumProperty,
            IReadOnlyCollection<ModelStruct?> readOnlyCollectionOfNullableModelStructProperty,
            IReadOnlyList<bool> readOnlyListOfBoolProperty,
            IReadOnlyList<int> readOnlyListOfIntProperty,
            IReadOnlyList<string> readOnlyListOfStringProperty,
            IReadOnlyList<Guid> readOnlyListOfGuidProperty,
            IReadOnlyList<DateTime> readOnlyListOfDateTimeProperty,
            IReadOnlyList<ModelEnum> readOnlyListOfModelEnumProperty,
            IReadOnlyList<ModelFlagsEnum> readOnlyListOfModelFlagsEnumProperty,
            IReadOnlyList<ModelStruct> readOnlyListOfModelStructProperty,
            IReadOnlyList<ModelClass> readOnlyListOfModelClassProperty,
            IReadOnlyList<bool?> readOnlyListOfNullableBoolProperty,
            IReadOnlyList<int?> readOnlyListOfNullableIntProperty,
            IReadOnlyList<Guid?> readOnlyListOfNullableGuidProperty,
            IReadOnlyList<DateTime?> readOnlyListOfNullableDateTimeProperty,
            IReadOnlyList<ModelEnum?> readOnlyListOfNullableModelEnumProperty,
            IReadOnlyList<ModelFlagsEnum?> readOnlyListOfNullableModelFlagsEnumProperty,
            IReadOnlyList<ModelStruct?> readOnlyListOfNullableModelStructProperty,
            IReadOnlyDictionary<bool, bool> readOnlyDictionaryOfBoolProperty,
            IReadOnlyDictionary<int, int> readOnlyDictionaryOfIntProperty,
            IReadOnlyDictionary<string, string> readOnlyDictionaryOfStringProperty,
            IReadOnlyDictionary<Guid, Guid> readOnlyDictionaryOfGuidProperty,
            IReadOnlyDictionary<DateTime, DateTime> readOnlyDictionaryOfDateTimeProperty,
            IReadOnlyDictionary<ModelEnum, ModelEnum> readOnlyDictionaryOfModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> readOnlyDictionaryOfModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelStruct, ModelStruct> readOnlyDictionaryOfModelStructProperty,
            IReadOnlyDictionary<ModelClass, ModelClass> readOnlyDictionaryOfModelClassProperty,
            IReadOnlyDictionary<bool?, bool?> readOnlyDictionaryOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> readOnlyDictionaryOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> readOnlyDictionaryOfNullableGuidProperty,
            IReadOnlyDictionary<DateTime?, DateTime?> readOnlyDictionaryOfNullableDateTimeProperty,
            IReadOnlyDictionary<ModelEnum?, ModelEnum?> readOnlyDictionaryOfNullableModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> readOnlyDictionaryOfNullableModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelStruct?, ModelStruct?> readOnlyDictionaryOfNullableModelStructProperty,
            IReadOnlyList<IReadOnlyList<string>> readOnlyListOfReadOnlyListOfStringProperty,
            IReadOnlyList<ICollection<string>> readOnlyListOfCollectionOfStringProperty,
            ICollection<IReadOnlyList<ICollection<string>>> collectionOfReadOnlyListOfCollectionOfStringProperty,
            IReadOnlyDictionary<string, IReadOnlyDictionary<DateTime, IReadOnlyDictionary<ModelClass, IReadOnlyList<string>>>> readOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty,
            IReadOnlyList<IReadOnlyDictionary<DateTime, IReadOnlyList<string>>> readOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty)
        {
            new { stringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { modelClassProperty }.AsArg().Must().NotBeNull();
            new { arrayOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { arrayOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfModelStructProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfModelClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { arrayOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfNullableModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfNullableModelStructProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyCollectionOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfModelStructProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfModelClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyCollectionOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfNullableModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionOfNullableModelStructProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyListOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfModelStructProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfModelClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyListOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfNullableModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListOfNullableModelStructProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyDictionaryOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfStringProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { readOnlyDictionaryOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfModelStructProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfModelClassProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { readOnlyDictionaryOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfNullableModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryOfNullableModelStructProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyListOfReadOnlyListOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyListOfCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { collectionOfReadOnlyListOfCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { readOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.BoolProperty = boolProperty;
            this.IntProperty = intProperty;
            this.StringProperty = stringProperty;
            this.GuidProperty = guidProperty;
            this.DateTimeProperty = dateTimeProperty;
            this.ModelEnumProperty = modelEnumProperty;
            this.ModelFlagsEnumProperty = modelFlagsEnumProperty;
            this.ModelStructProperty = modelStructProperty;
            this.ModelClassProperty = modelClassProperty;
            this.NullableBoolProperty = nullableBoolProperty;
            this.NullableIntProperty = nullableIntProperty;
            this.NullableGuidProperty = nullableGuidProperty;
            this.NullableDateTimeProperty = nullableDateTimeProperty;
            this.NullableModelEnumProperty = nullableModelEnumProperty;
            this.NullableModelFlagsEnumProperty = nullableModelFlagsEnumProperty;
            this.NullableModelStructProperty = nullableModelStructProperty;
            this.ArrayOfBoolProperty = arrayOfBoolProperty;
            this.ArrayOfIntProperty = arrayOfIntProperty;
            this.ArrayOfStringProperty = arrayOfStringProperty;
            this.ArrayOfGuidProperty = arrayOfGuidProperty;
            this.ArrayOfDateTimeProperty = arrayOfDateTimeProperty;
            this.ArrayOfModelEnumProperty = arrayOfModelEnumProperty;
            this.ArrayOfModelFlagsEnumProperty = arrayOfModelFlagsEnumProperty;
            this.ArrayOfModelStructProperty = arrayOfModelStructProperty;
            this.ArrayOfModelClassProperty = arrayOfModelClassProperty;
            this.ArrayOfNullableBoolProperty = arrayOfNullableBoolProperty;
            this.ArrayOfNullableIntProperty = arrayOfNullableIntProperty;
            this.ArrayOfNullableGuidProperty = arrayOfNullableGuidProperty;
            this.ArrayOfNullableDateTimeProperty = arrayOfNullableDateTimeProperty;
            this.ArrayOfNullableModelEnumProperty = arrayOfNullableModelEnumProperty;
            this.ArrayOfNullableModelFlagsEnumProperty = arrayOfNullableModelFlagsEnumProperty;
            this.ArrayOfNullableModelStructProperty = arrayOfNullableModelStructProperty;
            this.ReadOnlyCollectionOfBoolProperty = readOnlyCollectionOfBoolProperty;
            this.ReadOnlyCollectionOfIntProperty = readOnlyCollectionOfIntProperty;
            this.ReadOnlyCollectionOfStringProperty = readOnlyCollectionOfStringProperty;
            this.ReadOnlyCollectionOfGuidProperty = readOnlyCollectionOfGuidProperty;
            this.ReadOnlyCollectionOfDateTimeProperty = readOnlyCollectionOfDateTimeProperty;
            this.ReadOnlyCollectionOfModelEnumProperty = readOnlyCollectionOfModelEnumProperty;
            this.ReadOnlyCollectionOfModelFlagsEnumProperty = readOnlyCollectionOfModelFlagsEnumProperty;
            this.ReadOnlyCollectionOfModelStructProperty = readOnlyCollectionOfModelStructProperty;
            this.ReadOnlyCollectionOfModelClassProperty = readOnlyCollectionOfModelClassProperty;
            this.ReadOnlyCollectionOfNullableBoolProperty = readOnlyCollectionOfNullableBoolProperty;
            this.ReadOnlyCollectionOfNullableIntProperty = readOnlyCollectionOfNullableIntProperty;
            this.ReadOnlyCollectionOfNullableGuidProperty = readOnlyCollectionOfNullableGuidProperty;
            this.ReadOnlyCollectionOfNullableDateTimeProperty = readOnlyCollectionOfNullableDateTimeProperty;
            this.ReadOnlyCollectionOfNullableModelEnumProperty = readOnlyCollectionOfNullableModelEnumProperty;
            this.ReadOnlyCollectionOfNullableModelFlagsEnumProperty = readOnlyCollectionOfNullableModelFlagsEnumProperty;
            this.ReadOnlyCollectionOfNullableModelStructProperty = readOnlyCollectionOfNullableModelStructProperty;
            this.ReadOnlyListOfBoolProperty = readOnlyListOfBoolProperty;
            this.ReadOnlyListOfIntProperty = readOnlyListOfIntProperty;
            this.ReadOnlyListOfStringProperty = readOnlyListOfStringProperty;
            this.ReadOnlyListOfGuidProperty = readOnlyListOfGuidProperty;
            this.ReadOnlyListOfDateTimeProperty = readOnlyListOfDateTimeProperty;
            this.ReadOnlyListOfModelEnumProperty = readOnlyListOfModelEnumProperty;
            this.ReadOnlyListOfModelFlagsEnumProperty = readOnlyListOfModelFlagsEnumProperty;
            this.ReadOnlyListOfModelStructProperty = readOnlyListOfModelStructProperty;
            this.ReadOnlyListOfModelClassProperty = readOnlyListOfModelClassProperty;
            this.ReadOnlyListOfNullableBoolProperty = readOnlyListOfNullableBoolProperty;
            this.ReadOnlyListOfNullableIntProperty = readOnlyListOfNullableIntProperty;
            this.ReadOnlyListOfNullableGuidProperty = readOnlyListOfNullableGuidProperty;
            this.ReadOnlyListOfNullableDateTimeProperty = readOnlyListOfNullableDateTimeProperty;
            this.ReadOnlyListOfNullableModelEnumProperty = readOnlyListOfNullableModelEnumProperty;
            this.ReadOnlyListOfNullableModelFlagsEnumProperty = readOnlyListOfNullableModelFlagsEnumProperty;
            this.ReadOnlyListOfNullableModelStructProperty = readOnlyListOfNullableModelStructProperty;
            this.ReadOnlyDictionaryOfBoolProperty = readOnlyDictionaryOfBoolProperty;
            this.ReadOnlyDictionaryOfIntProperty = readOnlyDictionaryOfIntProperty;
            this.ReadOnlyDictionaryOfStringProperty = readOnlyDictionaryOfStringProperty;
            this.ReadOnlyDictionaryOfGuidProperty = readOnlyDictionaryOfGuidProperty;
            this.ReadOnlyDictionaryOfDateTimeProperty = readOnlyDictionaryOfDateTimeProperty;
            this.ReadOnlyDictionaryOfModelEnumProperty = readOnlyDictionaryOfModelEnumProperty;
            this.ReadOnlyDictionaryOfModelFlagsEnumProperty = readOnlyDictionaryOfModelFlagsEnumProperty;
            this.ReadOnlyDictionaryOfModelStructProperty = readOnlyDictionaryOfModelStructProperty;
            this.ReadOnlyDictionaryOfModelClassProperty = readOnlyDictionaryOfModelClassProperty;
            this.ReadOnlyDictionaryOfNullableBoolProperty = readOnlyDictionaryOfNullableBoolProperty;
            this.ReadOnlyDictionaryOfNullableIntProperty = readOnlyDictionaryOfNullableIntProperty;
            this.ReadOnlyDictionaryOfNullableGuidProperty = readOnlyDictionaryOfNullableGuidProperty;
            this.ReadOnlyDictionaryOfNullableDateTimeProperty = readOnlyDictionaryOfNullableDateTimeProperty;
            this.ReadOnlyDictionaryOfNullableModelEnumProperty = readOnlyDictionaryOfNullableModelEnumProperty;
            this.ReadOnlyDictionaryOfNullableModelFlagsEnumProperty = readOnlyDictionaryOfNullableModelFlagsEnumProperty;
            this.ReadOnlyDictionaryOfNullableModelStructProperty = readOnlyDictionaryOfNullableModelStructProperty;
            this.ReadOnlyListOfReadOnlyListOfStringProperty = readOnlyListOfReadOnlyListOfStringProperty;
            this.ReadOnlyListOfCollectionOfStringProperty = readOnlyListOfCollectionOfStringProperty;
            this.CollectionOfReadOnlyListOfCollectionOfStringProperty = collectionOfReadOnlyListOfCollectionOfStringProperty;
            this.ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty = readOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty;
            this.ReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty = readOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty;
        }

        public bool BoolProperty { get; private set; }

        public int IntProperty { get; private set; }

        public string StringProperty { get; private set; }

        public Guid GuidProperty { get; private set; }

        public DateTime DateTimeProperty { get; private set; }

        public ModelEnum ModelEnumProperty { get; private set; }

        public ModelFlagsEnum ModelFlagsEnumProperty { get; private set; }

        public ModelStruct ModelStructProperty { get; private set; }

        public ModelClass ModelClassProperty { get; private set; }

        public bool? NullableBoolProperty { get; private set; }

        public int? NullableIntProperty { get; private set; }

        public Guid? NullableGuidProperty { get; private set; }

        public DateTime? NullableDateTimeProperty { get; private set; }

        public ModelEnum? NullableModelEnumProperty { get; private set; }

        public ModelFlagsEnum? NullableModelFlagsEnumProperty { get; private set; }

        public ModelStruct? NullableModelStructProperty { get; private set; }

        public bool[] ArrayOfBoolProperty { get; private set; }

        public int[] ArrayOfIntProperty { get; private set; }

        public string[] ArrayOfStringProperty { get; private set; }

        public Guid[] ArrayOfGuidProperty { get; private set; }

        public DateTime[] ArrayOfDateTimeProperty { get; private set; }

        public ModelEnum[] ArrayOfModelEnumProperty { get; private set; }

        public ModelFlagsEnum[] ArrayOfModelFlagsEnumProperty { get; private set; }

        public ModelStruct[] ArrayOfModelStructProperty { get; private set; }

        public ModelClass[] ArrayOfModelClassProperty { get; private set; }

        public bool?[] ArrayOfNullableBoolProperty { get; private set; }

        public int?[] ArrayOfNullableIntProperty { get; private set; }

        public Guid?[] ArrayOfNullableGuidProperty { get; private set; }

        public DateTime?[] ArrayOfNullableDateTimeProperty { get; private set; }

        public ModelEnum?[] ArrayOfNullableModelEnumProperty { get; private set; }

        public ModelFlagsEnum?[] ArrayOfNullableModelFlagsEnumProperty { get; private set; }

        public ModelStruct?[] ArrayOfNullableModelStructProperty { get; private set; }

        public IReadOnlyCollection<bool> ReadOnlyCollectionOfBoolProperty { get; private set; }

        public IReadOnlyCollection<int> ReadOnlyCollectionOfIntProperty { get; private set; }

        public IReadOnlyCollection<string> ReadOnlyCollectionOfStringProperty { get; private set; }

        public IReadOnlyCollection<Guid> ReadOnlyCollectionOfGuidProperty { get; private set; }

        public IReadOnlyCollection<DateTime> ReadOnlyCollectionOfDateTimeProperty { get; private set; }

        public IReadOnlyCollection<ModelEnum> ReadOnlyCollectionOfModelEnumProperty { get; private set; }

        public IReadOnlyCollection<ModelFlagsEnum> ReadOnlyCollectionOfModelFlagsEnumProperty { get; private set; }

        public IReadOnlyCollection<ModelStruct> ReadOnlyCollectionOfModelStructProperty { get; private set; }

        public IReadOnlyCollection<ModelClass> ReadOnlyCollectionOfModelClassProperty { get; private set; }

        public IReadOnlyCollection<bool?> ReadOnlyCollectionOfNullableBoolProperty { get; private set; }

        public IReadOnlyCollection<int?> ReadOnlyCollectionOfNullableIntProperty { get; private set; }

        public IReadOnlyCollection<Guid?> ReadOnlyCollectionOfNullableGuidProperty { get; private set; }

        public IReadOnlyCollection<DateTime?> ReadOnlyCollectionOfNullableDateTimeProperty { get; private set; }

        public IReadOnlyCollection<ModelEnum?> ReadOnlyCollectionOfNullableModelEnumProperty { get; private set; }

        public IReadOnlyCollection<ModelFlagsEnum?> ReadOnlyCollectionOfNullableModelFlagsEnumProperty { get; private set; }

        public IReadOnlyCollection<ModelStruct?> ReadOnlyCollectionOfNullableModelStructProperty { get; private set; }

        public IReadOnlyList<bool> ReadOnlyListOfBoolProperty { get; private set; }

        public IReadOnlyList<int> ReadOnlyListOfIntProperty { get; private set; }

        public IReadOnlyList<string> ReadOnlyListOfStringProperty { get; private set; }

        public IReadOnlyList<Guid> ReadOnlyListOfGuidProperty { get; private set; }

        public IReadOnlyList<DateTime> ReadOnlyListOfDateTimeProperty { get; private set; }

        public IReadOnlyList<ModelEnum> ReadOnlyListOfModelEnumProperty { get; private set; }

        public IReadOnlyList<ModelFlagsEnum> ReadOnlyListOfModelFlagsEnumProperty { get; private set; }

        public IReadOnlyList<ModelStruct> ReadOnlyListOfModelStructProperty { get; private set; }

        public IReadOnlyList<ModelClass> ReadOnlyListOfModelClassProperty { get; private set; }

        public IReadOnlyList<bool?> ReadOnlyListOfNullableBoolProperty { get; private set; }

        public IReadOnlyList<int?> ReadOnlyListOfNullableIntProperty { get; private set; }

        public IReadOnlyList<Guid?> ReadOnlyListOfNullableGuidProperty { get; private set; }

        public IReadOnlyList<DateTime?> ReadOnlyListOfNullableDateTimeProperty { get; private set; }

        public IReadOnlyList<ModelEnum?> ReadOnlyListOfNullableModelEnumProperty { get; private set; }

        public IReadOnlyList<ModelFlagsEnum?> ReadOnlyListOfNullableModelFlagsEnumProperty { get; private set; }

        public IReadOnlyList<ModelStruct?> ReadOnlyListOfNullableModelStructProperty { get; private set; }

        public IReadOnlyDictionary<bool, bool> ReadOnlyDictionaryOfBoolProperty { get; private set; }

        public IReadOnlyDictionary<int, int> ReadOnlyDictionaryOfIntProperty { get; private set; }

        public IReadOnlyDictionary<string, string> ReadOnlyDictionaryOfStringProperty { get; private set; }

        public IReadOnlyDictionary<Guid, Guid> ReadOnlyDictionaryOfGuidProperty { get; private set; }

        public IReadOnlyDictionary<DateTime, DateTime> ReadOnlyDictionaryOfDateTimeProperty { get; private set; }

        public IReadOnlyDictionary<ModelEnum, ModelEnum> ReadOnlyDictionaryOfModelEnumProperty { get; private set; }

        public IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> ReadOnlyDictionaryOfModelFlagsEnumProperty { get; private set; }

        public IReadOnlyDictionary<ModelStruct, ModelStruct> ReadOnlyDictionaryOfModelStructProperty { get; private set; }

        public IReadOnlyDictionary<ModelClass, ModelClass> ReadOnlyDictionaryOfModelClassProperty { get; private set; }

        public IReadOnlyDictionary<bool?, bool?> ReadOnlyDictionaryOfNullableBoolProperty { get; private set; }

        public IReadOnlyDictionary<int?, int?> ReadOnlyDictionaryOfNullableIntProperty { get; private set; }

        public IReadOnlyDictionary<Guid?, Guid?> ReadOnlyDictionaryOfNullableGuidProperty { get; private set; }

        public IReadOnlyDictionary<DateTime?, DateTime?> ReadOnlyDictionaryOfNullableDateTimeProperty { get; private set; }

        public IReadOnlyDictionary<ModelEnum?, ModelEnum?> ReadOnlyDictionaryOfNullableModelEnumProperty { get; private set; }

        public IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> ReadOnlyDictionaryOfNullableModelFlagsEnumProperty { get; private set; }

        public IReadOnlyDictionary<ModelStruct?, ModelStruct?> ReadOnlyDictionaryOfNullableModelStructProperty { get; private set; }

        public IReadOnlyList<IReadOnlyList<string>> ReadOnlyListOfReadOnlyListOfStringProperty { get; private set; }

        public IReadOnlyList<ICollection<string>> ReadOnlyListOfCollectionOfStringProperty { get; private set; }

        public ICollection<IReadOnlyList<ICollection<string>>> CollectionOfReadOnlyListOfCollectionOfStringProperty { get; private set; }

        public IReadOnlyDictionary<string, IReadOnlyDictionary<DateTime, IReadOnlyDictionary<ModelClass, IReadOnlyList<string>>>> ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty { get; private set; }

        public IReadOnlyList<IReadOnlyDictionary<DateTime, IReadOnlyList<string>>> ReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty { get; private set; }
    }
}