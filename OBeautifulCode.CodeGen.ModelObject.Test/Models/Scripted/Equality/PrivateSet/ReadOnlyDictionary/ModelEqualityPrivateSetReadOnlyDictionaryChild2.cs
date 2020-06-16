﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetReadOnlyDictionaryChild2.cs" company="OBeautifulCode">
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
    public partial class ModelEqualityPrivateSetReadOnlyDictionaryChild2 : ModelEqualityPrivateSetReadOnlyDictionaryParent, IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPrivateSetReadOnlyDictionaryChild2>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelEqualityPrivateSetReadOnlyDictionaryChild2(
            IReadOnlyDictionary<bool, bool> parentReadOnlyDictionaryInterfaceOfBoolProperty,
            IReadOnlyDictionary<int, int> parentReadOnlyDictionaryInterfaceOfIntProperty,
            IReadOnlyDictionary<string, string> parentReadOnlyDictionaryInterfaceOfStringProperty,
            IReadOnlyDictionary<Guid, Guid> parentReadOnlyDictionaryInterfaceOfGuidProperty,
            IReadOnlyDictionary<CustomEnum, CustomEnum> parentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum, CustomFlagsEnum> parentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyDictionary<CustomClass, CustomClass> parentReadOnlyDictionaryInterfaceOfCustomClassProperty,
            IReadOnlyDictionary<CustomBaseClass, CustomBaseClass> parentReadOnlyDictionaryInterfaceOfCustomBaseClassProperty,
            IReadOnlyDictionary<bool, bool> child2ReadOnlyDictionaryInterfaceOfBoolProperty,
            IReadOnlyDictionary<int, int> child2ReadOnlyDictionaryInterfaceOfIntProperty,
            IReadOnlyDictionary<string, string> child2ReadOnlyDictionaryInterfaceOfStringProperty,
            IReadOnlyDictionary<Guid, Guid> child2ReadOnlyDictionaryInterfaceOfGuidProperty,
            IReadOnlyDictionary<CustomEnum, CustomEnum> child2ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum, CustomFlagsEnum> child2ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyDictionary<CustomClass, CustomClass> child2ReadOnlyDictionaryInterfaceOfCustomClassProperty,
            IReadOnlyDictionary<CustomBaseClass, CustomBaseClass> child2ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty)
            : base(parentReadOnlyDictionaryInterfaceOfBoolProperty, parentReadOnlyDictionaryInterfaceOfIntProperty, parentReadOnlyDictionaryInterfaceOfStringProperty, parentReadOnlyDictionaryInterfaceOfGuidProperty, parentReadOnlyDictionaryInterfaceOfCustomEnumProperty, parentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty, parentReadOnlyDictionaryInterfaceOfCustomClassProperty, parentReadOnlyDictionaryInterfaceOfCustomBaseClassProperty)
        {
            new { child2ReadOnlyDictionaryInterfaceOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { child2ReadOnlyDictionaryInterfaceOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { child2ReadOnlyDictionaryInterfaceOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { child2ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.Child2ReadOnlyDictionaryInterfaceOfBoolProperty = child2ReadOnlyDictionaryInterfaceOfBoolProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfIntProperty = child2ReadOnlyDictionaryInterfaceOfIntProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfStringProperty = child2ReadOnlyDictionaryInterfaceOfStringProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfGuidProperty = child2ReadOnlyDictionaryInterfaceOfGuidProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfCustomEnumProperty = child2ReadOnlyDictionaryInterfaceOfCustomEnumProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = child2ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfCustomClassProperty = child2ReadOnlyDictionaryInterfaceOfCustomClassProperty;
            this.Child2ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = child2ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<bool, bool> Child2ReadOnlyDictionaryInterfaceOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<int, int> Child2ReadOnlyDictionaryInterfaceOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, string> Child2ReadOnlyDictionaryInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<Guid, Guid> Child2ReadOnlyDictionaryInterfaceOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomEnum, CustomEnum> Child2ReadOnlyDictionaryInterfaceOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomFlagsEnum, CustomFlagsEnum> Child2ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomClass, CustomClass> Child2ReadOnlyDictionaryInterfaceOfCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomBaseClass, CustomBaseClass> Child2ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPrivateSetReadOnlyDictionaryChild2 other)
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
                this.ParentReadOnlyDictionaryInterfaceOfBoolProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfBoolProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfIntProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfIntProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfStringProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfStringProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfGuidProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfGuidProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty) &&
                this.ParentReadOnlyDictionaryInterfaceOfCustomBaseClassProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfCustomBaseClassProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfBoolProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfBoolProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfIntProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfIntProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfStringProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfStringProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfGuidProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfGuidProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfCustomEnumProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfCustomEnumProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfCustomClassProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfCustomClassProperty) &&
                this.Child2ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty.IsEqualTo(other.Child2ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty);

            return result;
        }
    }
}