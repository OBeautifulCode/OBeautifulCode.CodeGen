﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetReadOnlyDictionaryOfNullableChild1.cs" company="OBeautifulCode">
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

    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    public partial class ModelHashingPrivateSetReadOnlyDictionaryOfNullableChild1 : ModelHashingPrivateSetReadOnlyDictionaryOfNullableParent, IHashableViaCodeGen, IDeclareGetHashCodeMethod
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelHashingPrivateSetReadOnlyDictionaryOfNullableChild1(
            IReadOnlyDictionary<bool?, bool?> parentReadOnlyDictionaryInterfaceOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> parentReadOnlyDictionaryInterfaceOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> parentReadOnlyDictionaryInterfaceOfNullableGuidProperty,
            IReadOnlyDictionary<CustomEnum?, CustomEnum?> parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty,
            IReadOnlyDictionary<bool?, bool?> child1ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> child1ReadOnlyDictionaryInterfaceOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> child1ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
            IReadOnlyDictionary<CustomEnum?, CustomEnum?> child1ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> child1ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)
            : base(parentReadOnlyDictionaryInterfaceOfNullableBoolProperty, parentReadOnlyDictionaryInterfaceOfNullableIntProperty, parentReadOnlyDictionaryInterfaceOfNullableGuidProperty, parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty, parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)
        {
            new { child1ReadOnlyDictionaryInterfaceOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryInterfaceOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryInterfaceOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child1ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();

            this.Child1ReadOnlyDictionaryInterfaceOfNullableBoolProperty = child1ReadOnlyDictionaryInterfaceOfNullableBoolProperty;
            this.Child1ReadOnlyDictionaryInterfaceOfNullableIntProperty = child1ReadOnlyDictionaryInterfaceOfNullableIntProperty;
            this.Child1ReadOnlyDictionaryInterfaceOfNullableGuidProperty = child1ReadOnlyDictionaryInterfaceOfNullableGuidProperty;
            this.Child1ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty = child1ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty;
            this.Child1ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty = child1ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<bool?, bool?> Child1ReadOnlyDictionaryInterfaceOfNullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<int?, int?> Child1ReadOnlyDictionaryInterfaceOfNullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<Guid?, Guid?> Child1ReadOnlyDictionaryInterfaceOfNullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomEnum?, CustomEnum?> Child1ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> Child1ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty { get; private set; }

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
                .Hash(this.ParentReadOnlyDictionaryInterfaceOfNullableBoolProperty)
                .Hash(this.ParentReadOnlyDictionaryInterfaceOfNullableIntProperty)
                .Hash(this.ParentReadOnlyDictionaryInterfaceOfNullableGuidProperty)
                .Hash(this.ParentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty)
                .Hash(this.ParentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)
                .Hash(this.Child1ReadOnlyDictionaryInterfaceOfNullableBoolProperty)
                .Hash(this.Child1ReadOnlyDictionaryInterfaceOfNullableIntProperty)
                .Hash(this.Child1ReadOnlyDictionaryInterfaceOfNullableGuidProperty)
                .Hash(this.Child1ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty)
                .Hash(this.Child1ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)
                .Value;
    }
}