// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetNonGenericParentGenericChild{TFirst,TSecond}Test.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    public static partial class ModelPrivateSetNonGenericParentGenericChildTest
    {
        private static readonly ModelPrivateSetNonGenericParentGenericChild<Version, Guid> ReferenceObject = A.Dummy<ModelPrivateSetNonGenericParentGenericChild<Version, Guid>>();

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelPrivateSetNonGenericParentGenericChildTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelPrivateSetNonGenericParentGenericChild<Version, Guid>>
            {
                Name = "Scenario 1",
                ReferenceObject = ReferenceObject,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    ReferenceObject.DeepCloneWithChildClassProperty(A.Dummy<CustomClass>()),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    A.Dummy<ModelPrivateSetNonGenericParentGenericChild<Version, Guid>>().Whose(_=> _.ChildIntProperty < ReferenceObject.ChildIntProperty),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    A.Dummy<ModelPrivateSetNonGenericParentGenericChild<Version, Guid>>().Whose(_=> _.ChildIntProperty > ReferenceObject.ChildIntProperty),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy - string",
                    A.Dummy<ModelPrivateSetGenericParentGenericPartiallyClosedChild<Version>>(),
                    A.Dummy<ModelPrivateSetGenericParentNonGenericChild>(),
                    A.Dummy<ModelPrivateSetGenericParentGenericChild<Version, Guid>>(),
                },
            });
        }
    }
}