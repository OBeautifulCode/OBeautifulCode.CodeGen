﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPrivateSetReadOnlyCollection.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPrivateSetReadOnlyCollection : IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPrivateSetReadOnlyCollection>, IEquatable<ModelCloningPrivateSetReadOnlyCollection>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelCloningPrivateSetReadOnlyCollection(
            IReadOnlyCollection<bool> readOnlyCollectionInterfaceOfBoolProperty,
            IReadOnlyCollection<int> readOnlyCollectionInterfaceOfIntProperty,
            IReadOnlyCollection<string> readOnlyCollectionInterfaceOfStringProperty,
            IReadOnlyCollection<Guid> readOnlyCollectionInterfaceOfGuidProperty,
            IReadOnlyCollection<DateTime> readOnlyCollectionInterfaceOfDateTimeProperty,
            IReadOnlyCollection<CustomEnum> readOnlyCollectionInterfaceOfCustomEnumProperty,
            IReadOnlyCollection<CustomFlagsEnum> readOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyCollection<CustomClass> readOnlyCollectionInterfaceOfCustomClassProperty,
            IReadOnlyCollection<CustomBaseClass> readOnlyCollectionInterfaceOfCustomBaseClassProperty,
            IReadOnlyCollection<CustomGenericClass<CustomClass>> readOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty)
        {
            new { readOnlyCollectionInterfaceOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionInterfaceOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyCollectionInterfaceOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionInterfaceOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionInterfaceOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyCollectionInterfaceOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyCollectionInterfaceOfCustomBaseClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.ReadOnlyCollectionInterfaceOfBoolProperty = readOnlyCollectionInterfaceOfBoolProperty;
            this.ReadOnlyCollectionInterfaceOfIntProperty = readOnlyCollectionInterfaceOfIntProperty;
            this.ReadOnlyCollectionInterfaceOfStringProperty = readOnlyCollectionInterfaceOfStringProperty;
            this.ReadOnlyCollectionInterfaceOfGuidProperty = readOnlyCollectionInterfaceOfGuidProperty;
            this.ReadOnlyCollectionInterfaceOfDateTimeProperty = readOnlyCollectionInterfaceOfDateTimeProperty;
            this.ReadOnlyCollectionInterfaceOfCustomEnumProperty = readOnlyCollectionInterfaceOfCustomEnumProperty;
            this.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty = readOnlyCollectionInterfaceOfCustomFlagsEnumProperty;
            this.ReadOnlyCollectionInterfaceOfCustomClassProperty = readOnlyCollectionInterfaceOfCustomClassProperty;
            this.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty = readOnlyCollectionInterfaceOfCustomBaseClassProperty;
            this.ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty = readOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<bool> ReadOnlyCollectionInterfaceOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<int> ReadOnlyCollectionInterfaceOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<string> ReadOnlyCollectionInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<Guid> ReadOnlyCollectionInterfaceOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<DateTime> ReadOnlyCollectionInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomEnum> ReadOnlyCollectionInterfaceOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomFlagsEnum> ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomClass> ReadOnlyCollectionInterfaceOfCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomBaseClass> ReadOnlyCollectionInterfaceOfCustomBaseClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomGenericClass<CustomClass>> ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPrivateSetReadOnlyCollection other)
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
                this.ReadOnlyCollectionInterfaceOfBoolProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfBoolProperty) &&
                this.ReadOnlyCollectionInterfaceOfIntProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfIntProperty) &&
                this.ReadOnlyCollectionInterfaceOfStringProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfStringProperty) &&
                this.ReadOnlyCollectionInterfaceOfGuidProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfGuidProperty) &&
                this.ReadOnlyCollectionInterfaceOfDateTimeProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfDateTimeProperty) &&
                this.ReadOnlyCollectionInterfaceOfCustomEnumProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfCustomEnumProperty) &&
                this.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty) &&
                this.ReadOnlyCollectionInterfaceOfCustomClassProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfCustomClassProperty) &&
                this.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty) &&
                this.ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty);

            return result;
        }

        /// <inheritdoc />
        public ModelCloningPrivateSetReadOnlyCollection DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPrivateSetReadOnlyCollection DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPrivateSetReadOnlyCollection>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPrivateSetReadOnlyCollection)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPrivateSetReadOnlyCollection>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}