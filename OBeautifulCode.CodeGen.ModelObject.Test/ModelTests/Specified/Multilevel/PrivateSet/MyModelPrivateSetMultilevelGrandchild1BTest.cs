// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSetMultilevelGrandchild1BTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelPrivateSetMultilevelGrandchild1BTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelPrivateSetMultilevelGrandchild1BTest()
        {
            ConstructorArgumentValidationTestScenarios.AddScenario(
                ConstructorArgumentValidationTestScenario<MyModelPrivateSetMultilevelGrandchild1B>.ConstructorCannotThrowScenario);

            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPrivateSetMultilevelGrandchild1B>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPrivateSetMultilevelGrandchild1B(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild1B(1, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild1B(3, 2, 1),
                    new MyModelPrivateSetMultilevelGrandchild1B(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild1B(1, 2, 2),
                    new MyModelPrivateSetMultilevelGrandchild1B(6, -2, -1),
                    new MyModelPrivateSetMultilevelGrandchild1B(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild1B(2, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild1B(3, 3, 1),
                    new MyModelPrivateSetMultilevelGrandchild1B(0, 7, 0),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPrivateSetMultilevelGrandchild1A(1, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild2A(1, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild2B(1, 2, 3),
                },
            });
        }
    }
}