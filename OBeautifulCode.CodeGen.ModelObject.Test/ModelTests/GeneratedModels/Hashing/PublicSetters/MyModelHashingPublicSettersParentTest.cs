// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelHashingPublicSettersParentTest.cs" company="OBeautifulCode">
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

    public static partial class MyModelHashingPublicSettersParentTest
    {
        private static readonly MyModelHashingPublicSettersParent ObjectForEquatableTests = A.Dummy<MyModelHashingPublicSettersChild1>();

        private static readonly IReadOnlyCollection<MyModelHashingPublicSettersParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests;

        private static readonly IReadOnlyCollection<MyModelHashingPublicSettersParent> ObjectsThatAreNotEqualToObjectForEquatableTests = new[]
        {
            A.Dummy<MyModelHashingPublicSettersParent>(),
        };

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelHashingPublicSettersParentTest()
        {
            var objectThatIsEqualToButNotTheSameAsObjectForEquatableTests = new MyModelHashingPublicSettersChild1();

            var properties = typeof(MyModelHashingPublicSettersChild1).GetProperties();

            foreach (var property in properties)
            {
                property.SetValue(objectThatIsEqualToButNotTheSameAsObjectForEquatableTests, property.GetValue(ObjectForEquatableTests));
            }

            ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new[]
            {
                objectThatIsEqualToButNotTheSameAsObjectForEquatableTests,
            };

            EquatableTestScenarios.AddScenario(new Recipes.EquatableTestScenario<MyModelHashingPublicSettersParent>
            {
                Name = "Scenario 1",
                ReferenceObject = ObjectForEquatableTests,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.ToList(),
                ObjectsThatAreNotEqualToReferenceObject = ObjectsThatAreNotEqualToObjectForEquatableTests.ToList(),
            });
        }
    }
}