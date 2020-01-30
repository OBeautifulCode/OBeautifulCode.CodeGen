// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelEqualityPublicSettersParent.cs" company="OBeautifulCode">
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
    public abstract partial class MyModelEqualityPublicSettersParent : IEquatableViaCodeGen
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        public bool ParentBoolProperty { get; set; }

        public int ParentIntProperty { get; set; }

        public string ParentStringProperty { get; set; }

        public Guid ParentGuidProperty { get; set; }

        public DateTime ParentDateTimeProperty { get; set; }

        public ModelEnum ParentModelEnumProperty { get; set; }

        public ModelFlagsEnum ParentModelFlagsEnumProperty { get; set; }

        public ModelClass ParentModelClassProperty { get; set; }

        public bool? ParentNullableBoolProperty { get; set; }

        public int? ParentNullableIntProperty { get; set; }

        public Guid? ParentNullableGuidProperty { get; set; }

        public DateTime? ParentNullableDateTimeProperty { get; set; }

        public ModelEnum? ParentNullableModelEnumProperty { get; set; }

        public ModelFlagsEnum? ParentNullableModelFlagsEnumProperty { get; set; }

        public bool[] ParentArrayOfBoolProperty { get; set; }

        public int[] ParentArrayOfIntProperty { get; set; }

        public string[] ParentArrayOfStringProperty { get; set; }

        public Guid[] ParentArrayOfGuidProperty { get; set; }

        public DateTime[] ParentArrayOfDateTimeProperty { get; set; }

        public ModelEnum[] ParentArrayOfModelEnumProperty { get; set; }

        public ModelFlagsEnum[] ParentArrayOfModelFlagsEnumProperty { get; set; }

        public ModelClass[] ParentArrayOfModelClassProperty { get; set; }

        public bool?[] ParentArrayOfNullableBoolProperty { get; set; }

        public int?[] ParentArrayOfNullableIntProperty { get; set; }

        public Guid?[] ParentArrayOfNullableGuidProperty { get; set; }

        public DateTime?[] ParentArrayOfNullableDateTimeProperty { get; set; }

        public ModelEnum?[] ParentArrayOfNullableModelEnumProperty { get; set; }

        public ModelFlagsEnum?[] ParentArrayOfNullableModelFlagsEnumProperty { get; set; }

        public IReadOnlyCollection<bool> ParentReadOnlyCollectionInterfaceOfBoolProperty { get; set; }

        public IReadOnlyCollection<int> ParentReadOnlyCollectionInterfaceOfIntProperty { get; set; }

        public IReadOnlyCollection<string> ParentReadOnlyCollectionInterfaceOfStringProperty { get; set; }

        public IReadOnlyCollection<Guid> ParentReadOnlyCollectionInterfaceOfGuidProperty { get; set; }

        public IReadOnlyCollection<DateTime> ParentReadOnlyCollectionInterfaceOfDateTimeProperty { get; set; }

        public IReadOnlyCollection<ModelEnum> ParentReadOnlyCollectionInterfaceOfModelEnumProperty { get; set; }

        public IReadOnlyCollection<ModelFlagsEnum> ParentReadOnlyCollectionInterfaceOfModelFlagsEnumProperty { get; set; }

        public IReadOnlyCollection<ModelClass> ParentReadOnlyCollectionInterfaceOfModelClassProperty { get; set; }

        public IReadOnlyCollection<bool?> ParentReadOnlyCollectionInterfaceOfNullableBoolProperty { get; set; }

        public IReadOnlyCollection<int?> ParentReadOnlyCollectionInterfaceOfNullableIntProperty { get; set; }

        public IReadOnlyCollection<Guid?> ParentReadOnlyCollectionInterfaceOfNullableGuidProperty { get; set; }

        public IReadOnlyCollection<DateTime?> ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty { get; set; }

        public IReadOnlyCollection<ModelEnum?> ParentReadOnlyCollectionInterfaceOfNullableModelEnumProperty { get; set; }

        public IReadOnlyCollection<ModelFlagsEnum?> ParentReadOnlyCollectionInterfaceOfNullableModelFlagsEnumProperty { get; set; }

        public IReadOnlyList<bool> ParentReadOnlyListInterfaceOfBoolProperty { get; set; }

        public IReadOnlyList<int> ParentReadOnlyListInterfaceOfIntProperty { get; set; }

        public IReadOnlyList<string> ParentReadOnlyListInterfaceOfStringProperty { get; set; }

        public IReadOnlyList<Guid> ParentReadOnlyListInterfaceOfGuidProperty { get; set; }

        public IReadOnlyList<DateTime> ParentReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public IReadOnlyList<ModelEnum> ParentReadOnlyListInterfaceOfModelEnumProperty { get; set; }

        public IReadOnlyList<ModelFlagsEnum> ParentReadOnlyListInterfaceOfModelFlagsEnumProperty { get; set; }

        public IReadOnlyList<ModelClass> ParentReadOnlyListInterfaceOfModelClassProperty { get; set; }

        public IReadOnlyList<bool?> ParentReadOnlyListInterfaceOfNullableBoolProperty { get; set; }

        public IReadOnlyList<int?> ParentReadOnlyListInterfaceOfNullableIntProperty { get; set; }

        public IReadOnlyList<Guid?> ParentReadOnlyListInterfaceOfNullableGuidProperty { get; set; }

        public IReadOnlyList<DateTime?> ParentReadOnlyListInterfaceOfNullableDateTimeProperty { get; set; }

        public IReadOnlyList<ModelEnum?> ParentReadOnlyListInterfaceOfNullableModelEnumProperty { get; set; }

        public IReadOnlyList<ModelFlagsEnum?> ParentReadOnlyListInterfaceOfNullableModelFlagsEnumProperty { get; set; }

        public IReadOnlyDictionary<bool, bool> ParentReadOnlyDictionaryInterfaceOfBoolProperty { get; set; }

        public IReadOnlyDictionary<int, int> ParentReadOnlyDictionaryInterfaceOfIntProperty { get; set; }

        public IReadOnlyDictionary<string, string> ParentReadOnlyDictionaryInterfaceOfStringProperty { get; set; }

        public IReadOnlyDictionary<Guid, Guid> ParentReadOnlyDictionaryInterfaceOfGuidProperty { get; set; }

        public IReadOnlyDictionary<ModelEnum, ModelEnum> ParentReadOnlyDictionaryInterfaceOfModelEnumProperty { get; set; }

        public IReadOnlyDictionary<ModelFlagsEnum, ModelFlagsEnum> ParentReadOnlyDictionaryInterfaceOfModelFlagsEnumProperty { get; set; }

        public IReadOnlyDictionary<ModelClass, ModelClass> ParentReadOnlyDictionaryInterfaceOfModelClassProperty { get; set; }

        public IReadOnlyDictionary<bool?, bool?> ParentReadOnlyDictionaryInterfaceOfNullableBoolProperty { get; set; }

        public IReadOnlyDictionary<int?, int?> ParentReadOnlyDictionaryInterfaceOfNullableIntProperty { get; set; }

        public IReadOnlyDictionary<Guid?, Guid?> ParentReadOnlyDictionaryInterfaceOfNullableGuidProperty { get; set; }

        public IReadOnlyDictionary<ModelEnum?, ModelEnum?> ParentReadOnlyDictionaryInterfaceOfNullableModelEnumProperty { get; set; }

        public IReadOnlyDictionary<ModelFlagsEnum?, ModelFlagsEnum?> ParentReadOnlyDictionaryInterfaceOfNullableModelFlagsEnumProperty { get; set; }

        public ICollection<string> ParentCollectionInterfaceOfStringProperty { get; set; }

        public Collection<ICollection<string>> ParentCollectionOfCollectionInterfaceOfStringProperty { get; set; }

        public IList<ICollection<string>> ParentListInterfaceOfCollectionInterfaceOfStringProperty { get; set; }

        public List<ICollection<string>> ParentListOfCollectionInterfaceOfStringProperty { get; set; }

        public ReadOnlyCollection<ICollection<string>> ParentReadOnlyCollectionOfCollectionInterfaceOfStringProperty { get; set; }

        public IDictionary<string, IReadOnlyList<DateTime>> ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public Dictionary<string, IReadOnlyList<DateTime>> ParentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public ReadOnlyDictionary<string, IReadOnlyList<DateTime>> ParentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public ConcurrentDictionary<string, IReadOnlyList<DateTime>> ParentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, ReadOnlyDictionary<ModelClass, IReadOnlyList<DateTime>>>> ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }
    }
}