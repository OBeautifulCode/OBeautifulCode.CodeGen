// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSetMultilevelGrandchild2B.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Type;

    public partial class MyModelPrivateSetMultilevelGrandchild2B : MyModelPrivateSetMultilevelChild2, IModelViaCodeGen, IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<MyModelPrivateSetMultilevelGrandchild2B>
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public MyModelPrivateSetMultilevelGrandchild2B(
            int parentInt,
            int child2Int,
            int grandchild2BInt)
            : base(parentInt, child2Int)
        {
            this.Grandchild2BInt = grandchild2BInt;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int Grandchild2BInt { get; private set; }

        public RelativeSortOrder CompareToForRelativeSortOrder(
            MyModelPrivateSetMultilevelGrandchild2B other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }
            else
            {
                var sumThis = this.ParentInt + this.Child2Int + this.Grandchild2BInt;

                var sumOther = other.ParentInt + other.Child2Int + other.Grandchild2BInt;

                if (sumThis > sumOther)
                {
                    return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
                }
                else if (sumThis < sumOther)
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
}