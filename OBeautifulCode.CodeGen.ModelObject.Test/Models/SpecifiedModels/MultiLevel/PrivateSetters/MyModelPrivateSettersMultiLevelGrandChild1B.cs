// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultiLevelGrandChild1B.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public partial class MyModelPrivateSettersMultiLevelGrandChild1B : MyModelPrivateSettersMultiLevelChild1, IModelViaCodeGen, IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<MyModelPrivateSettersMultiLevelGrandChild1B>
    {
        public MyModelPrivateSettersMultiLevelGrandChild1B(
            int parentInt,
            int child1Int,
            int grandChild1BInt)
            : base(parentInt, child1Int)
        {
            this.GrandChild1BInt = grandChild1BInt;
        }

        public int GrandChild1BInt { get; private set; }

        public RelativeSortOrder CompareToForRelativeSortOrder(
            MyModelPrivateSettersMultiLevelGrandChild1B other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }
            else
            {
                var sumThis = this.ParentInt + this.Child1Int + this.GrandChild1BInt;

                var sumOther = other.ParentInt + this.Child1Int + this.GrandChild1BInt;

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