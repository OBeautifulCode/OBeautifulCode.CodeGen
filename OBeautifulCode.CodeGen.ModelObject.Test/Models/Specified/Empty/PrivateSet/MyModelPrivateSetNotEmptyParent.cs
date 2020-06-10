// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSetNotEmptyParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public abstract partial class MyModelPrivateSetNotEmptyParent : IModelViaCodeGen
    {
        protected MyModelPrivateSetNotEmptyParent(
            IReadOnlyDictionary<string, string> parentReadOnlyDictionaryOfStringString)
        {
            new { parentReadOnlyDictionaryOfStringString }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.ParentReadOnlyDictionaryOfStringString = parentReadOnlyDictionaryOfStringString;
        }

        public IReadOnlyDictionary<string, string> ParentReadOnlyDictionaryOfStringString { get; private set; }
    }
}