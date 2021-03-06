// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPublicSetReadOnlyListOfNullableTest.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPublicSetReadOnlyListOfNullableTest
    {
        private static readonly ModelHashingPublicSetReadOnlyListOfNullable ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullable>();

        private static readonly EquatableTestScenarios<ModelHashingPublicSetReadOnlyListOfNullable> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPublicSetReadOnlyListOfNullable>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPublicSetReadOnlyListOfNullable>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPublicSetReadOnlyListOfNullable[]
                    {
                        new ModelHashingPublicSetReadOnlyListOfNullable
                            {
                                ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPublicSetReadOnlyListOfNullable[]
                    {
                        new ModelHashingPublicSetReadOnlyListOfNullable
                            {
                                ReadOnlyListInterfaceOfNullableBoolProperty            = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty)).ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullable
                            {
                                ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReadOnlyListInterfaceOfNullableIntProperty             = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty)).ReadOnlyListInterfaceOfNullableIntProperty,
                                ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullable
                            {
                                ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                ReadOnlyListInterfaceOfNullableGuidProperty            = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty)).ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullable
                            {
                                ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReadOnlyListInterfaceOfNullableDateTimeProperty        = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty)).ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullable
                            {
                                ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReadOnlyListInterfaceOfNullableCustomEnumProperty      = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty)).ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullable
                            {
                                ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)).ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
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
        static ModelHashingPublicSetReadOnlyListOfNullableTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}