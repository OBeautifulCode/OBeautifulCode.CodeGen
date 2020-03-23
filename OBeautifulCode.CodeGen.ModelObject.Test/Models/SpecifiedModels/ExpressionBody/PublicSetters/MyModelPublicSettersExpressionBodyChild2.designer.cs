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

    public partial class MyModelPublicSettersExpressionBodyChild2 : IModel<MyModelPublicSettersExpressionBodyChild2>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPublicSettersExpressionBodyChild2"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPublicSettersExpressionBodyChild2 left, MyModelPublicSettersExpressionBodyChild2 right)
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
        /// Determines whether two objects of type <see cref="MyModelPublicSettersExpressionBodyChild2"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPublicSettersExpressionBodyChild2 left, MyModelPublicSettersExpressionBodyChild2 right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPublicSettersExpressionBodyChild2 other)
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
        public override bool Equals(object obj) => this == (obj as MyModelPublicSettersExpressionBodyChild2);

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
        public new MyModelPublicSettersExpressionBodyChild2 DeepClone() => (MyModelPublicSettersExpressionBodyChild2)this.DeepCloneInternal();

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
        public override MyModelPublicSettersExpressionBodyParent DeepCloneWithParentIntProperty(int parentIntProperty)
        {
            var result = new MyModelPublicSettersExpressionBodyChild2
                             {
                                 ParentIntProperty                        = parentIntProperty,
                                 ParentStringProperty                     = this.ParentStringProperty?.Clone().ToString(),
                                 ParentReadOnlyCollectionOfStringProperty = this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 ChildIntProperty                         = this.ChildIntProperty,
                                 ChildStringProperty                      = this.ChildStringProperty?.Clone().ToString(),
                                 ChildReadOnlyCollectionOfStringProperty  = this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                             };

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
        public override MyModelPublicSettersExpressionBodyParent DeepCloneWithParentStringProperty(string parentStringProperty)
        {
            var result = new MyModelPublicSettersExpressionBodyChild2
                             {
                                 ParentIntProperty                        = this.ParentIntProperty,
                                 ParentStringProperty                     = parentStringProperty,
                                 ParentReadOnlyCollectionOfStringProperty = this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 ChildIntProperty                         = this.ChildIntProperty,
                                 ChildStringProperty                      = this.ChildStringProperty?.Clone().ToString(),
                                 ChildReadOnlyCollectionOfStringProperty  = this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                             };

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
        public override MyModelPublicSettersExpressionBodyParent DeepCloneWithParentReadOnlyCollectionOfStringProperty(IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty)
        {
            var result = new MyModelPublicSettersExpressionBodyChild2
                             {
                                 ParentIntProperty                        = this.ParentIntProperty,
                                 ParentStringProperty                     = this.ParentStringProperty?.Clone().ToString(),
                                 ParentReadOnlyCollectionOfStringProperty = parentReadOnlyCollectionOfStringProperty,
                                 ChildIntProperty                         = this.ChildIntProperty,
                                 ChildStringProperty                      = this.ChildStringProperty?.Clone().ToString(),
                                 ChildReadOnlyCollectionOfStringProperty  = this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ChildIntProperty" />.
        /// </summary>
        /// <param name="childIntProperty">The new <see cref="ChildIntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPublicSettersExpressionBodyChild2" /> using the specified <paramref name="childIntProperty" /> for <see cref="ChildIntProperty" /> and a deep clone of every other property.</returns>
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
        public MyModelPublicSettersExpressionBodyChild2 DeepCloneWithChildIntProperty(int childIntProperty)
        {
            var result = new MyModelPublicSettersExpressionBodyChild2
                             {
                                 ParentIntProperty                        = this.ParentIntProperty,
                                 ParentStringProperty                     = this.ParentStringProperty?.Clone().ToString(),
                                 ParentReadOnlyCollectionOfStringProperty = this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 ChildIntProperty                         = childIntProperty,
                                 ChildStringProperty                      = this.ChildStringProperty?.Clone().ToString(),
                                 ChildReadOnlyCollectionOfStringProperty  = this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ChildStringProperty" />.
        /// </summary>
        /// <param name="childStringProperty">The new <see cref="ChildStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPublicSettersExpressionBodyChild2" /> using the specified <paramref name="childStringProperty" /> for <see cref="ChildStringProperty" /> and a deep clone of every other property.</returns>
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
        public MyModelPublicSettersExpressionBodyChild2 DeepCloneWithChildStringProperty(string childStringProperty)
        {
            var result = new MyModelPublicSettersExpressionBodyChild2
                             {
                                 ParentIntProperty                        = this.ParentIntProperty,
                                 ParentStringProperty                     = this.ParentStringProperty?.Clone().ToString(),
                                 ParentReadOnlyCollectionOfStringProperty = this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 ChildIntProperty                         = this.ChildIntProperty,
                                 ChildStringProperty                      = childStringProperty,
                                 ChildReadOnlyCollectionOfStringProperty  = this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ChildReadOnlyCollectionOfStringProperty" />.
        /// </summary>
        /// <param name="childReadOnlyCollectionOfStringProperty">The new <see cref="ChildReadOnlyCollectionOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPublicSettersExpressionBodyChild2" /> using the specified <paramref name="childReadOnlyCollectionOfStringProperty" /> for <see cref="ChildReadOnlyCollectionOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public MyModelPublicSettersExpressionBodyChild2 DeepCloneWithChildReadOnlyCollectionOfStringProperty(IReadOnlyCollection<string> childReadOnlyCollectionOfStringProperty)
        {
            var result = new MyModelPublicSettersExpressionBodyChild2
                             {
                                 ParentIntProperty                        = this.ParentIntProperty,
                                 ParentStringProperty                     = this.ParentStringProperty?.Clone().ToString(),
                                 ParentReadOnlyCollectionOfStringProperty = this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 ChildIntProperty                         = this.ChildIntProperty,
                                 ChildStringProperty                      = this.ChildStringProperty?.Clone().ToString(),
                                 ChildReadOnlyCollectionOfStringProperty  = childReadOnlyCollectionOfStringProperty,
                             };

            return result;
        }

        /// <inheritdoc />
        protected override MyModelPublicSettersExpressionBodyParent DeepCloneInternal()
        {
            var result = new MyModelPublicSettersExpressionBodyChild2
                             {
                                 ParentIntProperty                        = this.ParentIntProperty,
                                 ParentStringProperty                     = this.ParentStringProperty?.Clone().ToString(),
                                 ParentReadOnlyCollectionOfStringProperty = this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 ChildIntProperty                         = this.ChildIntProperty,
                                 ChildStringProperty                      = this.ChildStringProperty?.Clone().ToString(),
                                 ChildReadOnlyCollectionOfStringProperty  = this.ChildReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                             };

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.MyModelPublicSettersExpressionBodyChild2: ParentIntProperty = {this.ParentIntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ParentStringProperty = {this.ParentStringProperty?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ParentReadOnlyCollectionOfStringProperty = {this.ParentReadOnlyCollectionOfStringProperty?.ToString() ?? "<null>"}, ChildIntProperty = {this.ChildIntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ChildStringProperty = {this.ChildStringProperty?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ChildReadOnlyCollectionOfStringProperty = {this.ChildReadOnlyCollectionOfStringProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}