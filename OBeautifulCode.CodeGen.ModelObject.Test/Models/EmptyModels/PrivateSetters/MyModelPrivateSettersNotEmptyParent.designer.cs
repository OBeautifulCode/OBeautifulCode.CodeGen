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

    using static System.FormattableString;

    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.0.0")]
    public partial class MyModelPrivateSettersNotEmptyParent : IModel<MyModelPrivateSettersNotEmptyParent>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersNotEmptyParent"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPrivateSettersNotEmptyParent left, MyModelPrivateSettersNotEmptyParent right)
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
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersNotEmptyParent"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPrivateSettersNotEmptyParent left, MyModelPrivateSettersNotEmptyParent right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPrivateSettersNotEmptyParent other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);
    
        /// <inheritdoc />
        public abstract override int GetHashCode();
    
        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public abstract MyModelPrivateSettersNotEmptyParent DeepClone();

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryOfStringString" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryOfStringString">The new <see cref="ParentReadOnlyDictionaryOfStringString" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersNotEmptyParent" /> using the specified <paramref name="parentReadOnlyDictionaryOfStringString" /> for <see cref="ParentReadOnlyDictionaryOfStringString" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersNotEmptyParent DeepCloneWithParentReadOnlyDictionaryOfStringString(IReadOnlyDictionary<string, string> parentReadOnlyDictionaryOfStringString);
    
        /// <inheritdoc />
        public abstract override string ToString();
    }
}