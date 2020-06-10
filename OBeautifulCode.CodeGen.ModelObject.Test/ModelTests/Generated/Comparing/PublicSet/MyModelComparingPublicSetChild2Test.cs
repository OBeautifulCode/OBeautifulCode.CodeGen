// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPublicSetChild2Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelComparingPublicSetChild2Test
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelComparingPublicSetChild2Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPublicSetChild2>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPublicSetChild2 { Child2IntProperty = 5, ParentIntProperty = 4 },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPublicSetChild2 { Child2IntProperty = 4, ParentIntProperty = 5 }, new MyModelComparingPublicSetChild2 { Child2IntProperty = 0, ParentIntProperty = 9 }, new MyModelComparingPublicSetChild2 { Child2IntProperty = 5, ParentIntProperty = 4 } },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPublicSetChild2 { Child2IntProperty = 8, ParentIntProperty = 0 }, new MyModelComparingPublicSetChild2 { Child2IntProperty = -5, ParentIntProperty = -4 }, new MyModelComparingPublicSetChild2 { Child2IntProperty = 3, ParentIntProperty = 4 } },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPublicSetChild2 { Child2IntProperty = 9, ParentIntProperty = 1 }, new MyModelComparingPublicSetChild2 { Child2IntProperty = 5, ParentIntProperty = 5 }, new MyModelComparingPublicSetChild2 { Child2IntProperty = -50, ParentIntProperty = 100 } },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new MyModelComparingPublicSetChild1 { Child1IntProperty = 5, ParentIntProperty = 4 } },
            });
        }
    }
}