// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPublicSetParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using FakeItEasy;

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;

    public static partial class ModelHashingPublicSetParentTest
    {
        private static readonly ModelHashingPublicSetParent ObjectForEquatableTests = A.Dummy<ModelHashingPublicSetChild1>();

        private static readonly IReadOnlyCollection<ModelHashingPublicSetParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests;

        private static readonly IReadOnlyCollection<ModelHashingPublicSetParent> ObjectsThatAreNotEqualToObjectForEquatableTests = new[]
        {
            A.Dummy<ModelHashingPublicSetParent>(),
        };

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelHashingPublicSetParentTest()
        {
            var objectThatIsEqualToButNotTheSameAsObjectForEquatableTests = new ModelHashingPublicSetChild1();

            var properties = typeof(ModelHashingPublicSetChild1).GetProperties();

            foreach (var property in properties)
            {
                property.SetValue(objectThatIsEqualToButNotTheSameAsObjectForEquatableTests, property.GetValue(ObjectForEquatableTests));
            }

            ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new[]
            {
                objectThatIsEqualToButNotTheSameAsObjectForEquatableTests,
            };

            EquatableTestScenarios.AddScenario(new Recipes.EquatableTestScenario<ModelHashingPublicSetParent>
            {
                Name = "Scenario 1",
                ReferenceObject = ObjectForEquatableTests,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.ToList(),
                ObjectsThatAreNotEqualToReferenceObject = ObjectsThatAreNotEqualToObjectForEquatableTests.ToList(),
            });
        }
    }
}