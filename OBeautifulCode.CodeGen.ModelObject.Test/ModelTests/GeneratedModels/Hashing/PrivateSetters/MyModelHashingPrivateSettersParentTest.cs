// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelHashingPrivateSettersParentTest.cs" company="OBeautifulCode">
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

    using OBeautifulCode.String.Recipes;

    public partial class MyModelHashingPrivateSettersParentTest
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
    }
}