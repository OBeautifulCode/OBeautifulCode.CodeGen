// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPublicSetNullableTest.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPublicSetNullableTest
    {
        private static readonly ModelHashingPublicSetNullable ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPublicSetNullable>();

        private static readonly EquatableTestScenarios<ModelHashingPublicSetNullable> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPublicSetNullable>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPublicSetNullable>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPublicSetNullable[]
                    {
                        new ModelHashingPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPublicSetNullable[]
                    {
                        new ModelHashingPublicSetNullable
                            {
                                NullableBoolProperty            = A.Dummy<ModelHashingPublicSetNullable>().Whose(_ => !_.NullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableBoolProperty)).NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = A.Dummy<ModelHashingPublicSetNullable>().Whose(_ => !_.NullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableIntProperty)).NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = A.Dummy<ModelHashingPublicSetNullable>().Whose(_ => !_.NullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableGuidProperty)).NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = A.Dummy<ModelHashingPublicSetNullable>().Whose(_ => !_.NullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty)).NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = A.Dummy<ModelHashingPublicSetNullable>().Whose(_ => !_.NullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty)).NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = A.Dummy<ModelHashingPublicSetNullable>().Whose(_ => !_.NullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty)).NullableCustomFlagsEnumProperty,
                            },
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
        static ModelHashingPublicSetNullableTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}