// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelComparingPublicSetParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelComparingPublicSetParentTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelComparingPublicSetParentTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelComparingPublicSetParent>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelComparingPublicSetChild1 { Child1IntProperty = 5, ParentIntProperty = 4 },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new ModelComparingPublicSetChild1 { Child1IntProperty = 4, ParentIntProperty = 5 }, new ModelComparingPublicSetChild1 { Child1IntProperty = 0, ParentIntProperty = 9 }, new ModelComparingPublicSetChild1 { Child1IntProperty = 5, ParentIntProperty = 4 } },
                ObjectsThatAreLessThanReferenceObject = new[] { new ModelComparingPublicSetChild1 { Child1IntProperty = 8, ParentIntProperty = 0 }, new ModelComparingPublicSetChild1 { Child1IntProperty = -5, ParentIntProperty = -4 }, new ModelComparingPublicSetChild1 { Child1IntProperty = 3, ParentIntProperty = 4 } },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new ModelComparingPublicSetChild1 { Child1IntProperty = 9, ParentIntProperty = 1 }, new ModelComparingPublicSetChild1 { Child1IntProperty = 5, ParentIntProperty = 5 }, new ModelComparingPublicSetChild1 { Child1IntProperty = -50, ParentIntProperty = 100 } },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[] { new ModelComparingPublicSetChild2 { Child2IntProperty = 5, ParentIntProperty = 4 } },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string" },
            });
        }
    }
}