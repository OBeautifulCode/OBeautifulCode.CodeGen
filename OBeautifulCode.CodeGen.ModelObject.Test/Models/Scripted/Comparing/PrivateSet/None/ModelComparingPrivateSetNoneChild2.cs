﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelComparingPrivateSetNoneChild2.cs" company="OBeautifulCode">
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
    [SuppressMessage("Microsoft.Design", "CA1036: OverrideMethodsOnComparableTypes")]
    public partial class ModelComparingPrivateSetNoneChild2 : ModelComparingPrivateSetNoneParent, IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<ModelComparingPrivateSetNoneChild2>
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelComparingPrivateSetNoneChild2(
            int parentIntProperty,
            int child2IntProperty)
            : base(parentIntProperty)
        {

            this.Child2IntProperty = child2IntProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int Child2IntProperty { get; private set; }

        /// <inheritdoc />
        public RelativeSortOrder CompareToForRelativeSortOrder(ModelComparingPrivateSetNoneChild2 other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            var thisSum = this.Child2IntProperty + this.ParentIntProperty;
            var otherSum = other.Child2IntProperty + other.ParentIntProperty;

            if (thisSum > otherSum)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            else if (thisSum < otherSum)
            {
                return RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;
            }

            else
            {
                return RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance;
            }
        }
    }
}