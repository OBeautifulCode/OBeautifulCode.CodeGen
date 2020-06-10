// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSetMultilevelGrandchild2ATest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelPublicSetMultilevelGrandchild2ATest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelPublicSetMultilevelGrandchild2ATest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPublicSetMultilevelGrandchild2A>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPublicSetMultilevelGrandchild2A
                {
                    ParentInt = 1,
                    Child2Int = 2,
                    Grandchild2AInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2AInt = 3,
                    },
                    new MyModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 3,
                        Child2Int = 2,
                        Grandchild2AInt = 1,
                    },
                    new MyModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 0,
                        Child2Int = 6,
                        Grandchild2AInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2AInt = 2,
                    },
                    new MyModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 6,
                        Child2Int = -2,
                        Grandchild2AInt = -1,
                    },
                    new MyModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 0,
                        Child2Int = 5,
                        Grandchild2AInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 2,
                        Child2Int = 2,
                        Grandchild2AInt = 3,
                    },
                    new MyModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 3,
                        Child2Int = 3,
                        Grandchild2AInt = 1,
                    },
                    new MyModelPublicSetMultilevelGrandchild2A
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
                    new MyModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2BInt = 3,
                    },
                    new MyModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1AInt = 3,
                    },
                    new MyModelPublicSetMultilevelGrandchild1B
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