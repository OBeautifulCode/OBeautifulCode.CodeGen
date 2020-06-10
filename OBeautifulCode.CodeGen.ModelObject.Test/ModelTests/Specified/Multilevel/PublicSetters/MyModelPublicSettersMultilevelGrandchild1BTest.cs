// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSettersMultilevelGrandchild1BTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class MyModelPublicSettersMultilevelGrandchild1BTest
    {
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelPublicSettersMultilevelGrandchild1BTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<MyModelPublicSettersMultilevelGrandchild1B>
            {
                Name = "Scenario 1",
                ReferenceObject = new MyModelPublicSettersMultilevelGrandchild1B
                {
                    ParentInt = 1,
                    Child1Int = 2,
                    Grandchild1BInt = 3,
                },
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandchild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1BInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1B
                    {
                        ParentInt = 3,
                        Child1Int = 2,
                        Grandchild1BInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1B
                    {
                        ParentInt = 0,
                        Child1Int = 6,
                        Grandchild1BInt = 0,
                    },
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandchild1B
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1BInt = 2,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1B
                    {
                        ParentInt = 6,
                        Child1Int = -2,
                        Grandchild1BInt = -1,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1B
                    {
                        ParentInt = 0,
                        Child1Int = 5,
                        Grandchild1BInt = 0,
                    },
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    new MyModelPublicSettersMultilevelGrandchild1B
                    {
                        ParentInt = 2,
                        Child1Int = 2,
                        Grandchild1BInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1B
                    {
                        ParentInt = 3,
                        Child1Int = 3,
                        Grandchild1BInt = 1,
                    },
                    new MyModelPublicSettersMultilevelGrandchild1B
                    {
                        ParentInt = 0,
                        Child1Int = 7,
                        Grandchild1BInt = 0,
                    },
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy-string",
                    new MyModelPublicSettersMultilevelGrandchild1A
                    {
                        ParentInt = 1,
                        Child1Int = 2,
                        Grandchild1AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild2A
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2AInt = 3,
                    },
                    new MyModelPublicSettersMultilevelGrandchild2B
                    {
                        ParentInt = 1,
                        Child2Int = 2,
                        Grandchild2BInt = 3,
                    },
                },
            });
        }
    }
}