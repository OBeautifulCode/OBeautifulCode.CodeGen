// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelStruct.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    public struct ModelStruct : IEquatable<ModelStruct>, IDeepCloneable<ModelStruct>
    {
        public ModelStruct(
            int item1,
            string item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public int Item1 { get; private set; }

        public string Item2 { get; private set; }

        public static bool operator ==(
            ModelStruct left,
            ModelStruct right)
        {
            var result =
                (left.Item1 == right.Item1) &&
                (left.Item2 == right.Item2);

            return result;
        }

        public static bool operator !=(
            ModelStruct left,
            ModelStruct right)
            => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelStruct other) => this == other;

        /// <inheritdoc />
        public override bool Equals(object obj) => (obj is ModelStruct other) && this.Equals(other);

        /// <inheritdoc />
        public override int GetHashCode() =>
            HashCodeHelper.Initialize()
                .Hash(this.Item1)
                .Hash(this.Item2)
                .Value;

        public ModelStruct DeepClone()
        {
            var result = new ModelStruct(this.Item1, this.Item2?.Clone().ToString());

            return result;
        }

        public object Clone() => this.DeepClone();
    }
}
