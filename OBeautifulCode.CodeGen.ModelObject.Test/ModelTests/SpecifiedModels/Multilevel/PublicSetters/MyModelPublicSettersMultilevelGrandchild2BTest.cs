// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultilevelGrandchild2BTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelPublicSettersMultilevelGrandchild2BTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelPublicSettersMultilevelGrandchild2BTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPublicSettersMultilevelGrandchild2B>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPublicSettersMultilevelGrandchild2B
                {
                    ParentInt = 1,
                    Child2Int = 2,
                    Grandchild2BInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandchild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2BInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild2B
                    {
                        ParentInt = 3,
                        Child2Int = 2,
                        Grandchild2BInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandchild2B
                    {
                        ParentInt = 0,
                        Child2Int = 6,
                        Grandchild2BInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandchild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2BInt = 2,
                    },
                    new MyModelPublicSettersMultilevelGrandchild2B
                    {
                        ParentInt = 6,
                        Child2Int = -2,
                        Grandchild2BInt = -1,
                    },
                    new MyModelPublicSettersMultilevelGrandchild2B
                    {
                        ParentInt = 0,
                        Child2Int = 5,
                        Grandchild2BInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandchild2B
                    {
                        ParentInt = 2,
                        Child2Int = 2,
                        Grandchild2BInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild2B
                    {
                        ParentInt = 3,
                        Child2Int = 3,
                        Grandchild2BInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandchild2B
                    {
                        ParentInt = 0,
                        Child2Int = 7,
                        Grandchild2BInt = 0,
                    },
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPublicSettersMultilevelGrandchild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1BInt = 3,
                    },
                },
            });
        }
    }
}