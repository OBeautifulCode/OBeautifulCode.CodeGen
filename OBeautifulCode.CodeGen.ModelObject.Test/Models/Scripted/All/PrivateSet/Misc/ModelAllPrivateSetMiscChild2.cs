﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelAllPrivateSetMiscChild2.cs" company="OBeautifulCode">
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

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    public partial class ModelAllPrivateSetMiscChild2 : ModelAllPrivateSetMiscParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelAllPrivateSetMiscChild2(
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
            ICollection<string> child2CollectionInterfaceOfStringProperty,
            IList<string> child2ListInterfaceOfStringProperty,
            IReadOnlyCollection<ICollection<string>> child2ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
            ICollection<IReadOnlyList<string>> child2CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
            IList<ICollection<string>> child2ListInterfaceOfCollectionInterfaceOfStringProperty,
            IReadOnlyList<IList<string>> child2ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
            IDictionary<string, IReadOnlyList<DateTime>> child2DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyDictionary<string, ICollection<DateTime>> child2ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
            IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> child2ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyDictionary<string, IReadOnlyDictionary<string, IDictionary<CustomClass, IReadOnlyList<DateTime>>>> child2ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
            : base(parentCollectionInterfaceOfStringProperty, parentListInterfaceOfStringProperty, parentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty, parentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty, parentListInterfaceOfCollectionInterfaceOfStringProperty, parentReadOnlyListInterfaceOfListInterfaceOfStringProperty, parentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty, parentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty, parentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty, parentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
        {
            new { child2CollectionInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls().And().Each().NotBeNullNorWhiteSpace();
            new { child2ListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls().And().Each().NotBeNullNorWhiteSpace();
            new { child2ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2ListInterfaceOfCollectionInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2ReadOnlyListInterfaceOfListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { child2ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { child2ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.Child2CollectionInterfaceOfStringProperty = child2CollectionInterfaceOfStringProperty;
            this.Child2ListInterfaceOfStringProperty = child2ListInterfaceOfStringProperty;
            this.Child2ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty = child2ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty;
            this.Child2CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty = child2CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty;
            this.Child2ListInterfaceOfCollectionInterfaceOfStringProperty = child2ListInterfaceOfCollectionInterfaceOfStringProperty;
            this.Child2ReadOnlyListInterfaceOfListInterfaceOfStringProperty = child2ReadOnlyListInterfaceOfListInterfaceOfStringProperty;
            this.Child2DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty = child2DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty = child2ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty;
            this.Child2ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty = child2ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty = child2ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<string> Child2CollectionInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IList<string> Child2ListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<ICollection<string>> Child2ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<IReadOnlyList<string>> Child2CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IList<ICollection<string>> Child2ListInterfaceOfCollectionInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<IList<string>> Child2ReadOnlyListInterfaceOfListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IDictionary<string, IReadOnlyList<DateTime>> Child2DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, ICollection<DateTime>> Child2ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> Child2ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, IDictionary<CustomClass, IReadOnlyList<DateTime>>>> Child2ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; private set; }
    }
}