// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelComparingPrivateSetNoneTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class ModelComparingPrivateSetNoneTest
    {

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelComparingPrivateSetNoneTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelComparingPrivateSetNone>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelComparingPrivateSetNone(5),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new ModelComparingPrivateSetNone(5) },
                ObjectsThatAreLessThanReferenceObject = new[] { new ModelComparingPrivateSetNone(4), new ModelComparingPrivateSetNone(-5), new ModelComparingPrivateSetNone(0) },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new ModelComparingPrivateSetNone(6), new ModelComparingPrivateSetNone(10) },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy - string", new ModelComparingPrivateSetNoneChild1(5, 4), new ModelComparingPrivateSetNoneChild2(5, 4) },
            });
        }
    }
}