// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPublicSetChild1Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelComparingPublicSetChild1Test
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelComparingPublicSetChild1Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPublicSetChild1>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPublicSetChild1 {  Child1IntProperty = 5, ParentIntProperty = 4 },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPublicSetChild1 { Child1IntProperty = 4, ParentIntProperty = 5 }, new MyModelComparingPublicSetChild1 { Child1IntProperty = 0, ParentIntProperty = 9 }, new MyModelComparingPublicSetChild1 { Child1IntProperty = 5, ParentIntProperty = 4 } },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPublicSetChild1 { Child1IntProperty = 8, ParentIntProperty = 0 }, new MyModelComparingPublicSetChild1 { Child1IntProperty = -5, ParentIntProperty = -4 }, new MyModelComparingPublicSetChild1 { Child1IntProperty = 3, ParentIntProperty = 4 } },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPublicSetChild1 { Child1IntProperty = 9, ParentIntProperty = 1 }, new MyModelComparingPublicSetChild1 { Child1IntProperty = 5, ParentIntProperty = 5 }, new MyModelComparingPublicSetChild1 { Child1IntProperty = -50, ParentIntProperty = 100 } },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new MyModelComparingPublicSetChild2 { Child2IntProperty = 5, ParentIntProperty = 4 } },
            });
        }
    }
}