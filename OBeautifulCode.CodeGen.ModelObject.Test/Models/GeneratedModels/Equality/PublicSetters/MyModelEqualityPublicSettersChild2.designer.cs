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

    public partial class MyModelEqualityPublicSettersChild2 : IEquatable<MyModelEqualityPublicSettersChild2>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelEqualityPublicSettersChild2"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelEqualityPublicSettersChild2 left, MyModelEqualityPublicSettersChild2 right)
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
        /// Determines whether two objects of type <see cref="MyModelEqualityPublicSettersChild2"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(MyModelEqualityPublicSettersChild2 left, MyModelEqualityPublicSettersChild2 right) => !(left == right);

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as MyModelEqualityPublicSettersChild2);
    }
}