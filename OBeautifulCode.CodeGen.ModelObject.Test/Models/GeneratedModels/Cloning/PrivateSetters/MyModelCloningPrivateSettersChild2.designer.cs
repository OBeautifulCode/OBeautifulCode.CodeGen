// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;

    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    public partial class MyModelCloningPrivateSettersChild2 : IDeepCloneable<MyModelCloningPrivateSettersChild2>
    {
        /// <inheritdoc />
        public new MyModelCloningPrivateSettersChild2 DeepClone() => (MyModelCloningPrivateSettersChild2)this.DeepCloneInternal();

        /// <inheritdoc />
        protected override MyModelCloningPrivateSettersParent DeepCloneInternal() => ((IDeclareDeepCloneMethod<MyModelCloningPrivateSettersChild2>)this).DeepClone();
    }
}