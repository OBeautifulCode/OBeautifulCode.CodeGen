﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelChild1.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class MyModelChild1 : MyModelParent, IModelViaCodeGen
    {
        public MyModelChild1(
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
            object child1ObjectProperty,
            bool child1BoolProperty,
            int child1IntProperty,
            string child1StringProperty,
            Guid child1GuidProperty,
            DateTime child1DateTimeProperty,
            ModelEnum child1ModelEnumProperty,
            ModelFlagsEnum child1ModelFlagsEnumProperty,
            ModelStruct child1ModelStructProperty,
            ModelEquatableStruct child1ModelEquatableStructProperty,
            ModelClass child1ModelClassProperty,
            ModelEquatableClass child1ModelEquatableClassProperty,
            bool? child1NullableBoolProperty,
            int? child1NullableIntProperty,
            Guid? child1NullableGuidProperty,
            DateTime? child1NullableDateTimeProperty,
            ModelEnum? child1NullableModelEnumProperty,
            ModelFlagsEnum? child1NullableModelFlagsEnumProperty,
            ModelStruct? child1NullableModelStructProperty,
            ModelEquatableStruct? child1NullableModelEquatableStructProperty,
            object[] child1ArrayOfObjectProperty,
            bool[] child1ArrayOfBoolProperty,
            int[] child1ArrayOfIntProperty,
            string[] child1ArrayOfStringProperty,
            Guid[] child1ArrayOfGuidProperty,
            DateTime[] child1ArrayOfDateTimeProperty,
            ModelEnum[] child1ArrayOfModelEnumProperty,
            ModelFlagsEnum[] child1ArrayOfModelFlagsEnumProperty,
            ModelStruct[] child1ArrayOfModelStructProperty,
            ModelEquatableStruct[] child1ArrayOfModelEquatableStructProperty,
            ModelClass[] child1ArrayOfModelClassProperty,
            ModelEquatableClass[] child1ArrayOfModelEquatableClassProperty,
            bool?[] child1ArrayOfNullableBoolProperty,
            int?[] child1ArrayOfNullableIntProperty,
            Guid?[] child1ArrayOfNullableGuidProperty,
            DateTime?[] child1ArrayOfNullableDateTimeProperty,
            ModelEnum?[] child1ArrayOfNullableModelEnumProperty,
            ModelFlagsEnum?[] child1ArrayOfNullableModelFlagsEnumProperty,
            ModelStruct?[] child1ArrayOfNullableModelStructProperty,
            ModelEquatableStruct?[] child1ArrayOfNullableModelEquatableStructProperty,
            IReadOnlyCollection<object> child1ReadOnlyCollectionOfObjectProperty,
            IReadOnlyCollection<bool> child1ReadOnlyCollectionOfBoolProperty,
            IReadOnlyCollection<int> child1ReadOnlyCollectionOfIntProperty,
            IReadOnlyCollection<string> child1ReadOnlyCollectionOfStringProperty,
            IReadOnlyCollection<Guid> child1ReadOnlyCollectionOfGuidProperty,
            IReadOnlyCollection<DateTime> child1ReadOnlyCollectionOfDateTimeProperty,
            IReadOnlyCollection<ModelEnum> child1ReadOnlyCollectionOfModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum> child1ReadOnlyCollectionOfModelFlagsEnumProperty,
            IReadOnlyCollection<ModelStruct> child1ReadOnlyCollectionOfModelStructProperty,
            IReadOnlyCollection<ModelEquatableStruct> child1ReadOnlyCollectionOfModelEquatableStructProperty,
            IReadOnlyCollection<ModelClass> child1ReadOnlyCollectionOfModelClassProperty,
            IReadOnlyCollection<ModelEquatableClass> child1ReadOnlyCollectionOfModelEquatableClassProperty,
            IReadOnlyCollection<bool?> child1ReadOnlyCollectionOfNullableBoolProperty,
            IReadOnlyCollection<int?> child1ReadOnlyCollectionOfNullableIntProperty,
            IReadOnlyCollection<Guid?> child1ReadOnlyCollectionOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> child1ReadOnlyCollectionOfNullableDateTimeProperty,
            IReadOnlyCollection<ModelEnum?> child1ReadOnlyCollectionOfNullableModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum?> child1ReadOnlyCollectionOfNullableModelFlagsEnumProperty,
            IReadOnlyCollection<ModelStruct?> child1ReadOnlyCollectionOfNullableModelStructProperty,
            IReadOnlyCollection<ModelEquatableStruct?> child1ReadOnlyCollectionOfNullableModelEquatableStructProperty,
            IReadOnlyDictionary<object, object> child1ReadOnlyDictionaryOfObjectProperty,
            IReadOnlyDictionary<bool, bool> child1ReadOnlyDictionaryOfBoolProperty,
            IReadOnlyDictionary<int, int> child1ReadOnlyDictionaryOfIntProperty,
            IReadOnlyDictionary<string, string> child1ReadOnlyDictionaryOfStringProperty,
            IReadOnlyDictionary<Guid, Guid> child1ReadOnlyDictionaryOfGuidProperty,
            IReadOnlyDictionary<DateTime, DateTime> child1ReadOnlyDictionaryOfDateTimeProperty,
            IReadOnlyDictionary<ModelEnum, ModelEnum> child1ReadOnlyDictionaryOfModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> child1ReadOnlyDictionaryOfModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelStruct, ModelStruct> child1ReadOnlyDictionaryOfModelStructProperty,
            IReadOnlyDictionary<ModelEquatableStruct, ModelEquatableStruct> child1ReadOnlyDictionaryOfModelEquatableStructProperty,
            IReadOnlyDictionary<ModelClass, ModelClass> child1ReadOnlyDictionaryOfModelClassProperty,
            IReadOnlyDictionary<ModelEquatableClass, ModelEquatableClass> child1ReadOnlyDictionaryOfModelEquatableClassProperty,
            IReadOnlyDictionary<bool?, bool?> child1ReadOnlyDictionaryOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> child1ReadOnlyDictionaryOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> child1ReadOnlyDictionaryOfNullableGuidProperty,
            IReadOnlyDictionary<DateTime?, DateTime?> child1ReadOnlyDictionaryOfNullableDateTimeProperty,
            IReadOnlyDictionary<ModelEnum?, ModelEnum?> child1ReadOnlyDictionaryOfNullableModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> child1ReadOnlyDictionaryOfNullableModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelStruct?, ModelStruct?> child1ReadOnlyDictionaryOfNullableModelStructProperty,
            IReadOnlyDictionary<ModelEquatableStruct?, ModelEquatableStruct?> child1ReadOnlyDictionaryOfNullableModelEquatableStructProperty)
            : base(parentObjectProperty, parentBoolProperty, parentIntProperty, parentStringProperty, parentGuidProperty, parentDateTimeProperty, parentModelEnumProperty, parentModelFlagsEnumProperty, parentModelStructProperty, parentModelEquatableStructProperty, parentModelClassProperty, parentModelEquatableClassProperty, parentNullableBoolProperty, parentNullableIntProperty, parentNullableGuidProperty, parentNullableDateTimeProperty, parentNullableModelEnumProperty, parentNullableModelFlagsEnumProperty, parentNullableModelStructProperty, parentNullableModelEquatableStructProperty, parentArrayOfObjectProperty, parentArrayOfBoolProperty, parentArrayOfIntProperty, parentArrayOfStringProperty, parentArrayOfGuidProperty, parentArrayOfDateTimeProperty, parentArrayOfModelEnumProperty, parentArrayOfModelFlagsEnumProperty, parentArrayOfModelStructProperty, parentArrayOfModelEquatableStructProperty, parentArrayOfModelClassProperty, parentArrayOfModelEquatableClassProperty, parentArrayOfNullableBoolProperty, parentArrayOfNullableIntProperty, parentArrayOfNullableGuidProperty, parentArrayOfNullableDateTimeProperty, parentArrayOfNullableModelEnumProperty, parentArrayOfNullableModelFlagsEnumProperty, parentArrayOfNullableModelStructProperty, parentArrayOfNullableModelEquatableStructProperty, parentReadOnlyCollectionOfObjectProperty, parentReadOnlyCollectionOfBoolProperty, parentReadOnlyCollectionOfIntProperty, parentReadOnlyCollectionOfStringProperty, parentReadOnlyCollectionOfGuidProperty, parentReadOnlyCollectionOfDateTimeProperty, parentReadOnlyCollectionOfModelEnumProperty, parentReadOnlyCollectionOfModelFlagsEnumProperty, parentReadOnlyCollectionOfModelStructProperty, parentReadOnlyCollectionOfModelEquatableStructProperty, parentReadOnlyCollectionOfModelClassProperty, parentReadOnlyCollectionOfModelEquatableClassProperty, parentReadOnlyCollectionOfNullableBoolProperty, parentReadOnlyCollectionOfNullableIntProperty, parentReadOnlyCollectionOfNullableGuidProperty, parentReadOnlyCollectionOfNullableDateTimeProperty, parentReadOnlyCollectionOfNullableModelEnumProperty, parentReadOnlyCollectionOfNullableModelFlagsEnumProperty, parentReadOnlyCollectionOfNullableModelStructProperty, parentReadOnlyCollectionOfNullableModelEquatableStructProperty, parentReadOnlyDictionaryOfObjectProperty, parentReadOnlyDictionaryOfBoolProperty, parentReadOnlyDictionaryOfIntProperty, parentReadOnlyDictionaryOfStringProperty, parentReadOnlyDictionaryOfGuidProperty, parentReadOnlyDictionaryOfDateTimeProperty, parentReadOnlyDictionaryOfModelEnumProperty, parentReadOnlyDictionaryOfModelFlagsEnumProperty, parentReadOnlyDictionaryOfModelStructProperty, parentReadOnlyDictionaryOfModelEquatableStructProperty, parentReadOnlyDictionaryOfModelClassProperty, parentReadOnlyDictionaryOfModelEquatableClassProperty, parentReadOnlyDictionaryOfNullableBoolProperty, parentReadOnlyDictionaryOfNullableIntProperty, parentReadOnlyDictionaryOfNullableGuidProperty, parentReadOnlyDictionaryOfNullableDateTimeProperty, parentReadOnlyDictionaryOfNullableModelEnumProperty, parentReadOnlyDictionaryOfNullableModelFlagsEnumProperty, parentReadOnlyDictionaryOfNullableModelStructProperty, parentReadOnlyDictionaryOfNullableModelEquatableStructProperty)
        {
            new { child1ObjectProperty }.AsArg().Must().NotBeNull();
            new { child1StringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { child1ModelClassProperty }.AsArg().Must().NotBeNull();
            new { child1ModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfObjectProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfBoolProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfIntProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfStringProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfGuidProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfDateTimeProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfModelEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfModelStructProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfModelClassProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfNullableBoolProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfNullableIntProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfNullableGuidProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfNullableDateTimeProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfNullableModelEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfNullableModelStructProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfNullableModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfObjectProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfBoolProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfIntProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfGuidProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfDateTimeProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfModelEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfModelStructProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfModelClassProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfNullableBoolProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfNullableIntProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfNullableGuidProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfNullableDateTimeProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfNullableModelEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfNullableModelStructProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyCollectionOfNullableModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfObjectProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfBoolProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfIntProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfStringProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfGuidProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfDateTimeProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfModelEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfModelStructProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfModelClassProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfNullableBoolProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfNullableIntProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfNullableGuidProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfNullableDateTimeProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfNullableModelEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfNullableModelStructProperty }.AsArg().Must().NotBeNull();
            new { child1ReadOnlyDictionaryOfNullableModelEquatableStructProperty }.AsArg().Must().NotBeNull();

            this.Child1ObjectProperty = child1ObjectProperty;
            this.Child1BoolProperty = child1BoolProperty;
            this.Child1IntProperty = child1IntProperty;
            this.Child1StringProperty = child1StringProperty;
            this.Child1GuidProperty = child1GuidProperty;
            this.Child1DateTimeProperty = child1DateTimeProperty;
            this.Child1ModelEnumProperty = child1ModelEnumProperty;
            this.Child1ModelFlagsEnumProperty = child1ModelFlagsEnumProperty;
            this.Child1ModelStructProperty = child1ModelStructProperty;
            this.Child1ModelEquatableStructProperty = child1ModelEquatableStructProperty;
            this.Child1ModelClassProperty = child1ModelClassProperty;
            this.Child1ModelEquatableClassProperty = child1ModelEquatableClassProperty;
            this.Child1NullableBoolProperty = child1NullableBoolProperty;
            this.Child1NullableIntProperty = child1NullableIntProperty;
            this.Child1NullableGuidProperty = child1NullableGuidProperty;
            this.Child1NullableDateTimeProperty = child1NullableDateTimeProperty;
            this.Child1NullableModelEnumProperty = child1NullableModelEnumProperty;
            this.Child1NullableModelFlagsEnumProperty = child1NullableModelFlagsEnumProperty;
            this.Child1NullableModelStructProperty = child1NullableModelStructProperty;
            this.Child1NullableModelEquatableStructProperty = child1NullableModelEquatableStructProperty;
            this.Child1ArrayOfObjectProperty = child1ArrayOfObjectProperty;
            this.Child1ArrayOfBoolProperty = child1ArrayOfBoolProperty;
            this.Child1ArrayOfIntProperty = child1ArrayOfIntProperty;
            this.Child1ArrayOfStringProperty = child1ArrayOfStringProperty;
            this.Child1ArrayOfGuidProperty = child1ArrayOfGuidProperty;
            this.Child1ArrayOfDateTimeProperty = child1ArrayOfDateTimeProperty;
            this.Child1ArrayOfModelEnumProperty = child1ArrayOfModelEnumProperty;
            this.Child1ArrayOfModelFlagsEnumProperty = child1ArrayOfModelFlagsEnumProperty;
            this.Child1ArrayOfModelStructProperty = child1ArrayOfModelStructProperty;
            this.Child1ArrayOfModelEquatableStructProperty = child1ArrayOfModelEquatableStructProperty;
            this.Child1ArrayOfModelClassProperty = child1ArrayOfModelClassProperty;
            this.Child1ArrayOfModelEquatableClassProperty = child1ArrayOfModelEquatableClassProperty;
            this.Child1ArrayOfNullableBoolProperty = child1ArrayOfNullableBoolProperty;
            this.Child1ArrayOfNullableIntProperty = child1ArrayOfNullableIntProperty;
            this.Child1ArrayOfNullableGuidProperty = child1ArrayOfNullableGuidProperty;
            this.Child1ArrayOfNullableDateTimeProperty = child1ArrayOfNullableDateTimeProperty;
            this.Child1ArrayOfNullableModelEnumProperty = child1ArrayOfNullableModelEnumProperty;
            this.Child1ArrayOfNullableModelFlagsEnumProperty = child1ArrayOfNullableModelFlagsEnumProperty;
            this.Child1ArrayOfNullableModelStructProperty = child1ArrayOfNullableModelStructProperty;
            this.Child1ArrayOfNullableModelEquatableStructProperty = child1ArrayOfNullableModelEquatableStructProperty;
            this.Child1ReadOnlyCollectionOfObjectProperty = child1ReadOnlyCollectionOfObjectProperty;
            this.Child1ReadOnlyCollectionOfBoolProperty = child1ReadOnlyCollectionOfBoolProperty;
            this.Child1ReadOnlyCollectionOfIntProperty = child1ReadOnlyCollectionOfIntProperty;
            this.Child1ReadOnlyCollectionOfStringProperty = child1ReadOnlyCollectionOfStringProperty;
            this.Child1ReadOnlyCollectionOfGuidProperty = child1ReadOnlyCollectionOfGuidProperty;
            this.Child1ReadOnlyCollectionOfDateTimeProperty = child1ReadOnlyCollectionOfDateTimeProperty;
            this.Child1ReadOnlyCollectionOfModelEnumProperty = child1ReadOnlyCollectionOfModelEnumProperty;
            this.Child1ReadOnlyCollectionOfModelFlagsEnumProperty = child1ReadOnlyCollectionOfModelFlagsEnumProperty;
            this.Child1ReadOnlyCollectionOfModelStructProperty = child1ReadOnlyCollectionOfModelStructProperty;
            this.Child1ReadOnlyCollectionOfModelEquatableStructProperty = child1ReadOnlyCollectionOfModelEquatableStructProperty;
            this.Child1ReadOnlyCollectionOfModelClassProperty = child1ReadOnlyCollectionOfModelClassProperty;
            this.Child1ReadOnlyCollectionOfModelEquatableClassProperty = child1ReadOnlyCollectionOfModelEquatableClassProperty;
            this.Child1ReadOnlyCollectionOfNullableBoolProperty = child1ReadOnlyCollectionOfNullableBoolProperty;
            this.Child1ReadOnlyCollectionOfNullableIntProperty = child1ReadOnlyCollectionOfNullableIntProperty;
            this.Child1ReadOnlyCollectionOfNullableGuidProperty = child1ReadOnlyCollectionOfNullableGuidProperty;
            this.Child1ReadOnlyCollectionOfNullableDateTimeProperty = child1ReadOnlyCollectionOfNullableDateTimeProperty;
            this.Child1ReadOnlyCollectionOfNullableModelEnumProperty = child1ReadOnlyCollectionOfNullableModelEnumProperty;
            this.Child1ReadOnlyCollectionOfNullableModelFlagsEnumProperty = child1ReadOnlyCollectionOfNullableModelFlagsEnumProperty;
            this.Child1ReadOnlyCollectionOfNullableModelStructProperty = child1ReadOnlyCollectionOfNullableModelStructProperty;
            this.Child1ReadOnlyCollectionOfNullableModelEquatableStructProperty = child1ReadOnlyCollectionOfNullableModelEquatableStructProperty;
            this.Child1ReadOnlyDictionaryOfObjectProperty = child1ReadOnlyDictionaryOfObjectProperty;
            this.Child1ReadOnlyDictionaryOfBoolProperty = child1ReadOnlyDictionaryOfBoolProperty;
            this.Child1ReadOnlyDictionaryOfIntProperty = child1ReadOnlyDictionaryOfIntProperty;
            this.Child1ReadOnlyDictionaryOfStringProperty = child1ReadOnlyDictionaryOfStringProperty;
            this.Child1ReadOnlyDictionaryOfGuidProperty = child1ReadOnlyDictionaryOfGuidProperty;
            this.Child1ReadOnlyDictionaryOfDateTimeProperty = child1ReadOnlyDictionaryOfDateTimeProperty;
            this.Child1ReadOnlyDictionaryOfModelEnumProperty = child1ReadOnlyDictionaryOfModelEnumProperty;
            this.Child1ReadOnlyDictionaryOfModelFlagsEnumProperty = child1ReadOnlyDictionaryOfModelFlagsEnumProperty;
            this.Child1ReadOnlyDictionaryOfModelStructProperty = child1ReadOnlyDictionaryOfModelStructProperty;
            this.Child1ReadOnlyDictionaryOfModelEquatableStructProperty = child1ReadOnlyDictionaryOfModelEquatableStructProperty;
            this.Child1ReadOnlyDictionaryOfModelClassProperty = child1ReadOnlyDictionaryOfModelClassProperty;
            this.Child1ReadOnlyDictionaryOfModelEquatableClassProperty = child1ReadOnlyDictionaryOfModelEquatableClassProperty;
            this.Child1ReadOnlyDictionaryOfNullableBoolProperty = child1ReadOnlyDictionaryOfNullableBoolProperty;
            this.Child1ReadOnlyDictionaryOfNullableIntProperty = child1ReadOnlyDictionaryOfNullableIntProperty;
            this.Child1ReadOnlyDictionaryOfNullableGuidProperty = child1ReadOnlyDictionaryOfNullableGuidProperty;
            this.Child1ReadOnlyDictionaryOfNullableDateTimeProperty = child1ReadOnlyDictionaryOfNullableDateTimeProperty;
            this.Child1ReadOnlyDictionaryOfNullableModelEnumProperty = child1ReadOnlyDictionaryOfNullableModelEnumProperty;
            this.Child1ReadOnlyDictionaryOfNullableModelFlagsEnumProperty = child1ReadOnlyDictionaryOfNullableModelFlagsEnumProperty;
            this.Child1ReadOnlyDictionaryOfNullableModelStructProperty = child1ReadOnlyDictionaryOfNullableModelStructProperty;
            this.Child1ReadOnlyDictionaryOfNullableModelEquatableStructProperty = child1ReadOnlyDictionaryOfNullableModelEquatableStructProperty;
        }

        public object Child1ObjectProperty { get; }

        public bool Child1BoolProperty { get; }

        public int Child1IntProperty { get; }

        public string Child1StringProperty { get; }

        public Guid Child1GuidProperty { get; }

        public DateTime Child1DateTimeProperty { get; }

        public ModelEnum Child1ModelEnumProperty { get; }

        public ModelFlagsEnum Child1ModelFlagsEnumProperty { get; }

        public ModelStruct Child1ModelStructProperty { get; }

        public ModelEquatableStruct Child1ModelEquatableStructProperty { get; }

        public ModelClass Child1ModelClassProperty { get; }

        public ModelEquatableClass Child1ModelEquatableClassProperty { get; }

        public bool? Child1NullableBoolProperty { get; }

        public int? Child1NullableIntProperty { get; }

        public Guid? Child1NullableGuidProperty { get; }

        public DateTime? Child1NullableDateTimeProperty { get; }

        public ModelEnum? Child1NullableModelEnumProperty { get; }

        public ModelFlagsEnum? Child1NullableModelFlagsEnumProperty { get; }

        public ModelStruct? Child1NullableModelStructProperty { get; }

        public ModelEquatableStruct? Child1NullableModelEquatableStructProperty { get; }

        public object[] Child1ArrayOfObjectProperty { get; }

        public bool[] Child1ArrayOfBoolProperty { get; }

        public int[] Child1ArrayOfIntProperty { get; }

        public string[] Child1ArrayOfStringProperty { get; }

        public Guid[] Child1ArrayOfGuidProperty { get; }

        public DateTime[] Child1ArrayOfDateTimeProperty { get; }

        public ModelEnum[] Child1ArrayOfModelEnumProperty { get; }

        public ModelFlagsEnum[] Child1ArrayOfModelFlagsEnumProperty { get; }

        public ModelStruct[] Child1ArrayOfModelStructProperty { get; }

        public ModelEquatableStruct[] Child1ArrayOfModelEquatableStructProperty { get; }

        public ModelClass[] Child1ArrayOfModelClassProperty { get; }

        public ModelEquatableClass[] Child1ArrayOfModelEquatableClassProperty { get; }

        public bool?[] Child1ArrayOfNullableBoolProperty { get; }

        public int?[] Child1ArrayOfNullableIntProperty { get; }

        public Guid?[] Child1ArrayOfNullableGuidProperty { get; }

        public DateTime?[] Child1ArrayOfNullableDateTimeProperty { get; }

        public ModelEnum?[] Child1ArrayOfNullableModelEnumProperty { get; }

        public ModelFlagsEnum?[] Child1ArrayOfNullableModelFlagsEnumProperty { get; }

        public ModelStruct?[] Child1ArrayOfNullableModelStructProperty { get; }

        public ModelEquatableStruct?[] Child1ArrayOfNullableModelEquatableStructProperty { get; }

        public IReadOnlyCollection<object> Child1ReadOnlyCollectionOfObjectProperty { get; }

        public IReadOnlyCollection<bool> Child1ReadOnlyCollectionOfBoolProperty { get; }

        public IReadOnlyCollection<int> Child1ReadOnlyCollectionOfIntProperty { get; }

        public IReadOnlyCollection<string> Child1ReadOnlyCollectionOfStringProperty { get; }

        public IReadOnlyCollection<Guid> Child1ReadOnlyCollectionOfGuidProperty { get; }

        public IReadOnlyCollection<DateTime> Child1ReadOnlyCollectionOfDateTimeProperty { get; }

        public IReadOnlyCollection<ModelEnum> Child1ReadOnlyCollectionOfModelEnumProperty { get; }

        public IReadOnlyCollection<ModelFlagsEnum> Child1ReadOnlyCollectionOfModelFlagsEnumProperty { get; }

        public IReadOnlyCollection<ModelStruct> Child1ReadOnlyCollectionOfModelStructProperty { get; }

        public IReadOnlyCollection<ModelEquatableStruct> Child1ReadOnlyCollectionOfModelEquatableStructProperty { get; }

        public IReadOnlyCollection<ModelClass> Child1ReadOnlyCollectionOfModelClassProperty { get; }

        public IReadOnlyCollection<ModelEquatableClass> Child1ReadOnlyCollectionOfModelEquatableClassProperty { get; }

        public IReadOnlyCollection<bool?> Child1ReadOnlyCollectionOfNullableBoolProperty { get; }

        public IReadOnlyCollection<int?> Child1ReadOnlyCollectionOfNullableIntProperty { get; }

        public IReadOnlyCollection<Guid?> Child1ReadOnlyCollectionOfNullableGuidProperty { get; }

        public IReadOnlyCollection<DateTime?> Child1ReadOnlyCollectionOfNullableDateTimeProperty { get; }

        public IReadOnlyCollection<ModelEnum?> Child1ReadOnlyCollectionOfNullableModelEnumProperty { get; }

        public IReadOnlyCollection<ModelFlagsEnum?> Child1ReadOnlyCollectionOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyCollection<ModelStruct?> Child1ReadOnlyCollectionOfNullableModelStructProperty { get; }

        public IReadOnlyCollection<ModelEquatableStruct?> Child1ReadOnlyCollectionOfNullableModelEquatableStructProperty { get; }

        public IReadOnlyDictionary<object, object> Child1ReadOnlyDictionaryOfObjectProperty { get; }

        public IReadOnlyDictionary<bool, bool> Child1ReadOnlyDictionaryOfBoolProperty { get; }

        public IReadOnlyDictionary<int, int> Child1ReadOnlyDictionaryOfIntProperty { get; }

        public IReadOnlyDictionary<string, string> Child1ReadOnlyDictionaryOfStringProperty { get; }

        public IReadOnlyDictionary<Guid, Guid> Child1ReadOnlyDictionaryOfGuidProperty { get; }

        public IReadOnlyDictionary<DateTime, DateTime> Child1ReadOnlyDictionaryOfDateTimeProperty { get; }

        public IReadOnlyDictionary<ModelEnum, ModelEnum> Child1ReadOnlyDictionaryOfModelEnumProperty { get; }

        public IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> Child1ReadOnlyDictionaryOfModelFlagsEnumProperty { get; }

        public IReadOnlyDictionary<ModelStruct, ModelStruct> Child1ReadOnlyDictionaryOfModelStructProperty { get; }

        public IReadOnlyDictionary<ModelEquatableStruct, ModelEquatableStruct> Child1ReadOnlyDictionaryOfModelEquatableStructProperty { get; }

        public IReadOnlyDictionary<ModelClass, ModelClass> Child1ReadOnlyDictionaryOfModelClassProperty { get; }

        public IReadOnlyDictionary<ModelEquatableClass, ModelEquatableClass> Child1ReadOnlyDictionaryOfModelEquatableClassProperty { get; }

        public IReadOnlyDictionary<bool?, bool?> Child1ReadOnlyDictionaryOfNullableBoolProperty { get; }

        public IReadOnlyDictionary<int?, int?> Child1ReadOnlyDictionaryOfNullableIntProperty { get; }

        public IReadOnlyDictionary<Guid?, Guid?> Child1ReadOnlyDictionaryOfNullableGuidProperty { get; }

        public IReadOnlyDictionary<DateTime?, DateTime?> Child1ReadOnlyDictionaryOfNullableDateTimeProperty { get; }

        public IReadOnlyDictionary<ModelEnum?, ModelEnum?> Child1ReadOnlyDictionaryOfNullableModelEnumProperty { get; }

        public IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> Child1ReadOnlyDictionaryOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyDictionary<ModelStruct?, ModelStruct?> Child1ReadOnlyDictionaryOfNullableModelStructProperty { get; }

        public IReadOnlyDictionary<ModelEquatableStruct?, ModelEquatableStruct?> Child1ReadOnlyDictionaryOfNullableModelEquatableStructProperty { get; }
    }
}