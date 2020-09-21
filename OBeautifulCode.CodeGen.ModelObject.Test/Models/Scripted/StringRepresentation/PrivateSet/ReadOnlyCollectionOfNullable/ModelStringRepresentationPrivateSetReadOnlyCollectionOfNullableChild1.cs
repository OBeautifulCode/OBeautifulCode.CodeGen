﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelStringRepresentationPrivateSetReadOnlyCollectionOfNullableChild1.cs" company="OBeautifulCode">
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
    public partial class ModelStringRepresentationPrivateSetReadOnlyCollectionOfNullableChild1 : ModelStringRepresentationPrivateSetReadOnlyCollectionOfNullableParent, IStringRepresentableViaCodeGen, IDeclareToStringMethod
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelStringRepresentationPrivateSetReadOnlyCollectionOfNullableChild1(
            IReadOnlyCollection<bool?> parentReadOnlyCollectionInterfaceOfNullableBoolProperty,
            IReadOnlyCollection<int?> parentReadOnlyCollectionInterfaceOfNullableIntProperty,
            IReadOnlyCollection<Guid?> parentReadOnlyCollectionInterfaceOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> parentReadOnlyCollectionInterfaceOfNullableDateTimeProperty,
            IReadOnlyCollection<CustomEnum?> parentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty,
            IReadOnlyCollection<CustomFlagsEnum?> parentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty,
            IReadOnlyCollection<bool?> child1ReadOnlyCollectionInterfaceOfNullableBoolProperty,
            IReadOnlyCollection<int?> child1ReadOnlyCollectionInterfaceOfNullableIntProperty,
            IReadOnlyCollection<Guid?> child1ReadOnlyCollectionInterfaceOfNullableGuidProperty,
            IReadOnlyCollection<DateTime?> child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty,
            IReadOnlyCollection<CustomEnum?> child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty,
            IReadOnlyCollection<CustomFlagsEnum?> child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty)
            : base(parentReadOnlyCollectionInterfaceOfNullableBoolProperty, parentReadOnlyCollectionInterfaceOfNullableIntProperty, parentReadOnlyCollectionInterfaceOfNullableGuidProperty, parentReadOnlyCollectionInterfaceOfNullableDateTimeProperty, parentReadOnlyCollectionInterfaceOfNullableCustomEnumProperty, parentReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty)
        {
            new { child1ReadOnlyCollectionInterfaceOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionInterfaceOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionInterfaceOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();

            this.Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty = child1ReadOnlyCollectionInterfaceOfNullableBoolProperty;
            this.Child1ReadOnlyCollectionInterfaceOfNullableIntProperty = child1ReadOnlyCollectionInterfaceOfNullableIntProperty;
            this.Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty = child1ReadOnlyCollectionInterfaceOfNullableGuidProperty;
            this.Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty = child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty;
            this.Child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty = child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty;
            this.Child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty = child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<bool?> Child1ReadOnlyCollectionInterfaceOfNullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<int?> Child1ReadOnlyCollectionInterfaceOfNullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<Guid?> Child1ReadOnlyCollectionInterfaceOfNullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<DateTime?> Child1ReadOnlyCollectionInterfaceOfNullableDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomEnum?> Child1ReadOnlyCollectionInterfaceOfNullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomFlagsEnum?> Child1ReadOnlyCollectionInterfaceOfNullableCustomFlagsEnumProperty { get; private set; }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = "not being tested";

            return result;
        }
    }
}