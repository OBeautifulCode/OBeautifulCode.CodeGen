// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomBaseClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public abstract class CustomBaseClass : IModel<CustomBaseClass>
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

        /// <summary>
        /// Determines whether two objects of type <see cref="CustomBaseClass"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
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

        /// <summary>
        /// Determines whether two objects of type <see cref="CustomBaseClass"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(CustomBaseClass left, CustomBaseClass right) => !(left == right);

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

        /// <summary>
        /// Creates a new object that is a deep clone of this instance.
        /// </summary>
        /// <returns>
        /// A new object that is a deep clone of this instance.
        /// </returns>
        protected abstract CustomBaseClass DeepCloneInternal();
    }
}