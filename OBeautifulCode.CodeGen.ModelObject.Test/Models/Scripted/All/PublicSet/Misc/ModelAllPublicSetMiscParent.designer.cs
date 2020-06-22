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
    public partial class ModelAllPublicSetMiscParent : IModel<ModelAllPublicSetMiscParent>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelAllPublicSetMiscParent"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelAllPublicSetMiscParent left, ModelAllPublicSetMiscParent right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals((object)right);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref="ModelAllPublicSetMiscParent"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelAllPublicSetMiscParent left, ModelAllPublicSetMiscParent right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelAllPublicSetMiscParent other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);

        /// <inheritdoc />
        public abstract override int GetHashCode();

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModelAllPublicSetMiscParent DeepClone() => this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentCollectionInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="parentCollectionInterfaceOfStringProperty">The new <see cref="ParentCollectionInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetMiscParent" /> using the specified <paramref name="parentCollectionInterfaceOfStringProperty" /> for <see cref="ParentCollectionInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPublicSetMiscParent DeepCloneWithParentCollectionInterfaceOfStringProperty(ICollection<string> parentCollectionInterfaceOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentListInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="parentListInterfaceOfStringProperty">The new <see cref="ParentListInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetMiscParent" /> using the specified <paramref name="parentListInterfaceOfStringProperty" /> for <see cref="ParentListInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPublicSetMiscParent DeepCloneWithParentListInterfaceOfStringProperty(IList<string> parentListInterfaceOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty">The new <see cref="ParentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetMiscParent" /> using the specified <paramref name="parentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty" /> for <see cref="ParentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPublicSetMiscParent DeepCloneWithParentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty(IReadOnlyCollection<ICollection<string>> parentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="parentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty">The new <see cref="ParentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetMiscParent" /> using the specified <paramref name="parentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty" /> for <see cref="ParentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPublicSetMiscParent DeepCloneWithParentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty(ICollection<IReadOnlyList<string>> parentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentListInterfaceOfCollectionInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="parentListInterfaceOfCollectionInterfaceOfStringProperty">The new <see cref="ParentListInterfaceOfCollectionInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetMiscParent" /> using the specified <paramref name="parentListInterfaceOfCollectionInterfaceOfStringProperty" /> for <see cref="ParentListInterfaceOfCollectionInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPublicSetMiscParent DeepCloneWithParentListInterfaceOfCollectionInterfaceOfStringProperty(IList<ICollection<string>> parentListInterfaceOfCollectionInterfaceOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyListInterfaceOfListInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyListInterfaceOfListInterfaceOfStringProperty">The new <see cref="ParentReadOnlyListInterfaceOfListInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetMiscParent" /> using the specified <paramref name="parentReadOnlyListInterfaceOfListInterfaceOfStringProperty" /> for <see cref="ParentReadOnlyListInterfaceOfListInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPublicSetMiscParent DeepCloneWithParentReadOnlyListInterfaceOfListInterfaceOfStringProperty(IReadOnlyList<IList<string>> parentReadOnlyListInterfaceOfListInterfaceOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty">The new <see cref="ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetMiscParent" /> using the specified <paramref name="parentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" /> for <see cref="ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPublicSetMiscParent DeepCloneWithParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty(IDictionary<string, IReadOnlyList<DateTime>> parentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty">The new <see cref="ParentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetMiscParent" /> using the specified <paramref name="parentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty" /> for <see cref="ParentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPublicSetMiscParent DeepCloneWithParentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty(IReadOnlyDictionary<string, ICollection<DateTime>> parentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty">The new <see cref="ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetMiscParent" /> using the specified <paramref name="parentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" /> for <see cref="ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPublicSetMiscParent DeepCloneWithParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty(IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> parentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty">The new <see cref="ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetMiscParent" /> using the specified <paramref name="parentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" /> for <see cref="ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPublicSetMiscParent DeepCloneWithParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty(IReadOnlyDictionary<string, IReadOnlyDictionary<string, IDictionary<CustomClass, IReadOnlyList<DateTime>>>> parentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);

        /// <summary>
        /// Creates a new object that is a deep clone of this instance.
        /// </summary>
        /// <returns>
        /// A new object that is a deep clone of this instance.
        /// </returns>
        protected abstract ModelAllPublicSetMiscParent DeepCloneInternal();

        /// <inheritdoc />
        public abstract override string ToString();
    }
}