// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersConstructorMissingPropertyChild2.cs" company="OBeautifulCode">
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

    public partial class MyModelPrivateSettersConstructorMissingPropertyChild2 : MyModelPrivateSettersConstructorMissingPropertyParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public MyModelPrivateSettersConstructorMissingPropertyChild2(
            IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty,
            ModelClass childClass)
            : base(ModelEnum.ThirdValue, parentReadOnlyCollectionOfStringProperty)
        {
            new { childClass }.AsArg().Must().NotBeNull();

            this.ChildClass = childClass;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelClass ChildClass { get; private set; }
    }
}