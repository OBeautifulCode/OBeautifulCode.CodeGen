// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelFlagsEnum.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    [Flags]
    public enum ModelFlagsEnum
    {
        None = 0,

        First = 1,

        Second = 2,

        Third = 4,
    }
}
