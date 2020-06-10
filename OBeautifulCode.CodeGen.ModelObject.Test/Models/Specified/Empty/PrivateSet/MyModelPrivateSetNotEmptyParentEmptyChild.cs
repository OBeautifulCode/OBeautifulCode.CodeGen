// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSetNotEmptyParentEmptyChild.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;

    using OBeautifulCode.Type;

    public partial class MyModelPrivateSetNotEmptyParentEmptyChild : MyModelPrivateSetNotEmptyParent, IModelViaCodeGen
    {
        public MyModelPrivateSetNotEmptyParentEmptyChild(
            IReadOnlyDictionary<string, string> parentReadOnlyDictionaryOfStringString)
            : base(parentReadOnlyDictionaryOfStringString)
        {
        }
    }
}