// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEquatableStruct.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    using OBeautifulCode.Math.Recipes;

    public struct ModelEquatableStruct : IEquatable<ModelEquatableStruct>
    {
        public ModelEquatableStruct(
            int item1,
            string item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public int Item1 { get; }

        public string Item2 { get; }

        public static bool operator ==(
            ModelEquatableStruct left,
            ModelEquatableStruct right)
        {
            var result =
                (left.Item1 == right.Item1) &&
                (left.Item2 == right.Item2);

            return result;
        }

        public static bool operator !=(
            ModelEquatableStruct left,
            ModelEquatableStruct right)
            => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelEquatableStruct other) => this == other;

        /// <inheritdoc />
        public override bool Equals(object obj) => (obj is ModelEquatableStruct other) && this.Equals(other);

        /// <inheritdoc />
        public override int GetHashCode() =>
            HashCodeHelper.Initialize()
                .Hash(this.Item1)
                .Hash(this.Item2)
                .Value;
    }
}
