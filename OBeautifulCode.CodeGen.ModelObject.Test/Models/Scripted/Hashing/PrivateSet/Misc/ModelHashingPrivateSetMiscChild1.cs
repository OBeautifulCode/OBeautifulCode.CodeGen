﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetMiscChild1.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    using FakeItEasy;

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    public partial class ModelHashingPrivateSetMiscChild1 : ModelHashingPrivateSetMiscParent, IHashableViaCodeGen, IDeclareGetHashCodeMethod
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelHashingPrivateSetMiscChild1(
            ICollection<string> parentCollectionInterfaceOfStringProperty,
            IList<string> parentListInterfaceOfStringProperty,
            IReadOnlyCollection<ICollection<string>> parentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
            ICollection<IReadOnlyList<string>> parentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
            IList<ICollection<string>> parentListInterfaceOfCollectionInterfaceOfStringProperty,
            IReadOnlyList<IList<string>> parentReadOnlyListInterfaceOfListInterfaceOfStringProperty,
            IDictionary<string, IReadOnlyList<DateTime>> parentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyDictionary<string, ICollection<DateTime>> parentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
            IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> parentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyDictionary<string, IReadOnlyDictionary<string, IDictionary<CustomClass, IReadOnlyList<DateTime>>>> parentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
            ICollection<string> child1CollectionInterfaceOfStringProperty,
            IList<string> child1ListInterfaceOfStringProperty,
            IReadOnlyCollection<ICollection<string>> child1ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
            ICollection<IReadOnlyList<string>> child1CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
            IList<ICollection<string>> child1ListInterfaceOfCollectionInterfaceOfStringProperty,
            IReadOnlyList<IList<string>> child1ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
            IDictionary<string, IReadOnlyList<DateTime>> child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyDictionary<string, ICollection<DateTime>> child1ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
            IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyDictionary<string, IReadOnlyDictionary<string, IDictionary<CustomClass, IReadOnlyList<DateTime>>>> child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
            : base(parentCollectionInterfaceOfStringProperty, parentListInterfaceOfStringProperty, parentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty, parentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty, parentListInterfaceOfCollectionInterfaceOfStringProperty, parentReadOnlyListInterfaceOfListInterfaceOfStringProperty, parentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty, parentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty, parentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty, parentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
        {
            new { child1CollectionInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ListInterfaceOfCollectionInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyListInterfaceOfListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { child1ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.Child1CollectionInterfaceOfStringProperty = child1CollectionInterfaceOfStringProperty;
            this.Child1ListInterfaceOfStringProperty = child1ListInterfaceOfStringProperty;
            this.Child1ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty = child1ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty;
            this.Child1CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty = child1CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty;
            this.Child1ListInterfaceOfCollectionInterfaceOfStringProperty = child1ListInterfaceOfCollectionInterfaceOfStringProperty;
            this.Child1ReadOnlyListInterfaceOfListInterfaceOfStringProperty = child1ReadOnlyListInterfaceOfListInterfaceOfStringProperty;
            this.Child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty = child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty;
            this.Child1ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty = child1ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty;
            this.Child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty = child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty;
            this.Child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty = child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<string> Child1CollectionInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IList<string> Child1ListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<ICollection<string>> Child1ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<IReadOnlyList<string>> Child1CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IList<ICollection<string>> Child1ListInterfaceOfCollectionInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<IList<string>> Child1ReadOnlyListInterfaceOfListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IDictionary<string, IReadOnlyList<DateTime>> Child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, ICollection<DateTime>> Child1ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> Child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, IDictionary<CustomClass, IReadOnlyList<DateTime>>>> Child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; private set; }

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
                .Hash(this.ParentCollectionInterfaceOfStringProperty)
                .Hash(this.ParentListInterfaceOfStringProperty)
                .Hash(this.ParentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty)
                .Hash(this.ParentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty)
                .Hash(this.ParentListInterfaceOfCollectionInterfaceOfStringProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfListInterfaceOfStringProperty)
                .Hash(this.ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.ParentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.Child1CollectionInterfaceOfStringProperty)
                .Hash(this.Child1ListInterfaceOfStringProperty)
                .Hash(this.Child1ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty)
                .Hash(this.Child1CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty)
                .Hash(this.Child1ListInterfaceOfCollectionInterfaceOfStringProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfListInterfaceOfStringProperty)
                .Hash(this.Child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.Child1ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.Child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
                .Value;
    }
}