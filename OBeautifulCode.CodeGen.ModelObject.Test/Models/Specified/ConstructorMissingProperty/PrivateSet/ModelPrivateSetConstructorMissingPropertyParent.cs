// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetConstructorMissingPropertyParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    public abstract partial class ModelPrivateSetConstructorMissingPropertyParent : IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        protected ModelPrivateSetConstructorMissingPropertyParent(
            CustomEnum parentEnumProperty,
            IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty)
        {
            new { parentReadOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls().And().Each().NotBeNullNorWhiteSpace();

            this.ParentEnumProperty = parentEnumProperty;
            this.ParentReadOnlyCollectionOfStringProperty = parentReadOnlyCollectionOfStringProperty;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomEnum ParentEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<string> ParentReadOnlyCollectionOfStringProperty { get; private set; }
    }
}