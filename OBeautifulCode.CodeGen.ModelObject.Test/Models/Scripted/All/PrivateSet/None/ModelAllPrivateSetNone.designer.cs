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
    public partial class ModelAllPrivateSetNone : IModel<ModelAllPrivateSetNone>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelAllPrivateSetNone"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelAllPrivateSetNone left, ModelAllPrivateSetNone right)
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
        /// Determines whether two objects of type <see cref="ModelAllPrivateSetNone"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelAllPrivateSetNone left, ModelAllPrivateSetNone right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelAllPrivateSetNone other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.BoolProperty.IsEqualTo(other.BoolProperty)
                      && this.IntProperty.IsEqualTo(other.IntProperty)
                      && this.StringProperty.IsEqualTo(other.StringProperty, StringComparer.Ordinal)
                      && this.GuidProperty.IsEqualTo(other.GuidProperty)
                      && this.DateTimeProperty.IsEqualTo(other.DateTimeProperty)
                      && this.CustomEnumProperty.IsEqualTo(other.CustomEnumProperty)
                      && this.CustomFlagsEnumProperty.IsEqualTo(other.CustomFlagsEnumProperty)
                      && this.CustomClassProperty.IsEqualTo(other.CustomClassProperty)
                      && this.CustomBaseClassProperty.IsEqualTo(other.CustomBaseClassProperty)
                      && this.CustomGenericClassOfCustomClassProperty.IsEqualTo(other.CustomGenericClassOfCustomClassProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModelAllPrivateSetNone);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.BoolProperty)
            .Hash(this.IntProperty)
            .Hash(this.StringProperty)
            .Hash(this.GuidProperty)
            .Hash(this.DateTimeProperty)
            .Hash(this.CustomEnumProperty)
            .Hash(this.CustomFlagsEnumProperty)
            .Hash(this.CustomClassProperty)
            .Hash(this.CustomBaseClassProperty)
            .Hash(this.CustomGenericClassOfCustomClassProperty)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModelAllPrivateSetNone DeepClone()
        {
            var result = new ModelAllPrivateSetNone(
                                 this.BoolProperty.DeepClone(),
                                 this.IntProperty.DeepClone(),
                                 this.StringProperty?.DeepClone(),
                                 this.GuidProperty.DeepClone(),
                                 this.DateTimeProperty.DeepClone(),
                                 this.CustomEnumProperty.DeepClone(),
                                 this.CustomFlagsEnumProperty.DeepClone(),
                                 this.CustomClassProperty?.DeepClone(),
                                 this.CustomBaseClassProperty?.DeepClone(),
                                 this.CustomGenericClassOfCustomClassProperty?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="BoolProperty" />.
        /// </summary>
        /// <param name="boolProperty">The new <see cref="BoolProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetNone" /> using the specified <paramref name="boolProperty" /> for <see cref="BoolProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetNone DeepCloneWithBoolProperty(bool boolProperty)
        {
            var result = new ModelAllPrivateSetNone(
                                 boolProperty,
                                 this.IntProperty.DeepClone(),
                                 this.StringProperty?.DeepClone(),
                                 this.GuidProperty.DeepClone(),
                                 this.DateTimeProperty.DeepClone(),
                                 this.CustomEnumProperty.DeepClone(),
                                 this.CustomFlagsEnumProperty.DeepClone(),
                                 this.CustomClassProperty?.DeepClone(),
                                 this.CustomBaseClassProperty?.DeepClone(),
                                 this.CustomGenericClassOfCustomClassProperty?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="IntProperty" />.
        /// </summary>
        /// <param name="intProperty">The new <see cref="IntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetNone" /> using the specified <paramref name="intProperty" /> for <see cref="IntProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetNone DeepCloneWithIntProperty(int intProperty)
        {
            var result = new ModelAllPrivateSetNone(
                                 this.BoolProperty.DeepClone(),
                                 intProperty,
                                 this.StringProperty?.DeepClone(),
                                 this.GuidProperty.DeepClone(),
                                 this.DateTimeProperty.DeepClone(),
                                 this.CustomEnumProperty.DeepClone(),
                                 this.CustomFlagsEnumProperty.DeepClone(),
                                 this.CustomClassProperty?.DeepClone(),
                                 this.CustomBaseClassProperty?.DeepClone(),
                                 this.CustomGenericClassOfCustomClassProperty?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="StringProperty" />.
        /// </summary>
        /// <param name="stringProperty">The new <see cref="StringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetNone" /> using the specified <paramref name="stringProperty" /> for <see cref="StringProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetNone DeepCloneWithStringProperty(string stringProperty)
        {
            var result = new ModelAllPrivateSetNone(
                                 this.BoolProperty.DeepClone(),
                                 this.IntProperty.DeepClone(),
                                 stringProperty,
                                 this.GuidProperty.DeepClone(),
                                 this.DateTimeProperty.DeepClone(),
                                 this.CustomEnumProperty.DeepClone(),
                                 this.CustomFlagsEnumProperty.DeepClone(),
                                 this.CustomClassProperty?.DeepClone(),
                                 this.CustomBaseClassProperty?.DeepClone(),
                                 this.CustomGenericClassOfCustomClassProperty?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="GuidProperty" />.
        /// </summary>
        /// <param name="guidProperty">The new <see cref="GuidProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetNone" /> using the specified <paramref name="guidProperty" /> for <see cref="GuidProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetNone DeepCloneWithGuidProperty(Guid guidProperty)
        {
            var result = new ModelAllPrivateSetNone(
                                 this.BoolProperty.DeepClone(),
                                 this.IntProperty.DeepClone(),
                                 this.StringProperty?.DeepClone(),
                                 guidProperty,
                                 this.DateTimeProperty.DeepClone(),
                                 this.CustomEnumProperty.DeepClone(),
                                 this.CustomFlagsEnumProperty.DeepClone(),
                                 this.CustomClassProperty?.DeepClone(),
                                 this.CustomBaseClassProperty?.DeepClone(),
                                 this.CustomGenericClassOfCustomClassProperty?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="DateTimeProperty" />.
        /// </summary>
        /// <param name="dateTimeProperty">The new <see cref="DateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetNone" /> using the specified <paramref name="dateTimeProperty" /> for <see cref="DateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetNone DeepCloneWithDateTimeProperty(DateTime dateTimeProperty)
        {
            var result = new ModelAllPrivateSetNone(
                                 this.BoolProperty.DeepClone(),
                                 this.IntProperty.DeepClone(),
                                 this.StringProperty?.DeepClone(),
                                 this.GuidProperty.DeepClone(),
                                 dateTimeProperty,
                                 this.CustomEnumProperty.DeepClone(),
                                 this.CustomFlagsEnumProperty.DeepClone(),
                                 this.CustomClassProperty?.DeepClone(),
                                 this.CustomBaseClassProperty?.DeepClone(),
                                 this.CustomGenericClassOfCustomClassProperty?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CustomEnumProperty" />.
        /// </summary>
        /// <param name="customEnumProperty">The new <see cref="CustomEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetNone" /> using the specified <paramref name="customEnumProperty" /> for <see cref="CustomEnumProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetNone DeepCloneWithCustomEnumProperty(CustomEnum customEnumProperty)
        {
            var result = new ModelAllPrivateSetNone(
                                 this.BoolProperty.DeepClone(),
                                 this.IntProperty.DeepClone(),
                                 this.StringProperty?.DeepClone(),
                                 this.GuidProperty.DeepClone(),
                                 this.DateTimeProperty.DeepClone(),
                                 customEnumProperty,
                                 this.CustomFlagsEnumProperty.DeepClone(),
                                 this.CustomClassProperty?.DeepClone(),
                                 this.CustomBaseClassProperty?.DeepClone(),
                                 this.CustomGenericClassOfCustomClassProperty?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CustomFlagsEnumProperty" />.
        /// </summary>
        /// <param name="customFlagsEnumProperty">The new <see cref="CustomFlagsEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetNone" /> using the specified <paramref name="customFlagsEnumProperty" /> for <see cref="CustomFlagsEnumProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetNone DeepCloneWithCustomFlagsEnumProperty(CustomFlagsEnum customFlagsEnumProperty)
        {
            var result = new ModelAllPrivateSetNone(
                                 this.BoolProperty.DeepClone(),
                                 this.IntProperty.DeepClone(),
                                 this.StringProperty?.DeepClone(),
                                 this.GuidProperty.DeepClone(),
                                 this.DateTimeProperty.DeepClone(),
                                 this.CustomEnumProperty.DeepClone(),
                                 customFlagsEnumProperty,
                                 this.CustomClassProperty?.DeepClone(),
                                 this.CustomBaseClassProperty?.DeepClone(),
                                 this.CustomGenericClassOfCustomClassProperty?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CustomClassProperty" />.
        /// </summary>
        /// <param name="customClassProperty">The new <see cref="CustomClassProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetNone" /> using the specified <paramref name="customClassProperty" /> for <see cref="CustomClassProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetNone DeepCloneWithCustomClassProperty(CustomClass customClassProperty)
        {
            var result = new ModelAllPrivateSetNone(
                                 this.BoolProperty.DeepClone(),
                                 this.IntProperty.DeepClone(),
                                 this.StringProperty?.DeepClone(),
                                 this.GuidProperty.DeepClone(),
                                 this.DateTimeProperty.DeepClone(),
                                 this.CustomEnumProperty.DeepClone(),
                                 this.CustomFlagsEnumProperty.DeepClone(),
                                 customClassProperty,
                                 this.CustomBaseClassProperty?.DeepClone(),
                                 this.CustomGenericClassOfCustomClassProperty?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CustomBaseClassProperty" />.
        /// </summary>
        /// <param name="customBaseClassProperty">The new <see cref="CustomBaseClassProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetNone" /> using the specified <paramref name="customBaseClassProperty" /> for <see cref="CustomBaseClassProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetNone DeepCloneWithCustomBaseClassProperty(CustomBaseClass customBaseClassProperty)
        {
            var result = new ModelAllPrivateSetNone(
                                 this.BoolProperty.DeepClone(),
                                 this.IntProperty.DeepClone(),
                                 this.StringProperty?.DeepClone(),
                                 this.GuidProperty.DeepClone(),
                                 this.DateTimeProperty.DeepClone(),
                                 this.CustomEnumProperty.DeepClone(),
                                 this.CustomFlagsEnumProperty.DeepClone(),
                                 this.CustomClassProperty?.DeepClone(),
                                 customBaseClassProperty,
                                 this.CustomGenericClassOfCustomClassProperty?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CustomGenericClassOfCustomClassProperty" />.
        /// </summary>
        /// <param name="customGenericClassOfCustomClassProperty">The new <see cref="CustomGenericClassOfCustomClassProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPrivateSetNone" /> using the specified <paramref name="customGenericClassOfCustomClassProperty" /> for <see cref="CustomGenericClassOfCustomClassProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPrivateSetNone DeepCloneWithCustomGenericClassOfCustomClassProperty(CustomGenericClass<CustomClass> customGenericClassOfCustomClassProperty)
        {
            var result = new ModelAllPrivateSetNone(
                                 this.BoolProperty.DeepClone(),
                                 this.IntProperty.DeepClone(),
                                 this.StringProperty?.DeepClone(),
                                 this.GuidProperty.DeepClone(),
                                 this.DateTimeProperty.DeepClone(),
                                 this.CustomEnumProperty.DeepClone(),
                                 this.CustomFlagsEnumProperty.DeepClone(),
                                 this.CustomClassProperty?.DeepClone(),
                                 this.CustomBaseClassProperty?.DeepClone(),
                                 customGenericClassOfCustomClassProperty);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.ModelAllPrivateSetNone: BoolProperty = {this.BoolProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, IntProperty = {this.IntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, StringProperty = {this.StringProperty?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, GuidProperty = {this.GuidProperty.ToString() ?? "<null>"}, DateTimeProperty = {this.DateTimeProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, CustomEnumProperty = {this.CustomEnumProperty.ToString() ?? "<null>"}, CustomFlagsEnumProperty = {this.CustomFlagsEnumProperty.ToString() ?? "<null>"}, CustomClassProperty = {this.CustomClassProperty?.ToString() ?? "<null>"}, CustomBaseClassProperty = {this.CustomBaseClassProperty?.ToString() ?? "<null>"}, CustomGenericClassOfCustomClassProperty = {this.CustomGenericClassOfCustomClassProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}