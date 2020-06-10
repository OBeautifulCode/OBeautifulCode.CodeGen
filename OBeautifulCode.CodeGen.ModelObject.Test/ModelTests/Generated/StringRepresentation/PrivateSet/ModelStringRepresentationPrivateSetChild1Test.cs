// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelStringRepresentationPrivateSetChild1Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelStringRepresentationPrivateSetChild1Test
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelStringRepresentationPrivateSetChild1Test()
        {
            StringRepresentationTestScenarios.AddScenario(StringRepresentationTestScenario<ModelStringRepresentationPrivateSetChild1>.ForceGeneratedTestsToPassAndWriteMyOwnScenario);
        }
    }
}