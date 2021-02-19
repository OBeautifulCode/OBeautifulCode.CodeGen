// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetConstructorMoreDerivedThanPropertyChild1.cs" company="OBeautifulCode">
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

    public partial class ModelPrivateSetConstructorMoreDerivedThanPropertyChild1 : ModelPrivateSetConstructorMoreDerivedThanPropertyParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetConstructorMoreDerivedThanPropertyChild1(
            CustomEnum parentEnumProperty,
            CustomMultiChildClass customMultiBaseClass,
            IReadOnlyCollection<string> childReadOnlyCollectionOfStringProperty)
            : base(parentEnumProperty, customMultiBaseClass)
        {
            new { childReadOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.ChildReadOnlyCollectionOfStringProperty = childReadOnlyCollectionOfStringProperty;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<string> ChildReadOnlyCollectionOfStringProperty { get; private set; }
    }
}