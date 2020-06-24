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
    public partial class ModelPublicSetExpressionBody : IModel<ModelPublicSetExpressionBody>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelPublicSetExpressionBody"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelPublicSetExpressionBody left, ModelPublicSetExpressionBody right)
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
        /// Determines whether two objects of type <see cref="ModelPublicSetExpressionBody"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelPublicSetExpressionBody left, ModelPublicSetExpressionBody right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelPublicSetExpressionBody other)
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
        public override bool Equals(object obj) => this == (obj as ModelPublicSetExpressionBody);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.IntProperty)
            .Hash(this.StringProperty)
            .Hash(this.ReadOnlyCollectionOfStringProperty)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModelPublicSetExpressionBody DeepClone()
        {
            var result = new ModelPublicSetExpressionBody
                             {
                                 IntProperty                        = this.IntProperty,
                                 StringProperty                     = this.StringProperty?.Clone().ToString(),
                                 ReadOnlyCollectionOfStringProperty = this.ReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="IntProperty" />.
        /// </summary>
        /// <param name="intProperty">The new <see cref="IntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPublicSetExpressionBody" /> using the specified <paramref name="intProperty" /> for <see cref="IntProperty" /> and a deep clone of every other property.</returns>
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
        public ModelPublicSetExpressionBody DeepCloneWithIntProperty(int intProperty)
        {
            var result = new ModelPublicSetExpressionBody
                             {
                                 IntProperty                        = intProperty,
                                 StringProperty                     = this.StringProperty?.Clone().ToString(),
                                 ReadOnlyCollectionOfStringProperty = this.ReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="StringProperty" />.
        /// </summary>
        /// <param name="stringProperty">The new <see cref="StringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPublicSetExpressionBody" /> using the specified <paramref name="stringProperty" /> for <see cref="StringProperty" /> and a deep clone of every other property.</returns>
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
        public ModelPublicSetExpressionBody DeepCloneWithStringProperty(string stringProperty)
        {
            var result = new ModelPublicSetExpressionBody
                             {
                                 IntProperty                        = this.IntProperty,
                                 StringProperty                     = stringProperty,
                                 ReadOnlyCollectionOfStringProperty = this.ReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyCollectionOfStringProperty" />.
        /// </summary>
        /// <param name="readOnlyCollectionOfStringProperty">The new <see cref="ReadOnlyCollectionOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPublicSetExpressionBody" /> using the specified <paramref name="readOnlyCollectionOfStringProperty" /> for <see cref="ReadOnlyCollectionOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public ModelPublicSetExpressionBody DeepCloneWithReadOnlyCollectionOfStringProperty(IReadOnlyCollection<string> readOnlyCollectionOfStringProperty)
        {
            var result = new ModelPublicSetExpressionBody
                             {
                                 IntProperty                        = this.IntProperty,
                                 StringProperty                     = this.StringProperty?.Clone().ToString(),
                                 ReadOnlyCollectionOfStringProperty = readOnlyCollectionOfStringProperty,
                             };

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.ModelPublicSetExpressionBody: IntProperty = {this.IntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, StringProperty = {this.StringProperty?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ReadOnlyCollectionOfStringProperty = {this.ReadOnlyCollectionOfStringProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}