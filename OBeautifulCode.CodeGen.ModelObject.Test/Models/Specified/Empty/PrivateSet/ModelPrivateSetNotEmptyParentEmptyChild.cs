// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetNotEmptyParentEmptyChild.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;

    using OBeautifulCode.Type;

    public partial class ModelPrivateSetNotEmptyParentEmptyChild : ModelPrivateSetNotEmptyParent, IModelViaCodeGen
    {
        public ModelPrivateSetNotEmptyParentEmptyChild(
            IReadOnlyDictionary<string, string> parentReadOnlyDictionaryOfStringString)
            : base(parentReadOnlyDictionaryOfStringString)
        {
        }
    }
}