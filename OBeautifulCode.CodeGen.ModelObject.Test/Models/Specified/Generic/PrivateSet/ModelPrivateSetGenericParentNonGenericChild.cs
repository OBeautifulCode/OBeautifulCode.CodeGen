// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetGenericParentNonGenericChild.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Type;

    using Xunit.Sdk;

    public partial class ModelPrivateSetGenericParentNonGenericChild :
        ModelPrivateSetGenericParent<CustomClass, Guid>, IModelViaCodeGen, IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<ModelPrivateSetGenericParentNonGenericChild>
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetGenericParentNonGenericChild(
            string parentStringProperty,
            int parentIntProperty,
            CustomEnum parentEnumProperty,
            CustomClass parentCustomClassProperty,
            CustomClass parentGenericArgumentProperty,
            CustomClass[] parentGenericArrayProperty,
            Guid? parentGenericNullableProperty,
            CustomGenericClass<Guid> parentGenericCustomGenericClassProperty,
            IReadOnlyCollection<CustomClass> parentGenericReadOnlyCollectionProperty,
            IReadOnlyList<CustomClass> parentGenericReadOnlyListProperty,
            IReadOnlyDictionary<CustomClass, Guid> parentGenericReadOnlyDictionaryProperty1,
            IReadOnlyDictionary<Guid, CustomClass> parentGenericReadOnlyDictionaryProperty2,
            IReadOnlyDictionary<string, Guid> parentGenericPartiallyClosedReadOnlyDictionaryProperty1,
            IReadOnlyDictionary<CustomClass, string> parentGenericPartiallyClosedReadOnlyDictionaryProperty2,
            string childStringProperty,
            int childIntProperty,
            CustomEnum childEnumProperty,
            CustomClass childCustomClassProperty,
            string[] childArrayProperty,
            decimal? childNullableProperty,
            CustomGenericClass<string> childCustomGenericClassProperty,
            IReadOnlyCollection<string> childReadOnlyCollectionProperty,
            IReadOnlyDictionary<string, string> childReadOnlyDictionaryProperty)
        : base(parentStringProperty, parentIntProperty, parentEnumProperty, parentCustomClassProperty, parentGenericArgumentProperty, parentGenericArrayProperty, parentGenericNullableProperty, parentGenericCustomGenericClassProperty, parentGenericReadOnlyCollectionProperty, parentGenericReadOnlyListProperty, parentGenericReadOnlyDictionaryProperty1, parentGenericReadOnlyDictionaryProperty2, parentGenericPartiallyClosedReadOnlyDictionaryProperty1, parentGenericPartiallyClosedReadOnlyDictionaryProperty2)
        {
            this.ChildStringProperty = childStringProperty;
            this.ChildIntProperty = childIntProperty;
            this.ChildEnumProperty = childEnumProperty;
            this.ChildCustomClassProperty = childCustomClassProperty;
            this.ChildArrayProperty = childArrayProperty;
            this.ChildNullableProperty = childNullableProperty;
            this.ChildCustomGenericClassProperty = childCustomGenericClassProperty;
            this.ChildReadOnlyCollectionProperty = childReadOnlyCollectionProperty;
            this.ChildReadOnlyDictionaryProperty = childReadOnlyDictionaryProperty;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public string ChildStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int ChildIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomEnum ChildEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomClass ChildCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public string[] ChildArrayProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public decimal? ChildNullableProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomGenericClass<string> ChildCustomGenericClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<string> ChildReadOnlyCollectionProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<string, string> ChildReadOnlyDictionaryProperty { get; private set; }

        /// <inheritdoc />
        public RelativeSortOrder CompareToForRelativeSortOrder(
            ModelPrivateSetGenericParentNonGenericChild other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            if (this.ChildIntProperty < other.ChildIntProperty)
            {
                return RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;
            }

            if (this.ChildIntProperty > other.ChildIntProperty)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            return RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance;
        }
    }
}