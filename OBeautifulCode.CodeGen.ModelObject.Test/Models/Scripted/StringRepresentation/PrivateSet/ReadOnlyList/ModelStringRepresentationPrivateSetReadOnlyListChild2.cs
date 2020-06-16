﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelStringRepresentationPrivateSetReadOnlyListChild2.cs" company="OBeautifulCode">
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
    public partial class ModelStringRepresentationPrivateSetReadOnlyListChild2 : ModelStringRepresentationPrivateSetReadOnlyListParent, IStringRepresentableViaCodeGen, IDeclareToStringMethod
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelStringRepresentationPrivateSetReadOnlyListChild2(
            IReadOnlyList<bool> parentReadOnlyListInterfaceOfBoolProperty,
            IReadOnlyList<int> parentReadOnlyListInterfaceOfIntProperty,
            IReadOnlyList<string> parentReadOnlyListInterfaceOfStringProperty,
            IReadOnlyList<Guid> parentReadOnlyListInterfaceOfGuidProperty,
            IReadOnlyList<DateTime> parentReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyList<CustomEnum> parentReadOnlyListInterfaceOfCustomEnumProperty,
            IReadOnlyList<CustomFlagsEnum> parentReadOnlyListInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyList<CustomClass> parentReadOnlyListInterfaceOfCustomClassProperty,
            IReadOnlyList<CustomBaseClass> parentReadOnlyListInterfaceOfCustomBaseClassProperty,
            IReadOnlyList<bool> child2ReadOnlyListInterfaceOfBoolProperty,
            IReadOnlyList<int> child2ReadOnlyListInterfaceOfIntProperty,
            IReadOnlyList<string> child2ReadOnlyListInterfaceOfStringProperty,
            IReadOnlyList<Guid> child2ReadOnlyListInterfaceOfGuidProperty,
            IReadOnlyList<DateTime> child2ReadOnlyListInterfaceOfDateTimeProperty,
            IReadOnlyList<CustomEnum> child2ReadOnlyListInterfaceOfCustomEnumProperty,
            IReadOnlyList<CustomFlagsEnum> child2ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyList<CustomClass> child2ReadOnlyListInterfaceOfCustomClassProperty,
            IReadOnlyList<CustomBaseClass> child2ReadOnlyListInterfaceOfCustomBaseClassProperty)
            : base(parentReadOnlyListInterfaceOfBoolProperty, parentReadOnlyListInterfaceOfIntProperty, parentReadOnlyListInterfaceOfStringProperty, parentReadOnlyListInterfaceOfGuidProperty, parentReadOnlyListInterfaceOfDateTimeProperty, parentReadOnlyListInterfaceOfCustomEnumProperty, parentReadOnlyListInterfaceOfCustomFlagsEnumProperty, parentReadOnlyListInterfaceOfCustomClassProperty, parentReadOnlyListInterfaceOfCustomBaseClassProperty)
        {
            new { child2ReadOnlyListInterfaceOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ReadOnlyListInterfaceOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ReadOnlyListInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2ReadOnlyListInterfaceOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ReadOnlyListInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ReadOnlyListInterfaceOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ReadOnlyListInterfaceOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ReadOnlyListInterfaceOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2ReadOnlyListInterfaceOfCustomBaseClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.Child2ReadOnlyListInterfaceOfBoolProperty = child2ReadOnlyListInterfaceOfBoolProperty;
            this.Child2ReadOnlyListInterfaceOfIntProperty = child2ReadOnlyListInterfaceOfIntProperty;
            this.Child2ReadOnlyListInterfaceOfStringProperty = child2ReadOnlyListInterfaceOfStringProperty;
            this.Child2ReadOnlyListInterfaceOfGuidProperty = child2ReadOnlyListInterfaceOfGuidProperty;
            this.Child2ReadOnlyListInterfaceOfDateTimeProperty = child2ReadOnlyListInterfaceOfDateTimeProperty;
            this.Child2ReadOnlyListInterfaceOfCustomEnumProperty = child2ReadOnlyListInterfaceOfCustomEnumProperty;
            this.Child2ReadOnlyListInterfaceOfCustomFlagsEnumProperty = child2ReadOnlyListInterfaceOfCustomFlagsEnumProperty;
            this.Child2ReadOnlyListInterfaceOfCustomClassProperty = child2ReadOnlyListInterfaceOfCustomClassProperty;
            this.Child2ReadOnlyListInterfaceOfCustomBaseClassProperty = child2ReadOnlyListInterfaceOfCustomBaseClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<bool> Child2ReadOnlyListInterfaceOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<int> Child2ReadOnlyListInterfaceOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<string> Child2ReadOnlyListInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<Guid> Child2ReadOnlyListInterfaceOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<DateTime> Child2ReadOnlyListInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomEnum> Child2ReadOnlyListInterfaceOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomFlagsEnum> Child2ReadOnlyListInterfaceOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomClass> Child2ReadOnlyListInterfaceOfCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomBaseClass> Child2ReadOnlyListInterfaceOfCustomBaseClassProperty { get; private set; }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = "not being tested";

            return result;
        }
    }
}