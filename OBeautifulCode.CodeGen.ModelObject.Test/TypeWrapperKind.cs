// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TypeWrapperKind.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    public enum TypeWrapperKind
    {
        None,

        Nullable,

        ArrayOf,

        ArrayOfNullable,

        ReadOnlyCollectionOf,

        ReadOnlyCollectionOfNullable,

        ReadOnlyDictionaryOf,

        ReadOnlyDictionaryOfNullable,
    }
}
