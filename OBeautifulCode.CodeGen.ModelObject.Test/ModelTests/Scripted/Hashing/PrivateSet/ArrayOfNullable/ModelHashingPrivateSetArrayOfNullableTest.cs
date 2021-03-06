// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetArrayOfNullableTest.cs" company="OBeautifulCode">
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
    using OBeautifulCode.Equality.Recipes;

    public static partial class ModelHashingPrivateSetArrayOfNullableTest
    {
        private static readonly ModelHashingPrivateSetArrayOfNullable ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPrivateSetArrayOfNullable>();

        private static readonly EquatableTestScenarios<ModelHashingPrivateSetArrayOfNullable> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPrivateSetArrayOfNullable>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPrivateSetArrayOfNullable>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPrivateSetArrayOfNullable[]
                    {
                        new ModelHashingPrivateSetArrayOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPrivateSetArrayOfNullable[]
                    {
                        new ModelHashingPrivateSetArrayOfNullable(
                                A.Dummy<ModelHashingPrivateSetArrayOfNullable>().Whose(_ => !_.ArrayOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfNullableBoolProperty)).ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableBoolProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullable>().Whose(_ => !_.ArrayOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfNullableIntProperty)).ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableIntProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullable>().Whose(_ => !_.ArrayOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfNullableGuidProperty)).ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableGuidProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullable>().Whose(_ => !_.ArrayOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfNullableDateTimeProperty)).ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableDateTimeProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullable>().Whose(_ => !_.ArrayOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomEnumProperty)).ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomEnumProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullable>().Whose(_ => !_.ArrayOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfNullableCustomFlagsEnumProperty)).ArrayOfNullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                    },
                });

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelHashingPrivateSetArrayOfNullableTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}