﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPrivateSetArrayOfNullableChild2.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPrivateSetArrayOfNullableChild2 : ModelCloningPrivateSetArrayOfNullableParent, IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPrivateSetArrayOfNullableChild2>, IEquatable<ModelCloningPrivateSetArrayOfNullableChild2>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelCloningPrivateSetArrayOfNullableChild2(
            bool?[] parentArrayOfNullableBoolProperty,
            int?[] parentArrayOfNullableIntProperty,
            Guid?[] parentArrayOfNullableGuidProperty,
            DateTime?[] parentArrayOfNullableDateTimeProperty,
            CustomEnum?[] parentArrayOfNullableCustomEnumProperty,
            CustomFlagsEnum?[] parentArrayOfNullableCustomFlagsEnumProperty,
            bool?[] child2ArrayOfNullableBoolProperty,
            int?[] child2ArrayOfNullableIntProperty,
            Guid?[] child2ArrayOfNullableGuidProperty,
            DateTime?[] child2ArrayOfNullableDateTimeProperty,
            CustomEnum?[] child2ArrayOfNullableCustomEnumProperty,
            CustomFlagsEnum?[] child2ArrayOfNullableCustomFlagsEnumProperty)
            : base(parentArrayOfNullableBoolProperty, parentArrayOfNullableIntProperty, parentArrayOfNullableGuidProperty, parentArrayOfNullableDateTimeProperty, parentArrayOfNullableCustomEnumProperty, parentArrayOfNullableCustomFlagsEnumProperty)
        {
            new { child2ArrayOfNullableBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfNullableIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfNullableGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfNullableDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfNullableCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfNullableCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();

            this.Child2ArrayOfNullableBoolProperty = child2ArrayOfNullableBoolProperty;
            this.Child2ArrayOfNullableIntProperty = child2ArrayOfNullableIntProperty;
            this.Child2ArrayOfNullableGuidProperty = child2ArrayOfNullableGuidProperty;
            this.Child2ArrayOfNullableDateTimeProperty = child2ArrayOfNullableDateTimeProperty;
            this.Child2ArrayOfNullableCustomEnumProperty = child2ArrayOfNullableCustomEnumProperty;
            this.Child2ArrayOfNullableCustomFlagsEnumProperty = child2ArrayOfNullableCustomFlagsEnumProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public bool?[] Child2ArrayOfNullableBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int?[] Child2ArrayOfNullableIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Guid?[] Child2ArrayOfNullableGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public DateTime?[] Child2ArrayOfNullableDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomEnum?[] Child2ArrayOfNullableCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomFlagsEnum?[] Child2ArrayOfNullableCustomFlagsEnumProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPrivateSetArrayOfNullableChild2 other)
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
                this.ParentArrayOfNullableBoolProperty.IsEqualTo(other.ParentArrayOfNullableBoolProperty) &&
                this.ParentArrayOfNullableIntProperty.IsEqualTo(other.ParentArrayOfNullableIntProperty) &&
                this.ParentArrayOfNullableGuidProperty.IsEqualTo(other.ParentArrayOfNullableGuidProperty) &&
                this.ParentArrayOfNullableDateTimeProperty.IsEqualTo(other.ParentArrayOfNullableDateTimeProperty) &&
                this.ParentArrayOfNullableCustomEnumProperty.IsEqualTo(other.ParentArrayOfNullableCustomEnumProperty) &&
                this.ParentArrayOfNullableCustomFlagsEnumProperty.IsEqualTo(other.ParentArrayOfNullableCustomFlagsEnumProperty) &&
                this.Child2ArrayOfNullableBoolProperty.IsEqualTo(other.Child2ArrayOfNullableBoolProperty) &&
                this.Child2ArrayOfNullableIntProperty.IsEqualTo(other.Child2ArrayOfNullableIntProperty) &&
                this.Child2ArrayOfNullableGuidProperty.IsEqualTo(other.Child2ArrayOfNullableGuidProperty) &&
                this.Child2ArrayOfNullableDateTimeProperty.IsEqualTo(other.Child2ArrayOfNullableDateTimeProperty) &&
                this.Child2ArrayOfNullableCustomEnumProperty.IsEqualTo(other.Child2ArrayOfNullableCustomEnumProperty) &&
                this.Child2ArrayOfNullableCustomFlagsEnumProperty.IsEqualTo(other.Child2ArrayOfNullableCustomFlagsEnumProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(ModelCloningPrivateSetArrayOfNullableParent other)
        {
            var result = this.Equals((ModelCloningPrivateSetArrayOfNullableChild2)other);

            return result;
        }

        /// <inheritdoc />
        ModelCloningPrivateSetArrayOfNullableChild2 IDeclareDeepCloneMethod<ModelCloningPrivateSetArrayOfNullableChild2>.DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPrivateSetArrayOfNullableChild2 DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPrivateSetArrayOfNullableChild2>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPrivateSetArrayOfNullableChild2)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPrivateSetArrayOfNullableChild2>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}