// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StructuralGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Type.Recipes;

    /// <summary>
    /// Generates code related to structural checks.
    /// </summary>
    internal static class StructuralGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";
        private const string ExpectedInterfaceToken = "<<<ExpectedInterfaceHere>>>";
        private const string ExpectedInterfaceInTestMethodNameToken = "<<<ExpectedInterfaceInTestMethodNameHere>>>";
        private const string ExpectedInterfaceImplementationsInflationToken = "<<<ExpectedInterfaceImplementationsInflationHere>>>";

        private const string StructuralTestMethodsCodeTemplate = @"    public static class Structural
        {" + ExpectedInterfaceImplementationsInflationToken + @"
        }";

        private const string ExpectedImplementationTestMethodCodeTemplate = @"
            [Fact]
            public static void " + TypeNameToken + @"___Should_implement_" + ExpectedInterfaceInTestMethodNameToken + @"___When_reflecting()
            {
                // Arrange
                var type = typeof(" + TypeNameToken + @");
                var expectedModelMethods = typeof(" + ExpectedInterfaceToken + @")
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();
                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(" + ExpectedInterfaceToken + @"));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
            }";

        /// <summary>
        /// Generates test methods that test a model's structure.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test a model's structure.
        /// </returns>
        public static string GenerateStructuralTestMethods(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            var expectedInterfaceTestMethods = modelType
                .RequiredInterfaces
                .Select(modelType.GetExpectedInterfaceTestMethodCode).ToList();

            var result = StructuralTestMethodsCodeTemplate
                        .Replace(ExpectedInterfaceImplementationsInflationToken, expectedInterfaceTestMethods.ToDelimitedString(Environment.NewLine + Environment.NewLine));

            return result;
        }

        private static string GetExpectedInterfaceTestMethodCode(
            this ModelType modelType,
            Type expectedInterfaceType)
        {
            var expectedInterfaceTypeInTestMethodString = expectedInterfaceType.IsGenericType
                ? expectedInterfaceType.ToStringWithoutGenericComponent() + "_of_" + modelType.TypeReadableString
                : expectedInterfaceType.ToStringReadable();

            var result =
                ExpectedImplementationTestMethodCodeTemplate
                .Replace(TypeNameToken, modelType.TypeCompilableString)
                .Replace(ExpectedInterfaceToken, expectedInterfaceType.ToStringCompilable())
                .Replace(ExpectedInterfaceInTestMethodNameToken, expectedInterfaceTypeInTestMethodString);

            return result;
        }
    }
}