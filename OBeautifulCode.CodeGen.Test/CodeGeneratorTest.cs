// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGeneratorTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.Test
{
    using System.Diagnostics;

    using OBeautifulCode.CodeGen;

    using Xunit;
    using Xunit.Abstractions;

    public class CodeGeneratorTest
    {
        private readonly ITestOutputHelper testOutputHelper;

        public CodeGeneratorTest(
            ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void GenerateForModel___Should_generate_all_possible_code___When_parameter_generateFor_is_AllPossibleCode()
        {
            // Arrange, Act
            var actual = CodeGenerator.GenerateForModel<InnerModel>(GenerateFor.AllPossibleCode);

            // Assert
            this.testOutputHelper.WriteLine(actual);
        }
    }
}
