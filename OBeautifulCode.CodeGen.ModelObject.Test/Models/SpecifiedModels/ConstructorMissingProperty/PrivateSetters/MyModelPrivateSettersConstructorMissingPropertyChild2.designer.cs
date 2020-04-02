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

    public partial class MyModelPrivateSettersConstructorMissingPropertyChild2 : IModel<MyModelPrivateSettersConstructorMissingPropertyChild2>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersConstructorMissingPropertyChild2"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPrivateSettersConstructorMissingPropertyChild2 left, MyModelPrivateSettersConstructorMissingPropertyChild2 right)
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
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersConstructorMissingPropertyChild2"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPrivateSettersConstructorMissingPropertyChild2 left, MyModelPrivateSettersConstructorMissingPropertyChild2 right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPrivateSettersConstructorMissingPropertyChild2 other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ParentEnumProperty.IsEqualTo(other.ParentEnumProperty)
                      && this.ParentReadOnlyCollectionOfStringProperty.IsEqualTo(other.ParentReadOnlyCollectionOfStringProperty)
                      && this.ChildClass.IsEqualTo(other.ChildClass);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as MyModelPrivateSettersConstructorMissingPropertyChild2);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ParentEnumProperty)
            .Hash(this.ParentReadOnlyCollectionOfStringProperty)
            .Hash(this.ChildClass)
            .Value;

        /// <inheritdoc />
        public new MyModelPrivateSettersConstructorMissingPropertyChild2 DeepClone() => (MyModelPrivateSettersConstructorMissingPropertyChild2)this.DeepCloneInternal();

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
        public override MyModelPrivateSettersConstructorMissingPropertyParent DeepCloneWithParentEnumProperty(ModelEnum parentEnumProperty)
        {
            throw new NotSupportedException("The constructor in-use (by code gen) for MyModelPrivateSettersConstructorMissingPropertyChild2 does not have a parameter that corresponds with the 'ParentEnumProperty' property.  As such, this method, DeepCloneWithParentEnumProperty(ModelEnum parentEnumProperty), cannot utilize the specified 'parentEnumProperty' value for that property.");
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
        public override MyModelPrivateSettersConstructorMissingPropertyParent DeepCloneWithParentReadOnlyCollectionOfStringProperty(IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty)
        {
            var result = new MyModelPrivateSettersConstructorMissingPropertyChild2(
                                 parentReadOnlyCollectionOfStringProperty,
                                 this.ChildClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ChildClass" />.
        /// </summary>
        /// <param name="childClass">The new <see cref="ChildClass" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersConstructorMissingPropertyChild2" /> using the specified <paramref name="childClass" /> for <see cref="ChildClass" /> and a deep clone of every other property.</returns>
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
        public MyModelPrivateSettersConstructorMissingPropertyChild2 DeepCloneWithChildClass(ModelClass childClass)
        {
            var result = new MyModelPrivateSettersConstructorMissingPropertyChild2(
                                 this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 childClass);

            return result;
        }

        /// <inheritdoc />
        protected override MyModelPrivateSettersConstructorMissingPropertyParent DeepCloneInternal()
        {
            var result = new MyModelPrivateSettersConstructorMissingPropertyChild2(
                                 this.ParentReadOnlyCollectionOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ChildClass?.DeepClone());

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.MyModelPrivateSettersConstructorMissingPropertyChild2: ParentEnumProperty = {this.ParentEnumProperty.ToString() ?? "<null>"}, ParentReadOnlyCollectionOfStringProperty = {this.ParentReadOnlyCollectionOfStringProperty?.ToString() ?? "<null>"}, ChildClass = {this.ChildClass?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}