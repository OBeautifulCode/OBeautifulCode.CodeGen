// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelEqualityPrivateSetParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Reflection;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.String.Recipes;

    public static partial class MyModelEqualityPrivateSetParentTest
    {
        private static readonly Type ReferenceType = typeof(MyModelEqualityPrivateSetChild1);

        private static readonly ConstructorInfo ReferenceTypeConstructorInfo = ReferenceType.GetConstructors().Single();

        private static readonly IReadOnlyList<PropertyInfo> ReferenceTypeProperties = ReferenceTypeConstructorInfo.GetParameters().Select(_ => ReferenceType.GetProperty(_.Name.ToUpperFirstCharacter())).ToList();

        private static readonly MyModelEqualityPrivateSetChild1 ReferenceObject = A.Dummy<MyModelEqualityPrivateSetChild1>();

        private static readonly MyModelEqualityPrivateSetParent ObjectForEquatableTests = ReferenceObject;

        private static readonly IReadOnlyCollection<MyModelEqualityPrivateSetParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new[]
        {
            (MyModelEqualityPrivateSetParent)ReferenceTypeConstructorInfo.Invoke(ReferenceTypeProperties.Select(_ => _.GetValue(ReferenceObject)).ToArray()),
        };

        private static readonly MyModelEqualityPrivateSetParent[] ObjectsThatAreNotEqualToObjectForEquatableTests =
        {
            A.Dummy<MyModelEqualityPrivateSetParent>(),
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
        static MyModelEqualityPrivateSetParentTest()
        {
            EquatableTestScenarios.AddScenario(new Recipes.EquatableTestScenario<MyModelEqualityPrivateSetParent>
            {
                Name = "Scenario 1",
                ReferenceObject = ObjectForEquatableTests,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.ToList(),
                ObjectsThatAreNotEqualToReferenceObject = ObjectsThatAreNotEqualToObjectForEquatableTests.ToList(),
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[]
                {
                    A.Dummy<MyModelEqualityPrivateSetParent>().Whose(_ => _.GetType() != ObjectForEquatableTests.GetType()),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = ObjectsThatAreNotTheSameTypeAsObjectForEquatableTests.ToList(),
            });
        }
    }
}