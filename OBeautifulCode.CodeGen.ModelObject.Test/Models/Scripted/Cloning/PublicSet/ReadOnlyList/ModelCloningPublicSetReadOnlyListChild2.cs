﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPublicSetReadOnlyListChild2.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    using FakeItEasy;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

#pragma warning disable CS0659
#pragma warning disable CS0661
    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    public partial class ModelCloningPublicSetReadOnlyListChild2 : ModelCloningPublicSetReadOnlyListParent, IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPublicSetReadOnlyListChild2>, IEquatable<ModelCloningPublicSetReadOnlyListChild2>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<bool> Child2ReadOnlyListInterfaceOfBoolProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<int> Child2ReadOnlyListInterfaceOfIntProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<string> Child2ReadOnlyListInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<Guid> Child2ReadOnlyListInterfaceOfGuidProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<DateTime> Child2ReadOnlyListInterfaceOfDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomEnum> Child2ReadOnlyListInterfaceOfCustomEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomFlagsEnum> Child2ReadOnlyListInterfaceOfCustomFlagsEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomClass> Child2ReadOnlyListInterfaceOfCustomClassProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomBaseClass> Child2ReadOnlyListInterfaceOfCustomBaseClassProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyList<CustomGenericClass<CustomClass>> Child2ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPublicSetReadOnlyListChild2 other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = 
                this.ParentReadOnlyListInterfaceOfBoolProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfBoolProperty) &&
                this.ParentReadOnlyListInterfaceOfIntProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfIntProperty) &&
                this.ParentReadOnlyListInterfaceOfStringProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfStringProperty) &&
                this.ParentReadOnlyListInterfaceOfGuidProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfGuidProperty) &&
                this.ParentReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfDateTimeProperty) &&
                this.ParentReadOnlyListInterfaceOfCustomEnumProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfCustomEnumProperty) &&
                this.ParentReadOnlyListInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfCustomFlagsEnumProperty) &&
                this.ParentReadOnlyListInterfaceOfCustomClassProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfCustomClassProperty) &&
                this.ParentReadOnlyListInterfaceOfCustomBaseClassProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfCustomBaseClassProperty) &&
                this.ParentReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.ParentReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty) &&
                this.Child2ReadOnlyListInterfaceOfBoolProperty.IsEqualTo(other.Child2ReadOnlyListInterfaceOfBoolProperty) &&
                this.Child2ReadOnlyListInterfaceOfIntProperty.IsEqualTo(other.Child2ReadOnlyListInterfaceOfIntProperty) &&
                this.Child2ReadOnlyListInterfaceOfStringProperty.IsEqualTo(other.Child2ReadOnlyListInterfaceOfStringProperty) &&
                this.Child2ReadOnlyListInterfaceOfGuidProperty.IsEqualTo(other.Child2ReadOnlyListInterfaceOfGuidProperty) &&
                this.Child2ReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(other.Child2ReadOnlyListInterfaceOfDateTimeProperty) &&
                this.Child2ReadOnlyListInterfaceOfCustomEnumProperty.IsEqualTo(other.Child2ReadOnlyListInterfaceOfCustomEnumProperty) &&
                this.Child2ReadOnlyListInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.Child2ReadOnlyListInterfaceOfCustomFlagsEnumProperty) &&
                this.Child2ReadOnlyListInterfaceOfCustomClassProperty.IsEqualTo(other.Child2ReadOnlyListInterfaceOfCustomClassProperty) &&
                this.Child2ReadOnlyListInterfaceOfCustomBaseClassProperty.IsEqualTo(other.Child2ReadOnlyListInterfaceOfCustomBaseClassProperty) &&
                this.Child2ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.Child2ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(ModelCloningPublicSetReadOnlyListParent other)
        {
            var result = this.Equals((ModelCloningPublicSetReadOnlyListChild2)other);

            return result;
        }

        /// <inheritdoc />
        ModelCloningPublicSetReadOnlyListChild2 IDeclareDeepCloneMethod<ModelCloningPublicSetReadOnlyListChild2>.DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPublicSetReadOnlyListChild2 DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPublicSetReadOnlyListChild2>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPublicSetReadOnlyListChild2)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPublicSetReadOnlyListChild2>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}