﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetMiscChild1.cs" company="OBeautifulCode">
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

#pragma warning disable CS0659
#pragma warning disable CS0661
    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    [SuppressMessage("Microsoft.Usage", "CA2218: OverrideGetHashCodeOnOverridingEquals")]
    public partial class ModelEqualityPublicSetMiscChild1 : ModelEqualityPublicSetMiscParent, IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPublicSetMiscChild1>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<string> Child1CollectionInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IList<string> Child1ListInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<ICollection<string>> Child1ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<IReadOnlyList<string>> Child1CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IList<ICollection<string>> Child1ListInterfaceOfCollectionInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<IList<string>> Child1ReadOnlyListInterfaceOfListInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IDictionary<string, IReadOnlyList<DateTime>> Child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, ICollection<DateTime>> Child1ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> Child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, IDictionary<CustomClass, IReadOnlyList<DateTime>>>> Child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPublicSetMiscChild1 other)
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
                this.ParentCollectionInterfaceOfStringProperty.IsEqualTo(other.ParentCollectionInterfaceOfStringProperty) &&
                this.ParentListInterfaceOfStringProperty.IsEqualTo(other.ParentListInterfaceOfStringProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty) &&
                this.ParentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty.IsEqualTo(other.ParentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty) &&
                this.ParentListInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(other.ParentListInterfaceOfCollectionInterfaceOfStringProperty) &&
                this.ParentReadOnlyListInterfaceOfListInterfaceOfStringProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfListInterfaceOfStringProperty) &&
                this.ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty) &&
                this.ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.Child1CollectionInterfaceOfStringProperty.IsEqualTo(other.Child1CollectionInterfaceOfStringProperty) &&
                this.Child1ListInterfaceOfStringProperty.IsEqualTo(other.Child1ListInterfaceOfStringProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty) &&
                this.Child1CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty.IsEqualTo(other.Child1CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty) &&
                this.Child1ListInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(other.Child1ListInterfaceOfCollectionInterfaceOfStringProperty) &&
                this.Child1ReadOnlyListInterfaceOfListInterfaceOfStringProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfListInterfaceOfStringProperty) &&
                this.Child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.Child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty) &&
                this.Child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);

            return result;
        }
    }
}