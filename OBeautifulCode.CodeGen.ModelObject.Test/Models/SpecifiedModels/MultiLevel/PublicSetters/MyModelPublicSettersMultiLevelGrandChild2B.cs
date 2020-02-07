// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultiLevelGrandChild2B.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public partial class MyModelPublicSettersMultiLevelGrandChild2B : MyModelPublicSettersMultiLevelChild2, IModelViaCodeGen, IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<MyModelPublicSettersMultiLevelGrandChild2B>
    {
        public int GrandChild2BInt { get; set; }

        public RelativeSortOrder CompareToForRelativeSortOrder(
            MyModelPublicSettersMultiLevelGrandChild2B other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }
            else
            {
                var sumThis = this.ParentInt + this.Child2Int + this.GrandChild2BInt;

                var sumOther = other.ParentInt + this.Child2Int + this.GrandChild2BInt;

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