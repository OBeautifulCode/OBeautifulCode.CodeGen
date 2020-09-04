// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetGenericParent{TFirst, TSecond}.cs" company="OBeautifulCode">
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

    public abstract partial class ModelPrivateSetGenericParent<TFirst, TSecond> :
        IModelViaCodeGen, IComparableViaCodeGen
        where TSecond : struct
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        protected ModelPrivateSetGenericParent(
            string parentStringProperty,
            int parentIntProperty,
            CustomEnum parentEnumProperty,
            CustomClass parentCustomClassProperty,
            TFirst parentGenericArgumentProperty,
            TFirst[] parentGenericArrayProperty,
            TSecond? parentGenericNullableProperty,
            CustomGenericClass<TSecond> parentGenericCustomGenericClassProperty,
            IReadOnlyCollection<TFirst> parentGenericReadOnlyCollectionProperty,
            IReadOnlyList<TFirst> parentGenericReadOnlyListProperty,
            IReadOnlyDictionary<TFirst, TSecond> parentGenericReadOnlyDictionaryProperty1,
            IReadOnlyDictionary<TSecond, TFirst> parentGenericReadOnlyDictionaryProperty2,
            IReadOnlyDictionary<string, TSecond> parentGenericPartiallyClosedReadOnlyDictionaryProperty1,
            IReadOnlyDictionary<TFirst, string> parentGenericPartiallyClosedReadOnlyDictionaryProperty2)
        {
            new { parentStringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { parentCustomClassProperty }.AsArg().Must().NotBeNull();
            new { parentGenericArgumentProperty }.AsArg().Must().NotBeNull();
            new { parentGenericArrayProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { parentGenericCustomGenericClassProperty }.AsArg().Must().NotBeNull();
            new { parentGenericReadOnlyCollectionProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { parentGenericReadOnlyListProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { parentGenericReadOnlyDictionaryProperty1 }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { parentGenericReadOnlyDictionaryProperty2 }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { parentGenericPartiallyClosedReadOnlyDictionaryProperty1 }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { parentGenericPartiallyClosedReadOnlyDictionaryProperty2 }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.ParentStringProperty = parentStringProperty;
            this.ParentIntProperty = parentIntProperty;
            this.ParentEnumProperty = parentEnumProperty;
            this.ParentCustomClassProperty = parentCustomClassProperty;
            this.ParentGenericArgumentProperty = parentGenericArgumentProperty;
            this.ParentGenericArrayProperty = parentGenericArrayProperty;
            this.ParentGenericNullableProperty = parentGenericNullableProperty;
            this.ParentGenericCustomGenericClassProperty = parentGenericCustomGenericClassProperty;
            this.ParentGenericReadOnlyCollectionProperty = parentGenericReadOnlyCollectionProperty;
            this.ParentGenericReadOnlyListProperty = parentGenericReadOnlyListProperty;
            this.ParentGenericReadOnlyDictionaryProperty1 = parentGenericReadOnlyDictionaryProperty1;
            this.ParentGenericReadOnlyDictionaryProperty2 = parentGenericReadOnlyDictionaryProperty2;
            this.ParentGenericPartiallyClosedReadOnlyDictionaryProperty1 = parentGenericPartiallyClosedReadOnlyDictionaryProperty1;
            this.ParentGenericPartiallyClosedReadOnlyDictionaryProperty2 = parentGenericPartiallyClosedReadOnlyDictionaryProperty2;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public string ParentStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int ParentIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomEnum ParentEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomClass ParentCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public TFirst ParentGenericArgumentProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public TFirst[] ParentGenericArrayProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public TSecond? ParentGenericNullableProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomGenericClass<TSecond> ParentGenericCustomGenericClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<TFirst> ParentGenericReadOnlyCollectionProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyList<TFirst> ParentGenericReadOnlyListProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<TFirst, TSecond> ParentGenericReadOnlyDictionaryProperty1 { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<TSecond, TFirst> ParentGenericReadOnlyDictionaryProperty2 { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<string, TSecond> ParentGenericPartiallyClosedReadOnlyDictionaryProperty1 { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<TFirst, string> ParentGenericPartiallyClosedReadOnlyDictionaryProperty2 { get; private set; }
    }
}