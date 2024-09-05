// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetOptionalConstructorParameters.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class ModelPrivateSetOptionalConstructorParameters : IModelViaCodeGen
    {
        public ModelPrivateSetOptionalConstructorParameters(
            int item1,
            string item2 = null,
            string item3 = "some-default",
            CustomDerivedClass item4 = null,
            IReadOnlyCollection<CustomClass> item5 = null,
            IReadOnlyDictionary<string, CustomClass> item6 = null)
        {
            new { item3 }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { item5 }.AsArg().Must().NotContainAnyNullElementsWhenNotNull();
            new { item6 }.AsArg().Must().NotContainAnyKeyValuePairsWithNullValueWhenNotNull();

            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
            this.Item4 = item4;
            this.Item5 = item5;
            this.Item6 = item6;
        }

        public int Item1 { get; private set; }

        public string Item2 { get; private set; }

        public string Item3 { get; private set; }

        public CustomDerivedClass Item4 { get; private set; }

        public IReadOnlyCollection<CustomClass> Item5 { get; private set; }

        public IReadOnlyDictionary<string, CustomClass> Item6 { get; private set; }
    }
}
