// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetExpressionBodyChild1.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    public partial class ModelPrivateSetExpressionBodyChild1 : ModelPrivateSetExpressionBodyParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetExpressionBodyChild1(
            int parentIntProperty,
            string parentStringProperty,
            IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty,
            int childIntProperty,
            string childStringProperty,
            IReadOnlyCollection<string> childReadOnlyCollectionOfStringProperty)
            : base(parentIntProperty, parentStringProperty, parentReadOnlyCollectionOfStringProperty)
        {
            new { childStringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { childReadOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.ChildIntProperty = childIntProperty;
            this.ChildStringProperty = childStringProperty;
            this.ChildReadOnlyCollectionOfStringProperty = childReadOnlyCollectionOfStringProperty;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int ChildIntProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public string ChildStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<string> ChildReadOnlyCollectionOfStringProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public string ExpressionBodyChildStringProperty => this.ChildStringProperty + this.ChildIntProperty;

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int ExpressionBodyChildIntProperty => this.ChildIntProperty * 5;

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<string> ExpressionBodyChildReadOnlyCollectionOfStringProperty => this.ChildReadOnlyCollectionOfStringProperty.Take(1).ToList();

        public override string OverrideExpressionBodyPropertyString => this.ParentStringProperty + this.ParentIntProperty;

        public override int OverrideExpressionBodyIntProperty => this.ParentIntProperty * 5;

        public override IReadOnlyCollection<string> OverrideExpressionBodyReadOnlyCollectionOfStringProperty => this.ParentReadOnlyCollectionOfStringProperty.Take(1).ToList();
    }
}