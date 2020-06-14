// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPublicSetReadOnlyCollectionOfNullableParentTest.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPublicSetReadOnlyCollectionOfNullableParentTest
    {
        private static readonly ModelHashingPublicSetReadOnlyCollectionOfNullableParent ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPublicSetReadOnlyCollectionOfNullableParent>();

        private static readonly ModelHashingPublicSetReadOnlyCollectionOfNullableParent ObjectThatIsEqualToButNotTheSameAsReferenceObject = A.Dummy<ModelHashingPublicSetReadOnlyCollectionOfNullableParent>().Whose(_ => _.GetType() == ReferenceObjectForEquatableTestScenarios.GetType());

        private static readonly EquatableTestScenarios<ModelHashingPublicSetReadOnlyCollectionOfNullableParent> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPublicSetReadOnlyCollectionOfNullableParent>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPublicSetReadOnlyCollectionOfNullableParent>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPublicSetReadOnlyCollectionOfNullableParent[]
                    {
                        ObjectThatIsEqualToButNotTheSameAsReferenceObject,
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPublicSetReadOnlyCollectionOfNullableParent[]
                    {
                        // no good way to do this without DeepCloneWith...()
                    },
                    ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new ModelHashingPublicSetReadOnlyCollectionOfNullableParent[]
                    {
                        A.Dummy<ModelHashingPublicSetReadOnlyCollectionOfNullableParent>().Whose(_ => _.GetType() != ReferenceObjectForEquatableTestScenarios.GetType()),
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
        static ModelHashingPublicSetReadOnlyCollectionOfNullableParentTest()
        {
            var properties = ObjectThatIsEqualToButNotTheSameAsReferenceObject.GetType().GetProperties();

            foreach (var property in properties)
            {
                property.DeclaringType.GetProperty(property.Name).SetValue(ObjectThatIsEqualToButNotTheSameAsReferenceObject, property.GetValue(ReferenceObjectForEquatableTestScenarios));
            }

            EquatableTestScenarios.AddScenarios(LocalEquatableTestScenarios);
        }
    }
}