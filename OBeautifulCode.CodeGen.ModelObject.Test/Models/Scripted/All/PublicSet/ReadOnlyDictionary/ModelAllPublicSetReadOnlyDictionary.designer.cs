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
    public partial class ModelAllPublicSetReadOnlyDictionary : IModel<ModelAllPublicSetReadOnlyDictionary>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelAllPublicSetReadOnlyDictionary"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelAllPublicSetReadOnlyDictionary left, ModelAllPublicSetReadOnlyDictionary right)
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
        /// Determines whether two objects of type <see cref="ModelAllPublicSetReadOnlyDictionary"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelAllPublicSetReadOnlyDictionary left, ModelAllPublicSetReadOnlyDictionary right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelAllPublicSetReadOnlyDictionary other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ReadOnlyDictionaryInterfaceOfBoolProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfBoolProperty)
                      && this.ReadOnlyDictionaryInterfaceOfIntProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfIntProperty)
                      && this.ReadOnlyDictionaryInterfaceOfStringProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfStringProperty)
                      && this.ReadOnlyDictionaryInterfaceOfGuidProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfGuidProperty)
                      && this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfCustomEnumProperty)
                      && this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty)
                      && this.ReadOnlyDictionaryInterfaceOfCustomClassProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfCustomClassProperty)
                      && this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModelAllPublicSetReadOnlyDictionary);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ReadOnlyDictionaryInterfaceOfBoolProperty)
            .Hash(this.ReadOnlyDictionaryInterfaceOfIntProperty)
            .Hash(this.ReadOnlyDictionaryInterfaceOfStringProperty)
            .Hash(this.ReadOnlyDictionaryInterfaceOfGuidProperty)
            .Hash(this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty)
            .Hash(this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty)
            .Hash(this.ReadOnlyDictionaryInterfaceOfCustomClassProperty)
            .Hash(this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModelAllPublicSetReadOnlyDictionary DeepClone()
        {
            var result = new ModelAllPublicSetReadOnlyDictionary
                             {
                                 ReadOnlyDictionaryInterfaceOfBoolProperty            = this.ReadOnlyDictionaryInterfaceOfBoolProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfIntProperty             = this.ReadOnlyDictionaryInterfaceOfIntProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfStringProperty          = this.ReadOnlyDictionaryInterfaceOfStringProperty?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 ReadOnlyDictionaryInterfaceOfGuidProperty            = this.ReadOnlyDictionaryInterfaceOfGuidProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomEnumProperty      = this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomClassProperty     = this.ReadOnlyDictionaryInterfaceOfCustomClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyDictionaryInterfaceOfBoolProperty" />.
        /// </summary>
        /// <param name="readOnlyDictionaryInterfaceOfBoolProperty">The new <see cref="ReadOnlyDictionaryInterfaceOfBoolProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionary" /> using the specified <paramref name="readOnlyDictionaryInterfaceOfBoolProperty" /> for <see cref="ReadOnlyDictionaryInterfaceOfBoolProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyDictionary DeepCloneWithReadOnlyDictionaryInterfaceOfBoolProperty(IReadOnlyDictionary<bool, bool> readOnlyDictionaryInterfaceOfBoolProperty)
        {
            var result = new ModelAllPublicSetReadOnlyDictionary
                             {
                                 ReadOnlyDictionaryInterfaceOfBoolProperty            = readOnlyDictionaryInterfaceOfBoolProperty,
                                 ReadOnlyDictionaryInterfaceOfIntProperty             = this.ReadOnlyDictionaryInterfaceOfIntProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfStringProperty          = this.ReadOnlyDictionaryInterfaceOfStringProperty?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 ReadOnlyDictionaryInterfaceOfGuidProperty            = this.ReadOnlyDictionaryInterfaceOfGuidProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomEnumProperty      = this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomClassProperty     = this.ReadOnlyDictionaryInterfaceOfCustomClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyDictionaryInterfaceOfIntProperty" />.
        /// </summary>
        /// <param name="readOnlyDictionaryInterfaceOfIntProperty">The new <see cref="ReadOnlyDictionaryInterfaceOfIntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionary" /> using the specified <paramref name="readOnlyDictionaryInterfaceOfIntProperty" /> for <see cref="ReadOnlyDictionaryInterfaceOfIntProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyDictionary DeepCloneWithReadOnlyDictionaryInterfaceOfIntProperty(IReadOnlyDictionary<int, int> readOnlyDictionaryInterfaceOfIntProperty)
        {
            var result = new ModelAllPublicSetReadOnlyDictionary
                             {
                                 ReadOnlyDictionaryInterfaceOfBoolProperty            = this.ReadOnlyDictionaryInterfaceOfBoolProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfIntProperty             = readOnlyDictionaryInterfaceOfIntProperty,
                                 ReadOnlyDictionaryInterfaceOfStringProperty          = this.ReadOnlyDictionaryInterfaceOfStringProperty?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 ReadOnlyDictionaryInterfaceOfGuidProperty            = this.ReadOnlyDictionaryInterfaceOfGuidProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomEnumProperty      = this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomClassProperty     = this.ReadOnlyDictionaryInterfaceOfCustomClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyDictionaryInterfaceOfStringProperty" />.
        /// </summary>
        /// <param name="readOnlyDictionaryInterfaceOfStringProperty">The new <see cref="ReadOnlyDictionaryInterfaceOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionary" /> using the specified <paramref name="readOnlyDictionaryInterfaceOfStringProperty" /> for <see cref="ReadOnlyDictionaryInterfaceOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyDictionary DeepCloneWithReadOnlyDictionaryInterfaceOfStringProperty(IReadOnlyDictionary<string, string> readOnlyDictionaryInterfaceOfStringProperty)
        {
            var result = new ModelAllPublicSetReadOnlyDictionary
                             {
                                 ReadOnlyDictionaryInterfaceOfBoolProperty            = this.ReadOnlyDictionaryInterfaceOfBoolProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfIntProperty             = this.ReadOnlyDictionaryInterfaceOfIntProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfStringProperty          = readOnlyDictionaryInterfaceOfStringProperty,
                                 ReadOnlyDictionaryInterfaceOfGuidProperty            = this.ReadOnlyDictionaryInterfaceOfGuidProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomEnumProperty      = this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomClassProperty     = this.ReadOnlyDictionaryInterfaceOfCustomClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyDictionaryInterfaceOfGuidProperty" />.
        /// </summary>
        /// <param name="readOnlyDictionaryInterfaceOfGuidProperty">The new <see cref="ReadOnlyDictionaryInterfaceOfGuidProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionary" /> using the specified <paramref name="readOnlyDictionaryInterfaceOfGuidProperty" /> for <see cref="ReadOnlyDictionaryInterfaceOfGuidProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyDictionary DeepCloneWithReadOnlyDictionaryInterfaceOfGuidProperty(IReadOnlyDictionary<Guid, Guid> readOnlyDictionaryInterfaceOfGuidProperty)
        {
            var result = new ModelAllPublicSetReadOnlyDictionary
                             {
                                 ReadOnlyDictionaryInterfaceOfBoolProperty            = this.ReadOnlyDictionaryInterfaceOfBoolProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfIntProperty             = this.ReadOnlyDictionaryInterfaceOfIntProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfStringProperty          = this.ReadOnlyDictionaryInterfaceOfStringProperty?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 ReadOnlyDictionaryInterfaceOfGuidProperty            = readOnlyDictionaryInterfaceOfGuidProperty,
                                 ReadOnlyDictionaryInterfaceOfCustomEnumProperty      = this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomClassProperty     = this.ReadOnlyDictionaryInterfaceOfCustomClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyDictionaryInterfaceOfCustomEnumProperty" />.
        /// </summary>
        /// <param name="readOnlyDictionaryInterfaceOfCustomEnumProperty">The new <see cref="ReadOnlyDictionaryInterfaceOfCustomEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionary" /> using the specified <paramref name="readOnlyDictionaryInterfaceOfCustomEnumProperty" /> for <see cref="ReadOnlyDictionaryInterfaceOfCustomEnumProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyDictionary DeepCloneWithReadOnlyDictionaryInterfaceOfCustomEnumProperty(IReadOnlyDictionary<CustomEnum, CustomEnum> readOnlyDictionaryInterfaceOfCustomEnumProperty)
        {
            var result = new ModelAllPublicSetReadOnlyDictionary
                             {
                                 ReadOnlyDictionaryInterfaceOfBoolProperty            = this.ReadOnlyDictionaryInterfaceOfBoolProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfIntProperty             = this.ReadOnlyDictionaryInterfaceOfIntProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfStringProperty          = this.ReadOnlyDictionaryInterfaceOfStringProperty?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 ReadOnlyDictionaryInterfaceOfGuidProperty            = this.ReadOnlyDictionaryInterfaceOfGuidProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomEnumProperty      = readOnlyDictionaryInterfaceOfCustomEnumProperty,
                                 ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomClassProperty     = this.ReadOnlyDictionaryInterfaceOfCustomClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty" />.
        /// </summary>
        /// <param name="readOnlyDictionaryInterfaceOfCustomFlagsEnumProperty">The new <see cref="ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionary" /> using the specified <paramref name="readOnlyDictionaryInterfaceOfCustomFlagsEnumProperty" /> for <see cref="ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyDictionary DeepCloneWithReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty(IReadOnlyDictionary<CustomFlagsEnum, CustomFlagsEnum> readOnlyDictionaryInterfaceOfCustomFlagsEnumProperty)
        {
            var result = new ModelAllPublicSetReadOnlyDictionary
                             {
                                 ReadOnlyDictionaryInterfaceOfBoolProperty            = this.ReadOnlyDictionaryInterfaceOfBoolProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfIntProperty             = this.ReadOnlyDictionaryInterfaceOfIntProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfStringProperty          = this.ReadOnlyDictionaryInterfaceOfStringProperty?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 ReadOnlyDictionaryInterfaceOfGuidProperty            = this.ReadOnlyDictionaryInterfaceOfGuidProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomEnumProperty      = this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = readOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                 ReadOnlyDictionaryInterfaceOfCustomClassProperty     = this.ReadOnlyDictionaryInterfaceOfCustomClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyDictionaryInterfaceOfCustomClassProperty" />.
        /// </summary>
        /// <param name="readOnlyDictionaryInterfaceOfCustomClassProperty">The new <see cref="ReadOnlyDictionaryInterfaceOfCustomClassProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionary" /> using the specified <paramref name="readOnlyDictionaryInterfaceOfCustomClassProperty" /> for <see cref="ReadOnlyDictionaryInterfaceOfCustomClassProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyDictionary DeepCloneWithReadOnlyDictionaryInterfaceOfCustomClassProperty(IReadOnlyDictionary<CustomClass, CustomClass> readOnlyDictionaryInterfaceOfCustomClassProperty)
        {
            var result = new ModelAllPublicSetReadOnlyDictionary
                             {
                                 ReadOnlyDictionaryInterfaceOfBoolProperty            = this.ReadOnlyDictionaryInterfaceOfBoolProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfIntProperty             = this.ReadOnlyDictionaryInterfaceOfIntProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfStringProperty          = this.ReadOnlyDictionaryInterfaceOfStringProperty?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 ReadOnlyDictionaryInterfaceOfGuidProperty            = this.ReadOnlyDictionaryInterfaceOfGuidProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomEnumProperty      = this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomClassProperty     = readOnlyDictionaryInterfaceOfCustomClassProperty,
                                 ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty" />.
        /// </summary>
        /// <param name="readOnlyDictionaryInterfaceOfCustomBaseClassProperty">The new <see cref="ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyDictionary" /> using the specified <paramref name="readOnlyDictionaryInterfaceOfCustomBaseClassProperty" /> for <see cref="ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyDictionary DeepCloneWithReadOnlyDictionaryInterfaceOfCustomBaseClassProperty(IReadOnlyDictionary<CustomBaseClass, CustomBaseClass> readOnlyDictionaryInterfaceOfCustomBaseClassProperty)
        {
            var result = new ModelAllPublicSetReadOnlyDictionary
                             {
                                 ReadOnlyDictionaryInterfaceOfBoolProperty            = this.ReadOnlyDictionaryInterfaceOfBoolProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfIntProperty             = this.ReadOnlyDictionaryInterfaceOfIntProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfStringProperty          = this.ReadOnlyDictionaryInterfaceOfStringProperty?.ToDictionary(k => k.Key?.Clone().ToString(), v => v.Value?.Clone().ToString()),
                                 ReadOnlyDictionaryInterfaceOfGuidProperty            = this.ReadOnlyDictionaryInterfaceOfGuidProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomEnumProperty      = this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty?.ToDictionary(k => k.Key, v => v.Value),
                                 ReadOnlyDictionaryInterfaceOfCustomClassProperty     = this.ReadOnlyDictionaryInterfaceOfCustomClassProperty?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = readOnlyDictionaryInterfaceOfCustomBaseClassProperty,
                             };

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.ModelAllPublicSetReadOnlyDictionary: ReadOnlyDictionaryInterfaceOfBoolProperty = {this.ReadOnlyDictionaryInterfaceOfBoolProperty?.ToString() ?? "<null>"}, ReadOnlyDictionaryInterfaceOfIntProperty = {this.ReadOnlyDictionaryInterfaceOfIntProperty?.ToString() ?? "<null>"}, ReadOnlyDictionaryInterfaceOfStringProperty = {this.ReadOnlyDictionaryInterfaceOfStringProperty?.ToString() ?? "<null>"}, ReadOnlyDictionaryInterfaceOfGuidProperty = {this.ReadOnlyDictionaryInterfaceOfGuidProperty?.ToString() ?? "<null>"}, ReadOnlyDictionaryInterfaceOfCustomEnumProperty = {this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty?.ToString() ?? "<null>"}, ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = {this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty?.ToString() ?? "<null>"}, ReadOnlyDictionaryInterfaceOfCustomClassProperty = {this.ReadOnlyDictionaryInterfaceOfCustomClassProperty?.ToString() ?? "<null>"}, ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = {this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}