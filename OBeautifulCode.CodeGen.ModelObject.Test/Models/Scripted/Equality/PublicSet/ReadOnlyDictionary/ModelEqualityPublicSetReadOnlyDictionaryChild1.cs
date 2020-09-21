﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetReadOnlyDictionaryChild1.cs" company="OBeautifulCode">
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

#pragma warning disable CS0659
#pragma warning disable CS0661
    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    [SuppressMessage("Microsoft.Usage", "CA2218: OverrideGetHashCodeOnOverridingEquals")]
    public partial class ModelEqualityPublicSetReadOnlyDictionaryChild1 : ModelEqualityPublicSetReadOnlyDictionaryParent, IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPublicSetReadOnlyDictionaryChild1>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<bool, bool> Child1ReadOnlyDictionaryInterfaceOfBoolProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<int, int> Child1ReadOnlyDictionaryInterfaceOfIntProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, string> Child1ReadOnlyDictionaryInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<Guid, Guid> Child1ReadOnlyDictionaryInterfaceOfGuidProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomEnum, CustomEnum> Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomFlagsEnum, CustomFlagsEnum> Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomClass, CustomClass> Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomBaseClass, CustomBaseClass> Child1ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomGenericClass<CustomClass>, CustomGenericClass<CustomClass>> Child1ReadOnlyDictionaryInterfaceOfCustomGenericClassOfCustomClassProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPublicSetReadOnlyDictionaryChild1 other)
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
                this.ParentReadOnlyDictionaryInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.ParentReadOnlyDictionaryInterfaceOfCustomGenericClassOfCustomClassProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfBoolProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfBoolProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfIntProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfIntProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfStringProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfStringProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfGuidProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfGuidProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty) &&
                this.Child1ReadOnlyDictionaryInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.Child1ReadOnlyDictionaryInterfaceOfCustomGenericClassOfCustomClassProperty);

            return result;
        }
    }
}