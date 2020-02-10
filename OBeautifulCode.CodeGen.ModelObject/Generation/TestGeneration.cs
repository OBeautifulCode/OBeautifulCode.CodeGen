﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Collection.Recipes;

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
                Invariant($"namespace {modelType.TypeNamespace}.Test"),
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
                "    using OBeautifulCode.CodeGen.ModelObject.Recipes;",
                "    using OBeautifulCode.Collection.Recipes;",
                "    using OBeautifulCode.Math.Recipes;",
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

            items.Add(Invariant($"    public static partial class {modelType.TypeCompilableString}Test"));
            items.Add("    {");

            var firstNewlineInsideClassIndex = items.Count;

            if (kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithSerialization) && modelType.RequiresModel)
            {
                items.Add(string.Empty);
                items.Add("    " + modelType.GenerateSerializationTestFields());
            }

            if (modelType.RequiresEquality || modelType.RequiresHashing)
            {
                var equalityFieldsCode = modelType.GenerateEqualityTestFields();
                if (equalityFieldsCode != null)
                {
                    items.Add(string.Empty);
                    items.Add("    " + equalityFieldsCode);
                }
            }

            if (modelType.RequiresComparability)
            {
                var comparableTestFields = modelType.GenerateComparableTestFields();
                items.Add(string.Empty);
                items.Add("    " + comparableTestFields);
            }

            items.Add(string.Empty);
            items.Add("    " + modelType.GenerateStructuralTestMethods());

            if (modelType.RequiresStringRepresentation)
            {
                var stringTestMethodsCode = modelType.GenerateStringRepresentationTestMethods();
                if (stringTestMethodsCode != null)
                {
                    items.Add(string.Empty);
                    items.Add("    " + stringTestMethodsCode);
                }
            }

            if (modelType.RequiresModel)
            {
                var constructorTestMethodsCode = modelType.GenerateConstructorTestMethods();
                if (constructorTestMethodsCode != null)
                {
                    items.Add(string.Empty);
                    items.Add(constructorTestMethodsCode);
                }
            }

            if (modelType.RequiresDeepCloning)
            {
                items.Add(string.Empty);
                items.Add("    " + modelType.GenerateCloningTestMethods());
            }

            if (kind.HasFlag(GenerateFor.ModelImplementationTestsPartialClassWithSerialization) && modelType.RequiresModel)
            {
                items.Add(string.Empty);
                items.Add("    " + modelType.GenerateSerializationTestMethods());
            }

            if (modelType.RequiresEquality)
            {
                items.Add(string.Empty);
                items.Add("    " + modelType.GenerateEqualityTestMethods());
            }

            if (modelType.RequiresHashing)
            {
                items.Add(string.Empty);
                items.Add("    " + modelType.GenerateHashingTestMethods());
            }

            if (modelType.RequiresComparability)
            {
                items.Add(string.Empty);
                items.Add("    " + modelType.GenerateComparabilityTestMethods());
            }

            items.Add("    }");
            items.Add("}");

            items.RemoveAt(firstNewlineInsideClassIndex);

            var result = items.Where(_ => _ != null).ToNewLineDelimited();

            return result;
        }
    }
}