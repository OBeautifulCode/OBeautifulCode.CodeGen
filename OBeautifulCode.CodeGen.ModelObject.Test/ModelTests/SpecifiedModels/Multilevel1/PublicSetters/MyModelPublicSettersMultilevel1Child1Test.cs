// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultilevelChild1Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelPublicSettersMultilevelChild1Test
    {
        static MyModelPublicSettersMultilevelChild1Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPublicSettersMultilevelChild1>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPublicSettersMultilevelGrandChild1A
                {
                    ParentInt = 1,
                    Child1Int = 2,
                    GrandChild1AInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandChild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        GrandChild1AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1A
                    {
                        ParentInt = 3,
                        Child1Int = 2,
                        GrandChild1AInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1A
                    {
                        ParentInt = 0,
                        Child1Int = 6,
                        GrandChild1AInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandChild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        GrandChild1AInt = 2,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1A
                    {
                        ParentInt = 6,
                        Child1Int = -2,
                        GrandChild1AInt = -1,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1A
                    {
                        ParentInt = 0,
                        Child1Int = 5,
                        GrandChild1AInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandChild1A
                    {
                        ParentInt = 2,
                        Child1Int = 2,
                        GrandChild1AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1A
                    {
                        ParentInt = 3,
                        Child1Int = 3,
                        GrandChild1AInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandChild1A
                    {
                        ParentInt = 0,
                        Child1Int = 7,
                        GrandChild1AInt = 0,
                    },
                },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandChild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        GrandChild1BInt = 3,
                    },
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
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