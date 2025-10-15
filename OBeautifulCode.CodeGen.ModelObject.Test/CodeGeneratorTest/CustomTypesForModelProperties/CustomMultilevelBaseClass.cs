// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomMultilevelBaseClass.cs" company="OBeautifulCode">
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
    public abstract class CustomMultilevelBaseClass : IModel<CustomMultilevelBaseClass>
    {
        protected CustomMultilevelBaseClass(
            int rootItem1,
            string rootItem2)
        {
            new { rootItem2 }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.RootItem1 = rootItem1;
            this.RootItem2 = rootItem2;
        }

        public int RootItem1 { get; private set; }

        public string RootItem2 { get; private set; }

        public static bool operator ==(CustomMultilevelBaseClass left, CustomMultilevelBaseClass right)
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

        public static bool operator !=(CustomMultilevelBaseClass left, CustomMultilevelBaseClass right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(CustomMultilevelBaseClass other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);

        /// <inheritdoc />
        public abstract override int GetHashCode();

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public CustomMultilevelBaseClass DeepClone() => this.DeepCloneInternal();

        /// <inheritdoc />
        public virtual IReadOnlyList<SelfValidationFailure> GetSelfValidationFailures()
        {
            var result = new SelfValidationFailure[0];

            return result;
        }

        /// <inheritdoc />
        public abstract IReadOnlyList<ValidationFailure> GetValidationFailures(ValidationOptions options = null, PropertyPathTracker propertyPathTracker = null);

        protected abstract CustomMultilevelBaseClass DeepCloneInternal();
    }
}