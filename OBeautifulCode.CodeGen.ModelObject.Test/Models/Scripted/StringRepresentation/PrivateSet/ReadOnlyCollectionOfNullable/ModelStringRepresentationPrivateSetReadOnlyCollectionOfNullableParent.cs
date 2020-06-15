﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelStringRepresentationPrivateSetReadOnlyCollectionOfNullableParent.cs" company="OBeautifulCode">
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

    public abstract partial class ModelStringRepresentationPrivateSetReadOnlyCollectionOfNullableParent : IStringRepresentableViaCodeGen
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        protected ModelStringRepresentationPrivateSetReadOnlyCollectionOfNullableParent(
            IReadOnlyCollection<bool?> parentReadOnlyCollectionInterfaceOfNullableBoolProperty,
            IReadOnlyCollection<int?> parentReadOnlyCollectionInterfaceOfNullableIntProperty,
            IReadOnlyCollection<Guid?> parentReadOnlyCollectionInterfaceOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> parentReadOnlyCollectionInterfaceOfNullableDateTimeProperty,
            IReadOnlyCollection<CustomEnum?> parentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty,
            IReadOnlyCollection<CustomFlagsEnum?> parentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty)
        {
            new { parentReadOnlyCollectionInterfaceOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { parentReadOnlyCollectionInterfaceOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { parentReadOnlyCollectionInterfaceOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { parentReadOnlyCollectionInterfaceOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { parentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { parentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();

            this.ParentReadOnlyCollectionInterfaceOfNullableBoolProperty = parentReadOnlyCollectionInterfaceOfNullableBoolProperty;
            this.ParentReadOnlyCollectionInterfaceOfNullableIntProperty = parentReadOnlyCollectionInterfaceOfNullableIntProperty;
            this.ParentReadOnlyCollectionInterfaceOfNullableGuidProperty = parentReadOnlyCollectionInterfaceOfNullableGuidProperty;
            this.ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty = parentReadOnlyCollectionInterfaceOfNullableDateTimeProperty;
            this.ParentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty = parentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty;
            this.ParentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty = parentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<bool?> ParentReadOnlyCollectionInterfaceOfNullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<int?> ParentReadOnlyCollectionInterfaceOfNullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<Guid?> ParentReadOnlyCollectionInterfaceOfNullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<DateTime?> ParentReadOnlyCollectionInterfaceOfNullableDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomEnum?> ParentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomFlagsEnum?> ParentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty { get; private set; }
    }
}