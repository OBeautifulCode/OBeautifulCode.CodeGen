// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetMultilevelChild2Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelPrivateSetMultilevelChild2Test
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelPrivateSetMultilevelChild2Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelPrivateSetMultilevelChild2>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelPrivateSetMultilevelGrandchild2A(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new ModelPrivateSetMultilevelGrandchild2A(1, 2, 3),
                    new ModelPrivateSetMultilevelGrandchild2A(3, 2, 1),
                    new ModelPrivateSetMultilevelGrandchild2A(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new ModelPrivateSetMultilevelGrandchild2A(1, 2, 2),
                    new ModelPrivateSetMultilevelGrandchild2A(6, -2, -1),
                    new ModelPrivateSetMultilevelGrandchild2A(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new ModelPrivateSetMultilevelGrandchild2A(2, 2, 3),
                    new ModelPrivateSetMultilevelGrandchild2A(3, 3, 1),
                    new ModelPrivateSetMultilevelGrandchild2A(0, 7, 0),
                },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[]
                {
                    new ModelPrivateSetMultilevelGrandchild2B(1, 2, 3),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new ModelPrivateSetMultilevelGrandchild1A(1, 2, 3),
                    new ModelPrivateSetMultilevelGrandchild1B(1, 2, 3),
                },
            });
        }
    }
}