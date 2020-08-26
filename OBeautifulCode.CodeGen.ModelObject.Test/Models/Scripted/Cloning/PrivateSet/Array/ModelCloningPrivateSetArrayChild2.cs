﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPrivateSetArrayChild2.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPrivateSetArrayChild2 : ModelCloningPrivateSetArrayParent, IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPrivateSetArrayChild2>, IEquatable<ModelCloningPrivateSetArrayChild2>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelCloningPrivateSetArrayChild2(
            bool[] parentArrayOfBoolProperty,
            int[] parentArrayOfIntProperty,
            string[] parentArrayOfStringProperty,
            Guid[] parentArrayOfGuidProperty,
            DateTime[] parentArrayOfDateTimeProperty,
            CustomEnum[] parentArrayOfCustomEnumProperty,
            CustomFlagsEnum[] parentArrayOfCustomFlagsEnumProperty,
            CustomClass[] parentArrayOfCustomClassProperty,
            CustomBaseClass[] parentArrayOfCustomBaseClassProperty,
            CustomGenericClass<CustomClass>[] parentArrayOfCustomGenericClassOfCustomClassProperty,
            bool[] child2ArrayOfBoolProperty,
            int[] child2ArrayOfIntProperty,
            string[] child2ArrayOfStringProperty,
            Guid[] child2ArrayOfGuidProperty,
            DateTime[] child2ArrayOfDateTimeProperty,
            CustomEnum[] child2ArrayOfCustomEnumProperty,
            CustomFlagsEnum[] child2ArrayOfCustomFlagsEnumProperty,
            CustomClass[] child2ArrayOfCustomClassProperty,
            CustomBaseClass[] child2ArrayOfCustomBaseClassProperty,
            CustomGenericClass<CustomClass>[] child2ArrayOfCustomGenericClassOfCustomClassProperty)
            : base(parentArrayOfBoolProperty, parentArrayOfIntProperty, parentArrayOfStringProperty, parentArrayOfGuidProperty, parentArrayOfDateTimeProperty, parentArrayOfCustomEnumProperty, parentArrayOfCustomFlagsEnumProperty, parentArrayOfCustomClassProperty, parentArrayOfCustomBaseClassProperty, parentArrayOfCustomGenericClassOfCustomClassProperty)
        {
            new { child2ArrayOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfIntProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2ArrayOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfDateTimeProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyEnumerable();
            new { child2ArrayOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2ArrayOfCustomBaseClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { child2ArrayOfCustomGenericClassOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.Child2ArrayOfBoolProperty = child2ArrayOfBoolProperty;
            this.Child2ArrayOfIntProperty = child2ArrayOfIntProperty;
            this.Child2ArrayOfStringProperty = child2ArrayOfStringProperty;
            this.Child2ArrayOfGuidProperty = child2ArrayOfGuidProperty;
            this.Child2ArrayOfDateTimeProperty = child2ArrayOfDateTimeProperty;
            this.Child2ArrayOfCustomEnumProperty = child2ArrayOfCustomEnumProperty;
            this.Child2ArrayOfCustomFlagsEnumProperty = child2ArrayOfCustomFlagsEnumProperty;
            this.Child2ArrayOfCustomClassProperty = child2ArrayOfCustomClassProperty;
            this.Child2ArrayOfCustomBaseClassProperty = child2ArrayOfCustomBaseClassProperty;
            this.Child2ArrayOfCustomGenericClassOfCustomClassProperty = child2ArrayOfCustomGenericClassOfCustomClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public bool[] Child2ArrayOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public int[] Child2ArrayOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public string[] Child2ArrayOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Guid[] Child2ArrayOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public DateTime[] Child2ArrayOfDateTimeProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomEnum[] Child2ArrayOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomFlagsEnum[] Child2ArrayOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomClass[] Child2ArrayOfCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomBaseClass[] Child2ArrayOfCustomBaseClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public CustomGenericClass<CustomClass>[] Child2ArrayOfCustomGenericClassOfCustomClassProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPrivateSetArrayChild2 other)
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
                this.ParentArrayOfBoolProperty.IsEqualTo(other.ParentArrayOfBoolProperty) &&
                this.ParentArrayOfIntProperty.IsEqualTo(other.ParentArrayOfIntProperty) &&
                this.ParentArrayOfStringProperty.IsEqualTo(other.ParentArrayOfStringProperty) &&
                this.ParentArrayOfGuidProperty.IsEqualTo(other.ParentArrayOfGuidProperty) &&
                this.ParentArrayOfDateTimeProperty.IsEqualTo(other.ParentArrayOfDateTimeProperty) &&
                this.ParentArrayOfCustomEnumProperty.IsEqualTo(other.ParentArrayOfCustomEnumProperty) &&
                this.ParentArrayOfCustomFlagsEnumProperty.IsEqualTo(other.ParentArrayOfCustomFlagsEnumProperty) &&
                this.ParentArrayOfCustomClassProperty.IsEqualTo(other.ParentArrayOfCustomClassProperty) &&
                this.ParentArrayOfCustomBaseClassProperty.IsEqualTo(other.ParentArrayOfCustomBaseClassProperty) &&
                this.ParentArrayOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.ParentArrayOfCustomGenericClassOfCustomClassProperty) &&
                this.Child2ArrayOfBoolProperty.IsEqualTo(other.Child2ArrayOfBoolProperty) &&
                this.Child2ArrayOfIntProperty.IsEqualTo(other.Child2ArrayOfIntProperty) &&
                this.Child2ArrayOfStringProperty.IsEqualTo(other.Child2ArrayOfStringProperty) &&
                this.Child2ArrayOfGuidProperty.IsEqualTo(other.Child2ArrayOfGuidProperty) &&
                this.Child2ArrayOfDateTimeProperty.IsEqualTo(other.Child2ArrayOfDateTimeProperty) &&
                this.Child2ArrayOfCustomEnumProperty.IsEqualTo(other.Child2ArrayOfCustomEnumProperty) &&
                this.Child2ArrayOfCustomFlagsEnumProperty.IsEqualTo(other.Child2ArrayOfCustomFlagsEnumProperty) &&
                this.Child2ArrayOfCustomClassProperty.IsEqualTo(other.Child2ArrayOfCustomClassProperty) &&
                this.Child2ArrayOfCustomBaseClassProperty.IsEqualTo(other.Child2ArrayOfCustomBaseClassProperty) &&
                this.Child2ArrayOfCustomGenericClassOfCustomClassProperty.IsEqualTo(other.Child2ArrayOfCustomGenericClassOfCustomClassProperty);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(ModelCloningPrivateSetArrayParent other)
        {
            var result = this.Equals((ModelCloningPrivateSetArrayChild2)other);

            return result;
        }

        /// <inheritdoc />
        ModelCloningPrivateSetArrayChild2 IDeclareDeepCloneMethod<ModelCloningPrivateSetArrayChild2>.DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPrivateSetArrayChild2 DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPrivateSetArrayChild2>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPrivateSetArrayChild2)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPrivateSetArrayChild2>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}