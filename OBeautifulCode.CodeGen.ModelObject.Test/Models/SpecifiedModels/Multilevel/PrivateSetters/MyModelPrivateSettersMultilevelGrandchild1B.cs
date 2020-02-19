// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultilevelGrandchild1B.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public partial class MyModelPrivateSettersMultilevelGrandchild1B : MyModelPrivateSettersMultilevelChild1, IModelViaCodeGen, IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<MyModelPrivateSettersMultilevelGrandchild1B>
    {
        public MyModelPrivateSettersMultilevelGrandchild1B(
            int parentInt,
            int child1Int,
            int grandchild1BInt)
            : base(parentInt, child1Int)
        {
            this.Grandchild1BInt = grandchild1BInt;
        }

        public int Grandchild1BInt { get; private set; }

        public RelativeSortOrder CompareToForRelativeSortOrder(
            MyModelPrivateSettersMultilevelGrandchild1B other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }
            else
            {
                var sumThis = this.ParentInt + this.Child1Int + this.Grandchild1BInt;

                var sumOther = other.ParentInt + other.Child1Int + other.Grandchild1BInt;

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