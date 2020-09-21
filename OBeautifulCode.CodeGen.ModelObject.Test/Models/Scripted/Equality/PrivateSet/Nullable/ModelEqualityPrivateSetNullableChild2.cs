﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetNullableChild2.cs" company="OBeautifulCode">
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
    [SuppressMessage("Microsoft.Usage", "CA2218: OverrideGetHashCodeOnOverridingEquals")]
    public partial class ModelEqualityPrivateSetNullableChild2 : ModelEqualityPrivateSetNullableParent, IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPrivateSetNullableChild2>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelEqualityPrivateSetNullableChild2(
            bool? parentNullableBoolProperty,
            int? parentNullableIntProperty,
            Guid? parentNullableGuidProperty,
            DateTime? parentNullableDateTimeProperty,
            CustomEnum? parentNullableCustomEnumProperty,
            CustomFlagsEnum? parentNullableCustomFlagsEnumProperty,
            bool? child2NullableBoolProperty,
            int? child2NullableIntProperty,
            Guid? child2NullableGuidProperty,
            DateTime? child2NullableDateTimeProperty,
            CustomEnum? child2NullableCustomEnumProperty,
            CustomFlagsEnum? child2NullableCustomFlagsEnumProperty)
            : base(parentNullableBoolProperty, parentNullableIntProperty, parentNullableGuidProperty, parentNullableDateTimeProperty, parentNullableCustomEnumProperty, parentNullableCustomFlagsEnumProperty)
        {

            this.Child2NullableBoolProperty = child2NullableBoolProperty;
            this.Child2NullableIntProperty = child2NullableIntProperty;
            this.Child2NullableGuidProperty = child2NullableGuidProperty;
            this.Child2NullableDateTimeProperty = child2NullableDateTimeProperty;
            this.Child2NullableCustomEnumProperty = child2NullableCustomEnumProperty;
            this.Child2NullableCustomFlagsEnumProperty = child2NullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public bool? Child2NullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int? Child2NullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Guid? Child2NullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public DateTime? Child2NullableDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomEnum? Child2NullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomFlagsEnum? Child2NullableCustomFlagsEnumProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPrivateSetNullableChild2 other)
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
    }
}