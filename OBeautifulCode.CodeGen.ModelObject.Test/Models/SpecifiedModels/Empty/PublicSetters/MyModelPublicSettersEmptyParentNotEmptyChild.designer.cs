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

    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.0.0")]
    public partial class MyModelPublicSettersEmptyParentNotEmptyChild : IModel<MyModelPublicSettersEmptyParentNotEmptyChild>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPublicSettersEmptyParentNotEmptyChild"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPublicSettersEmptyParentNotEmptyChild left, MyModelPublicSettersEmptyParentNotEmptyChild right)
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
        /// Determines whether two objects of type <see cref="MyModelPublicSettersEmptyParentNotEmptyChild"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPublicSettersEmptyParentNotEmptyChild left, MyModelPublicSettersEmptyParentNotEmptyChild right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPublicSettersEmptyParentNotEmptyChild other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ChildReadOnlyDictionaryOfStringString.IsEqualTo(other.ChildReadOnlyDictionaryOfStringString);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as MyModelPublicSettersEmptyParentNotEmptyChild);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ChildReadOnlyDictionaryOfStringString)
            .Value;

        /// <inheritdoc />
        public override object Clone() => this.DeepClone();

        /// <inheritdoc />
        public override MyModelPublicSettersEmptyParent DeepClone()
        {
            var result = ((IDeepCloneable<MyModelPublicSettersEmptyParentNotEmptyChild>)this).DeepClone();

            return result;
        }

        /// <inheritdoc />
        MyModelPublicSettersEmptyParentNotEmptyChild IDeepCloneable<MyModelPublicSettersEmptyParentNotEmptyChild>.DeepClone()
        {
            var result = new MyModelPublicSettersEmptyParentNotEmptyChild
                             {
                                 ChildReadOnlyDictionaryOfStringString = this.ChildReadOnlyDictionaryOfStringString?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ChildReadOnlyDictionaryOfStringString" />.
        /// </summary>
        /// <param name="childReadOnlyDictionaryOfStringString">The new <see cref="ChildReadOnlyDictionaryOfStringString" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPublicSettersEmptyParentNotEmptyChild" /> using the specified <paramref name="childReadOnlyDictionaryOfStringString" /> for <see cref="ChildReadOnlyDictionaryOfStringString" /> and a deep clone of every other property.</returns>
        public MyModelPublicSettersEmptyParentNotEmptyChild DeepCloneWithChildReadOnlyDictionaryOfStringString(IReadOnlyDictionary<string, string> childReadOnlyDictionaryOfStringString)
        {
            var result = new MyModelPublicSettersEmptyParentNotEmptyChild
                             {
                                 ChildReadOnlyDictionaryOfStringString = childReadOnlyDictionaryOfStringString,
                             };
            
            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"{nameof(OBeautifulCode.CodeGen.ModelObject.Test)}.{nameof(MyModelPublicSettersEmptyParentNotEmptyChild)}: ChildReadOnlyDictionaryOfStringString = {this.ChildReadOnlyDictionaryOfStringString?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}