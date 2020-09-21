﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetNoneChild1.cs" company="OBeautifulCode">
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
    public partial class ModelEqualityPrivateSetNoneChild1 : ModelEqualityPrivateSetNoneParent, IEquatableViaCodeGen, IDeclareEqualsMethod<ModelEqualityPrivateSetNoneChild1>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelEqualityPrivateSetNoneChild1(
            bool parentBoolProperty,
            int parentIntProperty,
            string parentStringProperty,
            Guid parentGuidProperty,
            DateTime parentDateTimeProperty,
            CustomEnum parentCustomEnumProperty,
            CustomFlagsEnum parentCustomFlagsEnumProperty,
            CustomClass parentCustomClassProperty,
            CustomBaseClass parentCustomBaseClassProperty,
            CustomGenericClass<CustomClass> parentCustomGenericClassOfCustomClassProperty,
            bool child1BoolProperty,
            int child1IntProperty,
            string child1StringProperty,
            Guid child1GuidProperty,
            DateTime child1DateTimeProperty,
            CustomEnum child1CustomEnumProperty,
            CustomFlagsEnum child1CustomFlagsEnumProperty,
            CustomClass child1CustomClassProperty,
            CustomBaseClass child1CustomBaseClassProperty,
            CustomGenericClass<CustomClass> child1CustomGenericClassOfCustomClassProperty)
            : base(parentBoolProperty, parentIntProperty, parentStringProperty, parentGuidProperty, parentDateTimeProperty, parentCustomEnumProperty, parentCustomFlagsEnumProperty, parentCustomClassProperty, parentCustomBaseClassProperty, parentCustomGenericClassOfCustomClassProperty)
        {
            new { child1StringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { child1CustomClassProperty }.AsArg().Must().NotBeNull();
            new { child1CustomBaseClassProperty }.AsArg().Must().NotBeNull();
            new { child1CustomGenericClassOfCustomClassProperty }.AsArg().Must().NotBeNull();

            this.Child1BoolProperty = child1BoolProperty;
            this.Child1IntProperty = child1IntProperty;
            this.Child1StringProperty = child1StringProperty;
            this.Child1GuidProperty = child1GuidProperty;
            this.Child1DateTimeProperty = child1DateTimeProperty;
            this.Child1CustomEnumProperty = child1CustomEnumProperty;
            this.Child1CustomFlagsEnumProperty = child1CustomFlagsEnumProperty;
            this.Child1CustomClassProperty = child1CustomClassProperty;
            this.Child1CustomBaseClassProperty = child1CustomBaseClassProperty;
            this.Child1CustomGenericClassOfCustomClassProperty = child1CustomGenericClassOfCustomClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public bool Child1BoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int Child1IntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public string Child1StringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Guid Child1GuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public DateTime Child1DateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomEnum Child1CustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomFlagsEnum Child1CustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomClass Child1CustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomBaseClass Child1CustomBaseClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomGenericClass<CustomClass> Child1CustomGenericClassOfCustomClassProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelEqualityPrivateSetNoneChild1 other)
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
                this.ParentBoolProperty.IsEqualTo(other.ParentBoolProperty) &&
                this.ParentIntProperty.IsEqualTo(other.ParentIntProperty) &&
                this.ParentStringProperty.IsEqualTo(other.ParentStringProperty) &&
                this.ParentGuidProperty.IsEqualTo(other.ParentGuidProperty) &&
                this.ParentDateTimeProperty.IsEqualTo(other.ParentDateTimeProperty) &&
                this.ParentCustomEnumProperty.IsEqualTo(other.ParentCustomEnumProperty) &&
                this.ParentCustomFlagsEnumProperty.IsEqualTo(other.ParentCustomFlagsEnumProperty) &&
                this.ParentCustomClassProperty.IsEqualTo(other.ParentCustomClassProperty) &&
                this.ParentCustomBaseClassProperty.IsEqualTo(other.ParentCustomBaseClassProperty) &&
                this.ParentCustomGenericClassOfCustomClassProperty.IsEqualTo(other.ParentCustomGenericClassOfCustomClassProperty) &&
                this.Child1BoolProperty.IsEqualTo(other.Child1BoolProperty) &&
                this.Child1IntProperty.IsEqualTo(other.Child1IntProperty) &&
                this.Child1StringProperty.IsEqualTo(other.Child1StringProperty) &&
                this.Child1GuidProperty.IsEqualTo(other.Child1GuidProperty) &&
                this.Child1DateTimeProperty.IsEqualTo(other.Child1DateTimeProperty) &&
                this.Child1CustomEnumProperty.IsEqualTo(other.Child1CustomEnumProperty) &&
                this.Child1CustomFlagsEnumProperty.IsEqualTo(other.Child1CustomFlagsEnumProperty) &&
                this.Child1CustomClassProperty.IsEqualTo(other.Child1CustomClassProperty) &&
                this.Child1CustomBaseClassProperty.IsEqualTo(other.Child1CustomBaseClassProperty) &&
                this.Child1CustomGenericClassOfCustomClassProperty.IsEqualTo(other.Child1CustomGenericClassOfCustomClassProperty);

            return result;
        }
    }
}