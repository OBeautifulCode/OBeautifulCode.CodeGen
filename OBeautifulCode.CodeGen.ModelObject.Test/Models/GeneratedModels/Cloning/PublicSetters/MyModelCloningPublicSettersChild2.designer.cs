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
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.0.0")]
    public partial class MyModelCloningPublicSettersChild2 : IDeepCloneable<MyModelCloningPublicSettersChild2>
    {
        /// <inheritdoc />
        public new MyModelCloningPublicSettersChild2 DeepClone() => (MyModelCloningPublicSettersChild2)this.DeepCloneInternal();

        /// <inheritdoc />
        protected override MyModelCloningPublicSettersParent DeepCloneInternal() => ((IDeclareDeepCloneMethod<MyModelCloningPublicSettersChild2>)this).DeepClone();
    }
}