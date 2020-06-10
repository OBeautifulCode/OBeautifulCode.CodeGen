// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelHashingPrivateSetParentTest.cs" company="OBeautifulCode">
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

    public static partial class MyModelHashingPrivateSetParentTest
    {
        private static readonly Type ReferenceType = typeof(MyModelHashingPrivateSetChild1);

        private static readonly ConstructorInfo ReferenceTypeConstructorInfo = ReferenceType.GetConstructors().Single();

        private static readonly IReadOnlyList<PropertyInfo> ReferenceTypeProperties = ReferenceTypeConstructorInfo.GetParameters().Select(_ => ReferenceType.GetProperty(_.Name.ToUpperFirstCharacter())).ToList();

        private static readonly MyModelHashingPrivateSetChild1 ReferenceObject = A.Dummy<MyModelHashingPrivateSetChild1>();

        private static readonly MyModelHashingPrivateSetParent ObjectForEquatableTests = ReferenceObject;

        private static readonly IReadOnlyCollection<MyModelHashingPrivateSetParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new[]
        {
            (MyModelHashingPrivateSetParent)ReferenceTypeConstructorInfo.Invoke(ReferenceTypeProperties.Select(_ => _.GetValue(ReferenceObject)).ToArray()),
        };

        private static readonly MyModelHashingPrivateSetParent[] ObjectsThatAreNotEqualToObjectForEquatableTests =
        {
            A.Dummy<MyModelHashingPrivateSetParent>(),
        };

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelHashingPrivateSetParentTest()
        {
            EquatableTestScenarios.AddScenario(new Recipes.EquatableTestScenario<MyModelHashingPrivateSetParent>
            {
                Name = "Scenario 1",
                ReferenceObject = ObjectForEquatableTests,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.ToList(),
                ObjectsThatAreNotEqualToReferenceObject = ObjectsThatAreNotEqualToObjectForEquatableTests.ToList(),
            });
        }
    }
}