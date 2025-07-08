// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetMultipleConstructorsChild2.cs" company="OBeautifulCode">
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

    public partial class ModelPrivateSetMultipleConstructorsChild2 : ModelPrivateSetMultipleConstructorsParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetMultipleConstructorsChild2(
            int childIntProperty,
            string childStringProperty,
            IReadOnlyCollection<string> childReadOnlyCollectionOfStringProperty)
            : base(5)
        {
            new { childStringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { childReadOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls().And().Each().NotBeNullNorWhiteSpace();

            this.ChildIntProperty = childIntProperty;
            this.ChildStringProperty = childStringProperty;
            this.ChildReadOnlyCollectionOfStringProperty = childReadOnlyCollectionOfStringProperty;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetMultipleConstructorsChild2(
            int parentIntProperty,
            int childIntProperty,
            string childStringProperty,
            IReadOnlyCollection<string> childReadOnlyCollectionOfStringProperty)
            : base(parentIntProperty)
        {
            new { childStringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { childReadOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls().And().Each().NotBeNullNorWhiteSpace();

            this.ChildIntProperty = childIntProperty;
            this.ChildStringProperty = childStringProperty;
            this.ChildReadOnlyCollectionOfStringProperty = childReadOnlyCollectionOfStringProperty;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetMultipleConstructorsChild2(
            int parentIntProperty,
            string parentStringProperty,
            int childIntProperty,
            string childStringProperty,
            IReadOnlyCollection<string> childReadOnlyCollectionOfStringProperty)
            : base(parentIntProperty, parentStringProperty)
        {
            new { childStringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { childReadOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls().And().Each().NotBeNullNorWhiteSpace();

            this.ChildIntProperty = childIntProperty;
            this.ChildStringProperty = childStringProperty;
            this.ChildReadOnlyCollectionOfStringProperty = childReadOnlyCollectionOfStringProperty;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetMultipleConstructorsChild2(
            int parentIntProperty,
            string parentStringProperty,
            IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty,
            int childIntProperty)
            : this(parentIntProperty, parentStringProperty, parentReadOnlyCollectionOfStringProperty, childIntProperty, "ModelPrivateSetMultipleConstructorsChild2-constant")
        {
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetMultipleConstructorsChild2(
            int parentIntProperty,
            string parentStringProperty,
            IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty,
            int childIntProperty,
            string childStringProperty)
            : this(parentIntProperty, parentStringProperty, parentReadOnlyCollectionOfStringProperty, childIntProperty, childStringProperty, new[] { childStringProperty })
        {
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetMultipleConstructorsChild2(
            int parentIntProperty,
            string parentStringProperty,
            IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty,
            int childIntProperty,
            string childStringProperty,
            IReadOnlyCollection<string> childReadOnlyCollectionOfStringProperty)
            : base(parentIntProperty, parentStringProperty, parentReadOnlyCollectionOfStringProperty)
        {
            new { childStringProperty }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { childReadOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls().And().Each().NotBeNullNorWhiteSpace();

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
    }
}