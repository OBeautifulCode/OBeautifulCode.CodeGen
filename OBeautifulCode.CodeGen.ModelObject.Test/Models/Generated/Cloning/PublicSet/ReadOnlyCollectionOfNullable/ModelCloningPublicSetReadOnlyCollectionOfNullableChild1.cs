﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPublicSetReadOnlyCollectionOfNullableChild1.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPublicSetReadOnlyCollectionOfNullableChild1 : ModelCloningPublicSetReadOnlyCollectionOfNullableParent, IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPublicSetReadOnlyCollectionOfNullableChild1>, IEquatable<ModelCloningPublicSetReadOnlyCollectionOfNullableChild1>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<bool?> Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<int?> Child1ReadOnlyCollectionInterfaceOfNullableIntProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<Guid?> Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<DateTime?> Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomEnum?> Child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomFlagsEnum?> Child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPublicSetReadOnlyCollectionOfNullableChild1 other)
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
                this.ParentReadOnlyCollectionInterfaceOfNullableBoolProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfNullableBoolProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfNullableIntProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfNullableIntProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfNullableGuidProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfNullableGuidProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfNullableIntProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfNullableIntProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(ModelCloningPublicSetReadOnlyCollectionOfNullableParent other)
        {
            var result = this.Equals((ModelCloningPublicSetReadOnlyCollectionOfNullableChild1)other);

            return result;
        }

        /// <inheritdoc />
        ModelCloningPublicSetReadOnlyCollectionOfNullableChild1 IDeclareDeepCloneMethod<ModelCloningPublicSetReadOnlyCollectionOfNullableChild1>.DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPublicSetReadOnlyCollectionOfNullableChild1 DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPublicSetReadOnlyCollectionOfNullableChild1>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPublicSetReadOnlyCollectionOfNullableChild1)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPublicSetReadOnlyCollectionOfNullableChild1>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}