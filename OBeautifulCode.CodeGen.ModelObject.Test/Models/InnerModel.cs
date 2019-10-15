// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InnerModel.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Validation.Recipes;

    public class InnerModel
    {
        public InnerModel(
            object objectProperty,
            bool boolProperty,
            int intProperty,
            string stringProperty,
            Guid guidProperty,
            DateTime dateTimeProperty,
            ModelEnum modelEnumProperty,
            ModelFlagsEnum modelFlagsEnumProperty,
            ModelStruct modelStructProperty,
            ModelEquatableStruct modelEquatableStructProperty,
            ModelClass modelClassProperty,
            ModelEquatableClass modelEquatableClassProperty,
            bool? nullableBoolProperty,
            int? nullableIntProperty,
            Guid? nullableGuidProperty,
            DateTime? nullableDateTimeProperty,
            ModelEnum? nullableModelEnumProperty,
            ModelFlagsEnum? nullableModelFlagsEnumProperty,
            ModelStruct? nullableModelStructProperty,
            ModelEquatableStruct? nullableModelEquatableStructProperty,
            object[] arrayOfObjectProperty,
            bool[] arrayOfBoolProperty,
            int[] arrayOfIntProperty,
            string[] arrayOfStringProperty,
            Guid[] arrayOfGuidProperty,
            DateTime[] arrayOfDateTimeProperty,
            ModelEnum[] arrayOfModelEnumProperty,
            ModelFlagsEnum[] arrayOfModelFlagsEnumProperty,
            ModelStruct[] arrayOfModelStructProperty,
            ModelEquatableStruct[] arrayOfModelEquatableStructProperty,
            ModelClass[] arrayOfModelClassProperty,
            ModelEquatableClass[] arrayOfModelEquatableClassProperty,
            bool?[] arrayOfNullableBoolProperty,
            int?[] arrayOfNullableIntProperty,
            Guid?[] arrayOfNullableGuidProperty,
            DateTime?[] arrayOfNullableDateTimeProperty,
            ModelEnum?[] arrayOfNullableModelEnumProperty,
            ModelFlagsEnum?[] arrayOfNullableModelFlagsEnumProperty,
            ModelStruct?[] arrayOfNullableModelStructProperty,
            ModelEquatableStruct?[] arrayOfNullableModelEquatableStructProperty,
            IReadOnlyCollection<object> readOnlyCollectionOfObjectProperty,
            IReadOnlyCollection<bool> readOnlyCollectionOfBoolProperty,
            IReadOnlyCollection<int> readOnlyCollectionOfIntProperty,
            IReadOnlyCollection<string> readOnlyCollectionOfStringProperty,
            IReadOnlyCollection<Guid> readOnlyCollectionOfGuidProperty,
            IReadOnlyCollection<DateTime> readOnlyCollectionOfDateTimeProperty,
            IReadOnlyCollection<ModelEnum> readOnlyCollectionOfModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum> readOnlyCollectionOfModelFlagsEnumProperty,
            IReadOnlyCollection<ModelStruct> readOnlyCollectionOfModelStructProperty,
            IReadOnlyCollection<ModelEquatableStruct> readOnlyCollectionOfModelEquatableStructProperty,
            IReadOnlyCollection<ModelClass> readOnlyCollectionOfModelClassProperty,
            IReadOnlyCollection<ModelEquatableClass> readOnlyCollectionOfModelEquatableClassProperty,
            IReadOnlyCollection<bool?> readOnlyCollectionOfNullableBoolProperty,
            IReadOnlyCollection<int?> readOnlyCollectionOfNullableIntProperty,
            IReadOnlyCollection<Guid?> readOnlyCollectionOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> readOnlyCollectionOfNullableDateTimeProperty,
            IReadOnlyCollection<ModelEnum?> readOnlyCollectionOfNullableModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum?> readOnlyCollectionOfNullableModelFlagsEnumProperty,
            IReadOnlyCollection<ModelStruct?> readOnlyCollectionOfNullableModelStructProperty,
            IReadOnlyCollection<ModelEquatableStruct?> readOnlyCollectionOfNullableModelEquatableStructProperty,
            IReadOnlyDictionary<object, object> readOnlyDictionaryOfObjectProperty,
            IReadOnlyDictionary<bool, bool> readOnlyDictionaryOfBoolProperty,
            IReadOnlyDictionary<int, int> readOnlyDictionaryOfIntProperty,
            IReadOnlyDictionary<string, string> readOnlyDictionaryOfStringProperty,
            IReadOnlyDictionary<Guid, Guid> readOnlyDictionaryOfGuidProperty,
            IReadOnlyDictionary<DateTime, DateTime> readOnlyDictionaryOfDateTimeProperty,
            IReadOnlyDictionary<ModelEnum, ModelEnum> readOnlyDictionaryOfModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> readOnlyDictionaryOfModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelStruct, ModelStruct> readOnlyDictionaryOfModelStructProperty,
            IReadOnlyDictionary<ModelEquatableStruct, ModelEquatableStruct> readOnlyDictionaryOfModelEquatableStructProperty,
            IReadOnlyDictionary<ModelClass, ModelClass> readOnlyDictionaryOfModelClassProperty,
            IReadOnlyDictionary<ModelEquatableClass, ModelEquatableClass> readOnlyDictionaryOfModelEquatableClassProperty,
            IReadOnlyDictionary<bool?, bool?> readOnlyDictionaryOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> readOnlyDictionaryOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> readOnlyDictionaryOfNullableGuidProperty,
            IReadOnlyDictionary<DateTime?, DateTime?> readOnlyDictionaryOfNullableDateTimeProperty,
            IReadOnlyDictionary<ModelEnum?, ModelEnum?> readOnlyDictionaryOfNullableModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> readOnlyDictionaryOfNullableModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelStruct?, ModelStruct?> readOnlyDictionaryOfNullableModelStructProperty,
            IReadOnlyDictionary<ModelEquatableStruct?, ModelEquatableStruct?> readOnlyDictionaryOfNullableModelEquatableStructProperty)
        {
            new { objectProperty }.Must().NotBeNull();
            new { stringProperty }.Must().NotBeNullNorWhiteSpace();
            new { modelClassProperty }.Must().NotBeNull();
            new { modelEquatableClassProperty }.Must().NotBeNull();
            new { arrayOfObjectProperty }.Must().NotBeNull();
            new { arrayOfBoolProperty }.Must().NotBeNull();
            new { arrayOfIntProperty }.Must().NotBeNull();
            new { arrayOfStringProperty }.Must().NotBeNull();
            new { arrayOfGuidProperty }.Must().NotBeNull();
            new { arrayOfDateTimeProperty }.Must().NotBeNull();
            new { arrayOfModelEnumProperty }.Must().NotBeNull();
            new { arrayOfModelFlagsEnumProperty }.Must().NotBeNull();
            new { arrayOfModelStructProperty }.Must().NotBeNull();
            new { arrayOfModelEquatableStructProperty }.Must().NotBeNull();
            new { arrayOfModelClassProperty }.Must().NotBeNull();
            new { arrayOfModelEquatableClassProperty }.Must().NotBeNull();
            new { arrayOfNullableBoolProperty }.Must().NotBeNull();
            new { arrayOfNullableIntProperty }.Must().NotBeNull();
            new { arrayOfNullableGuidProperty }.Must().NotBeNull();
            new { arrayOfNullableDateTimeProperty }.Must().NotBeNull();
            new { arrayOfNullableModelEnumProperty }.Must().NotBeNull();
            new { arrayOfNullableModelFlagsEnumProperty }.Must().NotBeNull();
            new { arrayOfNullableModelStructProperty }.Must().NotBeNull();
            new { arrayOfNullableModelEquatableStructProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfObjectProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfBoolProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfIntProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfStringProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfGuidProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfDateTimeProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfModelEnumProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfModelFlagsEnumProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfModelStructProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfModelEquatableStructProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfModelClassProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfModelEquatableClassProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfNullableBoolProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfNullableIntProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfNullableGuidProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfNullableDateTimeProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfNullableModelEnumProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfNullableModelFlagsEnumProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfNullableModelStructProperty }.Must().NotBeNull();
            new { readOnlyCollectionOfNullableModelEquatableStructProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfObjectProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfBoolProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfIntProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfStringProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfGuidProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfDateTimeProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfModelEnumProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfModelFlagsEnumProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfModelStructProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfModelEquatableStructProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfModelClassProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfModelEquatableClassProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfNullableBoolProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfNullableIntProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfNullableGuidProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfNullableDateTimeProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfNullableModelEnumProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfNullableModelFlagsEnumProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfNullableModelStructProperty }.Must().NotBeNull();
            new { readOnlyDictionaryOfNullableModelEquatableStructProperty }.Must().NotBeNull();

            this.ObjectProperty = objectProperty;
            this.BoolProperty = boolProperty;
            this.IntProperty = intProperty;
            this.StringProperty = stringProperty;
            this.GuidProperty = guidProperty;
            this.DateTimeProperty = dateTimeProperty;
            this.ModelEnumProperty = modelEnumProperty;
            this.ModelFlagsEnumProperty = modelFlagsEnumProperty;
            this.ModelStructProperty = modelStructProperty;
            this.ModelEquatableStructProperty = modelEquatableStructProperty;
            this.ModelClassProperty = modelClassProperty;
            this.ModelEquatableClassProperty = modelEquatableClassProperty;
            this.NullableBoolProperty = nullableBoolProperty;
            this.NullableIntProperty = nullableIntProperty;
            this.NullableGuidProperty = nullableGuidProperty;
            this.NullableDateTimeProperty = nullableDateTimeProperty;
            this.NullableModelEnumProperty = nullableModelEnumProperty;
            this.NullableModelFlagsEnumProperty = nullableModelFlagsEnumProperty;
            this.NullableModelStructProperty = nullableModelStructProperty;
            this.NullableModelEquatableStructProperty = nullableModelEquatableStructProperty;
            this.ArrayOfObjectProperty = arrayOfObjectProperty;
            this.ArrayOfBoolProperty = arrayOfBoolProperty;
            this.ArrayOfIntProperty = arrayOfIntProperty;
            this.ArrayOfStringProperty = arrayOfStringProperty;
            this.ArrayOfGuidProperty = arrayOfGuidProperty;
            this.ArrayOfDateTimeProperty = arrayOfDateTimeProperty;
            this.ArrayOfModelEnumProperty = arrayOfModelEnumProperty;
            this.ArrayOfModelFlagsEnumProperty = arrayOfModelFlagsEnumProperty;
            this.ArrayOfModelStructProperty = arrayOfModelStructProperty;
            this.ArrayOfModelEquatableStructProperty = arrayOfModelEquatableStructProperty;
            this.ArrayOfModelClassProperty = arrayOfModelClassProperty;
            this.ArrayOfModelEquatableClassProperty = arrayOfModelEquatableClassProperty;
            this.ArrayOfNullableBoolProperty = arrayOfNullableBoolProperty;
            this.ArrayOfNullableIntProperty = arrayOfNullableIntProperty;
            this.ArrayOfNullableGuidProperty = arrayOfNullableGuidProperty;
            this.ArrayOfNullableDateTimeProperty = arrayOfNullableDateTimeProperty;
            this.ArrayOfNullableModelEnumProperty = arrayOfNullableModelEnumProperty;
            this.ArrayOfNullableModelFlagsEnumProperty = arrayOfNullableModelFlagsEnumProperty;
            this.ArrayOfNullableModelStructProperty = arrayOfNullableModelStructProperty;
            this.ArrayOfNullableModelEquatableStructProperty = arrayOfNullableModelEquatableStructProperty;
            this.ReadOnlyCollectionOfObjectProperty = readOnlyCollectionOfObjectProperty;
            this.ReadOnlyCollectionOfBoolProperty = readOnlyCollectionOfBoolProperty;
            this.ReadOnlyCollectionOfIntProperty = readOnlyCollectionOfIntProperty;
            this.ReadOnlyCollectionOfStringProperty = readOnlyCollectionOfStringProperty;
            this.ReadOnlyCollectionOfGuidProperty = readOnlyCollectionOfGuidProperty;
            this.ReadOnlyCollectionOfDateTimeProperty = readOnlyCollectionOfDateTimeProperty;
            this.ReadOnlyCollectionOfModelEnumProperty = readOnlyCollectionOfModelEnumProperty;
            this.ReadOnlyCollectionOfModelFlagsEnumProperty = readOnlyCollectionOfModelFlagsEnumProperty;
            this.ReadOnlyCollectionOfModelStructProperty = readOnlyCollectionOfModelStructProperty;
            this.ReadOnlyCollectionOfModelEquatableStructProperty = readOnlyCollectionOfModelEquatableStructProperty;
            this.ReadOnlyCollectionOfModelClassProperty = readOnlyCollectionOfModelClassProperty;
            this.ReadOnlyCollectionOfModelEquatableClassProperty = readOnlyCollectionOfModelEquatableClassProperty;
            this.ReadOnlyCollectionOfNullableBoolProperty = readOnlyCollectionOfNullableBoolProperty;
            this.ReadOnlyCollectionOfNullableIntProperty = readOnlyCollectionOfNullableIntProperty;
            this.ReadOnlyCollectionOfNullableGuidProperty = readOnlyCollectionOfNullableGuidProperty;
            this.ReadOnlyCollectionOfNullableDateTimeProperty = readOnlyCollectionOfNullableDateTimeProperty;
            this.ReadOnlyCollectionOfNullableModelEnumProperty = readOnlyCollectionOfNullableModelEnumProperty;
            this.ReadOnlyCollectionOfNullableModelFlagsEnumProperty = readOnlyCollectionOfNullableModelFlagsEnumProperty;
            this.ReadOnlyCollectionOfNullableModelStructProperty = readOnlyCollectionOfNullableModelStructProperty;
            this.ReadOnlyCollectionOfNullableModelEquatableStructProperty = readOnlyCollectionOfNullableModelEquatableStructProperty;
            this.ReadOnlyDictionaryOfObjectProperty = readOnlyDictionaryOfObjectProperty;
            this.ReadOnlyDictionaryOfBoolProperty = readOnlyDictionaryOfBoolProperty;
            this.ReadOnlyDictionaryOfIntProperty = readOnlyDictionaryOfIntProperty;
            this.ReadOnlyDictionaryOfStringProperty = readOnlyDictionaryOfStringProperty;
            this.ReadOnlyDictionaryOfGuidProperty = readOnlyDictionaryOfGuidProperty;
            this.ReadOnlyDictionaryOfDateTimeProperty = readOnlyDictionaryOfDateTimeProperty;
            this.ReadOnlyDictionaryOfModelEnumProperty = readOnlyDictionaryOfModelEnumProperty;
            this.ReadOnlyDictionaryOfModelFlagsEnumProperty = readOnlyDictionaryOfModelFlagsEnumProperty;
            this.ReadOnlyDictionaryOfModelStructProperty = readOnlyDictionaryOfModelStructProperty;
            this.ReadOnlyDictionaryOfModelEquatableStructProperty = readOnlyDictionaryOfModelEquatableStructProperty;
            this.ReadOnlyDictionaryOfModelClassProperty = readOnlyDictionaryOfModelClassProperty;
            this.ReadOnlyDictionaryOfModelEquatableClassProperty = readOnlyDictionaryOfModelEquatableClassProperty;
            this.ReadOnlyDictionaryOfNullableBoolProperty = readOnlyDictionaryOfNullableBoolProperty;
            this.ReadOnlyDictionaryOfNullableIntProperty = readOnlyDictionaryOfNullableIntProperty;
            this.ReadOnlyDictionaryOfNullableGuidProperty = readOnlyDictionaryOfNullableGuidProperty;
            this.ReadOnlyDictionaryOfNullableDateTimeProperty = readOnlyDictionaryOfNullableDateTimeProperty;
            this.ReadOnlyDictionaryOfNullableModelEnumProperty = readOnlyDictionaryOfNullableModelEnumProperty;
            this.ReadOnlyDictionaryOfNullableModelFlagsEnumProperty = readOnlyDictionaryOfNullableModelFlagsEnumProperty;
            this.ReadOnlyDictionaryOfNullableModelStructProperty = readOnlyDictionaryOfNullableModelStructProperty;
            this.ReadOnlyDictionaryOfNullableModelEquatableStructProperty = readOnlyDictionaryOfNullableModelEquatableStructProperty;
        }

        public object ObjectProperty { get; }

        public bool BoolProperty { get; }

        public int IntProperty { get; }

        public string StringProperty { get; }

        public Guid GuidProperty { get; }

        public DateTime DateTimeProperty { get; }

        public ModelEnum ModelEnumProperty { get; }

        public ModelFlagsEnum ModelFlagsEnumProperty { get; }

        public ModelStruct ModelStructProperty { get; }

        public ModelEquatableStruct ModelEquatableStructProperty { get; }

        public ModelClass ModelClassProperty { get; }

        public ModelEquatableClass ModelEquatableClassProperty { get; }

        public bool? NullableBoolProperty { get; }

        public int? NullableIntProperty { get; }

        public Guid? NullableGuidProperty { get; }

        public DateTime? NullableDateTimeProperty { get; }

        public ModelEnum? NullableModelEnumProperty { get; }

        public ModelFlagsEnum? NullableModelFlagsEnumProperty { get; }

        public ModelStruct? NullableModelStructProperty { get; }

        public ModelEquatableStruct? NullableModelEquatableStructProperty { get; }

        public object[] ArrayOfObjectProperty { get; }

        public bool[] ArrayOfBoolProperty { get; }

        public int[] ArrayOfIntProperty { get; }

        public string[] ArrayOfStringProperty { get; }

        public Guid[] ArrayOfGuidProperty { get; }

        public DateTime[] ArrayOfDateTimeProperty { get; }

        public ModelEnum[] ArrayOfModelEnumProperty { get; }

        public ModelFlagsEnum[] ArrayOfModelFlagsEnumProperty { get; }

        public ModelStruct[] ArrayOfModelStructProperty { get; }

        public ModelEquatableStruct[] ArrayOfModelEquatableStructProperty { get; }

        public ModelClass[] ArrayOfModelClassProperty { get; }

        public ModelEquatableClass[] ArrayOfModelEquatableClassProperty { get; }

        public bool?[] ArrayOfNullableBoolProperty { get; }

        public int?[] ArrayOfNullableIntProperty { get; }

        public Guid?[] ArrayOfNullableGuidProperty { get; }

        public DateTime?[] ArrayOfNullableDateTimeProperty { get; }

        public ModelEnum?[] ArrayOfNullableModelEnumProperty { get; }

        public ModelFlagsEnum?[] ArrayOfNullableModelFlagsEnumProperty { get; }

        public ModelStruct?[] ArrayOfNullableModelStructProperty { get; }

        public ModelEquatableStruct?[] ArrayOfNullableModelEquatableStructProperty { get; }

        public IReadOnlyCollection<object> ReadOnlyCollectionOfObjectProperty { get; }

        public IReadOnlyCollection<bool> ReadOnlyCollectionOfBoolProperty { get; }

        public IReadOnlyCollection<int> ReadOnlyCollectionOfIntProperty { get; }

        public IReadOnlyCollection<string> ReadOnlyCollectionOfStringProperty { get; }

        public IReadOnlyCollection<Guid> ReadOnlyCollectionOfGuidProperty { get; }

        public IReadOnlyCollection<DateTime> ReadOnlyCollectionOfDateTimeProperty { get; }

        public IReadOnlyCollection<ModelEnum> ReadOnlyCollectionOfModelEnumProperty { get; }

        public IReadOnlyCollection<ModelFlagsEnum> ReadOnlyCollectionOfModelFlagsEnumProperty { get; }

        public IReadOnlyCollection<ModelStruct> ReadOnlyCollectionOfModelStructProperty { get; }

        public IReadOnlyCollection<ModelEquatableStruct> ReadOnlyCollectionOfModelEquatableStructProperty { get; }

        public IReadOnlyCollection<ModelClass> ReadOnlyCollectionOfModelClassProperty { get; }

        public IReadOnlyCollection<ModelEquatableClass> ReadOnlyCollectionOfModelEquatableClassProperty { get; }

        public IReadOnlyCollection<bool?> ReadOnlyCollectionOfNullableBoolProperty { get; }

        public IReadOnlyCollection<int?> ReadOnlyCollectionOfNullableIntProperty { get; }

        public IReadOnlyCollection<Guid?> ReadOnlyCollectionOfNullableGuidProperty { get; }

        public IReadOnlyCollection<DateTime?> ReadOnlyCollectionOfNullableDateTimeProperty { get; }

        public IReadOnlyCollection<ModelEnum?> ReadOnlyCollectionOfNullableModelEnumProperty { get; }

        public IReadOnlyCollection<ModelFlagsEnum?> ReadOnlyCollectionOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyCollection<ModelStruct?> ReadOnlyCollectionOfNullableModelStructProperty { get; }

        public IReadOnlyCollection<ModelEquatableStruct?> ReadOnlyCollectionOfNullableModelEquatableStructProperty { get; }

        public IReadOnlyDictionary<object, object> ReadOnlyDictionaryOfObjectProperty { get; }

        public IReadOnlyDictionary<bool, bool> ReadOnlyDictionaryOfBoolProperty { get; }

        public IReadOnlyDictionary<int, int> ReadOnlyDictionaryOfIntProperty { get; }

        public IReadOnlyDictionary<string, string> ReadOnlyDictionaryOfStringProperty { get; }

        public IReadOnlyDictionary<Guid, Guid> ReadOnlyDictionaryOfGuidProperty { get; }

        public IReadOnlyDictionary<DateTime, DateTime> ReadOnlyDictionaryOfDateTimeProperty { get; }

        public IReadOnlyDictionary<ModelEnum, ModelEnum> ReadOnlyDictionaryOfModelEnumProperty { get; }

        public IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> ReadOnlyDictionaryOfModelFlagsEnumProperty { get; }

        public IReadOnlyDictionary<ModelStruct, ModelStruct> ReadOnlyDictionaryOfModelStructProperty { get; }

        public IReadOnlyDictionary<ModelEquatableStruct, ModelEquatableStruct> ReadOnlyDictionaryOfModelEquatableStructProperty { get; }

        public IReadOnlyDictionary<ModelClass, ModelClass> ReadOnlyDictionaryOfModelClassProperty { get; }

        public IReadOnlyDictionary<ModelEquatableClass, ModelEquatableClass> ReadOnlyDictionaryOfModelEquatableClassProperty { get; }

        public IReadOnlyDictionary<bool?, bool?> ReadOnlyDictionaryOfNullableBoolProperty { get; }

        public IReadOnlyDictionary<int?, int?> ReadOnlyDictionaryOfNullableIntProperty { get; }

        public IReadOnlyDictionary<Guid?, Guid?> ReadOnlyDictionaryOfNullableGuidProperty { get; }

        public IReadOnlyDictionary<DateTime?, DateTime?> ReadOnlyDictionaryOfNullableDateTimeProperty { get; }

        public IReadOnlyDictionary<ModelEnum?, ModelEnum?> ReadOnlyDictionaryOfNullableModelEnumProperty { get; }

        public IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> ReadOnlyDictionaryOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyDictionary<ModelStruct?, ModelStruct?> ReadOnlyDictionaryOfNullableModelStructProperty { get; }

        public IReadOnlyDictionary<ModelEquatableStruct?, ModelEquatableStruct?> ReadOnlyDictionaryOfNullableModelEquatableStructProperty { get; }
    }
}
