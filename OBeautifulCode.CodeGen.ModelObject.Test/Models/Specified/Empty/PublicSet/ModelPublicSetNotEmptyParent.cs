﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPublicSetNotEmptyParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;

    using OBeautifulCode.Type;

    public abstract partial class ModelPublicSetNotEmptyParent : IModelViaCodeGen
    {
        public IReadOnlyDictionary<string, string> ParentReadOnlyDictionaryOfStringString { get; set; }
    }
}