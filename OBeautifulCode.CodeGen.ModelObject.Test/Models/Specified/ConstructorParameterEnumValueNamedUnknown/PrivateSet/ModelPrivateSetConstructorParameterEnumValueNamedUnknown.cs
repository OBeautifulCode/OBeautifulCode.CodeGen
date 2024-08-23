// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelPrivateSetConstructorParameterEnumValueNamedUnknown.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class ModelPrivateSetConstructorParameterEnumValueNamedUnknown : IModelViaCodeGen
    {
        public ModelPrivateSetConstructorParameterEnumValueNamedUnknown(
            CustomEnum item1,
            CustomEnum? item2,
            CustomEnumWithUnknown item3,
            CustomEnumWithUnknown? item4)
        {
            new { item3 }.AsArg().Must().NotBeEqualTo(CustomEnumWithUnknown.Unknown);
            new { item4 }.AsArg().Must().NotBeEqualToWhenNotNull((CustomEnumWithUnknown?)CustomEnumWithUnknown.Unknown);

            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
            this.Item4 = item4;
        }

        public CustomEnum Item1 { get; private set; }

        public CustomEnum? Item2 { get; private set; }

        public CustomEnumWithUnknown Item3 { get; private set; }

        public CustomEnumWithUnknown? Item4 { get; private set; }
    }
}
