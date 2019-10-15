// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGeneratorTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.Representation.System;
    using OBeautifulCode.String.Recipes;

    using Xunit;
    using Xunit.Abstractions;

    using static System.FormattableString;

    public class CodeGeneratorTest
    {
        private static readonly Type[] TypesToTest =
        {
            typeof(object),
            typeof(bool),
            typeof(int),
            typeof(string),
            typeof(Guid),
            typeof(DateTime),
            typeof(ModelEnum),
            typeof(ModelFlagsEnum),
            typeof(ModelStruct),
            typeof(ModelEquatableStruct),
            typeof(ModelClass),
            typeof(ModelEquatableClass),
        };

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

        [Fact]
        public void GenerateInnerModel___Should_generate_the_model___When_SetterKind_is_None()
        {
            // Arrange, Act
            var actual = GenerateInnerModel("InnerModel", SetterKind.None);

            // Assert
            this.testOutputHelper.WriteLine(actual);
        }

        private static string GenerateInnerModel(
            string modelName,
            SetterKind setterKind)
        {
            var constructorParameterStatements = new List<string>();
            var constructorValidationStatements = new List<string>();
            var constructorPropertySettingStatements = new List<string>();

            var propertyStatements = new List<string>();

            if (setterKind.RequiresConstructor())
            {
                constructorParameterStatements.Add(Invariant($"        public {modelName}("));
            }

            var typeWrapperKinds = EnumExtensions.GetEnumValues<TypeWrapperKind>();
            foreach (var typeWrapperKind in typeWrapperKinds)
            {
                foreach (var typeToTest in TypesToTest)
                {
                    var fullyWrappedType = typeToTest.ToFullyWrappedType(typeWrapperKind);

                    if (fullyWrappedType != null)
                    {
                        var typeCompilableString = fullyWrappedType.ToStringCompilable();

                        var propertyNamePrefix = typeWrapperKind == TypeWrapperKind.None
                            ? string.Empty
                            : typeWrapperKind.ToString();

                        var propertyName = Invariant($"{propertyNamePrefix}{typeToTest.ToStringReadable().ToUpperFirstCharacter()}Property");

                        propertyStatements.Add(string.Empty);
                        propertyStatements.Add(Invariant($"        public {typeCompilableString} {propertyName} {{ get; {setterKind.ToSetterString()}}}"));

                        if (setterKind.RequiresConstructor())
                        {
                            var constructorParameterName = propertyName.ToLowerFirstCharacter();
                            constructorParameterStatements.Add(Invariant($"            {typeCompilableString} {constructorParameterName},"));

                            constructorPropertySettingStatements.Add(Invariant($"            this.{propertyName} = {constructorParameterName};"));

                            var mustValidationMethodName = fullyWrappedType.GetMustValidationMethodName();
                            if (mustValidationMethodName != null)
                            {
                                constructorValidationStatements.Add(Invariant($"            new {{ {constructorParameterName} }}.Must().{mustValidationMethodName}();"));
                            }
                        }
                    }
                }
            }

            var headerStatements = new List<string>
            {
                "// --------------------------------------------------------------------------------------------------------------------",
                Invariant($"// <copyright file=\"{modelName}.cs\" company=\"OBeautifulCode\">"),
                "//   Copyright (c) OBeautifulCode 2018. All rights reserved.",
                "// </copyright>",
                "// --------------------------------------------------------------------------------------------------------------------",
                string.Empty,
                Invariant($"namespace {typeof(CodeGeneratorTest).Namespace}"),
                "{",
                "    using System;",
                "    using System.Collections.Generic;",
                string.Empty,
                "    using OBeautifulCode.Validation.Recipes;",
                string.Empty,
                Invariant($"    public partial class {modelName} : IModelViaCodeGen"),
                "    {",
            };

            var footerStatements = new List<string>
            {
                "    }",
                "}",
            };

            var constructorStatements = new List<string>();
            if (setterKind.RequiresConstructor())
            {
                constructorParameterStatements[constructorParameterStatements.Count - 1] = constructorParameterStatements.Last().TrimEnd(',') + ")";

                constructorStatements.AddRange(constructorParameterStatements);
                constructorStatements.Add("        {");
                constructorStatements.AddRange(constructorValidationStatements);
                constructorStatements.Add(string.Empty);
                constructorStatements.AddRange(constructorPropertySettingStatements);
                constructorStatements.Add("        }");
            }

            var result = new string[0]
                .Concat(headerStatements)
                .Concat(constructorStatements)
                .Concat(propertyStatements)
                .Concat(footerStatements)
                .ToNewLineDelimited();

            return result;
        }
    }
}
