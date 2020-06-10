// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelHashingPrivateSettersParentTest.cs" company="OBeautifulCode">
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

    public static partial class MyModelHashingPrivateSettersParentTest
    {
        private static readonly Type ReferenceType = typeof(MyModelHashingPrivateSettersChild1);

        private static readonly ConstructorInfo ReferenceTypeConstructorInfo = ReferenceType.GetConstructors().Single();

        private static readonly IReadOnlyList<PropertyInfo> ReferenceTypeProperties = ReferenceTypeConstructorInfo.GetParameters().Select(_ => ReferenceType.GetProperty(_.Name.ToUpperFirstCharacter())).ToList();

        private static readonly MyModelHashingPrivateSettersChild1 ReferenceObject = A.Dummy<MyModelHashingPrivateSettersChild1>();

        private static readonly MyModelHashingPrivateSettersParent ObjectForEquatableTests = ReferenceObject;

        private static readonly IReadOnlyCollection<MyModelHashingPrivateSettersParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new[]
        {
            (MyModelHashingPrivateSettersParent)ReferenceTypeConstructorInfo.Invoke(ReferenceTypeProperties.Select(_ => _.GetValue(ReferenceObject)).ToArray()),
        };

        private static readonly MyModelHashingPrivateSettersParent[] ObjectsThatAreNotEqualToObjectForEquatableTests =
        {
            A.Dummy<MyModelHashingPrivateSettersParent>(),
        };

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelHashingPrivateSettersParentTest()
        {
            EquatableTestScenarios.AddScenario(new Recipes.EquatableTestScenario<MyModelHashingPrivateSettersParent>
            {
                Name = "Scenario 1",
                ReferenceObject = ObjectForEquatableTests,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.ToList(),
                ObjectsThatAreNotEqualToReferenceObject = ObjectsThatAreNotEqualToObjectForEquatableTests.ToList(),
            });
        }
    }
}