// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPublicSetTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelComparingPublicSetTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelComparingPublicSetTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPublicSet>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPublicSet { IntProperty = 5 },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPublicSet { IntProperty = 5 } },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPublicSet { IntProperty = 4 }, new MyModelComparingPublicSet { IntProperty = -5 } },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPublicSet { IntProperty = 6 }, new MyModelComparingPublicSet { IntProperty = 50 } },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new MyModelComparingPublicSetChild1 { Child1IntProperty = 5, ParentIntProperty = 4 }, new MyModelComparingPublicSetChild2 { Child2IntProperty = 5, ParentIntProperty = 4 } },
            });
        }
    }
}