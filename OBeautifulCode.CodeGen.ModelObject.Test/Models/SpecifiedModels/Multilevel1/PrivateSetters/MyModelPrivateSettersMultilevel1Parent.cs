// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultilevelParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public abstract partial class MyModelPrivateSettersMultilevelParent : IModelViaCodeGen, IComparableViaCodeGen
    {
        protected MyModelPrivateSettersMultilevelParent(
            int parentInt)
        {
            this.ParentInt = parentInt;
        }

        public int ParentInt { get; private set; }
    }
}