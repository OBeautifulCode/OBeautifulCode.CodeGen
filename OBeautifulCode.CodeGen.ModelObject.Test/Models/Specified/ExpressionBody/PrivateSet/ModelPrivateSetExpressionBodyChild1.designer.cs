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
    public partial class ModelPrivateSetExpressionBodyChild1 : IModel<ModelPrivateSetExpressionBodyChild1>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelPrivateSetExpressionBodyChild1"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelPrivateSetExpressionBodyChild1 left, ModelPrivateSetExpressionBodyChild1 right)
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
        /// Determines whether two objects of type <see cref="ModelPrivateSetExpressionBodyChild1"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelPrivateSetExpressionBodyChild1 left, ModelPrivateSetExpressionBodyChild1 right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelPrivateSetExpressionBodyChild1 other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ParentIntProperty.IsEqualTo(other.ParentIntProperty)
                      && this.ParentStringProperty.IsEqualTo(other.ParentStringProperty, StringComparer.Ordinal)
                      && this.ParentReadOnlyCollectionOfStringProperty.IsEqualTo(other.ParentReadOnlyCollectionOfStringProperty)
                      && this.ChildIntProperty.IsEqualTo(other.ChildIntProperty)
                      && this.ChildStringProperty.IsEqualTo(other.ChildStringProperty, StringComparer.Ordinal)
                      && this.ChildReadOnlyCollectionOfStringProperty.IsEqualTo(other.ChildReadOnlyCollectionOfStringProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModelPrivateSetExpressionBodyChild1);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ParentIntProperty)
            .Hash(this.ParentStringProperty)
            .Hash(this.ParentReadOnlyCollectionOfStringProperty)
            .Hash(this.ChildIntProperty)
            .Hash(this.ChildStringProperty)
            .Hash(this.ChildReadOnlyCollectionOfStringProperty)
            .Value;

        /// <inheritdoc />
        public new ModelPrivateSetExpressionBodyChild1 DeepClone() => (ModelPrivateSetExpressionBodyChild1)this.DeepCloneInternal();

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
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public override ModelPrivateSetExpressionBodyParent DeepCloneWithParentIntProperty(int parentIntProperty)
        {
            var result = new ModelPrivateSetExpressionBodyChild1(
                                 parentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ChildIntProperty,
                                 this.ChildStringProperty?.Clone().ToString(),
                                 this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

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
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public override ModelPrivateSetExpressionBodyParent DeepCloneWithParentStringProperty(string parentStringProperty)
        {
            var result = new ModelPrivateSetExpressionBodyChild1(
                                 this.ParentIntProperty,
                                 parentStringProperty,
                                 this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ChildIntProperty,
                                 this.ChildStringProperty?.Clone().ToString(),
                                 this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

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
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public override ModelPrivateSetExpressionBodyParent DeepCloneWithParentReadOnlyCollectionOfStringProperty(IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty)
        {
            var result = new ModelPrivateSetExpressionBodyChild1(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 parentReadOnlyCollectionOfStringProperty,
                                 this.ChildIntProperty,
                                 this.ChildStringProperty?.Clone().ToString(),
                                 this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ChildIntProperty" />.
        /// </summary>
        /// <param name="childIntProperty">The new <see cref="ChildIntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPrivateSetExpressionBodyChild1" /> using the specified <paramref name="childIntProperty" /> for <see cref="ChildIntProperty" /> and a deep clone of every other property.</returns>
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
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ModelPrivateSetExpressionBodyChild1 DeepCloneWithChildIntProperty(int childIntProperty)
        {
            var result = new ModelPrivateSetExpressionBodyChild1(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 childIntProperty,
                                 this.ChildStringProperty?.Clone().ToString(),
                                 this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ChildStringProperty" />.
        /// </summary>
        /// <param name="childStringProperty">The new <see cref="ChildStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPrivateSetExpressionBodyChild1" /> using the specified <paramref name="childStringProperty" /> for <see cref="ChildStringProperty" /> and a deep clone of every other property.</returns>
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
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ModelPrivateSetExpressionBodyChild1 DeepCloneWithChildStringProperty(string childStringProperty)
        {
            var result = new ModelPrivateSetExpressionBodyChild1(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ChildIntProperty,
                                 childStringProperty,
                                 this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ChildReadOnlyCollectionOfStringProperty" />.
        /// </summary>
        /// <param name="childReadOnlyCollectionOfStringProperty">The new <see cref="ChildReadOnlyCollectionOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPrivateSetExpressionBodyChild1" /> using the specified <paramref name="childReadOnlyCollectionOfStringProperty" /> for <see cref="ChildReadOnlyCollectionOfStringProperty" /> and a deep clone of every other property.</returns>
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
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ModelPrivateSetExpressionBodyChild1 DeepCloneWithChildReadOnlyCollectionOfStringProperty(IReadOnlyCollection<string> childReadOnlyCollectionOfStringProperty)
        {
            var result = new ModelPrivateSetExpressionBodyChild1(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ChildIntProperty,
                                 this.ChildStringProperty?.Clone().ToString(),
                                 childReadOnlyCollectionOfStringProperty);

            return result;
        }

        /// <inheritdoc />
        protected override ModelPrivateSetExpressionBodyParent DeepCloneInternal()
        {
            var result = new ModelPrivateSetExpressionBodyChild1(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ChildIntProperty,
                                 this.ChildStringProperty?.Clone().ToString(),
                                 this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.ModelPrivateSetExpressionBodyChild1: ParentIntProperty = {this.ParentIntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ParentStringProperty = {this.ParentStringProperty?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ParentReadOnlyCollectionOfStringProperty = {this.ParentReadOnlyCollectionOfStringProperty?.ToString() ?? "<null>"}, ChildIntProperty = {this.ChildIntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ChildStringProperty = {this.ChildStringProperty?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ChildReadOnlyCollectionOfStringProperty = {this.ChildReadOnlyCollectionOfStringProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}