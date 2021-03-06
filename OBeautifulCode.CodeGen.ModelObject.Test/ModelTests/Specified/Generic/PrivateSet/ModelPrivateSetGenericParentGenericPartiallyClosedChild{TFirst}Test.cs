// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetGenericParentGenericPartiallyClosedChild{TFirst}Test.cs" company="OBeautifulCode">
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

    public static partial class ModelPrivateSetGenericParentGenericPartiallyClosedChildTFirstTest
    {
        private static readonly ModelPrivateSetGenericParentGenericPartiallyClosedChild<Version> ReferenceObject = A.Dummy<ModelPrivateSetGenericParentGenericPartiallyClosedChild<Version>>();

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelPrivateSetGenericParentGenericPartiallyClosedChildTFirstTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelPrivateSetGenericParentGenericPartiallyClosedChild<Version>>
            {
                Name = "Scenario 1",
                ReferenceObject = ReferenceObject,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    ReferenceObject.DeepCloneWithChildCustomClassProperty(A.Dummy<CustomClass>()),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    A.Dummy<ModelPrivateSetGenericParentGenericPartiallyClosedChild<Version>>().Whose(_=> _.ChildIntProperty < ReferenceObject.ChildIntProperty),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    A.Dummy<ModelPrivateSetGenericParentGenericPartiallyClosedChild<Version>>().Whose(_=> _.ChildIntProperty > ReferenceObject.ChildIntProperty),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                {
                    1,
                    "dummy - string",
                    A.Dummy<ModelPrivateSetGenericParentGenericChild<Version, Guid>>(),
                    A.Dummy<ModelPrivateSetGenericParentNonGenericChild>(),
                },
            });
        }
    }
}