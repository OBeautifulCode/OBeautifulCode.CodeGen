// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

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
            new { parentObjectProperty }.AsArg().Must().NotBeNull();
            new { parentStringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { parentModelClassProperty }.AsArg().Must().NotBeNull();
            new { parentModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfObjectProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfBoolProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfIntProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfStringProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfGuidProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfDateTimeProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfModelEnumProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfModelStructProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfModelClassProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfNullableBoolProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfNullableIntProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfNullableGuidProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfNullableDateTimeProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfNullableModelEnumProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfNullableModelStructProperty }.AsArg().Must().NotBeNull();
            new { parentArrayOfNullableModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfObjectProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfBoolProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfIntProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfGuidProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfDateTimeProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelEnumProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelStructProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelClassProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableBoolProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableIntProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableGuidProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableDateTimeProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableModelEnumProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableModelStructProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionOfNullableModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfObjectProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfBoolProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfIntProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfStringProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfGuidProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfDateTimeProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelEnumProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelStructProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelEquatableStructProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelClassProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfModelEquatableClassProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableBoolProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableIntProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableGuidProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableDateTimeProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableModelEnumProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableModelStructProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyDictionaryOfNullableModelEquatableStructProperty }.AsArg().Must().NotBeNull();

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