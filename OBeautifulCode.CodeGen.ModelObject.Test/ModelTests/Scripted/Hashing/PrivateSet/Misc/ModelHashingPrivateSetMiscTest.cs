// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetMiscTest.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPrivateSetMiscTest
    {
        private static readonly ModelHashingPrivateSetMisc ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPrivateSetMisc>();

        private static readonly EquatableTestScenarios<ModelHashingPrivateSetMisc> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPrivateSetMisc>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPrivateSetMisc>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPrivateSetMisc[]
                    {
                        new ModelHashingPrivateSetMisc(
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPrivateSetMisc[]
                    {
                        new ModelHashingPrivateSetMisc(
                                A.Dummy<ModelHashingPrivateSetMisc>().Whose(_ => !_.CollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty)).CollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                        new ModelHashingPrivateSetMisc(
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                A.Dummy<ModelHashingPrivateSetMisc>().Whose(_ => !_.ListInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ListInterfaceOfStringProperty)).ListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                        new ModelHashingPrivateSetMisc(
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfStringProperty,
                                A.Dummy<ModelHashingPrivateSetMisc>().Whose(_ => !_.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty)).ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                        new ModelHashingPrivateSetMisc(
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
                                A.Dummy<ModelHashingPrivateSetMisc>().Whose(_ => !_.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty)).CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                        new ModelHashingPrivateSetMisc(
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
                                A.Dummy<ModelHashingPrivateSetMisc>().Whose(_ => !_.ListInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty)).ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                        new ModelHashingPrivateSetMisc(
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                A.Dummy<ModelHashingPrivateSetMisc>().Whose(_ => !_.ReadOnlyListInterfaceOfListInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfListInterfaceOfStringProperty)).ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                        new ModelHashingPrivateSetMisc(
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
                                A.Dummy<ModelHashingPrivateSetMisc>().Whose(_ => !_.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)).DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                        new ModelHashingPrivateSetMisc(
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                A.Dummy<ModelHashingPrivateSetMisc>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty)).ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                        new ModelHashingPrivateSetMisc(
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
                                A.Dummy<ModelHashingPrivateSetMisc>().Whose(_ => !_.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)).ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                        new ModelHashingPrivateSetMisc(
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.CollectionInterfaceOfReadOnlyListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ListInterfaceOfCollectionInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfListInterfaceOfStringProperty,
                                ReferenceObjectForEquatableTestScenarios.DictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty,
                                ReferenceObjectForEquatableTestScenarios.ReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty,
                                A.Dummy<ModelHashingPrivateSetMisc>().Whose(_ => !_.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)).ReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
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
        static ModelHashingPrivateSetMiscTest()
        {
            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}