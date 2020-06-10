// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSetMultilevelGrandchild1ATest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelPrivateSetMultilevelGrandchild1ATest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelPrivateSetMultilevelGrandchild1ATest()
        {
            StringRepresentationTestScenarios.RemoveAllScenarios();

            StringRepresentationTestScenarios.AddScenario(StringRepresentationTestScenario<MyModelPrivateSetMultilevelGrandchild1A>.ForceGeneratedTestsToPassAndWriteMyOwnScenario);

            ConstructorArgumentValidationTestScenarios.AddScenario(
                ConstructorArgumentValidationTestScenario<MyModelPrivateSetMultilevelGrandchild1A>.ConstructorCannotThrowScenario);

            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPrivateSetMultilevelGrandchild1A>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPrivateSetMultilevelGrandchild1A(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild1A(1, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild1A(3, 2, 1),
                    new MyModelPrivateSetMultilevelGrandchild1A(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild1A(1, 2, 2),
                    new MyModelPrivateSetMultilevelGrandchild1A(6, -2, -1),
                    new MyModelPrivateSetMultilevelGrandchild1A(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild1A(2, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild1A(3, 3, 1),
                    new MyModelPrivateSetMultilevelGrandchild1A(0, 7, 0),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPrivateSetMultilevelGrandchild1B(1, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild2A(1, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild2B(1, 2, 3),
                },
            });
        }
    }
}