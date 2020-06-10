// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSetMultilevelGrandchild2BTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelPrivateSetMultilevelGrandchild2BTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelPrivateSetMultilevelGrandchild2BTest()
        {
            ConstructorArgumentValidationTestScenarios.AddScenario(
                ConstructorArgumentValidationTestScenario<MyModelPrivateSetMultilevelGrandchild2B>.ConstructorCannotThrowScenario);

            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPrivateSetMultilevelGrandchild2B>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPrivateSetMultilevelGrandchild2B(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild2B(1, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild2B(3, 2, 1),
                    new MyModelPrivateSetMultilevelGrandchild2B(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild2B(1, 2, 2),
                    new MyModelPrivateSetMultilevelGrandchild2B(6, -2, -1),
                    new MyModelPrivateSetMultilevelGrandchild2B(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild2B(2, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild2B(3, 3, 1),
                    new MyModelPrivateSetMultilevelGrandchild2B(0, 7, 0),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPrivateSetMultilevelGrandchild2A(1, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild1A(1, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild1B(1, 2, 3),
                },
            });
        }
    }
}