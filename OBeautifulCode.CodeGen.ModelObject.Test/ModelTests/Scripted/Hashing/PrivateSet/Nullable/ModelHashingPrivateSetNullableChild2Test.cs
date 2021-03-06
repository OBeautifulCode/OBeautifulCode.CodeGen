// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetNullableChild2Test.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPrivateSetNullableChild2Test
    {
        private static readonly ModelHashingPrivateSetNullableChild2 ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPrivateSetNullableChild2>();

        private static readonly EquatableTestScenarios<ModelHashingPrivateSetNullableChild2> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPrivateSetNullableChild2>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPrivateSetNullableChild2>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPrivateSetNullableChild2[]
                    {
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPrivateSetNullableChild2[]
                    {
                        new ModelHashingPrivateSetNullableChild2(
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.ParentNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty)).ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.ParentNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty)).ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.ParentNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty)).ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.ParentNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty)).ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.ParentNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty)).ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.ParentNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty)).ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.Child2NullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty)).Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.Child2NullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty)).Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.Child2NullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty)).Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.Child2NullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty)).Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.Child2NullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty)).Child2NullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty),
                        new ModelHashingPrivateSetNullableChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2NullableCustomEnumProperty,
                                A.Dummy<ModelHashingPrivateSetNullableChild2>().Whose(_ => !_.Child2NullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2NullableCustomFlagsEnumProperty)).Child2NullableCustomFlagsEnumProperty),
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                        A.Dummy<ModelHashingPrivateSetNullableChild1>(),
                    },
                });

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelHashingPrivateSetNullableChild2Test()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}