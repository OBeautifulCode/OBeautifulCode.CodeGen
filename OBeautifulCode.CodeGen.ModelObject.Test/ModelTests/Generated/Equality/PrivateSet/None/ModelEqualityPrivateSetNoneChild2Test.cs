// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetNoneChild2Test.cs" company="OBeautifulCode">
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

    public static partial class ModelEqualityPrivateSetNoneChild2Test
    {
        private static readonly ModelEqualityPrivateSetNoneChild2 ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelEqualityPrivateSetNoneChild2>();

        private static readonly EquatableTestScenarios<ModelEqualityPrivateSetNoneChild2> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelEqualityPrivateSetNoneChild2>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelEqualityPrivateSetNoneChild2>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelEqualityPrivateSetNoneChild2[]
                    {
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelEqualityPrivateSetNoneChild2[]
                    {
                        new ModelEqualityPrivateSetNoneChild2(
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.ParentBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentBoolProperty)).ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.ParentIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentIntProperty)).ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.ParentStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentStringProperty)).ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.ParentGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentGuidProperty)).ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.ParentDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty)).ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.ParentCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty)).ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.ParentCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty)).ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.ParentCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty)).ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.Child2BoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2BoolProperty)).Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.Child2IntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2IntProperty)).Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.Child2StringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2StringProperty)).Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.Child2GuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2GuidProperty)).Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.Child2DateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty)).Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.Child2CustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty)).Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.Child2CustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty)).Child2CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty),
                        new ModelEqualityPrivateSetNoneChild2(
                                ReferenceObjectForEquatableTestScenarios.ParentBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2IntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2StringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child2CustomFlagsEnumProperty,
                                A.Dummy<ModelEqualityPrivateSetNoneChild2>().Whose(_ => !_.Child2CustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2CustomClassProperty)).Child2CustomClassProperty),
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                        A.Dummy<ModelEqualityPrivateSetNoneChild1>(),
                    },
                });

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelEqualityPrivateSetNoneChild2Test()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}