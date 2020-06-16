// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetNoneTest.cs" company="OBeautifulCode">
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

    public static partial class ModelEqualityPublicSetNoneTest
    {
        private static readonly ModelEqualityPublicSetNone ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelEqualityPublicSetNone>();

        private static readonly EquatableTestScenarios<ModelEqualityPublicSetNone> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelEqualityPublicSetNone>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelEqualityPublicSetNone>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelEqualityPublicSetNone[]
                    {
                        new ModelEqualityPublicSetNone
                            {
                                BoolProperty            = ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                IntProperty             = ReferenceObjectForEquatableTestScenarios.IntProperty,
                                StringProperty          = ReferenceObjectForEquatableTestScenarios.StringProperty,
                                GuidProperty            = ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                DateTimeProperty        = ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                CustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                CustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                CustomClassProperty     = ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                CustomBaseClassProperty = ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                            },
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelEqualityPublicSetNone[]
                    {
                        new ModelEqualityPublicSetNone
                            {
                                BoolProperty            = A.Dummy<ModelEqualityPublicSetNone>().Whose(_ => !_.BoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.BoolProperty)).BoolProperty,
                                IntProperty             = ReferenceObjectForEquatableTestScenarios.IntProperty,
                                StringProperty          = ReferenceObjectForEquatableTestScenarios.StringProperty,
                                GuidProperty            = ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                DateTimeProperty        = ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                CustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                CustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                CustomClassProperty     = ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                CustomBaseClassProperty = ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                            },
                        new ModelEqualityPublicSetNone
                            {
                                BoolProperty            = ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                IntProperty             = A.Dummy<ModelEqualityPublicSetNone>().Whose(_ => !_.IntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.IntProperty)).IntProperty,
                                StringProperty          = ReferenceObjectForEquatableTestScenarios.StringProperty,
                                GuidProperty            = ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                DateTimeProperty        = ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                CustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                CustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                CustomClassProperty     = ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                CustomBaseClassProperty = ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                            },
                        new ModelEqualityPublicSetNone
                            {
                                BoolProperty            = ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                IntProperty             = ReferenceObjectForEquatableTestScenarios.IntProperty,
                                StringProperty          = A.Dummy<ModelEqualityPublicSetNone>().Whose(_ => !_.StringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.StringProperty)).StringProperty,
                                GuidProperty            = ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                DateTimeProperty        = ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                CustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                CustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                CustomClassProperty     = ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                CustomBaseClassProperty = ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                            },
                        new ModelEqualityPublicSetNone
                            {
                                BoolProperty            = ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                IntProperty             = ReferenceObjectForEquatableTestScenarios.IntProperty,
                                StringProperty          = ReferenceObjectForEquatableTestScenarios.StringProperty,
                                GuidProperty            = A.Dummy<ModelEqualityPublicSetNone>().Whose(_ => !_.GuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.GuidProperty)).GuidProperty,
                                DateTimeProperty        = ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                CustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                CustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                CustomClassProperty     = ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                CustomBaseClassProperty = ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                            },
                        new ModelEqualityPublicSetNone
                            {
                                BoolProperty            = ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                IntProperty             = ReferenceObjectForEquatableTestScenarios.IntProperty,
                                StringProperty          = ReferenceObjectForEquatableTestScenarios.StringProperty,
                                GuidProperty            = ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                DateTimeProperty        = A.Dummy<ModelEqualityPublicSetNone>().Whose(_ => !_.DateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.DateTimeProperty)).DateTimeProperty,
                                CustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                CustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                CustomClassProperty     = ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                CustomBaseClassProperty = ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                            },
                        new ModelEqualityPublicSetNone
                            {
                                BoolProperty            = ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                IntProperty             = ReferenceObjectForEquatableTestScenarios.IntProperty,
                                StringProperty          = ReferenceObjectForEquatableTestScenarios.StringProperty,
                                GuidProperty            = ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                DateTimeProperty        = ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                CustomEnumProperty      = A.Dummy<ModelEqualityPublicSetNone>().Whose(_ => !_.CustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CustomEnumProperty)).CustomEnumProperty,
                                CustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                CustomClassProperty     = ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                CustomBaseClassProperty = ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                            },
                        new ModelEqualityPublicSetNone
                            {
                                BoolProperty            = ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                IntProperty             = ReferenceObjectForEquatableTestScenarios.IntProperty,
                                StringProperty          = ReferenceObjectForEquatableTestScenarios.StringProperty,
                                GuidProperty            = ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                DateTimeProperty        = ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                CustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                CustomFlagsEnumProperty = A.Dummy<ModelEqualityPublicSetNone>().Whose(_ => !_.CustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty)).CustomFlagsEnumProperty,
                                CustomClassProperty     = ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                CustomBaseClassProperty = ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                            },
                        new ModelEqualityPublicSetNone
                            {
                                BoolProperty            = ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                IntProperty             = ReferenceObjectForEquatableTestScenarios.IntProperty,
                                StringProperty          = ReferenceObjectForEquatableTestScenarios.StringProperty,
                                GuidProperty            = ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                DateTimeProperty        = ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                CustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                CustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                CustomClassProperty     = A.Dummy<ModelEqualityPublicSetNone>().Whose(_ => !_.CustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CustomClassProperty)).CustomClassProperty,
                                CustomBaseClassProperty = ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty,
                            },
                        new ModelEqualityPublicSetNone
                            {
                                BoolProperty            = ReferenceObjectForEquatableTestScenarios.BoolProperty,
                                IntProperty             = ReferenceObjectForEquatableTestScenarios.IntProperty,
                                StringProperty          = ReferenceObjectForEquatableTestScenarios.StringProperty,
                                GuidProperty            = ReferenceObjectForEquatableTestScenarios.GuidProperty,
                                DateTimeProperty        = ReferenceObjectForEquatableTestScenarios.DateTimeProperty,
                                CustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.CustomEnumProperty,
                                CustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.CustomFlagsEnumProperty,
                                CustomClassProperty     = ReferenceObjectForEquatableTestScenarios.CustomClassProperty,
                                CustomBaseClassProperty = A.Dummy<ModelEqualityPublicSetNone>().Whose(_ => !_.CustomBaseClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CustomBaseClassProperty)).CustomBaseClassProperty,
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
        static ModelEqualityPublicSetNoneTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}