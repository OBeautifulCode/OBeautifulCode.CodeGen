// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelComparingPublicSetTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelComparingPublicSetTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelComparingPublicSetTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelComparingPublicSet>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelComparingPublicSet { IntProperty = 5 },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new ModelComparingPublicSet { IntProperty = 5 } },
                ObjectsThatAreLessThanReferenceObject = new[] { new ModelComparingPublicSet { IntProperty = 4 }, new ModelComparingPublicSet { IntProperty = -5 } },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new ModelComparingPublicSet { IntProperty = 6 }, new ModelComparingPublicSet { IntProperty = 50 } },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new ModelComparingPublicSetChild1 { Child1IntProperty = 5, ParentIntProperty = 4 }, new ModelComparingPublicSetChild2 { Child2IntProperty = 5, ParentIntProperty = 4 } },
            });
        }
    }
}