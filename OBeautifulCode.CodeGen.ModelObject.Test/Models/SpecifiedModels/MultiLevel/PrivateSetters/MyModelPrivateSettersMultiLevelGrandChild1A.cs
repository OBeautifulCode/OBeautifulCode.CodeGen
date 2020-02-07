// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultiLevelGrandChild1A.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public partial class MyModelPrivateSettersMultiLevelGrandChild1A : MyModelPrivateSettersMultiLevelChild1, IModelViaCodeGen, IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<MyModelPrivateSettersMultiLevelGrandChild1A>
    {
        public MyModelPrivateSettersMultiLevelGrandChild1A(
            int parentInt,
            int child1Int,
            int grandChild1AInt)
            : base(parentInt, child1Int)
        {
            this.GrandChild1AInt = grandChild1AInt;
        }

        public int GrandChild1AInt { get; private set; }

        public RelativeSortOrder CompareToForRelativeSortOrder(
            MyModelPrivateSettersMultiLevelGrandChild1A other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }
            else
            {
                var sumThis = this.ParentInt + this.Child1Int + this.GrandChild1AInt;

                var sumOther = other.ParentInt + this.Child1Int + this.GrandChild1AInt;

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