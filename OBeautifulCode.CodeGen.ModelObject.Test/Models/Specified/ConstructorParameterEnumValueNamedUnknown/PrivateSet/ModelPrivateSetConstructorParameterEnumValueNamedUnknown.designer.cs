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

    using global::OBeautifulCode.Cloning.Recipes;
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class ModelPrivateSetConstructorParameterEnumValueNamedUnknown : IModel<ModelPrivateSetConstructorParameterEnumValueNamedUnknown>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelPrivateSetConstructorParameterEnumValueNamedUnknown"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelPrivateSetConstructorParameterEnumValueNamedUnknown left, ModelPrivateSetConstructorParameterEnumValueNamedUnknown right)
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
        /// Determines whether two objects of type <see cref="ModelPrivateSetConstructorParameterEnumValueNamedUnknown"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelPrivateSetConstructorParameterEnumValueNamedUnknown left, ModelPrivateSetConstructorParameterEnumValueNamedUnknown right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelPrivateSetConstructorParameterEnumValueNamedUnknown other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.Item1.IsEqualTo(other.Item1)
                      && this.Item2.IsEqualTo(other.Item2)
                      && this.Item3.IsEqualTo(other.Item3)
                      && this.Item4.IsEqualTo(other.Item4);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModelPrivateSetConstructorParameterEnumValueNamedUnknown);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Item1)
            .Hash(this.Item2)
            .Hash(this.Item3)
            .Hash(this.Item4)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModelPrivateSetConstructorParameterEnumValueNamedUnknown DeepClone()
        {
            var result = new ModelPrivateSetConstructorParameterEnumValueNamedUnknown(
                                 this.Item1.DeepClone(),
                                 this.Item2?.DeepClone(),
                                 this.Item3.DeepClone(),
                                 this.Item4?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Item1" />.
        /// </summary>
        /// <param name="item1">The new <see cref="Item1" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPrivateSetConstructorParameterEnumValueNamedUnknown" /> using the specified <paramref name="item1" /> for <see cref="Item1" /> and a deep clone of every other property.</returns>
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
        public ModelPrivateSetConstructorParameterEnumValueNamedUnknown DeepCloneWithItem1(CustomEnum item1)
        {
            var result = new ModelPrivateSetConstructorParameterEnumValueNamedUnknown(
                                 item1,
                                 this.Item2?.DeepClone(),
                                 this.Item3.DeepClone(),
                                 this.Item4?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Item2" />.
        /// </summary>
        /// <param name="item2">The new <see cref="Item2" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPrivateSetConstructorParameterEnumValueNamedUnknown" /> using the specified <paramref name="item2" /> for <see cref="Item2" /> and a deep clone of every other property.</returns>
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
        public ModelPrivateSetConstructorParameterEnumValueNamedUnknown DeepCloneWithItem2(CustomEnum? item2)
        {
            var result = new ModelPrivateSetConstructorParameterEnumValueNamedUnknown(
                                 this.Item1.DeepClone(),
                                 item2,
                                 this.Item3.DeepClone(),
                                 this.Item4?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Item3" />.
        /// </summary>
        /// <param name="item3">The new <see cref="Item3" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPrivateSetConstructorParameterEnumValueNamedUnknown" /> using the specified <paramref name="item3" /> for <see cref="Item3" /> and a deep clone of every other property.</returns>
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
        public ModelPrivateSetConstructorParameterEnumValueNamedUnknown DeepCloneWithItem3(CustomEnumWithUnknown item3)
        {
            var result = new ModelPrivateSetConstructorParameterEnumValueNamedUnknown(
                                 this.Item1.DeepClone(),
                                 this.Item2?.DeepClone(),
                                 item3,
                                 this.Item4?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Item4" />.
        /// </summary>
        /// <param name="item4">The new <see cref="Item4" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelPrivateSetConstructorParameterEnumValueNamedUnknown" /> using the specified <paramref name="item4" /> for <see cref="Item4" /> and a deep clone of every other property.</returns>
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
        public ModelPrivateSetConstructorParameterEnumValueNamedUnknown DeepCloneWithItem4(CustomEnumWithUnknown? item4)
        {
            var result = new ModelPrivateSetConstructorParameterEnumValueNamedUnknown(
                                 this.Item1.DeepClone(),
                                 this.Item2?.DeepClone(),
                                 this.Item3.DeepClone(),
                                 item4);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.ModelPrivateSetConstructorParameterEnumValueNamedUnknown: Item1 = {this.Item1.ToString() ?? "<null>"}, Item2 = {this.Item2?.ToString() ?? "<null>"}, Item3 = {this.Item3.ToString() ?? "<null>"}, Item4 = {this.Item4?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}