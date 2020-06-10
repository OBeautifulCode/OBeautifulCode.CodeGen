// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSetConstructorMissingPropertyChild1.cs" company="OBeautifulCode">
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

    public partial class MyModelPrivateSetConstructorMissingPropertyChild1 : MyModelPrivateSetConstructorMissingPropertyParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public MyModelPrivateSetConstructorMissingPropertyChild1(
            IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty,
            IReadOnlyCollection<string> childReadOnlyCollectionOfStringProperty)
            : base(ModelEnum.SecondValue, parentReadOnlyCollectionOfStringProperty)
        {
            new { childReadOnlyCollectionOfStringProperty }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.ChildReadOnlyCollectionOfStringProperty = childReadOnlyCollectionOfStringProperty;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<string> ChildReadOnlyCollectionOfStringProperty { get; private set; }
    }
}