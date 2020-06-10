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
    public partial class ModelPrivateSetExpressionBody : IModel<ModelPrivateSetExpressionBody>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelPrivateSetExpressionBody"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelPrivateSetExpressionBody left, ModelPrivateSetExpressionBody right)
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
        /// Determines whether two objects of type <see cref="ModelPrivateSetExpressionBody"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelPrivateSetExpressionBody left, ModelPrivateSetExpressionBody right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelPrivateSetExpressionBody other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.IntProperty.IsEqualTo(other.IntProperty)
                      && this.StringProperty.IsEqualTo(other.StringProperty, StringComparer.Ordinal)
                      && this.ReadOnlyCollectionOfStringProperty.IsEqualTo(other.ReadOnlyCollectionOfStringProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModelPrivateSetExpressionBody);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.IntProperty)
            .Hash(this.StringProperty)
            .Hash(this.ReadOnlyCollectionOfStringProperty)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModelPrivateSetExpressionBody DeepClone()
        {
            var result = new ModelPrivateSetExpressionBody(
                                 this.IntProperty,
                                 this.StringProperty?.Clone().ToString(),
                                 this.ReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="IntProperty" />.
        /// </summary>
        /// <param name="intProperty">The new <see cref="IntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPrivateSetExpressionBody" /> using the specified <paramref name="intProperty" /> for <see cref="IntProperty" /> and a deep clone of every other property.</returns>
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
        public ModelPrivateSetExpressionBody DeepCloneWithIntProperty(int intProperty)
        {
            var result = new ModelPrivateSetExpressionBody(
                                 intProperty,
                                 this.StringProperty?.Clone().ToString(),
                                 this.ReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="StringProperty" />.
        /// </summary>
        /// <param name="stringProperty">The new <see cref="StringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPrivateSetExpressionBody" /> using the specified <paramref name="stringProperty" /> for <see cref="StringProperty" /> and a deep clone of every other property.</returns>
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
        public ModelPrivateSetExpressionBody DeepCloneWithStringProperty(string stringProperty)
        {
            var result = new ModelPrivateSetExpressionBody(
                                 this.IntProperty,
                                 stringProperty,
                                 this.ReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyCollectionOfStringProperty" />.
        /// </summary>
        /// <param name="readOnlyCollectionOfStringProperty">The new <see cref="ReadOnlyCollectionOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPrivateSetExpressionBody" /> using the specified <paramref name="readOnlyCollectionOfStringProperty" /> for <see cref="ReadOnlyCollectionOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public ModelPrivateSetExpressionBody DeepCloneWithReadOnlyCollectionOfStringProperty(IReadOnlyCollection<string> readOnlyCollectionOfStringProperty)
        {
            var result = new ModelPrivateSetExpressionBody(
                                 this.IntProperty,
                                 this.StringProperty?.Clone().ToString(),
                                 readOnlyCollectionOfStringProperty);

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.ModelPrivateSetExpressionBody: IntProperty = {this.IntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, StringProperty = {this.StringProperty?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ReadOnlyCollectionOfStringProperty = {this.ReadOnlyCollectionOfStringProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}