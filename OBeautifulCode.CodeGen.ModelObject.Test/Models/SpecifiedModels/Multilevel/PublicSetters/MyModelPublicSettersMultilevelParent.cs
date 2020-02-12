// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultilevelParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public abstract partial class MyModelPublicSettersMultilevelParent : IModelViaCodeGen, IComparableViaCodeGen
    {
        public int ParentInt { get; set; }
    }
}