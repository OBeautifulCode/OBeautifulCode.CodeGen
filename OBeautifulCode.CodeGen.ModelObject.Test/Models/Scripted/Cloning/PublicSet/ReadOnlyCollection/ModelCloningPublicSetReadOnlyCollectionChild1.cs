﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPublicSetReadOnlyCollectionChild1.cs" company="OBeautifulCode">
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

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

#pragma warning disable CS0659
#pragma warning disable CS0661
    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = ObcSuppressBecause.CA1711_IdentifiersShouldNotHaveIncorrectSuffix_TypeNameAddedAsSuffixForTestsWhereTypeIsPrimaryConcern)]
    public partial class ModelCloningPublicSetReadOnlyCollectionChild1 : ModelCloningPublicSetReadOnlyCollectionParent, IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPublicSetReadOnlyCollectionChild1>, IEquatable<ModelCloningPublicSetReadOnlyCollectionChild1>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<bool> Child1ReadOnlyCollectionInterfaceOfBoolProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<int> Child1ReadOnlyCollectionInterfaceOfIntProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<string> Child1ReadOnlyCollectionInterfaceOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<Guid> Child1ReadOnlyCollectionInterfaceOfGuidProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<DateTime> Child1ReadOnlyCollectionInterfaceOfDateTimeProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomEnum> Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomFlagsEnum> Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomClass> Child1ReadOnlyCollectionInterfaceOfCustomClassProperty { get; set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPublicSetReadOnlyCollectionChild1 other)
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
                this.ParentReadOnlyCollectionInterfaceOfBoolProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfBoolProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfIntProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfIntProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfStringProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfStringProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfGuidProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfGuidProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfDateTimeProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfDateTimeProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty) &&
                this.ParentReadOnlyCollectionInterfaceOfCustomClassProperty.IsEqualTo(other.ParentReadOnlyCollectionInterfaceOfCustomClassProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfBoolProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfBoolProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfIntProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfIntProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfStringProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfStringProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfGuidProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfGuidProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty) &&
                this.Child1ReadOnlyCollectionInterfaceOfCustomClassProperty.IsEqualTo(other.Child1ReadOnlyCollectionInterfaceOfCustomClassProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(ModelCloningPublicSetReadOnlyCollectionParent other)
        {
            var result = this.Equals((ModelCloningPublicSetReadOnlyCollectionChild1)other);

            return result;
        }

        /// <inheritdoc />
        ModelCloningPublicSetReadOnlyCollectionChild1 IDeclareDeepCloneMethod<ModelCloningPublicSetReadOnlyCollectionChild1>.DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPublicSetReadOnlyCollectionChild1 DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPublicSetReadOnlyCollectionChild1>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPublicSetReadOnlyCollectionChild1)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPublicSetReadOnlyCollectionChild1>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}