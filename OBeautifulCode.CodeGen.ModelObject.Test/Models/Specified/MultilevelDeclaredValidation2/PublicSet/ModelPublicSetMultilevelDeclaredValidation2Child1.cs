// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPublicSetMultilevelDeclaredValidation2Child1.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    public abstract partial class ModelPublicSetMultilevelDeclaredValidation2Child1 : ModelPublicSetMultilevelDeclaredValidation2Parent, IModelViaCodeGen, IDeclareGetSelfValidationFailuresMethod
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int Child1Int { get; set; }

        public override IReadOnlyList<SelfValidationFailure> GetSelfValidationFailures()
        {
            var result = new SelfValidationFailure[0];

            return result;
        }
    }
}