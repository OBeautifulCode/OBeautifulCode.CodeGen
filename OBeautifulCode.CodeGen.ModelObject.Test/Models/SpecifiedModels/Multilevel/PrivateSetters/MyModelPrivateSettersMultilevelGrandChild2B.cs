// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultilevelGrandChild2B.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public partial class MyModelPrivateSettersMultilevelGrandChild2B : MyModelPrivateSettersMultilevelChild2, IModelViaCodeGen, IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<MyModelPrivateSettersMultilevelGrandChild2B>
    {
        public MyModelPrivateSettersMultilevelGrandChild2B(
            int parentInt,
            int child2Int,
            int grandChild2BInt)
            : base(parentInt, child2Int)
        {
            this.GrandChild2BInt = grandChild2BInt;
        }

        public int GrandChild2BInt { get; private set; }

        public RelativeSortOrder CompareToForRelativeSortOrder(
            MyModelPrivateSettersMultilevelGrandChild2B other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }
            else
            {
                var sumThis = this.ParentInt + this.Child2Int + this.GrandChild2BInt;

                var sumOther = other.ParentInt + other.Child2Int + other.GrandChild2BInt;

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