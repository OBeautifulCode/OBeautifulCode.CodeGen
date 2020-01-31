// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelCloningPublicSetters.cs" company="OBeautifulCode">
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

#pragma warning disable CS0659
#pragma warning disable CS0661
    public partial class MyModelCloningPublicSetters : IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<MyModelCloningPublicSetters>, IEquatable<MyModelCloningPublicSetters>
#pragma warning disable CS0659
#pragma warning disable CS0661
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
        public bool Equals(MyModelCloningPublicSetters other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = 
                this.BoolProperty.IsEqualTo(other.BoolProperty) &&
                this.IntProperty.IsEqualTo(other.IntProperty) &&
                this.StringProperty.IsEqualTo(other.StringProperty) &&
                this.GuidProperty.IsEqualTo(other.GuidProperty) &&
                this.DateTimeProperty.IsEqualTo(other.DateTimeProperty) &&
                this.ModelEnumProperty.IsEqualTo(other.ModelEnumProperty) &&
                this.ModelFlagsEnumProperty.IsEqualTo(other.ModelFlagsEnumProperty) &&
                this.ModelClassProperty.IsEqualTo(other.ModelClassProperty) &&
                this.NullableBoolProperty.IsEqualTo(other.NullableBoolProperty) &&
                this.NullableIntProperty.IsEqualTo(other.NullableIntProperty) &&
                this.NullableGuidProperty.IsEqualTo(other.NullableGuidProperty) &&
                this.NullableDateTimeProperty.IsEqualTo(other.NullableDateTimeProperty) &&
                this.NullableModelEnumProperty.IsEqualTo(other.NullableModelEnumProperty) &&
                this.NullableModelFlagsEnumProperty.IsEqualTo(other.NullableModelFlagsEnumProperty) &&
                this.ArrayOfBoolProperty.IsEqualTo(other.ArrayOfBoolProperty) &&
                this.ArrayOfIntProperty.IsEqualTo(other.ArrayOfIntProperty) &&
                this.ArrayOfStringProperty.IsEqualTo(other.ArrayOfStringProperty) &&
                this.ArrayOfGuidProperty.IsEqualTo(other.ArrayOfGuidProperty) &&
                this.ArrayOfDateTimeProperty.IsEqualTo(other.ArrayOfDateTimeProperty) &&
                this.ArrayOfModelEnumProperty.IsEqualTo(other.ArrayOfModelEnumProperty) &&
                this.ArrayOfModelFlagsEnumProperty.IsEqualTo(other.ArrayOfModelFlagsEnumProperty) &&
                this.ArrayOfModelClassProperty.IsEqualTo(other.ArrayOfModelClassProperty) &&
                this.ArrayOfNullableBoolProperty.IsEqualTo(other.ArrayOfNullableBoolProperty) &&
                this.ArrayOfNullableIntProperty.IsEqualTo(other.ArrayOfNullableIntProperty) &&
                this.ArrayOfNullableGuidProperty.IsEqualTo(other.ArrayOfNullableGuidProperty) &&
                this.ArrayOfNullableDateTimeProperty.IsEqualTo(other.ArrayOfNullableDateTimeProperty) &&
                this.ArrayOfNullableModelEnumProperty.IsEqualTo(other.ArrayOfNullableModelEnumProperty) &&
                this.ArrayOfNullableModelFlagsEnumProperty.IsEqualTo(other.ArrayOfNullableModelFlagsEnumProperty) &&
                this.ReadOnlyCollectionInterfaceOfBoolProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfBoolProperty) &&
                this.ReadOnlyCollectionInterfaceOfIntProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfIntProperty) &&
                this.ReadOnlyCollectionInterfaceOfStringProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfStringProperty) &&
                this.ReadOnlyCollectionInterfaceOfGuidProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfGuidProperty) &&
                this.ReadOnlyCollectionInterfaceOfDateTimeProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfDateTimeProperty) &&
                this.ReadOnlyCollectionInterfaceOfModelEnumProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfModelEnumProperty) &&
                this.ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfModelFlagsEnumProperty) &&
                this.ReadOnlyCollectionInterfaceOfModelClassProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfModelClassProperty) &&
                this.ReadOnlyCollectionInterfaceOfNullableBoolProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfNullableBoolProperty) &&
                this.ReadOnlyCollectionInterfaceOfNullableIntProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfNullableIntProperty) &&
                this.ReadOnlyCollectionInterfaceOfNullableGuidProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfNullableGuidProperty) &&
                this.ReadOnlyCollectionInterfaceOfNullableDateTimeProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfNullableDateTimeProperty) &&
                this.ReadOnlyCollectionInterfaceOfNullableModelEnumProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfNullableModelEnumProperty) &&
                this.ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty) &&
                this.ReadOnlyListInterfaceOfBoolProperty.IsEqualTo(other.ReadOnlyListInterfaceOfBoolProperty) &&
                this.ReadOnlyListInterfaceOfIntProperty.IsEqualTo(other.ReadOnlyListInterfaceOfIntProperty) &&
                this.ReadOnlyListInterfaceOfStringProperty.IsEqualTo(other.ReadOnlyListInterfaceOfStringProperty) &&
                this.ReadOnlyListInterfaceOfGuidProperty.IsEqualTo(other.ReadOnlyListInterfaceOfGuidProperty) &&
                this.ReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ReadOnlyListInterfaceOfModelEnumProperty.IsEqualTo(other.ReadOnlyListInterfaceOfModelEnumProperty) &&
                this.ReadOnlyListInterfaceOfModelFlagsEnumProperty.IsEqualTo(other.ReadOnlyListInterfaceOfModelFlagsEnumProperty) &&
                this.ReadOnlyListInterfaceOfModelClassProperty.IsEqualTo(other.ReadOnlyListInterfaceOfModelClassProperty) &&
                this.ReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableBoolProperty) &&
                this.ReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableIntProperty) &&
                this.ReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableGuidProperty) &&
                this.ReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableDateTimeProperty) &&
                this.ReadOnlyListInterfaceOfNullableModelEnumProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableModelEnumProperty) &&
                this.ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableModelFlagsEnumProperty) &&
                this.ReadOnlyDictionaryInterfaceOfBoolProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfBoolProperty) &&
                this.ReadOnlyDictionaryInterfaceOfIntProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfIntProperty) &&
                this.ReadOnlyDictionaryInterfaceOfStringProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfStringProperty) &&
                this.ReadOnlyDictionaryInterfaceOfGuidProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfGuidProperty) &&
                this.ReadOnlyDictionaryInterfaceOfModelEnumProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfModelEnumProperty) &&
                this.ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty) &&
                this.ReadOnlyDictionaryInterfaceOfModelClassProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfModelClassProperty) &&
                this.ReadOnlyDictionaryInterfaceOfNullableBoolProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfNullableBoolProperty) &&
                this.ReadOnlyDictionaryInterfaceOfNullableIntProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfNullableIntProperty) &&
                this.ReadOnlyDictionaryInterfaceOfNullableGuidProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfNullableGuidProperty) &&
                this.ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfNullableModelEnumProperty) &&
                this.ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty) &&
                this.CollectionInterfaceOfStringProperty.IsEqualTo(other.CollectionInterfaceOfStringProperty) &&
                this.CollectionOfCollectionInterfaceOfStringProperty.IsEqualTo(other.CollectionOfCollectionInterfaceOfStringProperty) &&
                this.ListInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(other.ListInterfaceOfCollectionInterfaceOfStringProperty) &&
                this.ListOfCollectionInterfaceOfStringProperty.IsEqualTo(other.ListOfCollectionInterfaceOfStringProperty) &&
                this.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty.IsEqualTo(other.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty) &&
                this.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);

            return result;
        }

        /// <inheritdoc />
        public MyModelCloningPublicSetters DeepClone()
        {
            var result = this.DeepCloneInternal();

            return result;
        }

        private MyModelCloningPublicSetters DeepCloneInternal()
        {
            var referenceModel = A.Dummy<MyModelAllPublicSetters>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (MyModelAllPublicSetters)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<MyModelCloningPublicSetters>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}