// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelComparingPublicSetChild1Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelComparingPublicSetChild1Test
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelComparingPublicSetChild1Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelComparingPublicSetChild1>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelComparingPublicSetChild1 {  Child1IntProperty = 5, ParentIntProperty = 4 },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new ModelComparingPublicSetChild1 { Child1IntProperty = 4, ParentIntProperty = 5 }, new ModelComparingPublicSetChild1 { Child1IntProperty = 0, ParentIntProperty = 9 }, new ModelComparingPublicSetChild1 { Child1IntProperty = 5, ParentIntProperty = 4 } },
                ObjectsThatAreLessThanReferenceObject = new[] { new ModelComparingPublicSetChild1 { Child1IntProperty = 8, ParentIntProperty = 0 }, new ModelComparingPublicSetChild1 { Child1IntProperty = -5, ParentIntProperty = -4 }, new ModelComparingPublicSetChild1 { Child1IntProperty = 3, ParentIntProperty = 4 } },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new ModelComparingPublicSetChild1 { Child1IntProperty = 9, ParentIntProperty = 1 }, new ModelComparingPublicSetChild1 { Child1IntProperty = 5, ParentIntProperty = 5 }, new ModelComparingPublicSetChild1 { Child1IntProperty = -50, ParentIntProperty = 100 } },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new ModelComparingPublicSetChild2 { Child2IntProperty = 5, ParentIntProperty = 4 } },
            });
        }
    }
}