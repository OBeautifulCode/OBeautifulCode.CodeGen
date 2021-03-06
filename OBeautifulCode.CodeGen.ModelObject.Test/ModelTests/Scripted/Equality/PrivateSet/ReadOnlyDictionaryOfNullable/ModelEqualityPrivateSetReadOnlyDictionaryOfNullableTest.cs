// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetReadOnlyDictionaryOfNullableTest.cs" company="OBeautifulCode">
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

    public static partial class ModelEqualityPrivateSetReadOnlyDictionaryOfNullableTest
    {
        private static readonly ModelEqualityPrivateSetReadOnlyDictionaryOfNullable ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelEqualityPrivateSetReadOnlyDictionaryOfNullable>();

        private static readonly EquatableTestScenarios<ModelEqualityPrivateSetReadOnlyDictionaryOfNullable> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelEqualityPrivateSetReadOnlyDictionaryOfNullable>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelEqualityPrivateSetReadOnlyDictionaryOfNullable>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelEqualityPrivateSetReadOnlyDictionaryOfNullable[]
                    {
                        new ModelEqualityPrivateSetReadOnlyDictionaryOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelEqualityPrivateSetReadOnlyDictionaryOfNullable[]
                    {
                        new ModelEqualityPrivateSetReadOnlyDictionaryOfNullable(
                                A.Dummy<ModelEqualityPrivateSetReadOnlyDictionaryOfNullable>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty)).ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyDictionaryOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyDictionaryOfNullable>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty)).ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyDictionaryOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyDictionaryOfNullable>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty)).ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyDictionaryOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyDictionaryOfNullable>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty)).ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyDictionaryOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyDictionaryOfNullable>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty)).ReadOnlyDictionaryInterfaceOfNullableCustomFlagsEnumProperty),
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
        static ModelEqualityPrivateSetReadOnlyDictionaryOfNullableTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}