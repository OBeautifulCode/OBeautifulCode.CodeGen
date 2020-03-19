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

    public partial class MyModelPublicSettersMultilevelGrandchild1B : IModel<MyModelPublicSettersMultilevelGrandchild1B>, IComparableForRelativeSortOrder<MyModelPublicSettersMultilevelGrandchild1B>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPublicSettersMultilevelGrandchild1B"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPublicSettersMultilevelGrandchild1B left, MyModelPublicSettersMultilevelGrandchild1B right)
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

        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPublicSettersMultilevelGrandchild1B"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPublicSettersMultilevelGrandchild1B left, MyModelPublicSettersMultilevelGrandchild1B right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPublicSettersMultilevelGrandchild1B other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ParentInt.IsEqualTo(other.ParentInt)
                      && this.Child1Int.IsEqualTo(other.Child1Int)
                      && this.Grandchild1BInt.IsEqualTo(other.Grandchild1BInt);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as MyModelPublicSettersMultilevelGrandchild1B);

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelGrandchild1B"/> is less than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than operator.</param>
        /// <param name="right">The object to the right of the less-than operator.</param>
        /// <returns>true if <paramref name="left"/> is less than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <(MyModelPublicSettersMultilevelGrandchild1B left, MyModelPublicSettersMultilevelGrandchild1B right)
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
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelGrandchild1B"/> is greater than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than operator.</param>
        /// <param name="right">The object to the right of the greater-than operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >(MyModelPublicSettersMultilevelGrandchild1B left, MyModelPublicSettersMultilevelGrandchild1B right)
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
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelGrandchild1B"/> is less than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the less-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is less than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <=(MyModelPublicSettersMultilevelGrandchild1B left, MyModelPublicSettersMultilevelGrandchild1B right) => !(left > right);

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelPublicSettersMultilevelGrandchild1B"/> is greater than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the greater-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >=(MyModelPublicSettersMultilevelGrandchild1B left, MyModelPublicSettersMultilevelGrandchild1B right) => !(left < right);

        /// <inheritdoc />
        public int CompareTo(MyModelPublicSettersMultilevelGrandchild1B other)
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

            if (!(obj is MyModelPublicSettersMultilevelGrandchild1B other))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type 'MyModelPublicSettersMultilevelGrandchild1B' whereas the other object is of type '{obj.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareTo(other);

            return result;
        }

        /// <inheritdoc />
        public override RelativeSortOrder CompareToForRelativeSortOrder(MyModelPublicSettersMultilevelParent other)
        {
            if (ReferenceEquals(other, null))
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            if (!(other is MyModelPublicSettersMultilevelGrandchild1B otherAsMyModelPublicSettersMultilevelGrandchild1B))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type 'MyModelPublicSettersMultilevelGrandchild1B' whereas the other object is of type '{other.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareToForRelativeSortOrder(otherAsMyModelPublicSettersMultilevelGrandchild1B);

            return result;
        }

        /// <inheritdoc />
        public override RelativeSortOrder CompareToForRelativeSortOrder(MyModelPublicSettersMultilevelChild1 other)
        {
            if (ReferenceEquals(other, null))
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            if (!(other is MyModelPublicSettersMultilevelGrandchild1B otherAsMyModelPublicSettersMultilevelGrandchild1B))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type 'MyModelPublicSettersMultilevelGrandchild1B' whereas the other object is of type '{other.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareToForRelativeSortOrder(otherAsMyModelPublicSettersMultilevelGrandchild1B);

            return result;
        }

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ParentInt)
            .Hash(this.Child1Int)
            .Hash(this.Grandchild1BInt)
            .Value;

        /// <inheritdoc />
        public new MyModelPublicSettersMultilevelGrandchild1B DeepClone() => (MyModelPublicSettersMultilevelGrandchild1B)this.DeepCloneInternal();

        /// <inheritdoc />
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
        public override MyModelPublicSettersMultilevelParent DeepCloneWithParentInt(int parentInt)
        {
            var result = new MyModelPublicSettersMultilevelGrandchild1B
                             {
                                 ParentInt       = parentInt,
                                 Child1Int       = this.Child1Int,
                                 Grandchild1BInt = this.Grandchild1BInt,
                             };

            return result;
        }

        /// <inheritdoc />
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
        public override MyModelPublicSettersMultilevelChild1 DeepCloneWithChild1Int(int child1Int)
        {
            var result = new MyModelPublicSettersMultilevelGrandchild1B
                             {
                                 ParentInt       = this.ParentInt,
                                 Child1Int       = child1Int,
                                 Grandchild1BInt = this.Grandchild1BInt,
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Grandchild1BInt" />.
        /// </summary>
        /// <param name="grandchild1BInt">The new <see cref="Grandchild1BInt" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPublicSettersMultilevelGrandchild1B" /> using the specified <paramref name="grandchild1BInt" /> for <see cref="Grandchild1BInt" /> and a deep clone of every other property.</returns>
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
        public MyModelPublicSettersMultilevelGrandchild1B DeepCloneWithGrandchild1BInt(int grandchild1BInt)
        {
            var result = new MyModelPublicSettersMultilevelGrandchild1B
                             {
                                 ParentInt       = this.ParentInt,
                                 Child1Int       = this.Child1Int,
                                 Grandchild1BInt = grandchild1BInt,
                             };

            return result;
        }

        /// <inheritdoc />
        protected override MyModelPublicSettersMultilevelParent DeepCloneInternal()
        {
            var result = new MyModelPublicSettersMultilevelGrandchild1B
                             {
                                 ParentInt       = this.ParentInt,
                                 Child1Int       = this.Child1Int,
                                 Grandchild1BInt = this.Grandchild1BInt,
                             };

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.MyModelPublicSettersMultilevelGrandchild1B: ParentInt = {this.ParentInt.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Child1Int = {this.Child1Int.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Grandchild1BInt = {this.Grandchild1BInt.ToString(CultureInfo.InvariantCulture) ?? "<null>"}.");

            return result;
        }
    }
}