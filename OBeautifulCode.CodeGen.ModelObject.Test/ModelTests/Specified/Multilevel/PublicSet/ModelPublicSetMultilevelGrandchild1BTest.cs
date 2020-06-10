// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPublicSetMultilevelGrandchild1BTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelPublicSetMultilevelGrandchild1BTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelPublicSetMultilevelGrandchild1BTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelPublicSetMultilevelGrandchild1B>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelPublicSetMultilevelGrandchild1B
                {
                    ParentInt = 1,
                    Child1Int = 2,
                    Grandchild1BInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new ModelPublicSetMultilevelGrandchild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1BInt = 3,
                    },
                    new ModelPublicSetMultilevelGrandchild1B
                    {
                        ParentInt = 3,
                        Child1Int = 2,
                        Grandchild1BInt = 1,
                    },
                    new ModelPublicSetMultilevelGrandchild1B
                    {
                        ParentInt = 0,
                        Child1Int = 6,
                        Grandchild1BInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new ModelPublicSetMultilevelGrandchild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1BInt = 2,
                    },
                    new ModelPublicSetMultilevelGrandchild1B
                    {
                        ParentInt = 6,
                        Child1Int = -2,
                        Grandchild1BInt = -1,
                    },
                    new ModelPublicSetMultilevelGrandchild1B
                    {
                        ParentInt = 0,
                        Child1Int = 5,
                        Grandchild1BInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new ModelPublicSetMultilevelGrandchild1B
                    {
                        ParentInt = 2,
                        Child1Int = 2,
                        Grandchild1BInt = 3,
                    },
                    new ModelPublicSetMultilevelGrandchild1B
                    {
                        ParentInt = 3,
                        Child1Int = 3,
                        Grandchild1BInt = 1,
                    },
                    new ModelPublicSetMultilevelGrandchild1B
                    {
                        ParentInt = 0,
                        Child1Int = 7,
                        Grandchild1BInt = 0,
                    },
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new ModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1AInt = 3,
                    },
                    new ModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2AInt = 3,
                    },
                    new ModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2BInt = 3,
                    },
                },
            });
        }
    }
}