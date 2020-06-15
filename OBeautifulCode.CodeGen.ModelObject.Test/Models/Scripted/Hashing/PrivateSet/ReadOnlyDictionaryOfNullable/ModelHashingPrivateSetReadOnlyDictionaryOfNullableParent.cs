﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetReadOnlyDictionaryOfNullableParent.cs" company="OBeautifulCode">
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
    public abstract partial class ModelHashingPrivateSetReadOnlyDictionaryOfNullableParent : IHashableViaCodeGen
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        protected ModelHashingPrivateSetReadOnlyDictionaryOfNullableParent(
            IReadOnlyDictionary<bool?, bool?> parentReadOnlyDictionaryInterfaceOfNullableBoolProperty,
            IReadOnlyDictionary<int?, int?> parentReadOnlyDictionaryInterfaceOfNullableIntProperty,
            IReadOnlyDictionary<Guid?, Guid?> parentReadOnlyDictionaryInterfaceOfNullableGuidProperty,
            IReadOnlyDictionary<CustomEnum?, CustomEnum?> parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)
        {
            new { parentReadOnlyDictionaryInterfaceOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { parentReadOnlyDictionaryInterfaceOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { parentReadOnlyDictionaryInterfaceOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();

            this.ParentReadOnlyDictionaryInterfaceOfNullableBoolProperty = parentReadOnlyDictionaryInterfaceOfNullableBoolProperty;
            this.ParentReadOnlyDictionaryInterfaceOfNullableIntProperty = parentReadOnlyDictionaryInterfaceOfNullableIntProperty;
            this.ParentReadOnlyDictionaryInterfaceOfNullableGuidProperty = parentReadOnlyDictionaryInterfaceOfNullableGuidProperty;
            this.ParentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty = parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty;
            this.ParentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty = parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<bool?, bool?> ParentReadOnlyDictionaryInterfaceOfNullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<int?, int?> ParentReadOnlyDictionaryInterfaceOfNullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<Guid?, Guid?> ParentReadOnlyDictionaryInterfaceOfNullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomEnum?, CustomEnum?> ParentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> ParentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty { get; private set; }
    }
}