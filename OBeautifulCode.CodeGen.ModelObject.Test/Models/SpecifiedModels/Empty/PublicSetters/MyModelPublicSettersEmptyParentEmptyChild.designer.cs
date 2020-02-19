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

    public partial class MyModelPublicSettersEmptyParentEmptyChild : IModel<MyModelPublicSettersEmptyParentEmptyChild>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPublicSettersEmptyParentEmptyChild"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPublicSettersEmptyParentEmptyChild left, MyModelPublicSettersEmptyParentEmptyChild right)
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
        /// Determines whether two objects of type <see cref="MyModelPublicSettersEmptyParentEmptyChild"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPublicSettersEmptyParentEmptyChild left, MyModelPublicSettersEmptyParentEmptyChild right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPublicSettersEmptyParentEmptyChild other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = true;

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as MyModelPublicSettersEmptyParentEmptyChild);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Value;

        /// <inheritdoc />
        public new MyModelPublicSettersEmptyParentEmptyChild DeepClone() => (MyModelPublicSettersEmptyParentEmptyChild)this.DeepCloneInternal();

        /// <inheritdoc />
        protected override MyModelPublicSettersEmptyParent DeepCloneInternal()
        {
            var result = new MyModelPublicSettersEmptyParentEmptyChild();

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"{nameof(OBeautifulCode.CodeGen.ModelObject.Test)}.{nameof(MyModelPublicSettersEmptyParentEmptyChild)}: <no properties>.");

            return result;
        }
    }
}