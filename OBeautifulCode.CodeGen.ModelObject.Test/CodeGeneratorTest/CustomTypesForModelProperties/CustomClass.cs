// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    public class CustomClass : IEquatable<CustomClass>, IDeepCloneable<CustomClass>, IComparable<CustomClass>
    {
        public CustomClass(
            int item1,
            string item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public int Item1 { get; private set; }

        public string Item2 { get; private set; }

        public static bool operator ==(
            CustomClass left,
            CustomClass right)
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
            CustomClass left,
            CustomClass right)
            => !(left == right);

        public static bool operator <(
            CustomClass left,
            CustomClass right)
        {
            var result = Compare(left, right) < 0;

            return result;
        }

        public static bool operator >(
            CustomClass left,
            CustomClass right)
        {
            var result = Compare(left, right) > 0;

            return result;
        }

        public static int Compare(
            CustomClass left,
            CustomClass right)
        {
            if (ReferenceEquals(left, right))
            {
                return 0;
            }

            if (ReferenceEquals(left, null))
            {
                return -1;
            }

            var result = left.CompareTo(right);

            return result;
        }

        /// <inheritdoc />
        public bool Equals(CustomClass other) => this == other;

        public int CompareTo(
            CustomClass other)
        {
            if (ReferenceEquals(other, null))
            {
                return 1;
            }

            var thisString = this.Item1 + this.Item2;
            var otherString = other.Item1 + other.Item2;

            var result = string.Compare(thisString, otherString, StringComparison.Ordinal);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as CustomClass);

        /// <inheritdoc />
        public override int GetHashCode() =>
            HashCodeHelper.Initialize()
                .Hash(this.Item1)
                .Hash(this.Item2)
                .Value;

        public CustomClass DeepClone()
        {
            var result = new CustomClass(this.Item1, this.Item2?.Clone().ToString());

            return result;
        }

        public object Clone() => this.DeepClone();
    }
}
