// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetNullableChild1Test.cs" company="OBeautifulCode">
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

    public static partial class ModelEqualityPublicSetNullableChild1Test
    {
        private static readonly ModelEqualityPublicSetNullableChild1 ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelEqualityPublicSetNullableChild1>();

        private static readonly EquatableTestScenarios<ModelEqualityPublicSetNullableChild1> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelEqualityPublicSetNullableChild1>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelEqualityPublicSetNullableChild1>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelEqualityPublicSetNullableChild1[]
                    {
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelEqualityPublicSetNullableChild1[]
                    {
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.ParentNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty)).ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.ParentNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty)).ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.ParentNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty)).ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.ParentNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty)).ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.ParentNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty)).ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.ParentNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty)).ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.Child1NullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty)).Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.Child1NullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty)).Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.Child1NullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty)).Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.Child1NullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty)).Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.Child1NullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty)).Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetNullableChild1
                            {
                                ParentNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableBoolProperty,
                                ParentNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentNullableIntProperty,
                                ParentNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentNullableGuidProperty,
                                ParentNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentNullableDateTimeProperty,
                                ParentNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomEnumProperty,
                                ParentNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentNullableCustomFlagsEnumProperty,
                                Child1NullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableBoolProperty,
                                Child1NullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child1NullableIntProperty,
                                Child1NullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child1NullableGuidProperty,
                                Child1NullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child1NullableDateTimeProperty,
                                Child1NullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child1NullableCustomEnumProperty,
                                Child1NullableCustomFlagsEnumProperty = A.Dummy<ModelEqualityPublicSetNullableChild1>().Whose(_ => !_.Child1NullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1NullableCustomFlagsEnumProperty)).Child1NullableCustomFlagsEnumProperty,
                            },
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                        A.Dummy<ModelEqualityPublicSetNullableChild2>(),
                    },
                });

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelEqualityPublicSetNullableChild1Test()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}