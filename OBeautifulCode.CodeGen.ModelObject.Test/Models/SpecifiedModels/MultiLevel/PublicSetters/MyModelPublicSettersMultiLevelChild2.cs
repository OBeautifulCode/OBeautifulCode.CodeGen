// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultiLevelChild2.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public abstract partial class MyModelPublicSettersMultiLevelChild2 : MyModelPublicSettersMultiLevelParent, IModelViaCodeGen, IComparableViaCodeGen
    {
        public int Child2Int { get; set; }
    }
}