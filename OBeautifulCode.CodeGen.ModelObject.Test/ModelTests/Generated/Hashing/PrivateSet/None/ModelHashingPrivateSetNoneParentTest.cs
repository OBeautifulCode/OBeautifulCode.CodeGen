// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetNoneParentTest.cs" company="OBeautifulCode">
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

    public static partial class ModelHashingPrivateSetNoneParentTest
    {
        private static readonly ModelHashingPrivateSetNoneParent ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPrivateSetNoneParent>();

        private static readonly ModelHashingPrivateSetNoneParent ObjectThatIsEqualToButNotTheSameAsReferenceObject = A.Dummy<ModelHashingPrivateSetNoneParent>().Whose(_ => _.GetType() == ReferenceObjectForEquatableTestScenarios.GetType());

        private static readonly EquatableTestScenarios<ModelHashingPrivateSetNoneParent> LocalEquatableTestScenarios = new EquatableTestScenarios<ModelHashingPrivateSetNoneParent>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPrivateSetNoneParent>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPrivateSetNoneParent[]
                    {
                        ObjectThatIsEqualToButNotTheSameAsReferenceObject,
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPrivateSetNoneParent[]
                    {
                        // no good way to do this without DeepCloneWith...()
                    },
                    ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new ModelHashingPrivateSetNoneParent[]
                    {
                        A.Dummy<ModelHashingPrivateSetNoneParent>().Whose(_ => _.GetType() != ReferenceObjectForEquatableTestScenarios.GetType()),
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
        static ModelHashingPrivateSetNoneParentTest()
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