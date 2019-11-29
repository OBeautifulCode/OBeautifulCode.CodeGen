// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelGettersOnlyChild1.cs" company="OBeautifulCode">
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

    public partial class MyModelGettersOnlyChild1 : MyModelGettersOnlyParent, IModelViaCodeGen
    {
        public MyModelGettersOnlyChild1(
            bool parentBoolProperty,
            int parentIntProperty,
            string parentStringProperty,
            Guid parentGuidProperty,
            DateTime parentDateTimeProperty,
            ModelEnum parentModelEnumProperty,
            ModelFlagsEnum parentModelFlagsEnumProperty,
            ModelClass parentModelClassProperty,
            bool? parentNullableBoolProperty,
            int? parentNullableIntProperty,
            Guid? parentNullableGuidProperty,
            DateTime? parentNullableDateTimeProperty,
            ModelEnum? parentNullableModelEnumProperty,
            ModelFlagsEnum? parentNullableModelFlagsEnumProperty,
            bool[] parentArrayOfBoolProperty,
            int[] parentArrayOfIntProperty,
            string[] parentArrayOfStringProperty,
            Guid[] parentArrayOfGuidProperty,
            DateTime[] parentArrayOfDateTimeProperty,
            ModelEnum[] parentArrayOfModelEnumProperty,
            ModelFlagsEnum[] parentArrayOfModelFlagsEnumProperty,
            ModelClass[] parentArrayOfModelClassProperty,
            bool?[] parentArrayOfNullableBoolProperty,
            int?[] parentArrayOfNullableIntProperty,
            Guid?[] parentArrayOfNullableGuidProperty,
            DateTime?[] parentArrayOfNullableDateTimeProperty,
            ModelEnum?[] parentArrayOfNullableModelEnumProperty,
            ModelFlagsEnum?[] parentArrayOfNullableModelFlagsEnumProperty,
            IReadOnlyCollection<bool> parentReadOnlyCollectionOfBoolProperty,
            IReadOnlyCollection<int> parentReadOnlyCollectionOfIntProperty,
            IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty,
            IReadOnlyCollection<Guid> parentReadOnlyCollectionOfGuidProperty,
            IReadOnlyCollection<DateTime> parentReadOnlyCollectionOfDateTimeProperty,
            IReadOnlyCollection<ModelEnum> parentReadOnlyCollectionOfModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum> parentReadOnlyCollectionOfModelFlagsEnumProperty,
            IReadOnlyCollection<ModelClass> parentReadOnlyCollectionOfModelClassProperty,
            IReadOnlyCollection<bool?> parentReadOnlyCollectionOfNullableBoolProperty,
            IReadOnlyCollection<int?> parentReadOnlyCollectionOfNullableIntProperty,
            IReadOnlyCollection<Guid?> parentReadOnlyCollectionOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> parentReadOnlyCollectionOfNullableDateTimeProperty,
            IReadOnlyCollection<ModelEnum?> parentReadOnlyCollectionOfNullableModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum?> parentReadOnlyCollectionOfNullableModelFlagsEnumProperty,
            IReadOnlyList<bool> parentReadOnlyListOfBoolProperty,
            IReadOnlyList<int> parentReadOnlyListOfIntProperty,
            IReadOnlyList<string> parentReadOnlyListOfStringProperty,
            IReadOnlyList<Guid> parentReadOnlyListOfGuidProperty,
            IReadOnlyList<DateTime> parentReadOnlyListOfDateTimeProperty,
            IReadOnlyList<ModelEnum> parentReadOnlyListOfModelEnumProperty,
            IReadOnlyList<ModelFlagsEnum> parentReadOnlyListOfModelFlagsEnumProperty,
            IReadOnlyList<ModelClass> parentReadOnlyListOfModelClassProperty,
            IReadOnlyList<bool?> parentReadOnlyListOfNullableBoolProperty,
            IReadOnlyList<int?> parentReadOnlyListOfNullableIntProperty,
            IReadOnlyList<Guid?> parentReadOnlyListOfNullableGuidProperty,
            IReadOnlyList<DateTime?> parentReadOnlyListOfNullableDateTimeProperty,
            IReadOnlyList<ModelEnum?> parentReadOnlyListOfNullableModelEnumProperty,
            IReadOnlyList<ModelFlagsEnum?> parentReadOnlyListOfNullableModelFlagsEnumProperty,
            IReadOnlyDictionary<bool, bool> parentReadOnlyDictionaryOfBoolProperty,
            IReadOnlyDictionary<int, int> parentReadOnlyDictionaryOfIntProperty,
            IReadOnlyDictionary<string, string> parentReadOnlyDictionaryOfStringProperty,
            IReadOnlyDictionary<Guid, Guid> parentReadOnlyDictionaryOfGuidProperty,
            IReadOnlyDictionary<ModelEnum, ModelEnum> parentReadOnlyDictionaryOfModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> parentReadOnlyDictionaryOfModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelClass, ModelClass> parentReadOnlyDictionaryOfModelClassProperty,
            IReadOnlyDictionary<bool?, bool?> parentReadOnlyDictionaryOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> parentReadOnlyDictionaryOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> parentReadOnlyDictionaryOfNullableGuidProperty,
            IReadOnlyDictionary<ModelEnum?, ModelEnum?> parentReadOnlyDictionaryOfNullableModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> parentReadOnlyDictionaryOfNullableModelFlagsEnumProperty,
            IReadOnlyList<ICollection<string>> parentReadOnlyListOfCollectionOfStringProperty,
            IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> parentReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty,
            IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyDictionary<ModelClass, IReadOnlyList<DateTime>>>> parentReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty,
            bool child1BoolProperty,
            int child1IntProperty,
            string child1StringProperty,
            Guid child1GuidProperty,
            DateTime child1DateTimeProperty,
            ModelEnum child1ModelEnumProperty,
            ModelFlagsEnum child1ModelFlagsEnumProperty,
            ModelClass child1ModelClassProperty,
            bool? child1NullableBoolProperty,
            int? child1NullableIntProperty,
            Guid? child1NullableGuidProperty,
            DateTime? child1NullableDateTimeProperty,
            ModelEnum? child1NullableModelEnumProperty,
            ModelFlagsEnum? child1NullableModelFlagsEnumProperty,
            bool[] child1ArrayOfBoolProperty,
            int[] child1ArrayOfIntProperty,
            string[] child1ArrayOfStringProperty,
            Guid[] child1ArrayOfGuidProperty,
            DateTime[] child1ArrayOfDateTimeProperty,
            ModelEnum[] child1ArrayOfModelEnumProperty,
            ModelFlagsEnum[] child1ArrayOfModelFlagsEnumProperty,
            ModelClass[] child1ArrayOfModelClassProperty,
            bool?[] child1ArrayOfNullableBoolProperty,
            int?[] child1ArrayOfNullableIntProperty,
            Guid?[] child1ArrayOfNullableGuidProperty,
            DateTime?[] child1ArrayOfNullableDateTimeProperty,
            ModelEnum?[] child1ArrayOfNullableModelEnumProperty,
            ModelFlagsEnum?[] child1ArrayOfNullableModelFlagsEnumProperty,
            IReadOnlyCollection<bool> child1ReadOnlyCollectionOfBoolProperty,
            IReadOnlyCollection<int> child1ReadOnlyCollectionOfIntProperty,
            IReadOnlyCollection<string> child1ReadOnlyCollectionOfStringProperty,
            IReadOnlyCollection<Guid> child1ReadOnlyCollectionOfGuidProperty,
            IReadOnlyCollection<DateTime> child1ReadOnlyCollectionOfDateTimeProperty,
            IReadOnlyCollection<ModelEnum> child1ReadOnlyCollectionOfModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum> child1ReadOnlyCollectionOfModelFlagsEnumProperty,
            IReadOnlyCollection<ModelClass> child1ReadOnlyCollectionOfModelClassProperty,
            IReadOnlyCollection<bool?> child1ReadOnlyCollectionOfNullableBoolProperty,
            IReadOnlyCollection<int?> child1ReadOnlyCollectionOfNullableIntProperty,
            IReadOnlyCollection<Guid?> child1ReadOnlyCollectionOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> child1ReadOnlyCollectionOfNullableDateTimeProperty,
            IReadOnlyCollection<ModelEnum?> child1ReadOnlyCollectionOfNullableModelEnumProperty,
            IReadOnlyCollection<ModelFlagsEnum?> child1ReadOnlyCollectionOfNullableModelFlagsEnumProperty,
            IReadOnlyList<bool> child1ReadOnlyListOfBoolProperty,
            IReadOnlyList<int> child1ReadOnlyListOfIntProperty,
            IReadOnlyList<string> child1ReadOnlyListOfStringProperty,
            IReadOnlyList<Guid> child1ReadOnlyListOfGuidProperty,
            IReadOnlyList<DateTime> child1ReadOnlyListOfDateTimeProperty,
            IReadOnlyList<ModelEnum> child1ReadOnlyListOfModelEnumProperty,
            IReadOnlyList<ModelFlagsEnum> child1ReadOnlyListOfModelFlagsEnumProperty,
            IReadOnlyList<ModelClass> child1ReadOnlyListOfModelClassProperty,
            IReadOnlyList<bool?> child1ReadOnlyListOfNullableBoolProperty,
            IReadOnlyList<int?> child1ReadOnlyListOfNullableIntProperty,
            IReadOnlyList<Guid?> child1ReadOnlyListOfNullableGuidProperty,
            IReadOnlyList<DateTime?> child1ReadOnlyListOfNullableDateTimeProperty,
            IReadOnlyList<ModelEnum?> child1ReadOnlyListOfNullableModelEnumProperty,
            IReadOnlyList<ModelFlagsEnum?> child1ReadOnlyListOfNullableModelFlagsEnumProperty,
            IReadOnlyDictionary<bool, bool> child1ReadOnlyDictionaryOfBoolProperty,
            IReadOnlyDictionary<int, int> child1ReadOnlyDictionaryOfIntProperty,
            IReadOnlyDictionary<string, string> child1ReadOnlyDictionaryOfStringProperty,
            IReadOnlyDictionary<Guid, Guid> child1ReadOnlyDictionaryOfGuidProperty,
            IReadOnlyDictionary<ModelEnum, ModelEnum> child1ReadOnlyDictionaryOfModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> child1ReadOnlyDictionaryOfModelFlagsEnumProperty,
            IReadOnlyDictionary<ModelClass, ModelClass> child1ReadOnlyDictionaryOfModelClassProperty,
            IReadOnlyDictionary<bool?, bool?> child1ReadOnlyDictionaryOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> child1ReadOnlyDictionaryOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> child1ReadOnlyDictionaryOfNullableGuidProperty,
            IReadOnlyDictionary<ModelEnum?, ModelEnum?> child1ReadOnlyDictionaryOfNullableModelEnumProperty,
            IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> child1ReadOnlyDictionaryOfNullableModelFlagsEnumProperty,
            IReadOnlyList<ICollection<string>> child1ReadOnlyListOfCollectionOfStringProperty,
            IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> child1ReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty,
            IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyDictionary<ModelClass, IReadOnlyList<DateTime>>>> child1ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty)
            : base(parentBoolProperty, parentIntProperty, parentStringProperty, parentGuidProperty, parentDateTimeProperty, parentModelEnumProperty, parentModelFlagsEnumProperty, parentModelClassProperty, parentNullableBoolProperty, parentNullableIntProperty, parentNullableGuidProperty, parentNullableDateTimeProperty, parentNullableModelEnumProperty, parentNullableModelFlagsEnumProperty, parentArrayOfBoolProperty, parentArrayOfIntProperty, parentArrayOfStringProperty, parentArrayOfGuidProperty, parentArrayOfDateTimeProperty, parentArrayOfModelEnumProperty, parentArrayOfModelFlagsEnumProperty, parentArrayOfModelClassProperty, parentArrayOfNullableBoolProperty, parentArrayOfNullableIntProperty, parentArrayOfNullableGuidProperty, parentArrayOfNullableDateTimeProperty, parentArrayOfNullableModelEnumProperty, parentArrayOfNullableModelFlagsEnumProperty, parentReadOnlyCollectionOfBoolProperty, parentReadOnlyCollectionOfIntProperty, parentReadOnlyCollectionOfStringProperty, parentReadOnlyCollectionOfGuidProperty, parentReadOnlyCollectionOfDateTimeProperty, parentReadOnlyCollectionOfModelEnumProperty, parentReadOnlyCollectionOfModelFlagsEnumProperty, parentReadOnlyCollectionOfModelClassProperty, parentReadOnlyCollectionOfNullableBoolProperty, parentReadOnlyCollectionOfNullableIntProperty, parentReadOnlyCollectionOfNullableGuidProperty, parentReadOnlyCollectionOfNullableDateTimeProperty, parentReadOnlyCollectionOfNullableModelEnumProperty, parentReadOnlyCollectionOfNullableModelFlagsEnumProperty, parentReadOnlyListOfBoolProperty, parentReadOnlyListOfIntProperty, parentReadOnlyListOfStringProperty, parentReadOnlyListOfGuidProperty, parentReadOnlyListOfDateTimeProperty, parentReadOnlyListOfModelEnumProperty, parentReadOnlyListOfModelFlagsEnumProperty, parentReadOnlyListOfModelClassProperty, parentReadOnlyListOfNullableBoolProperty, parentReadOnlyListOfNullableIntProperty, parentReadOnlyListOfNullableGuidProperty, parentReadOnlyListOfNullableDateTimeProperty, parentReadOnlyListOfNullableModelEnumProperty, parentReadOnlyListOfNullableModelFlagsEnumProperty, parentReadOnlyDictionaryOfBoolProperty, parentReadOnlyDictionaryOfIntProperty, parentReadOnlyDictionaryOfStringProperty, parentReadOnlyDictionaryOfGuidProperty, parentReadOnlyDictionaryOfModelEnumProperty, parentReadOnlyDictionaryOfModelFlagsEnumProperty, parentReadOnlyDictionaryOfModelClassProperty, parentReadOnlyDictionaryOfNullableBoolProperty, parentReadOnlyDictionaryOfNullableIntProperty, parentReadOnlyDictionaryOfNullableGuidProperty, parentReadOnlyDictionaryOfNullableModelEnumProperty, parentReadOnlyDictionaryOfNullableModelFlagsEnumProperty, parentReadOnlyListOfCollectionOfStringProperty, parentReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty, parentReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty)
        {
            new { child1StringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { child1ModelClassProperty }.AsArg().Must().NotBeNull();
            new { child1ArrayOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ArrayOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfModelClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ArrayOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfNullableModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyCollectionOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfModelClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyCollectionOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfNullableModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyListOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfModelClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyListOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfNullableModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyDictionaryOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryOfIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryOfStringProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { child1ReadOnlyDictionaryOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryOfModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryOfModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryOfModelClassProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { child1ReadOnlyDictionaryOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryOfNullableModelEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryOfNullableModelFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyListOfCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.Child1BoolProperty = child1BoolProperty;
            this.Child1IntProperty = child1IntProperty;
            this.Child1StringProperty = child1StringProperty;
            this.Child1GuidProperty = child1GuidProperty;
            this.Child1DateTimeProperty = child1DateTimeProperty;
            this.Child1ModelEnumProperty = child1ModelEnumProperty;
            this.Child1ModelFlagsEnumProperty = child1ModelFlagsEnumProperty;
            this.Child1ModelClassProperty = child1ModelClassProperty;
            this.Child1NullableBoolProperty = child1NullableBoolProperty;
            this.Child1NullableIntProperty = child1NullableIntProperty;
            this.Child1NullableGuidProperty = child1NullableGuidProperty;
            this.Child1NullableDateTimeProperty = child1NullableDateTimeProperty;
            this.Child1NullableModelEnumProperty = child1NullableModelEnumProperty;
            this.Child1NullableModelFlagsEnumProperty = child1NullableModelFlagsEnumProperty;
            this.Child1ArrayOfBoolProperty = child1ArrayOfBoolProperty;
            this.Child1ArrayOfIntProperty = child1ArrayOfIntProperty;
            this.Child1ArrayOfStringProperty = child1ArrayOfStringProperty;
            this.Child1ArrayOfGuidProperty = child1ArrayOfGuidProperty;
            this.Child1ArrayOfDateTimeProperty = child1ArrayOfDateTimeProperty;
            this.Child1ArrayOfModelEnumProperty = child1ArrayOfModelEnumProperty;
            this.Child1ArrayOfModelFlagsEnumProperty = child1ArrayOfModelFlagsEnumProperty;
            this.Child1ArrayOfModelClassProperty = child1ArrayOfModelClassProperty;
            this.Child1ArrayOfNullableBoolProperty = child1ArrayOfNullableBoolProperty;
            this.Child1ArrayOfNullableIntProperty = child1ArrayOfNullableIntProperty;
            this.Child1ArrayOfNullableGuidProperty = child1ArrayOfNullableGuidProperty;
            this.Child1ArrayOfNullableDateTimeProperty = child1ArrayOfNullableDateTimeProperty;
            this.Child1ArrayOfNullableModelEnumProperty = child1ArrayOfNullableModelEnumProperty;
            this.Child1ArrayOfNullableModelFlagsEnumProperty = child1ArrayOfNullableModelFlagsEnumProperty;
            this.Child1ReadOnlyCollectionOfBoolProperty = child1ReadOnlyCollectionOfBoolProperty;
            this.Child1ReadOnlyCollectionOfIntProperty = child1ReadOnlyCollectionOfIntProperty;
            this.Child1ReadOnlyCollectionOfStringProperty = child1ReadOnlyCollectionOfStringProperty;
            this.Child1ReadOnlyCollectionOfGuidProperty = child1ReadOnlyCollectionOfGuidProperty;
            this.Child1ReadOnlyCollectionOfDateTimeProperty = child1ReadOnlyCollectionOfDateTimeProperty;
            this.Child1ReadOnlyCollectionOfModelEnumProperty = child1ReadOnlyCollectionOfModelEnumProperty;
            this.Child1ReadOnlyCollectionOfModelFlagsEnumProperty = child1ReadOnlyCollectionOfModelFlagsEnumProperty;
            this.Child1ReadOnlyCollectionOfModelClassProperty = child1ReadOnlyCollectionOfModelClassProperty;
            this.Child1ReadOnlyCollectionOfNullableBoolProperty = child1ReadOnlyCollectionOfNullableBoolProperty;
            this.Child1ReadOnlyCollectionOfNullableIntProperty = child1ReadOnlyCollectionOfNullableIntProperty;
            this.Child1ReadOnlyCollectionOfNullableGuidProperty = child1ReadOnlyCollectionOfNullableGuidProperty;
            this.Child1ReadOnlyCollectionOfNullableDateTimeProperty = child1ReadOnlyCollectionOfNullableDateTimeProperty;
            this.Child1ReadOnlyCollectionOfNullableModelEnumProperty = child1ReadOnlyCollectionOfNullableModelEnumProperty;
            this.Child1ReadOnlyCollectionOfNullableModelFlagsEnumProperty = child1ReadOnlyCollectionOfNullableModelFlagsEnumProperty;
            this.Child1ReadOnlyListOfBoolProperty = child1ReadOnlyListOfBoolProperty;
            this.Child1ReadOnlyListOfIntProperty = child1ReadOnlyListOfIntProperty;
            this.Child1ReadOnlyListOfStringProperty = child1ReadOnlyListOfStringProperty;
            this.Child1ReadOnlyListOfGuidProperty = child1ReadOnlyListOfGuidProperty;
            this.Child1ReadOnlyListOfDateTimeProperty = child1ReadOnlyListOfDateTimeProperty;
            this.Child1ReadOnlyListOfModelEnumProperty = child1ReadOnlyListOfModelEnumProperty;
            this.Child1ReadOnlyListOfModelFlagsEnumProperty = child1ReadOnlyListOfModelFlagsEnumProperty;
            this.Child1ReadOnlyListOfModelClassProperty = child1ReadOnlyListOfModelClassProperty;
            this.Child1ReadOnlyListOfNullableBoolProperty = child1ReadOnlyListOfNullableBoolProperty;
            this.Child1ReadOnlyListOfNullableIntProperty = child1ReadOnlyListOfNullableIntProperty;
            this.Child1ReadOnlyListOfNullableGuidProperty = child1ReadOnlyListOfNullableGuidProperty;
            this.Child1ReadOnlyListOfNullableDateTimeProperty = child1ReadOnlyListOfNullableDateTimeProperty;
            this.Child1ReadOnlyListOfNullableModelEnumProperty = child1ReadOnlyListOfNullableModelEnumProperty;
            this.Child1ReadOnlyListOfNullableModelFlagsEnumProperty = child1ReadOnlyListOfNullableModelFlagsEnumProperty;
            this.Child1ReadOnlyDictionaryOfBoolProperty = child1ReadOnlyDictionaryOfBoolProperty;
            this.Child1ReadOnlyDictionaryOfIntProperty = child1ReadOnlyDictionaryOfIntProperty;
            this.Child1ReadOnlyDictionaryOfStringProperty = child1ReadOnlyDictionaryOfStringProperty;
            this.Child1ReadOnlyDictionaryOfGuidProperty = child1ReadOnlyDictionaryOfGuidProperty;
            this.Child1ReadOnlyDictionaryOfModelEnumProperty = child1ReadOnlyDictionaryOfModelEnumProperty;
            this.Child1ReadOnlyDictionaryOfModelFlagsEnumProperty = child1ReadOnlyDictionaryOfModelFlagsEnumProperty;
            this.Child1ReadOnlyDictionaryOfModelClassProperty = child1ReadOnlyDictionaryOfModelClassProperty;
            this.Child1ReadOnlyDictionaryOfNullableBoolProperty = child1ReadOnlyDictionaryOfNullableBoolProperty;
            this.Child1ReadOnlyDictionaryOfNullableIntProperty = child1ReadOnlyDictionaryOfNullableIntProperty;
            this.Child1ReadOnlyDictionaryOfNullableGuidProperty = child1ReadOnlyDictionaryOfNullableGuidProperty;
            this.Child1ReadOnlyDictionaryOfNullableModelEnumProperty = child1ReadOnlyDictionaryOfNullableModelEnumProperty;
            this.Child1ReadOnlyDictionaryOfNullableModelFlagsEnumProperty = child1ReadOnlyDictionaryOfNullableModelFlagsEnumProperty;
            this.Child1ReadOnlyListOfCollectionOfStringProperty = child1ReadOnlyListOfCollectionOfStringProperty;
            this.Child1ReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty = child1ReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty;
            this.Child1ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty = child1ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty;
        }

        public bool Child1BoolProperty { get; }

        public int Child1IntProperty { get; }

        public string Child1StringProperty { get; }

        public Guid Child1GuidProperty { get; }

        public DateTime Child1DateTimeProperty { get; }

        public ModelEnum Child1ModelEnumProperty { get; }

        public ModelFlagsEnum Child1ModelFlagsEnumProperty { get; }

        public ModelClass Child1ModelClassProperty { get; }

        public bool? Child1NullableBoolProperty { get; }

        public int? Child1NullableIntProperty { get; }

        public Guid? Child1NullableGuidProperty { get; }

        public DateTime? Child1NullableDateTimeProperty { get; }

        public ModelEnum? Child1NullableModelEnumProperty { get; }

        public ModelFlagsEnum? Child1NullableModelFlagsEnumProperty { get; }

        public bool[] Child1ArrayOfBoolProperty { get; }

        public int[] Child1ArrayOfIntProperty { get; }

        public string[] Child1ArrayOfStringProperty { get; }

        public Guid[] Child1ArrayOfGuidProperty { get; }

        public DateTime[] Child1ArrayOfDateTimeProperty { get; }

        public ModelEnum[] Child1ArrayOfModelEnumProperty { get; }

        public ModelFlagsEnum[] Child1ArrayOfModelFlagsEnumProperty { get; }

        public ModelClass[] Child1ArrayOfModelClassProperty { get; }

        public bool?[] Child1ArrayOfNullableBoolProperty { get; }

        public int?[] Child1ArrayOfNullableIntProperty { get; }

        public Guid?[] Child1ArrayOfNullableGuidProperty { get; }

        public DateTime?[] Child1ArrayOfNullableDateTimeProperty { get; }

        public ModelEnum?[] Child1ArrayOfNullableModelEnumProperty { get; }

        public ModelFlagsEnum?[] Child1ArrayOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyCollection<bool> Child1ReadOnlyCollectionOfBoolProperty { get; }

        public IReadOnlyCollection<int> Child1ReadOnlyCollectionOfIntProperty { get; }

        public IReadOnlyCollection<string> Child1ReadOnlyCollectionOfStringProperty { get; }

        public IReadOnlyCollection<Guid> Child1ReadOnlyCollectionOfGuidProperty { get; }

        public IReadOnlyCollection<DateTime> Child1ReadOnlyCollectionOfDateTimeProperty { get; }

        public IReadOnlyCollection<ModelEnum> Child1ReadOnlyCollectionOfModelEnumProperty { get; }

        public IReadOnlyCollection<ModelFlagsEnum> Child1ReadOnlyCollectionOfModelFlagsEnumProperty { get; }

        public IReadOnlyCollection<ModelClass> Child1ReadOnlyCollectionOfModelClassProperty { get; }

        public IReadOnlyCollection<bool?> Child1ReadOnlyCollectionOfNullableBoolProperty { get; }

        public IReadOnlyCollection<int?> Child1ReadOnlyCollectionOfNullableIntProperty { get; }

        public IReadOnlyCollection<Guid?> Child1ReadOnlyCollectionOfNullableGuidProperty { get; }

        public IReadOnlyCollection<DateTime?> Child1ReadOnlyCollectionOfNullableDateTimeProperty { get; }

        public IReadOnlyCollection<ModelEnum?> Child1ReadOnlyCollectionOfNullableModelEnumProperty { get; }

        public IReadOnlyCollection<ModelFlagsEnum?> Child1ReadOnlyCollectionOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyList<bool> Child1ReadOnlyListOfBoolProperty { get; }

        public IReadOnlyList<int> Child1ReadOnlyListOfIntProperty { get; }

        public IReadOnlyList<string> Child1ReadOnlyListOfStringProperty { get; }

        public IReadOnlyList<Guid> Child1ReadOnlyListOfGuidProperty { get; }

        public IReadOnlyList<DateTime> Child1ReadOnlyListOfDateTimeProperty { get; }

        public IReadOnlyList<ModelEnum> Child1ReadOnlyListOfModelEnumProperty { get; }

        public IReadOnlyList<ModelFlagsEnum> Child1ReadOnlyListOfModelFlagsEnumProperty { get; }

        public IReadOnlyList<ModelClass> Child1ReadOnlyListOfModelClassProperty { get; }

        public IReadOnlyList<bool?> Child1ReadOnlyListOfNullableBoolProperty { get; }

        public IReadOnlyList<int?> Child1ReadOnlyListOfNullableIntProperty { get; }

        public IReadOnlyList<Guid?> Child1ReadOnlyListOfNullableGuidProperty { get; }

        public IReadOnlyList<DateTime?> Child1ReadOnlyListOfNullableDateTimeProperty { get; }

        public IReadOnlyList<ModelEnum?> Child1ReadOnlyListOfNullableModelEnumProperty { get; }

        public IReadOnlyList<ModelFlagsEnum?> Child1ReadOnlyListOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyDictionary<bool, bool> Child1ReadOnlyDictionaryOfBoolProperty { get; }

        public IReadOnlyDictionary<int, int> Child1ReadOnlyDictionaryOfIntProperty { get; }

        public IReadOnlyDictionary<string, string> Child1ReadOnlyDictionaryOfStringProperty { get; }

        public IReadOnlyDictionary<Guid, Guid> Child1ReadOnlyDictionaryOfGuidProperty { get; }

        public IReadOnlyDictionary<ModelEnum, ModelEnum> Child1ReadOnlyDictionaryOfModelEnumProperty { get; }

        public IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> Child1ReadOnlyDictionaryOfModelFlagsEnumProperty { get; }

        public IReadOnlyDictionary<ModelClass, ModelClass> Child1ReadOnlyDictionaryOfModelClassProperty { get; }

        public IReadOnlyDictionary<bool?, bool?> Child1ReadOnlyDictionaryOfNullableBoolProperty { get; }

        public IReadOnlyDictionary<int?, int?> Child1ReadOnlyDictionaryOfNullableIntProperty { get; }

        public IReadOnlyDictionary<Guid?, Guid?> Child1ReadOnlyDictionaryOfNullableGuidProperty { get; }

        public IReadOnlyDictionary<ModelEnum?, ModelEnum?> Child1ReadOnlyDictionaryOfNullableModelEnumProperty { get; }

        public IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> Child1ReadOnlyDictionaryOfNullableModelFlagsEnumProperty { get; }

        public IReadOnlyList<ICollection<string>> Child1ReadOnlyListOfCollectionOfStringProperty { get; }

        public IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> Child1ReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty { get; }

        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyDictionary<ModelClass, IReadOnlyList<DateTime>>>> Child1ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfDateTimeProperty { get; }
    }
}