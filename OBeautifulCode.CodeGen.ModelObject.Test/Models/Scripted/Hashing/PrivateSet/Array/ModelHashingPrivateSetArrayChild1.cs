﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetArrayChild1.cs" company="OBeautifulCode">
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
    public partial class ModelHashingPrivateSetArrayChild1 : ModelHashingPrivateSetArrayParent, IHashableViaCodeGen, IDeclareGetHashCodeMethod
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelHashingPrivateSetArrayChild1(
            bool[] parentArrayOfBoolProperty,
            int[] parentArrayOfIntProperty,
            string[] parentArrayOfStringProperty,
            Guid[] parentArrayOfGuidProperty,
            DateTime[] parentArrayOfDateTimeProperty,
            CustomEnum[] parentArrayOfCustomEnumProperty,
            CustomFlagsEnum[] parentArrayOfCustomFlagsEnumProperty,
            CustomClass[] parentArrayOfCustomClassProperty,
            bool[] child1ArrayOfBoolProperty,
            int[] child1ArrayOfIntProperty,
            string[] child1ArrayOfStringProperty,
            Guid[] child1ArrayOfGuidProperty,
            DateTime[] child1ArrayOfDateTimeProperty,
            CustomEnum[] child1ArrayOfCustomEnumProperty,
            CustomFlagsEnum[] child1ArrayOfCustomFlagsEnumProperty,
            CustomClass[] child1ArrayOfCustomClassProperty)
            : base(parentArrayOfBoolProperty, parentArrayOfIntProperty, parentArrayOfStringProperty, parentArrayOfGuidProperty, parentArrayOfDateTimeProperty, parentArrayOfCustomEnumProperty, parentArrayOfCustomFlagsEnumProperty, parentArrayOfCustomClassProperty)
        {
            new { child1ArrayOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ArrayOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ArrayOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.Child1ArrayOfBoolProperty = child1ArrayOfBoolProperty;
            this.Child1ArrayOfIntProperty = child1ArrayOfIntProperty;
            this.Child1ArrayOfStringProperty = child1ArrayOfStringProperty;
            this.Child1ArrayOfGuidProperty = child1ArrayOfGuidProperty;
            this.Child1ArrayOfDateTimeProperty = child1ArrayOfDateTimeProperty;
            this.Child1ArrayOfCustomEnumProperty = child1ArrayOfCustomEnumProperty;
            this.Child1ArrayOfCustomFlagsEnumProperty = child1ArrayOfCustomFlagsEnumProperty;
            this.Child1ArrayOfCustomClassProperty = child1ArrayOfCustomClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public bool[] Child1ArrayOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int[] Child1ArrayOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public string[] Child1ArrayOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Guid[] Child1ArrayOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public DateTime[] Child1ArrayOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomEnum[] Child1ArrayOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomFlagsEnum[] Child1ArrayOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomClass[] Child1ArrayOfCustomClassProperty { get; private set; }

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
                .Hash(this.ParentArrayOfBoolProperty)
                .Hash(this.ParentArrayOfIntProperty)
                .Hash(this.ParentArrayOfStringProperty)
                .Hash(this.ParentArrayOfGuidProperty)
                .Hash(this.ParentArrayOfDateTimeProperty)
                .Hash(this.ParentArrayOfCustomEnumProperty)
                .Hash(this.ParentArrayOfCustomFlagsEnumProperty)
                .Hash(this.ParentArrayOfCustomClassProperty)
                .Hash(this.Child1ArrayOfBoolProperty)
                .Hash(this.Child1ArrayOfIntProperty)
                .Hash(this.Child1ArrayOfStringProperty)
                .Hash(this.Child1ArrayOfGuidProperty)
                .Hash(this.Child1ArrayOfDateTimeProperty)
                .Hash(this.Child1ArrayOfCustomEnumProperty)
                .Hash(this.Child1ArrayOfCustomFlagsEnumProperty)
                .Hash(this.Child1ArrayOfCustomClassProperty)
                .Value;
    }
}