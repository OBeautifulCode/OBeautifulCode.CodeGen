// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelHashingPrivateSetParentTest.cs" company="OBeautifulCode">
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

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.String.Recipes;

    public static partial class ModelHashingPrivateSetParentTest
    {
        private static readonly Type ReferenceType = typeof(ModelHashingPrivateSetChild1);

        private static readonly ConstructorInfo ReferenceTypeConstructorInfo = ReferenceType.GetConstructors().Single();

        private static readonly IReadOnlyList<PropertyInfo> ReferenceTypeProperties = ReferenceTypeConstructorInfo.GetParameters().Select(_ => ReferenceType.GetProperty(_.Name.ToUpperFirstCharacter())).ToList();

        private static readonly ModelHashingPrivateSetChild1 ReferenceObject = A.Dummy<ModelHashingPrivateSetChild1>();

        private static readonly ModelHashingPrivateSetParent ObjectForEquatableTests = ReferenceObject;

        private static readonly IReadOnlyCollection<ModelHashingPrivateSetParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new[]
        {
            (ModelHashingPrivateSetParent)ReferenceTypeConstructorInfo.Invoke(ReferenceTypeProperties.Select(_ => _.GetValue(ReferenceObject)).ToArray()),
        };

        private static readonly ModelHashingPrivateSetParent[] ObjectsThatAreNotEqualToObjectForEquatableTests =
        {
            A.Dummy<ModelHashingPrivateSetParent>(),
        };

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ModelHashingPrivateSetParentTest()
        {
            EquatableTestScenarios.AddScenario(new Recipes.EquatableTestScenario<ModelHashingPrivateSetParent>
            {
                Name = "Scenario 1",
                ReferenceObject = ObjectForEquatableTests,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.ToList(),
                ObjectsThatAreNotEqualToReferenceObject = ObjectsThatAreNotEqualToObjectForEquatableTests.ToList(),
            });
        }
    }
}