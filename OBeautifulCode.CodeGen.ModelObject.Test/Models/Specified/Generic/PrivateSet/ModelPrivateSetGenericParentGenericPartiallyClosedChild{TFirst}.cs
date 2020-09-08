// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetGenericParentGenericPartiallyClosedChild{TFirst}.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Type;

    public partial class ModelPrivateSetGenericParentGenericPartiallyClosedChild<TFirst> :
        ModelPrivateSetGenericParent<TFirst, Guid>, IModelViaCodeGen, IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<ModelPrivateSetGenericParentGenericPartiallyClosedChild<TFirst>>
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetGenericParentGenericPartiallyClosedChild(
            string parentStringProperty,
            int parentIntProperty,
            CustomEnum parentEnumProperty,
            CustomClass parentCustomClassProperty,
            TFirst parentGenericArgumentProperty,
            TFirst[] parentGenericArrayProperty,
            Guid? parentGenericNullableProperty,
            CustomGenericClass<Guid> parentGenericCustomGenericClassProperty,
            IReadOnlyCollection<TFirst> parentGenericReadOnlyCollectionProperty,
            IReadOnlyList<TFirst> parentGenericReadOnlyListProperty,
            IReadOnlyDictionary<TFirst, Guid> parentGenericReadOnlyDictionaryProperty1,
            IReadOnlyDictionary<Guid, TFirst> parentGenericReadOnlyDictionaryProperty2,
            IReadOnlyDictionary<string, Guid> parentGenericPartiallyClosedReadOnlyDictionaryProperty1,
            IReadOnlyDictionary<TFirst, string> parentGenericPartiallyClosedReadOnlyDictionaryProperty2,
            string childStringProperty,
            int childIntProperty,
            CustomEnum childEnumProperty,
            CustomClass childCustomClassProperty,
            TFirst childGenericArgumentProperty,
            TFirst[] childGenericArrayProperty,
            Guid? childGenericNullableProperty,
            CustomGenericClass<TFirst> childGenericCustomGenericClassProperty,
            IReadOnlyCollection<TFirst> childGenericReadOnlyCollectionProperty,
            IReadOnlyList<TFirst> childGenericReadOnlyListProperty,
            IReadOnlyDictionary<TFirst, Guid> childGenericReadOnlyDictionaryProperty1,
            IReadOnlyDictionary<Guid, TFirst> childGenericReadOnlyDictionaryProperty2,
            IReadOnlyDictionary<string, TFirst> childGenericPartiallyClosedReadOnlyDictionaryProperty1,
            IReadOnlyDictionary<TFirst, string> childGenericPartiallyClosedReadOnlyDictionaryProperty2)
            : base(parentStringProperty, parentIntProperty, parentEnumProperty, parentCustomClassProperty, parentGenericArgumentProperty, parentGenericArrayProperty, parentGenericNullableProperty, parentGenericCustomGenericClassProperty, parentGenericReadOnlyCollectionProperty, parentGenericReadOnlyListProperty, parentGenericReadOnlyDictionaryProperty1, parentGenericReadOnlyDictionaryProperty2, parentGenericPartiallyClosedReadOnlyDictionaryProperty1, parentGenericPartiallyClosedReadOnlyDictionaryProperty2)
        {
            new { childStringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { childCustomClassProperty }.AsArg().Must().NotBeNull();
            new { childGenericArgumentProperty }.AsArg().Must().NotBeNull();
            new { childGenericArrayProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { childGenericCustomGenericClassProperty }.AsArg().Must().NotBeNull();
            new { childGenericReadOnlyCollectionProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { childGenericReadOnlyListProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { childGenericReadOnlyDictionaryProperty1 }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { childGenericReadOnlyDictionaryProperty2 }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { childGenericPartiallyClosedReadOnlyDictionaryProperty1 }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { childGenericPartiallyClosedReadOnlyDictionaryProperty2 }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.ChildStringProperty = childStringProperty;
            this.ChildIntProperty = childIntProperty;
            this.ChildEnumProperty = childEnumProperty;
            this.ChildCustomClassProperty = childCustomClassProperty;
            this.ChildGenericArgumentProperty = childGenericArgumentProperty;
            this.ChildGenericArrayProperty = childGenericArrayProperty;
            this.ChildGenericNullableProperty = childGenericNullableProperty;
            this.ChildGenericCustomGenericClassProperty = childGenericCustomGenericClassProperty;
            this.ChildGenericReadOnlyCollectionProperty = childGenericReadOnlyCollectionProperty;
            this.ChildGenericReadOnlyListProperty = childGenericReadOnlyListProperty;
            this.ChildGenericReadOnlyDictionaryProperty1 = childGenericReadOnlyDictionaryProperty1;
            this.ChildGenericReadOnlyDictionaryProperty2 = childGenericReadOnlyDictionaryProperty2;
            this.ChildGenericPartiallyClosedReadOnlyDictionaryProperty1 = childGenericPartiallyClosedReadOnlyDictionaryProperty1;
            this.ChildGenericPartiallyClosedReadOnlyDictionaryProperty2 = childGenericPartiallyClosedReadOnlyDictionaryProperty2;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public string ChildStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int ChildIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomEnum ChildEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomClass ChildCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public TFirst ChildGenericArgumentProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = ObcSuppressBecause.CA1819_PropertiesShouldNotReturnArrays_ArrayPropertyRequiredForTesting)]
        public TFirst[] ChildGenericArrayProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public Guid? ChildGenericNullableProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomGenericClass<TFirst> ChildGenericCustomGenericClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<TFirst> ChildGenericReadOnlyCollectionProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyList<TFirst> ChildGenericReadOnlyListProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<TFirst, Guid> ChildGenericReadOnlyDictionaryProperty1 { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<Guid, TFirst> ChildGenericReadOnlyDictionaryProperty2 { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<string, TFirst> ChildGenericPartiallyClosedReadOnlyDictionaryProperty1 { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<TFirst, string> ChildGenericPartiallyClosedReadOnlyDictionaryProperty2 { get; private set; }

        /// <inheritdoc />
        public RelativeSortOrder CompareToForRelativeSortOrder(
            ModelPrivateSetGenericParentGenericPartiallyClosedChild<TFirst> other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            if (this.ChildIntProperty < other.ChildIntProperty)
            {
                return RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;
            }

            if (this.ChildIntProperty > other.ChildIntProperty)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            return RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance;
        }
    }
}