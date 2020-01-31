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

        private const string ShouldDeclareGetHashCodeMethodCodeTemplate = @"
            [Fact]
            public static void " + TypeNameToken + @"___Should_declare_GetHashCode_method___When_reflecting()
            {
                // Arrange
                var type = typeof(" + TypeNameToken + @");

                // Act
                var method = type.GetMethod(nameof(GetHashCode));

                // Assert
                method.DeclaringType.AsTest().Must().BeEqualTo(type);
            }";

        private const string ShouldDeclareToStringMethodCodeTemplate = @"
            [Fact]
            public static void " + TypeNameToken + @"___Should_declare_ToString_method___When_reflecting()
            {
                // Arrange
                var type = typeof(" + TypeNameToken + @");

                // Act
                var method = type.GetMethod(nameof(ToString));

                // Assert
                method.DeclaringType.AsTest().Must().BeEqualTo(type);
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

            var inflationCode = expectedInterfaceTestMethods.ToDelimitedString(Environment.NewLine + Environment.NewLine);

            if (modelType.DeclaresGetHashCodeMethod)
            {
                inflationCode = inflationCode + Environment.NewLine + ShouldDeclareGetHashCodeMethodCodeTemplate
                                    .Replace(TypeNameToken, modelType.TypeCompilableString);
            }

            if (modelType.DeclaresToStringMethod)
            {
                inflationCode = inflationCode + Environment.NewLine + ShouldDeclareToStringMethodCodeTemplate
                                    .Replace(TypeNameToken, modelType.TypeCompilableString);
            }

            var result = StructuralTestMethodsCodeTemplate
                        .Replace(ExpectedInterfaceImplementationsInflationToken, inflationCode);

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