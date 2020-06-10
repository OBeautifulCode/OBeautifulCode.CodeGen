// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPrivateSetChild1Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelComparingPrivateSetChild1Test
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelComparingPrivateSetChild1Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPrivateSetChild1>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPrivateSetChild1(5, 4),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPrivateSetChild1(4, 5), new MyModelComparingPrivateSetChild1(0, 9), new MyModelComparingPrivateSetChild1(5, 4) },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPrivateSetChild1(8, 0), new MyModelComparingPrivateSetChild1(-5, -4), new MyModelComparingPrivateSetChild1(3, 4) },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPrivateSetChild1(9, 1), new MyModelComparingPrivateSetChild1(5, 5), new MyModelComparingPrivateSetChild1(-50, 100) },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new MyModelComparingPrivateSetChild2(5, 4) },
            });
        }
    }
}