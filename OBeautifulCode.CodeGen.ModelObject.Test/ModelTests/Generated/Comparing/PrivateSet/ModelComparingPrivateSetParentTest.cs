// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelComparingPrivateSetParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelComparingPrivateSetParentTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelComparingPrivateSetParentTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelComparingPrivateSetParent>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelComparingPrivateSetChild1(5, 4),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new ModelComparingPrivateSetChild1(4, 5), new ModelComparingPrivateSetChild1(0, 9), new ModelComparingPrivateSetChild1(5, 4) },
                ObjectsThatAreLessThanReferenceObject = new[] { new ModelComparingPrivateSetChild1(8, 0), new ModelComparingPrivateSetChild1(-5, -4), new ModelComparingPrivateSetChild1(3, 4) },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new ModelComparingPrivateSetChild1(9, 1), new ModelComparingPrivateSetChild1(5, 5), new ModelComparingPrivateSetChild1(-50, 100) },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[] { new ModelComparingPrivateSetChild2(5, 4) },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string" },
            });
        }
    }
}