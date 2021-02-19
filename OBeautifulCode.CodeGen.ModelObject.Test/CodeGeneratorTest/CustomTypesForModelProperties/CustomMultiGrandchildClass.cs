// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomMultiGrandchildClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    [Serializable]
    public class CustomMultiGrandchildClass : CustomMultiChildBaseClass, IModel<CustomMultiGrandchildClass>
    {
        public CustomMultiGrandchildClass(
            int rootItem1,
            string rootItem2,
            int childBaseItem1,
            string childBaseItem2,
            int grandchildItem1,
            string grandchildItem2)
            : base(rootItem1, rootItem2, childBaseItem1, childBaseItem2)
        {
            new { grandchildItem2 }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.GrandchildItem1 = grandchildItem1;
            this.GrandchildItem2 = grandchildItem2;
        }

        public int GrandchildItem1 { get; private set; }

        public string GrandchildItem2 { get; private set; }

        public static bool operator ==(CustomMultiGrandchildClass left, CustomMultiGrandchildClass right)
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

        public static bool operator !=(CustomMultiGrandchildClass left, CustomMultiGrandchildClass right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(CustomMultiGrandchildClass other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.RootItem1.IsEqualTo(other.RootItem1)
                      && this.RootItem2.IsEqualTo(other.RootItem2)
                      && this.ChildBaseItem1.IsEqualTo(other.ChildBaseItem1)
                      && this.ChildBaseItem2.IsEqualTo(other.ChildBaseItem2)
                      && this.GrandchildItem1.IsEqualTo(other.GrandchildItem1)
                      && this.GrandchildItem2.IsEqualTo(other.GrandchildItem2);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as CustomMultiGrandchildClass);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.RootItem1)
            .Hash(this.RootItem2)
            .Hash(this.ChildBaseItem1)
            .Hash(this.ChildBaseItem2)
            .Hash(this.GrandchildItem1)
            .Hash(this.GrandchildItem2)
            .Value;

        /// <inheritdoc />
        public new CustomMultiGrandchildClass DeepClone() => (CustomMultiGrandchildClass)this.DeepCloneInternal();

        /// <inheritdoc />
        protected override CustomMultiBaseClass DeepCloneInternal()
        {
            var result = new CustomMultiGrandchildClass(
                this.RootItem1,
                this.RootItem2,
                this.ChildBaseItem1,
                this.ChildBaseItem2,
                this.GrandchildItem1,
                this.GrandchildItem2);

            return result;
        }
    }
}