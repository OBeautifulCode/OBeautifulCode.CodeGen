﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPrivateSetReadOnlyDictionaryOfNullable.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPrivateSetReadOnlyDictionaryOfNullable : IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPrivateSetReadOnlyDictionaryOfNullable>, IEquatable<ModelCloningPrivateSetReadOnlyDictionaryOfNullable>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelCloningPrivateSetReadOnlyDictionaryOfNullable(
            IReadOnlyDictionary<bool?, bool?> readOnlyDictionaryInterfaceOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> readOnlyDictionaryInterfaceOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> readOnlyDictionaryInterfaceOfNullableGuidProperty,
            IReadOnlyDictionary<CustomEnum?, CustomEnum?> readOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> readOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)
        {
            new { readOnlyDictionaryInterfaceOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfNullableCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();

            this.ReadOnlyDictionaryInterfaceOfNullableBoolProperty = readOnlyDictionaryInterfaceOfNullableBoolProperty;
            this.ReadOnlyDictionaryInterfaceOfNullableIntProperty = readOnlyDictionaryInterfaceOfNullableIntProperty;
            this.ReadOnlyDictionaryInterfaceOfNullableGuidProperty = readOnlyDictionaryInterfaceOfNullableGuidProperty;
            this.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty = readOnlyDictionaryInterfaceOfNullableCustomEnumProperty;
            this.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty = readOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<bool?, bool?> ReadOnlyDictionaryInterfaceOfNullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<int?, int?> ReadOnlyDictionaryInterfaceOfNullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<Guid?, Guid?> ReadOnlyDictionaryInterfaceOfNullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomEnum?, CustomEnum?> ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPrivateSetReadOnlyDictionaryOfNullable other)
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
                this.ReadOnlyDictionaryInterfaceOfNullableBoolProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfNullableBoolProperty) &&
                this.ReadOnlyDictionaryInterfaceOfNullableIntProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfNullableIntProperty) &&
                this.ReadOnlyDictionaryInterfaceOfNullableGuidProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfNullableGuidProperty) &&
                this.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty) &&
                this.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty);

            return result;
        }

        /// <inheritdoc />
        public ModelCloningPrivateSetReadOnlyDictionaryOfNullable DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPrivateSetReadOnlyDictionaryOfNullable DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPrivateSetReadOnlyDictionaryOfNullable>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPrivateSetReadOnlyDictionaryOfNullable)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPrivateSetReadOnlyDictionaryOfNullable>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}