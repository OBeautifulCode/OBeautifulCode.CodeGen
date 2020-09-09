﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPrivateSetReadOnlyListOfNullableParent.cs" company="OBeautifulCode">
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
    public abstract partial class ModelCloningPrivateSetReadOnlyListOfNullableParent : IDeepCloneableViaCodeGen, IEquatable<ModelCloningPrivateSetReadOnlyListOfNullableParent>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        protected ModelCloningPrivateSetReadOnlyListOfNullableParent(
            IReadOnlyList<bool?> parentReadOnlyListInterfaceOfNullableBoolProperty,
            IReadOnlyList<int?> parentReadOnlyListInterfaceOfNullableIntProperty,
            IReadOnlyList<Guid?> parentReadOnlyListInterfaceOfNullableGuidProperty,
            IReadOnlyList<DateTime?> parentReadOnlyListInterfaceOfNullableDateTimeProperty,
            IReadOnlyList<CustomEnum?> parentReadOnlyListInterfaceOfNullableCustomEnumProperty,
            IReadOnlyList<CustomFlagsEnum?> parentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)
        {
            new { parentReadOnlyListInterfaceOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { parentReadOnlyListInterfaceOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { parentReadOnlyListInterfaceOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { parentReadOnlyListInterfaceOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { parentReadOnlyListInterfaceOfNullableCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { parentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();

            this.ParentReadOnlyListInterfaceOfNullableBoolProperty = parentReadOnlyListInterfaceOfNullableBoolProperty;
            this.ParentReadOnlyListInterfaceOfNullableIntProperty = parentReadOnlyListInterfaceOfNullableIntProperty;
            this.ParentReadOnlyListInterfaceOfNullableGuidProperty = parentReadOnlyListInterfaceOfNullableGuidProperty;
            this.ParentReadOnlyListInterfaceOfNullableDateTimeProperty = parentReadOnlyListInterfaceOfNullableDateTimeProperty;
            this.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty = parentReadOnlyListInterfaceOfNullableCustomEnumProperty;
            this.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = parentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<bool?> ParentReadOnlyListInterfaceOfNullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<int?> ParentReadOnlyListInterfaceOfNullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<Guid?> ParentReadOnlyListInterfaceOfNullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<DateTime?> ParentReadOnlyListInterfaceOfNullableDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomEnum?> ParentReadOnlyListInterfaceOfNullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomFlagsEnum?> ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty { get; private set; }

        /// <inheritdoc />
        public virtual bool Equals(ModelCloningPrivateSetReadOnlyListOfNullableParent other)
        {
            throw new NotImplementedException("This method should be abstract.  It was generated as virtual so that you aren't forced to override it when you create a new model that derives from this model.  It will be overriden in the generated designer file.");
        }
    }
}