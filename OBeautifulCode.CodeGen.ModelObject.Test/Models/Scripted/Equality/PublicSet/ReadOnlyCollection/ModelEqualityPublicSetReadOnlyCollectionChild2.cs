﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetReadOnlyCollectionChild2.cs" company="OBeautifulCode">
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
    public partial class ModelEqualityPublicSetReadOnlyCollectionChild2 : ModelEqualityPublicSetReadOnlyCollectionParent, IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPublicSetReadOnlyCollectionChild2>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<bool> Child2ReadOnlyCollectionInterfaceOfBoolProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<int> Child2ReadOnlyCollectionInterfaceOfIntProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<string> Child2ReadOnlyCollectionInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<Guid> Child2ReadOnlyCollectionInterfaceOfGuidProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<DateTime> Child2ReadOnlyCollectionInterfaceOfDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomEnum> Child2ReadOnlyCollectionInterfaceOfCustomEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomFlagsEnum> Child2ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomClass> Child2ReadOnlyCollectionInterfaceOfCustomClassProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomBaseClass> Child2ReadOnlyCollectionInterfaceOfCustomBaseClassProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomGenericClass<CustomClass>> Child2ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPublicSetReadOnlyCollectionChild2 other)
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
                this.ParentReadOnlyCollectionInterfaceOfBoolProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfBoolProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfIntProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfIntProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfStringProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfStringProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfGuidProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfGuidProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfDateTimeProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfDateTimeProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfCustomClassProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfCustomClassProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfBoolProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfBoolProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfIntProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfIntProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfStringProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfStringProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfGuidProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfGuidProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfDateTimeProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfDateTimeProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfCustomEnumProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfCustomEnumProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfCustomClassProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfCustomClassProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfCustomBaseClassProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfCustomBaseClassProperty) &&
                this.Child2ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.Child2ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty);

            return result;
        }
    }
}