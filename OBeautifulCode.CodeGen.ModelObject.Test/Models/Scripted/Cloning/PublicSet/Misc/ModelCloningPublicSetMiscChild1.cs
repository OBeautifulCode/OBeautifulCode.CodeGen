﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPublicSetMiscChild1.cs" company="OBeautifulCode">
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
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

#pragma warning disable CS0659
#pragma warning disable CS0661
    public partial class ModelCloningPublicSetMiscChild1 : ModelCloningPublicSetMiscParent, IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPublicSetMiscChild1>, IEquatable<ModelCloningPublicSetMiscChild1>
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
        public Collection<ICollection<string>> Child1CollectionOfCollectionInterfaceOfStringProperty { get; set; }

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
        public List<ICollection<string>> Child1ListOfCollectionInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ReadOnlyCollection<ICollection<string>> Child1ReadOnlyCollectionOfCollectionInterfaceOfStringProperty { get; set; }

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
        public Dictionary<string, IReadOnlyList<DateTime>> Child1DictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ReadOnlyDictionary<string, IReadOnlyList<DateTime>> Child1ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ConcurrentDictionary<string, IReadOnlyList<DateTime>> Child1ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

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
        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, ReadOnlyDictionary<CustomClass, IReadOnlyList<DateTime>>>> Child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPublicSetMiscChild1 other)
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
                this.ParentCollectionOfCollectionInterfaceOfStringProperty.IsEqualTo(other.ParentCollectionOfCollectionInterfaceOfStringProperty) &&
                this.ParentListInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(other.ParentListInterfaceOfCollectionInterfaceOfStringProperty) &&
                this.ParentListOfCollectionInterfaceOfStringProperty.IsEqualTo(other.ParentListOfCollectionInterfaceOfStringProperty) &&
                this.ParentReadOnlyCollectionOfCollectionInterfaceOfStringProperty.IsEqualTo(other.ParentReadOnlyCollectionOfCollectionInterfaceOfStringProperty) &&
                this.ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ParentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ParentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ParentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ParentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ParentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ParentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.Child1CollectionInterfaceOfStringProperty.IsEqualTo(other.Child1CollectionInterfaceOfStringProperty) &&
                this.Child1CollectionOfCollectionInterfaceOfStringProperty.IsEqualTo(other.Child1CollectionOfCollectionInterfaceOfStringProperty) &&
                this.Child1ListInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(other.Child1ListInterfaceOfCollectionInterfaceOfStringProperty) &&
                this.Child1ListOfCollectionInterfaceOfStringProperty.IsEqualTo(other.Child1ListOfCollectionInterfaceOfStringProperty) &&
                this.Child1ReadOnlyCollectionOfCollectionInterfaceOfStringProperty.IsEqualTo(other.Child1ReadOnlyCollectionOfCollectionInterfaceOfStringProperty) &&
                this.Child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.Child1DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.Child1DictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.Child1DictionaryOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.Child1ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.Child1ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.Child1ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.Child1ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.Child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(ModelCloningPublicSetMiscParent other)
        {
            var result = this.Equals((ModelCloningPublicSetMiscChild1)other);

            return result;
        }

        /// <inheritdoc />
        ModelCloningPublicSetMiscChild1 IDeclareDeepCloneMethod<ModelCloningPublicSetMiscChild1>.DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPublicSetMiscChild1 DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPublicSetMiscChild1>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPublicSetMiscChild1)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPublicSetMiscChild1>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}