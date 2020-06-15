﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelStringRepresentationPrivateSetReadOnlyDictionary.cs" company="OBeautifulCode">
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

    public partial class ModelStringRepresentationPrivateSetReadOnlyDictionary : IStringRepresentableViaCodeGen, IDeclareToStringMethod
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelStringRepresentationPrivateSetReadOnlyDictionary(
            IReadOnlyDictionary<bool, bool> readOnlyDictionaryInterfaceOfBoolProperty,
            IReadOnlyDictionary<int, int> readOnlyDictionaryInterfaceOfIntProperty,
            IReadOnlyDictionary<string, string> readOnlyDictionaryInterfaceOfStringProperty,
            IReadOnlyDictionary<Guid, Guid> readOnlyDictionaryInterfaceOfGuidProperty,
            IReadOnlyDictionary<CustomEnum, CustomEnum> readOnlyDictionaryInterfaceOfCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum, CustomFlagsEnum> readOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyDictionary<CustomClass, CustomClass> readOnlyDictionaryInterfaceOfCustomClassProperty)
        {
            new { readOnlyDictionaryInterfaceOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { readOnlyDictionaryInterfaceOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.ReadOnlyDictionaryInterfaceOfBoolProperty = readOnlyDictionaryInterfaceOfBoolProperty;
            this.ReadOnlyDictionaryInterfaceOfIntProperty = readOnlyDictionaryInterfaceOfIntProperty;
            this.ReadOnlyDictionaryInterfaceOfStringProperty = readOnlyDictionaryInterfaceOfStringProperty;
            this.ReadOnlyDictionaryInterfaceOfGuidProperty = readOnlyDictionaryInterfaceOfGuidProperty;
            this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty = readOnlyDictionaryInterfaceOfCustomEnumProperty;
            this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = readOnlyDictionaryInterfaceOfCustomFlagsEnumProperty;
            this.ReadOnlyDictionaryInterfaceOfCustomClassProperty = readOnlyDictionaryInterfaceOfCustomClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<bool, bool> ReadOnlyDictionaryInterfaceOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<int, int> ReadOnlyDictionaryInterfaceOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, string> ReadOnlyDictionaryInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<Guid, Guid> ReadOnlyDictionaryInterfaceOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomEnum, CustomEnum> ReadOnlyDictionaryInterfaceOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomFlagsEnum, CustomFlagsEnum> ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomClass, CustomClass> ReadOnlyDictionaryInterfaceOfCustomClassProperty { get; private set; }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = "not being tested";

            return result;
        }
    }
}