// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersNotEmptyParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;

    using OBeautifulCode.Type;

    public abstract partial class MyModelPublicSettersNotEmptyParent : IModelViaCodeGen
    {
        public IReadOnlyDictionary<string, string> ParentReadOnlyDictionaryOfStringString { get; set; }
    }
}