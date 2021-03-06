// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetReadOnlyListOfNullableChild2Test.cs" company="OBeautifulCode">
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

    public static partial class ModelEqualityPrivateSetReadOnlyListOfNullableChild2Test
    {
        private static readonly ModelEqualityPrivateSetReadOnlyListOfNullableChild2 ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>();

        private static readonly EquatableTestScenarios<ModelEqualityPrivateSetReadOnlyListOfNullableChild2> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelEqualityPrivateSetReadOnlyListOfNullableChild2[]
                    {
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelEqualityPrivateSetReadOnlyListOfNullableChild2[]
                    {
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty)).ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty)).ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty)).ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty)).ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty)).ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)).ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty)).Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty)).Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty)).Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty)).Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty)).Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                        new ModelEqualityPrivateSetReadOnlyListOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)).Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                        A.Dummy<ModelEqualityPrivateSetReadOnlyListOfNullableChild1>(),
                    },
                });

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelEqualityPrivateSetReadOnlyListOfNullableChild2Test()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}