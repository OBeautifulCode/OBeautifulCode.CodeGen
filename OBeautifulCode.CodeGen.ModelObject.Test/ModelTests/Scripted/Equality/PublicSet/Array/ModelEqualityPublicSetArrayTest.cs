// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetArrayTest.cs" company="OBeautifulCode">
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

    public static partial class ModelEqualityPublicSetArrayTest
    {
        private static readonly ModelEqualityPublicSetArray ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelEqualityPublicSetArray>();

        private static readonly EquatableTestScenarios<ModelEqualityPublicSetArray> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelEqualityPublicSetArray>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelEqualityPublicSetArray>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelEqualityPublicSetArray[]
                    {
                        new ModelEqualityPublicSetArray
                            {
                                ArrayOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ArrayOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ArrayOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ArrayOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ArrayOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ArrayOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ArrayOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ArrayOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty,
                                ArrayOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomBaseClassProperty,
                                ArrayOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomGenericClassOfCustomClassProperty,
                            },
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelEqualityPublicSetArray[]
                    {
                        new ModelEqualityPublicSetArray
                            {
                                ArrayOfBoolProperty                            = A.Dummy<ModelEqualityPublicSetArray>().Whose(_ => !_.ArrayOfBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty)).ArrayOfBoolProperty,
                                ArrayOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ArrayOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ArrayOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ArrayOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ArrayOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ArrayOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ArrayOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty,
                                ArrayOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomBaseClassProperty,
                                ArrayOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelEqualityPublicSetArray
                            {
                                ArrayOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ArrayOfIntProperty                             = A.Dummy<ModelEqualityPublicSetArray>().Whose(_ => !_.ArrayOfIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty)).ArrayOfIntProperty,
                                ArrayOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ArrayOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ArrayOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ArrayOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ArrayOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ArrayOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty,
                                ArrayOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomBaseClassProperty,
                                ArrayOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelEqualityPublicSetArray
                            {
                                ArrayOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ArrayOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ArrayOfStringProperty                          = A.Dummy<ModelEqualityPublicSetArray>().Whose(_ => !_.ArrayOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty)).ArrayOfStringProperty,
                                ArrayOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ArrayOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ArrayOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ArrayOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ArrayOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty,
                                ArrayOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomBaseClassProperty,
                                ArrayOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelEqualityPublicSetArray
                            {
                                ArrayOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ArrayOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ArrayOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ArrayOfGuidProperty                            = A.Dummy<ModelEqualityPublicSetArray>().Whose(_ => !_.ArrayOfGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty)).ArrayOfGuidProperty,
                                ArrayOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ArrayOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ArrayOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ArrayOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty,
                                ArrayOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomBaseClassProperty,
                                ArrayOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelEqualityPublicSetArray
                            {
                                ArrayOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ArrayOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ArrayOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ArrayOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ArrayOfDateTimeProperty                        = A.Dummy<ModelEqualityPublicSetArray>().Whose(_ => !_.ArrayOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty)).ArrayOfDateTimeProperty,
                                ArrayOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ArrayOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ArrayOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty,
                                ArrayOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomBaseClassProperty,
                                ArrayOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelEqualityPublicSetArray
                            {
                                ArrayOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ArrayOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ArrayOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ArrayOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ArrayOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ArrayOfCustomEnumProperty                      = A.Dummy<ModelEqualityPublicSetArray>().Whose(_ => !_.ArrayOfCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty)).ArrayOfCustomEnumProperty,
                                ArrayOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ArrayOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty,
                                ArrayOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomBaseClassProperty,
                                ArrayOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelEqualityPublicSetArray
                            {
                                ArrayOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ArrayOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ArrayOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ArrayOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ArrayOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ArrayOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ArrayOfCustomFlagsEnumProperty                 = A.Dummy<ModelEqualityPublicSetArray>().Whose(_ => !_.ArrayOfCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty)).ArrayOfCustomFlagsEnumProperty,
                                ArrayOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty,
                                ArrayOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomBaseClassProperty,
                                ArrayOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelEqualityPublicSetArray
                            {
                                ArrayOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ArrayOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ArrayOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ArrayOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ArrayOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ArrayOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ArrayOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ArrayOfCustomClassProperty                     = A.Dummy<ModelEqualityPublicSetArray>().Whose(_ => !_.ArrayOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty)).ArrayOfCustomClassProperty,
                                ArrayOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomBaseClassProperty,
                                ArrayOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelEqualityPublicSetArray
                            {
                                ArrayOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ArrayOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ArrayOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ArrayOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ArrayOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ArrayOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ArrayOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ArrayOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty,
                                ArrayOfCustomBaseClassProperty                 = A.Dummy<ModelEqualityPublicSetArray>().Whose(_ => !_.ArrayOfCustomBaseClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfCustomBaseClassProperty)).ArrayOfCustomBaseClassProperty,
                                ArrayOfCustomGenericClassOfCustomClassProperty = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomGenericClassOfCustomClassProperty,
                            },
                        new ModelEqualityPublicSetArray
                            {
                                ArrayOfBoolProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfBoolProperty,
                                ArrayOfIntProperty                             = ReferenceObjectForEquatableTestScenarios.ArrayOfIntProperty,
                                ArrayOfStringProperty                          = ReferenceObjectForEquatableTestScenarios.ArrayOfStringProperty,
                                ArrayOfGuidProperty                            = ReferenceObjectForEquatableTestScenarios.ArrayOfGuidProperty,
                                ArrayOfDateTimeProperty                        = ReferenceObjectForEquatableTestScenarios.ArrayOfDateTimeProperty,
                                ArrayOfCustomEnumProperty                      = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomEnumProperty,
                                ArrayOfCustomFlagsEnumProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomFlagsEnumProperty,
                                ArrayOfCustomClassProperty                     = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomClassProperty,
                                ArrayOfCustomBaseClassProperty                 = ReferenceObjectForEquatableTestScenarios.ArrayOfCustomBaseClassProperty,
                                ArrayOfCustomGenericClassOfCustomClassProperty = A.Dummy<ModelEqualityPublicSetArray>().Whose(_ => !_.ArrayOfCustomGenericClassOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ArrayOfCustomGenericClassOfCustomClassProperty)).ArrayOfCustomGenericClassOfCustomClassProperty,
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
        static ModelEqualityPublicSetArrayTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}