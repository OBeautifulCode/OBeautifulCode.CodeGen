// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    public class ModelClass : IEquatable<ModelClass>, IDeepCloneable<ModelClass>
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

        public static bool operator ==(
            ModelClass left,
            ModelClass right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result =
                (left.Item1 == right.Item1) &&
                (left.Item2 == right.Item2);
            return result;
        }

        public static bool operator !=(
            ModelClass left,
            ModelClass right)
            => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelClass other) => this == other;

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModelClass);

        /// <inheritdoc />
        public override int GetHashCode() =>
            HashCodeHelper.Initialize()
                .Hash(this.Item1)
                .Hash(this.Item2)
                .Value;

        public ModelClass DeepClone()
        {
            var result = new ModelClass(this.Item1, this.Item2?.Clone().ToString());

            return result;
        }

        public object Clone() => this.DeepClone();
    }
}
