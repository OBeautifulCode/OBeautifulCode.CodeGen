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
        private static readonly Type[] TypesToWrap =
        {
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

        private static readonly Type[] AdditionalTypes =
        {
            typeof(IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyList<Guid>>>),
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
            var actual = CodeGenerator.GenerateForModel<MyModelGettersOnlyChild1>(GenerateFor.AllPossibleCode);

            // Assert
            this.testOutputHelper.WriteLine(actual);
        }

        [Fact]
        public void GenerateModel___Should_generate_the_model___When_called()
        {
            // Arrange
            var typesToWrap = TypesToWrap;
            var typeWrapperKinds = EnumExtensions.GetDefinedEnumValues<TypeWrapperKind>();
            var additionalTypes = AdditionalTypes;

            // Act
            var actual = GenerateModel("MyModel", SetterKind.GettersOnly, typesToWrap, typeWrapperKinds, additionalTypes);

            // Assert
            this.testOutputHelper.WriteLine(actual);
        }

        private static string GenerateModel(
            string modelName,
            SetterKind setterKind,
            IReadOnlyCollection<Type> typesToWrap,
            IReadOnlyCollection<TypeWrapperKind> typeWrapperKinds,
            IReadOnlyCollection<Type> additionalTypes)
        {
            var parentCode = GenerateModel(modelName, setterKind, typesToWrap, typeWrapperKinds, additionalTypes, HierarchyKind.Abstract);

            var child1Code = GenerateModel(modelName, setterKind, typesToWrap, typeWrapperKinds, additionalTypes, HierarchyKind.Derivative, childIdentifier: "1");

            var child2Code = GenerateModel(modelName, setterKind, typesToWrap, typeWrapperKinds, additionalTypes, HierarchyKind.Derivative, childIdentifier: "2");

            var result = Invariant($"{parentCode}{Environment.NewLine}{Environment.NewLine}{child1Code}{Environment.NewLine}{Environment.NewLine}{child2Code}");

            return result;
        }

        private static string GenerateModel(
            string baseName,
            SetterKind setterKind,
            IReadOnlyCollection<Type> typesToWrap,
            IReadOnlyCollection<TypeWrapperKind> typeWrapperKinds,
            IReadOnlyCollection<Type> additionalTypes,
            HierarchyKind hierarchyKind,
            string childIdentifier = null)
        {
            var modelName = baseName.BuildModelName(setterKind, hierarchyKind, childIdentifier);

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

            var typesToAddAsProperties = new List<Type>();
            foreach (var typeWrapperKind in typeWrapperKinds)
            {
                typesToAddAsProperties.AddRange(typesToWrap.Select(_ => _.ToFullyWrappedType(typeWrapperKind)).Where(_ => _ != null));
            }

            typesToAddAsProperties.AddRange(additionalTypes);

            foreach (var typeToAddAsProperty in typesToAddAsProperties)
            {
                var typeCompilableString = typeToAddAsProperty.ToStringCompilable();

                var propertyName = typeToAddAsProperty.BuildPropertyName(hierarchyKind, childIdentifier);

                propertyStatements.Add(string.Empty);
                propertyStatements.Add(Invariant($"        public {typeCompilableString} {propertyName} {{ get; {setterKind.ToSetterString()}}}"));

                if (setterKind.RequiresConstructor())
                {
                    var constructorParameterName = propertyName.ToLowerFirstCharacter();
                    constructorParameterStatements.Add(Invariant($"            {typeCompilableString} {constructorParameterName},"));

                    if (hierarchyKind == HierarchyKind.Derivative)
                    {
                        var constructorParentParameterName = typeToAddAsProperty.BuildPropertyName(HierarchyKind.Abstract, null).ToLowerFirstCharacter();
                        constructorParentParameterNames.Add(constructorParentParameterName);

                        constructorParentParameterStatements.Add(Invariant($"            {typeCompilableString} {constructorParentParameterName},"));
                    }

                    constructorPropertySettingStatements.Add(Invariant($"            this.{propertyName} = {constructorParameterName};"));

                    var mustValidationMethodName = typeToAddAsProperty.GetMustValidationMethodName();
                    if (mustValidationMethodName != null)
                    {
                        constructorValidationStatements.Add(Invariant($"            new {{ {constructorParameterName} }}.AsArg().Must().{mustValidationMethodName}();"));
                    }
                }
            }

            var abstractStatement = hierarchyKind == HierarchyKind.Abstract ? "abstract " : string.Empty;

            var derivativeStatement = hierarchyKind == HierarchyKind.Derivative ? $"{baseName.BuildModelName(setterKind, HierarchyKind.Abstract)}, " : string.Empty;

            var headerStatements = new List<string>
            {
                "// --------------------------------------------------------------------------------------------------------------------",
                Invariant($"// <copyright file=\"{modelName}.cs\" company=\"OBeautifulCode\">"),
                "//   Copyright (c) OBeautifulCode 2018. All rights reserved.",
                "// </copyright>",
                "// <auto-generated>",
                "//   Sourced OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest.GenerateModel()",
                "// </auto-generated>",
                "// --------------------------------------------------------------------------------------------------------------------",
                string.Empty,
                Invariant($"namespace {typeof(CodeGeneratorTest).Namespace}"),
                "{",
                "    using System;",
                "    using System.Collections.Generic;",
                string.Empty,
                "    using OBeautifulCode.Assertion.Recipes;",
                "    using OBeautifulCode.Type;",
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
    }
}
