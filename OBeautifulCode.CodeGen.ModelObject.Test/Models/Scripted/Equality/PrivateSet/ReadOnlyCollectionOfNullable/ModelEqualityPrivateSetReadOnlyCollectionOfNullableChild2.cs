﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetReadOnlyCollectionOfNullableChild2.cs" company="OBeautifulCode">
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
    public partial class ModelEqualityPrivateSetReadOnlyCollectionOfNullableChild2 : ModelEqualityPrivateSetReadOnlyCollectionOfNullableParent, IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPrivateSetReadOnlyCollectionOfNullableChild2>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelEqualityPrivateSetReadOnlyCollectionOfNullableChild2(
            IReadOnlyCollection<bool?> parentReadOnlyCollectionInterfaceOfNullableBoolProperty,
            IReadOnlyCollection<int?> parentReadOnlyCollectionInterfaceOfNullableIntProperty,
            IReadOnlyCollection<Guid?> parentReadOnlyCollectionInterfaceOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> parentReadOnlyCollectionInterfaceOfNullableDateTimeProperty,
            IReadOnlyCollection<CustomEnum?> parentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty,
            IReadOnlyCollection<CustomFlagsEnum?> parentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty,
            IReadOnlyCollection<bool?> child2ReadOnlyCollectionInterfaceOfNullableBoolProperty,
            IReadOnlyCollection<int?> child2ReadOnlyCollectionInterfaceOfNullableIntProperty,
            IReadOnlyCollection<Guid?> child2ReadOnlyCollectionInterfaceOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> child2ReadOnlyCollectionInterfaceOfNullableDateTimeProperty,
            IReadOnlyCollection<CustomEnum?> child2ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty,
            IReadOnlyCollection<CustomFlagsEnum?> child2ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty)
            : base(parentReadOnlyCollectionInterfaceOfNullableBoolProperty, parentReadOnlyCollectionInterfaceOfNullableIntProperty, parentReadOnlyCollectionInterfaceOfNullableGuidProperty, parentReadOnlyCollectionInterfaceOfNullableDateTimeProperty, parentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty, parentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty)
        {
            new { child2ReadOnlyCollectionInterfaceOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ReadOnlyCollectionInterfaceOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ReadOnlyCollectionInterfaceOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ReadOnlyCollectionInterfaceOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();

            this.Child2ReadOnlyCollectionInterfaceOfNullableBoolProperty = child2ReadOnlyCollectionInterfaceOfNullableBoolProperty;
            this.Child2ReadOnlyCollectionInterfaceOfNullableIntProperty = child2ReadOnlyCollectionInterfaceOfNullableIntProperty;
            this.Child2ReadOnlyCollectionInterfaceOfNullableGuidProperty = child2ReadOnlyCollectionInterfaceOfNullableGuidProperty;
            this.Child2ReadOnlyCollectionInterfaceOfNullableDateTimeProperty = child2ReadOnlyCollectionInterfaceOfNullableDateTimeProperty;
            this.Child2ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty = child2ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty;
            this.Child2ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty = child2ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<bool?> Child2ReadOnlyCollectionInterfaceOfNullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<int?> Child2ReadOnlyCollectionInterfaceOfNullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<Guid?> Child2ReadOnlyCollectionInterfaceOfNullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<DateTime?> Child2ReadOnlyCollectionInterfaceOfNullableDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomEnum?> Child2ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomFlagsEnum?> Child2ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPrivateSetReadOnlyCollectionOfNullableChild2 other)
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
    }
}