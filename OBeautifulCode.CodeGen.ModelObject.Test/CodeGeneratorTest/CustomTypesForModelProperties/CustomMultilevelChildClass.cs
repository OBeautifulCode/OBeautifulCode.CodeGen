﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomMultilevelChildClass.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    [Serializable]
    public class CustomMultilevelChildClass : CustomMultilevelBaseClass, IModel<CustomMultilevelChildClass>
    {
        public CustomMultilevelChildClass(
            int rootItem1,
            string rootItem2,
            int childItem1,
            string childItem2)
            : base(rootItem1, rootItem2)
        {
            new { childItem2 }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.ChildItem1 = childItem1;
            this.ChildItem2 = childItem2;
        }

        public int ChildItem1 { get; private set; }

        public string ChildItem2 { get; private set; }

        public static bool operator ==(CustomMultilevelChildClass left, CustomMultilevelChildClass right)
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

        public static bool operator !=(CustomMultilevelChildClass left, CustomMultilevelChildClass right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(CustomMultilevelChildClass other)
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
                      && this.ChildItem1.IsEqualTo(other.ChildItem1)
                      && this.ChildItem2.IsEqualTo(other.ChildItem2);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as CustomMultilevelChildClass);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.RootItem1)
            .Hash(this.RootItem2)
            .Hash(this.ChildItem1)
            .Hash(this.ChildItem2)
            .Value;

        /// <inheritdoc />
        public new CustomMultilevelChildClass DeepClone() => (CustomMultilevelChildClass)this.DeepCloneInternal();

        /// <inheritdoc />
        protected override CustomMultilevelBaseClass DeepCloneInternal()
        {
            var result = new CustomMultilevelChildClass(
                this.RootItem1,
                this.RootItem2,
                this.ChildItem1,
                this.ChildItem2);

            return result;
        }
    }
}