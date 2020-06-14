// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetReadOnlyDictionaryChild1Test.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPrivateSetReadOnlyDictionaryChild1Test
    {
        private static readonly ModelHashingPrivateSetReadOnlyDictionaryChild1 ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>();

        private static readonly EquatableTestScenarios<ModelHashingPrivateSetReadOnlyDictionaryChild1> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPrivateSetReadOnlyDictionaryChild1>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPrivateSetReadOnlyDictionaryChild1>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPrivateSetReadOnlyDictionaryChild1[]
                    {
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPrivateSetReadOnlyDictionaryChild1[]
                    {
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.ParentReadOnlyDictionaryInterfaceOfBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty)).ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.ParentReadOnlyDictionaryInterfaceOfIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty)).ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.ParentReadOnlyDictionaryInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty)).ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.ParentReadOnlyDictionaryInterfaceOfGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty)).ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty)).ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty)).ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty)).ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.Child1ReadOnlyDictionaryInterfaceOfBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty)).Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.Child1ReadOnlyDictionaryInterfaceOfIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty)).Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.Child1ReadOnlyDictionaryInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty)).Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.Child1ReadOnlyDictionaryInterfaceOfGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty)).Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty)).Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty)).Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionaryChild1(
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild1>().Whose(_ => !_.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty)).Child1ReadOnlyDictionaryInterfaceOfCustomClassProperty),
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                        A.Dummy<ModelHashingPrivateSetReadOnlyDictionaryChild2>(),
                    },
                });

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelHashingPrivateSetReadOnlyDictionaryChild1Test()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}