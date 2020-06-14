// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetReadOnlyListOfNullableTest.cs" company="OBeautifulCode">
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

    public static partial class ModelEqualityPrivateSetReadOnlyListOfNullableTest
    {
        private static readonly ModelEqualityPrivateSetReadOnlyListOfNullable ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullable>();

        private static readonly EquatableTestScenarios<ModelEqualityPrivateSetReadOnlyListOfNullable> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelEqualityPrivateSetReadOnlyListOfNullable>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelEqualityPrivateSetReadOnlyListOfNullable>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelEqualityPrivateSetReadOnlyListOfNullable[]
                    {
                        new ModelEqualityPrivateSetReadOnlyListOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelEqualityPrivateSetReadOnlyListOfNullable[]
                    {
                        new ModelEqualityPrivateSetReadOnlyListOfNullable(
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty)).ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty)).ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty)).ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty)).ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty)).ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullable(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullable>().Whose(_ => !_.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)).ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
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
        static ModelEqualityPrivateSetReadOnlyListOfNullableTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}