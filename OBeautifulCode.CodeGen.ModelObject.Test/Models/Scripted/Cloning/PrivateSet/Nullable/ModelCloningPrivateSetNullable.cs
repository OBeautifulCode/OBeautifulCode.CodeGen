﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPrivateSetNullable.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPrivateSetNullable : IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPrivateSetNullable>, IEquatable<ModelCloningPrivateSetNullable>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelCloningPrivateSetNullable(
            bool? nullableBoolProperty,
            int? nullableIntProperty,
            Guid? nullableGuidProperty,
            DateTime? nullableDateTimeProperty,
            CustomEnum? nullableCustomEnumProperty,
            CustomFlagsEnum? nullableCustomFlagsEnumProperty)
        {

            this.NullableBoolProperty = nullableBoolProperty;
            this.NullableIntProperty = nullableIntProperty;
            this.NullableGuidProperty = nullableGuidProperty;
            this.NullableDateTimeProperty = nullableDateTimeProperty;
            this.NullableCustomEnumProperty = nullableCustomEnumProperty;
            this.NullableCustomFlagsEnumProperty = nullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public bool? NullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int? NullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Guid? NullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public DateTime? NullableDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomEnum? NullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomFlagsEnum? NullableCustomFlagsEnumProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPrivateSetNullable other)
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
                this.NullableBoolProperty.IsEqualTo(other.NullableBoolProperty) &&
                this.NullableIntProperty.IsEqualTo(other.NullableIntProperty) &&
                this.NullableGuidProperty.IsEqualTo(other.NullableGuidProperty) &&
                this.NullableDateTimeProperty.IsEqualTo(other.NullableDateTimeProperty) &&
                this.NullableCustomEnumProperty.IsEqualTo(other.NullableCustomEnumProperty) &&
                this.NullableCustomFlagsEnumProperty.IsEqualTo(other.NullableCustomFlagsEnumProperty);

            return result;
        }

        /// <inheritdoc />
        public ModelCloningPrivateSetNullable DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPrivateSetNullable DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPrivateSetNullable>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPrivateSetNullable)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPrivateSetNullable>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}