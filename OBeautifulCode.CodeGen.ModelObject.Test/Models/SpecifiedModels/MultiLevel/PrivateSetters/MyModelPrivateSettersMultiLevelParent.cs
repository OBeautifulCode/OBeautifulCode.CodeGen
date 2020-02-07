// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultiLevelParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public abstract partial class MyModelPrivateSettersMultiLevelParent : IModelViaCodeGen, IComparableViaCodeGen
    {
        protected MyModelPrivateSettersMultiLevelParent(
            int parentInt)
        {
            this.ParentInt = parentInt;
        }

        public int ParentInt { get; private set; }
    }
}