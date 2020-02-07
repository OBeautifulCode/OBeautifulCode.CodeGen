// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelEqualityPrivateSettersParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.String.Recipes;

    public static partial class MyModelEqualityPrivateSettersParentTest
    {
        private static readonly Type ReferenceType = typeof(MyModelEqualityPrivateSettersChild1);

        private static readonly ConstructorInfo ReferenceTypeConstructorInfo = ReferenceType.GetConstructors().Single();

        private static readonly IReadOnlyList<PropertyInfo> ReferenceTypeProperties = ReferenceTypeConstructorInfo.GetParameters().Select(_ => ReferenceType.GetProperty(_.Name.ToUpperFirstCharacter())).ToList();

        private static readonly MyModelEqualityPrivateSettersChild1 ReferenceObject = A.Dummy<MyModelEqualityPrivateSettersChild1>();

        private static readonly MyModelEqualityPrivateSettersParent ObjectForEquatableTests = ReferenceObject;

        private static readonly IReadOnlyCollection<MyModelEqualityPrivateSettersParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new[]
        {
            (MyModelEqualityPrivateSettersParent)ReferenceTypeConstructorInfo.Invoke(ReferenceTypeProperties.Select(_ => _.GetValue(ReferenceObject)).ToArray()),
        };

        private static readonly MyModelEqualityPrivateSettersParent[] ObjectsThatAreNotEqualToObjectForEquatableTests =
        {
            A.Dummy<MyModelEqualityPrivateSettersParent>(),
        };

        private static readonly IReadOnlyCollection<object> ObjectsThatAreNotTheSameTypeAsObjectForEquatableTests = new[]
        {
            A.Dummy<object>(),
            A.Dummy<string>(),
            A.Dummy<int>(),
            A.Dummy<int?>(),
            A.Dummy<Guid>(),
        };

        static MyModelEqualityPrivateSettersParentTest()
        {
            EquatableTestScenarios.AddScenario(new Recipes.EquatableTestScenario<MyModelEqualityPrivateSettersParent>
            {
                Name = "Scenario 1",
                ReferenceObject = ObjectForEquatableTests,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.ToList(),
                ObjectsThatAreNotEqualToReferenceObject = ObjectsThatAreNotEqualToObjectForEquatableTests.ToList(),
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[]
                {
                    A.Dummy<MyModelEqualityPrivateSettersParent>().Whose(_ => _.GetType() != ObjectForEquatableTests.GetType()),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = ObjectsThatAreNotTheSameTypeAsObjectForEquatableTests.ToList(),
            });
        }
    }
}