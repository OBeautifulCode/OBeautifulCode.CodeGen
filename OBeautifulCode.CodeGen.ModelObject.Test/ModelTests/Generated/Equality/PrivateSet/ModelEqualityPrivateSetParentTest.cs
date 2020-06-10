// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelEqualityPrivateSetParentTest.cs" company="OBeautifulCode">
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

    public static partial class ModelEqualityPrivateSetParentTest
    {
        private static readonly Type ReferenceType = typeof(ModelEqualityPrivateSetChild1);

        private static readonly ConstructorInfo ReferenceTypeConstructorInfo = ReferenceType.GetConstructors().Single();

        private static readonly IReadOnlyList<PropertyInfo> ReferenceTypeProperties = ReferenceTypeConstructorInfo.GetParameters().Select(_ => ReferenceType.GetProperty(_.Name.ToUpperFirstCharacter())).ToList();

        private static readonly ModelEqualityPrivateSetChild1 ReferenceObject = A.Dummy<ModelEqualityPrivateSetChild1>();

        private static readonly ModelEqualityPrivateSetParent ObjectForEquatableTests = ReferenceObject;

        private static readonly IReadOnlyCollection<ModelEqualityPrivateSetParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new[]
        {
            (ModelEqualityPrivateSetParent)ReferenceTypeConstructorInfo.Invoke(ReferenceTypeProperties.Select(_ => _.GetValue(ReferenceObject)).ToArray()),
        };

        private static readonly ModelEqualityPrivateSetParent[] ObjectsThatAreNotEqualToObjectForEquatableTests =
        {
            A.Dummy<ModelEqualityPrivateSetParent>(),
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
        static ModelEqualityPrivateSetParentTest()
        {
            EquatableTestScenarios.AddScenario(new Recipes.EquatableTestScenario<ModelEqualityPrivateSetParent>
            {
                Name = "Scenario 1",
                ReferenceObject = ObjectForEquatableTests,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.ToList(),
                ObjectsThatAreNotEqualToReferenceObject = ObjectsThatAreNotEqualToObjectForEquatableTests.ToList(),
                ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new[]
                {
                    A.Dummy<ModelEqualityPrivateSetParent>().Whose(_ => _.GetType() != ObjectForEquatableTests.GetType()),
                },
                ObjectsThatAreNotOfTheSameTypeAsReferenceObject = ObjectsThatAreNotTheSameTypeAsObjectForEquatableTests.ToList(),
            });
        }
    }
}