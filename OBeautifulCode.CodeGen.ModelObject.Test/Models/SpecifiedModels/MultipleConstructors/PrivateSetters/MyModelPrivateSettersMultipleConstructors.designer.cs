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

    public partial class MyModelPrivateSettersMultipleConstructors : IModel<MyModelPrivateSettersMultipleConstructors>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersMultipleConstructors"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPrivateSettersMultipleConstructors left, MyModelPrivateSettersMultipleConstructors right)
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
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersMultipleConstructors"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPrivateSettersMultipleConstructors left, MyModelPrivateSettersMultipleConstructors right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPrivateSettersMultipleConstructors other)
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
                      && this.StringProperty.Equals(other.StringProperty, StringComparison.Ordinal)
                      && this.ReadOnlyCollectionOfStringProperty.IsEqualTo(other.ReadOnlyCollectionOfStringProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as MyModelPrivateSettersMultipleConstructors);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.IntProperty)
            .Hash(this.StringProperty)
            .Hash(this.ReadOnlyCollectionOfStringProperty)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public MyModelPrivateSettersMultipleConstructors DeepClone()
        {
            var result = new MyModelPrivateSettersMultipleConstructors(
                                 this.IntProperty,
                                 this.StringProperty?.Clone().ToString(),
                                 this.ReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="IntProperty" />.
        /// </summary>
        /// <param name="intProperty">The new <see cref="IntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersMultipleConstructors" /> using the specified <paramref name="intProperty" /> for <see cref="IntProperty" /> and a deep clone of every other property.</returns>
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
        public MyModelPrivateSettersMultipleConstructors DeepCloneWithIntProperty(int intProperty)
        {
            var result = new MyModelPrivateSettersMultipleConstructors(
                                 intProperty,
                                 this.StringProperty?.Clone().ToString(),
                                 this.ReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="StringProperty" />.
        /// </summary>
        /// <param name="stringProperty">The new <see cref="StringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersMultipleConstructors" /> using the specified <paramref name="stringProperty" /> for <see cref="StringProperty" /> and a deep clone of every other property.</returns>
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
        public MyModelPrivateSettersMultipleConstructors DeepCloneWithStringProperty(string stringProperty)
        {
            var result = new MyModelPrivateSettersMultipleConstructors(
                                 this.IntProperty,
                                 stringProperty,
                                 this.ReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyCollectionOfStringProperty" />.
        /// </summary>
        /// <param name="readOnlyCollectionOfStringProperty">The new <see cref="ReadOnlyCollectionOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersMultipleConstructors" /> using the specified <paramref name="readOnlyCollectionOfStringProperty" /> for <see cref="ReadOnlyCollectionOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public MyModelPrivateSettersMultipleConstructors DeepCloneWithReadOnlyCollectionOfStringProperty(IReadOnlyCollection<string> readOnlyCollectionOfStringProperty)
        {
            var result = new MyModelPrivateSettersMultipleConstructors(
                                 this.IntProperty,
                                 this.StringProperty?.Clone().ToString(),
                                 readOnlyCollectionOfStringProperty);

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.MyModelPrivateSettersMultipleConstructors: IntProperty = {this.IntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, StringProperty = {this.StringProperty?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ReadOnlyCollectionOfStringProperty = {this.ReadOnlyCollectionOfStringProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}