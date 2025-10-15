// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPublicSetMultilevelDeclaredValidation1Parent.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    public abstract partial class ModelPublicSetMultilevelDeclaredValidation1Parent : IModelViaCodeGen, IDeclareGetSelfValidationFailuresMethod
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = ObcSuppressBecause.CA1720_IdentifiersShouldNotContainTypeNames_TypeNameAddedToIdentifierForTestsWhereTypeIsPrimaryConcern)]
        public int ParentInt { get; set; }

        public virtual IReadOnlyList<SelfValidationFailure> GetSelfValidationFailures()
        {
            var result = new SelfValidationFailure[0];

            return result;
        }
    }
}