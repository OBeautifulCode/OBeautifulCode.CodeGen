// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetConstructorMissingPropertyChild2.cs" company="OBeautifulCode">
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

    public partial class ModelPrivateSetConstructorMissingPropertyChild2 : ModelPrivateSetConstructorMissingPropertyParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetConstructorMissingPropertyChild2(
            IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty,
            CustomClass childClass)
            : base(CustomEnum.ThirdValue, parentReadOnlyCollectionOfStringProperty)
        {
            new { childClass }.AsArg().Must().NotBeNull();

            this.ChildClass = childClass;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public CustomClass ChildClass { get; private set; }
    }
}