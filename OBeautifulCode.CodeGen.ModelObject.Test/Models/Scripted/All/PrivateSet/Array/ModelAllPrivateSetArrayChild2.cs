﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelAllPrivateSetArrayChild2.cs" company="OBeautifulCode">
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
    public partial class ModelAllPrivateSetArrayChild2 : ModelAllPrivateSetArrayParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelAllPrivateSetArrayChild2(
            bool[] parentArrayOfBoolProperty,
            int[] parentArrayOfIntProperty,
            string[] parentArrayOfStringProperty,
            Guid[] parentArrayOfGuidProperty,
            DateTime[] parentArrayOfDateTimeProperty,
            CustomEnum[] parentArrayOfCustomEnumProperty,
            CustomFlagsEnum[] parentArrayOfCustomFlagsEnumProperty,
            CustomClass[] parentArrayOfCustomClassProperty,
            CustomBaseClass[] parentArrayOfCustomBaseClassProperty,
            CustomGenericClass<CustomClass>[] parentArrayOfCustomGenericClassOfCustomClassProperty,
            bool[] child2ArrayOfBoolProperty,
            int[] child2ArrayOfIntProperty,
            string[] child2ArrayOfStringProperty,
            Guid[] child2ArrayOfGuidProperty,
            DateTime[] child2ArrayOfDateTimeProperty,
            CustomEnum[] child2ArrayOfCustomEnumProperty,
            CustomFlagsEnum[] child2ArrayOfCustomFlagsEnumProperty,
            CustomClass[] child2ArrayOfCustomClassProperty,
            CustomBaseClass[] child2ArrayOfCustomBaseClassProperty,
            CustomGenericClass<CustomClass>[] child2ArrayOfCustomGenericClassOfCustomClassProperty)
            : base(parentArrayOfBoolProperty, parentArrayOfIntProperty, parentArrayOfStringProperty, parentArrayOfGuidProperty, parentArrayOfDateTimeProperty, parentArrayOfCustomEnumProperty, parentArrayOfCustomFlagsEnumProperty, parentArrayOfCustomClassProperty, parentArrayOfCustomBaseClassProperty, parentArrayOfCustomGenericClassOfCustomClassProperty)
        {
            new { child2ArrayOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2ArrayOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2ArrayOfCustomBaseClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2ArrayOfCustomGenericClassOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.Child2ArrayOfBoolProperty = child2ArrayOfBoolProperty;
            this.Child2ArrayOfIntProperty = child2ArrayOfIntProperty;
            this.Child2ArrayOfStringProperty = child2ArrayOfStringProperty;
            this.Child2ArrayOfGuidProperty = child2ArrayOfGuidProperty;
            this.Child2ArrayOfDateTimeProperty = child2ArrayOfDateTimeProperty;
            this.Child2ArrayOfCustomEnumProperty = child2ArrayOfCustomEnumProperty;
            this.Child2ArrayOfCustomFlagsEnumProperty = child2ArrayOfCustomFlagsEnumProperty;
            this.Child2ArrayOfCustomClassProperty = child2ArrayOfCustomClassProperty;
            this.Child2ArrayOfCustomBaseClassProperty = child2ArrayOfCustomBaseClassProperty;
            this.Child2ArrayOfCustomGenericClassOfCustomClassProperty = child2ArrayOfCustomGenericClassOfCustomClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public bool[] Child2ArrayOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int[] Child2ArrayOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public string[] Child2ArrayOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Guid[] Child2ArrayOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public DateTime[] Child2ArrayOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomEnum[] Child2ArrayOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomFlagsEnum[] Child2ArrayOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomClass[] Child2ArrayOfCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomBaseClass[] Child2ArrayOfCustomBaseClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomGenericClass<CustomClass>[] Child2ArrayOfCustomGenericClassOfCustomClassProperty { get; private set; }
    }
}