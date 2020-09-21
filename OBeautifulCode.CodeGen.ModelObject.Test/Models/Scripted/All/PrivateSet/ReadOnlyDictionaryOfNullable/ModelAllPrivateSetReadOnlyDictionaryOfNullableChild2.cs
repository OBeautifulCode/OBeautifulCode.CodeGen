﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelAllPrivateSetReadOnlyDictionaryOfNullableChild2.cs" company="OBeautifulCode">
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
    public partial class ModelAllPrivateSetReadOnlyDictionaryOfNullableChild2 : ModelAllPrivateSetReadOnlyDictionaryOfNullableParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelAllPrivateSetReadOnlyDictionaryOfNullableChild2(
            IReadOnlyDictionary<bool?, bool?> parentReadOnlyDictionaryInterfaceOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> parentReadOnlyDictionaryInterfaceOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> parentReadOnlyDictionaryInterfaceOfNullableGuidProperty,
            IReadOnlyDictionary<CustomEnum?, CustomEnum?> parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty,
            IReadOnlyDictionary<bool?, bool?> child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> child2ReadOnlyDictionaryInterfaceOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
            IReadOnlyDictionary<CustomEnum?, CustomEnum?> child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)
            : base(parentReadOnlyDictionaryInterfaceOfNullableBoolProperty, parentReadOnlyDictionaryInterfaceOfNullableIntProperty, parentReadOnlyDictionaryInterfaceOfNullableGuidProperty, parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty, parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)
        {
            new { child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();

            this.Child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty = child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfNullableIntProperty = child2ReadOnlyDictionaryInterfaceOfNullableIntProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty = child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty = child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty = child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<bool?, bool?> Child2ReadOnlyDictionaryInterfaceOfNullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<int?, int?> Child2ReadOnlyDictionaryInterfaceOfNullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<Guid?, Guid?> Child2ReadOnlyDictionaryInterfaceOfNullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomEnum?, CustomEnum?> Child2ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> Child2ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty { get; private set; }
    }
}