﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomGenericClass{T}.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    [Serializable]
    public class CustomGenericClass<T> : IEquatable<CustomGenericClass<T>>, IDeepCloneable<CustomGenericClass<T>>, IComparable<CustomGenericClass<T>>
    {
        public CustomGenericClass(
            int item1,
            string item2,
            T item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public int Item1 { get; private set; }

        public string Item2 { get; private set; }

        public T Item3 { get; private set; }

        public static bool operator ==(
            CustomGenericClass<T> left,
            CustomGenericClass<T> right)
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
                (left.Item2 == right.Item2) &&
                left.Item3.IsEqualTo(right.Item3);

            return result;
        }

        public static bool operator !=(
            CustomGenericClass<T> left,
            CustomGenericClass<T> right)
            => !(left == right);

        public static bool operator <(
            CustomGenericClass<T> left,
            CustomGenericClass<T> right)
        {
            var result = Compare(left, right) < 0;

            return result;
        }

        public static bool operator >(
            CustomGenericClass<T> left,
            CustomGenericClass<T> right)
        {
            var result = Compare(left, right) > 0;

            return result;
        }

        [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Justification = "For testing purposes")]
        public static int Compare(
            CustomGenericClass<T> left,
            CustomGenericClass<T> right)
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
        public bool Equals(CustomGenericClass<T> other) => this == other;

        public int CompareTo(
            CustomGenericClass<T> other)
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
        public override bool Equals(object obj) => this == (obj as CustomGenericClass<T>);

        /// <inheritdoc />
        public override int GetHashCode() =>
            HashCodeHelper.Initialize()
                .Hash(this.Item1)
                .Hash(this.Item2)
                .Hash(this.Item3)
                .Value;

        public CustomGenericClass<T> DeepClone()
        {
            object item3Clone;

            var type = typeof(T);

            if (type.IsValueType)
            {
                item3Clone = this.Item3;
            }
            else
            {
                if (ReferenceEquals(this.Item3, null))
                {
                    item3Clone = default;
                }
                else if (this.Item3 is IDeepCloneable<T> deepCloneableValue)
                {
                    item3Clone = deepCloneableValue.DeepClone();
                }
                else if (this.Item3 is string stringValue)
                {
                    item3Clone = stringValue.DeepClone();
                }
                else if (this.Item3 is System.Version valueAsVersion)
                {
                    item3Clone = valueAsVersion.DeepClone();
                }
                else if (this.Item3 is System.Uri valueAsUri)
                {
                    item3Clone = valueAsUri.DeepClone();
                }
                else
                {
                    throw new NotSupportedException("I do not know how to deep clone object of type: " + type);
                }
            }

            var result = new CustomGenericClass<T>(this.Item1, this.Item2?.DeepClone(), (T)item3Clone);

            return result;
        }

        public object Clone() => this.DeepClone();
    }
}
