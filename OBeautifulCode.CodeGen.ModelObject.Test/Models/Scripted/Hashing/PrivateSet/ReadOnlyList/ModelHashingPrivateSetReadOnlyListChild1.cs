﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetReadOnlyListChild1.cs" company="OBeautifulCode">
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

    public partial class ModelHashingPrivateSetReadOnlyListChild1 : ModelHashingPrivateSetReadOnlyListParent, IHashableViaCodeGen, IDeclareGetHashCodeMethod
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelHashingPrivateSetReadOnlyListChild1(
            IReadOnlyList<bool> parentReadOnlyListInterfaceOfBoolProperty,
            IReadOnlyList<int> parentReadOnlyListInterfaceOfIntProperty,
            IReadOnlyList<string> parentReadOnlyListInterfaceOfStringProperty,
            IReadOnlyList<Guid> parentReadOnlyListInterfaceOfGuidProperty,
            IReadOnlyList<DateTime> parentReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyList<CustomEnum> parentReadOnlyListInterfaceOfCustomEnumProperty,
            IReadOnlyList<CustomFlagsEnum> parentReadOnlyListInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyList<CustomClass> parentReadOnlyListInterfaceOfCustomClassProperty,
            IReadOnlyList<bool> child1ReadOnlyListInterfaceOfBoolProperty,
            IReadOnlyList<int> child1ReadOnlyListInterfaceOfIntProperty,
            IReadOnlyList<string> child1ReadOnlyListInterfaceOfStringProperty,
            IReadOnlyList<Guid> child1ReadOnlyListInterfaceOfGuidProperty,
            IReadOnlyList<DateTime> child1ReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyList<CustomEnum> child1ReadOnlyListInterfaceOfCustomEnumProperty,
            IReadOnlyList<CustomFlagsEnum> child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyList<CustomClass> child1ReadOnlyListInterfaceOfCustomClassProperty)
            : base(parentReadOnlyListInterfaceOfBoolProperty, parentReadOnlyListInterfaceOfIntProperty, parentReadOnlyListInterfaceOfStringProperty, parentReadOnlyListInterfaceOfGuidProperty, parentReadOnlyListInterfaceOfDateTimeProperty, parentReadOnlyListInterfaceOfCustomEnumProperty, parentReadOnlyListInterfaceOfCustomFlagsEnumProperty, parentReadOnlyListInterfaceOfCustomClassProperty)
        {
            new { child1ReadOnlyListInterfaceOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyListInterfaceOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.Child1ReadOnlyListInterfaceOfBoolProperty = child1ReadOnlyListInterfaceOfBoolProperty;
            this.Child1ReadOnlyListInterfaceOfIntProperty = child1ReadOnlyListInterfaceOfIntProperty;
            this.Child1ReadOnlyListInterfaceOfStringProperty = child1ReadOnlyListInterfaceOfStringProperty;
            this.Child1ReadOnlyListInterfaceOfGuidProperty = child1ReadOnlyListInterfaceOfGuidProperty;
            this.Child1ReadOnlyListInterfaceOfDateTimeProperty = child1ReadOnlyListInterfaceOfDateTimeProperty;
            this.Child1ReadOnlyListInterfaceOfCustomEnumProperty = child1ReadOnlyListInterfaceOfCustomEnumProperty;
            this.Child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty = child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty;
            this.Child1ReadOnlyListInterfaceOfCustomClassProperty = child1ReadOnlyListInterfaceOfCustomClassProperty;
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

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
                .Hash(this.ParentReadOnlyListInterfaceOfBoolProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfIntProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfStringProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfGuidProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfCustomEnumProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfCustomFlagsEnumProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfCustomClassProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfBoolProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfIntProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfStringProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfGuidProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfDateTimeProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfCustomEnumProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfCustomFlagsEnumProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfCustomClassProperty)
                .Value;
    }
}