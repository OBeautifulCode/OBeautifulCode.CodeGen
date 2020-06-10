// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPrivateSetTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelComparingPrivateSetTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelComparingPrivateSetTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPrivateSet>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPrivateSet(5),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPrivateSet(5) },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPrivateSet(4), new MyModelComparingPrivateSet(-5), new MyModelComparingPrivateSet(0) },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPrivateSet(6), new MyModelComparingPrivateSet(10) },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new MyModelComparingPrivateSetChild1(5, 4), new MyModelComparingPrivateSetChild2(5, 4) },
            });
        }
    }
}