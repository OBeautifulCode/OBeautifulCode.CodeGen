﻿// --------------------------------------------------------------------------------------------------------------------
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

    using global::OBeautifulCode.Cloning.Recipes;
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class ModelCloningPrivateSetNoneChild1 : IDeepCloneable<ModelCloningPrivateSetNoneChild1>
    {
        /// <inheritdoc />
        public new ModelCloningPrivateSetNoneChild1 DeepClone() => (ModelCloningPrivateSetNoneChild1)this.DeepCloneInternal();

        /// <inheritdoc />
        protected override ModelCloningPrivateSetNoneParent DeepCloneInternal() => ((IDeclareDeepCloneMethod<ModelCloningPrivateSetNoneChild1>)this).DeepClone();
    }
}