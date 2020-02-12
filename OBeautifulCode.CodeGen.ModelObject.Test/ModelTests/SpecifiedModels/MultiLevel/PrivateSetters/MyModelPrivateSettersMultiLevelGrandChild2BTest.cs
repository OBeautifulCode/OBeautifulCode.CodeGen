// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultiLevelGrandChild2BTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelPrivateSettersMultiLevelGrandChild2BTest
    {
        static MyModelPrivateSettersMultiLevelGrandChild2BTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPrivateSettersMultiLevelGrandChild2B>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPrivateSettersMultiLevelGrandChild2B(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultiLevelGrandChild2B(1, 2, 3),
                    new MyModelPrivateSettersMultiLevelGrandChild2B(3, 2, 1),
                    new MyModelPrivateSettersMultiLevelGrandChild2B(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultiLevelGrandChild2B(1, 2, 2),
                    new MyModelPrivateSettersMultiLevelGrandChild2B(6, -2, -1),
                    new MyModelPrivateSettersMultiLevelGrandChild2B(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultiLevelGrandChild2B(2, 2, 3),
                    new MyModelPrivateSettersMultiLevelGrandChild2B(3, 3, 1),
                    new MyModelPrivateSettersMultiLevelGrandChild2B(0, 7, 0),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPrivateSettersMultiLevelGrandChild2A(1, 2, 3),
                    new MyModelPrivateSettersMultiLevelGrandChild1A(1, 2, 3),
                    new MyModelPrivateSettersMultiLevelGrandChild1B(1, 2, 3),
                },
            });
        }
    }
}