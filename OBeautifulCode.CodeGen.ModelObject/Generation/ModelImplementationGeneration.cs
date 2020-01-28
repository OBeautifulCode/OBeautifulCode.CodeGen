﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelImplementationGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates model implementation code.
    /// </summary>
    internal static class ModelImplementationGeneration
    {
        /// <summary>
        /// Generates code that implements standard features of a model, including
        /// equality checks, hash code generation, cloning methods, and a friendly ToString().
        /// </summary>
        /// <param name="modelType">The type of model.</param>
        /// <returns>
        /// Generated code that implements the standard features for the specified model type.
        /// </returns>
        public static string GenerateCodeForModelImplementation(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            var interfaces = new List<Type>();

            if (modelType.Type.IsAssignableTo(typeof(IModelViaCodeGen)))
            {
                interfaces.Add(typeof(IModel<>).MakeGenericType(modelType.Type));
            }
            else
            {
                if (modelType.Type.IsAssignableTo(typeof(IDeepCloneableViaCodeGen)))
                {
                    interfaces.Add(typeof(IDeepCloneable<>).MakeGenericType(modelType.Type));
                }

                if (modelType.Type.IsAssignableTo(typeof(IEquatableViaCodeGen)))
                {
                    interfaces.Add(typeof(IEquatable<>).MakeGenericType(modelType.Type));
                }

                if (modelType.Type.IsAssignableTo(typeof(IHashableViaCodeGen)))
                {
                    interfaces.Add(typeof(IHashable));
                }

                if (modelType.Type.IsAssignableTo(typeof(IStringRepresentableViaCodeGen)))
                {
                    interfaces.Add(typeof(IStringRepresentable));
                }
            }

            if (modelType.Type.IsAssignableTo(typeof(IComparableViaCodeGen)))
            {
                interfaces.Add(typeof(IComparableForRelativeSortOrder<>).MakeGenericType(modelType.Type));
            }

            var items = new[]
            {
                "// --------------------------------------------------------------------------------------------------------------------",
                "// <auto-generated>",
                Invariant($"//   Generated using {GenerationShared.GetCodeGenAssemblyName()} ({GenerationShared.GetCodeGenAssemblyVersion()})"),
                "// </auto-generated>",
                "// --------------------------------------------------------------------------------------------------------------------",
                string.Empty,
                Invariant($"namespace {modelType.Type.Namespace}"),
                "{",
                "    using System;",
                "    using System.CodeDom.Compiler;",
                "    using System.Collections.Concurrent;",
                "    using System.Collections.Generic;",
                "    using System.Collections.ObjectModel;",
                "    using System.Diagnostics.CodeAnalysis;",
                "    using System.Globalization;",
                "    using System.Linq;",
                string.Empty,
                "    using OBeautifulCode.Equality.Recipes;",
                "    using OBeautifulCode.Type;",
                string.Empty,
                "    using static System.FormattableString;",
                string.Empty,
                "    [ExcludeFromCodeCoverage]",
                Invariant($"    [GeneratedCode(\"{GenerationShared.GetCodeGenAssemblyName()}\", \"{GenerationShared.GetCodeGenAssemblyVersion()}\")]"),
                Invariant($"    public partial class {modelType.Type.ToStringReadable()} : {interfaces.Select(_ => _.ToStringReadable()).ToDelimitedString(", ")}"),
                "    {",
                "    " + modelType.GenerateEqualityMethods(),
                "    " + modelType.GenerateGetHashCodeMethod(),
                "    " + modelType.GenerateCloningMethods(),
                "    " + modelType.GenerateToStringMethod(),
                "    }",
                "}",
            };

            var result = string.Join(
                Environment.NewLine,
                items);

            return result;
        }
    }
}