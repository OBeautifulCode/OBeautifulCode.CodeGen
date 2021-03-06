// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetReadOnlyDictionaryOfNullableTest.cs" company="OBeautifulCode">
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

    public static partial class ModelEqualityPublicSetReadOnlyDictionaryOfNullableTest
    {
        private static readonly ModelEqualityPublicSetReadOnlyDictionaryOfNullable ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelEqualityPublicSetReadOnlyDictionaryOfNullable>();

        private static readonly EquatableTestScenarios<ModelEqualityPublicSetReadOnlyDictionaryOfNullable> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelEqualityPublicSetReadOnlyDictionaryOfNullable>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelEqualityPublicSetReadOnlyDictionaryOfNullable>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelEqualityPublicSetReadOnlyDictionaryOfNullable[]
                    {
                        new ModelEqualityPublicSetReadOnlyDictionaryOfNullable
                            {
                                ReadOnlyDictionaryInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                ReadOnlyDictionaryInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                ReadOnlyDictionaryInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelEqualityPublicSetReadOnlyDictionaryOfNullable[]
                    {
                        new ModelEqualityPublicSetReadOnlyDictionaryOfNullable
                            {
                                ReadOnlyDictionaryInterfaceOfNullableBoolProperty            = A.Dummy<ModelEqualityPublicSetReadOnlyDictionaryOfNullable>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty)).ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                ReadOnlyDictionaryInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                ReadOnlyDictionaryInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyDictionaryOfNullable
                            {
                                ReadOnlyDictionaryInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                ReadOnlyDictionaryInterfaceOfNullableIntProperty             = A.Dummy<ModelEqualityPublicSetReadOnlyDictionaryOfNullable>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty)).ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                ReadOnlyDictionaryInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyDictionaryOfNullable
                            {
                                ReadOnlyDictionaryInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                ReadOnlyDictionaryInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                ReadOnlyDictionaryInterfaceOfNullableGuidProperty            = A.Dummy<ModelEqualityPublicSetReadOnlyDictionaryOfNullable>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty)).ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyDictionaryOfNullable
                            {
                                ReadOnlyDictionaryInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                ReadOnlyDictionaryInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                ReadOnlyDictionaryInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty      = A.Dummy<ModelEqualityPublicSetReadOnlyDictionaryOfNullable>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty)).ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyDictionaryOfNullable
                            {
                                ReadOnlyDictionaryInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                ReadOnlyDictionaryInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                ReadOnlyDictionaryInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty = A.Dummy<ModelEqualityPublicSetReadOnlyDictionaryOfNullable>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)).ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty,
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
        static ModelEqualityPublicSetReadOnlyDictionaryOfNullableTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}