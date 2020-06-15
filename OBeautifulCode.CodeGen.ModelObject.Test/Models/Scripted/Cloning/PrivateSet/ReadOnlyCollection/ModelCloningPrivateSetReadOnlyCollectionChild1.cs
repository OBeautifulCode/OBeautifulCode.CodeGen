﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPrivateSetReadOnlyCollectionChild1.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPrivateSetReadOnlyCollectionChild1 : ModelCloningPrivateSetReadOnlyCollectionParent, IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPrivateSetReadOnlyCollectionChild1>, IEquatable<ModelCloningPrivateSetReadOnlyCollectionChild1>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelCloningPrivateSetReadOnlyCollectionChild1(
            IReadOnlyCollection<bool> parentReadOnlyCollectionInterfaceOfBoolProperty,
            IReadOnlyCollection<int> parentReadOnlyCollectionInterfaceOfIntProperty,
            IReadOnlyCollection<string> parentReadOnlyCollectionInterfaceOfStringProperty,
            IReadOnlyCollection<Guid> parentReadOnlyCollectionInterfaceOfGuidProperty,
            IReadOnlyCollection<DateTime> parentReadOnlyCollectionInterfaceOfDateTimeProperty,
            IReadOnlyCollection<CustomEnum> parentReadOnlyCollectionInterfaceOfCustomEnumProperty,
            IReadOnlyCollection<CustomFlagsEnum> parentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyCollection<CustomClass> parentReadOnlyCollectionInterfaceOfCustomClassProperty,
            IReadOnlyCollection<bool> child1ReadOnlyCollectionInterfaceOfBoolProperty,
            IReadOnlyCollection<int> child1ReadOnlyCollectionInterfaceOfIntProperty,
            IReadOnlyCollection<string> child1ReadOnlyCollectionInterfaceOfStringProperty,
            IReadOnlyCollection<Guid> child1ReadOnlyCollectionInterfaceOfGuidProperty,
            IReadOnlyCollection<DateTime> child1ReadOnlyCollectionInterfaceOfDateTimeProperty,
            IReadOnlyCollection<CustomEnum> child1ReadOnlyCollectionInterfaceOfCustomEnumProperty,
            IReadOnlyCollection<CustomFlagsEnum> child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyCollection<CustomClass> child1ReadOnlyCollectionInterfaceOfCustomClassProperty)
            : base(parentReadOnlyCollectionInterfaceOfBoolProperty, parentReadOnlyCollectionInterfaceOfIntProperty, parentReadOnlyCollectionInterfaceOfStringProperty, parentReadOnlyCollectionInterfaceOfGuidProperty, parentReadOnlyCollectionInterfaceOfDateTimeProperty, parentReadOnlyCollectionInterfaceOfCustomEnumProperty, parentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty, parentReadOnlyCollectionInterfaceOfCustomClassProperty)
        {
            new { child1ReadOnlyCollectionInterfaceOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionInterfaceOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child1ReadOnlyCollectionInterfaceOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionInterfaceOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionInterfaceOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child1ReadOnlyCollectionInterfaceOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.Child1ReadOnlyCollectionInterfaceOfBoolProperty = child1ReadOnlyCollectionInterfaceOfBoolProperty;
            this.Child1ReadOnlyCollectionInterfaceOfIntProperty = child1ReadOnlyCollectionInterfaceOfIntProperty;
            this.Child1ReadOnlyCollectionInterfaceOfStringProperty = child1ReadOnlyCollectionInterfaceOfStringProperty;
            this.Child1ReadOnlyCollectionInterfaceOfGuidProperty = child1ReadOnlyCollectionInterfaceOfGuidProperty;
            this.Child1ReadOnlyCollectionInterfaceOfDateTimeProperty = child1ReadOnlyCollectionInterfaceOfDateTimeProperty;
            this.Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty = child1ReadOnlyCollectionInterfaceOfCustomEnumProperty;
            this.Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty = child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty;
            this.Child1ReadOnlyCollectionInterfaceOfCustomClassProperty = child1ReadOnlyCollectionInterfaceOfCustomClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<bool> Child1ReadOnlyCollectionInterfaceOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<int> Child1ReadOnlyCollectionInterfaceOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<string> Child1ReadOnlyCollectionInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<Guid> Child1ReadOnlyCollectionInterfaceOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<DateTime> Child1ReadOnlyCollectionInterfaceOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomEnum> Child1ReadOnlyCollectionInterfaceOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomFlagsEnum> Child1ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyCollection<CustomClass> Child1ReadOnlyCollectionInterfaceOfCustomClassProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPrivateSetReadOnlyCollectionChild1 other)
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
        public override bool Equals(ModelCloningPrivateSetReadOnlyCollectionParent other)
        {
            var result = this.Equals((ModelCloningPrivateSetReadOnlyCollectionChild1)other);

            return result;
        }

        /// <inheritdoc />
        ModelCloningPrivateSetReadOnlyCollectionChild1 IDeclareDeepCloneMethod<ModelCloningPrivateSetReadOnlyCollectionChild1>.DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPrivateSetReadOnlyCollectionChild1 DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPrivateSetReadOnlyCollectionChild1>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPrivateSetReadOnlyCollectionChild1)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPrivateSetReadOnlyCollectionChild1>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}