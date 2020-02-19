// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPrivateSettersChild2Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelComparingPrivateSettersChild2Test
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelComparingPrivateSettersChild2Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelComparingPrivateSettersChild2>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelComparingPrivateSettersChild2(5, 4),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[] { new MyModelComparingPrivateSettersChild2(4, 5), new MyModelComparingPrivateSettersChild2(0, 9), new MyModelComparingPrivateSettersChild2(5, 4) },
                ObjectsThatAreLessThanReferenceObject = new[] { new MyModelComparingPrivateSettersChild2(8, 0), new MyModelComparingPrivateSettersChild2(-5, -4), new MyModelComparingPrivateSettersChild2(3, 4) },
                ObjectsThatAreGreaterThanReferenceObject = new[] { new MyModelComparingPrivateSettersChild2(9, 1), new MyModelComparingPrivateSettersChild2(5, 5), new MyModelComparingPrivateSettersChild2(-50, 100) },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[] { 1, "dummy-string", new MyModelComparingPrivateSettersChild1(5, 4) },
            });
        }
    }
}