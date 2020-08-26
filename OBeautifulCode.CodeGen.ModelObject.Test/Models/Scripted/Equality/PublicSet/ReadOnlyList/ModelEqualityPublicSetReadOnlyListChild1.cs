﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetReadOnlyListChild1.cs" company="OBeautifulCode">
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
    public partial class ModelEqualityPublicSetReadOnlyListChild1 : ModelEqualityPublicSetReadOnlyListParent, IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPublicSetReadOnlyListChild1>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<bool> Child1ReadOnlyListInterfaceOfBoolProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<int> Child1ReadOnlyListInterfaceOfIntProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<string> Child1ReadOnlyListInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<Guid> Child1ReadOnlyListInterfaceOfGuidProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<DateTime> Child1ReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomEnum> Child1ReadOnlyListInterfaceOfCustomEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomFlagsEnum> Child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomClass> Child1ReadOnlyListInterfaceOfCustomClassProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomBaseClass> Child1ReadOnlyListInterfaceOfCustomBaseClassProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomGenericClass<CustomClass>> Child1ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPublicSetReadOnlyListChild1 other)
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
                this.ParentReadOnlyListInterfaceOfBoolProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfBoolProperty) &&
                this.ParentReadOnlyListInterfaceOfIntProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfIntProperty) &&
                this.ParentReadOnlyListInterfaceOfStringProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfStringProperty) &&
                this.ParentReadOnlyListInterfaceOfGuidProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfGuidProperty) &&
                this.ParentReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ParentReadOnlyListInterfaceOfCustomEnumProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfCustomEnumProperty) &&
                this.ParentReadOnlyListInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfCustomFlagsEnumProperty) &&
                this.ParentReadOnlyListInterfaceOfCustomClassProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfCustomClassProperty) &&
                this.ParentReadOnlyListInterfaceOfCustomBaseClassProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfCustomBaseClassProperty) &&
                this.ParentReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty) &&
                this.Child1ReadOnlyListInterfaceOfBoolProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfBoolProperty) &&
                this.Child1ReadOnlyListInterfaceOfIntProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfIntProperty) &&
                this.Child1ReadOnlyListInterfaceOfStringProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfStringProperty) &&
                this.Child1ReadOnlyListInterfaceOfGuidProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfGuidProperty) &&
                this.Child1ReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfDateTimeProperty) &&
                this.Child1ReadOnlyListInterfaceOfCustomEnumProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfCustomEnumProperty) &&
                this.Child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty) &&
                this.Child1ReadOnlyListInterfaceOfCustomClassProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfCustomClassProperty) &&
                this.Child1ReadOnlyListInterfaceOfCustomBaseClassProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfCustomBaseClassProperty) &&
                this.Child1ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.Child1ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty);

            return result;
        }
    }
}