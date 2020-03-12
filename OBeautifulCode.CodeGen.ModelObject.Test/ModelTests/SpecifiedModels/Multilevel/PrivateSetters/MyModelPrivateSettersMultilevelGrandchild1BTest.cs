// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSettersMultilevelGrandchild1BTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelPrivateSettersMultilevelGrandchild1BTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelPrivateSettersMultilevelGrandchild1BTest()
        {
            ConstructorArgumentValidationTestScenarios.AddScenario(
                ConstructorArgumentValidationTestScenario<MyModelPrivateSettersMultilevelGrandchild1B>.AlwaysPassingScenario);

            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPrivateSettersMultilevelGrandchild1B>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPrivateSettersMultilevelGrandchild1B(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandchild1B(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandchild1B(3, 2, 1),
                    new MyModelPrivateSettersMultilevelGrandchild1B(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandchild1B(1, 2, 2),
                    new MyModelPrivateSettersMultilevelGrandchild1B(6, -2, -1),
                    new MyModelPrivateSettersMultilevelGrandchild1B(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPrivateSettersMultilevelGrandchild1B(2, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandchild1B(3, 3, 1),
                    new MyModelPrivateSettersMultilevelGrandchild1B(0, 7, 0),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPrivateSettersMultilevelGrandchild1A(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandchild2A(1, 2, 3),
                    new MyModelPrivateSettersMultilevelGrandchild2B(1, 2, 3),
                },
            });
        }
    }
}