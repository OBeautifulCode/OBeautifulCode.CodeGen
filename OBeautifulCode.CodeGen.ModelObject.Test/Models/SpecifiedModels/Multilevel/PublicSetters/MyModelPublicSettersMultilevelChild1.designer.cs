// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;

    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    public partial class MyModelPublicSettersMultilevelChild1 : IModel<MyModelPublicSettersMultilevelChild1>, IComparableForRelativeSortOrder<MyModelPublicSettersMultilevelChild1>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPublicSettersMultilevelChild1"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPublicSettersMultilevelChild1 left, MyModelPublicSettersMultilevelChild1 right)
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
        /// Determines whether two objects of type <see cref="MyModelPublicSettersMultilevelChild1"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPublicSettersMultilevelChild1 left, MyModelPublicSettersMultilevelChild1 right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPublicSettersMultilevelChild1 other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelChild1"/> is less than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than operator.</param>
        /// <param name="right">The object to the right of the less-than operator.</param>
        /// <returns>true if <paramref name="left"/> is less than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <(MyModelPublicSettersMultilevelChild1 left, MyModelPublicSettersMultilevelChild1 right)
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
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelChild1"/> is greater than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than operator.</param>
        /// <param name="right">The object to the right of the greater-than operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >(MyModelPublicSettersMultilevelChild1 left, MyModelPublicSettersMultilevelChild1 right)
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
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelChild1"/> is less than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the less-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is less than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <=(MyModelPublicSettersMultilevelChild1 left, MyModelPublicSettersMultilevelChild1 right) => !(left > right);

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelChild1"/> is greater than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the greater-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >=(MyModelPublicSettersMultilevelChild1 left, MyModelPublicSettersMultilevelChild1 right) => !(left < right);

        /// <inheritdoc />
        public int CompareTo(MyModelPublicSettersMultilevelChild1 other)
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
        public abstract RelativeSortOrder CompareToForRelativeSortOrder(MyModelPublicSettersMultilevelChild1 other);

        /// <inheritdoc />
        public abstract override int GetHashCode();

        /// <inheritdoc />
        public new MyModelPublicSettersMultilevelChild1 DeepClone() => (MyModelPublicSettersMultilevelChild1)this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="Child1Int" />.
        /// </summary>
        /// <param name="child1Int">The new <see cref="Child1Int" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPublicSettersMultilevelChild1" /> using the specified <paramref name="child1Int" /> for <see cref="Child1Int" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public abstract MyModelPublicSettersMultilevelChild1 DeepCloneWithChild1Int(int child1Int);

        /// <inheritdoc />
        public abstract override string ToString();
    }
}