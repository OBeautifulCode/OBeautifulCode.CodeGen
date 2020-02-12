// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultilevelParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelPrivateSettersMultilevelParentTest
    {
        static MyModelPrivateSettersMultilevelParentTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPrivateSettersMultilevelParent>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPrivateSettersMultilevelGrandChild1A(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandChild1A(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandChild1A(3, 2, 1),
                    new MyModelPrivateSettersMultilevelGrandChild1A(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandChild1A(1, 2, 2),
                    new MyModelPrivateSettersMultilevelGrandChild1A(6, -2, -1),
                    new MyModelPrivateSettersMultilevelGrandChild1A(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandChild1A(2, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandChild1A(3, 3, 1),
                    new MyModelPrivateSettersMultilevelGrandChild1A(0, 7, 0),
                },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new MyModelPrivateSettersMultilevelParent[]
                {
                    new MyModelPrivateSettersMultilevelGrandChild1B(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandChild2A(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandChild2B(1, 2, 3),
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