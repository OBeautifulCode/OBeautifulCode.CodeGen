// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultilevelGrandChild2ATest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelPrivateSettersMultilevelGrandChild2ATest
    {
        static MyModelPrivateSettersMultilevelGrandChild2ATest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPrivateSettersMultilevelGrandChild2A>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPrivateSettersMultilevelGrandChild2A(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandChild2A(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandChild2A(3, 2, 1),
                    new MyModelPrivateSettersMultilevelGrandChild2A(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandChild2A(1, 2, 2),
                    new MyModelPrivateSettersMultilevelGrandChild2A(6, -2, -1),
                    new MyModelPrivateSettersMultilevelGrandChild2A(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandChild2A(2, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandChild2A(3, 3, 1),
                    new MyModelPrivateSettersMultilevelGrandChild2A(0, 7, 0),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPrivateSettersMultilevelGrandChild2B(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandChild1A(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandChild1B(1, 2, 3),
                },
            });
        }
    }
}