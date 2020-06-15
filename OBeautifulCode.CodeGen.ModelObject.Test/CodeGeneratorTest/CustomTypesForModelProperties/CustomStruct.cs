// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomStruct.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    [Serializable]
    public struct CustomStruct : IEquatable<CustomStruct>, IDeepCloneable<CustomStruct>
    {
        public CustomStruct(
            int item1,
            string item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public int Item1 { get; private set; }

        public string Item2 { get; private set; }

        public static bool operator ==(
            CustomStruct left,
            CustomStruct right)
        {
            var result =
                (left.Item1 == right.Item1) &&
                (left.Item2 == right.Item2);

            return result;
        }

        public static bool operator !=(
            CustomStruct left,
            CustomStruct right)
            => !(left == right);

        /// <inheritdoc />
        public bool Equals(CustomStruct other) => this == other;

        /// <inheritdoc />
        public override bool Equals(object obj) => (obj is CustomStruct other) && this.Equals(other);

        /// <inheritdoc />
        public override int GetHashCode() =>
            HashCodeHelper.Initialize()
                .Hash(this.Item1)
                .Hash(this.Item2)
                .Value;

        public CustomStruct DeepClone()
        {
            var result = new CustomStruct(this.Item1, this.Item2?.Clone().ToString());

            return result;
        }

        public object Clone() => this.DeepClone();
    }
}
