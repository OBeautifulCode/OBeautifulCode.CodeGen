// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetNonGenericParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Type;

    public abstract partial class ModelPrivateSetNonGenericParent :
        IModelViaCodeGen, IComparableViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        protected ModelPrivateSetNonGenericParent(
            string parentStringProperty,
            int parentIntProperty,
            CustomEnum parentEnumProperty,
            CustomClass parentCustomClassProperty,
            string[] parentArrayProperty,
            decimal? parentNullableProperty,
            CustomGenericClass<string> parentCustomGenericClassProperty,
            IReadOnlyCollection<string> parentReadOnlyCollectionProperty,
            IReadOnlyDictionary<string, string> parentReadOnlyDictionaryProperty)
        {
            new { parentStringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { parentCustomClassProperty }.AsArg().Must().NotBeNull();
            new { parentArrayProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { parentCustomGenericClassProperty }.AsArg().Must().NotBeNull();
            new { parentReadOnlyCollectionProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            new { parentReadOnlyDictionaryProperty }.AsArg().Must().NotBeNullNorEmptyDictionaryNorContainAnyNullValues();

            this.ParentStringProperty = parentStringProperty;
            this.ParentIntProperty = parentIntProperty;
            this.ParentEnumProperty = parentEnumProperty;
            this.ParentCustomClassProperty = parentCustomClassProperty;
            this.ParentArrayProperty = parentArrayProperty;
            this.ParentNullableProperty = parentNullableProperty;
            this.ParentCustomGenericClassProperty = parentCustomGenericClassProperty;
            this.ParentReadOnlyCollectionProperty = parentReadOnlyCollectionProperty;
            this.ParentReadOnlyDictionaryProperty = parentReadOnlyDictionaryProperty;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public string ParentStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int ParentIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomEnum ParentEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomClass ParentCustomClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = ObcSuppressBecause.CA1819_PropertiesShouldNotReturnArrays_ArrayPropertyRequiredForTesting)]
        public string[] ParentArrayProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public decimal? ParentNullableProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomGenericClass<string> ParentCustomGenericClassProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<string> ParentReadOnlyCollectionProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyDictionary<string, string> ParentReadOnlyDictionaryProperty { get; private set; }
    }
}