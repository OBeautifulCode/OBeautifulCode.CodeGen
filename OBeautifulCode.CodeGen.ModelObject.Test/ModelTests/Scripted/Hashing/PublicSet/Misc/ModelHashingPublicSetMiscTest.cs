// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPublicSetMiscTest.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPublicSetMiscTest
    {
        private static readonly ModelHashingPublicSetMisc ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPublicSetMisc>();

        private static readonly EquatableTestScenarios<ModelHashingPublicSetMisc> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPublicSetMisc>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPublicSetMisc>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPublicSetMisc[]
                    {
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                            },
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPublicSetMisc[]
                    {
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = A.Dummy<ModelHashingPublicSetMisc>().Whose(_ => !_.CollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty)).CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                            },
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = A.Dummy<ModelHashingPublicSetMisc>().Whose(_ => !_.CollectionOfCollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty)).CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                            },
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = A.Dummy<ModelHashingPublicSetMisc>().Whose(_ => !_.ListInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty)).ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                            },
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = A.Dummy<ModelHashingPublicSetMisc>().Whose(_ => !_.ListOfCollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty)).ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                            },
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = A.Dummy<ModelHashingPublicSetMisc>().Whose(_ => !_.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty)).ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                            },
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = A.Dummy<ModelHashingPublicSetMisc>().Whose(_ => !_.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)).DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                            },
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = A.Dummy<ModelHashingPublicSetMisc>().Whose(_ => !_.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty)).DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                            },
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = A.Dummy<ModelHashingPublicSetMisc>().Whose(_ => !_.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty)).ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                            },
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = A.Dummy<ModelHashingPublicSetMisc>().Whose(_ => !_.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty)).ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                            },
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = A.Dummy<ModelHashingPublicSetMisc>().Whose(_ => !_.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)).ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                            },
                        new ModelHashingPublicSetMisc
                            {
                                CollectionInterfaceOfStringProperty                                                                                   = ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                CollectionOfCollectionInterfaceOfStringProperty                                                                       = ReferenceObjectForEquatableTestScenarios.CollectionOfCollectionInterfaceOfStringProperty,
                                ListInterfaceOfCollectionInterfaceOfStringProperty                                                                    = ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ListOfCollectionInterfaceOfStringProperty                                                                             = ReferenceObjectForEquatableTestScenarios.ListOfCollectionInterfaceOfStringProperty,
                                ReadOnlyCollectionOfCollectionInterfaceOfStringProperty                                                               = ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionOfCollectionInterfaceOfStringProperty,
                                DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                                                          = ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                DictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                                   = ReferenceObjectForEquatableTestScenarios.DictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty                                                         = ReferenceObjectForEquatableTestScenarios.ConcurrentDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty                           = ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty = A.Dummy<ModelHashingPublicSetMisc>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty)).ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyDictionaryOfReadOnlyListInterfaceOfDateTimeProperty,
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
        static ModelHashingPublicSetMiscTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}