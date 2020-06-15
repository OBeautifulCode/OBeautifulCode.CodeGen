// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomFlagsEnum.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    [Flags]
    [Serializable]
    [SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames", Justification = ObcSuppressBecause.CA_ALL_SeeOtherSuppressionMessages)]
    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags", Justification = ObcSuppressBecause.CA1726_UsePreferredTerms_FlagsAddedForTestsWhereEnumKindIsPrimaryConcern)]
    public enum CustomFlagsEnum
    {
        None = 0,

        First = 1,

        Second = 2,

        Third = 4,
    }
}
