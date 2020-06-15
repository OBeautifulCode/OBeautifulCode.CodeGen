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
    public partial class ModelAllPrivateSetMiscParent : IModel<ModelAllPrivateSetMiscParent>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelAllPrivateSetMiscParent"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelAllPrivateSetMiscParent left, ModelAllPrivateSetMiscParent right)
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
        /// Determines whether two objects of type <see cref="ModelAllPrivateSetMiscParent"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelAllPrivateSetMiscParent left, ModelAllPrivateSetMiscParent right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelAllPrivateSetMiscParent other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);

        /// <inheritdoc />
        public abstract override int GetHashCode();

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModelAllPrivateSetMiscParent DeepClone() => this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentCollectionInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="parentCollectionInterfaceOfStringProperty">The new <see cref="ParentCollectionInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetMiscParent" /> using the specified <paramref name="parentCollectionInterfaceOfStringProperty" /> for <see cref="ParentCollectionInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPrivateSetMiscParent DeepCloneWithParentCollectionInterfaceOfStringProperty(ICollection<string> parentCollectionInterfaceOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentCollectionOfCollectionInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="parentCollectionOfCollectionInterfaceOfStringProperty">The new <see cref="ParentCollectionOfCollectionInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetMiscParent" /> using the specified <paramref name="parentCollectionOfCollectionInterfaceOfStringProperty" /> for <see cref="ParentCollectionOfCollectionInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPrivateSetMiscParent DeepCloneWithParentCollectionOfCollectionInterfaceOfStringProperty(Collection<ICollection<string>> parentCollectionOfCollectionInterfaceOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentListInterfaceOfCollectionInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="parentListInterfaceOfCollectionInterfaceOfStringProperty">The new <see cref="ParentListInterfaceOfCollectionInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetMiscParent" /> using the specified <paramref name="parentListInterfaceOfCollectionInterfaceOfStringProperty" /> for <see cref="ParentListInterfaceOfCollectionInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPrivateSetMiscParent DeepCloneWithParentListInterfaceOfCollectionInterfaceOfStringProperty(IList<ICollection<string>> parentListInterfaceOfCollectionInterfaceOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentListOfCollectionInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="parentListOfCollectionInterfaceOfStringProperty">The new <see cref="ParentListOfCollectionInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetMiscParent" /> using the specified <paramref name="parentListOfCollectionInterfaceOfStringProperty" /> for <see cref="ParentListOfCollectionInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPrivateSetMiscParent DeepCloneWithParentListOfCollectionInterfaceOfStringProperty(List<ICollection<string>> parentListOfCollectionInterfaceOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyCollectionOfCollectionInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyCollectionOfCollectionInterfaceOfStringProperty">The new <see cref="ParentReadOnlyCollectionOfCollectionInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetMiscParent" /> using the specified <paramref name="parentReadOnlyCollectionOfCollectionInterfaceOfStringProperty" /> for <see cref="ParentReadOnlyCollectionOfCollectionInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPrivateSetMiscParent DeepCloneWithParentReadOnlyCollectionOfCollectionInterfaceOfStringProperty(ReadOnlyCollection<ICollection<string>> parentReadOnlyCollectionOfCollectionInterfaceOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty">The new <see cref="ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetMiscParent" /> using the specified <paramref name="parentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" /> for <see cref="ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPrivateSetMiscParent DeepCloneWithParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty(IDictionary<string, IReadOnlyList<DateTime>> parentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty">The new <see cref="ParentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetMiscParent" /> using the specified <paramref name="parentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" /> for <see cref="ParentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPrivateSetMiscParent DeepCloneWithParentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty(Dictionary<string, IReadOnlyList<DateTime>> parentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty">The new <see cref="ParentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetMiscParent" /> using the specified <paramref name="parentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" /> for <see cref="ParentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPrivateSetMiscParent DeepCloneWithParentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty(ReadOnlyDictionary<string, IReadOnlyList<DateTime>> parentReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty">The new <see cref="ParentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetMiscParent" /> using the specified <paramref name="parentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" /> for <see cref="ParentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPrivateSetMiscParent DeepCloneWithParentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty(ConcurrentDictionary<string, IReadOnlyList<DateTime>> parentConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty">The new <see cref="ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetMiscParent" /> using the specified <paramref name="parentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" /> for <see cref="ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPrivateSetMiscParent DeepCloneWithParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty(IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>> parentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty">The new <see cref="ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetMiscParent" /> using the specified <paramref name="parentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" /> for <see cref="ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public abstract ModelAllPrivateSetMiscParent DeepCloneWithParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty(IReadOnlyDictionary<string, IReadOnlyDictionary<string, ReadOnlyDictionary<CustomClass, IReadOnlyList<DateTime>>>> parentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty);

        /// <summary>
        /// Creates a new object that is a deep clone of this instance.
        /// </summary>
        /// <returns>
        /// A new object that is a deep clone of this instance.
        /// </returns>
        protected abstract ModelAllPrivateSetMiscParent DeepCloneInternal();

        /// <inheritdoc />
        public abstract override string ToString();
    }
}