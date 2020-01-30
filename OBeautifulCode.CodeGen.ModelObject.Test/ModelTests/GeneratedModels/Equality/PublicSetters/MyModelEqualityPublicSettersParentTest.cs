// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelEqualityPublicSettersParentTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System.Reflection;

    using FakeItEasy;

    public partial class MyModelEqualityPublicSettersParentTest
    {
        private static readonly MyModelEqualityPublicSettersParent ObjectForEquatableTests = A.Dummy<MyModelEqualityPublicSettersChild1>();

        private static readonly MyModelEqualityPublicSettersParent ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests;

        private static readonly MyModelEqualityPublicSettersParent[] ObjectsThatAreNotEqualToObjectForEquatableTests =
        {
            A.Dummy<MyModelEqualityPublicSettersParent>(),
        };

        private static readonly string ObjectThatIsNotTheSameTypeAsObjectForEquatableTests = A.Dummy<string>();

        static MyModelEqualityPublicSettersParentTest()
        {
            ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests = new MyModelEqualityPublicSettersChild1();

            var properties = typeof(MyModelEqualityPublicSettersChild1).GetProperties();

            foreach (var property in properties)
            {
                property.SetValue(ObjectThatIsEqualToButNotTheSameAsObjectForEquatableTests, property.GetValue(ObjectForEquatableTests));
            }
        }
    }
}