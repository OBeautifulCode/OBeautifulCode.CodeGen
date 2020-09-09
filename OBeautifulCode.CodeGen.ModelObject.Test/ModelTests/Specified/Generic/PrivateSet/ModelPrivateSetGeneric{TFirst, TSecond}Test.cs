// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetGeneric{TFirst, TSecond}Test.cs" company="OBeautifulCode">
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
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelPrivateSetGenericTest
    {
        private static readonly ModelPrivateSetGeneric<Version, Guid> ReferenceObject = A.Dummy<ModelPrivateSetGeneric<Version, Guid>>();

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelPrivateSetGenericTest()
        {
            ComparableTestScenarios.AddScenario(new ComparableTestScenario<ModelPrivateSetGeneric<Version, Guid>>
            {
                Name = "Scenario 1",
                ReferenceObject = ReferenceObject,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new[]
                {
                    ReferenceObject.DeepCloneWithCustomClassProperty(A.Dummy<CustomClass>()),
                },
                ObjectsThatAreLessThanReferenceObject = new[]
                {
                    A.Dummy<ModelPrivateSetGeneric<Version, Guid>>().Whose(_=> _.IntProperty < ReferenceObject.IntProperty),
                },
                ObjectsThatAreGreaterThanReferenceObject = new[]
                {
                    A.Dummy<ModelPrivateSetGeneric<Version, Guid>>().Whose(_=> _.IntProperty > ReferenceObject.IntProperty),
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