// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelComparingPrivateSetTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelComparingPrivateSetTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelComparingPrivateSetTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelComparingPrivateSet>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelComparingPrivateSet(5),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new ModelComparingPrivateSet(5) },
                ObjectsThatAreLessThanReferenceObject = new[] { new ModelComparingPrivateSet(4), new ModelComparingPrivateSet(-5), new ModelComparingPrivateSet(0) },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new ModelComparingPrivateSet(6), new ModelComparingPrivateSet(10) },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new ModelComparingPrivateSetChild1(5, 4), new ModelComparingPrivateSetChild2(5, 4) },
            });
        }
    }
}