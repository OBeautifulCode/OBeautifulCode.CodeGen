// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultilevelParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelPrivateSettersMultilevelParentTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelPrivateSettersMultilevelParentTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPrivateSettersMultilevelParent>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPrivateSettersMultilevelGrandchild1A(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandchild1A(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandchild1A(3, 2, 1),
                    new MyModelPrivateSettersMultilevelGrandchild1A(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandchild1A(1, 2, 2),
                    new MyModelPrivateSettersMultilevelGrandchild1A(6, -2, -1),
                    new MyModelPrivateSettersMultilevelGrandchild1A(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandchild1A(2, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandchild1A(3, 3, 1),
                    new MyModelPrivateSettersMultilevelGrandchild1A(0, 7, 0),
                },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new MyModelPrivateSettersMultilevelParent[]
                {
                    new MyModelPrivateSettersMultilevelGrandchild1B(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandchild2A(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandchild2B(1, 2, 3),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                },
            });
        }
    }
}