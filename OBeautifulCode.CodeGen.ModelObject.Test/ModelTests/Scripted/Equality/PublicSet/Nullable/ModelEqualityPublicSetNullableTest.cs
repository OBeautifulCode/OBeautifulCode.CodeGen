// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetNullableTest.cs" company="OBeautifulCode">
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
    using OBeautifulCode.Equality.Recipes;

    public static partial class ModelEqualityPublicSetNullableTest
    {
        private static readonly ModelEqualityPublicSetNullable ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelEqualityPublicSetNullable>();

        private static readonly EquatableTestScenarios<ModelEqualityPublicSetNullable> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelEqualityPublicSetNullable>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelEqualityPublicSetNullable>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelEqualityPublicSetNullable[]
                    {
                        new ModelEqualityPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelEqualityPublicSetNullable[]
                    {
                        new ModelEqualityPublicSetNullable
                            {
                                NullableBoolProperty            = A.Dummy<ModelEqualityPublicSetNullable>().Whose(_ => !_.NullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableBoolProperty)).NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = A.Dummy<ModelEqualityPublicSetNullable>().Whose(_ => !_.NullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableIntProperty)).NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = A.Dummy<ModelEqualityPublicSetNullable>().Whose(_ => !_.NullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableGuidProperty)).NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = A.Dummy<ModelEqualityPublicSetNullable>().Whose(_ => !_.NullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty)).NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = A.Dummy<ModelEqualityPublicSetNullable>().Whose(_ => !_.NullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty)).NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullable
                            {
                                NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.NullableBoolProperty,
                                NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.NullableIntProperty,
                                NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.NullableGuidProperty,
                                NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.NullableDateTimeProperty,
                                NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.NullableCustomEnumProperty,
                                NullableCustomFlagsEnumProperty = A.Dummy<ModelEqualityPublicSetNullable>().Whose(_ => !_.NullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.NullableCustomFlagsEnumProperty)).NullableCustomFlagsEnumProperty,
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
        static ModelEqualityPublicSetNullableTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}