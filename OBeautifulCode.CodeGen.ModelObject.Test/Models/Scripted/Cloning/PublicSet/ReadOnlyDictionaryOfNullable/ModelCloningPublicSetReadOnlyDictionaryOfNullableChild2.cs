﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPublicSetReadOnlyDictionaryOfNullableChild2.cs" company="OBeautifulCode">
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

#pragma warning disable CS0659
#pragma warning disable CS0661
    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    public partial class ModelCloningPublicSetReadOnlyDictionaryOfNullableChild2 : ModelCloningPublicSetReadOnlyDictionaryOfNullableParent, IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPublicSetReadOnlyDictionaryOfNullableChild2>, IEquatable<ModelCloningPublicSetReadOnlyDictionaryOfNullableChild2>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<bool?, bool?> Child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<int?, int?> Child2ReadOnlyDictionaryInterfaceOfNullableIntProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<Guid?, Guid?> Child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomEnum?, CustomEnum?> Child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> Child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPublicSetReadOnlyDictionaryOfNullableChild2 other)
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
                this.ParentReadOnlyDictionaryInterfaceOfNullableBoolProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfNullableBoolProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfNullableIntProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfNullableIntProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfNullableGuidProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfNullableGuidProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfNullableIntProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfNullableIntProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(ModelCloningPublicSetReadOnlyDictionaryOfNullableParent other)
        {
            var result = this.Equals((ModelCloningPublicSetReadOnlyDictionaryOfNullableChild2)other);

            return result;
        }

        /// <inheritdoc />
        ModelCloningPublicSetReadOnlyDictionaryOfNullableChild2 IDeclareDeepCloneMethod<ModelCloningPublicSetReadOnlyDictionaryOfNullableChild2>.DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPublicSetReadOnlyDictionaryOfNullableChild2 DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPublicSetReadOnlyDictionaryOfNullableChild2>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPublicSetReadOnlyDictionaryOfNullableChild2)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPublicSetReadOnlyDictionaryOfNullableChild2>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}