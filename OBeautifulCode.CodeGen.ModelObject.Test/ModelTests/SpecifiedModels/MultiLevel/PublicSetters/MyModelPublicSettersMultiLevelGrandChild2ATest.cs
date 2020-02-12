// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultiLevelGrandChild2ATest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelPublicSettersMultiLevelGrandChild2ATest
    {
        static MyModelPublicSettersMultiLevelGrandChild2ATest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPublicSettersMultiLevelGrandChild2A>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPublicSettersMultiLevelGrandChild2A
                {
                    ParentInt = 1,
                    Child2Int = 2,
                    GrandChild2AInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPublicSettersMultiLevelGrandChild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        GrandChild2AInt = 3,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild2A
                    {
                        ParentInt = 3,
                        Child2Int = 2,
                        GrandChild2AInt = 1,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild2A
                    {
                        ParentInt = 0,
                        Child2Int = 6,
                        GrandChild2AInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultiLevelGrandChild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        GrandChild2AInt = 2,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild2A
                    {
                        ParentInt = 6,
                        Child2Int = -2,
                        GrandChild2AInt = -1,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild2A
                    {
                        ParentInt = 0,
                        Child2Int = 5,
                        GrandChild2AInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultiLevelGrandChild2A
                    {
                        ParentInt = 2,
                        Child2Int = 2,
                        GrandChild2AInt = 3,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild2A
                    {
                        ParentInt = 3,
                        Child2Int = 3,
                        GrandChild2AInt = 1,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild2A
                    {
                        ParentInt = 0,
                        Child2Int = 7,
                        GrandChild2AInt = 0,
                    },
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPublicSettersMultiLevelGrandChild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        GrandChild2BInt = 3,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        GrandChild1AInt = 3,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        GrandChild1BInt = 3,
                    },
                },
            });
        }
    }
}