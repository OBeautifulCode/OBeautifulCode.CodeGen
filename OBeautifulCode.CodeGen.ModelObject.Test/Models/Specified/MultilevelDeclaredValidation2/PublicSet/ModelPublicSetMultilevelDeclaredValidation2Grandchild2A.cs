// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPublicSetMultilevelDeclaredValidation2Grandchild2A.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    public partial class ModelPublicSetMultilevelDeclaredValidation2Grandchild2A : ModelPublicSetMultilevelDeclaredValidation2Child2, IModelViaCodeGen, IDeclareGetSelfValidationFailuresMethod
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int Grandchild2AInt { get; set; }

        public override IReadOnlyList<SelfValidationFailure> GetSelfValidationFailures()
        {
            var result = new SelfValidationFailure[0];

            return result;
        }
    }
}