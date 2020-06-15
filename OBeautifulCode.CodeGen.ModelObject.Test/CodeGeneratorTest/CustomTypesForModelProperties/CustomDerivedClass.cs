// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomDerivedClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    public class CustomDerivedClass : CustomBaseClass, IModel<CustomDerivedClass>
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

        /// <summary>
        /// Determines whether two objects of type <see cref="CustomDerivedClass"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
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

        /// <summary>
        /// Determines whether two objects of type <see cref="CustomDerivedClass"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(CustomDerivedClass left, CustomDerivedClass right) => !(left == right);

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