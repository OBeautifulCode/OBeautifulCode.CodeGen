// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomDerivedClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    [Serializable]
    public class CustomDerivedClass : CustomBaseClass, IModel<CustomDerivedClass>, IDeclareCompareToForRelativeSortOrderMethod<CustomDerivedClass>
    {
        public CustomDerivedClass(
            int baseItem1,
            string baseItem2,
            int derivedItem1,
            string derivedItem2)
            : base(baseItem1, baseItem2)
        {
            new { derivedItem2 }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.DerivedItem1 = derivedItem1;
            this.DerivedItem2 = derivedItem2;
        }

        public int DerivedItem1 { get; private set; }

        public string DerivedItem2 { get; private set; }

        public static bool operator ==(CustomDerivedClass left, CustomDerivedClass right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals(right);

            return result;
        }

        public static bool operator !=(CustomDerivedClass left, CustomDerivedClass right) => !(left == right);

        public static bool operator <(CustomDerivedClass left, CustomDerivedClass right)
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

        public static bool operator >(CustomDerivedClass left, CustomDerivedClass right)
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

        public static bool operator <=(CustomDerivedClass left, CustomDerivedClass right) => !(left > right);

        public static bool operator >=(CustomDerivedClass left, CustomDerivedClass right) => !(left < right);

        /// <inheritdoc />
        public bool Equals(CustomDerivedClass other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.BaseItem1.IsEqualTo(other.BaseItem1)
                      && this.BaseItem2.IsEqualTo(other.BaseItem2)
                      && this.DerivedItem1.IsEqualTo(other.DerivedItem1)
                      && this.DerivedItem2.IsEqualTo(other.DerivedItem2);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as CustomDerivedClass);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.BaseItem1)
            .Hash(this.BaseItem2)
            .Hash(this.DerivedItem1)
            .Hash(this.DerivedItem2)
            .Value;

        /// <inheritdoc />
        public new CustomDerivedClass DeepClone() => (CustomDerivedClass)this.DeepCloneInternal();

        /// <inheritdoc />
        public RelativeSortOrder CompareToForRelativeSortOrder(CustomDerivedClass other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            var thisText = this.BaseItem1 + this.BaseItem2 + this.DerivedItem1 + this.DerivedItem2;

            var otherText = other.BaseItem1 + other.BaseItem2 + other.DerivedItem1 + other.DerivedItem2;

            var comparison = string.Compare(thisText, otherText, StringComparison.Ordinal);

            if (comparison > 0)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }
            else if (comparison < 0)
            {
                return RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;
            }
            else
            {
                return RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance;
            }
        }

        public int CompareTo(CustomDerivedClass other)
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
        public override int CompareTo(object obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return 1;
            }

            if (!(obj is CustomDerivedClass other))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type 'CustomDerivedClass' whereas the other object is of type '{obj.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareTo(other);

            return result;
        }

        /// <inheritdoc />
        public override RelativeSortOrder CompareToForRelativeSortOrder(CustomBaseClass other)
        {
            if (ReferenceEquals(other, null))
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            if (!(other is CustomDerivedClass otherAsCustomDerivedClass))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type 'CustomDerivedClass' whereas the other object is of type '{other.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareToForRelativeSortOrder(otherAsCustomDerivedClass);

            return result;
        }

        /// <inheritdoc />
        protected override CustomBaseClass DeepCloneInternal()
        {
            var result = new CustomDerivedClass(
                this.BaseItem1,
                this.BaseItem2,
                this.DerivedItem1,
                this.DerivedItem2);

            return result;
        }
    }
}