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

    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.0.0")]
    public partial class MyModelPublicSettersMultilevelParent : IModel<MyModelPublicSettersMultilevelParent>, IComparableForRelativeSortOrder<MyModelPublicSettersMultilevelParent>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPublicSettersMultilevelParent"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPublicSettersMultilevelParent left, MyModelPublicSettersMultilevelParent right)
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

        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPublicSettersMultilevelParent"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPublicSettersMultilevelParent left, MyModelPublicSettersMultilevelParent right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPublicSettersMultilevelParent other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelParent"/> is less than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than operator.</param>
        /// <param name="right">The object to the right of the less-than operator.</param>
        /// <returns>true if <paramref name="left"/> is less than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <(MyModelPublicSettersMultilevelParent left, MyModelPublicSettersMultilevelParent right)
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
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelParent"/> is greater than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than operator.</param>
        /// <param name="right">The object to the right of the greater-than operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >(MyModelPublicSettersMultilevelParent left, MyModelPublicSettersMultilevelParent right)
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
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelParent"/> is less than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the less-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is less than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <=(MyModelPublicSettersMultilevelParent left, MyModelPublicSettersMultilevelParent right) => !(left > right);

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelParent"/> is greater than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the greater-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >=(MyModelPublicSettersMultilevelParent left, MyModelPublicSettersMultilevelParent right) => !(left < right);

        /// <inheritdoc />
        public int CompareTo(MyModelPublicSettersMultilevelParent other)
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
        public abstract int CompareTo(object obj);

        /// <inheritdoc />
        public abstract RelativeSortOrder CompareToForRelativeSortOrder(MyModelPublicSettersMultilevelParent other);

        /// <inheritdoc />
        public abstract override int GetHashCode();

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public MyModelPublicSettersMultilevelParent DeepClone() => this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentInt" />.
        /// </summary>
        /// <param name="parentInt">The new <see cref="ParentInt" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPublicSettersMultilevelParent" /> using the specified <paramref name="parentInt" /> for <see cref="ParentInt" /> and a deep clone of every other property.</returns>
        public abstract MyModelPublicSettersMultilevelParent DeepCloneWithParentInt(int parentInt);

        /// <summary>
        /// Creates a new object that is a deep clone of this instance.
        /// </summary>
        /// <returns>
        /// A new object that is a deep clone of this instance.
        /// </returns>
        protected abstract MyModelPublicSettersMultilevelParent DeepCloneInternal();

        /// <inheritdoc />
        public abstract override string ToString();
    }
}