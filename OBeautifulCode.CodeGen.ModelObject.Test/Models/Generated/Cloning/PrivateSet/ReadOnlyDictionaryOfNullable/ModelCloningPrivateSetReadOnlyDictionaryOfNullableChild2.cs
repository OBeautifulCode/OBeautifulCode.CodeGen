﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPrivateSetReadOnlyDictionaryOfNullableChild2.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPrivateSetReadOnlyDictionaryOfNullableChild2 : ModelCloningPrivateSetReadOnlyDictionaryOfNullableParent, IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPrivateSetReadOnlyDictionaryOfNullableChild2>, IEquatable<ModelCloningPrivateSetReadOnlyDictionaryOfNullableChild2>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelCloningPrivateSetReadOnlyDictionaryOfNullableChild2(
            IReadOnlyDictionary<bool?, bool?> parentReadOnlyDictionaryInterfaceOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> parentReadOnlyDictionaryInterfaceOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> parentReadOnlyDictionaryInterfaceOfNullableGuidProperty,
            IReadOnlyDictionary<CustomEnum?, CustomEnum?> parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty,
            IReadOnlyDictionary<bool?, bool?> child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> child2ReadOnlyDictionaryInterfaceOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
            IReadOnlyDictionary<CustomEnum?, CustomEnum?> child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)
            : base(parentReadOnlyDictionaryInterfaceOfNullableBoolProperty, parentReadOnlyDictionaryInterfaceOfNullableIntProperty, parentReadOnlyDictionaryInterfaceOfNullableGuidProperty, parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty, parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)
        {
            new { child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();

            this.Child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty = child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfNullableIntProperty = child2ReadOnlyDictionaryInterfaceOfNullableIntProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty = child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty = child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty = child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<bool?, bool?> Child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<int?, int?> Child2ReadOnlyDictionaryInterfaceOfNullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<Guid?, Guid?> Child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomEnum?, CustomEnum?> Child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> Child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPrivateSetReadOnlyDictionaryOfNullableChild2 other)
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
        public override bool Equals(ModelCloningPrivateSetReadOnlyDictionaryOfNullableParent other)
        {
            var result = this.Equals((ModelCloningPrivateSetReadOnlyDictionaryOfNullableChild2)other);

            return result;
        }

        /// <inheritdoc />
        ModelCloningPrivateSetReadOnlyDictionaryOfNullableChild2 IDeclareDeepCloneMethod<ModelCloningPrivateSetReadOnlyDictionaryOfNullableChild2>.DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPrivateSetReadOnlyDictionaryOfNullableChild2 DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPrivateSetReadOnlyDictionaryOfNullableChild2>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPrivateSetReadOnlyDictionaryOfNullableChild2)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPrivateSetReadOnlyDictionaryOfNullableChild2>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}