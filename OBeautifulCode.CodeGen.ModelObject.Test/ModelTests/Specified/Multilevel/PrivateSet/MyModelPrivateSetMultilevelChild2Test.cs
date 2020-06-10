// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPrivateSetMultilevelChild2Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelPrivateSetMultilevelChild2Test
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelPrivateSetMultilevelChild2Test()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPrivateSetMultilevelChild2>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPrivateSetMultilevelGrandchild2A(1, 2, 3),
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild2A(1, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild2A(3, 2, 1),
                    new MyModelPrivateSetMultilevelGrandchild2A(0, 6, 0),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild2A(1, 2, 2),
                    new MyModelPrivateSetMultilevelGrandchild2A(6, -2, -1),
                    new MyModelPrivateSetMultilevelGrandchild2A(0, 5, 0),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild2A(2, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild2A(3, 3, 1),
                    new MyModelPrivateSetMultilevelGrandchild2A(0, 7, 0),
                },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[]
                {
                    new MyModelPrivateSetMultilevelGrandchild2B(1, 2, 3),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPrivateSetMultilevelGrandchild1A(1, 2, 3),
                    new MyModelPrivateSetMultilevelGrandchild1B(1, 2, 3),
                },
            });
        }
    }
}