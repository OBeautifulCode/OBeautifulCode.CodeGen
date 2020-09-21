// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPublicSetReadOnlyListTest.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPublicSetReadOnlyListTest
    {
        private static readonly ModelHashingPublicSetReadOnlyList ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPublicSetReadOnlyList>();

        private static readonly EquatableTestScenarios<ModelHashingPublicSetReadOnlyList> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPublicSetReadOnlyList>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPublicSetReadOnlyList>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPublicSetReadOnlyList[]
                    {
                        new ModelHashingPublicSetReadOnlyList
                            {
                                ReadOnlyListInterfaceOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfBoolProperty,
                                ReadOnlyListInterfaceOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfIntProperty,
                                ReadOnlyListInterfaceOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfStringProperty,
                                ReadOnlyListInterfaceOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfGuidProperty,
                                ReadOnlyListInterfaceOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomEnumProperty,
                                ReadOnlyListInterfaceOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
                                ReadOnlyListInterfaceOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomClassProperty,
                                ReadOnlyListInterfaceOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomBaseClassProperty,
                                ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
                            },
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPublicSetReadOnlyList[]
                    {
                        new ModelHashingPublicSetReadOnlyList
                            {
                                ReadOnlyListInterfaceOfBoolProperty                            = A.Dummy<ModelHashingPublicSetReadOnlyList>().Whose(_ => !_.ReadOnlyListInterfaceOfBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfBoolProperty)).ReadOnlyListInterfaceOfBoolProperty,
                                ReadOnlyListInterfaceOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfIntProperty,
                                ReadOnlyListInterfaceOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfStringProperty,
                                ReadOnlyListInterfaceOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfGuidProperty,
                                ReadOnlyListInterfaceOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomEnumProperty,
                                ReadOnlyListInterfaceOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
                                ReadOnlyListInterfaceOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomClassProperty,
                                ReadOnlyListInterfaceOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomBaseClassProperty,
                                ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelHashingPublicSetReadOnlyList
                            {
                                ReadOnlyListInterfaceOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfBoolProperty,
                                ReadOnlyListInterfaceOfIntProperty                             = A.Dummy<ModelHashingPublicSetReadOnlyList>().Whose(_ => !_.ReadOnlyListInterfaceOfIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfIntProperty)).ReadOnlyListInterfaceOfIntProperty,
                                ReadOnlyListInterfaceOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfStringProperty,
                                ReadOnlyListInterfaceOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfGuidProperty,
                                ReadOnlyListInterfaceOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomEnumProperty,
                                ReadOnlyListInterfaceOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
                                ReadOnlyListInterfaceOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomClassProperty,
                                ReadOnlyListInterfaceOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomBaseClassProperty,
                                ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelHashingPublicSetReadOnlyList
                            {
                                ReadOnlyListInterfaceOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfBoolProperty,
                                ReadOnlyListInterfaceOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfIntProperty,
                                ReadOnlyListInterfaceOfStringProperty                          = A.Dummy<ModelHashingPublicSetReadOnlyList>().Whose(_ => !_.ReadOnlyListInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfStringProperty)).ReadOnlyListInterfaceOfStringProperty,
                                ReadOnlyListInterfaceOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfGuidProperty,
                                ReadOnlyListInterfaceOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomEnumProperty,
                                ReadOnlyListInterfaceOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
                                ReadOnlyListInterfaceOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomClassProperty,
                                ReadOnlyListInterfaceOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomBaseClassProperty,
                                ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelHashingPublicSetReadOnlyList
                            {
                                ReadOnlyListInterfaceOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfBoolProperty,
                                ReadOnlyListInterfaceOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfIntProperty,
                                ReadOnlyListInterfaceOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfStringProperty,
                                ReadOnlyListInterfaceOfGuidProperty                            = A.Dummy<ModelHashingPublicSetReadOnlyList>().Whose(_ => !_.ReadOnlyListInterfaceOfGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfGuidProperty)).ReadOnlyListInterfaceOfGuidProperty,
                                ReadOnlyListInterfaceOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomEnumProperty,
                                ReadOnlyListInterfaceOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
                                ReadOnlyListInterfaceOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomClassProperty,
                                ReadOnlyListInterfaceOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomBaseClassProperty,
                                ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelHashingPublicSetReadOnlyList
                            {
                                ReadOnlyListInterfaceOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfBoolProperty,
                                ReadOnlyListInterfaceOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfIntProperty,
                                ReadOnlyListInterfaceOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfStringProperty,
                                ReadOnlyListInterfaceOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfGuidProperty,
                                ReadOnlyListInterfaceOfDateTimeProperty                        = A.Dummy<ModelHashingPublicSetReadOnlyList>().Whose(_ => !_.ReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfDateTimeProperty)).ReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomEnumProperty,
                                ReadOnlyListInterfaceOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
                                ReadOnlyListInterfaceOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomClassProperty,
                                ReadOnlyListInterfaceOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomBaseClassProperty,
                                ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelHashingPublicSetReadOnlyList
                            {
                                ReadOnlyListInterfaceOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfBoolProperty,
                                ReadOnlyListInterfaceOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfIntProperty,
                                ReadOnlyListInterfaceOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfStringProperty,
                                ReadOnlyListInterfaceOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfGuidProperty,
                                ReadOnlyListInterfaceOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfCustomEnumProperty                      = A.Dummy<ModelHashingPublicSetReadOnlyList>().Whose(_ => !_.ReadOnlyListInterfaceOfCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomEnumProperty)).ReadOnlyListInterfaceOfCustomEnumProperty,
                                ReadOnlyListInterfaceOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
                                ReadOnlyListInterfaceOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomClassProperty,
                                ReadOnlyListInterfaceOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomBaseClassProperty,
                                ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelHashingPublicSetReadOnlyList
                            {
                                ReadOnlyListInterfaceOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfBoolProperty,
                                ReadOnlyListInterfaceOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfIntProperty,
                                ReadOnlyListInterfaceOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfStringProperty,
                                ReadOnlyListInterfaceOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfGuidProperty,
                                ReadOnlyListInterfaceOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomEnumProperty,
                                ReadOnlyListInterfaceOfCustomFlagsEnumProperty                 = A.Dummy<ModelHashingPublicSetReadOnlyList>().Whose(_ => !_.ReadOnlyListInterfaceOfCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomFlagsEnumProperty)).ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
                                ReadOnlyListInterfaceOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomClassProperty,
                                ReadOnlyListInterfaceOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomBaseClassProperty,
                                ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelHashingPublicSetReadOnlyList
                            {
                                ReadOnlyListInterfaceOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfBoolProperty,
                                ReadOnlyListInterfaceOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfIntProperty,
                                ReadOnlyListInterfaceOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfStringProperty,
                                ReadOnlyListInterfaceOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfGuidProperty,
                                ReadOnlyListInterfaceOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomEnumProperty,
                                ReadOnlyListInterfaceOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
                                ReadOnlyListInterfaceOfCustomClassProperty                     = A.Dummy<ModelHashingPublicSetReadOnlyList>().Whose(_ => !_.ReadOnlyListInterfaceOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomClassProperty)).ReadOnlyListInterfaceOfCustomClassProperty,
                                ReadOnlyListInterfaceOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomBaseClassProperty,
                                ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelHashingPublicSetReadOnlyList
                            {
                                ReadOnlyListInterfaceOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfBoolProperty,
                                ReadOnlyListInterfaceOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfIntProperty,
                                ReadOnlyListInterfaceOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfStringProperty,
                                ReadOnlyListInterfaceOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfGuidProperty,
                                ReadOnlyListInterfaceOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomEnumProperty,
                                ReadOnlyListInterfaceOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
                                ReadOnlyListInterfaceOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomClassProperty,
                                ReadOnlyListInterfaceOfCustomBaseClassProperty                 = A.Dummy<ModelHashingPublicSetReadOnlyList>().Whose(_ => !_.ReadOnlyListInterfaceOfCustomBaseClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomBaseClassProperty)).ReadOnlyListInterfaceOfCustomBaseClassProperty,
                                ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelHashingPublicSetReadOnlyList
                            {
                                ReadOnlyListInterfaceOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfBoolProperty,
                                ReadOnlyListInterfaceOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfIntProperty,
                                ReadOnlyListInterfaceOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfStringProperty,
                                ReadOnlyListInterfaceOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfGuidProperty,
                                ReadOnlyListInterfaceOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomEnumProperty,
                                ReadOnlyListInterfaceOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomFlagsEnumProperty,
                                ReadOnlyListInterfaceOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomClassProperty,
                                ReadOnlyListInterfaceOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomBaseClassProperty,
                                ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty = A.Dummy<ModelHashingPublicSetReadOnlyList>().Whose(_ => !_.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty)).ReadOnlyListInterfaceOfCustomGenericClassOfCustomClassProperty,
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
        static ModelHashingPublicSetReadOnlyListTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}