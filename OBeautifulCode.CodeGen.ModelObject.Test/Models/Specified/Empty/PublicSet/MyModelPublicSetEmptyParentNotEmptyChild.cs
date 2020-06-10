// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSetEmptyParentNotEmptyChild.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;

    using OBeautifulCode.Type;

    public partial class MyModelPublicSetEmptyParentNotEmptyChild : MyModelPublicSetEmptyParent, IModelViaCodeGen
    {
        public IReadOnlyDictionary<string, string> ChildReadOnlyDictionaryOfStringString { get; set; }
    }
}