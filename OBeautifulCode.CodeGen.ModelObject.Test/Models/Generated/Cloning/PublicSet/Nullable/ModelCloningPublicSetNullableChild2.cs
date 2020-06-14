﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPublicSetNullableChild2.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPublicSetNullableChild2 : ModelCloningPublicSetNullableParent, IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPublicSetNullableChild2>, IEquatable<ModelCloningPublicSetNullableChild2>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public bool? Child2NullableBoolProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int? Child2NullableIntProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Guid? Child2NullableGuidProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public DateTime? Child2NullableDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomEnum? Child2NullableCustomEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomFlagsEnum? Child2NullableCustomFlagsEnumProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPublicSetNullableChild2 other)
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
                this.ParentNullableBoolProperty.IsEqualTo(other.ParentNullableBoolProperty) &&
                this.ParentNullableIntProperty.IsEqualTo(other.ParentNullableIntProperty) &&
                this.ParentNullableGuidProperty.IsEqualTo(other.ParentNullableGuidProperty) &&
                this.ParentNullableDateTimeProperty.IsEqualTo(other.ParentNullableDateTimeProperty) &&
                this.ParentNullableCustomEnumProperty.IsEqualTo(other.ParentNullableCustomEnumProperty) &&
                this.ParentNullableCustomFlagsEnumProperty.IsEqualTo(other.ParentNullableCustomFlagsEnumProperty) &&
                this.Child2NullableBoolProperty.IsEqualTo(other.Child2NullableBoolProperty) &&
                this.Child2NullableIntProperty.IsEqualTo(other.Child2NullableIntProperty) &&
                this.Child2NullableGuidProperty.IsEqualTo(other.Child2NullableGuidProperty) &&
                this.Child2NullableDateTimeProperty.IsEqualTo(other.Child2NullableDateTimeProperty) &&
                this.Child2NullableCustomEnumProperty.IsEqualTo(other.Child2NullableCustomEnumProperty) &&
                this.Child2NullableCustomFlagsEnumProperty.IsEqualTo(other.Child2NullableCustomFlagsEnumProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(ModelCloningPublicSetNullableParent other)
        {
            var result = this.Equals((ModelCloningPublicSetNullableChild2)other);

            return result;
        }

        /// <inheritdoc />
        ModelCloningPublicSetNullableChild2 IDeclareDeepCloneMethod<ModelCloningPublicSetNullableChild2>.DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPublicSetNullableChild2 DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPublicSetNullableChild2>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPublicSetNullableChild2)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPublicSetNullableChild2>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}