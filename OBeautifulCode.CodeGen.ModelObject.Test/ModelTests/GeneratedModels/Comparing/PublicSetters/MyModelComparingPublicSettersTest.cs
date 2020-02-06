// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPublicSettersTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelComparingPublicSettersTest
    {
        static MyModelComparingPublicSettersTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPublicSetters>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPublicSetters { IntProperty = 5 },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPublicSetters { IntProperty = 5 } },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPublicSetters { IntProperty = 4 }, new MyModelComparingPublicSetters { IntProperty = -5 } },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPublicSetters { IntProperty = 6 }, new MyModelComparingPublicSetters { IntProperty = 50 } },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new MyModelComparingPublicSettersChild1 { Child1IntProperty = 5, ParentIntProperty = 4 }, new MyModelComparingPublicSettersChild2 { Child2IntProperty = 5, ParentIntProperty = 4 } },
            });
        }
    }
}