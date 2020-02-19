// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultilevelParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelPublicSettersMultilevelParentTest
    {
        static MyModelPublicSettersMultilevelParentTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPublicSettersMultilevelParent>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPublicSettersMultilevelGrandchild1A
                {
                    ParentInt = 1,
                    Child1Int = 2,
                    Grandchild1AInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandchild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1A
                    {
                        ParentInt = 3,
                        Child1Int = 2,
                        Grandchild1AInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1A
                    {
                        ParentInt = 0,
                        Child1Int = 6,
                        Grandchild1AInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandchild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1AInt = 2,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1A
                    {
                        ParentInt = 6,
                        Child1Int = -2,
                        Grandchild1AInt = -1,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1A
                    {
                        ParentInt = 0,
                        Child1Int = 5,
                        Grandchild1AInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandchild1A
                    {
                        ParentInt = 2,
                        Child1Int = 2,
                        Grandchild1AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1A
                    {
                        ParentInt = 3,
                        Child1Int = 3,
                        Grandchild1AInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1A
                    {
                        ParentInt = 0,
                        Child1Int = 7,
                        Grandchild1AInt = 0,
                    },
                },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new MyModelPublicSettersMultilevelParent[]
                {
                    new MyModelPublicSettersMultilevelGrandchild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1BInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2BInt = 3,
                    },
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                },
            });
        }
    }
}