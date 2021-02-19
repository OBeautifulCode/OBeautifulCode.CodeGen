// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetConstructorMoreDerivedThanPropertyParent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    public abstract partial class ModelPrivateSetConstructorMoreDerivedThanPropertyParent : IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        protected ModelPrivateSetConstructorMoreDerivedThanPropertyParent(
            CustomEnum parentEnumProperty,
            CustomMultilevelBaseClass customMultilevelBaseClass)
        {
            new { customMultilevelBaseClass }.AsArg().Must().NotBeNull();

            this.ParentEnumProperty = parentEnumProperty;
            this.CustomMultilevelBaseClass = customMultilevelBaseClass;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomEnum ParentEnumProperty { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomMultilevelBaseClass CustomMultilevelBaseClass { get; private set; }
    }
}