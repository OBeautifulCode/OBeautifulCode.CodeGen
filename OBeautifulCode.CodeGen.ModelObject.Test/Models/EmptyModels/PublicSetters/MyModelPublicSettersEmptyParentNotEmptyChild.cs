// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersEmptyParentNotEmptyChild.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;

    using OBeautifulCode.Type;

    public partial class MyModelPublicSettersEmptyParentNotEmptyChild : MyModelPublicSettersEmptyParent, IModelViaCodeGen
    {
        public IReadOnlyDictionary<string, string> ChildReadOnlyDictionaryOfStringString { get; set; }
    }
}