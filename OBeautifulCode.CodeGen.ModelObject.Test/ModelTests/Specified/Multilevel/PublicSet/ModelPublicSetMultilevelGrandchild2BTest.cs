// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPublicSetMultilevelGrandchild2BTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class ModelPublicSetMultilevelGrandchild2BTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelPublicSetMultilevelGrandchild2BTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelPublicSetMultilevelGrandchild2B>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelPublicSetMultilevelGrandchild2B
                {
                    ParentInt = 1,
                    Child2Int = 2,
                    Grandchild2BInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new ModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2BInt = 3,
                    },
                    new ModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 3,
                        Child2Int = 2,
                        Grandchild2BInt = 1,
                    },
                    new ModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 0,
                        Child2Int = 6,
                        Grandchild2BInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new ModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2BInt = 2,
                    },
                    new ModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 6,
                        Child2Int = -2,
                        Grandchild2BInt = -1,
                    },
                    new ModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 0,
                        Child2Int = 5,
                        Grandchild2BInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new ModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 2,
                        Child2Int = 2,
                        Grandchild2BInt = 3,
                    },
                    new ModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 3,
                        Child2Int = 3,
                        Grandchild2BInt = 1,
                    },
                    new ModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 0,
                        Child2Int = 7,
                        Grandchild2BInt = 0,
                    },
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new ModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2AInt = 3,
                    },
                    new ModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1AInt = 3,
                    },
                    new ModelPublicSetMultilevelGrandchild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1BInt = 3,
                    },
                },
            });
        }
    }
}