// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetReadOnlyDictionaryTest.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPrivateSetReadOnlyDictionaryTest
    {
        private static readonly ModelHashingPrivateSetReadOnlyDictionary ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPrivateSetReadOnlyDictionary>();

        private static readonly EquatableTestScenarios<ModelHashingPrivateSetReadOnlyDictionary> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPrivateSetReadOnlyDictionary>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPrivateSetReadOnlyDictionary>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPrivateSetReadOnlyDictionary[]
                    {
                        new ModelHashingPrivateSetReadOnlyDictionary(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPrivateSetReadOnlyDictionary[]
                    {
                        new ModelHashingPrivateSetReadOnlyDictionary(
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionary>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfBoolProperty)).ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionary(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfBoolProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionary>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfIntProperty)).ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionary(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfIntProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionary>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfStringProperty)).ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionary(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfStringProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionary>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfGuidProperty)).ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionary(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfGuidProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionary>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomEnumProperty)).ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionary(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionary>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty)).ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionary(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionary>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomClassProperty)).ReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyDictionary(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomClassProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyDictionary>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty)).ReadOnlyDictionaryInterfaceOfCustomBaseClassProperty),
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
        static ModelHashingPrivateSetReadOnlyDictionaryTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}