// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetNotEmptyParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public abstract partial class ModelPrivateSetNotEmptyParent : IModelViaCodeGen
    {
        protected ModelPrivateSetNotEmptyParent(
            IReadOnlyDictionary<string, string> parentReadOnlyDictionaryOfStringString)
        {
            new { parentReadOnlyDictionaryOfStringString }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.ParentReadOnlyDictionaryOfStringString = parentReadOnlyDictionaryOfStringString;
        }

        public IReadOnlyDictionary<string, string> ParentReadOnlyDictionaryOfStringString { get; private set; }
    }
}