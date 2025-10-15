// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomMultilevelChildBaseClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    [Serializable]
    public abstract class CustomMultilevelChildBaseClass : CustomMultilevelBaseClass, IModel<CustomMultilevelChildBaseClass>
    {
        protected CustomMultilevelChildBaseClass(
            int rootItem1,
            string rootItem2,
            int childBaseItem1,
            string childBaseItem2)
            : base(rootItem1, rootItem2)
        {
            new { childBaseItem2 }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.ChildBaseItem1 = childBaseItem1;
            this.ChildBaseItem2 = childBaseItem2;
        }

        public int ChildBaseItem1 { get; private set; }

        public string ChildBaseItem2 { get; private set; }

        public static bool operator ==(CustomMultilevelChildBaseClass left, CustomMultilevelChildBaseClass right)
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

        public static bool operator !=(CustomMultilevelChildBaseClass left, CustomMultilevelChildBaseClass right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(CustomMultilevelChildBaseClass other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);

        /// <inheritdoc />
        public abstract override int GetHashCode();

        /// <inheritdoc />
        public new CustomMultilevelChildBaseClass DeepClone() => (CustomMultilevelChildBaseClass)this.DeepCloneInternal();

        /// <inheritdoc />
        public override IReadOnlyList<SelfValidationFailure> GetSelfValidationFailures()
        {
            var result = base.GetSelfValidationFailures();

            return result;
        }
    }
}