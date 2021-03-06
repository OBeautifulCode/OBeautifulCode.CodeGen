// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetReadOnlyListOfNullableChild2Test.cs" company="OBeautifulCode">
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

    public static partial class ModelEqualityPublicSetReadOnlyListOfNullableChild2Test
    {
        private static readonly ModelEqualityPublicSetReadOnlyListOfNullableChild2 ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>();

        private static readonly EquatableTestScenarios<ModelEqualityPublicSetReadOnlyListOfNullableChild2> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelEqualityPublicSetReadOnlyListOfNullableChild2>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelEqualityPublicSetReadOnlyListOfNullableChild2>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelEqualityPublicSetReadOnlyListOfNullableChild2[]
                    {
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
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
                    ObjectsThatAreNotEqualToReferenceObject = new ModelEqualityPublicSetReadOnlyListOfNullableChild2[]
                    {
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty)).ParentReadOnlyListInterfaceOfNullableBoolProperty,
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
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty)).ParentReadOnlyListInterfaceOfNullableIntProperty,
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
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty)).ParentReadOnlyListInterfaceOfNullableGuidProperty,
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
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty)).ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty)).ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)).ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty)).Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty)).Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
                            {
                                ParentReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableBoolProperty,
                                ParentReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableIntProperty,
                                ParentReadOnlyListInterfaceOfNullableGuidProperty            = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableGuidProperty,
                                ParentReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableDateTimeProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableBoolProperty            = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableBoolProperty,
                                Child2ReadOnlyListInterfaceOfNullableIntProperty             = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableIntProperty,
                                Child2ReadOnlyListInterfaceOfNullableGuidProperty            = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableGuidProperty)).Child2ReadOnlyListInterfaceOfNullableGuidProperty,
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
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
                                Child2ReadOnlyListInterfaceOfNullableDateTimeProperty        = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableDateTimeProperty)).Child2ReadOnlyListInterfaceOfNullableDateTimeProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
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
                                Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty      = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty)).Child2ReadOnlyListInterfaceOfNullableCustomEnumProperty,
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                        new ModelEqualityPublicSetReadOnlyListOfNullableChild2
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
                                Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty = A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild2>().Whose(_ => !_.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty)).Child2ReadOnlyListInterfaceOfNullableCustomFlagsEnumProperty,
                            },
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                        A.Dummy<ModelEqualityPublicSetReadOnlyListOfNullableChild1>(),
                    },
                });

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelEqualityPublicSetReadOnlyListOfNullableChild2Test()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}