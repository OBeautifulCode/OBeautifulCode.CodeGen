// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomEnum.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    [Serializable]
    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    public enum CustomEnum
    {
        FirstValue,

        SecondValue,

        ThirdValue,
    }
}
