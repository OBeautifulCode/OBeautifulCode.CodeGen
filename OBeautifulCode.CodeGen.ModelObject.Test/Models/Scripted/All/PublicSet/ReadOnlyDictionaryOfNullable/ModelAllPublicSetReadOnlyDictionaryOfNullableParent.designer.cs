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
    public partial class ModelAllPublicSetReadOnlyDictionaryOfNullableParent : IModel<ModelAllPublicSetReadOnlyDictionaryOfNullableParent>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelAllPublicSetReadOnlyDictionaryOfNullableParent"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelAllPublicSetReadOnlyDictionaryOfNullableParent left, ModelAllPublicSetReadOnlyDictionaryOfNullableParent right)
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
        /// Determines whether two objects of type <see cref="ModelAllPublicSetReadOnlyDictionaryOfNullableParent"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelAllPublicSetReadOnlyDictionaryOfNullableParent left, ModelAllPublicSetReadOnlyDictionaryOfNullableParent right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelAllPublicSetReadOnlyDictionaryOfNullableParent other) => this == other;

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            throw new NotImplementedException("This method should be abstract.  It was generated as virtual so that you aren't forced to override it when you create a new model that derives from this model.  It will be overriden in the generated designer file.");
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            throw new NotImplementedException("This method should be abstract.  It was generated as virtual so that you aren't forced to override it when you create a new model that derives from this model.  It will be overriden in the generated designer file.");
        }

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModelAllPublicSetReadOnlyDictionaryOfNullableParent DeepClone() => this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryInterfaceOfNullableBoolProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryInterfaceOfNullableBoolProperty">The new <see cref="ParentReadOnlyDictionaryInterfaceOfNullableBoolProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionaryOfNullableParent" /> using the specified <paramref name="parentReadOnlyDictionaryInterfaceOfNullableBoolProperty" /> for <see cref="ParentReadOnlyDictionaryInterfaceOfNullableBoolProperty" /> and a deep clone of every other property.</returns>
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
        public virtual ModelAllPublicSetReadOnlyDictionaryOfNullableParent DeepCloneWithParentReadOnlyDictionaryInterfaceOfNullableBoolProperty(IReadOnlyDictionary<bool?, bool?> parentReadOnlyDictionaryInterfaceOfNullableBoolProperty)
        {
            throw new NotImplementedException("This method should be abstract.  It was generated as virtual so that you aren't forced to override it when you create a new model that derives from this model.  It will be overriden in the generated designer file.");
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryInterfaceOfNullableIntProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryInterfaceOfNullableIntProperty">The new <see cref="ParentReadOnlyDictionaryInterfaceOfNullableIntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionaryOfNullableParent" /> using the specified <paramref name="parentReadOnlyDictionaryInterfaceOfNullableIntProperty" /> for <see cref="ParentReadOnlyDictionaryInterfaceOfNullableIntProperty" /> and a deep clone of every other property.</returns>
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
        public virtual ModelAllPublicSetReadOnlyDictionaryOfNullableParent DeepCloneWithParentReadOnlyDictionaryInterfaceOfNullableIntProperty(IReadOnlyDictionary<int?, int?> parentReadOnlyDictionaryInterfaceOfNullableIntProperty)
        {
            throw new NotImplementedException("This method should be abstract.  It was generated as virtual so that you aren't forced to override it when you create a new model that derives from this model.  It will be overriden in the generated designer file.");
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryInterfaceOfNullableGuidProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryInterfaceOfNullableGuidProperty">The new <see cref="ParentReadOnlyDictionaryInterfaceOfNullableGuidProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionaryOfNullableParent" /> using the specified <paramref name="parentReadOnlyDictionaryInterfaceOfNullableGuidProperty" /> for <see cref="ParentReadOnlyDictionaryInterfaceOfNullableGuidProperty" /> and a deep clone of every other property.</returns>
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
        public virtual ModelAllPublicSetReadOnlyDictionaryOfNullableParent DeepCloneWithParentReadOnlyDictionaryInterfaceOfNullableGuidProperty(IReadOnlyDictionary<Guid?, Guid?> parentReadOnlyDictionaryInterfaceOfNullableGuidProperty)
        {
            throw new NotImplementedException("This method should be abstract.  It was generated as virtual so that you aren't forced to override it when you create a new model that derives from this model.  It will be overriden in the generated designer file.");
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty">The new <see cref="ParentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionaryOfNullableParent" /> using the specified <paramref name="parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty" /> for <see cref="ParentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty" /> and a deep clone of every other property.</returns>
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
        public virtual ModelAllPublicSetReadOnlyDictionaryOfNullableParent DeepCloneWithParentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty(IReadOnlyDictionary<CustomEnum?, CustomEnum?> parentReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty)
        {
            throw new NotImplementedException("This method should be abstract.  It was generated as virtual so that you aren't forced to override it when you create a new model that derives from this model.  It will be overriden in the generated designer file.");
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty">The new <see cref="ParentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionaryOfNullableParent" /> using the specified <paramref name="parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty" /> for <see cref="ParentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty" /> and a deep clone of every other property.</returns>
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
        public virtual ModelAllPublicSetReadOnlyDictionaryOfNullableParent DeepCloneWithParentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty(IReadOnlyDictionary<CustomFlagsEnum?, CustomFlagsEnum?> parentReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)
        {
            throw new NotImplementedException("This method should be abstract.  It was generated as virtual so that you aren't forced to override it when you create a new model that derives from this model.  It will be overriden in the generated designer file.");
        }

        /// <summary>
        /// Creates a new object that is a deep clone of this instance.
        /// </summary>
        /// <returns>
        /// A new object that is a deep clone of this instance.
        /// </returns>
        protected virtual ModelAllPublicSetReadOnlyDictionaryOfNullableParent DeepCloneInternal()
        {
            throw new NotImplementedException("This method should be abstract.  It was generated as virtual so that you aren't forced to override it when you create a new model that derives from this model.  It will be overriden in the generated designer file.");
        }

        /// <inheritdoc />
        public override string ToString()
        {
            throw new NotImplementedException("This method should be abstract.  It was generated as virtual so that you aren't forced to override it when you create a new model that derives from this model.  It will be overriden in the generated designer file.");
        }
    }
}