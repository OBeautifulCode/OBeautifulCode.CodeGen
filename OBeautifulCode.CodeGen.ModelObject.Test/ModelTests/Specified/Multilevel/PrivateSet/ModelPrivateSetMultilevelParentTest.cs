// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetMultilevelParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class ModelPrivateSetMultilevelParentTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelPrivateSetMultilevelParentTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelPrivateSetMultilevelParent>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelPrivateSetMultilevelGrandchild1A(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new ModelPrivateSetMultilevelGrandchild1A(1, 2, 3),
                    new ModelPrivateSetMultilevelGrandchild1A(3, 2, 1),
                    new ModelPrivateSetMultilevelGrandchild1A(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new ModelPrivateSetMultilevelGrandchild1A(1, 2, 2),
                    new ModelPrivateSetMultilevelGrandchild1A(6, -2, -1),
                    new ModelPrivateSetMultilevelGrandchild1A(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new ModelPrivateSetMultilevelGrandchild1A(2, 2, 3),
                    new ModelPrivateSetMultilevelGrandchild1A(3, 3, 1),
                    new ModelPrivateSetMultilevelGrandchild1A(0, 7, 0),
                },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new ModelPrivateSetMultilevelParent[]
                {
                    new ModelPrivateSetMultilevelGrandchild1B(1, 2, 3),
                    new ModelPrivateSetMultilevelGrandchild2A(1, 2, 3),
                    new ModelPrivateSetMultilevelGrandchild2B(1, 2, 3),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                },
            });
        }
    }
}