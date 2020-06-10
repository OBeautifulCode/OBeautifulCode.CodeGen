// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelStringRepresentationPublicSettersTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelStringRepresentationPublicSettersTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelStringRepresentationPublicSettersTest()
        {
            StringRepresentationTestScenarios.AddScenario(StringRepresentationTestScenario<MyModelStringRepresentationPublicSetters>.ForceGeneratedTestsToPassAndWriteMyOwnScenario);
        }
    }
}