// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomBaseClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    [Serializable]
    public abstract class CustomBaseClass : IModel<CustomBaseClass>, IComparableForRelativeSortOrder<CustomBaseClass>
    {
        protected CustomBaseClass(
            int baseItem1,
            string baseItem2)
        {
            new { baseItem2 }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.BaseItem1 = baseItem1;
            this.BaseItem2 = baseItem2;
        }

        public int BaseItem1 { get; private set; }

        public string BaseItem2 { get; private set; }

        public static bool operator ==(CustomBaseClass left, CustomBaseClass right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals((object)right);

            return result;
        }

        public static bool operator !=(CustomBaseClass left, CustomBaseClass right) => !(left == right);

        public static bool operator <(CustomBaseClass left, CustomBaseClass right)
        {
            if (ReferenceEquals(left, right))
            {
                return false;
            }

            if (ReferenceEquals(left, null))
            {
                return true;
            }

            if (ReferenceEquals(right, null))
            {
                return false;
            }

            if (left.GetType() != right.GetType())
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  The left operand is of type '{left.GetType().ToStringReadable()}' whereas the right operand is of type '{right.GetType().ToStringReadable()}'."));
            }

            var relativeSortOrder = left.CompareToForRelativeSortOrder(right);

            var result = relativeSortOrder == RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;

            return result;
        }

        public static bool operator >(CustomBaseClass left, CustomBaseClass right)
        {
            if (ReferenceEquals(left, right))
            {
                return false;
            }

            if (ReferenceEquals(left, null))
            {
                return false;
            }

            if (ReferenceEquals(right, null))
            {
                return true;
            }

            if (left.GetType() != right.GetType())
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  The left operand is of type '{left.GetType().ToStringReadable()}' whereas the right operand is of type '{right.GetType().ToStringReadable()}'."));
            }

            var relativeSortOrder = left.CompareToForRelativeSortOrder(right);

            var result = relativeSortOrder == RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;

            return result;
        }

        public static bool operator <=(CustomBaseClass left, CustomBaseClass right) => !(left > right);

        public static bool operator >=(CustomBaseClass left, CustomBaseClass right) => !(left < right);

        /// <inheritdoc />
        public bool Equals(CustomBaseClass other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);

        /// <inheritdoc />
        public abstract override int GetHashCode();

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public CustomBaseClass DeepClone() => this.DeepCloneInternal();

        /// <inheritdoc />
        public int CompareTo(CustomBaseClass other)
        {
            if (ReferenceEquals(other, null))
            {
                return 1;
            }

            var relativeSortOrder = this.CompareToForRelativeSortOrder(other);

            switch (relativeSortOrder)
            {
                case RelativeSortOrder.ThisInstancePrecedesTheOtherInstance:
                    return -1;
                case RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance:
                    return 0;
                case RelativeSortOrder.ThisInstanceFollowsTheOtherInstance:
                    return 1;
                default:
                    throw new NotSupportedException(Invariant($"This {nameof(RelativeSortOrder)} is not supported: {relativeSortOrder}."));
            }
        }

        /// <inheritdoc />
        public abstract int CompareTo(object obj);

        /// <inheritdoc />
        public abstract RelativeSortOrder CompareToForRelativeSortOrder(CustomBaseClass other);

        protected abstract CustomBaseClass DeepCloneInternal();
    }
}