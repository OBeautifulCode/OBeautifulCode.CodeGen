// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultilevelChild2Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelPrivateSettersMultilevelChild2Test
    {
        static MyModelPrivateSettersMultilevelChild2Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPrivateSettersMultilevelChild2>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPrivateSettersMultilevelGrandchild2A(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandchild2A(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandchild2A(3, 2, 1),
                    new MyModelPrivateSettersMultilevelGrandchild2A(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandchild2A(1, 2, 2),
                    new MyModelPrivateSettersMultilevelGrandchild2A(6, -2, -1),
                    new MyModelPrivateSettersMultilevelGrandchild2A(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandchild2A(2, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandchild2A(3, 3, 1),
                    new MyModelPrivateSettersMultilevelGrandchild2A(0, 7, 0),
                },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandchild2B(1, 2, 3),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPrivateSettersMultilevelGrandchild1A(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandchild1B(1, 2, 3),
                },
            });
        }
    }
}