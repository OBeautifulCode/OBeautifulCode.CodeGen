// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetGeneric{TFirst,TSecond}.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Type;

    public partial class ModelPrivateSetGeneric<TFirst, TSecond> :
        IModelViaCodeGen, IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<ModelPrivateSetGeneric<TFirst, TSecond>>
        where TSecond : struct
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetGeneric(
            string stringProperty,
            int intProperty,
            CustomEnum enumProperty,
            CustomClass customClassProperty,
            TFirst genericArgumentProperty,
            TFirst[] genericArrayProperty,
            TSecond? genericNullableProperty,
            CustomGenericClass<TSecond> genericCustomGenericClassProperty,
            IReadOnlyCollection<TFirst> genericReadOnlyCollectionProperty,
            IReadOnlyList<TFirst> genericReadOnlyListProperty,
            IReadOnlyDictionary<TFirst, TSecond> genericReadOnlyDictionaryProperty1,
            IReadOnlyDictionary<TSecond, TFirst> genericReadOnlyDictionaryProperty2,
            IReadOnlyDictionary<string, TSecond> genericPartiallyClosedReadOnlyDictionaryProperty1,
            IReadOnlyDictionary<TFirst, string> genericPartiallyClosedReadOnlyDictionaryProperty2)
        {
            new { stringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { customClassProperty }.AsArg().Must().NotBeNull();
            new { genericArgumentProperty }.AsArg().Must().NotBeNull();
            new { genericArrayProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { genericCustomGenericClassProperty }.AsArg().Must().NotBeNull();
            new { genericReadOnlyCollectionProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { genericReadOnlyListProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { genericReadOnlyDictionaryProperty1 }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { genericReadOnlyDictionaryProperty2 }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { genericPartiallyClosedReadOnlyDictionaryProperty1 }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { genericPartiallyClosedReadOnlyDictionaryProperty2 }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.StringProperty = stringProperty;
            this.IntProperty = intProperty;
            this.EnumProperty = enumProperty;
            this.CustomClassProperty = customClassProperty;
            this.GenericArgumentProperty = genericArgumentProperty;
            this.GenericArrayProperty = genericArrayProperty;
            this.GenericNullableProperty = genericNullableProperty;
            this.GenericCustomGenericClassProperty = genericCustomGenericClassProperty;
            this.GenericReadOnlyCollectionProperty = genericReadOnlyCollectionProperty;
            this.GenericReadOnlyListProperty = genericReadOnlyListProperty;
            this.GenericReadOnlyDictionaryProperty1 = genericReadOnlyDictionaryProperty1;
            this.GenericReadOnlyDictionaryProperty2 = genericReadOnlyDictionaryProperty2;
            this.GenericPartiallyClosedReadOnlyDictionaryProperty1 = genericPartiallyClosedReadOnlyDictionaryProperty1;
            this.GenericPartiallyClosedReadOnlyDictionaryProperty2 = genericPartiallyClosedReadOnlyDictionaryProperty2;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public string StringProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int IntProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomEnum EnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomClass CustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public TFirst GenericArgumentProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = ObcSuppressBecause.CA1819_PropertiesShouldNotReturnArrays_ArrayPropertyRequiredForTesting)]
        public TFirst[] GenericArrayProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public TSecond? GenericNullableProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomGenericClass<TSecond> GenericCustomGenericClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<TFirst> GenericReadOnlyCollectionProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyList<TFirst> GenericReadOnlyListProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<TFirst, TSecond> GenericReadOnlyDictionaryProperty1 { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<TSecond, TFirst> GenericReadOnlyDictionaryProperty2 { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<string, TSecond> GenericPartiallyClosedReadOnlyDictionaryProperty1 { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<TFirst, string> GenericPartiallyClosedReadOnlyDictionaryProperty2 { get; private set; }

        /// <inheritdoc />
        public RelativeSortOrder CompareToForRelativeSortOrder(
            ModelPrivateSetGeneric<TFirst, TSecond> other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            if (this.IntProperty < other.IntProperty)
            {
                return RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;
            }

            if (this.IntProperty > other.IntProperty)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            return RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance;
        }
    }
}