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
    public partial class MyModelComparingPrivateSettersChild2 : IComparableForRelativeSortOrder<MyModelComparingPrivateSettersChild2>
    {
        /// <summary>
        /// Determines whether an object of type <see cref="MyModelComparingPrivateSettersChild2"/> is less than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than operator.</param>
        /// <param name="right">The object to the right of the less-than operator.</param>
        /// <returns>true if <paramref name="left"/> is less than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <(MyModelComparingPrivateSettersChild2 left, MyModelComparingPrivateSettersChild2 right)
        {
            if (ReferenceEquals(left, right))
            {
                return false;
            }

            if (ReferenceEquals(left, null))
            {
                return true;
            }

            var relativeSortOrder = left.CompareToForRelativeSortOrder(right);

            var result = relativeSortOrder == RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;

            return result;
        }

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelComparingPrivateSettersChild2"/> is greater than another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than operator.</param>
        /// <param name="right">The object to the right of the greater-than operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >(MyModelComparingPrivateSettersChild2 left, MyModelComparingPrivateSettersChild2 right)
        {
            if (ReferenceEquals(left, right))
            {
                return false;
            }

            if (ReferenceEquals(left, null))
            {
                return false;
            }

            var relativeSortOrder = left.CompareToForRelativeSortOrder(right);

            var result = relativeSortOrder == RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;

            return result;
        }

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelComparingPrivateSettersChild2"/> is less than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the less-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the less-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is less than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator <=(MyModelComparingPrivateSettersChild2 left, MyModelComparingPrivateSettersChild2 right) => !(left > right);

        /// <summary>
        /// Determines whether an object of type <see cref="MyModelComparingPrivateSettersChild2"/> is greater than or equal to another object of that type.
        /// </summary>
        /// <param name="left">The object to the left of the greater-than-or-equal-to operator.</param>
        /// <param name="right">The object to the right of the greater-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; otherwise false.</returns>
        public static bool operator >=(MyModelComparingPrivateSettersChild2 left, MyModelComparingPrivateSettersChild2 right) => !(left < right);

        /// <inheritdoc />
        public int CompareTo(MyModelComparingPrivateSettersChild2 other)
        {
            if (other == null)
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
            if (!(obj is MyModelComparingPrivateSettersChild2 other))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type '{nameof(MyModelComparingPrivateSettersChild2)}' whereas the other object is of type '{obj.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareTo(other);

            return result;
        }

        public override RelativeSortOrder CompareToForRelativeSortOrder(MyModelComparingPrivateSettersParent other)
        {
            if (!(other is MyModelComparingPrivateSettersChild2 otherAsMyModelComparingPrivateSettersChild2))
            {
                throw new ArgumentException(Invariant($"Attempting to compare objects of different types.  This object is of type '{nameof(MyModelComparingPrivateSettersChild2)}' whereas the other object is of type '{other.GetType().ToStringReadable()}'."));
            }

            var result = this.CompareToForRelativeSortOrder(otherAsMyModelComparingPrivateSettersChild2);

            return result;
        }
    }
}