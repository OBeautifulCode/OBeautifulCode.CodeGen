// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPrivateSettersTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelComparingPrivateSettersTest
    {
        static MyModelComparingPrivateSettersTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPrivateSetters>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPrivateSetters(5),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPrivateSetters(5) },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPrivateSetters(4), new MyModelComparingPrivateSetters(-5), new MyModelComparingPrivateSetters(0) },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPrivateSetters(6), new MyModelComparingPrivateSetters(10) },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new MyModelComparingPrivateSettersChild1(5, 4), new MyModelComparingPrivateSettersChild2(5, 4) },
            });
        }
    }
}