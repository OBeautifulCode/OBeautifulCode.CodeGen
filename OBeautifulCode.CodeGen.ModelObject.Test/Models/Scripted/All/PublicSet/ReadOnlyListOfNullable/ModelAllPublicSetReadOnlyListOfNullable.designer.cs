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
    public partial class ModelAllPublicSetReadOnlyListOfNullable : IModel<ModelAllPublicSetReadOnlyListOfNullable>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelAllPublicSetReadOnlyListOfNullable"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelAllPublicSetReadOnlyListOfNullable left, ModelAllPublicSetReadOnlyListOfNullable right)
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
        /// Determines whether two objects of type <see cref="ModelAllPublicSetReadOnlyListOfNullable"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelAllPublicSetReadOnlyListOfNullable left, ModelAllPublicSetReadOnlyListOfNullable right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ModelAllPublicSetReadOnlyListOfNullable other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableBoolProperty)
                      && this.ReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableIntProperty)
                      && this.ReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableGuidProperty)
                      && this.ReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableDateTimeProperty)
                      && this.ReadOnlyListInterfaceOfNullableCustomEnumProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableCustomEnumProperty)
                      && this.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(other.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModelAllPublicSetReadOnlyListOfNullable);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ReadOnlyListInterfaceOfNullableBoolProperty)
            .Hash(this.ReadOnlyListInterfaceOfNullableIntProperty)
            .Hash(this.ReadOnlyListInterfaceOfNullableGuidProperty)
            .Hash(this.ReadOnlyListInterfaceOfNullableDateTimeProperty)
            .Hash(this.ReadOnlyListInterfaceOfNullableCustomEnumProperty)
            .Hash(this.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public ModelAllPublicSetReadOnlyListOfNullable DeepClone()
        {
            var result = new ModelAllPublicSetReadOnlyListOfNullable
                             {
                                 ReadOnlyListInterfaceOfNullableBoolProperty            = this.ReadOnlyListInterfaceOfNullableBoolProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableIntProperty             = this.ReadOnlyListInterfaceOfNullableIntProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableGuidProperty            = this.ReadOnlyListInterfaceOfNullableGuidProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableDateTimeProperty        = this.ReadOnlyListInterfaceOfNullableDateTimeProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomEnumProperty      = this.ReadOnlyListInterfaceOfNullableCustomEnumProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = this.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty?.DeepClone(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfNullableBoolProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfNullableBoolProperty">The new <see cref="ReadOnlyListInterfaceOfNullableBoolProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyListOfNullable" /> using the specified <paramref name="readOnlyListInterfaceOfNullableBoolProperty" /> for <see cref="ReadOnlyListInterfaceOfNullableBoolProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyListOfNullable DeepCloneWithReadOnlyListInterfaceOfNullableBoolProperty(IReadOnlyList<bool?> readOnlyListInterfaceOfNullableBoolProperty)
        {
            var result = new ModelAllPublicSetReadOnlyListOfNullable
                             {
                                 ReadOnlyListInterfaceOfNullableBoolProperty            = readOnlyListInterfaceOfNullableBoolProperty,
                                 ReadOnlyListInterfaceOfNullableIntProperty             = this.ReadOnlyListInterfaceOfNullableIntProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableGuidProperty            = this.ReadOnlyListInterfaceOfNullableGuidProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableDateTimeProperty        = this.ReadOnlyListInterfaceOfNullableDateTimeProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomEnumProperty      = this.ReadOnlyListInterfaceOfNullableCustomEnumProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = this.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty?.DeepClone(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfNullableIntProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfNullableIntProperty">The new <see cref="ReadOnlyListInterfaceOfNullableIntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyListOfNullable" /> using the specified <paramref name="readOnlyListInterfaceOfNullableIntProperty" /> for <see cref="ReadOnlyListInterfaceOfNullableIntProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyListOfNullable DeepCloneWithReadOnlyListInterfaceOfNullableIntProperty(IReadOnlyList<int?> readOnlyListInterfaceOfNullableIntProperty)
        {
            var result = new ModelAllPublicSetReadOnlyListOfNullable
                             {
                                 ReadOnlyListInterfaceOfNullableBoolProperty            = this.ReadOnlyListInterfaceOfNullableBoolProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableIntProperty             = readOnlyListInterfaceOfNullableIntProperty,
                                 ReadOnlyListInterfaceOfNullableGuidProperty            = this.ReadOnlyListInterfaceOfNullableGuidProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableDateTimeProperty        = this.ReadOnlyListInterfaceOfNullableDateTimeProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomEnumProperty      = this.ReadOnlyListInterfaceOfNullableCustomEnumProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = this.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty?.DeepClone(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfNullableGuidProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfNullableGuidProperty">The new <see cref="ReadOnlyListInterfaceOfNullableGuidProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyListOfNullable" /> using the specified <paramref name="readOnlyListInterfaceOfNullableGuidProperty" /> for <see cref="ReadOnlyListInterfaceOfNullableGuidProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyListOfNullable DeepCloneWithReadOnlyListInterfaceOfNullableGuidProperty(IReadOnlyList<Guid?> readOnlyListInterfaceOfNullableGuidProperty)
        {
            var result = new ModelAllPublicSetReadOnlyListOfNullable
                             {
                                 ReadOnlyListInterfaceOfNullableBoolProperty            = this.ReadOnlyListInterfaceOfNullableBoolProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableIntProperty             = this.ReadOnlyListInterfaceOfNullableIntProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableGuidProperty            = readOnlyListInterfaceOfNullableGuidProperty,
                                 ReadOnlyListInterfaceOfNullableDateTimeProperty        = this.ReadOnlyListInterfaceOfNullableDateTimeProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomEnumProperty      = this.ReadOnlyListInterfaceOfNullableCustomEnumProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = this.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty?.DeepClone(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfNullableDateTimeProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfNullableDateTimeProperty">The new <see cref="ReadOnlyListInterfaceOfNullableDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyListOfNullable" /> using the specified <paramref name="readOnlyListInterfaceOfNullableDateTimeProperty" /> for <see cref="ReadOnlyListInterfaceOfNullableDateTimeProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyListOfNullable DeepCloneWithReadOnlyListInterfaceOfNullableDateTimeProperty(IReadOnlyList<DateTime?> readOnlyListInterfaceOfNullableDateTimeProperty)
        {
            var result = new ModelAllPublicSetReadOnlyListOfNullable
                             {
                                 ReadOnlyListInterfaceOfNullableBoolProperty            = this.ReadOnlyListInterfaceOfNullableBoolProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableIntProperty             = this.ReadOnlyListInterfaceOfNullableIntProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableGuidProperty            = this.ReadOnlyListInterfaceOfNullableGuidProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableDateTimeProperty        = readOnlyListInterfaceOfNullableDateTimeProperty,
                                 ReadOnlyListInterfaceOfNullableCustomEnumProperty      = this.ReadOnlyListInterfaceOfNullableCustomEnumProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = this.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty?.DeepClone(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfNullableCustomEnumProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfNullableCustomEnumProperty">The new <see cref="ReadOnlyListInterfaceOfNullableCustomEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyListOfNullable" /> using the specified <paramref name="readOnlyListInterfaceOfNullableCustomEnumProperty" /> for <see cref="ReadOnlyListInterfaceOfNullableCustomEnumProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyListOfNullable DeepCloneWithReadOnlyListInterfaceOfNullableCustomEnumProperty(IReadOnlyList<CustomEnum?> readOnlyListInterfaceOfNullableCustomEnumProperty)
        {
            var result = new ModelAllPublicSetReadOnlyListOfNullable
                             {
                                 ReadOnlyListInterfaceOfNullableBoolProperty            = this.ReadOnlyListInterfaceOfNullableBoolProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableIntProperty             = this.ReadOnlyListInterfaceOfNullableIntProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableGuidProperty            = this.ReadOnlyListInterfaceOfNullableGuidProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableDateTimeProperty        = this.ReadOnlyListInterfaceOfNullableDateTimeProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomEnumProperty      = readOnlyListInterfaceOfNullableCustomEnumProperty,
                                 ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = this.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty?.DeepClone(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty" />.
        /// </summary>
        /// <param name="readOnlyListInterfaceOfNullableCustomFlagsEnumProperty">The new <see cref="ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ModelAllPublicSetReadOnlyListOfNullable" /> using the specified <paramref name="readOnlyListInterfaceOfNullableCustomFlagsEnumProperty" /> for <see cref="ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty" /> and a deep clone of every other property.</returns>
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
        public ModelAllPublicSetReadOnlyListOfNullable DeepCloneWithReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty(IReadOnlyList<CustomFlagsEnum?> readOnlyListInterfaceOfNullableCustomFlagsEnumProperty)
        {
            var result = new ModelAllPublicSetReadOnlyListOfNullable
                             {
                                 ReadOnlyListInterfaceOfNullableBoolProperty            = this.ReadOnlyListInterfaceOfNullableBoolProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableIntProperty             = this.ReadOnlyListInterfaceOfNullableIntProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableGuidProperty            = this.ReadOnlyListInterfaceOfNullableGuidProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableDateTimeProperty        = this.ReadOnlyListInterfaceOfNullableDateTimeProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomEnumProperty      = this.ReadOnlyListInterfaceOfNullableCustomEnumProperty?.DeepClone(),
                                 ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = readOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                             };

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"OBeautifulCode.CodeGen.ModelObject.Test.ModelAllPublicSetReadOnlyListOfNullable: ReadOnlyListInterfaceOfNullableBoolProperty = {this.ReadOnlyListInterfaceOfNullableBoolProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfNullableIntProperty = {this.ReadOnlyListInterfaceOfNullableIntProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfNullableGuidProperty = {this.ReadOnlyListInterfaceOfNullableGuidProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfNullableDateTimeProperty = {this.ReadOnlyListInterfaceOfNullableDateTimeProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfNullableCustomEnumProperty = {this.ReadOnlyListInterfaceOfNullableCustomEnumProperty?.ToString() ?? "<null>"}, ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = {this.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}