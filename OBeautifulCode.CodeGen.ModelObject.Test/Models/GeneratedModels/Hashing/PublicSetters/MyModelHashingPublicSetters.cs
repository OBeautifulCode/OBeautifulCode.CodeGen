// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelHashingPublicSetters.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest.GenerateModel()
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using FakeItEasy;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    public partial class MyModelHashingPublicSetters : IHashableViaCodeGen, IDeclareGetHashCodeMethod
    {
        public bool BoolProperty { get; set; }

        public int IntProperty { get; set; }

        public string StringProperty { get; set; }

        public Guid GuidProperty { get; set; }

        public DateTime DateTimeProperty { get; set; }

        public ModelEnum ModelEnumProperty { get; set; }

        public ModelFlagsEnum ModelFlagsEnumProperty { get; set; }

        public ModelClass ModelClassProperty { get; set; }

        public bool? NullableBoolProperty { get; set; }

        public int? NullableIntProperty { get; set; }

        public Guid? NullableGuidProperty { get; set; }

        public DateTime? NullableDateTimeProperty { get; set; }

        public ModelEnum? NullableModelEnumProperty { get; set; }

        public ModelFlagsEnum? NullableModelFlagsEnumProperty { get; set; }

        public bool[] ArrayOfBoolProperty { get; set; }

        public int[] ArrayOfIntProperty { get; set; }

        public string[] ArrayOfStringProperty { get; set; }

        public Guid[] ArrayOfGuidProperty { get; set; }

        public DateTime[] ArrayOfDateTimeProperty { get; set; }

        public ModelEnum[] ArrayOfModelEnumProperty { get; set; }

        public ModelFlagsEnum[] ArrayOfModelFlagsEnumProperty { get; set; }

        public ModelClass[] ArrayOfModelClassProperty { get; set; }

        public bool?[] ArrayOfNullableBoolProperty { get; set; }

        public int?[] ArrayOfNullableIntProperty { get; set; }

        public Guid?[] ArrayOfNullableGuidProperty { get; set; }

        public DateTime?[] ArrayOfNullableDateTimeProperty { get; set; }

        public ModelEnum?[] ArrayOfNullableModelEnumProperty { get; set; }

        public ModelFlagsEnum?[] ArrayOfNullableModelFlagsEnumProperty { get; set; }

        public IReadOnlyCollection<bool> ReadOnlyCollectionInterfaceOfBoolProperty { get; set; }

        public IReadOnlyCollection<int> ReadOnlyCollectionInterfaceOfIntProperty { get; set; }

        public IReadOnlyCollection<string> ReadOnlyCollectionInterfaceOfStringProperty { get; set; }

        public IReadOnlyCollection<Guid> ReadOnlyCollectionInterfaceOfGuidProperty { get; set; }

        public IReadOnlyCollection<DateTime> ReadOnlyCollectionInterfaceOfDateTimeProperty { get; set; }

        public IReadOnlyCollection<ModelEnum> ReadOnlyCollectionInterfaceOfModelEnumProperty { get; set; }

        public IReadOnlyCollection<ModelFlagsEnum> ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty { get; set; }

        public IReadOnlyCollection<ModelClass> ReadOnlyCollectionInterfaceOfModelClassProperty { get; set; }

        public IReadOnlyCollection<bool?> ReadOnlyCollectionInterfaceOfNullableBoolProperty { get; set; }

        public IReadOnlyCollection<int?> ReadOnlyCollectionInterfaceOfNullableIntProperty { get; set; }

        public IReadOnlyCollection<Guid?> ReadOnlyCollectionInterfaceOfNullableGuidProperty { get; set; }

        public IReadOnlyCollection<DateTime?> ReadOnlyCollectionInterfaceOfNullableDateTimeProperty { get; set; }

        public IReadOnlyCollection<ModelEnum?> ReadOnlyCollectionInterfaceOfNullableModelEnumProperty { get; set; }

        public IReadOnlyCollection<ModelFlagsEnum?> ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty { get; set; }

        public IReadOnlyList<bool> ReadOnlyListInterfaceOfBoolProperty { get; set; }

        public IReadOnlyList<int> ReadOnlyListInterfaceOfIntProperty { get; set; }

        public IReadOnlyList<string> ReadOnlyListInterfaceOfStringProperty { get; set; }

        public IReadOnlyList<Guid> ReadOnlyListInterfaceOfGuidProperty { get; set; }

        public IReadOnlyList<DateTime> ReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public IReadOnlyList<ModelEnum> ReadOnlyListInterfaceOfModelEnumProperty { get; set; }

        public IReadOnlyList<ModelFlagsEnum> ReadOnlyListInterfaceOfModelFlagsEnumProperty { get; set; }

        public IReadOnlyList<ModelClass> ReadOnlyListInterfaceOfModelClassProperty { get; set; }

        public IReadOnlyList<bool?> ReadOnlyListInterfaceOfNullableBoolProperty { get; set; }

        public IReadOnlyList<int?> ReadOnlyListInterfaceOfNullableIntProperty { get; set; }

        public IReadOnlyList<Guid?> ReadOnlyListInterfaceOfNullableGuidProperty { get; set; }

        public IReadOnlyList<DateTime?> ReadOnlyListInterfaceOfNullableDateTimeProperty { get; set; }

        public IReadOnlyList<ModelEnum?> ReadOnlyListInterfaceOfNullableModelEnumProperty { get; set; }

        public IReadOnlyList<ModelFlagsEnum?> ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty { get; set; }

        public IReadOnlyDictionary<bool, bool> ReadOnlyDictionaryInterfaceOfBoolProperty { get; set; }

        public IReadOnlyDictionary<int, int> ReadOnlyDictionaryInterfaceOfIntProperty { get; set; }

        public IReadOnlyDictionary<string, string> ReadOnlyDictionaryInterfaceOfStringProperty { get; set; }

        public IReadOnlyDictionary<Guid, Guid> ReadOnlyDictionaryInterfaceOfGuidProperty { get; set; }

        public IReadOnlyDictionary<ModelEnum, ModelEnum> ReadOnlyDictionaryInterfaceOfModelEnumProperty { get; set; }

        public IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty { get; set; }

        public IReadOnlyDictionary<ModelClass, ModelClass> ReadOnlyDictionaryInterfaceOfModelClassProperty { get; set; }

        public IReadOnlyDictionary<bool?, bool?> ReadOnlyDictionaryInterfaceOfNullableBoolProperty { get; set; }

        public IReadOnlyDictionary<int?, int?> ReadOnlyDictionaryInterfaceOfNullableIntProperty { get; set; }

        public IReadOnlyDictionary<Guid?, Guid?> ReadOnlyDictionaryInterfaceOfNullableGuidProperty { get; set; }

        public IReadOnlyDictionary<ModelEnum?, ModelEnum?> ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty { get; set; }

        public IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty { get; set; }

        public ICollection<string> CollectionInterfaceOfStringProperty { get; set; }

        public Collection<ICollection<string>> CollectionOfCollectionInterfaceOfStringProperty { get; set; }

        public IList<ICollection<string>> ListInterfaceOfCollectionInterfaceOfStringProperty { get; set; }

        public List<ICollection<string>> ListOfCollectionInterfaceOfStringProperty { get; set; }

        public ReadOnlyCollection<ICollection<string>> ReadOnlyCollectionOfCollectionInterfaceOfStringProperty { get; set; }

        public IDictionary<string, IReadOnlyList<DateTime>> DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public Dictionary<string, IReadOnlyList<DateTime>> DictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public ReadOnlyDictionary<string, IReadOnlyList<DateTime>> ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public ConcurrentDictionary<string, IReadOnlyList<DateTime>> ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, ReadOnlyDictionary<ModelClass, IReadOnlyList<DateTime>>>> ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
                .Hash(this.BoolProperty)
                .Hash(this.IntProperty)
                .Hash(this.StringProperty)
                .Hash(this.GuidProperty)
                .Hash(this.DateTimeProperty)
                .Hash(this.ModelEnumProperty)
                .Hash(this.ModelFlagsEnumProperty)
                .Hash(this.ModelClassProperty)
                .Hash(this.NullableBoolProperty)
                .Hash(this.NullableIntProperty)
                .Hash(this.NullableGuidProperty)
                .Hash(this.NullableDateTimeProperty)
                .Hash(this.NullableModelEnumProperty)
                .Hash(this.NullableModelFlagsEnumProperty)
                .Hash(this.ArrayOfBoolProperty)
                .Hash(this.ArrayOfIntProperty)
                .Hash(this.ArrayOfStringProperty)
                .Hash(this.ArrayOfGuidProperty)
                .Hash(this.ArrayOfDateTimeProperty)
                .Hash(this.ArrayOfModelEnumProperty)
                .Hash(this.ArrayOfModelFlagsEnumProperty)
                .Hash(this.ArrayOfModelClassProperty)
                .Hash(this.ArrayOfNullableBoolProperty)
                .Hash(this.ArrayOfNullableIntProperty)
                .Hash(this.ArrayOfNullableGuidProperty)
                .Hash(this.ArrayOfNullableDateTimeProperty)
                .Hash(this.ArrayOfNullableModelEnumProperty)
                .Hash(this.ArrayOfNullableModelFlagsEnumProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfBoolProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfIntProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfStringProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfGuidProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfDateTimeProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfModelEnumProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfModelClassProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfNullableBoolProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfNullableIntProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfNullableGuidProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfNullableDateTimeProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfNullableModelEnumProperty)
                .Hash(this.ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty)
                .Hash(this.ReadOnlyListInterfaceOfBoolProperty)
                .Hash(this.ReadOnlyListInterfaceOfIntProperty)
                .Hash(this.ReadOnlyListInterfaceOfStringProperty)
                .Hash(this.ReadOnlyListInterfaceOfGuidProperty)
                .Hash(this.ReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.ReadOnlyListInterfaceOfModelEnumProperty)
                .Hash(this.ReadOnlyListInterfaceOfModelFlagsEnumProperty)
                .Hash(this.ReadOnlyListInterfaceOfModelClassProperty)
                .Hash(this.ReadOnlyListInterfaceOfNullableBoolProperty)
                .Hash(this.ReadOnlyListInterfaceOfNullableIntProperty)
                .Hash(this.ReadOnlyListInterfaceOfNullableGuidProperty)
                .Hash(this.ReadOnlyListInterfaceOfNullableDateTimeProperty)
                .Hash(this.ReadOnlyListInterfaceOfNullableModelEnumProperty)
                .Hash(this.ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfBoolProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfIntProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfStringProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfGuidProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfModelEnumProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfModelClassProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfNullableBoolProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfNullableIntProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfNullableGuidProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty)
                .Hash(this.CollectionInterfaceOfStringProperty)
                .Hash(this.CollectionOfCollectionInterfaceOfStringProperty)
                .Hash(this.ListInterfaceOfCollectionInterfaceOfStringProperty)
                .Hash(this.ListOfCollectionInterfaceOfStringProperty)
                .Hash(this.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty)
                .Hash(this.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty)
                .Value;
    }
}