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

    public partial class MyModelPrivateSettersExpressionBodyChild1 : IModel<MyModelPrivateSettersExpressionBodyChild1>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersExpressionBodyChild1"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPrivateSettersExpressionBodyChild1 left, MyModelPrivateSettersExpressionBodyChild1 right)
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
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersExpressionBodyChild1"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPrivateSettersExpressionBodyChild1 left, MyModelPrivateSettersExpressionBodyChild1 right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPrivateSettersExpressionBodyChild1 other)
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
                      && this.ParentStringProperty.Equals(other.ParentStringProperty, StringComparison.Ordinal)
                      && this.ParentReadOnlyCollectionOfStringProperty.IsEqualTo(other.ParentReadOnlyCollectionOfStringProperty)
                      && this.ChildIntProperty.IsEqualTo(other.ChildIntProperty)
                      && this.ChildStringProperty.Equals(other.ChildStringProperty, StringComparison.Ordinal)
                      && this.ChildReadOnlyCollectionOfStringProperty.IsEqualTo(other.ChildReadOnlyCollectionOfStringProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as MyModelPrivateSettersExpressionBodyChild1);

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
        public new MyModelPrivateSettersExpressionBodyChild1 DeepClone() => (MyModelPrivateSettersExpressionBodyChild1)this.DeepCloneInternal();

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
        public override MyModelPrivateSettersExpressionBodyParent DeepCloneWithParentIntProperty(int parentIntProperty)
        {
            var result = new MyModelPrivateSettersExpressionBodyChild1(
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
        public override MyModelPrivateSettersExpressionBodyParent DeepCloneWithParentStringProperty(string parentStringProperty)
        {
            var result = new MyModelPrivateSettersExpressionBodyChild1(
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
        public override MyModelPrivateSettersExpressionBodyParent DeepCloneWithParentReadOnlyCollectionOfStringProperty(IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty)
        {
            var result = new MyModelPrivateSettersExpressionBodyChild1(
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
        /// <returns>New <see cref="MyModelPrivateSettersExpressionBodyChild1" /> using the specified <paramref name="childIntProperty" /> for <see cref="ChildIntProperty" /> and a deep clone of every other property.</returns>
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
        public MyModelPrivateSettersExpressionBodyChild1 DeepCloneWithChildIntProperty(int childIntProperty)
        {
            var result = new MyModelPrivateSettersExpressionBodyChild1(
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
        /// <returns>New <see cref="MyModelPrivateSettersExpressionBodyChild1" /> using the specified <paramref name="childStringProperty" /> for <see cref="ChildStringProperty" /> and a deep clone of every other property.</returns>
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
        public MyModelPrivateSettersExpressionBodyChild1 DeepCloneWithChildStringProperty(string childStringProperty)
        {
            var result = new MyModelPrivateSettersExpressionBodyChild1(
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
        /// <returns>New <see cref="MyModelPrivateSettersExpressionBodyChild1" /> using the specified <paramref name="childReadOnlyCollectionOfStringProperty" /> for <see cref="ChildReadOnlyCollectionOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public MyModelPrivateSettersExpressionBodyChild1 DeepCloneWithChildReadOnlyCollectionOfStringProperty(IReadOnlyCollection<string> childReadOnlyCollectionOfStringProperty)
        {
            var result = new MyModelPrivateSettersExpressionBodyChild1(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ChildIntProperty,
                                 this.ChildStringProperty?.Clone().ToString(),
                                 childReadOnlyCollectionOfStringProperty);

            return result;
        }

        /// <inheritdoc />
        protected override MyModelPrivateSettersExpressionBodyParent DeepCloneInternal()
        {
            var result = new MyModelPrivateSettersExpressionBodyChild1(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ChildIntProperty,
                                 this.ChildStringProperty?.Clone().ToString(),
                                 this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList());

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.MyModelPrivateSettersExpressionBodyChild1: ParentIntProperty = {this.ParentIntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ParentStringProperty = {this.ParentStringProperty?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ParentReadOnlyCollectionOfStringProperty = {this.ParentReadOnlyCollectionOfStringProperty?.ToString() ?? "<null>"}, ChildIntProperty = {this.ChildIntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ChildStringProperty = {this.ChildStringProperty?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ChildReadOnlyCollectionOfStringProperty = {this.ChildReadOnlyCollectionOfStringProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}