﻿// --------------------------------------------------------------------------------------------------------------------
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

    [Serializable]
    public partial class ModelPublicSetNotEmptyParentEmptyChild : IModel<ModelPublicSetNotEmptyParentEmptyChild>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelPublicSetNotEmptyParentEmptyChild"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelPublicSetNotEmptyParentEmptyChild left, ModelPublicSetNotEmptyParentEmptyChild right)
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
        /// Determines whether two objects of type <see cref="ModelPublicSetNotEmptyParentEmptyChild"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelPublicSetNotEmptyParentEmptyChild left, ModelPublicSetNotEmptyParentEmptyChild right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelPublicSetNotEmptyParentEmptyChild other)
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
        public override bool Equals(object obj) => this == (obj as ModelPublicSetNotEmptyParentEmptyChild);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ParentReadOnlyDictionaryOfStringString)
            .Value;

        /// <inheritdoc />
        public new ModelPublicSetNotEmptyParentEmptyChild DeepClone() => (ModelPublicSetNotEmptyParentEmptyChild)this.DeepCloneInternal();

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
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
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public override ModelPublicSetNotEmptyParent DeepCloneWithParentReadOnlyDictionaryOfStringString(IReadOnlyDictionary<string, string> parentReadOnlyDictionaryOfStringString)
        {
            var result = new ModelPublicSetNotEmptyParentEmptyChild
                             {
                                 ParentReadOnlyDictionaryOfStringString = parentReadOnlyDictionaryOfStringString,
                             };

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        protected override ModelPublicSetNotEmptyParent DeepCloneInternal()
        {
            var result = new ModelPublicSetNotEmptyParentEmptyChild
                             {
                                 ParentReadOnlyDictionaryOfStringString = this.ParentReadOnlyDictionaryOfStringString?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                             };

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.ModelPublicSetNotEmptyParentEmptyChild: ParentReadOnlyDictionaryOfStringString = {this.ParentReadOnlyDictionaryOfStringString?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}