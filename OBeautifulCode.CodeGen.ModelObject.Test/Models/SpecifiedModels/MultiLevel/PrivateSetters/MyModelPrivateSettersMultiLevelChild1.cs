// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultiLevelChild1.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public abstract partial class MyModelPrivateSettersMultiLevelChild1 : MyModelPrivateSettersMultiLevelParent, IModelViaCodeGen, IComparableViaCodeGen
    {
        protected MyModelPrivateSettersMultiLevelChild1(
            int parentInt,
            int child1Int)
            : base(parentInt)
        {
            this.Child1Int = child1Int;
        }

        public int Child1Int { get; private set; }
    }
}