// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetMultilevelGrandchild2BTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelPrivateSetMultilevelGrandchild2BTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelPrivateSetMultilevelGrandchild2BTest()
        {
            ConstructorArgumentValidationTestScenarios.AddScenario(
                ConstructorArgumentValidationTestScenario<ModelPrivateSetMultilevelGrandchild2B>.ConstructorCannotThrowScenario);

            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelPrivateSetMultilevelGrandchild2B>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelPrivateSetMultilevelGrandchild2B(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new ModelPrivateSetMultilevelGrandchild2B(1, 2, 3),
                    new ModelPrivateSetMultilevelGrandchild2B(3, 2, 1),
                    new ModelPrivateSetMultilevelGrandchild2B(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new ModelPrivateSetMultilevelGrandchild2B(1, 2, 2),
                    new ModelPrivateSetMultilevelGrandchild2B(6, -2, -1),
                    new ModelPrivateSetMultilevelGrandchild2B(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new ModelPrivateSetMultilevelGrandchild2B(2, 2, 3),
                    new ModelPrivateSetMultilevelGrandchild2B(3, 3, 1),
                    new ModelPrivateSetMultilevelGrandchild2B(0, 7, 0),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new ModelPrivateSetMultilevelGrandchild2A(1, 2, 3),
                    new ModelPrivateSetMultilevelGrandchild1A(1, 2, 3),
                    new ModelPrivateSetMultilevelGrandchild1B(1, 2, 3),
                },
            });
        }
    }
}