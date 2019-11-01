// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Type;
    using OBeautifulCode.Validation.Recipes;

    public abstract partial class MyModelParent : IModelViaCodeGen
    {
        public MyModelParent(
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
            IReadOnlyDictionary<ModelEquatableStruct?, ModelEquatableStruct?> parentReadOnlyDictionaryOfNullableModelEquatableStructProperty)
        {
            new { parentObjectProperty }.Must().NotBeNull();
            new { parentStringProperty }.Must().NotBeNullNorWhiteSpace();
            new { parentModelClassProperty }.Must().NotBeNull();
            new { parentModelEquatableClassProperty }.Must().NotBeNull();
            new { parentArrayOfObjectProperty }.Must().NotBeNull();
            new { parentArrayOfBoolProperty }.Must().NotBeNull();
            new { parentArrayOfIntProperty }.Must().NotBeNull();
            new { parentArrayOfStringProperty }.Must().NotBeNull();
            new { parentArrayOfGuidProperty }.Must().NotBeNull();
            new { parentArrayOfDateTimeProperty }.Must().NotBeNull();
            new { parentArrayOfModelEnumProperty }.Must().NotBeNull();
            new { parentArrayOfModelFlagsEnumProperty }.Must().NotBeNull();
            new { parentArrayOfModelStructProperty }.Must().NotBeNull();
            new { parentArrayOfModelEquatableStructProperty }.Must().NotBeNull();
            new { parentArrayOfModelClassProperty }.Must().NotBeNull();
            new { parentArrayOfModelEquatableClassProperty }.Must().NotBeNull();
            new { parentArrayOfNullableBoolProperty }.Must().NotBeNull();
            new { parentArrayOfNullableIntProperty }.Must().NotBeNull();
            new { parentArrayOfNullableGuidProperty }.Must().NotBeNull();
            new { parentArrayOfNullableDateTimeProperty }.Must().NotBeNull();
            new { parentArrayOfNullableModelEnumProperty }.Must().NotBeNull();
            new { parentArrayOfNullableModelFlagsEnumProperty }.Must().NotBeNull();
            new { parentArrayOfNullableModelStructProperty }.Must().NotBeNull();
            new { parentArrayOfNullableModelEquatableStructProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfObjectProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfBoolProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfIntProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfStringProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfGuidProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfDateTimeProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelEnumProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelFlagsEnumProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelStructProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelEquatableStructProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelClassProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelEquatableClassProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableBoolProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableIntProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableGuidProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableDateTimeProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableModelEnumProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableModelFlagsEnumProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableModelStructProperty }.Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableModelEquatableStructProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfObjectProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfBoolProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfIntProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfStringProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfGuidProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfDateTimeProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelEnumProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelFlagsEnumProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelStructProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelEquatableStructProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelClassProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelEquatableClassProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableBoolProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableIntProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableGuidProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableDateTimeProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableModelEnumProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableModelFlagsEnumProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableModelStructProperty }.Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableModelEquatableStructProperty }.Must().NotBeNull();

            this.ParentObjectProperty = parentObjectProperty;
            this.ParentBoolProperty = parentBoolProperty;
            this.ParentIntProperty = parentIntProperty;
            this.ParentStringProperty = parentStringProperty;
            this.ParentGuidProperty = parentGuidProperty;
            this.ParentDateTimeProperty = parentDateTimeProperty;
            this.ParentModelEnumProperty = parentModelEnumProperty;
            this.ParentModelFlagsEnumProperty = parentModelFlagsEnumProperty;
            this.ParentModelStructProperty = parentModelStructProperty;
            this.ParentModelEquatableStructProperty = parentModelEquatableStructProperty;
            this.ParentModelClassProperty = parentModelClassProperty;
            this.ParentModelEquatableClassProperty = parentModelEquatableClassProperty;
            this.ParentNullableBoolProperty = parentNullableBoolProperty;
            this.ParentNullableIntProperty = parentNullableIntProperty;
            this.ParentNullableGuidProperty = parentNullableGuidProperty;
            this.ParentNullableDateTimeProperty = parentNullableDateTimeProperty;
            this.ParentNullableModelEnumProperty = parentNullableModelEnumProperty;
            this.ParentNullableModelFlagsEnumProperty = parentNullableModelFlagsEnumProperty;
            this.ParentNullableModelStructProperty = parentNullableModelStructProperty;
            this.ParentNullableModelEquatableStructProperty = parentNullableModelEquatableStructProperty;
            this.ParentArrayOfObjectProperty = parentArrayOfObjectProperty;
            this.ParentArrayOfBoolProperty = parentArrayOfBoolProperty;
            this.ParentArrayOfIntProperty = parentArrayOfIntProperty;
            this.ParentArrayOfStringProperty = parentArrayOfStringProperty;
            this.ParentArrayOfGuidProperty = parentArrayOfGuidProperty;
            this.ParentArrayOfDateTimeProperty = parentArrayOfDateTimeProperty;
            this.ParentArrayOfModelEnumProperty = parentArrayOfModelEnumProperty;
            this.ParentArrayOfModelFlagsEnumProperty = parentArrayOfModelFlagsEnumProperty;
            this.ParentArrayOfModelStructProperty = parentArrayOfModelStructProperty;
            this.ParentArrayOfModelEquatableStructProperty = parentArrayOfModelEquatableStructProperty;
            this.ParentArrayOfModelClassProperty = parentArrayOfModelClassProperty;
            this.ParentArrayOfModelEquatableClassProperty = parentArrayOfModelEquatableClassProperty;
            this.ParentArrayOfNullableBoolProperty = parentArrayOfNullableBoolProperty;
            this.ParentArrayOfNullableIntProperty = parentArrayOfNullableIntProperty;
            this.ParentArrayOfNullableGuidProperty = parentArrayOfNullableGuidProperty;
            this.ParentArrayOfNullableDateTimeProperty = parentArrayOfNullableDateTimeProperty;
            this.ParentArrayOfNullableModelEnumProperty = parentArrayOfNullableModelEnumProperty;
            this.ParentArrayOfNullableModelFlagsEnumProperty = parentArrayOfNullableModelFlagsEnumProperty;
            this.ParentArrayOfNullableModelStructProperty = parentArrayOfNullableModelStructProperty;
            this.ParentArrayOfNullableModelEquatableStructProperty = parentArrayOfNullableModelEquatableStructProperty;
            this.ParentReadOnlyCollectionOfObjectProperty = parentReadOnlyCollectionOfObjectProperty;
            this.ParentReadOnlyCollectionOfBoolProperty = parentReadOnlyCollectionOfBoolProperty;
            this.ParentReadOnlyCollectionOfIntProperty = parentReadOnlyCollectionOfIntProperty;
            this.ParentReadOnlyCollectionOfStringProperty = parentReadOnlyCollectionOfStringProperty;
            this.ParentReadOnlyCollectionOfGuidProperty = parentReadOnlyCollectionOfGuidProperty;
            this.ParentReadOnlyCollectionOfDateTimeProperty = parentReadOnlyCollectionOfDateTimeProperty;
            this.ParentReadOnlyCollectionOfModelEnumProperty = parentReadOnlyCollectionOfModelEnumProperty;
            this.ParentReadOnlyCollectionOfModelFlagsEnumProperty = parentReadOnlyCollectionOfModelFlagsEnumProperty;
            this.ParentReadOnlyCollectionOfModelStructProperty = parentReadOnlyCollectionOfModelStructProperty;
            this.ParentReadOnlyCollectionOfModelEquatableStructProperty = parentReadOnlyCollectionOfModelEquatableStructProperty;
            this.ParentReadOnlyCollectionOfModelClassProperty = parentReadOnlyCollectionOfModelClassProperty;
            this.ParentReadOnlyCollectionOfModelEquatableClassProperty = parentReadOnlyCollectionOfModelEquatableClassProperty;
            this.ParentReadOnlyCollectionOfNullableBoolProperty = parentReadOnlyCollectionOfNullableBoolProperty;
            this.ParentReadOnlyCollectionOfNullableIntProperty = parentReadOnlyCollectionOfNullableIntProperty;
            this.ParentReadOnlyCollectionOfNullableGuidProperty = parentReadOnlyCollectionOfNullableGuidProperty;
            this.ParentReadOnlyCollectionOfNullableDateTimeProperty = parentReadOnlyCollectionOfNullableDateTimeProperty;
            this.ParentReadOnlyCollectionOfNullableModelEnumProperty = parentReadOnlyCollectionOfNullableModelEnumProperty;
            this.ParentReadOnlyCollectionOfNullableModelFlagsEnumProperty = parentReadOnlyCollectionOfNullableModelFlagsEnumProperty;
            this.ParentReadOnlyCollectionOfNullableModelStructProperty = parentReadOnlyCollectionOfNullableModelStructProperty;
            this.ParentReadOnlyCollectionOfNullableModelEquatableStructProperty = parentReadOnlyCollectionOfNullableModelEquatableStructProperty;
            this.ParentReadOnlyDictionaryOfObjectProperty = parentReadOnlyDictionaryOfObjectProperty;
            this.ParentReadOnlyDictionaryOfBoolProperty = parentReadOnlyDictionaryOfBoolProperty;
            this.ParentReadOnlyDictionaryOfIntProperty = parentReadOnlyDictionaryOfIntProperty;
            this.ParentReadOnlyDictionaryOfStringProperty = parentReadOnlyDictionaryOfStringProperty;
            this.ParentReadOnlyDictionaryOfGuidProperty = parentReadOnlyDictionaryOfGuidProperty;
            this.ParentReadOnlyDictionaryOfDateTimeProperty = parentReadOnlyDictionaryOfDateTimeProperty;
            this.ParentReadOnlyDictionaryOfModelEnumProperty = parentReadOnlyDictionaryOfModelEnumProperty;
            this.ParentReadOnlyDictionaryOfModelFlagsEnumProperty = parentReadOnlyDictionaryOfModelFlagsEnumProperty;
            this.ParentReadOnlyDictionaryOfModelStructProperty = parentReadOnlyDictionaryOfModelStructProperty;
            this.ParentReadOnlyDictionaryOfModelEquatableStructProperty = parentReadOnlyDictionaryOfModelEquatableStructProperty;
            this.ParentReadOnlyDictionaryOfModelClassProperty = parentReadOnlyDictionaryOfModelClassProperty;
            this.ParentReadOnlyDictionaryOfModelEquatableClassProperty = parentReadOnlyDictionaryOfModelEquatableClassProperty;
            this.ParentReadOnlyDictionaryOfNullableBoolProperty = parentReadOnlyDictionaryOfNullableBoolProperty;
            this.ParentReadOnlyDictionaryOfNullableIntProperty = parentReadOnlyDictionaryOfNullableIntProperty;
            this.ParentReadOnlyDictionaryOfNullableGuidProperty = parentReadOnlyDictionaryOfNullableGuidProperty;
            this.ParentReadOnlyDictionaryOfNullableDateTimeProperty = parentReadOnlyDictionaryOfNullableDateTimeProperty;
            this.ParentReadOnlyDictionaryOfNullableModelEnumProperty = parentReadOnlyDictionaryOfNullableModelEnumProperty;
            this.ParentReadOnlyDictionaryOfNullableModelFlagsEnumProperty = parentReadOnlyDictionaryOfNullableModelFlagsEnumProperty;
            this.ParentReadOnlyDictionaryOfNullableModelStructProperty = parentReadOnlyDictionaryOfNullableModelStructProperty;
            this.ParentReadOnlyDictionaryOfNullableModelEquatableStructProperty = parentReadOnlyDictionaryOfNullableModelEquatableStructProperty;
        }

        public object ParentObjectProperty { get; }

        public bool ParentBoolProperty { get; }

        public int ParentIntProperty { get; }

        public string ParentStringProperty { get; }

        public Guid ParentGuidProperty { get; }

        public DateTime ParentDateTimeProperty { get; }

        public ModelEnum ParentModelEnumProperty { get; }

        public ModelFlagsEnum ParentModelFlagsEnumProperty { get; }

        public ModelStruct ParentModelStructProperty { get; }

        public ModelEquatableStruct ParentModelEquatableStructProperty { get; }

        public ModelClass ParentModelClassProperty { get; }

        public ModelEquatableClass ParentModelEquatableClassProperty { get; }

        public bool? ParentNullableBoolProperty { get; }

        public int? ParentNullableIntProperty { get; }

        public Guid? ParentNullableGuidProperty { get; }

        public DateTime? ParentNullableDateTimeProperty { get; }

        public ModelEnum? ParentNullableModelEnumProperty { get; }

        public ModelFlagsEnum? ParentNullableModelFlagsEnumProperty { get; }

        public ModelStruct? ParentNullableModelStructProperty { get; }

        public ModelEquatableStruct? ParentNullableModelEquatableStructProperty { get; }

        public object[] ParentArrayOfObjectProperty { get; }

        public bool[] ParentArrayOfBoolProperty { get; }

        public int[] ParentArrayOfIntProperty { get; }

        public string[] ParentArrayOfStringProperty { get; }

        public Guid[] ParentArrayOfGuidProperty { get; }

        public DateTime[] ParentArrayOfDateTimeProperty { get; }

        public ModelEnum[] ParentArrayOfModelEnumProperty { get; }

        public ModelFlagsEnum[] ParentArrayOfModelFlagsEnumProperty { get; }

        public ModelStruct[] ParentArrayOfModelStructProperty { get; }

        public ModelEquatableStruct[] ParentArrayOfModelEquatableStructProperty { get; }

        public ModelClass[] ParentArrayOfModelClassProperty { get; }

        public ModelEquatableClass[] ParentArrayOfModelEquatableClassProperty { get; }

        public bool?[] ParentArrayOfNullableBoolProperty { get; }

        public int?[] ParentArrayOfNullableIntProperty { get; }

        public Guid?[] ParentArrayOfNullableGuidProperty { get; }

        public DateTime?[] ParentArrayOfNullableDateTimeProperty { get; }

        public ModelEnum?[] ParentArrayOfNullableModelEnumProperty { get; }

        public ModelFlagsEnum?[] ParentArrayOfNullableModelFlagsEnumProperty { get; }

        public ModelStruct?[] ParentArrayOfNullableModelStructProperty { get; }

        public ModelEquatableStruct?[] ParentArrayOfNullableModelEquatableStructProperty { get; }

        public IReadOnlyCollection<object> ParentReadOnlyCollectionOfObjectProperty { get; }

        public IReadOnlyCollection<bool> ParentReadOnlyCollectionOfBoolProperty { get; }

        public IReadOnlyCollection<int> ParentReadOnlyCollectionOfIntProperty { get; }

        public IReadOnlyCollection<string> ParentReadOnlyCollectionOfStringProperty { get; }

        public IReadOnlyCollection<Guid> ParentReadOnlyCollectionOfGuidProperty { get; }

        public IReadOnlyCollection<DateTime> ParentReadOnlyCollectionOfDateTimeProperty { get; }

        public IReadOnlyCollection<ModelEnum> ParentReadOnlyCollectionOfModelEnumProperty { get; }

        public IReadOnlyCollection<ModelFlagsEnum> ParentReadOnlyCollectionOfModelFlagsEnumProperty { get; }

        public IReadOnlyCollection<ModelStruct> ParentReadOnlyCollectionOfModelStructProperty { get; }

        public IReadOnlyCollection<ModelEquatableStruct> ParentReadOnlyCollectionOfModelEquatableStructProperty { get; }

        public IReadOnlyCollection<ModelClass> ParentReadOnlyCollectionOfModelClassProperty { get; }

        public IReadOnlyCollection<ModelEquatableClass> ParentReadOnlyCollectionOfModelEquatableClassProperty { get; }

        public IReadOnlyCollection<bool?> ParentReadOnlyCollectionOfNullableBoolProperty { get; }

        public IReadOnlyCollection<int?> ParentReadOnlyCollectionOfNullableIntProperty { get; }

        public IReadOnlyCollection<Guid?> ParentReadOnlyCollectionOfNullableGuidProperty { get; }

        public IReadOnlyCollection<DateTime?> ParentReadOnlyCollectionOfNullableDateTimeProperty { get; }

        public IReadOnlyCollection<ModelEnum?> ParentReadOnlyCollectionOfNullableModelEnumProperty { get; }

        public IReadOnlyCollection<ModelFlagsEnum?> ParentReadOnlyCollectionOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyCollection<ModelStruct?> ParentReadOnlyCollectionOfNullableModelStructProperty { get; }

        public IReadOnlyCollection<ModelEquatableStruct?> ParentReadOnlyCollectionOfNullableModelEquatableStructProperty { get; }

        public IReadOnlyDictionary<object, object> ParentReadOnlyDictionaryOfObjectProperty { get; }

        public IReadOnlyDictionary<bool, bool> ParentReadOnlyDictionaryOfBoolProperty { get; }

        public IReadOnlyDictionary<int, int> ParentReadOnlyDictionaryOfIntProperty { get; }

        public IReadOnlyDictionary<string, string> ParentReadOnlyDictionaryOfStringProperty { get; }

        public IReadOnlyDictionary<Guid, Guid> ParentReadOnlyDictionaryOfGuidProperty { get; }

        public IReadOnlyDictionary<DateTime, DateTime> ParentReadOnlyDictionaryOfDateTimeProperty { get; }

        public IReadOnlyDictionary<ModelEnum, ModelEnum> ParentReadOnlyDictionaryOfModelEnumProperty { get; }

        public IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> ParentReadOnlyDictionaryOfModelFlagsEnumProperty { get; }

        public IReadOnlyDictionary<ModelStruct, ModelStruct> ParentReadOnlyDictionaryOfModelStructProperty { get; }

        public IReadOnlyDictionary<ModelEquatableStruct, ModelEquatableStruct> ParentReadOnlyDictionaryOfModelEquatableStructProperty { get; }

        public IReadOnlyDictionary<ModelClass, ModelClass> ParentReadOnlyDictionaryOfModelClassProperty { get; }

        public IReadOnlyDictionary<ModelEquatableClass, ModelEquatableClass> ParentReadOnlyDictionaryOfModelEquatableClassProperty { get; }

        public IReadOnlyDictionary<bool?, bool?> ParentReadOnlyDictionaryOfNullableBoolProperty { get; }

        public IReadOnlyDictionary<int?, int?> ParentReadOnlyDictionaryOfNullableIntProperty { get; }

        public IReadOnlyDictionary<Guid?, Guid?> ParentReadOnlyDictionaryOfNullableGuidProperty { get; }

        public IReadOnlyDictionary<DateTime?, DateTime?> ParentReadOnlyDictionaryOfNullableDateTimeProperty { get; }

        public IReadOnlyDictionary<ModelEnum?, ModelEnum?> ParentReadOnlyDictionaryOfNullableModelEnumProperty { get; }

        public IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> ParentReadOnlyDictionaryOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyDictionary<ModelStruct?, ModelStruct?> ParentReadOnlyDictionaryOfNullableModelStructProperty { get; }

        public IReadOnlyDictionary<ModelEquatableStruct?, ModelEquatableStruct?> ParentReadOnlyDictionaryOfNullableModelEquatableStructProperty { get; }
    }
}