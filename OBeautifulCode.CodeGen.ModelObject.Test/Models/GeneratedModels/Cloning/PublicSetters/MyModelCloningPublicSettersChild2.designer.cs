// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;

    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.0.0")]
    public partial class MyModelCloningPublicSettersChild2 : IDeepCloneable<MyModelCloningPublicSettersChild2>
    {
        /// <inheritdoc />
        public new object Clone() => this.DeepClone();

        /// <inheritdoc />
        public override MyModelCloningPublicSettersParent DeepClone()
        {
            var result = ((IDeepCloneable<MyModelCloningPublicSettersChild2>)this).DeepClone();

            return result;
        }

        /// <inheritdoc />
        MyModelCloningPublicSettersChild2 IDeepCloneable<MyModelCloningPublicSettersChild2>.DeepClone()
        {
            var result = ((IDeclareDeepCloneMethod<MyModelCloningPublicSettersChild2>)this).DeepClone();

            return result;
        }
    }
}