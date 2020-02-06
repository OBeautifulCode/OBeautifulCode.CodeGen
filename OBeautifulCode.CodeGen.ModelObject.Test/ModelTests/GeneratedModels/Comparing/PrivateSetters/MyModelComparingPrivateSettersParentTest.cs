// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPrivateSettersParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelComparingPrivateSettersParentTest
    {
        static MyModelComparingPrivateSettersParentTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPrivateSettersParent>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPrivateSettersChild1(5, 4),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPrivateSettersChild1(4, 5), new MyModelComparingPrivateSettersChild1(0, 9), new MyModelComparingPrivateSettersChild1(5, 4) },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPrivateSettersChild1(8, 0), new MyModelComparingPrivateSettersChild1(-5, -4), new MyModelComparingPrivateSettersChild1(3, 4) },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPrivateSettersChild1(9, 1), new MyModelComparingPrivateSettersChild1(5, 5), new MyModelComparingPrivateSettersChild1(-50, 100) },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[] { new MyModelComparingPrivateSettersChild2(5, 4) },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string" },
            });
        }
    }
}