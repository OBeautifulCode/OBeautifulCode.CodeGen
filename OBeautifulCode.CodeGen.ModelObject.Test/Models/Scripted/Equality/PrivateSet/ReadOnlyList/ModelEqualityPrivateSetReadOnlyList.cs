﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetReadOnlyList.cs" company="OBeautifulCode">
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
    public partial class ModelEqualityPrivateSetReadOnlyList : IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPrivateSetReadOnlyList>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelEqualityPrivateSetReadOnlyList(
            IReadOnlyList<bool> readOnlyListInterfaceOfBoolProperty,
            IReadOnlyList<int> readOnlyListInterfaceOfIntProperty,
            IReadOnlyList<string> readOnlyListInterfaceOfStringProperty,
            IReadOnlyList<Guid> readOnlyListInterfaceOfGuidProperty,
            IReadOnlyList<DateTime> readOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyList<CustomEnum> readOnlyListInterfaceOfCustomEnumProperty,
            IReadOnlyList<CustomFlagsEnum> readOnlyListInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyList<CustomClass> readOnlyListInterfaceOfCustomClassProperty,
            IReadOnlyList<CustomBaseClass> readOnlyListInterfaceOfCustomBaseClassProperty)
        {
            new { readOnlyListInterfaceOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListInterfaceOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyListInterfaceOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListInterfaceOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListInterfaceOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { readOnlyListInterfaceOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { readOnlyListInterfaceOfCustomBaseClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.ReadOnlyListInterfaceOfBoolProperty = readOnlyListInterfaceOfBoolProperty;
            this.ReadOnlyListInterfaceOfIntProperty = readOnlyListInterfaceOfIntProperty;
            this.ReadOnlyListInterfaceOfStringProperty = readOnlyListInterfaceOfStringProperty;
            this.ReadOnlyListInterfaceOfGuidProperty = readOnlyListInterfaceOfGuidProperty;
            this.ReadOnlyListInterfaceOfDateTimeProperty = readOnlyListInterfaceOfDateTimeProperty;
            this.ReadOnlyListInterfaceOfCustomEnumProperty = readOnlyListInterfaceOfCustomEnumProperty;
            this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty = readOnlyListInterfaceOfCustomFlagsEnumProperty;
            this.ReadOnlyListInterfaceOfCustomClassProperty = readOnlyListInterfaceOfCustomClassProperty;
            this.ReadOnlyListInterfaceOfCustomBaseClassProperty = readOnlyListInterfaceOfCustomBaseClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<bool> ReadOnlyListInterfaceOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<int> ReadOnlyListInterfaceOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<string> ReadOnlyListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<Guid> ReadOnlyListInterfaceOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<DateTime> ReadOnlyListInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomEnum> ReadOnlyListInterfaceOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomFlagsEnum> ReadOnlyListInterfaceOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomClass> ReadOnlyListInterfaceOfCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomBaseClass> ReadOnlyListInterfaceOfCustomBaseClassProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPrivateSetReadOnlyList other)
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
                this.ReadOnlyListInterfaceOfBoolProperty.IsEqualTo(other.ReadOnlyListInterfaceOfBoolProperty) &&
                this.ReadOnlyListInterfaceOfIntProperty.IsEqualTo(other.ReadOnlyListInterfaceOfIntProperty) &&
                this.ReadOnlyListInterfaceOfStringProperty.IsEqualTo(other.ReadOnlyListInterfaceOfStringProperty) &&
                this.ReadOnlyListInterfaceOfGuidProperty.IsEqualTo(other.ReadOnlyListInterfaceOfGuidProperty) &&
                this.ReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ReadOnlyListInterfaceOfCustomEnumProperty.IsEqualTo(other.ReadOnlyListInterfaceOfCustomEnumProperty) &&
                this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.ReadOnlyListInterfaceOfCustomFlagsEnumProperty) &&
                this.ReadOnlyListInterfaceOfCustomClassProperty.IsEqualTo(other.ReadOnlyListInterfaceOfCustomClassProperty) &&
                this.ReadOnlyListInterfaceOfCustomBaseClassProperty.IsEqualTo(other.ReadOnlyListInterfaceOfCustomBaseClassProperty);

            return result;
        }
    }
}