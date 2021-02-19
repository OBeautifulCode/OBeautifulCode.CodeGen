// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomMultiBaseClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    [Serializable]
    public abstract class CustomMultiBaseClass : IModel<CustomMultiBaseClass>
    {
        protected CustomMultiBaseClass(
            int rootItem1,
            string rootItem2)
        {
            new { rootItem2 }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.RootItem1 = rootItem1;
            this.RootItem2 = rootItem2;
        }

        public int RootItem1 { get; private set; }

        public string RootItem2 { get; private set; }

        public static bool operator ==(CustomMultiBaseClass left, CustomMultiBaseClass right)
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

        public static bool operator !=(CustomMultiBaseClass left, CustomMultiBaseClass right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(CustomMultiBaseClass other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);

        /// <inheritdoc />
        public abstract override int GetHashCode();

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public CustomMultiBaseClass DeepClone() => this.DeepCloneInternal();

        protected abstract CustomMultiBaseClass DeepCloneInternal();
    }
}