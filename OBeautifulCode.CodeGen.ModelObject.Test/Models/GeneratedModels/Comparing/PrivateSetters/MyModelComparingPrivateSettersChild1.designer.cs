// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;

    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    public partial class MyModelComparingPrivateSettersChild1 : IComparableForRelativeSortOrder<MyModelComparingPrivateSettersChild1>
    {
        /// <summary>
        /// Determines whether an object of type <see cref="MyModelComparingPrivateSettersChild1"/> is less than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than operator.</param>
        /// <param name="right">The object to the right of the less-than operator.</param>
        /// <returns>true if <paramref name="left"/> is less than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <(MyModelComparingPrivateSettersChild1 left, MyModelComparingPrivateSettersChild1 right)
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

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelComparingPrivateSettersChild1"/> is greater than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than operator.</param>
        /// <param name="right">The object to the right of the greater-than operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >(MyModelComparingPrivateSettersChild1 left, MyModelComparingPrivateSettersChild1 right)
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

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelComparingPrivateSettersChild1"/> is less than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the less-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is less than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <=(MyModelComparingPrivateSettersChild1 left, MyModelComparingPrivateSettersChild1 right) => !(left > right);

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelComparingPrivateSettersChild1"/> is greater than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the greater-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >=(MyModelComparingPrivateSettersChild1 left, MyModelComparingPrivateSettersChild1 right) => !(left < right);

        /// <inheritdoc />
        public int CompareTo(MyModelComparingPrivateSettersChild1 other)
        {
            if (ReferenceEquals(other, null))
            {
                return 1;
            }

            var relativeSortOrder = this.CompareToForRelativeSortOrder(other);

            switch(relativeSortOrder)
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

            if (!(obj is MyModelComparingPrivateSettersChild1 other))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type 'MyModelComparingPrivateSettersChild1' whereas the other object is of type '{obj.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareTo(other);

            return result;
        }

        /// <inheritdoc />
        public override RelativeSortOrder CompareToForRelativeSortOrder(MyModelComparingPrivateSettersParent other)
        {
            if (ReferenceEquals(other, null))
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            if (!(other is MyModelComparingPrivateSettersChild1 otherAsMyModelComparingPrivateSettersChild1))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type 'MyModelComparingPrivateSettersChild1' whereas the other object is of type '{other.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareToForRelativeSortOrder(otherAsMyModelComparingPrivateSettersChild1);

            return result;
        }
    }
}