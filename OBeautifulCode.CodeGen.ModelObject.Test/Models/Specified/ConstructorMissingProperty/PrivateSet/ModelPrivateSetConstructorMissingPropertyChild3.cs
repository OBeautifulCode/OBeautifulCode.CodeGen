// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetConstructorMissingPropertyChild3.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    public partial class ModelPrivateSetConstructorMissingPropertyChild3 : ModelPrivateSetConstructorMissingPropertyParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public ModelPrivateSetConstructorMissingPropertyChild3(
            CustomEnum parentEnumProperty,
            IReadOnlyCollection<string> parentReadOnlyCollectionOfStringProperty,
            int childIntProperty)
            : base(parentEnumProperty, parentReadOnlyCollectionOfStringProperty)
        {
            this.ChildIntProperty = childIntProperty;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int ChildIntProperty { get; private set; }
    }
}