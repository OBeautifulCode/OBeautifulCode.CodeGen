// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPublicSettersChild2Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class MyModelComparingPublicSettersChild2Test
    {
        static MyModelComparingPublicSettersChild2Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPublicSettersChild2>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPublicSettersChild2 { Child2IntProperty = 5, ParentIntProperty = 4 },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPublicSettersChild2 { Child2IntProperty = 4, ParentIntProperty = 5 }, new MyModelComparingPublicSettersChild2 { Child2IntProperty = 0, ParentIntProperty = 9 }, new MyModelComparingPublicSettersChild2 { Child2IntProperty = 5, ParentIntProperty = 4 } },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPublicSettersChild2 { Child2IntProperty = 8, ParentIntProperty = 0 }, new MyModelComparingPublicSettersChild2 { Child2IntProperty = -5, ParentIntProperty = -4 }, new MyModelComparingPublicSettersChild2 { Child2IntProperty = 3, ParentIntProperty = 4 } },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPublicSettersChild2 { Child2IntProperty = 9, ParentIntProperty = 1 }, new MyModelComparingPublicSettersChild2 { Child2IntProperty = 5, ParentIntProperty = 5 }, new MyModelComparingPublicSettersChild2 { Child2IntProperty = -50, ParentIntProperty = 100 } },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new MyModelComparingPublicSettersChild1 { Child1IntProperty = 5, ParentIntProperty = 4 } },
            });
        }
    }
}