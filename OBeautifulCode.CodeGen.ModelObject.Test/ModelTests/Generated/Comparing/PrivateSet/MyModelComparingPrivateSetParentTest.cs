// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPrivateSetParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelComparingPrivateSetParentTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelComparingPrivateSetParentTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPrivateSetParent>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPrivateSetChild1(5, 4),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPrivateSetChild1(4, 5), new MyModelComparingPrivateSetChild1(0, 9), new MyModelComparingPrivateSetChild1(5, 4) },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPrivateSetChild1(8, 0), new MyModelComparingPrivateSetChild1(-5, -4), new MyModelComparingPrivateSetChild1(3, 4) },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPrivateSetChild1(9, 1), new MyModelComparingPrivateSetChild1(5, 5), new MyModelComparingPrivateSetChild1(-50, 100) },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[] { new MyModelComparingPrivateSetChild2(5, 4) },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string" },
            });
        }
    }
}