﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelChild2.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Type;
    using OBeautifulCode.Validation.Recipes;

    public partial class MyModelChild2 : MyModelParent, IModelViaCodeGen
    {
        public MyModelChild2(
            object parentObjectProperty,
            bool parentBoolProperty,
            int parentIntProperty,
            string parentStringProperty,
            Guid parentGuidProperty,
            DateTime parentDateTimeProperty,
            ModelEnum parentModelEnumProperty,
            ModelFlagsEnum parentModelFlagsEnumProperty,
            ModelStruct parentModelStructProperty,
            ModelEquatableStruct parentModelEquatableStructProperty,
            ModelClass parentModelClassProperty,
            ModelEquatableClass parentModelEquatableClassProperty,
            bool? parentNullableBoolProperty,
            int? parentNullableIntProperty,
            Guid? parentNullableGuidProperty,
            DateTime? parentNullableDateTimeProperty,
            ModelEnum? parentNullableModelEnumProperty,
            ModelFlagsEnum? parentNullableModelFlagsEnumProperty,
            ModelStruct? parentNullableModelStructProperty,
            ModelEquatableStruct? parentNullableModelEquatableStructProperty,
            object[] parentArrayOfObjectProperty,
            bool[] parentArrayOfBoolProperty,
            int[] parentArrayOfIntProperty,
            string[] parentArrayOfStringProperty,
            Guid[] parentArrayOfGuidProperty,
            DateTime[] parentArrayOfDateTimeProperty,
            ModelEnum[] parentArrayOfModelEnumProperty,
            ModelFlagsEnum[] parentArrayOfModelFlagsEnumProperty,
            ModelStruct[] parentArrayOfModelStructProperty,
            ModelEquatableStruct[] parentArrayOfModelEquatableStructProperty,
            ModelClass[] parentArrayOfModelClassProperty,
            ModelEquatableClass[] parentArrayOfModelEquatableClassProperty,
            bool?[] parentArrayOfNullableBoolProperty,
            int?[] parentArrayOfNullableIntProperty,
            Guid?[] parentArrayOfNullableGuidProperty,
            DateTime?[] parentArrayOfNullableDateTimeProperty,
            ModelEnum?[] parentArrayOfNullableModelEnumProperty,
            ModelFlagsEnum?[] parentArrayOfNullableModelFlagsEnumProperty,
            ModelStruct?[] parentArrayOfNullableModelStructProperty,
            ModelEquatableStruct?[] parentArrayOfNullableModelEquatableStructProperty,
            IReadOnlyCollection<object> parentReadOnlyCollectionOfObjectProperty,
            IReadOnlyCollection<bool> parentReadOnlyCollectionOfBoolProperty,
            IReadOnlyCollection<int> parentReadOnlyCollectionOfIntProperty,
            IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty,
            IReadOnlyCollection<Guid> parentReadOnlyCollectionOfGuidProperty,
            IReadOnlyCollection<DateTime> parentReadOnlyCollectionOfDateTimeProperty,
            IReadOnlyCollection<ModelEnum> parentReadOnlyCollectionOfModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum> parentReadOnlyCollectionOfModelFlagsEnumProperty,
            IReadOnlyCollection<ModelStruct> parentReadOnlyCollectionOfModelStructProperty,
            IReadOnlyCollection<ModelEquatableStruct> parentReadOnlyCollectionOfModelEquatableStructProperty,
            IReadOnlyCollection<ModelClass> parentReadOnlyCollectionOfModelClassProperty,
            IReadOnlyCollection<ModelEquatableClass> parentReadOnlyCollectionOfModelEquatableClassProperty,
            IReadOnlyCollection<bool?> parentReadOnlyCollectionOfNullableBoolProperty,
            IReadOnlyCollection<int?> parentReadOnlyCollectionOfNullableIntProperty,
            IReadOnlyCollection<Guid?> parentReadOnlyCollectionOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> parentReadOnlyCollectionOfNullableDateTimeProperty,
            IReadOnlyCollection<ModelEnum?> parentReadOnlyCollectionOfNullableModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum?> parentReadOnlyCollectionOfNullableModelFlagsEnumProperty,
            IReadOnlyCollection<ModelStruct?> parentReadOnlyCollectionOfNullableModelStructProperty,
            IReadOnlyCollection<ModelEquatableStruct?> parentReadOnlyCollectionOfNullableModelEquatableStructProperty,
            IReadOnlyDictionary<object, object> parentReadOnlyDictionaryOfObjectProperty,
            IReadOnlyDictionary<bool, bool> parentReadOnlyDictionaryOfBoolProperty,
            IReadOnlyDictionary<int, int> parentReadOnlyDictionaryOfIntProperty,
            IReadOnlyDictionary<string, string> parentReadOnlyDictionaryOfStringProperty,
            IReadOnlyDictionary<Guid, Guid> parentReadOnlyDictionaryOfGuidProperty,
            IReadOnlyDictionary<DateTime, DateTime> parentReadOnlyDictionaryOfDateTimeProperty,
            IReadOnlyDictionary<ModelEnum, ModelEnum> parentReadOnlyDictionaryOfModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> parentReadOnlyDictionaryOfModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelStruct, ModelStruct> parentReadOnlyDictionaryOfModelStructProperty,
            IReadOnlyDictionary<ModelEquatableStruct, ModelEquatableStruct> parentReadOnlyDictionaryOfModelEquatableStructProperty,
            IReadOnlyDictionary<ModelClass, ModelClass> parentReadOnlyDictionaryOfModelClassProperty,
            IReadOnlyDictionary<ModelEquatableClass, ModelEquatableClass> parentReadOnlyDictionaryOfModelEquatableClassProperty,
            IReadOnlyDictionary<bool?, bool?> parentReadOnlyDictionaryOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> parentReadOnlyDictionaryOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> parentReadOnlyDictionaryOfNullableGuidProperty,
            IReadOnlyDictionary<DateTime?, DateTime?> parentReadOnlyDictionaryOfNullableDateTimeProperty,
            IReadOnlyDictionary<ModelEnum?, ModelEnum?> parentReadOnlyDictionaryOfNullableModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> parentReadOnlyDictionaryOfNullableModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelStruct?, ModelStruct?> parentReadOnlyDictionaryOfNullableModelStructProperty,
            IReadOnlyDictionary<ModelEquatableStruct?, ModelEquatableStruct?> parentReadOnlyDictionaryOfNullableModelEquatableStructProperty,
            object child2ObjectProperty,
            bool child2BoolProperty,
            int child2IntProperty,
            string child2StringProperty,
            Guid child2GuidProperty,
            DateTime child2DateTimeProperty,
            ModelEnum child2ModelEnumProperty,
            ModelFlagsEnum child2ModelFlagsEnumProperty,
            ModelStruct child2ModelStructProperty,
            ModelEquatableStruct child2ModelEquatableStructProperty,
            ModelClass child2ModelClassProperty,
            ModelEquatableClass child2ModelEquatableClassProperty,
            bool? child2NullableBoolProperty,
            int? child2NullableIntProperty,
            Guid? child2NullableGuidProperty,
            DateTime? child2NullableDateTimeProperty,
            ModelEnum? child2NullableModelEnumProperty,
            ModelFlagsEnum? child2NullableModelFlagsEnumProperty,
            ModelStruct? child2NullableModelStructProperty,
            ModelEquatableStruct? child2NullableModelEquatableStructProperty,
            object[] child2ArrayOfObjectProperty,
            bool[] child2ArrayOfBoolProperty,
            int[] child2ArrayOfIntProperty,
            string[] child2ArrayOfStringProperty,
            Guid[] child2ArrayOfGuidProperty,
            DateTime[] child2ArrayOfDateTimeProperty,
            ModelEnum[] child2ArrayOfModelEnumProperty,
            ModelFlagsEnum[] child2ArrayOfModelFlagsEnumProperty,
            ModelStruct[] child2ArrayOfModelStructProperty,
            ModelEquatableStruct[] child2ArrayOfModelEquatableStructProperty,
            ModelClass[] child2ArrayOfModelClassProperty,
            ModelEquatableClass[] child2ArrayOfModelEquatableClassProperty,
            bool?[] child2ArrayOfNullableBoolProperty,
            int?[] child2ArrayOfNullableIntProperty,
            Guid?[] child2ArrayOfNullableGuidProperty,
            DateTime?[] child2ArrayOfNullableDateTimeProperty,
            ModelEnum?[] child2ArrayOfNullableModelEnumProperty,
            ModelFlagsEnum?[] child2ArrayOfNullableModelFlagsEnumProperty,
            ModelStruct?[] child2ArrayOfNullableModelStructProperty,
            ModelEquatableStruct?[] child2ArrayOfNullableModelEquatableStructProperty,
            IReadOnlyCollection<object> child2ReadOnlyCollectionOfObjectProperty,
            IReadOnlyCollection<bool> child2ReadOnlyCollectionOfBoolProperty,
            IReadOnlyCollection<int> child2ReadOnlyCollectionOfIntProperty,
            IReadOnlyCollection<string> child2ReadOnlyCollectionOfStringProperty,
            IReadOnlyCollection<Guid> child2ReadOnlyCollectionOfGuidProperty,
            IReadOnlyCollection<DateTime> child2ReadOnlyCollectionOfDateTimeProperty,
            IReadOnlyCollection<ModelEnum> child2ReadOnlyCollectionOfModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum> child2ReadOnlyCollectionOfModelFlagsEnumProperty,
            IReadOnlyCollection<ModelStruct> child2ReadOnlyCollectionOfModelStructProperty,
            IReadOnlyCollection<ModelEquatableStruct> child2ReadOnlyCollectionOfModelEquatableStructProperty,
            IReadOnlyCollection<ModelClass> child2ReadOnlyCollectionOfModelClassProperty,
            IReadOnlyCollection<ModelEquatableClass> child2ReadOnlyCollectionOfModelEquatableClassProperty,
            IReadOnlyCollection<bool?> child2ReadOnlyCollectionOfNullableBoolProperty,
            IReadOnlyCollection<int?> child2ReadOnlyCollectionOfNullableIntProperty,
            IReadOnlyCollection<Guid?> child2ReadOnlyCollectionOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> child2ReadOnlyCollectionOfNullableDateTimeProperty,
            IReadOnlyCollection<ModelEnum?> child2ReadOnlyCollectionOfNullableModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum?> child2ReadOnlyCollectionOfNullableModelFlagsEnumProperty,
            IReadOnlyCollection<ModelStruct?> child2ReadOnlyCollectionOfNullableModelStructProperty,
            IReadOnlyCollection<ModelEquatableStruct?> child2ReadOnlyCollectionOfNullableModelEquatableStructProperty,
            IReadOnlyDictionary<object, object> child2ReadOnlyDictionaryOfObjectProperty,
            IReadOnlyDictionary<bool, bool> child2ReadOnlyDictionaryOfBoolProperty,
            IReadOnlyDictionary<int, int> child2ReadOnlyDictionaryOfIntProperty,
            IReadOnlyDictionary<string, string> child2ReadOnlyDictionaryOfStringProperty,
            IReadOnlyDictionary<Guid, Guid> child2ReadOnlyDictionaryOfGuidProperty,
            IReadOnlyDictionary<DateTime, DateTime> child2ReadOnlyDictionaryOfDateTimeProperty,
            IReadOnlyDictionary<ModelEnum, ModelEnum> child2ReadOnlyDictionaryOfModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> child2ReadOnlyDictionaryOfModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelStruct, ModelStruct> child2ReadOnlyDictionaryOfModelStructProperty,
            IReadOnlyDictionary<ModelEquatableStruct, ModelEquatableStruct> child2ReadOnlyDictionaryOfModelEquatableStructProperty,
            IReadOnlyDictionary<ModelClass, ModelClass> child2ReadOnlyDictionaryOfModelClassProperty,
            IReadOnlyDictionary<ModelEquatableClass, ModelEquatableClass> child2ReadOnlyDictionaryOfModelEquatableClassProperty,
            IReadOnlyDictionary<bool?, bool?> child2ReadOnlyDictionaryOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> child2ReadOnlyDictionaryOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> child2ReadOnlyDictionaryOfNullableGuidProperty,
            IReadOnlyDictionary<DateTime?, DateTime?> child2ReadOnlyDictionaryOfNullableDateTimeProperty,
            IReadOnlyDictionary<ModelEnum?, ModelEnum?> child2ReadOnlyDictionaryOfNullableModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> child2ReadOnlyDictionaryOfNullableModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelStruct?, ModelStruct?> child2ReadOnlyDictionaryOfNullableModelStructProperty,
            IReadOnlyDictionary<ModelEquatableStruct?, ModelEquatableStruct?> child2ReadOnlyDictionaryOfNullableModelEquatableStructProperty)
            : base(parentObjectProperty, parentBoolProperty, parentIntProperty, parentStringProperty, parentGuidProperty, parentDateTimeProperty, parentModelEnumProperty, parentModelFlagsEnumProperty, parentModelStructProperty, parentModelEquatableStructProperty, parentModelClassProperty, parentModelEquatableClassProperty, parentNullableBoolProperty, parentNullableIntProperty, parentNullableGuidProperty, parentNullableDateTimeProperty, parentNullableModelEnumProperty, parentNullableModelFlagsEnumProperty, parentNullableModelStructProperty, parentNullableModelEquatableStructProperty, parentArrayOfObjectProperty, parentArrayOfBoolProperty, parentArrayOfIntProperty, parentArrayOfStringProperty, parentArrayOfGuidProperty, parentArrayOfDateTimeProperty, parentArrayOfModelEnumProperty, parentArrayOfModelFlagsEnumProperty, parentArrayOfModelStructProperty, parentArrayOfModelEquatableStructProperty, parentArrayOfModelClassProperty, parentArrayOfModelEquatableClassProperty, parentArrayOfNullableBoolProperty, parentArrayOfNullableIntProperty, parentArrayOfNullableGuidProperty, parentArrayOfNullableDateTimeProperty, parentArrayOfNullableModelEnumProperty, parentArrayOfNullableModelFlagsEnumProperty, parentArrayOfNullableModelStructProperty, parentArrayOfNullableModelEquatableStructProperty, parentReadOnlyCollectionOfObjectProperty, parentReadOnlyCollectionOfBoolProperty, parentReadOnlyCollectionOfIntProperty, parentReadOnlyCollectionOfStringProperty, parentReadOnlyCollectionOfGuidProperty, parentReadOnlyCollectionOfDateTimeProperty, parentReadOnlyCollectionOfModelEnumProperty, parentReadOnlyCollectionOfModelFlagsEnumProperty, parentReadOnlyCollectionOfModelStructProperty, parentReadOnlyCollectionOfModelEquatableStructProperty, parentReadOnlyCollectionOfModelClassProperty, parentReadOnlyCollectionOfModelEquatableClassProperty, parentReadOnlyCollectionOfNullableBoolProperty, parentReadOnlyCollectionOfNullableIntProperty, parentReadOnlyCollectionOfNullableGuidProperty, parentReadOnlyCollectionOfNullableDateTimeProperty, parentReadOnlyCollectionOfNullableModelEnumProperty, parentReadOnlyCollectionOfNullableModelFlagsEnumProperty, parentReadOnlyCollectionOfNullableModelStructProperty, parentReadOnlyCollectionOfNullableModelEquatableStructProperty, parentReadOnlyDictionaryOfObjectProperty, parentReadOnlyDictionaryOfBoolProperty, parentReadOnlyDictionaryOfIntProperty, parentReadOnlyDictionaryOfStringProperty, parentReadOnlyDictionaryOfGuidProperty, parentReadOnlyDictionaryOfDateTimeProperty, parentReadOnlyDictionaryOfModelEnumProperty, parentReadOnlyDictionaryOfModelFlagsEnumProperty, parentReadOnlyDictionaryOfModelStructProperty, parentReadOnlyDictionaryOfModelEquatableStructProperty, parentReadOnlyDictionaryOfModelClassProperty, parentReadOnlyDictionaryOfModelEquatableClassProperty, parentReadOnlyDictionaryOfNullableBoolProperty, parentReadOnlyDictionaryOfNullableIntProperty, parentReadOnlyDictionaryOfNullableGuidProperty, parentReadOnlyDictionaryOfNullableDateTimeProperty, parentReadOnlyDictionaryOfNullableModelEnumProperty, parentReadOnlyDictionaryOfNullableModelFlagsEnumProperty, parentReadOnlyDictionaryOfNullableModelStructProperty, parentReadOnlyDictionaryOfNullableModelEquatableStructProperty)
        {
            new { child2ObjectProperty }.Must().NotBeNull();
            new { child2StringProperty }.Must().NotBeNullNorWhiteSpace();
            new { child2ModelClassProperty }.Must().NotBeNull();
            new { child2ModelEquatableClassProperty }.Must().NotBeNull();
            new { child2ArrayOfObjectProperty }.Must().NotBeNull();
            new { child2ArrayOfBoolProperty }.Must().NotBeNull();
            new { child2ArrayOfIntProperty }.Must().NotBeNull();
            new { child2ArrayOfStringProperty }.Must().NotBeNull();
            new { child2ArrayOfGuidProperty }.Must().NotBeNull();
            new { child2ArrayOfDateTimeProperty }.Must().NotBeNull();
            new { child2ArrayOfModelEnumProperty }.Must().NotBeNull();
            new { child2ArrayOfModelFlagsEnumProperty }.Must().NotBeNull();
            new { child2ArrayOfModelStructProperty }.Must().NotBeNull();
            new { child2ArrayOfModelEquatableStructProperty }.Must().NotBeNull();
            new { child2ArrayOfModelClassProperty }.Must().NotBeNull();
            new { child2ArrayOfModelEquatableClassProperty }.Must().NotBeNull();
            new { child2ArrayOfNullableBoolProperty }.Must().NotBeNull();
            new { child2ArrayOfNullableIntProperty }.Must().NotBeNull();
            new { child2ArrayOfNullableGuidProperty }.Must().NotBeNull();
            new { child2ArrayOfNullableDateTimeProperty }.Must().NotBeNull();
            new { child2ArrayOfNullableModelEnumProperty }.Must().NotBeNull();
            new { child2ArrayOfNullableModelFlagsEnumProperty }.Must().NotBeNull();
            new { child2ArrayOfNullableModelStructProperty }.Must().NotBeNull();
            new { child2ArrayOfNullableModelEquatableStructProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfObjectProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfBoolProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfIntProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfStringProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfGuidProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfDateTimeProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfModelEnumProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfModelFlagsEnumProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfModelStructProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfModelEquatableStructProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfModelClassProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfModelEquatableClassProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfNullableBoolProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfNullableIntProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfNullableGuidProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfNullableDateTimeProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfNullableModelEnumProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfNullableModelFlagsEnumProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfNullableModelStructProperty }.Must().NotBeNull();
            new { child2ReadOnlyCollectionOfNullableModelEquatableStructProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfObjectProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfBoolProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfIntProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfStringProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfGuidProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfDateTimeProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfModelEnumProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfModelFlagsEnumProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfModelStructProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfModelEquatableStructProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfModelClassProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfModelEquatableClassProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfNullableBoolProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfNullableIntProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfNullableGuidProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfNullableDateTimeProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfNullableModelEnumProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfNullableModelFlagsEnumProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfNullableModelStructProperty }.Must().NotBeNull();
            new { child2ReadOnlyDictionaryOfNullableModelEquatableStructProperty }.Must().NotBeNull();

            this.Child2ObjectProperty = child2ObjectProperty;
            this.Child2BoolProperty = child2BoolProperty;
            this.Child2IntProperty = child2IntProperty;
            this.Child2StringProperty = child2StringProperty;
            this.Child2GuidProperty = child2GuidProperty;
            this.Child2DateTimeProperty = child2DateTimeProperty;
            this.Child2ModelEnumProperty = child2ModelEnumProperty;
            this.Child2ModelFlagsEnumProperty = child2ModelFlagsEnumProperty;
            this.Child2ModelStructProperty = child2ModelStructProperty;
            this.Child2ModelEquatableStructProperty = child2ModelEquatableStructProperty;
            this.Child2ModelClassProperty = child2ModelClassProperty;
            this.Child2ModelEquatableClassProperty = child2ModelEquatableClassProperty;
            this.Child2NullableBoolProperty = child2NullableBoolProperty;
            this.Child2NullableIntProperty = child2NullableIntProperty;
            this.Child2NullableGuidProperty = child2NullableGuidProperty;
            this.Child2NullableDateTimeProperty = child2NullableDateTimeProperty;
            this.Child2NullableModelEnumProperty = child2NullableModelEnumProperty;
            this.Child2NullableModelFlagsEnumProperty = child2NullableModelFlagsEnumProperty;
            this.Child2NullableModelStructProperty = child2NullableModelStructProperty;
            this.Child2NullableModelEquatableStructProperty = child2NullableModelEquatableStructProperty;
            this.Child2ArrayOfObjectProperty = child2ArrayOfObjectProperty;
            this.Child2ArrayOfBoolProperty = child2ArrayOfBoolProperty;
            this.Child2ArrayOfIntProperty = child2ArrayOfIntProperty;
            this.Child2ArrayOfStringProperty = child2ArrayOfStringProperty;
            this.Child2ArrayOfGuidProperty = child2ArrayOfGuidProperty;
            this.Child2ArrayOfDateTimeProperty = child2ArrayOfDateTimeProperty;
            this.Child2ArrayOfModelEnumProperty = child2ArrayOfModelEnumProperty;
            this.Child2ArrayOfModelFlagsEnumProperty = child2ArrayOfModelFlagsEnumProperty;
            this.Child2ArrayOfModelStructProperty = child2ArrayOfModelStructProperty;
            this.Child2ArrayOfModelEquatableStructProperty = child2ArrayOfModelEquatableStructProperty;
            this.Child2ArrayOfModelClassProperty = child2ArrayOfModelClassProperty;
            this.Child2ArrayOfModelEquatableClassProperty = child2ArrayOfModelEquatableClassProperty;
            this.Child2ArrayOfNullableBoolProperty = child2ArrayOfNullableBoolProperty;
            this.Child2ArrayOfNullableIntProperty = child2ArrayOfNullableIntProperty;
            this.Child2ArrayOfNullableGuidProperty = child2ArrayOfNullableGuidProperty;
            this.Child2ArrayOfNullableDateTimeProperty = child2ArrayOfNullableDateTimeProperty;
            this.Child2ArrayOfNullableModelEnumProperty = child2ArrayOfNullableModelEnumProperty;
            this.Child2ArrayOfNullableModelFlagsEnumProperty = child2ArrayOfNullableModelFlagsEnumProperty;
            this.Child2ArrayOfNullableModelStructProperty = child2ArrayOfNullableModelStructProperty;
            this.Child2ArrayOfNullableModelEquatableStructProperty = child2ArrayOfNullableModelEquatableStructProperty;
            this.Child2ReadOnlyCollectionOfObjectProperty = child2ReadOnlyCollectionOfObjectProperty;
            this.Child2ReadOnlyCollectionOfBoolProperty = child2ReadOnlyCollectionOfBoolProperty;
            this.Child2ReadOnlyCollectionOfIntProperty = child2ReadOnlyCollectionOfIntProperty;
            this.Child2ReadOnlyCollectionOfStringProperty = child2ReadOnlyCollectionOfStringProperty;
            this.Child2ReadOnlyCollectionOfGuidProperty = child2ReadOnlyCollectionOfGuidProperty;
            this.Child2ReadOnlyCollectionOfDateTimeProperty = child2ReadOnlyCollectionOfDateTimeProperty;
            this.Child2ReadOnlyCollectionOfModelEnumProperty = child2ReadOnlyCollectionOfModelEnumProperty;
            this.Child2ReadOnlyCollectionOfModelFlagsEnumProperty = child2ReadOnlyCollectionOfModelFlagsEnumProperty;
            this.Child2ReadOnlyCollectionOfModelStructProperty = child2ReadOnlyCollectionOfModelStructProperty;
            this.Child2ReadOnlyCollectionOfModelEquatableStructProperty = child2ReadOnlyCollectionOfModelEquatableStructProperty;
            this.Child2ReadOnlyCollectionOfModelClassProperty = child2ReadOnlyCollectionOfModelClassProperty;
            this.Child2ReadOnlyCollectionOfModelEquatableClassProperty = child2ReadOnlyCollectionOfModelEquatableClassProperty;
            this.Child2ReadOnlyCollectionOfNullableBoolProperty = child2ReadOnlyCollectionOfNullableBoolProperty;
            this.Child2ReadOnlyCollectionOfNullableIntProperty = child2ReadOnlyCollectionOfNullableIntProperty;
            this.Child2ReadOnlyCollectionOfNullableGuidProperty = child2ReadOnlyCollectionOfNullableGuidProperty;
            this.Child2ReadOnlyCollectionOfNullableDateTimeProperty = child2ReadOnlyCollectionOfNullableDateTimeProperty;
            this.Child2ReadOnlyCollectionOfNullableModelEnumProperty = child2ReadOnlyCollectionOfNullableModelEnumProperty;
            this.Child2ReadOnlyCollectionOfNullableModelFlagsEnumProperty = child2ReadOnlyCollectionOfNullableModelFlagsEnumProperty;
            this.Child2ReadOnlyCollectionOfNullableModelStructProperty = child2ReadOnlyCollectionOfNullableModelStructProperty;
            this.Child2ReadOnlyCollectionOfNullableModelEquatableStructProperty = child2ReadOnlyCollectionOfNullableModelEquatableStructProperty;
            this.Child2ReadOnlyDictionaryOfObjectProperty = child2ReadOnlyDictionaryOfObjectProperty;
            this.Child2ReadOnlyDictionaryOfBoolProperty = child2ReadOnlyDictionaryOfBoolProperty;
            this.Child2ReadOnlyDictionaryOfIntProperty = child2ReadOnlyDictionaryOfIntProperty;
            this.Child2ReadOnlyDictionaryOfStringProperty = child2ReadOnlyDictionaryOfStringProperty;
            this.Child2ReadOnlyDictionaryOfGuidProperty = child2ReadOnlyDictionaryOfGuidProperty;
            this.Child2ReadOnlyDictionaryOfDateTimeProperty = child2ReadOnlyDictionaryOfDateTimeProperty;
            this.Child2ReadOnlyDictionaryOfModelEnumProperty = child2ReadOnlyDictionaryOfModelEnumProperty;
            this.Child2ReadOnlyDictionaryOfModelFlagsEnumProperty = child2ReadOnlyDictionaryOfModelFlagsEnumProperty;
            this.Child2ReadOnlyDictionaryOfModelStructProperty = child2ReadOnlyDictionaryOfModelStructProperty;
            this.Child2ReadOnlyDictionaryOfModelEquatableStructProperty = child2ReadOnlyDictionaryOfModelEquatableStructProperty;
            this.Child2ReadOnlyDictionaryOfModelClassProperty = child2ReadOnlyDictionaryOfModelClassProperty;
            this.Child2ReadOnlyDictionaryOfModelEquatableClassProperty = child2ReadOnlyDictionaryOfModelEquatableClassProperty;
            this.Child2ReadOnlyDictionaryOfNullableBoolProperty = child2ReadOnlyDictionaryOfNullableBoolProperty;
            this.Child2ReadOnlyDictionaryOfNullableIntProperty = child2ReadOnlyDictionaryOfNullableIntProperty;
            this.Child2ReadOnlyDictionaryOfNullableGuidProperty = child2ReadOnlyDictionaryOfNullableGuidProperty;
            this.Child2ReadOnlyDictionaryOfNullableDateTimeProperty = child2ReadOnlyDictionaryOfNullableDateTimeProperty;
            this.Child2ReadOnlyDictionaryOfNullableModelEnumProperty = child2ReadOnlyDictionaryOfNullableModelEnumProperty;
            this.Child2ReadOnlyDictionaryOfNullableModelFlagsEnumProperty = child2ReadOnlyDictionaryOfNullableModelFlagsEnumProperty;
            this.Child2ReadOnlyDictionaryOfNullableModelStructProperty = child2ReadOnlyDictionaryOfNullableModelStructProperty;
            this.Child2ReadOnlyDictionaryOfNullableModelEquatableStructProperty = child2ReadOnlyDictionaryOfNullableModelEquatableStructProperty;
        }

        public object Child2ObjectProperty { get; }

        public bool Child2BoolProperty { get; }

        public int Child2IntProperty { get; }

        public string Child2StringProperty { get; }

        public Guid Child2GuidProperty { get; }

        public DateTime Child2DateTimeProperty { get; }

        public ModelEnum Child2ModelEnumProperty { get; }

        public ModelFlagsEnum Child2ModelFlagsEnumProperty { get; }

        public ModelStruct Child2ModelStructProperty { get; }

        public ModelEquatableStruct Child2ModelEquatableStructProperty { get; }

        public ModelClass Child2ModelClassProperty { get; }

        public ModelEquatableClass Child2ModelEquatableClassProperty { get; }

        public bool? Child2NullableBoolProperty { get; }

        public int? Child2NullableIntProperty { get; }

        public Guid? Child2NullableGuidProperty { get; }

        public DateTime? Child2NullableDateTimeProperty { get; }

        public ModelEnum? Child2NullableModelEnumProperty { get; }

        public ModelFlagsEnum? Child2NullableModelFlagsEnumProperty { get; }

        public ModelStruct? Child2NullableModelStructProperty { get; }

        public ModelEquatableStruct? Child2NullableModelEquatableStructProperty { get; }

        public object[] Child2ArrayOfObjectProperty { get; }

        public bool[] Child2ArrayOfBoolProperty { get; }

        public int[] Child2ArrayOfIntProperty { get; }

        public string[] Child2ArrayOfStringProperty { get; }

        public Guid[] Child2ArrayOfGuidProperty { get; }

        public DateTime[] Child2ArrayOfDateTimeProperty { get; }

        public ModelEnum[] Child2ArrayOfModelEnumProperty { get; }

        public ModelFlagsEnum[] Child2ArrayOfModelFlagsEnumProperty { get; }

        public ModelStruct[] Child2ArrayOfModelStructProperty { get; }

        public ModelEquatableStruct[] Child2ArrayOfModelEquatableStructProperty { get; }

        public ModelClass[] Child2ArrayOfModelClassProperty { get; }

        public ModelEquatableClass[] Child2ArrayOfModelEquatableClassProperty { get; }

        public bool?[] Child2ArrayOfNullableBoolProperty { get; }

        public int?[] Child2ArrayOfNullableIntProperty { get; }

        public Guid?[] Child2ArrayOfNullableGuidProperty { get; }

        public DateTime?[] Child2ArrayOfNullableDateTimeProperty { get; }

        public ModelEnum?[] Child2ArrayOfNullableModelEnumProperty { get; }

        public ModelFlagsEnum?[] Child2ArrayOfNullableModelFlagsEnumProperty { get; }

        public ModelStruct?[] Child2ArrayOfNullableModelStructProperty { get; }

        public ModelEquatableStruct?[] Child2ArrayOfNullableModelEquatableStructProperty { get; }

        public IReadOnlyCollection<object> Child2ReadOnlyCollectionOfObjectProperty { get; }

        public IReadOnlyCollection<bool> Child2ReadOnlyCollectionOfBoolProperty { get; }

        public IReadOnlyCollection<int> Child2ReadOnlyCollectionOfIntProperty { get; }

        public IReadOnlyCollection<string> Child2ReadOnlyCollectionOfStringProperty { get; }

        public IReadOnlyCollection<Guid> Child2ReadOnlyCollectionOfGuidProperty { get; }

        public IReadOnlyCollection<DateTime> Child2ReadOnlyCollectionOfDateTimeProperty { get; }

        public IReadOnlyCollection<ModelEnum> Child2ReadOnlyCollectionOfModelEnumProperty { get; }

        public IReadOnlyCollection<ModelFlagsEnum> Child2ReadOnlyCollectionOfModelFlagsEnumProperty { get; }

        public IReadOnlyCollection<ModelStruct> Child2ReadOnlyCollectionOfModelStructProperty { get; }

        public IReadOnlyCollection<ModelEquatableStruct> Child2ReadOnlyCollectionOfModelEquatableStructProperty { get; }

        public IReadOnlyCollection<ModelClass> Child2ReadOnlyCollectionOfModelClassProperty { get; }

        public IReadOnlyCollection<ModelEquatableClass> Child2ReadOnlyCollectionOfModelEquatableClassProperty { get; }

        public IReadOnlyCollection<bool?> Child2ReadOnlyCollectionOfNullableBoolProperty { get; }

        public IReadOnlyCollection<int?> Child2ReadOnlyCollectionOfNullableIntProperty { get; }

        public IReadOnlyCollection<Guid?> Child2ReadOnlyCollectionOfNullableGuidProperty { get; }

        public IReadOnlyCollection<DateTime?> Child2ReadOnlyCollectionOfNullableDateTimeProperty { get; }

        public IReadOnlyCollection<ModelEnum?> Child2ReadOnlyCollectionOfNullableModelEnumProperty { get; }

        public IReadOnlyCollection<ModelFlagsEnum?> Child2ReadOnlyCollectionOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyCollection<ModelStruct?> Child2ReadOnlyCollectionOfNullableModelStructProperty { get; }

        public IReadOnlyCollection<ModelEquatableStruct?> Child2ReadOnlyCollectionOfNullableModelEquatableStructProperty { get; }

        public IReadOnlyDictionary<object, object> Child2ReadOnlyDictionaryOfObjectProperty { get; }

        public IReadOnlyDictionary<bool, bool> Child2ReadOnlyDictionaryOfBoolProperty { get; }

        public IReadOnlyDictionary<int, int> Child2ReadOnlyDictionaryOfIntProperty { get; }

        public IReadOnlyDictionary<string, string> Child2ReadOnlyDictionaryOfStringProperty { get; }

        public IReadOnlyDictionary<Guid, Guid> Child2ReadOnlyDictionaryOfGuidProperty { get; }

        public IReadOnlyDictionary<DateTime, DateTime> Child2ReadOnlyDictionaryOfDateTimeProperty { get; }

        public IReadOnlyDictionary<ModelEnum, ModelEnum> Child2ReadOnlyDictionaryOfModelEnumProperty { get; }

        public IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> Child2ReadOnlyDictionaryOfModelFlagsEnumProperty { get; }

        public IReadOnlyDictionary<ModelStruct, ModelStruct> Child2ReadOnlyDictionaryOfModelStructProperty { get; }

        public IReadOnlyDictionary<ModelEquatableStruct, ModelEquatableStruct> Child2ReadOnlyDictionaryOfModelEquatableStructProperty { get; }

        public IReadOnlyDictionary<ModelClass, ModelClass> Child2ReadOnlyDictionaryOfModelClassProperty { get; }

        public IReadOnlyDictionary<ModelEquatableClass, ModelEquatableClass> Child2ReadOnlyDictionaryOfModelEquatableClassProperty { get; }

        public IReadOnlyDictionary<bool?, bool?> Child2ReadOnlyDictionaryOfNullableBoolProperty { get; }

        public IReadOnlyDictionary<int?, int?> Child2ReadOnlyDictionaryOfNullableIntProperty { get; }

        public IReadOnlyDictionary<Guid?, Guid?> Child2ReadOnlyDictionaryOfNullableGuidProperty { get; }

        public IReadOnlyDictionary<DateTime?, DateTime?> Child2ReadOnlyDictionaryOfNullableDateTimeProperty { get; }

        public IReadOnlyDictionary<ModelEnum?, ModelEnum?> Child2ReadOnlyDictionaryOfNullableModelEnumProperty { get; }

        public IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> Child2ReadOnlyDictionaryOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyDictionary<ModelStruct?, ModelStruct?> Child2ReadOnlyDictionaryOfNullableModelStructProperty { get; }

        public IReadOnlyDictionary<ModelEquatableStruct?, ModelEquatableStruct?> Child2ReadOnlyDictionaryOfNullableModelEquatableStructProperty { get; }
    }
}
