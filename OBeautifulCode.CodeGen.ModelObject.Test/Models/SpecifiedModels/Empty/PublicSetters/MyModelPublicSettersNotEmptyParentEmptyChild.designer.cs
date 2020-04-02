// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;

    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    public partial class MyModelPublicSettersNotEmptyParentEmptyChild : IModel<MyModelPublicSettersNotEmptyParentEmptyChild>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPublicSettersNotEmptyParentEmptyChild"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPublicSettersNotEmptyParentEmptyChild left, MyModelPublicSettersNotEmptyParentEmptyChild right)
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
        /// Determines whether two objects of type <see cref="MyModelPublicSettersNotEmptyParentEmptyChild"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPublicSettersNotEmptyParentEmptyChild left, MyModelPublicSettersNotEmptyParentEmptyChild right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPublicSettersNotEmptyParentEmptyChild other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ParentReadOnlyDictionaryOfStringString.IsEqualTo(other.ParentReadOnlyDictionaryOfStringString);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as MyModelPublicSettersNotEmptyParentEmptyChild);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ParentReadOnlyDictionaryOfStringString)
            .Value;

        /// <inheritdoc />
        public new MyModelPublicSettersNotEmptyParentEmptyChild DeepClone() => (MyModelPublicSettersNotEmptyParentEmptyChild)this.DeepCloneInternal();

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        public override MyModelPublicSettersNotEmptyParent DeepCloneWithParentReadOnlyDictionaryOfStringString(IReadOnlyDictionary<string, string> parentReadOnlyDictionaryOfStringString)
        {
            var result = new MyModelPublicSettersNotEmptyParentEmptyChild
                             {
                                 ParentReadOnlyDictionaryOfStringString = parentReadOnlyDictionaryOfStringString,
                             };

            return result;
        }

        /// <inheritdoc />
        protected override MyModelPublicSettersNotEmptyParent DeepCloneInternal()
        {
            var result = new MyModelPublicSettersNotEmptyParentEmptyChild
                             {
                                 ParentReadOnlyDictionaryOfStringString = this.ParentReadOnlyDictionaryOfStringString?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                             };

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.MyModelPublicSettersNotEmptyParentEmptyChild: ParentReadOnlyDictionaryOfStringString = {this.ParentReadOnlyDictionaryOfStringString?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}