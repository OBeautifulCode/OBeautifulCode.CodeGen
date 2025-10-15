// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPublicSetMultilevelDeclaredValidation1Grandchild1A.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    public partial class ModelPublicSetMultilevelDeclaredValidation1Grandchild1A : ModelPublicSetMultilevelDeclaredValidation1Child1, IModelViaCodeGen, IDeclareGetSelfValidationFailuresMethod
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int Grandchild1AInt { get; set; }

        public override IReadOnlyList<SelfValidationFailure> GetSelfValidationFailures()
        {
            var result = base.GetSelfValidationFailures();

            return result;
        }
    }
}