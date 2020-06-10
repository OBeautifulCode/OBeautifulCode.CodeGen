﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelComparingPublicSetChild2Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelComparingPublicSetChild2Test
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelComparingPublicSetChild2Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelComparingPublicSetChild2>
            {
                Name = "Scenario 1",
                ReferenceObject = new ModelComparingPublicSetChild2 { Child2IntProperty = 5, ParentIntProperty = 4 },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new ModelComparingPublicSetChild2 { Child2IntProperty = 4, ParentIntProperty = 5 }, new ModelComparingPublicSetChild2 { Child2IntProperty = 0, ParentIntProperty = 9 }, new ModelComparingPublicSetChild2 { Child2IntProperty = 5, ParentIntProperty = 4 } },
                ObjectsThatAreLessThanReferenceObject = new[] { new ModelComparingPublicSetChild2 { Child2IntProperty = 8, ParentIntProperty = 0 }, new ModelComparingPublicSetChild2 { Child2IntProperty = -5, ParentIntProperty = -4 }, new ModelComparingPublicSetChild2 { Child2IntProperty = 3, ParentIntProperty = 4 } },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new ModelComparingPublicSetChild2 { Child2IntProperty = 9, ParentIntProperty = 1 }, new ModelComparingPublicSetChild2 { Child2IntProperty = 5, ParentIntProperty = 5 }, new ModelComparingPublicSetChild2 { Child2IntProperty = -50, ParentIntProperty = 100 } },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new ModelComparingPublicSetChild1 { Child1IntProperty = 5, ParentIntProperty = 4 } },
            });
        }
    }
}