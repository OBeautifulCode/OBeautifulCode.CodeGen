// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetArrayTest.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPrivateSetArrayTest
    {
        private static readonly ModelHashingPrivateSetArray ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPrivateSetArray>();

        private static readonly EquatableTestScenarios<ModelHashingPrivateSetArray> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPrivateSetArray>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPrivateSetArray>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPrivateSetArray[]
                    {
                        new ModelHashingPrivateSetArray(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPrivateSetArray[]
                    {
                        new ModelHashingPrivateSetArray(
                                A.Dummy<ModelHashingPrivateSetArray>().Whose(_ => !_.ArrayOfBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty)).ArrayOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty),
                        new ModelHashingPrivateSetArray(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                A.Dummy<ModelHashingPrivateSetArray>().Whose(_ => !_.ArrayOfIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty)).ArrayOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty),
                        new ModelHashingPrivateSetArray(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                A.Dummy<ModelHashingPrivateSetArray>().Whose(_ => !_.ArrayOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty)).ArrayOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty),
                        new ModelHashingPrivateSetArray(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                A.Dummy<ModelHashingPrivateSetArray>().Whose(_ => !_.ArrayOfGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty)).ArrayOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty),
                        new ModelHashingPrivateSetArray(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                A.Dummy<ModelHashingPrivateSetArray>().Whose(_ => !_.ArrayOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty)).ArrayOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty),
                        new ModelHashingPrivateSetArray(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                A.Dummy<ModelHashingPrivateSetArray>().Whose(_ => !_.ArrayOfCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty)).ArrayOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty),
                        new ModelHashingPrivateSetArray(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                A.Dummy<ModelHashingPrivateSetArray>().Whose(_ => !_.ArrayOfCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty)).ArrayOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty),
                        new ModelHashingPrivateSetArray(
                                ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                A.Dummy<ModelHashingPrivateSetArray>().Whose(_ => !_.ArrayOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty)).ArrayOfCustomClassProperty),
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
        static ModelHashingPrivateSetArrayTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}