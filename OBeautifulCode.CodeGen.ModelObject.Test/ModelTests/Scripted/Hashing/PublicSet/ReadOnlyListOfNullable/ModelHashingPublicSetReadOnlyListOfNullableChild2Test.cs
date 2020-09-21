// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPublicSetReadOnlyListOfNullableChild2Test.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPublicSetReadOnlyListOfNullableChild2Test
    {
        private static readonly ModelHashingPublicSetReadOnlyListOfNullableChild2 ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>();

        private static readonly EquatableTestScenarios<ModelHashingPublicSetReadOnlyListOfNullableChild2> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPublicSetReadOnlyListOfNullableChild2>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPublicSetReadOnlyListOfNullableChild2>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPublicSetReadOnlyListOfNullableChild2[]
                    {
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPublicSetReadOnlyListOfNullableChild2[]
                    {
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty)).ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty)).ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty)).ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty)).ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty)).ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)).ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty)).Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty)).Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty)).Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty)).Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty)).Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelHashingPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)).Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                        A.Dummy<ModelHashingPublicSetReadOnlyListOfNullableChild1>(),
                    },
                });

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelHashingPublicSetReadOnlyListOfNullableChild2Test()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}