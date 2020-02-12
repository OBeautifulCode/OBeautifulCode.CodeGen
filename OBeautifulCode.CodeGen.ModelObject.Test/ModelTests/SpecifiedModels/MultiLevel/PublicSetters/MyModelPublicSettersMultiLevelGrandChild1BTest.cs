// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultiLevelGrandChild1BTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelPublicSettersMultiLevelGrandChild1BTest
    {
        static MyModelPublicSettersMultiLevelGrandChild1BTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPublicSettersMultiLevelGrandChild1B>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPublicSettersMultiLevelGrandChild1B
                {
                    ParentInt = 1,
                    Child1Int = 2,
                    GrandChild1BInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPublicSettersMultiLevelGrandChild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        GrandChild1BInt = 3,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild1B
                    {
                        ParentInt = 3,
                        Child1Int = 2,
                        GrandChild1BInt = 1,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild1B
                    {
                        ParentInt = 0,
                        Child1Int = 6,
                        GrandChild1BInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultiLevelGrandChild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        GrandChild1BInt = 2,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild1B
                    {
                        ParentInt = 6,
                        Child1Int = -2,
                        GrandChild1BInt = -1,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild1B
                    {
                        ParentInt = 0,
                        Child1Int = 5,
                        GrandChild1BInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultiLevelGrandChild1B
                    {
                        ParentInt = 2,
                        Child1Int = 2,
                        GrandChild1BInt = 3,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild1B
                    {
                        ParentInt = 3,
                        Child1Int = 3,
                        GrandChild1BInt = 1,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild1B
                    {
                        ParentInt = 0,
                        Child1Int = 7,
                        GrandChild1BInt = 0,
                    },
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPublicSettersMultiLevelGrandChild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        GrandChild1AInt = 3,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        GrandChild2AInt = 3,
                    },
                    new MyModelPublicSettersMultiLevelGrandChild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        GrandChild2BInt = 3,
                    },
                },
            });
        }
    }
}