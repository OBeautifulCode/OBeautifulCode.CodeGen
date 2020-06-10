// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPublicSetParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelEqualityPublicSetParentTest
    {
        private static readonly ModelEqualityPublicSetParent ObjectForEquatableTests = A.Dummy<ModelEqualityPublicSetChild1>();

        private static readonly IReadOnlyCollection<ModelEqualityPublicSetParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests;

        private static readonly IReadOnlyCollection<ModelEqualityPublicSetParent> ObjectsThatAreNotEqualToObjectForEquatableTests = new[]
        {
            A.Dummy<ModelEqualityPublicSetParent>(),
        };

        private static readonly IReadOnlyCollection<object> ObjectsThatAreNotTheSameTypeAsObjectForEquatableTests = new[]
        {
            A.Dummy<object>(),
            A.Dummy<string>(),
            A.Dummy<int>(),
            A.Dummy<int?>(),
            A.Dummy<Guid>(),
        };

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelEqualityPublicSetParentTest()
        {
            var objectThatIsEqualToButNotTheSameAsObjectForEquatableTests = new ModelEqualityPublicSetChild1();

            var properties = typeof(ModelEqualityPublicSetChild1).GetProperties();

            foreach (var property in properties)
            {
                property.SetValue(objectThatIsEqualToButNotTheSameAsObjectForEquatableTests, property.GetValue(ObjectForEquatableTests));
            }

            ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new[]
            {
                objectThatIsEqualToButNotTheSameAsObjectForEquatableTests,
            };

            EquatableTestScenarios.AddScenario(new Recipes.EquatableTestScenario<ModelEqualityPublicSetParent>
            {
                Name = "Scenario 1",
                ReferenceObject = ObjectForEquatableTests,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.ToList(),
                ObjectsThatAreNotEqualToReferenceObject = ObjectsThatAreNotEqualToObjectForEquatableTests.ToList(),
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[]
                {
                    A.Dummy<ModelEqualityPublicSetParent>().Whose(_ => _.GetType() != ObjectForEquatableTests.GetType()),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = ObjectsThatAreNotTheSameTypeAsObjectForEquatableTests.ToList(),
            });
        }
    }
}