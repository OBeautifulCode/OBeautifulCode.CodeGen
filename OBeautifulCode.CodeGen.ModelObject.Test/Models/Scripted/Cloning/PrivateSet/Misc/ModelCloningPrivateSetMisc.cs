﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPrivateSetMisc.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPrivateSetMisc : IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPrivateSetMisc>, IEquatable<ModelCloningPrivateSetMisc>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelCloningPrivateSetMisc(
            ICollection<string> collectionInterfaceOfStringProperty,
            IList<string> listInterfaceOfStringProperty,
            IReadOnlyCollection<ICollection<string>> readOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
            ICollection<IReadOnlyList<string>> collectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
            IList<ICollection<string>> listInterfaceOfCollectionInterfaceOfStringProperty,
            IReadOnlyList<IList<string>> readOnlyListInterfaceOfListInterfaceOfStringProperty,
            IDictionary<string, IReadOnlyList<DateTime>> dictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyDictionary<string, ICollection<DateTime>> readOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
            IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> readOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyDictionary<string, IReadOnlyDictionary<string, IDictionary<CustomClass, IReadOnlyList<DateTime>>>> readOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)
        {
            new { collectionInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { listInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { collectionInterfaceOfReadOnlyListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { listInterfaceOfCollectionInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyListInterfaceOfListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { dictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { readOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { readOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.CollectionInterfaceOfStringProperty = collectionInterfaceOfStringProperty;
            this.ListInterfaceOfStringProperty = listInterfaceOfStringProperty;
            this.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty = readOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty;
            this.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty = collectionInterfaceOfReadOnlyListInterfaceOfStringProperty;
            this.ListInterfaceOfCollectionInterfaceOfStringProperty = listInterfaceOfCollectionInterfaceOfStringProperty;
            this.ReadOnlyListInterfaceOfListInterfaceOfStringProperty = readOnlyListInterfaceOfListInterfaceOfStringProperty;
            this.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty = dictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty;
            this.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty = readOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty;
            this.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty = readOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty;
            this.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty = readOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<string> CollectionInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IList<string> ListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<ICollection<string>> ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<IReadOnlyList<string>> CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IList<ICollection<string>> ListInterfaceOfCollectionInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<IList<string>> ReadOnlyListInterfaceOfListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IDictionary<string, IReadOnlyList<DateTime>> DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, ICollection<DateTime>> ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, IDictionary<CustomClass, IReadOnlyList<DateTime>>>> ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPrivateSetMisc other)
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
                this.CollectionInterfaceOfStringProperty.IsEqualTo(other.CollectionInterfaceOfStringProperty) &&
                this.ListInterfaceOfStringProperty.IsEqualTo(other.ListInterfaceOfStringProperty) &&
                this.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty) &&
                this.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty.IsEqualTo(other.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty) &&
                this.ListInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(other.ListInterfaceOfCollectionInterfaceOfStringProperty) &&
                this.ReadOnlyListInterfaceOfListInterfaceOfStringProperty.IsEqualTo(other.ReadOnlyListInterfaceOfListInterfaceOfStringProperty) &&
                this.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty) &&
                this.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);

            return result;
        }

        /// <inheritdoc />
        public ModelCloningPrivateSetMisc DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPrivateSetMisc DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPrivateSetMisc>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPrivateSetMisc)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPrivateSetMisc>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}