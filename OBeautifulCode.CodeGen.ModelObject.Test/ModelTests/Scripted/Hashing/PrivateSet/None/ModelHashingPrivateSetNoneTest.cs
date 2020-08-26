// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetNoneTest.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPrivateSetNoneTest
    {
        private static readonly ModelHashingPrivateSetNone ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPrivateSetNone>();

        private static readonly EquatableTestScenarios<ModelHashingPrivateSetNone> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPrivateSetNone>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPrivateSetNone>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPrivateSetNone[]
                    {
                        new ModelHashingPrivateSetNone(
                                ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.IntProperty,
                                ReferenceObjectForEquatableTestScenarios.StringProperty,
                                ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomGenericClassOfCustomClassProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPrivateSetNone[]
                    {
                        new ModelHashingPrivateSetNone(
                                A.Dummy<ModelHashingPrivateSetNone>().Whose(_ => !_.BoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.BoolProperty)).BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.IntProperty,
                                ReferenceObjectForEquatableTestScenarios.StringProperty,
                                ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomGenericClassOfCustomClassProperty),
                        new ModelHashingPrivateSetNone(
                                ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                A.Dummy<ModelHashingPrivateSetNone>().Whose(_ => !_.IntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.IntProperty)).IntProperty,
                                ReferenceObjectForEquatableTestScenarios.StringProperty,
                                ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomGenericClassOfCustomClassProperty),
                        new ModelHashingPrivateSetNone(
                                ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.IntProperty,
                                A.Dummy<ModelHashingPrivateSetNone>().Whose(_ => !_.StringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.StringProperty)).StringProperty,
                                ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomGenericClassOfCustomClassProperty),
                        new ModelHashingPrivateSetNone(
                                ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.IntProperty,
                                ReferenceObjectForEquatableTestScenarios.StringProperty,
                                A.Dummy<ModelHashingPrivateSetNone>().Whose(_ => !_.GuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.GuidProperty)).GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomGenericClassOfCustomClassProperty),
                        new ModelHashingPrivateSetNone(
                                ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.IntProperty,
                                ReferenceObjectForEquatableTestScenarios.StringProperty,
                                ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                A.Dummy<ModelHashingPrivateSetNone>().Whose(_ => !_.DateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.DateTimeProperty)).DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomGenericClassOfCustomClassProperty),
                        new ModelHashingPrivateSetNone(
                                ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.IntProperty,
                                ReferenceObjectForEquatableTestScenarios.StringProperty,
                                ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                A.Dummy<ModelHashingPrivateSetNone>().Whose(_ => !_.CustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CustomEnumProperty)).CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomGenericClassOfCustomClassProperty),
                        new ModelHashingPrivateSetNone(
                                ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.IntProperty,
                                ReferenceObjectForEquatableTestScenarios.StringProperty,
                                ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                A.Dummy<ModelHashingPrivateSetNone>().Whose(_ => !_.CustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty)).CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomGenericClassOfCustomClassProperty),
                        new ModelHashingPrivateSetNone(
                                ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.IntProperty,
                                ReferenceObjectForEquatableTestScenarios.StringProperty,
                                ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                A.Dummy<ModelHashingPrivateSetNone>().Whose(_ => !_.CustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CustomClassProperty)).CustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomGenericClassOfCustomClassProperty),
                        new ModelHashingPrivateSetNone(
                                ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.IntProperty,
                                ReferenceObjectForEquatableTestScenarios.StringProperty,
                                ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                A.Dummy<ModelHashingPrivateSetNone>().Whose(_ => !_.CustomBaseClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty)).CustomBaseClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomGenericClassOfCustomClassProperty),
                        new ModelHashingPrivateSetNone(
                                ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                ReferenceObjectForEquatableTestScenarios.IntProperty,
                                ReferenceObjectForEquatableTestScenarios.StringProperty,
                                ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                                A.Dummy<ModelHashingPrivateSetNone>().Whose(_ => !_.CustomGenericClassOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CustomGenericClassOfCustomClassProperty)).CustomGenericClassOfCustomClassProperty),
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
        static ModelHashingPrivateSetNoneTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}