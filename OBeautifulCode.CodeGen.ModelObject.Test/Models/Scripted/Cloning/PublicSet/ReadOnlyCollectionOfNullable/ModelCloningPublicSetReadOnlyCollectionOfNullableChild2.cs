﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPublicSetReadOnlyCollectionOfNullableChild2.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPublicSetReadOnlyCollectionOfNullableChild2 : ModelCloningPublicSetReadOnlyCollectionOfNullableParent, IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPublicSetReadOnlyCollectionOfNullableChild2>, IEquatable<ModelCloningPublicSetReadOnlyCollectionOfNullableChild2>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<bool?> Child2ReadOnlyCollectionInterfaceOfNullableBoolProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<int?> Child2ReadOnlyCollectionInterfaceOfNullableIntProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<Guid?> Child2ReadOnlyCollectionInterfaceOfNullableGuidProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<DateTime?> Child2ReadOnlyCollectionInterfaceOfNullableDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomEnum?> Child2ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomFlagsEnum?> Child2ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPublicSetReadOnlyCollectionOfNullableChild2 other)
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
                this.Child2ReadOnlyCollectionInterfaceOfNullableBoolProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfNullableBoolProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfNullableIntProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfNullableIntProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfNullableGuidProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfNullableGuidProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfNullableDateTimeProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfNullableDateTimeProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(ModelCloningPublicSetReadOnlyCollectionOfNullableParent other)
        {
            var result = this.Equals((ModelCloningPublicSetReadOnlyCollectionOfNullableChild2)other);

            return result;
        }

        /// <inheritdoc />
        ModelCloningPublicSetReadOnlyCollectionOfNullableChild2 IDeclareDeepCloneMethod<ModelCloningPublicSetReadOnlyCollectionOfNullableChild2>.DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPublicSetReadOnlyCollectionOfNullableChild2 DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPublicSetReadOnlyCollectionOfNullableChild2>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPublicSetReadOnlyCollectionOfNullableChild2)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPublicSetReadOnlyCollectionOfNullableChild2>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}