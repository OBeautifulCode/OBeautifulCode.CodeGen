// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelStringRepresentationPrivateSetChild2Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelStringRepresentationPrivateSetChild2Test
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelStringRepresentationPrivateSetChild2Test()
        {
            StringRepresentationTestScenarios.AddScenario(StringRepresentationTestScenario<ModelStringRepresentationPrivateSetChild2>.ForceGeneratedTestsToPassAndWriteMyOwnScenario);
        }
    }
}