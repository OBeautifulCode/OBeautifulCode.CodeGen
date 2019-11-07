// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelStruct.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Type;

    [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Justification = ObcSuppressBecause.CA1815_OverrideEqualsAndOperatorEqualsOnValueTypes_TypeUsedForTestsThatRequireTypeToNotBeEquatable)]
    public struct ModelStruct : IDeepCloneable<ModelStruct>
    {
        public ModelStruct(
            int item1,
            string item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public int Item1 { get; }

        public string Item2 { get; }

        public ModelStruct DeepClone()
        {
            var result = new ModelStruct(this.Item1, this.Item2?.Clone().ToString());

            return result;
        }

        public object Clone() => this.DeepClone();
    }
}
