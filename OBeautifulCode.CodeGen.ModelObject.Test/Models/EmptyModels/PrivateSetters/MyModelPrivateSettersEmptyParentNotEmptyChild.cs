// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersEmptyParentNotEmptyChild.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class MyModelPrivateSettersEmptyParentNotEmptyChild : MyModelPrivateSettersEmptyParent, IModelViaCodeGen
    {
        public MyModelPrivateSettersEmptyParentNotEmptyChild(
            IReadOnlyDictionary<string, string> childReadOnlyDictionaryOfStringString)
        {
            new { childReadOnlyDictionaryOfStringString }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.ChildReadOnlyDictionaryOfStringString = childReadOnlyDictionaryOfStringString;
        }

        public IReadOnlyDictionary<string, string> ChildReadOnlyDictionaryOfStringString { get; private set; }
    }
}