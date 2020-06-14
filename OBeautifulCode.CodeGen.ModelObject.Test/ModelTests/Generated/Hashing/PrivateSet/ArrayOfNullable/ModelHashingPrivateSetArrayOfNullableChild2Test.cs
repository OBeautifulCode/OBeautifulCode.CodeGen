// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetArrayOfNullableChild2Test.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPrivateSetArrayOfNullableChild2Test
    {
        private static readonly ModelHashingPrivateSetArrayOfNullableChild2 ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>();

        private static readonly EquatableTestScenarios<ModelHashingPrivateSetArrayOfNullableChild2> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPrivateSetArrayOfNullableChild2>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPrivateSetArrayOfNullableChild2>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPrivateSetArrayOfNullableChild2[]
                    {
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPrivateSetArrayOfNullableChild2[]
                    {
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.ParentArrayOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty)).ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.ParentArrayOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty)).ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.ParentArrayOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty)).ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.ParentArrayOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty)).ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.ParentArrayOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty)).ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.ParentArrayOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty)).ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.Child2ArrayOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty)).Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.Child2ArrayOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty)).Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.Child2ArrayOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty)).Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.Child2ArrayOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty)).Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.Child2ArrayOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty)).Child2ArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetArrayOfNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentArrayOfNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomEnumProperty,
                                A.Dummy<ModelHashingPrivateSetArrayOfNullableChild2>().Whose(_ => !_.Child2ArrayOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ArrayOfNullableCustomFlagsEnumProperty)).Child2ArrayOfNullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                        A.Dummy<ModelHashingPrivateSetArrayOfNullableChild1>(),
                    },
                });

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelHashingPrivateSetArrayOfNullableChild2Test()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}