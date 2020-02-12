// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultilevelGrandChild1BTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelPublicSettersMultilevelGrandChild1BTest
    {
        static MyModelPublicSettersMultilevelGrandChild1BTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPublicSettersMultilevelGrandChild1B>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPublicSettersMultilevelGrandChild1B
                {
                    ParentInt = 1,
                    Child1Int = 2,
                    GrandChild1BInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandChild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        GrandChild1BInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1B
                    {
                        ParentInt = 3,
                        Child1Int = 2,
                        GrandChild1BInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1B
                    {
                        ParentInt = 0,
                        Child1Int = 6,
                        GrandChild1BInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandChild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        GrandChild1BInt = 2,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1B
                    {
                        ParentInt = 6,
                        Child1Int = -2,
                        GrandChild1BInt = -1,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1B
                    {
                        ParentInt = 0,
                        Child1Int = 5,
                        GrandChild1BInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandChild1B
                    {
                        ParentInt = 2,
                        Child1Int = 2,
                        GrandChild1BInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1B
                    {
                        ParentInt = 3,
                        Child1Int = 3,
                        GrandChild1BInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1B
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
                    new MyModelPublicSettersMultilevelGrandChild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        GrandChild1AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandChild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        GrandChild2AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandChild2B
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