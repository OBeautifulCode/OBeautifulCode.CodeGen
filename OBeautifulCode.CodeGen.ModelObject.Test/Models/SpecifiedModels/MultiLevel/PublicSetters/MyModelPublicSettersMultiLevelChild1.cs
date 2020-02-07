// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultiLevelChild1.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public abstract partial class MyModelPublicSettersMultiLevelChild1 : MyModelPublicSettersMultiLevelParent, IModelViaCodeGen, IComparableViaCodeGen
    {
        public int Child1Int { get; set; }
    }
}