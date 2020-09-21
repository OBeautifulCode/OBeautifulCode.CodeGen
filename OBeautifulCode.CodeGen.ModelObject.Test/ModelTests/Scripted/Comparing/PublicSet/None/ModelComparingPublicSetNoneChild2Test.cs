// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelComparingPublicSetNoneChild2Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class ModelComparingPublicSetNoneChild2Test
    {

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelComparingPublicSetNoneChild2Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelComparingPublicSetNoneChild2>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelComparingPublicSetNoneChild2 { Child2IntProperty = 5, ParentIntProperty = 4 },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new ModelComparingPublicSetNoneChild2 { Child2IntProperty = 4, ParentIntProperty = 5 }, new ModelComparingPublicSetNoneChild2 { Child2IntProperty = 0, ParentIntProperty = 9 }, new ModelComparingPublicSetNoneChild2 { Child2IntProperty = 5, ParentIntProperty = 4 } },
                ObjectsThatAreLessThanReferenceObject = new[] { new ModelComparingPublicSetNoneChild2 { Child2IntProperty = 8, ParentIntProperty = 0 }, new ModelComparingPublicSetNoneChild2 { Child2IntProperty = -5, ParentIntProperty = -4 }, new ModelComparingPublicSetNoneChild2 { Child2IntProperty = 3, ParentIntProperty = 4 } },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new ModelComparingPublicSetNoneChild2 { Child2IntProperty = 9, ParentIntProperty = 1 }, new ModelComparingPublicSetNoneChild2 { Child2IntProperty = 5, ParentIntProperty = 5 }, new ModelComparingPublicSetNoneChild2 { Child2IntProperty = -50, ParentIntProperty = 100 } },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new ModelComparingPublicSetNoneChild1 { Child1IntProperty = 5, ParentIntProperty = 4 } },
            });
        }
    }
}