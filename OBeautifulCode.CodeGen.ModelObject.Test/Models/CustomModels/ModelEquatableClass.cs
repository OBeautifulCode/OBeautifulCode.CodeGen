// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEquatableClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    using OBeautifulCode.Equality.Recipes;

    public class ModelEquatableClass : IEquatable<ModelEquatableClass>
    {
        public ModelEquatableClass(
            int item1,
            string item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public int Item1 { get; }

        public string Item2 { get; }

        public static bool operator ==(
            ModelEquatableClass left,
            ModelEquatableClass right)
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
            ModelEquatableClass left,
            ModelEquatableClass right)
            => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelEquatableClass other) => this == other;

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModelEquatableClass);

        /// <inheritdoc />
        public override int GetHashCode() =>
            HashCodeHelper.Initialize()
                .Hash(this.Item1)
                .Hash(this.Item2)
                .Value;
    }
}
