// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelGettersOnly.cs" company="OBeautifulCode">
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

    public partial class MyModelGettersOnly : IModelViaCodeGen
    {
        public MyModelGettersOnly(
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
            IReadOnlyList<bool> readOnlyListOfBoolProperty,
            IReadOnlyList<int> readOnlyListOfIntProperty,
            IReadOnlyList<string> readOnlyListOfStringProperty,
            IReadOnlyList<Guid> readOnlyListOfGuidProperty,
            IReadOnlyList<DateTime> readOnlyListOfDateTimeProperty,
            IReadOnlyList<ModelEnum> readOnlyListOfModelEnumProperty,
            IReadOnlyList<ModelFlagsEnum> readOnlyListOfModelFlagsEnumProperty,
            IReadOnlyList<ModelStruct> readOnlyListOfModelStructProperty,
            IReadOnlyList<ModelEquatableStruct> readOnlyListOfModelEquatableStructProperty,
            IReadOnlyList<ModelClass> readOnlyListOfModelClassProperty,
            IReadOnlyList<ModelEquatableClass> readOnlyListOfModelEquatableClassProperty,
            IReadOnlyList<bool?> readOnlyListOfNullableBoolProperty,
            IReadOnlyList<int?> readOnlyListOfNullableIntProperty,
            IReadOnlyList<Guid?> readOnlyListOfNullableGuidProperty,
            IReadOnlyList<DateTime?> readOnlyListOfNullableDateTimeProperty,
            IReadOnlyList<ModelEnum?> readOnlyListOfNullableModelEnumProperty,
            IReadOnlyList<ModelFlagsEnum?> readOnlyListOfNullableModelFlagsEnumProperty,
            IReadOnlyList<ModelStruct?> readOnlyListOfNullableModelStructProperty,
            IReadOnlyList<ModelEquatableStruct?> readOnlyListOfNullableModelEquatableStructProperty,
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
            IReadOnlyDictionary<ModelEquatableStruct?, ModelEquatableStruct?> readOnlyDictionaryOfNullableModelEquatableStructProperty,
            IReadOnlyList<IReadOnlyList<string>> readOnlyListOfReadOnlyListOfStringProperty,
            IReadOnlyList<ICollection<string>> readOnlyListOfCollectionOfStringProperty,
            ICollection<IReadOnlyList<ICollection<string>>> collectionOfReadOnlyListOfCollectionOfStringProperty,
            IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyList<Guid>>> readOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfGuidProperty,
            IReadOnlyDictionary<string, IReadOnlyDictionary<ICollection<string>, IReadOnlyDictionary<IList<string>, IReadOnlyList<string>>>> readOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty)
        {
            new { stringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { modelClassProperty }.AsArg().Must().NotBeNull();
            new { modelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { arrayOfBoolProperty }.AsArg().Must().NotBeNull();
            new { arrayOfIntProperty }.AsArg().Must().NotBeNull();
            new { arrayOfStringProperty }.AsArg().Must().NotBeNull();
            new { arrayOfGuidProperty }.AsArg().Must().NotBeNull();
            new { arrayOfDateTimeProperty }.AsArg().Must().NotBeNull();
            new { arrayOfModelEnumProperty }.AsArg().Must().NotBeNull();
            new { arrayOfModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { arrayOfModelStructProperty }.AsArg().Must().NotBeNull();
            new { arrayOfModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { arrayOfModelClassProperty }.AsArg().Must().NotBeNull();
            new { arrayOfModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { arrayOfNullableBoolProperty }.AsArg().Must().NotBeNull();
            new { arrayOfNullableIntProperty }.AsArg().Must().NotBeNull();
            new { arrayOfNullableGuidProperty }.AsArg().Must().NotBeNull();
            new { arrayOfNullableDateTimeProperty }.AsArg().Must().NotBeNull();
            new { arrayOfNullableModelEnumProperty }.AsArg().Must().NotBeNull();
            new { arrayOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { arrayOfNullableModelStructProperty }.AsArg().Must().NotBeNull();
            new { arrayOfNullableModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfBoolProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfIntProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfGuidProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfDateTimeProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfModelEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfModelStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfModelClassProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfNullableBoolProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfNullableIntProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfNullableGuidProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfNullableDateTimeProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfNullableModelEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfNullableModelStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyCollectionOfNullableModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfBoolProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfIntProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfStringProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfGuidProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfDateTimeProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfModelEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfModelStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfModelClassProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfNullableBoolProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfNullableIntProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfNullableGuidProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfNullableDateTimeProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfNullableModelEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfNullableModelStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfNullableModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfBoolProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfIntProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfStringProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfGuidProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfDateTimeProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfModelEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfModelStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfModelClassProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfNullableBoolProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfNullableIntProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfNullableGuidProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfNullableDateTimeProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfNullableModelEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfNullableModelStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfNullableModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfReadOnlyListOfStringProperty }.AsArg().Must().NotBeNull();
            new { readOnlyListOfCollectionOfStringProperty }.AsArg().Must().NotBeNull();
            new { collectionOfReadOnlyListOfCollectionOfStringProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfGuidProperty }.AsArg().Must().NotBeNull();
            new { readOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty }.AsArg().Must().NotBeNull();

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
            this.ReadOnlyListOfBoolProperty = readOnlyListOfBoolProperty;
            this.ReadOnlyListOfIntProperty = readOnlyListOfIntProperty;
            this.ReadOnlyListOfStringProperty = readOnlyListOfStringProperty;
            this.ReadOnlyListOfGuidProperty = readOnlyListOfGuidProperty;
            this.ReadOnlyListOfDateTimeProperty = readOnlyListOfDateTimeProperty;
            this.ReadOnlyListOfModelEnumProperty = readOnlyListOfModelEnumProperty;
            this.ReadOnlyListOfModelFlagsEnumProperty = readOnlyListOfModelFlagsEnumProperty;
            this.ReadOnlyListOfModelStructProperty = readOnlyListOfModelStructProperty;
            this.ReadOnlyListOfModelEquatableStructProperty = readOnlyListOfModelEquatableStructProperty;
            this.ReadOnlyListOfModelClassProperty = readOnlyListOfModelClassProperty;
            this.ReadOnlyListOfModelEquatableClassProperty = readOnlyListOfModelEquatableClassProperty;
            this.ReadOnlyListOfNullableBoolProperty = readOnlyListOfNullableBoolProperty;
            this.ReadOnlyListOfNullableIntProperty = readOnlyListOfNullableIntProperty;
            this.ReadOnlyListOfNullableGuidProperty = readOnlyListOfNullableGuidProperty;
            this.ReadOnlyListOfNullableDateTimeProperty = readOnlyListOfNullableDateTimeProperty;
            this.ReadOnlyListOfNullableModelEnumProperty = readOnlyListOfNullableModelEnumProperty;
            this.ReadOnlyListOfNullableModelFlagsEnumProperty = readOnlyListOfNullableModelFlagsEnumProperty;
            this.ReadOnlyListOfNullableModelStructProperty = readOnlyListOfNullableModelStructProperty;
            this.ReadOnlyListOfNullableModelEquatableStructProperty = readOnlyListOfNullableModelEquatableStructProperty;
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
            this.ReadOnlyListOfReadOnlyListOfStringProperty = readOnlyListOfReadOnlyListOfStringProperty;
            this.ReadOnlyListOfCollectionOfStringProperty = readOnlyListOfCollectionOfStringProperty;
            this.CollectionOfReadOnlyListOfCollectionOfStringProperty = collectionOfReadOnlyListOfCollectionOfStringProperty;
            this.ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfGuidProperty = readOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfGuidProperty;
            this.ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty = readOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty;
        }

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

        public IReadOnlyList<bool> ReadOnlyListOfBoolProperty { get; }

        public IReadOnlyList<int> ReadOnlyListOfIntProperty { get; }

        public IReadOnlyList<string> ReadOnlyListOfStringProperty { get; }

        public IReadOnlyList<Guid> ReadOnlyListOfGuidProperty { get; }

        public IReadOnlyList<DateTime> ReadOnlyListOfDateTimeProperty { get; }

        public IReadOnlyList<ModelEnum> ReadOnlyListOfModelEnumProperty { get; }

        public IReadOnlyList<ModelFlagsEnum> ReadOnlyListOfModelFlagsEnumProperty { get; }

        public IReadOnlyList<ModelStruct> ReadOnlyListOfModelStructProperty { get; }

        public IReadOnlyList<ModelEquatableStruct> ReadOnlyListOfModelEquatableStructProperty { get; }

        public IReadOnlyList<ModelClass> ReadOnlyListOfModelClassProperty { get; }

        public IReadOnlyList<ModelEquatableClass> ReadOnlyListOfModelEquatableClassProperty { get; }

        public IReadOnlyList<bool?> ReadOnlyListOfNullableBoolProperty { get; }

        public IReadOnlyList<int?> ReadOnlyListOfNullableIntProperty { get; }

        public IReadOnlyList<Guid?> ReadOnlyListOfNullableGuidProperty { get; }

        public IReadOnlyList<DateTime?> ReadOnlyListOfNullableDateTimeProperty { get; }

        public IReadOnlyList<ModelEnum?> ReadOnlyListOfNullableModelEnumProperty { get; }

        public IReadOnlyList<ModelFlagsEnum?> ReadOnlyListOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyList<ModelStruct?> ReadOnlyListOfNullableModelStructProperty { get; }

        public IReadOnlyList<ModelEquatableStruct?> ReadOnlyListOfNullableModelEquatableStructProperty { get; }

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

        public IReadOnlyList<IReadOnlyList<string>> ReadOnlyListOfReadOnlyListOfStringProperty { get; }

        public IReadOnlyList<ICollection<string>> ReadOnlyListOfCollectionOfStringProperty { get; }

        public ICollection<IReadOnlyList<ICollection<string>>> CollectionOfReadOnlyListOfCollectionOfStringProperty { get; }

        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyList<Guid>>> ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfGuidProperty { get; }

        public IReadOnlyDictionary<string, IReadOnlyDictionary<ICollection<string>, IReadOnlyDictionary<IList<string>, IReadOnlyList<string>>>> ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty { get; }
    }
}