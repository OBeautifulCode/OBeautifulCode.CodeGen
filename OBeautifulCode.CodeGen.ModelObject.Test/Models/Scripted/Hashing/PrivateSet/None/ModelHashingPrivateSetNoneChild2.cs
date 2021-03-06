﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetNoneChild2.cs" company="OBeautifulCode">
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
    public partial class ModelHashingPrivateSetNoneChild2 : ModelHashingPrivateSetNoneParent, IHashableViaCodeGen, IDeclareGetHashCodeMethod
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelHashingPrivateSetNoneChild2(
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
            bool child2BoolProperty,
            int child2IntProperty,
            string child2StringProperty,
            Guid child2GuidProperty,
            DateTime child2DateTimeProperty,
            CustomEnum child2CustomEnumProperty,
            CustomFlagsEnum child2CustomFlagsEnumProperty,
            CustomClass child2CustomClassProperty,
            CustomBaseClass child2CustomBaseClassProperty,
            CustomGenericClass<CustomClass> child2CustomGenericClassOfCustomClassProperty)
            : base(parentBoolProperty, parentIntProperty, parentStringProperty, parentGuidProperty, parentDateTimeProperty, parentCustomEnumProperty, parentCustomFlagsEnumProperty, parentCustomClassProperty, parentCustomBaseClassProperty, parentCustomGenericClassOfCustomClassProperty)
        {
            new { child2StringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { child2CustomClassProperty }.AsArg().Must().NotBeNull();
            new { child2CustomBaseClassProperty }.AsArg().Must().NotBeNull();
            new { child2CustomGenericClassOfCustomClassProperty }.AsArg().Must().NotBeNull();

            this.Child2BoolProperty = child2BoolProperty;
            this.Child2IntProperty = child2IntProperty;
            this.Child2StringProperty = child2StringProperty;
            this.Child2GuidProperty = child2GuidProperty;
            this.Child2DateTimeProperty = child2DateTimeProperty;
            this.Child2CustomEnumProperty = child2CustomEnumProperty;
            this.Child2CustomFlagsEnumProperty = child2CustomFlagsEnumProperty;
            this.Child2CustomClassProperty = child2CustomClassProperty;
            this.Child2CustomBaseClassProperty = child2CustomBaseClassProperty;
            this.Child2CustomGenericClassOfCustomClassProperty = child2CustomGenericClassOfCustomClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public bool Child2BoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int Child2IntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public string Child2StringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Guid Child2GuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public DateTime Child2DateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomEnum Child2CustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomFlagsEnum Child2CustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomClass Child2CustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomBaseClass Child2CustomBaseClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomGenericClass<CustomClass> Child2CustomGenericClassOfCustomClassProperty { get; private set; }

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
                .Hash(this.ParentBoolProperty)
                .Hash(this.ParentIntProperty)
                .Hash(this.ParentStringProperty)
                .Hash(this.ParentGuidProperty)
                .Hash(this.ParentDateTimeProperty)
                .Hash(this.ParentCustomEnumProperty)
                .Hash(this.ParentCustomFlagsEnumProperty)
                .Hash(this.ParentCustomClassProperty)
                .Hash(this.ParentCustomBaseClassProperty)
                .Hash(this.ParentCustomGenericClassOfCustomClassProperty)
                .Hash(this.Child2BoolProperty)
                .Hash(this.Child2IntProperty)
                .Hash(this.Child2StringProperty)
                .Hash(this.Child2GuidProperty)
                .Hash(this.Child2DateTimeProperty)
                .Hash(this.Child2CustomEnumProperty)
                .Hash(this.Child2CustomFlagsEnumProperty)
                .Hash(this.Child2CustomClassProperty)
                .Hash(this.Child2CustomBaseClassProperty)
                .Hash(this.Child2CustomGenericClassOfCustomClassProperty)
                .Value;
    }
}