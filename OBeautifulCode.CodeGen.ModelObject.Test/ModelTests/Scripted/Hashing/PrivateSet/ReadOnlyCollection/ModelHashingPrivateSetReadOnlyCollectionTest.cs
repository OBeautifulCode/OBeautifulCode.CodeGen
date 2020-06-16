// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetReadOnlyCollectionTest.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPrivateSetReadOnlyCollectionTest
    {
        private static readonly ModelHashingPrivateSetReadOnlyCollection ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPrivateSetReadOnlyCollection>();

        private static readonly EquatableTestScenarios<ModelHashingPrivateSetReadOnlyCollection> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPrivateSetReadOnlyCollection>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPrivateSetReadOnlyCollection>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPrivateSetReadOnlyCollection[]
                    {
                        new ModelHashingPrivateSetReadOnlyCollection(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPrivateSetReadOnlyCollection[]
                    {
                        new ModelHashingPrivateSetReadOnlyCollection(
                                A.Dummy<ModelHashingPrivateSetReadOnlyCollection>().Whose(_ => !_.ReadOnlyCollectionInterfaceOfBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfBoolProperty)).ReadOnlyCollectionInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyCollection(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfBoolProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyCollection>().Whose(_ => !_.ReadOnlyCollectionInterfaceOfIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfIntProperty)).ReadOnlyCollectionInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyCollection(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfIntProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyCollection>().Whose(_ => !_.ReadOnlyCollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfStringProperty)).ReadOnlyCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyCollection(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfStringProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyCollection>().Whose(_ => !_.ReadOnlyCollectionInterfaceOfGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfGuidProperty)).ReadOnlyCollectionInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyCollection(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfGuidProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyCollection>().Whose(_ => !_.ReadOnlyCollectionInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfDateTimeProperty)).ReadOnlyCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyCollection(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfDateTimeProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyCollection>().Whose(_ => !_.ReadOnlyCollectionInterfaceOfCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomEnumProperty)).ReadOnlyCollectionInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyCollection(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomEnumProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyCollection>().Whose(_ => !_.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty)).ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyCollection(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyCollection>().Whose(_ => !_.ReadOnlyCollectionInterfaceOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomClassProperty)).ReadOnlyCollectionInterfaceOfCustomClassProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty),
                        new ModelHashingPrivateSetReadOnlyCollection(
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfBoolProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfIntProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfGuidProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomClassProperty,
                                A.Dummy<ModelHashingPrivateSetReadOnlyCollection>().Whose(_ => !_.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCustomBaseClassProperty)).ReadOnlyCollectionInterfaceOfCustomBaseClassProperty),
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
        static ModelHashingPrivateSetReadOnlyCollectionTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}