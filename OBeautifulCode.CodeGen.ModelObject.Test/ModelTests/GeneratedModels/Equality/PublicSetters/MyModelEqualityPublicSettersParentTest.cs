// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelEqualityPublicSettersParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;

    public static partial class MyModelEqualityPublicSettersParentTest
    {
        private static readonly MyModelEqualityPublicSettersParent ObjectForEquatableTests = A.Dummy<MyModelEqualityPublicSettersChild1>();

        private static readonly IReadOnlyCollection<MyModelEqualityPublicSettersParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests;

        private static readonly IReadOnlyCollection<MyModelEqualityPublicSettersParent> ObjectsThatAreNotEqualToObjectForEquatableTests = new[]
        {
            A.Dummy<MyModelEqualityPublicSettersParent>(),
        };

        private static readonly IReadOnlyCollection<object> ObjectsThatAreNotTheSameTypeAsObjectForEquatableTests = new[]
        {
            A.Dummy<object>(),
            A.Dummy<string>(),
            A.Dummy<int>(),
            A.Dummy<int?>(),
            A.Dummy<Guid>(),
        };

        static MyModelEqualityPublicSettersParentTest()
        {
            var objectThatIsEqualToButNotTheSameAsObjectForEquatableTests = new MyModelEqualityPublicSettersChild1();

            var properties = typeof(MyModelEqualityPublicSettersChild1).GetProperties();

            foreach (var property in properties)
            {
                property.SetValue(objectThatIsEqualToButNotTheSameAsObjectForEquatableTests, property.GetValue(ObjectForEquatableTests));
            }

            ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new[]
            {
                objectThatIsEqualToButNotTheSameAsObjectForEquatableTests,
            };

            EquatableTestScenarios.AddScenario(new Recipes.EquatableTestScenario<MyModelEqualityPublicSettersParent>
            {
                Name = "Scenario 1",
                ReferenceObject = ObjectForEquatableTests,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.ToList(),
                ObjectsThatAreNotEqualToReferenceObject = ObjectsThatAreNotEqualToObjectForEquatableTests.ToList(),
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[]
                {
                    A.Dummy<MyModelEqualityPublicSettersParent>().Whose(_ => _.GetType() != ObjectForEquatableTests.GetType()),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = ObjectsThatAreNotTheSameTypeAsObjectForEquatableTests.ToList(),
            });
        }
    }
}