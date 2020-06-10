// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelHashingPublicSetParentTest.cs" company="OBeautifulCode">
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

    public static partial class MyModelHashingPublicSetParentTest
    {
        private static readonly MyModelHashingPublicSetParent ObjectForEquatableTests = A.Dummy<MyModelHashingPublicSetChild1>();

        private static readonly IReadOnlyCollection<MyModelHashingPublicSetParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests;

        private static readonly IReadOnlyCollection<MyModelHashingPublicSetParent> ObjectsThatAreNotEqualToObjectForEquatableTests = new[]
        {
            A.Dummy<MyModelHashingPublicSetParent>(),
        };

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static MyModelHashingPublicSetParentTest()
        {
            var objectThatIsEqualToButNotTheSameAsObjectForEquatableTests = new MyModelHashingPublicSetChild1();

            var properties = typeof(MyModelHashingPublicSetChild1).GetProperties();

            foreach (var property in properties)
            {
                property.SetValue(objectThatIsEqualToButNotTheSameAsObjectForEquatableTests, property.GetValue(ObjectForEquatableTests));
            }

            ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests = new[]
            {
                objectThatIsEqualToButNotTheSameAsObjectForEquatableTests,
            };

            EquatableTestScenarios.AddScenario(new Recipes.EquatableTestScenario<MyModelHashingPublicSetParent>
            {
                Name = "Scenario 1",
                ReferenceObject = ObjectForEquatableTests,
                ObjectsThatAreEqualToButNotTheSameAsReferenceObject = ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests.ToList(),
                ObjectsThatAreNotEqualToReferenceObject = ObjectsThatAreNotEqualToObjectForEquatableTests.ToList(),
            });
        }
    }
}