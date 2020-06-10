// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSetMultilevelParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelPublicSetMultilevelParentTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelPublicSetMultilevelParentTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPublicSetMultilevelParent>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPublicSetMultilevelGrandchild1A
                {
                    ParentInt = 1,
                    Child1Int = 2,
                    Grandchild1AInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1AInt = 3,
                    },
                    new MyModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 3,
                        Child1Int = 2,
                        Grandchild1AInt = 1,
                    },
                    new MyModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 0,
                        Child1Int = 6,
                        Grandchild1AInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1AInt = 2,
                    },
                    new MyModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 6,
                        Child1Int = -2,
                        Grandchild1AInt = -1,
                    },
                    new MyModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 0,
                        Child1Int = 5,
                        Grandchild1AInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 2,
                        Child1Int = 2,
                        Grandchild1AInt = 3,
                    },
                    new MyModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 3,
                        Child1Int = 3,
                        Grandchild1AInt = 1,
                    },
                    new MyModelPublicSetMultilevelGrandchild1A
                    {
                        ParentInt = 0,
                        Child1Int = 7,
                        Grandchild1AInt = 0,
                    },
                },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new MyModelPublicSetMultilevelParent[]
                {
                    new MyModelPublicSetMultilevelGrandchild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1BInt = 3,
                    },
                    new MyModelPublicSetMultilevelGrandchild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2AInt = 3,
                    },
                    new MyModelPublicSetMultilevelGrandchild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2BInt = 3,
                    },
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