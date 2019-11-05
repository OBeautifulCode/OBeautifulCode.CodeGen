// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelFlagsEnum.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    [Flags]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames", Justification = ObcSuppressBecause.CA_ALL_SeeOtherSuppressionMessages)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    public enum ModelFlagsEnum
    {
        None = 0,

        First = 1,

        Second = 2,

        Third = 4,
    }
}
