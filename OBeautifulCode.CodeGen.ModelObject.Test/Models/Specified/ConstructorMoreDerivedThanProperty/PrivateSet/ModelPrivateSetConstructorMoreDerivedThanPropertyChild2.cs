// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetConstructorMoreDerivedThanPropertyChild2.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    public partial class ModelPrivateSetConstructorMoreDerivedThanPropertyChild2 : ModelPrivateSetConstructorMoreDerivedThanPropertyParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetConstructorMoreDerivedThanPropertyChild2(
            CustomEnum parentEnumProperty,
            CustomMultilevelChildBaseClass customMultilevelBaseClass,
            CustomClass childCustomClass)
            : base(parentEnumProperty, customMultilevelBaseClass)
        {
            new { childCustomClass }.AsArg().Must().NotBeNull();

            this.ChildCustomClass = childCustomClass;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomClass ChildCustomClass { get; private set; }
    }
}