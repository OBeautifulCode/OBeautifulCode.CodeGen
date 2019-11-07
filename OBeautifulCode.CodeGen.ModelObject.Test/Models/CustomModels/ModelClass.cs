// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Type;

    public class ModelClass : IDeepCloneable<ModelClass>
    {
        public ModelClass(
            int item1,
            string item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public int Item1 { get; }

        public string Item2 { get; }

        public ModelClass DeepClone()
        {
            var result = new ModelClass(this.Item1, this.Item2?.Clone().ToString());

            return result;
        }

        public object Clone() => this.DeepClone();
    }
}
