// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultilevelChild2.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public abstract partial class MyModelPrivateSettersMultilevelChild2 : MyModelPrivateSettersMultilevelParent, IModelViaCodeGen, IComparableViaCodeGen
    {
        protected MyModelPrivateSettersMultilevelChild2(
            int parentInt,
            int child2Int)
            : base(parentInt)
        {
            this.Child2Int = child2Int;
        }

        public int Child2Int { get; private set; }
    }
}