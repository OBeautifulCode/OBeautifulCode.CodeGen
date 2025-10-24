// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationTests.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.IO;
    using Xunit;

    public static class ValidationTests
    {
        [Fact(Skip = "for local testing only")]
        public static void GenerateDesignerFiles()
        {
            var modelTypes = new[]
            {
                typeof(ValidatableNumeric),
                typeof(ValidatableString),
                typeof(ValidatableObject),
                typeof(ValidatableComboProperties),
            };

            foreach (var modelType in modelTypes)
            {
                var designerFileContents = modelType.GenerateForModel(GenerateFor.ModelImplementationPartialClass, assembly => null);

                var filePath = Settings.SourceRoot + "CodeGeneratorTest\\" + "Validation\\" + modelType.Name + ".designer.cs";

                File.WriteAllText(filePath, designerFileContents);
            }
        }
    }
}
