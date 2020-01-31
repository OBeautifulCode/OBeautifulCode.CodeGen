// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelEqualityPublicSettersParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Collections.Generic;

    using FakeItEasy;

    public partial class MyModelEqualityPublicSettersParentTest
    {
        private static readonly MyModelEqualityPublicSettersParent ObjectForEquatableTests = A.Dummy<MyModelEqualityPublicSettersChild1>();

        private static readonly IReadOnlyCollection<MyModelEqualityPublicSettersParent> ObjectsThatAreEqualToButNotTheSameAsObjectForEquatableTests;

        private static readonly IReadOnlyCollection<MyModelEqualityPublicSettersParent> ObjectsThatAreNotEqualToObjectForEquatableTests = new[]
        {
            A.Dummy<MyModelEqualityPublicSettersParent>(),
        };

        private static readonly IReadOnlyCollection<object> ObjectsThatAreNotTheSameTypeAsObjectForEquatableTests = new[]
        {
            A.Dummy<string>(),
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
        }
    }
}