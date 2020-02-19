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
    public partial class MyModelPrivateSettersMultilevelGrandChild2A : IModel<MyModelPrivateSettersMultilevelGrandChild2A>, IComparableForRelativeSortOrder<MyModelPrivateSettersMultilevelGrandChild2A>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersMultilevelGrandChild2A"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPrivateSettersMultilevelGrandChild2A left, MyModelPrivateSettersMultilevelGrandChild2A right)
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
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersMultilevelGrandChild2A"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPrivateSettersMultilevelGrandChild2A left, MyModelPrivateSettersMultilevelGrandChild2A right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPrivateSettersMultilevelGrandChild2A other)
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
                      && this.Child2Int.IsEqualTo(other.Child2Int)
                      && this.GrandChild2AInt.IsEqualTo(other.GrandChild2AInt);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as MyModelPrivateSettersMultilevelGrandChild2A);

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelPrivateSettersMultilevelGrandChild2A"/> is less than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than operator.</param>
        /// <param name="right">The object to the right of the less-than operator.</param>
        /// <returns>true if <paramref name="left"/> is less than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <(MyModelPrivateSettersMultilevelGrandChild2A left, MyModelPrivateSettersMultilevelGrandChild2A right)
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
        /// Determines whether an object of type <see cref="MyModelPrivateSettersMultilevelGrandChild2A"/> is greater than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than operator.</param>
        /// <param name="right">The object to the right of the greater-than operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >(MyModelPrivateSettersMultilevelGrandChild2A left, MyModelPrivateSettersMultilevelGrandChild2A right)
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
        /// Determines whether an object of type <see cref="MyModelPrivateSettersMultilevelGrandChild2A"/> is less than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the less-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is less than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <=(MyModelPrivateSettersMultilevelGrandChild2A left, MyModelPrivateSettersMultilevelGrandChild2A right) => !(left > right);

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelPrivateSettersMultilevelGrandChild2A"/> is greater than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the greater-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >=(MyModelPrivateSettersMultilevelGrandChild2A left, MyModelPrivateSettersMultilevelGrandChild2A right) => !(left < right);

        /// <inheritdoc />
        public int CompareTo(MyModelPrivateSettersMultilevelGrandChild2A other)
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

            if (!(obj is MyModelPrivateSettersMultilevelGrandChild2A other))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type '{nameof(MyModelPrivateSettersMultilevelGrandChild2A)}' whereas the other object is of type '{obj.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareTo(other);

            return result;
        }

        /// <inheritdoc />
        public override RelativeSortOrder CompareToForRelativeSortOrder(MyModelPrivateSettersMultilevelParent other)
        {
            if (ReferenceEquals(other, null))
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            if (!(other is MyModelPrivateSettersMultilevelGrandChild2A otherAsMyModelPrivateSettersMultilevelGrandChild2A))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type '{nameof(MyModelPrivateSettersMultilevelGrandChild2A)}' whereas the other object is of type '{other.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareToForRelativeSortOrder(otherAsMyModelPrivateSettersMultilevelGrandChild2A);

            return result;
        }

        /// <inheritdoc />
        public override RelativeSortOrder CompareToForRelativeSortOrder(MyModelPrivateSettersMultilevelChild2 other)
        {
            if (ReferenceEquals(other, null))
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            if (!(other is MyModelPrivateSettersMultilevelGrandChild2A otherAsMyModelPrivateSettersMultilevelGrandChild2A))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type '{nameof(MyModelPrivateSettersMultilevelGrandChild2A)}' whereas the other object is of type '{other.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareToForRelativeSortOrder(otherAsMyModelPrivateSettersMultilevelGrandChild2A);

            return result;
        }

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ParentInt)
            .Hash(this.Child2Int)
            .Hash(this.GrandChild2AInt)
            .Value;

        /// <inheritdoc />
        public new MyModelPrivateSettersMultilevelGrandChild2A DeepClone() => (MyModelPrivateSettersMultilevelGrandChild2A)this.DeepCloneInternal();

        /// <inheritdoc />
        public override MyModelPrivateSettersMultilevelParent DeepCloneWithParentInt(int parentInt)
        {
            var result = new MyModelPrivateSettersMultilevelGrandChild2A(
                                 parentInt,
                                 this.Child2Int,
                                 this.GrandChild2AInt);

            return result;
        }

        /// <inheritdoc />
        public override MyModelPrivateSettersMultilevelChild2 DeepCloneWithChild2Int(int child2Int)
        {
            var result = new MyModelPrivateSettersMultilevelGrandChild2A(
                                 this.ParentInt,
                                 child2Int,
                                 this.GrandChild2AInt);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="GrandChild2AInt" />.
        /// </summary>
        /// <param name="grandChild2AInt">The new <see cref="GrandChild2AInt" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersMultilevelGrandChild2A" /> using the specified <paramref name="grandChild2AInt" /> for <see cref="GrandChild2AInt" /> and a deep clone of every other property.</returns>
        public MyModelPrivateSettersMultilevelGrandChild2A DeepCloneWithGrandChild2AInt(int grandChild2AInt)
        {
            var result = new MyModelPrivateSettersMultilevelGrandChild2A(
                                 this.ParentInt,
                                 this.Child2Int,
                                 grandChild2AInt);

            return result;
        }

        /// <inheritdoc />
        protected override MyModelPrivateSettersMultilevelParent DeepCloneInternal()
        {
            var result = new MyModelPrivateSettersMultilevelGrandChild2A(
                                 this.ParentInt,
                                 this.Child2Int,
                                 this.GrandChild2AInt);

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"{nameof(OBeautifulCode.CodeGen.ModelObject.Test)}.{nameof(MyModelPrivateSettersMultilevelGrandChild2A)}: ParentInt = {this.ParentInt.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Child2Int = {this.Child2Int.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, GrandChild2AInt = {this.GrandChild2AInt.ToString(CultureInfo.InvariantCulture) ?? "<null>"}.");

            return result;
        }
    }
}