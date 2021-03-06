﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPublicSetMultilevelGrandchild2ATest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class ModelPublicSetMultilevelGrandchild2ATest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelPublicSetMultilevelGrandchild2ATest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelPublicSetMultilevelGrandchild2A>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelPublicSetMultilevelGrandchild2A
                {
                    ParentInt = 1,
                    Child2Int = 2,
                    Grandchild2AInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new ModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2AInt = 3,
                    },
                    new ModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 3,
                        Child2Int = 2,
                        Grandchild2AInt = 1,
                    },
                    new ModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 0,
                        Child2Int = 6,
                        Grandchild2AInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new ModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2AInt = 2,
                    },
                    new ModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 6,
                        Child2Int = -2,
                        Grandchild2AInt = -1,
                    },
                    new ModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 0,
                        Child2Int = 5,
                        Grandchild2AInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new ModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 2,
                        Child2Int = 2,
                        Grandchild2AInt = 3,
                    },
                    new ModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 3,
                        Child2Int = 3,
                        Grandchild2AInt = 1,
                    },
                    new ModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 0,
                        Child2Int = 7,
                        Grandchild2AInt = 0,
                    },
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new ModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2BInt = 3,
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