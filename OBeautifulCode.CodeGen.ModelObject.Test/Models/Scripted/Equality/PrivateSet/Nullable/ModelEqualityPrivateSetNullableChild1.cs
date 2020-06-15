﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetNullableChild1.cs" company="OBeautifulCode">
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
    [SuppressMessage("Microsoft.Usage", "CA2218: OverrideGetHashCodeOnOverridingEquals")]
    public partial class ModelEqualityPrivateSetNullableChild1 : ModelEqualityPrivateSetNullableParent, IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPrivateSetNullableChild1>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelEqualityPrivateSetNullableChild1(
            bool? parentNullableBoolProperty,
            int? parentNullableIntProperty,
            Guid? parentNullableGuidProperty,
            DateTime? parentNullableDateTimeProperty,
            CustomEnum? parentNullableCustomEnumProperty,
            CustomFlagsEnum? parentNullableCustomFlagsEnumProperty,
            bool? child1NullableBoolProperty,
            int? child1NullableIntProperty,
            Guid? child1NullableGuidProperty,
            DateTime? child1NullableDateTimeProperty,
            CustomEnum? child1NullableCustomEnumProperty,
            CustomFlagsEnum? child1NullableCustomFlagsEnumProperty)
            : base(parentNullableBoolProperty, parentNullableIntProperty, parentNullableGuidProperty, parentNullableDateTimeProperty, parentNullableCustomEnumProperty, parentNullableCustomFlagsEnumProperty)
        {

            this.Child1NullableBoolProperty = child1NullableBoolProperty;
            this.Child1NullableIntProperty = child1NullableIntProperty;
            this.Child1NullableGuidProperty = child1NullableGuidProperty;
            this.Child1NullableDateTimeProperty = child1NullableDateTimeProperty;
            this.Child1NullableCustomEnumProperty = child1NullableCustomEnumProperty;
            this.Child1NullableCustomFlagsEnumProperty = child1NullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public bool? Child1NullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int? Child1NullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Guid? Child1NullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public DateTime? Child1NullableDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomEnum? Child1NullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomFlagsEnum? Child1NullableCustomFlagsEnumProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPrivateSetNullableChild1 other)
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
                this.Child1NullableBoolProperty.IsEqualTo(other.Child1NullableBoolProperty) &&
                this.Child1NullableIntProperty.IsEqualTo(other.Child1NullableIntProperty) &&
                this.Child1NullableGuidProperty.IsEqualTo(other.Child1NullableGuidProperty) &&
                this.Child1NullableDateTimeProperty.IsEqualTo(other.Child1NullableDateTimeProperty) &&
                this.Child1NullableCustomEnumProperty.IsEqualTo(other.Child1NullableCustomEnumProperty) &&
                this.Child1NullableCustomFlagsEnumProperty.IsEqualTo(other.Child1NullableCustomFlagsEnumProperty);

            return result;
        }
    }
}