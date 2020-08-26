﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetReadOnlyListChild1.cs" company="OBeautifulCode">
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
    public partial class ModelEqualityPrivateSetReadOnlyListChild1 : ModelEqualityPrivateSetReadOnlyListParent, IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPrivateSetReadOnlyListChild1>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelEqualityPrivateSetReadOnlyListChild1(
            IReadOnlyList<bool> parentReadOnlyListInterfaceOfBoolProperty,
            IReadOnlyList<int> parentReadOnlyListInterfaceOfIntProperty,
            IReadOnlyList<string> parentReadOnlyListInterfaceOfStringProperty,
            IReadOnlyList<Guid> parentReadOnlyListInterfaceOfGuidProperty,
            IReadOnlyList<DateTime> parentReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyList<CustomEnum> parentReadOnlyListInterfaceOfCustomEnumProperty,
            IReadOnlyList<CustomFlagsEnum> parentReadOnlyListInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyList<CustomClass> parentReadOnlyListInterfaceOfCustomClassProperty,
            IReadOnlyList<CustomBaseClass> parentReadOnlyListInterfaceOfCustomBaseClassProperty,
            IReadOnlyList<CustomGenericClass<CustomClass>> parentReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
            IReadOnlyList<bool> child1ReadOnlyListInterfaceOfBoolProperty,
            IReadOnlyList<int> child1ReadOnlyListInterfaceOfIntProperty,
            IReadOnlyList<string> child1ReadOnlyListInterfaceOfStringProperty,
            IReadOnlyList<Guid> child1ReadOnlyListInterfaceOfGuidProperty,
            IReadOnlyList<DateTime> child1ReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyList<CustomEnum> child1ReadOnlyListInterfaceOfCustomEnumProperty,
            IReadOnlyList<CustomFlagsEnum> child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyList<CustomClass> child1ReadOnlyListInterfaceOfCustomClassProperty,
            IReadOnlyList<CustomBaseClass> child1ReadOnlyListInterfaceOfCustomBaseClassProperty,
            IReadOnlyList<CustomGenericClass<CustomClass>> child1ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty)
            : base(parentReadOnlyListInterfaceOfBoolProperty, parentReadOnlyListInterfaceOfIntProperty, parentReadOnlyListInterfaceOfStringProperty, parentReadOnlyListInterfaceOfGuidProperty, parentReadOnlyListInterfaceOfDateTimeProperty, parentReadOnlyListInterfaceOfCustomEnumProperty, parentReadOnlyListInterfaceOfCustomFlagsEnumProperty, parentReadOnlyListInterfaceOfCustomClassProperty, parentReadOnlyListInterfaceOfCustomBaseClassProperty, parentReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty)
        {
            new { child1ReadOnlyListInterfaceOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyListInterfaceOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyListInterfaceOfCustomBaseClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.Child1ReadOnlyListInterfaceOfBoolProperty = child1ReadOnlyListInterfaceOfBoolProperty;
            this.Child1ReadOnlyListInterfaceOfIntProperty = child1ReadOnlyListInterfaceOfIntProperty;
            this.Child1ReadOnlyListInterfaceOfStringProperty = child1ReadOnlyListInterfaceOfStringProperty;
            this.Child1ReadOnlyListInterfaceOfGuidProperty = child1ReadOnlyListInterfaceOfGuidProperty;
            this.Child1ReadOnlyListInterfaceOfDateTimeProperty = child1ReadOnlyListInterfaceOfDateTimeProperty;
            this.Child1ReadOnlyListInterfaceOfCustomEnumProperty = child1ReadOnlyListInterfaceOfCustomEnumProperty;
            this.Child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty = child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty;
            this.Child1ReadOnlyListInterfaceOfCustomClassProperty = child1ReadOnlyListInterfaceOfCustomClassProperty;
            this.Child1ReadOnlyListInterfaceOfCustomBaseClassProperty = child1ReadOnlyListInterfaceOfCustomBaseClassProperty;
            this.Child1ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = child1ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<bool> Child1ReadOnlyListInterfaceOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<int> Child1ReadOnlyListInterfaceOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<string> Child1ReadOnlyListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<Guid> Child1ReadOnlyListInterfaceOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<DateTime> Child1ReadOnlyListInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomEnum> Child1ReadOnlyListInterfaceOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomFlagsEnum> Child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomClass> Child1ReadOnlyListInterfaceOfCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomBaseClass> Child1ReadOnlyListInterfaceOfCustomBaseClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomGenericClass<CustomClass>> Child1ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPrivateSetReadOnlyListChild1 other)
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