﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetReadOnlyCollectionChild1.cs" company="OBeautifulCode">
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
    public partial class ModelEqualityPublicSetReadOnlyCollectionChild1 : ModelEqualityPublicSetReadOnlyCollectionParent, IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPublicSetReadOnlyCollectionChild1>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<bool> Child1ReadOnlyCollectionInterfaceOfBoolProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<int> Child1ReadOnlyCollectionInterfaceOfIntProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<string> Child1ReadOnlyCollectionInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<Guid> Child1ReadOnlyCollectionInterfaceOfGuidProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<DateTime> Child1ReadOnlyCollectionInterfaceOfDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomEnum> Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomFlagsEnum> Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomClass> Child1ReadOnlyCollectionInterfaceOfCustomClassProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomBaseClass> Child1ReadOnlyCollectionInterfaceOfCustomBaseClassProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomGenericClass<CustomClass>> Child1ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPublicSetReadOnlyCollectionChild1 other)
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
                this.Child1ReadOnlyCollectionInterfaceOfBoolProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfBoolProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfIntProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfIntProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfStringProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfStringProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfGuidProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfGuidProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfCustomClassProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfCustomClassProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfCustomBaseClassProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfCustomBaseClassProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty);

            return result;
        }
    }
}