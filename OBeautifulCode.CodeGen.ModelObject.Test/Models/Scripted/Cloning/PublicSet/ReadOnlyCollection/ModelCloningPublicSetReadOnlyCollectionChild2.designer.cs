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
    public partial class ModelCloningPublicSetReadOnlyCollectionChild2 : IDeepCloneable<ModelCloningPublicSetReadOnlyCollectionChild2>
    {
        /// <inheritdoc />
        public new ModelCloningPublicSetReadOnlyCollectionChild2 DeepClone() => (ModelCloningPublicSetReadOnlyCollectionChild2)this.DeepCloneInternal();

        /// <inheritdoc />
        protected override ModelCloningPublicSetReadOnlyCollectionParent DeepCloneInternal() => ((IDeclareDeepCloneMethod<ModelCloningPublicSetReadOnlyCollectionChild2>)this).DeepClone();
    }
}