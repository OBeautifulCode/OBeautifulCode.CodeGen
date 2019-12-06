﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to testing.
    /// </summary>
    internal static class TestGeneration
    {
        /// <summary>
        /// Generates unit test code.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <param name="kind">Specifies the kind of code to generate.</param>
        /// <returns>
        /// Generated equality methods.
        /// </returns>
        public static string GenerateCodeForTests(
            this ModelType modelType,
            GenerateFor kind)
        {
            // ReSharper disable once UseObjectOrCollectionInitializer
            var items = new List<string>
            {
                "// --------------------------------------------------------------------------------------------------------------------",
                "// <auto-generated>",
                Invariant($"//   Generated using {GenerationShared.GetCodeGenAssemblyName()} ({GenerationShared.GetCodeGenAssemblyVersion()})"),
                "// </auto-generated>",
                "// --------------------------------------------------------------------------------------------------------------------",
                string.Empty,
                Invariant($"namespace {modelType.Type.Namespace}.Test"),
                "{",
                "    using System;",
                "    using System.CodeDom.Compiler;",
                "    using System.Collections.Concurrent;",
                "    using System.Collections.Generic;",
                "    using System.Collections.ObjectModel;",
                "    using System.Diagnostics.CodeAnalysis;",
                "    using System.Globalization;",
                "    using System.Linq;",
                "    using System.Reflection;",
                string.Empty,
                "    using FakeItEasy;",
                string.Empty,
                "    using OBeautifulCode.Assertion.Recipes;",
                "    using OBeautifulCode.AutoFakeItEasy;",
                "    using OBeautifulCode.Collection.Recipes;",
                "    using OBeautifulCode.Representation.System;",
                "    using OBeautifulCode.Serialization;",
                "    using OBeautifulCode.Serialization.Bson;",
                "    using OBeautifulCode.Serialization.Json;",
                "    using OBeautifulCode.Type;",
                string.Empty,
                "    using Xunit;",
                string.Empty,
                "    using static System.FormattableString;",
                string.Empty,
                "    [ExcludeFromCodeCoverage]",
                Invariant($"    [GeneratedCode(\"{GenerationShared.GetCodeGenAssemblyName()}\", \"{GenerationShared.GetCodeGenAssemblyVersion()}\")]"),
            };

            items.Add(Invariant($"    public partial class {modelType.Type.ToStringCompilable()}Test"));
            items.Add("    {");

            if (kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithSerialization))
            {
                items.Add("    " + modelType.GenerateSerializationTestFields());
            }

            items.Add(string.Empty);
            items.Add("    " + modelType.GenerateEqualityTestFields());
            items.Add("    " + modelType.GenerateToStringTestMethod());
            items.Add("    " + modelType.GenerateConstructorTestMethods());
            items.Add("    " + modelType.GenerateCloningTestMethods());

            if (kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithSerialization))
            {
                items.Add("    " + modelType.GenerateSerializationTestMethods());
            }

            items.Add("    " + modelType.GenerateEqualityTestMethods());
            items.Add("    }");
            items.Add("}");

            var result = string.Join(
                Environment.NewLine,
                items.Where(_ => (_.Length == 0) || !string.IsNullOrWhiteSpace(_)).ToArray());

            return result;
        }
    }
}