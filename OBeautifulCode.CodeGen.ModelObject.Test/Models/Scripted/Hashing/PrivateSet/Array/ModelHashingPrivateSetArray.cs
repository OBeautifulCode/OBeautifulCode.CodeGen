﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetArray.cs" company="OBeautifulCode">
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
    public partial class ModelHashingPrivateSetArray : IHashableViaCodeGen, IDeclareGetHashCodeMethod
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelHashingPrivateSetArray(
            bool[] arrayOfBoolProperty,
            int[] arrayOfIntProperty,
            string[] arrayOfStringProperty,
            Guid[] arrayOfGuidProperty,
            DateTime[] arrayOfDateTimeProperty,
            CustomEnum[] arrayOfCustomEnumProperty,
            CustomFlagsEnum[] arrayOfCustomFlagsEnumProperty,
            CustomClass[] arrayOfCustomClassProperty,
            CustomBaseClass[] arrayOfCustomBaseClassProperty)
        {
            new { arrayOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { arrayOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { arrayOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { arrayOfCustomBaseClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.ArrayOfBoolProperty = arrayOfBoolProperty;
            this.ArrayOfIntProperty = arrayOfIntProperty;
            this.ArrayOfStringProperty = arrayOfStringProperty;
            this.ArrayOfGuidProperty = arrayOfGuidProperty;
            this.ArrayOfDateTimeProperty = arrayOfDateTimeProperty;
            this.ArrayOfCustomEnumProperty = arrayOfCustomEnumProperty;
            this.ArrayOfCustomFlagsEnumProperty = arrayOfCustomFlagsEnumProperty;
            this.ArrayOfCustomClassProperty = arrayOfCustomClassProperty;
            this.ArrayOfCustomBaseClassProperty = arrayOfCustomBaseClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public bool[] ArrayOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int[] ArrayOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public string[] ArrayOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Guid[] ArrayOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public DateTime[] ArrayOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomEnum[] ArrayOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomFlagsEnum[] ArrayOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomClass[] ArrayOfCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomBaseClass[] ArrayOfCustomBaseClassProperty { get; private set; }

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
                .Hash(this.ArrayOfBoolProperty)
                .Hash(this.ArrayOfIntProperty)
                .Hash(this.ArrayOfStringProperty)
                .Hash(this.ArrayOfGuidProperty)
                .Hash(this.ArrayOfDateTimeProperty)
                .Hash(this.ArrayOfCustomEnumProperty)
                .Hash(this.ArrayOfCustomFlagsEnumProperty)
                .Hash(this.ArrayOfCustomClassProperty)
                .Hash(this.ArrayOfCustomBaseClassProperty)
                .Value;
    }
}