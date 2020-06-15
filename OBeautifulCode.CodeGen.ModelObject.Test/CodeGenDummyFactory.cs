// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGenDummyFactory.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.AutoFakeItEasy;

    public class CodeGenDummyFactory : DefaultCodeGenDummyFactory
    {
        public CodeGenDummyFactory()
        {
            AutoFixtureBackedDummyFactory.UseRandomConcreteSubclassForDummy<CustomBaseClass>();
        }
    }
}