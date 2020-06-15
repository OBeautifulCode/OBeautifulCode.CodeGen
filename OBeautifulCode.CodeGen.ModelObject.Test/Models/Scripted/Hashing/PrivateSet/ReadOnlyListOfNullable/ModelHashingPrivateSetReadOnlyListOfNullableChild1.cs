﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetReadOnlyListOfNullableChild1.cs" company="OBeautifulCode">
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

    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    public partial class ModelHashingPrivateSetReadOnlyListOfNullableChild1 : ModelHashingPrivateSetReadOnlyListOfNullableParent, IHashableViaCodeGen, IDeclareGetHashCodeMethod
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelHashingPrivateSetReadOnlyListOfNullableChild1(
            IReadOnlyList<bool?> parentReadOnlyListInterfaceOfNullableBoolProperty,
            IReadOnlyList<int?> parentReadOnlyListInterfaceOfNullableIntProperty,
            IReadOnlyList<Guid?> parentReadOnlyListInterfaceOfNullableGuidProperty,
            IReadOnlyList<DateTime?> parentReadOnlyListInterfaceOfNullableDateTimeProperty,
            IReadOnlyList<CustomEnum?> parentReadOnlyListInterfaceOfNullableCustomEnumProperty,
            IReadOnlyList<CustomFlagsEnum?> parentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
            IReadOnlyList<bool?> child1ReadOnlyListInterfaceOfNullableBoolProperty,
            IReadOnlyList<int?> child1ReadOnlyListInterfaceOfNullableIntProperty,
            IReadOnlyList<Guid?> child1ReadOnlyListInterfaceOfNullableGuidProperty,
            IReadOnlyList<DateTime?> child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
            IReadOnlyList<CustomEnum?> child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
            IReadOnlyList<CustomFlagsEnum?> child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)
            : base(parentReadOnlyListInterfaceOfNullableBoolProperty, parentReadOnlyListInterfaceOfNullableIntProperty, parentReadOnlyListInterfaceOfNullableGuidProperty, parentReadOnlyListInterfaceOfNullableDateTimeProperty, parentReadOnlyListInterfaceOfNullableCustomEnumProperty, parentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)
        {
            new { child1ReadOnlyListInterfaceOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfNullableCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();

            this.Child1ReadOnlyListInterfaceOfNullableBoolProperty = child1ReadOnlyListInterfaceOfNullableBoolProperty;
            this.Child1ReadOnlyListInterfaceOfNullableIntProperty = child1ReadOnlyListInterfaceOfNullableIntProperty;
            this.Child1ReadOnlyListInterfaceOfNullableGuidProperty = child1ReadOnlyListInterfaceOfNullableGuidProperty;
            this.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty = child1ReadOnlyListInterfaceOfNullableDateTimeProperty;
            this.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty = child1ReadOnlyListInterfaceOfNullableCustomEnumProperty;
            this.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<bool?> Child1ReadOnlyListInterfaceOfNullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<int?> Child1ReadOnlyListInterfaceOfNullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<Guid?> Child1ReadOnlyListInterfaceOfNullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<DateTime?> Child1ReadOnlyListInterfaceOfNullableDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomEnum?> Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomFlagsEnum?> Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty { get; private set; }

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
                .Hash(this.ParentReadOnlyListInterfaceOfNullableBoolProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfNullableIntProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfNullableGuidProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfNullableDateTimeProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty)
                .Hash(this.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfNullableBoolProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfNullableIntProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfNullableGuidProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty)
                .Hash(this.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)
                .Value;
    }
}