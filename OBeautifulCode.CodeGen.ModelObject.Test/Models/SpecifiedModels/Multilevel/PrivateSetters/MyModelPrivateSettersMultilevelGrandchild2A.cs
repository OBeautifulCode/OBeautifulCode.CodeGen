// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultilevelGrandchild2A.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public partial class MyModelPrivateSettersMultilevelGrandchild2A : MyModelPrivateSettersMultilevelChild2, IModelViaCodeGen, IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<MyModelPrivateSettersMultilevelGrandchild2A>
    {
        public MyModelPrivateSettersMultilevelGrandchild2A(
            int parentInt,
            int child2Int,
            int grandchild2AInt)
            : base(parentInt, child2Int)
        {
            this.Grandchild2AInt = grandchild2AInt;
        }

        public int Grandchild2AInt { get; private set; }

        public RelativeSortOrder CompareToForRelativeSortOrder(
            MyModelPrivateSettersMultilevelGrandchild2A other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }
            else
            {
                var sumThis = this.ParentInt + this.Child2Int + this.Grandchild2AInt;

                var sumOther = other.ParentInt + other.Child2Int + other.Grandchild2AInt;

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