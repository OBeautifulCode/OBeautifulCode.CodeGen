// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultilevelChild1.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public abstract partial class MyModelPublicSettersMultilevelChild1 : MyModelPublicSettersMultilevelParent, IModelViaCodeGen, IComparableViaCodeGen
    {
        public int Child1Int { get; set; }
    }
}