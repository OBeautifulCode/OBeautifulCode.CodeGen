// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetReadOnlyListOfNullableChild1Test.cs" company="OBeautifulCode">
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

    public static partial class ModelEqualityPrivateSetReadOnlyListOfNullableChild1Test
    {
        private static readonly ModelEqualityPrivateSetReadOnlyListOfNullableChild1 ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>();

        private static readonly EquatableTestScenarios<ModelEqualityPrivateSetReadOnlyListOfNullableChild1> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelEqualityPrivateSetReadOnlyListOfNullableChild1[]
                    {
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelEqualityPrivateSetReadOnlyListOfNullableChild1[]
                    {
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty)).ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty)).ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty)).ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty)).ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty)).ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)).ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.Child1ReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty)).Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.Child1ReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty)).Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.Child1ReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty)).Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty)).Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty)).Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>().Whose(_ => !_.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)).Child1ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                        A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>(),
                    },
                });

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelEqualityPrivateSetReadOnlyListOfNullableChild1Test()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}