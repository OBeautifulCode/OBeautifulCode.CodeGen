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
    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Type.Recipes;

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
            var actual = CodeGenerator.GenerateForModel<MyModelParent>(GenerateFor.AllPossibleCode);

            // Assert
            this.testOutputHelper.WriteLine(actual);
        }

        [Fact]
        public void GenerateModel___Should_generate_the_model___When_called()
        {
            // Arrange
            var typesToTest = TypesToTest;
            var typeWrapperKinds = EnumExtensions.GetDefinedEnumValues<TypeWrapperKind>();

            // Act
            var actual = GenerateModel("MyModel", SetterKind.None, typesToTest, typeWrapperKinds);

            // Assert
            this.testOutputHelper.WriteLine(actual);
        }

        private static string GenerateModel(
            string modelName,
            SetterKind setterKind,
            IReadOnlyCollection<Type> typesToTest,
            IReadOnlyCollection<TypeWrapperKind> typeWrapperKinds)
        {
            var parentCode = GenerateModel(modelName, setterKind, typesToTest, typeWrapperKinds, HierarchyKind.Abstract);

            var child1Code = GenerateModel(modelName, setterKind, typesToTest, typeWrapperKinds, HierarchyKind.Derivative, childIdentifier: "1");

            var child2Code = GenerateModel(modelName, setterKind, typesToTest, typeWrapperKinds, HierarchyKind.Derivative, childIdentifier: "2");

            var result = Invariant($"{parentCode}{Environment.NewLine}{Environment.NewLine}{child1Code}{Environment.NewLine}{Environment.NewLine}{child2Code}");

            return result;
        }

        private static string GenerateModel(
            string baseName,
            SetterKind setterKind,
            IReadOnlyCollection<Type> typesToTest,
            IReadOnlyCollection<TypeWrapperKind> typeWrapperKinds,
            HierarchyKind hierarchyKind,
            string childIdentifier = null)
        {
            var modelName = BuildModelName(baseName, hierarchyKind, childIdentifier);

            var constructorParentParameterStatements = new List<string>();
            var constructorParentParameterNames = new List<string>();
            var constructorDeclarationStatement = string.Empty;
            var constructorParameterStatements = new List<string>();
            var constructorValidationStatements = new List<string>();
            var constructorPropertySettingStatements = new List<string>();

            var propertyStatements = new List<string>();

            if (setterKind.RequiresConstructor())
            {
                constructorDeclarationStatement = Invariant($"        public {modelName}(");
            }

            foreach (var typeWrapperKind in typeWrapperKinds)
            {
                foreach (var typeToTest in typesToTest)
                {
                    var fullyWrappedType = typeToTest.ToFullyWrappedType(typeWrapperKind);

                    if (fullyWrappedType != null)
                    {
                        var typeCompilableString = fullyWrappedType.ToStringCompilable();

                        var propertyName = BuildPropertyName(typeToTest, typeWrapperKind, hierarchyKind, childIdentifier);

                        propertyStatements.Add(string.Empty);
                        propertyStatements.Add(Invariant($"        public {typeCompilableString} {propertyName} {{ get; {setterKind.ToSetterString()}}}"));

                        if (setterKind.RequiresConstructor())
                        {
                            var constructorParameterName = propertyName.ToLowerFirstCharacter();
                            constructorParameterStatements.Add(Invariant($"            {typeCompilableString} {constructorParameterName},"));

                            if (hierarchyKind == HierarchyKind.Derivative)
                            {
                                var constructorParentParameterName = BuildPropertyName(typeToTest, typeWrapperKind, HierarchyKind.Abstract, null).ToLowerFirstCharacter();
                                constructorParentParameterNames.Add(constructorParentParameterName);

                                constructorParentParameterStatements.Add(Invariant($"            {typeCompilableString} {constructorParentParameterName},"));
                            }

                            constructorPropertySettingStatements.Add(Invariant($"            this.{propertyName} = {constructorParameterName};"));

                            var mustValidationMethodName = fullyWrappedType.GetMustValidationMethodName();
                            if (mustValidationMethodName != null)
                            {
                                constructorValidationStatements.Add(Invariant($"            new {{ {constructorParameterName} }}.AsArg().Must().{mustValidationMethodName}();"));
                            }
                        }
                    }
                }
            }

            var abstractStatement = hierarchyKind == HierarchyKind.Abstract ? "abstract " : string.Empty;

            var derivativeStatement = hierarchyKind == HierarchyKind.Derivative ? $"{BuildModelName(baseName, HierarchyKind.Abstract)}, " : string.Empty;

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
                "    using OBeautifulCode.Type;",
                "    using OBeautifulCode.Validation.Recipes;",
                string.Empty,
                Invariant($"    public {abstractStatement}partial class {modelName} : {derivativeStatement}IModelViaCodeGen"),
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
                constructorStatements.Add(constructorDeclarationStatement);

                constructorStatements.AddRange(constructorParentParameterStatements);

                constructorParameterStatements[constructorParameterStatements.Count - 1] = constructorParameterStatements.Last().TrimEnd(',') + ")";
                constructorStatements.AddRange(constructorParameterStatements);

                if (hierarchyKind == HierarchyKind.Derivative)
                {
                    constructorStatements.Add(Invariant($"            : base({constructorParentParameterNames.ToDelimitedString(", ")})"));
                }

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

        private static string BuildModelName(
            string baseName,
            HierarchyKind hierarchyKind,
            string childIdentifier = null)
        {
            var result = Invariant($"{baseName}{BuildHierarchyNameToken(hierarchyKind)}{childIdentifier}");

            return result;
        }

        private static string BuildPropertyName(
            Type typeToTest,
            TypeWrapperKind typeWrapperKind,
            HierarchyKind hierarchyKind,
            string prefix)
        {
            var typeWrapperQualification = typeWrapperKind == TypeWrapperKind.None
                ? string.Empty
                : typeWrapperKind.ToString();

            var hierarchyNameToken = BuildHierarchyNameToken(hierarchyKind);

            var result = Invariant($"{hierarchyNameToken}{prefix}{typeWrapperQualification}{typeToTest.ToStringReadable().ToUpperFirstCharacter()}Property");

            return result;
        }

        private static string BuildHierarchyNameToken(
            HierarchyKind hierarchyKind)
        {
            string result;

            switch (hierarchyKind)
            {
                case HierarchyKind.Abstract:
                    result = "Parent";
                    break;
                case HierarchyKind.Derivative:
                    result = "Child";
                    break;
                default:
                    throw new NotSupportedException("This hierarchy kind is not supported: " + hierarchyKind);
            }

            return result;
        }
    }
}
