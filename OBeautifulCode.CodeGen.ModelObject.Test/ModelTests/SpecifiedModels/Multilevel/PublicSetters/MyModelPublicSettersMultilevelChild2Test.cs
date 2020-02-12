// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultilevelChild2Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelPublicSettersMultilevelChild2Test
    {
        static MyModelPublicSettersMultilevelChild2Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPublicSettersMultilevelChild2>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPublicSettersMultilevelGrandChild2A
                {
                    ParentInt = 1,
                    Child2Int = 2,
                    GrandChild2AInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandChild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        GrandChild2AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandChild2A
                    {
                        ParentInt = 3,
                        Child2Int = 2,
                        GrandChild2AInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandChild2A
                    {
                        ParentInt = 0,
                        Child2Int = 6,
                        GrandChild2AInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandChild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        GrandChild2AInt = 2,
                    },
                    new MyModelPublicSettersMultilevelGrandChild2A
                    {
                        ParentInt = 6,
                        Child2Int = -2,
                        GrandChild2AInt = -1,
                    },
                    new MyModelPublicSettersMultilevelGrandChild2A
                    {
                        ParentInt = 0,
                        Child2Int = 5,
                        GrandChild2AInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandChild2A
                    {
                        ParentInt = 2,
                        Child2Int = 2,
                        GrandChild2AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandChild2A
                    {
                        ParentInt = 3,
                        Child2Int = 3,
                        GrandChild2AInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandChild2A
                    {
                        ParentInt = 0,
                        Child2Int = 7,
                        GrandChild2AInt = 0,
                    },
                },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandChild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        GrandChild2BInt = 3,
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
                    new MyModelPublicSettersMultilevelGrandChild1B
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