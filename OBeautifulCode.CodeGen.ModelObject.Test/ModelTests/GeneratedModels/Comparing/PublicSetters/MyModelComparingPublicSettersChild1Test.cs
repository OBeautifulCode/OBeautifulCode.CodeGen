// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPublicSettersChild1Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelComparingPublicSettersChild1Test
    {
        static MyModelComparingPublicSettersChild1Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPublicSettersChild1>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPublicSettersChild1 {  Child1IntProperty = 5, ParentIntProperty = 4 },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPublicSettersChild1 { Child1IntProperty = 4, ParentIntProperty = 5 }, new MyModelComparingPublicSettersChild1 { Child1IntProperty = 0, ParentIntProperty = 9 }, new MyModelComparingPublicSettersChild1 { Child1IntProperty = 5, ParentIntProperty = 4 } },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPublicSettersChild1 { Child1IntProperty = 8, ParentIntProperty = 0 }, new MyModelComparingPublicSettersChild1 { Child1IntProperty = -5, ParentIntProperty = -4 }, new MyModelComparingPublicSettersChild1 { Child1IntProperty = 3, ParentIntProperty = 4 } },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPublicSettersChild1 { Child1IntProperty = 9, ParentIntProperty = 1 }, new MyModelComparingPublicSettersChild1 { Child1IntProperty = 5, ParentIntProperty = 5 }, new MyModelComparingPublicSettersChild1 { Child1IntProperty = -50, ParentIntProperty = 100 } },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new MyModelComparingPublicSettersChild2 { Child2IntProperty = 5, ParentIntProperty = 4 } },
            });
        }
    }
}