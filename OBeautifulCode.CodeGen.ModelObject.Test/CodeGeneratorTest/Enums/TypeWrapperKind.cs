// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TypeWrapperKind.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    public enum TypeWrapperKind
    {
        NotApplicable,

        NotWrapped,

        Nullable,

        ArrayOf,

        ArrayOfNullable,

        // ReSharper disable once InconsistentNaming
        IReadOnlyCollectionOf,

        // ReSharper disable once InconsistentNaming
        IReadOnlyCollectionOfNullable,

        // ReSharper disable once InconsistentNaming
        IReadOnlyListOf,

        // ReSharper disable once InconsistentNaming
        IReadOnlyListOfNullable,

        // ReSharper disable once InconsistentNaming
        IReadOnlyDictionaryOf,

        // ReSharper disable once InconsistentNaming
        IReadOnlyDictionaryOfNullable,

        AdditionalTypes,
    }
}
