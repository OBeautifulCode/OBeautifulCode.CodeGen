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
    public partial class ModelAllPrivateSetReadOnlyList : IModel<ModelAllPrivateSetReadOnlyList>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelAllPrivateSetReadOnlyList"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelAllPrivateSetReadOnlyList left, ModelAllPrivateSetReadOnlyList right)
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
        /// Determines whether two objects of type <see cref="ModelAllPrivateSetReadOnlyList"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelAllPrivateSetReadOnlyList left, ModelAllPrivateSetReadOnlyList right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelAllPrivateSetReadOnlyList other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ReadOnlyListInterfaceOfBoolProperty.IsEqualTo(other.ReadOnlyListInterfaceOfBoolProperty)
                      && this.ReadOnlyListInterfaceOfIntProperty.IsEqualTo(other.ReadOnlyListInterfaceOfIntProperty)
                      && this.ReadOnlyListInterfaceOfStringProperty.IsEqualTo(other.ReadOnlyListInterfaceOfStringProperty)
                      && this.ReadOnlyListInterfaceOfGuidProperty.IsEqualTo(other.ReadOnlyListInterfaceOfGuidProperty)
                      && this.ReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ReadOnlyListInterfaceOfDateTimeProperty)
                      && this.ReadOnlyListInterfaceOfCustomEnumProperty.IsEqualTo(other.ReadOnlyListInterfaceOfCustomEnumProperty)
                      && this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.ReadOnlyListInterfaceOfCustomFlagsEnumProperty)
                      && this.ReadOnlyListInterfaceOfCustomClassProperty.IsEqualTo(other.ReadOnlyListInterfaceOfCustomClassProperty)
                      && this.ReadOnlyListInterfaceOfCustomBaseClassProperty.IsEqualTo(other.ReadOnlyListInterfaceOfCustomBaseClassProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModelAllPrivateSetReadOnlyList);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ReadOnlyListInterfaceOfBoolProperty)
            .Hash(this.ReadOnlyListInterfaceOfIntProperty)
            .Hash(this.ReadOnlyListInterfaceOfStringProperty)
            .Hash(this.ReadOnlyListInterfaceOfGuidProperty)
            .Hash(this.ReadOnlyListInterfaceOfDateTimeProperty)
            .Hash(this.ReadOnlyListInterfaceOfCustomEnumProperty)
            .Hash(this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty)
            .Hash(this.ReadOnlyListInterfaceOfCustomClassProperty)
            .Hash(this.ReadOnlyListInterfaceOfCustomBaseClassProperty)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModelAllPrivateSetReadOnlyList DeepClone()
        {
            var result = new ModelAllPrivateSetReadOnlyList(
                                 this.ReadOnlyListInterfaceOfBoolProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfIntProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ReadOnlyListInterfaceOfGuidProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfDateTimeProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfBoolProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfBoolProperty">The new <see cref="ReadOnlyListInterfaceOfBoolProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetReadOnlyList" /> using the specified <paramref name="readOnlyListInterfaceOfBoolProperty" /> for <see cref="ReadOnlyListInterfaceOfBoolProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetReadOnlyList DeepCloneWithReadOnlyListInterfaceOfBoolProperty(IReadOnlyList<bool> readOnlyListInterfaceOfBoolProperty)
        {
            var result = new ModelAllPrivateSetReadOnlyList(
                                 readOnlyListInterfaceOfBoolProperty,
                                 this.ReadOnlyListInterfaceOfIntProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ReadOnlyListInterfaceOfGuidProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfDateTimeProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfIntProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfIntProperty">The new <see cref="ReadOnlyListInterfaceOfIntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetReadOnlyList" /> using the specified <paramref name="readOnlyListInterfaceOfIntProperty" /> for <see cref="ReadOnlyListInterfaceOfIntProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetReadOnlyList DeepCloneWithReadOnlyListInterfaceOfIntProperty(IReadOnlyList<int> readOnlyListInterfaceOfIntProperty)
        {
            var result = new ModelAllPrivateSetReadOnlyList(
                                 this.ReadOnlyListInterfaceOfBoolProperty?.Select(i => i).ToList(),
                                 readOnlyListInterfaceOfIntProperty,
                                 this.ReadOnlyListInterfaceOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ReadOnlyListInterfaceOfGuidProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfDateTimeProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfStringProperty">The new <see cref="ReadOnlyListInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetReadOnlyList" /> using the specified <paramref name="readOnlyListInterfaceOfStringProperty" /> for <see cref="ReadOnlyListInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetReadOnlyList DeepCloneWithReadOnlyListInterfaceOfStringProperty(IReadOnlyList<string> readOnlyListInterfaceOfStringProperty)
        {
            var result = new ModelAllPrivateSetReadOnlyList(
                                 this.ReadOnlyListInterfaceOfBoolProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfIntProperty?.Select(i => i).ToList(),
                                 readOnlyListInterfaceOfStringProperty,
                                 this.ReadOnlyListInterfaceOfGuidProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfDateTimeProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfGuidProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfGuidProperty">The new <see cref="ReadOnlyListInterfaceOfGuidProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetReadOnlyList" /> using the specified <paramref name="readOnlyListInterfaceOfGuidProperty" /> for <see cref="ReadOnlyListInterfaceOfGuidProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetReadOnlyList DeepCloneWithReadOnlyListInterfaceOfGuidProperty(IReadOnlyList<Guid> readOnlyListInterfaceOfGuidProperty)
        {
            var result = new ModelAllPrivateSetReadOnlyList(
                                 this.ReadOnlyListInterfaceOfBoolProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfIntProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 readOnlyListInterfaceOfGuidProperty,
                                 this.ReadOnlyListInterfaceOfDateTimeProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfDateTimeProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfDateTimeProperty">The new <see cref="ReadOnlyListInterfaceOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetReadOnlyList" /> using the specified <paramref name="readOnlyListInterfaceOfDateTimeProperty" /> for <see cref="ReadOnlyListInterfaceOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetReadOnlyList DeepCloneWithReadOnlyListInterfaceOfDateTimeProperty(IReadOnlyList<DateTime> readOnlyListInterfaceOfDateTimeProperty)
        {
            var result = new ModelAllPrivateSetReadOnlyList(
                                 this.ReadOnlyListInterfaceOfBoolProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfIntProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ReadOnlyListInterfaceOfGuidProperty?.Select(i => i).ToList(),
                                 readOnlyListInterfaceOfDateTimeProperty,
                                 this.ReadOnlyListInterfaceOfCustomEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfCustomEnumProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfCustomEnumProperty">The new <see cref="ReadOnlyListInterfaceOfCustomEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetReadOnlyList" /> using the specified <paramref name="readOnlyListInterfaceOfCustomEnumProperty" /> for <see cref="ReadOnlyListInterfaceOfCustomEnumProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetReadOnlyList DeepCloneWithReadOnlyListInterfaceOfCustomEnumProperty(IReadOnlyList<CustomEnum> readOnlyListInterfaceOfCustomEnumProperty)
        {
            var result = new ModelAllPrivateSetReadOnlyList(
                                 this.ReadOnlyListInterfaceOfBoolProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfIntProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ReadOnlyListInterfaceOfGuidProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfDateTimeProperty?.Select(i => i).ToList(),
                                 readOnlyListInterfaceOfCustomEnumProperty,
                                 this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfCustomFlagsEnumProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfCustomFlagsEnumProperty">The new <see cref="ReadOnlyListInterfaceOfCustomFlagsEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetReadOnlyList" /> using the specified <paramref name="readOnlyListInterfaceOfCustomFlagsEnumProperty" /> for <see cref="ReadOnlyListInterfaceOfCustomFlagsEnumProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetReadOnlyList DeepCloneWithReadOnlyListInterfaceOfCustomFlagsEnumProperty(IReadOnlyList<CustomFlagsEnum> readOnlyListInterfaceOfCustomFlagsEnumProperty)
        {
            var result = new ModelAllPrivateSetReadOnlyList(
                                 this.ReadOnlyListInterfaceOfBoolProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfIntProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ReadOnlyListInterfaceOfGuidProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfDateTimeProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomEnumProperty?.Select(i => i).ToList(),
                                 readOnlyListInterfaceOfCustomFlagsEnumProperty,
                                 this.ReadOnlyListInterfaceOfCustomClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfCustomClassProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfCustomClassProperty">The new <see cref="ReadOnlyListInterfaceOfCustomClassProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetReadOnlyList" /> using the specified <paramref name="readOnlyListInterfaceOfCustomClassProperty" /> for <see cref="ReadOnlyListInterfaceOfCustomClassProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetReadOnlyList DeepCloneWithReadOnlyListInterfaceOfCustomClassProperty(IReadOnlyList<CustomClass> readOnlyListInterfaceOfCustomClassProperty)
        {
            var result = new ModelAllPrivateSetReadOnlyList(
                                 this.ReadOnlyListInterfaceOfBoolProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfIntProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ReadOnlyListInterfaceOfGuidProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfDateTimeProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty?.Select(i => i).ToList(),
                                 readOnlyListInterfaceOfCustomClassProperty,
                                 this.ReadOnlyListInterfaceOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToList());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfCustomBaseClassProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfCustomBaseClassProperty">The new <see cref="ReadOnlyListInterfaceOfCustomBaseClassProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetReadOnlyList" /> using the specified <paramref name="readOnlyListInterfaceOfCustomBaseClassProperty" /> for <see cref="ReadOnlyListInterfaceOfCustomBaseClassProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetReadOnlyList DeepCloneWithReadOnlyListInterfaceOfCustomBaseClassProperty(IReadOnlyList<CustomBaseClass> readOnlyListInterfaceOfCustomBaseClassProperty)
        {
            var result = new ModelAllPrivateSetReadOnlyList(
                                 this.ReadOnlyListInterfaceOfBoolProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfIntProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ReadOnlyListInterfaceOfGuidProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfDateTimeProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty?.Select(i => i).ToList(),
                                 this.ReadOnlyListInterfaceOfCustomClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 readOnlyListInterfaceOfCustomBaseClassProperty);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.ModelAllPrivateSetReadOnlyList: ReadOnlyListInterfaceOfBoolProperty = {this.ReadOnlyListInterfaceOfBoolProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfIntProperty = {this.ReadOnlyListInterfaceOfIntProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfStringProperty = {this.ReadOnlyListInterfaceOfStringProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfGuidProperty = {this.ReadOnlyListInterfaceOfGuidProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfDateTimeProperty = {this.ReadOnlyListInterfaceOfDateTimeProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfCustomEnumProperty = {this.ReadOnlyListInterfaceOfCustomEnumProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfCustomFlagsEnumProperty = {this.ReadOnlyListInterfaceOfCustomFlagsEnumProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfCustomClassProperty = {this.ReadOnlyListInterfaceOfCustomClassProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfCustomBaseClassProperty = {this.ReadOnlyListInterfaceOfCustomBaseClassProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}