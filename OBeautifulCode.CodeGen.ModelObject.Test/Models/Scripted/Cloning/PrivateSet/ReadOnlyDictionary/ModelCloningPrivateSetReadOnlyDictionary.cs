﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelCloningPrivateSetReadOnlyDictionary.cs" company="OBeautifulCode">
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
    public partial class ModelCloningPrivateSetReadOnlyDictionary : IDeepCloneableViaCodeGen, IDeclareDeepCloneMethod<ModelCloningPrivateSetReadOnlyDictionary>, IEquatable<ModelCloningPrivateSetReadOnlyDictionary>
#pragma warning disable CS0659
#pragma warning disable CS0661
    {
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        public ModelCloningPrivateSetReadOnlyDictionary(
            IReadOnlyDictionary<bool, bool> readOnlyDictionaryInterfaceOfBoolProperty,
            IReadOnlyDictionary<int, int> readOnlyDictionaryInterfaceOfIntProperty,
            IReadOnlyDictionary<string, string> readOnlyDictionaryInterfaceOfStringProperty,
            IReadOnlyDictionary<Guid, Guid> readOnlyDictionaryInterfaceOfGuidProperty,
            IReadOnlyDictionary<CustomEnum, CustomEnum> readOnlyDictionaryInterfaceOfCustomEnumProperty,
            IReadOnlyDictionary<CustomFlagsEnum, CustomFlagsEnum> readOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
            IReadOnlyDictionary<CustomClass, CustomClass> readOnlyDictionaryInterfaceOfCustomClassProperty,
            IReadOnlyDictionary<CustomBaseClass, CustomBaseClass> readOnlyDictionaryInterfaceOfCustomBaseClassProperty)
        {
            new { readOnlyDictionaryInterfaceOfBoolProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfIntProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfStringProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { readOnlyDictionaryInterfaceOfGuidProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfCustomEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfCustomFlagsEnumProperty }.AsArg().Must().NotBeNullNorEmptyDictionary();
            new { readOnlyDictionaryInterfaceOfCustomClassProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();
            new { readOnlyDictionaryInterfaceOfCustomBaseClassProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.ReadOnlyDictionaryInterfaceOfBoolProperty = readOnlyDictionaryInterfaceOfBoolProperty;
            this.ReadOnlyDictionaryInterfaceOfIntProperty = readOnlyDictionaryInterfaceOfIntProperty;
            this.ReadOnlyDictionaryInterfaceOfStringProperty = readOnlyDictionaryInterfaceOfStringProperty;
            this.ReadOnlyDictionaryInterfaceOfGuidProperty = readOnlyDictionaryInterfaceOfGuidProperty;
            this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty = readOnlyDictionaryInterfaceOfCustomEnumProperty;
            this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty = readOnlyDictionaryInterfaceOfCustomFlagsEnumProperty;
            this.ReadOnlyDictionaryInterfaceOfCustomClassProperty = readOnlyDictionaryInterfaceOfCustomClassProperty;
            this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty = readOnlyDictionaryInterfaceOfCustomBaseClassProperty;
        }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<bool, bool> ReadOnlyDictionaryInterfaceOfBoolProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<int, int> ReadOnlyDictionaryInterfaceOfIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<string, string> ReadOnlyDictionaryInterfaceOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<Guid, Guid> ReadOnlyDictionaryInterfaceOfGuidProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomEnum, CustomEnum> ReadOnlyDictionaryInterfaceOfCustomEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomFlagsEnum, CustomFlagsEnum> ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomClass, CustomClass> ReadOnlyDictionaryInterfaceOfCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1720: IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IReadOnlyDictionary<CustomBaseClass, CustomBaseClass> ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty { get; private set; }

        /// <inheritdoc />
        public bool Equals(ModelCloningPrivateSetReadOnlyDictionary other)
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
                this.ReadOnlyDictionaryInterfaceOfBoolProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfBoolProperty) &&
                this.ReadOnlyDictionaryInterfaceOfIntProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfIntProperty) &&
                this.ReadOnlyDictionaryInterfaceOfStringProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfStringProperty) &&
                this.ReadOnlyDictionaryInterfaceOfGuidProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfGuidProperty) &&
                this.ReadOnlyDictionaryInterfaceOfCustomEnumProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfCustomEnumProperty) &&
                this.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty) &&
                this.ReadOnlyDictionaryInterfaceOfCustomClassProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfCustomClassProperty) &&
                this.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty.IsEqualTo(other.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty);

            return result;
        }

        /// <inheritdoc />
        public ModelCloningPrivateSetReadOnlyDictionary DeepClone()
        {
            var result = this.DeepCloneImplementation();

            return result;
        }

        private ModelCloningPrivateSetReadOnlyDictionary DeepCloneImplementation()
        {
            var referenceModel = A.Dummy<ModelAllPrivateSetReadOnlyDictionary>();

            var referenceModelProperties = referenceModel.GetType().GetProperties();

            foreach (var referenceModelProperty in referenceModelProperties)
            {
                referenceModelProperty.DeclaringType.GetProperty(referenceModelProperty.Name).SetValue(referenceModel, this.GetType().GetProperty(referenceModelProperty.Name).GetValue(this));
            }

            referenceModel = (ModelAllPrivateSetReadOnlyDictionary)referenceModel.GetType().GetMethod("DeepClone").Invoke(referenceModel, new object[0]);

            var thisModelProperties = this.GetType().GetProperties();

            var result = A.Dummy<ModelCloningPrivateSetReadOnlyDictionary>();

            foreach (var thisModelProperty in thisModelProperties)
            {
                thisModelProperty.DeclaringType.GetProperty(thisModelProperty.Name).SetValue(result, referenceModel.GetType().GetProperty(thisModelProperty.Name).GetValue(referenceModel));
            }

            return result;
        }
    }
}