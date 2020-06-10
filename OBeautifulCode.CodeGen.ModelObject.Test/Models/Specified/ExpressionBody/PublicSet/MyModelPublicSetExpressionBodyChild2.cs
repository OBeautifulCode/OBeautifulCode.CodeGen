// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSetExpressionBodyChild2.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Type;

    public partial class MyModelPublicSetExpressionBodyChild2 : MyModelPublicSetExpressionBodyParent, IModelViaCodeGen
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int ChildIntProperty { get; set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public string ChildStringProperty { get; set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<string> ChildReadOnlyCollectionOfStringProperty { get; set; }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public string ExpressionBodyChildStringProperty => this.ChildStringProperty + this.ChildIntProperty;

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int ExpressionBodyChildIntProperty => this.ChildIntProperty * 5;

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public IReadOnlyCollection<string> ExpressionBodyChildReadOnlyCollectionOfStringProperty => this.ChildReadOnlyCollectionOfStringProperty?.Take(1).ToList();

        public override string OverrideExpressionBodyPropertyString => this.ParentStringProperty + this.ParentIntProperty;

        public override int OverrideExpressionBodyIntProperty => this.ParentIntProperty * 5;

        public override IReadOnlyCollection<string> OverrideExpressionBodyReadOnlyCollectionOfStringProperty => this.ParentReadOnlyCollectionOfStringProperty?.Take(1).ToList();
    }
}