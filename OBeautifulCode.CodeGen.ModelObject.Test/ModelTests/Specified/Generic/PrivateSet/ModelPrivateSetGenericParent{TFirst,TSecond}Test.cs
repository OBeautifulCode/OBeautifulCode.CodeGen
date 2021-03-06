// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetGenericParentGenericChild{TFirst,TSecond}Test.cs" company="OBeautifulCode">
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


    public static partial class ModelPrivateSetGenericParentTFirstTSecondTest
    {
        private static readonly ModelPrivateSetGenericParentGenericChild<Version, Guid> ReferenceObject = A.Dummy<ModelPrivateSetGenericParentGenericChild<Version, Guid>>();

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelPrivateSetGenericParentTFirstTSecondTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelPrivateSetGenericParent<Version, Guid>>
            {
                Name = "Scenario 1",
                ReferenceObject = ReferenceObject,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    ReferenceObject.DeepCloneWithChildCustomClassProperty(A.Dummy<CustomClass>()),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    A.Dummy<ModelPrivateSetGenericParentGenericChild<Version, Guid>>().Whose(_=> _.ChildIntProperty < ReferenceObject.ChildIntProperty),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    A.Dummy<ModelPrivateSetGenericParentGenericChild<Version, Guid>>().Whose(_=> _.ChildIntProperty > ReferenceObject.ChildIntProperty),
                },
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new ModelPrivateSetGenericParent<Version, Guid>[]
                {
                    A.Dummy<ModelPrivateSetGenericParentGenericPartiallyClosedChild<Version>>().DeepCloneWithChildIntProperty(ReferenceObject.ChildIntProperty),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy - string",
                },
            });
        }
    }
}