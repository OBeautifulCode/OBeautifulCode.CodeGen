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
    public partial class ModelAllPrivateSetArray : IModel<ModelAllPrivateSetArray>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelAllPrivateSetArray"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelAllPrivateSetArray left, ModelAllPrivateSetArray right)
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
        /// Determines whether two objects of type <see cref="ModelAllPrivateSetArray"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelAllPrivateSetArray left, ModelAllPrivateSetArray right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelAllPrivateSetArray other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ArrayOfBoolProperty.IsEqualTo(other.ArrayOfBoolProperty)
                      && this.ArrayOfIntProperty.IsEqualTo(other.ArrayOfIntProperty)
                      && this.ArrayOfStringProperty.IsEqualTo(other.ArrayOfStringProperty)
                      && this.ArrayOfGuidProperty.IsEqualTo(other.ArrayOfGuidProperty)
                      && this.ArrayOfDateTimeProperty.IsEqualTo(other.ArrayOfDateTimeProperty)
                      && this.ArrayOfCustomEnumProperty.IsEqualTo(other.ArrayOfCustomEnumProperty)
                      && this.ArrayOfCustomFlagsEnumProperty.IsEqualTo(other.ArrayOfCustomFlagsEnumProperty)
                      && this.ArrayOfCustomClassProperty.IsEqualTo(other.ArrayOfCustomClassProperty)
                      && this.ArrayOfCustomBaseClassProperty.IsEqualTo(other.ArrayOfCustomBaseClassProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModelAllPrivateSetArray);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ArrayOfBoolProperty)
            .Hash(this.ArrayOfIntProperty)
            .Hash(this.ArrayOfStringProperty)
            .Hash(this.ArrayOfGuidProperty)
            .Hash(this.ArrayOfDateTimeProperty)
            .Hash(this.ArrayOfCustomEnumProperty)
            .Hash(this.ArrayOfCustomFlagsEnumProperty)
            .Hash(this.ArrayOfCustomClassProperty)
            .Hash(this.ArrayOfCustomBaseClassProperty)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModelAllPrivateSetArray DeepClone()
        {
            var result = new ModelAllPrivateSetArray(
                                 this.ArrayOfBoolProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfIntProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfStringProperty?.Select(i => i?.Clone().ToString()).ToArray(),
                                 this.ArrayOfGuidProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfDateTimeProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomFlagsEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomClassProperty?.Select(i => i?.DeepClone()).ToArray(),
                                 this.ArrayOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToArray());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ArrayOfBoolProperty" />.
        /// </summary>
        /// <param name="arrayOfBoolProperty">The new <see cref="ArrayOfBoolProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetArray" /> using the specified <paramref name="arrayOfBoolProperty" /> for <see cref="ArrayOfBoolProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetArray DeepCloneWithArrayOfBoolProperty(bool[] arrayOfBoolProperty)
        {
            var result = new ModelAllPrivateSetArray(
                                 arrayOfBoolProperty,
                                 this.ArrayOfIntProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfStringProperty?.Select(i => i?.Clone().ToString()).ToArray(),
                                 this.ArrayOfGuidProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfDateTimeProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomFlagsEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomClassProperty?.Select(i => i?.DeepClone()).ToArray(),
                                 this.ArrayOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToArray());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ArrayOfIntProperty" />.
        /// </summary>
        /// <param name="arrayOfIntProperty">The new <see cref="ArrayOfIntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetArray" /> using the specified <paramref name="arrayOfIntProperty" /> for <see cref="ArrayOfIntProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetArray DeepCloneWithArrayOfIntProperty(int[] arrayOfIntProperty)
        {
            var result = new ModelAllPrivateSetArray(
                                 this.ArrayOfBoolProperty?.Select(i => i).ToArray(),
                                 arrayOfIntProperty,
                                 this.ArrayOfStringProperty?.Select(i => i?.Clone().ToString()).ToArray(),
                                 this.ArrayOfGuidProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfDateTimeProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomFlagsEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomClassProperty?.Select(i => i?.DeepClone()).ToArray(),
                                 this.ArrayOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToArray());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ArrayOfStringProperty" />.
        /// </summary>
        /// <param name="arrayOfStringProperty">The new <see cref="ArrayOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetArray" /> using the specified <paramref name="arrayOfStringProperty" /> for <see cref="ArrayOfStringProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetArray DeepCloneWithArrayOfStringProperty(string[] arrayOfStringProperty)
        {
            var result = new ModelAllPrivateSetArray(
                                 this.ArrayOfBoolProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfIntProperty?.Select(i => i).ToArray(),
                                 arrayOfStringProperty,
                                 this.ArrayOfGuidProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfDateTimeProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomFlagsEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomClassProperty?.Select(i => i?.DeepClone()).ToArray(),
                                 this.ArrayOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToArray());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ArrayOfGuidProperty" />.
        /// </summary>
        /// <param name="arrayOfGuidProperty">The new <see cref="ArrayOfGuidProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetArray" /> using the specified <paramref name="arrayOfGuidProperty" /> for <see cref="ArrayOfGuidProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetArray DeepCloneWithArrayOfGuidProperty(Guid[] arrayOfGuidProperty)
        {
            var result = new ModelAllPrivateSetArray(
                                 this.ArrayOfBoolProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfIntProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfStringProperty?.Select(i => i?.Clone().ToString()).ToArray(),
                                 arrayOfGuidProperty,
                                 this.ArrayOfDateTimeProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomFlagsEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomClassProperty?.Select(i => i?.DeepClone()).ToArray(),
                                 this.ArrayOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToArray());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ArrayOfDateTimeProperty" />.
        /// </summary>
        /// <param name="arrayOfDateTimeProperty">The new <see cref="ArrayOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetArray" /> using the specified <paramref name="arrayOfDateTimeProperty" /> for <see cref="ArrayOfDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetArray DeepCloneWithArrayOfDateTimeProperty(DateTime[] arrayOfDateTimeProperty)
        {
            var result = new ModelAllPrivateSetArray(
                                 this.ArrayOfBoolProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfIntProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfStringProperty?.Select(i => i?.Clone().ToString()).ToArray(),
                                 this.ArrayOfGuidProperty?.Select(i => i).ToArray(),
                                 arrayOfDateTimeProperty,
                                 this.ArrayOfCustomEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomFlagsEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomClassProperty?.Select(i => i?.DeepClone()).ToArray(),
                                 this.ArrayOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToArray());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ArrayOfCustomEnumProperty" />.
        /// </summary>
        /// <param name="arrayOfCustomEnumProperty">The new <see cref="ArrayOfCustomEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetArray" /> using the specified <paramref name="arrayOfCustomEnumProperty" /> for <see cref="ArrayOfCustomEnumProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetArray DeepCloneWithArrayOfCustomEnumProperty(CustomEnum[] arrayOfCustomEnumProperty)
        {
            var result = new ModelAllPrivateSetArray(
                                 this.ArrayOfBoolProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfIntProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfStringProperty?.Select(i => i?.Clone().ToString()).ToArray(),
                                 this.ArrayOfGuidProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfDateTimeProperty?.Select(i => i).ToArray(),
                                 arrayOfCustomEnumProperty,
                                 this.ArrayOfCustomFlagsEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomClassProperty?.Select(i => i?.DeepClone()).ToArray(),
                                 this.ArrayOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToArray());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ArrayOfCustomFlagsEnumProperty" />.
        /// </summary>
        /// <param name="arrayOfCustomFlagsEnumProperty">The new <see cref="ArrayOfCustomFlagsEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetArray" /> using the specified <paramref name="arrayOfCustomFlagsEnumProperty" /> for <see cref="ArrayOfCustomFlagsEnumProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetArray DeepCloneWithArrayOfCustomFlagsEnumProperty(CustomFlagsEnum[] arrayOfCustomFlagsEnumProperty)
        {
            var result = new ModelAllPrivateSetArray(
                                 this.ArrayOfBoolProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfIntProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfStringProperty?.Select(i => i?.Clone().ToString()).ToArray(),
                                 this.ArrayOfGuidProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfDateTimeProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomEnumProperty?.Select(i => i).ToArray(),
                                 arrayOfCustomFlagsEnumProperty,
                                 this.ArrayOfCustomClassProperty?.Select(i => i?.DeepClone()).ToArray(),
                                 this.ArrayOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToArray());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ArrayOfCustomClassProperty" />.
        /// </summary>
        /// <param name="arrayOfCustomClassProperty">The new <see cref="ArrayOfCustomClassProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetArray" /> using the specified <paramref name="arrayOfCustomClassProperty" /> for <see cref="ArrayOfCustomClassProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetArray DeepCloneWithArrayOfCustomClassProperty(CustomClass[] arrayOfCustomClassProperty)
        {
            var result = new ModelAllPrivateSetArray(
                                 this.ArrayOfBoolProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfIntProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfStringProperty?.Select(i => i?.Clone().ToString()).ToArray(),
                                 this.ArrayOfGuidProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfDateTimeProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomFlagsEnumProperty?.Select(i => i).ToArray(),
                                 arrayOfCustomClassProperty,
                                 this.ArrayOfCustomBaseClassProperty?.Select(i => i?.DeepClone()).ToArray());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ArrayOfCustomBaseClassProperty" />.
        /// </summary>
        /// <param name="arrayOfCustomBaseClassProperty">The new <see cref="ArrayOfCustomBaseClassProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetArray" /> using the specified <paramref name="arrayOfCustomBaseClassProperty" /> for <see cref="ArrayOfCustomBaseClassProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetArray DeepCloneWithArrayOfCustomBaseClassProperty(CustomBaseClass[] arrayOfCustomBaseClassProperty)
        {
            var result = new ModelAllPrivateSetArray(
                                 this.ArrayOfBoolProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfIntProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfStringProperty?.Select(i => i?.Clone().ToString()).ToArray(),
                                 this.ArrayOfGuidProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfDateTimeProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomFlagsEnumProperty?.Select(i => i).ToArray(),
                                 this.ArrayOfCustomClassProperty?.Select(i => i?.DeepClone()).ToArray(),
                                 arrayOfCustomBaseClassProperty);

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.ModelAllPrivateSetArray: ArrayOfBoolProperty = {this.ArrayOfBoolProperty?.ToString() ?? "<null>"}, ArrayOfIntProperty = {this.ArrayOfIntProperty?.ToString() ?? "<null>"}, ArrayOfStringProperty = {this.ArrayOfStringProperty?.ToString() ?? "<null>"}, ArrayOfGuidProperty = {this.ArrayOfGuidProperty?.ToString() ?? "<null>"}, ArrayOfDateTimeProperty = {this.ArrayOfDateTimeProperty?.ToString() ?? "<null>"}, ArrayOfCustomEnumProperty = {this.ArrayOfCustomEnumProperty?.ToString() ?? "<null>"}, ArrayOfCustomFlagsEnumProperty = {this.ArrayOfCustomFlagsEnumProperty?.ToString() ?? "<null>"}, ArrayOfCustomClassProperty = {this.ArrayOfCustomClassProperty?.ToString() ?? "<null>"}, ArrayOfCustomBaseClassProperty = {this.ArrayOfCustomBaseClassProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}