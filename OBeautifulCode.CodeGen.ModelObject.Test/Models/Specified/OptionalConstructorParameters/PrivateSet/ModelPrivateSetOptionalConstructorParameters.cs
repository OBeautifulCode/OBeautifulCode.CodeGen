// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetOptionalConstructorParameters.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class ModelPrivateSetOptionalConstructorParameters : IModelViaCodeGen
    {
        public ModelPrivateSetOptionalConstructorParameters(
            int item1,
            string item2 = null,
            string item3 = "some-default",
            CustomDerivedClass item4 = null)
        {
            new { item3 }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
            this.Item4 = item4;
        }

        public int Item1 { get; private set; }

        public string Item2 { get; private set; }

        public string Item3 { get; private set; }

        public CustomDerivedClass Item4 { get; private set; }
    }
}
