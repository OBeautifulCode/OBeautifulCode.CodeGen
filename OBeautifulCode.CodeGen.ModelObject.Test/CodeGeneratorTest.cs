// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGeneratorTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Type.Recipes;

    using Xunit;

    using static System.FormattableString;

    public class CodeGeneratorTest
    {
        public const string SourceRoot = "d:\\src\\OBeautifulCode\\OBeautifulCode.CodeGen\\";

        public const string ModelBaseName = "MyModel";

        public static readonly bool WriteFiles = true;

        public static readonly IReadOnlyList<string> ChildIdentifiers = new[] { "1", "2" };

        public static readonly string GeneratedModelsPath = SourceRoot.AppendMissing("\\") + "OBeautifulCode.CodeGen.ModelObject.Test\\Models\\GeneratedModels\\";

        public static readonly string GeneratedTestsPath = SourceRoot.AppendMissing("\\") + "OBeautifulCode.CodeGen.ModelObject.Test\\ModelTests\\GeneratedModels\\";

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

        private static readonly IReadOnlyList<TypeWrapperKind> TypeWrapperKinds = EnumExtensions.GetDefinedEnumValues<TypeWrapperKind>().ToList();

        private static readonly Type[] AdditionalTypes =
        {
            typeof(IReadOnlyList<IReadOnlyList<string>>),
            typeof(IReadOnlyList<ICollection<string>>),
            typeof(ICollection<IReadOnlyList<ICollection<string>>>),
            typeof(IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyList<Guid>>>),
            typeof(IReadOnlyDictionary<string, IReadOnlyDictionary<ICollection<string>, IReadOnlyDictionary<IList<string>, IReadOnlyList<string>>>>),
        };

        private delegate void ExecuteForModelsEventHandler(GenerationKind generationKind, SetterKind setterKind, HierarchyKind hierarchyKind, string directoryPath, string childIdentifier = null);

        [Fact]
        public void GenerateModel___Should_generate_the_model___When_called()
        {
            void ExecuteForModelsEventHandler(GenerationKind generationKind, SetterKind setterKind, HierarchyKind hierarchyKind, string directoryPath, string childIdentifier = null)
            {
                var modelName = ModelBaseName.BuildModelName(setterKind, hierarchyKind, childIdentifier);

                var modelFilePath = directoryPath + modelName + ".cs";

                var modelCode = GenerateModel(ModelBaseName, setterKind, TypesToWrap, TypeWrapperKinds, AdditionalTypes, hierarchyKind, childIdentifier);

                if (WriteFiles)
                {
                    File.WriteAllText(modelFilePath, modelCode);
                }
            }

            ExecuteForModels(GenerationKind.Model, ExecuteForModelsEventHandler);
        }

        [Fact]
        public void GenerateForModel___Should_generate_model_implementation_partial_class___When_parameter_generateFor_is_ModelImplementationPartialClass()
        {
            var executeForModelsEventHandler = BuildExecuteForModelsEventHandlerForGenerateForModel();

            ExecuteForModels(GenerationKind.Model, executeForModelsEventHandler);
        }

        [Fact]
        public void GenerateForModel___Should_generate_model_test_partial_class___When_parameter_generateFor_is_ModelImplementationTestsPartialClassWithSerialization()
        {
            var executeForModelsEventHandler = BuildExecuteForModelsEventHandlerForGenerateForModel();

            ExecuteForModels(GenerationKind.Test, executeForModelsEventHandler);
        }

        private static void ExecuteForModels(
            GenerationKind generationKind,
            ExecuteForModelsEventHandler eventHandler)
        {
            var setterKinds = EnumExtensions.GetDefinedEnumValues<SetterKind>();

            foreach (var setterKind in setterKinds)
            {
                var directoryPath = setterKind.GetGeneratedCodePath(generationKind);

                var hierarchyKinds = EnumExtensions.GetDefinedEnumValues<HierarchyKind>();

                foreach (var hierarchyKind in hierarchyKinds)
                {
                    if (hierarchyKind == HierarchyKind.ConcreteInherited)
                    {
                        foreach (var childIdentifier in ChildIdentifiers)
                        {
                            eventHandler(generationKind, setterKind, hierarchyKind, directoryPath, childIdentifier);
                        }
                    }
                    else
                    {
                        eventHandler(generationKind, setterKind, hierarchyKind, directoryPath);
                    }
                }
            }
        }

        private static ExecuteForModelsEventHandler BuildExecuteForModelsEventHandlerForGenerateForModel()
        {
            void ExecuteForModelsEventHandler(GenerationKind generationKind, SetterKind setterKind, HierarchyKind hierarchyKind, string directoryPath, string childIdentifier = null)
            {
                var modelName = ModelBaseName.BuildModelName(setterKind, hierarchyKind, childIdentifier);

                var modelType = typeof(CodeGeneratorTest).Assembly.GetTypes().Single(_ => _.Name == modelName);

                var generateForModelMethodInfo = typeof(CodeGenerator).GetMethod(nameof(CodeGenerator.GenerateForModel)).MakeGenericMethod(modelType);

                var testToken = generationKind == GenerationKind.Test ? "Test" : null;

                var modelFilePath = directoryPath + modelName + $"{testToken}.designer.cs";

                GenerateFor generateFor;
                switch (generationKind)
                {
                    case GenerationKind.Model:
                        generateFor = GenerateFor.ModelImplementationPartialClass;
                        break;
                    case GenerationKind.Test:
                        generateFor = GenerateFor.ModelImplementationTestsPartialClassWithSerialization;
                        break;
                    default:
                        throw new NotSupportedException("This kind is not supported: " + generationKind);
                }

                var modelCode = (string)generateForModelMethodInfo.Invoke(null, new object[] { generateFor });

                if (WriteFiles)
                {
                    File.WriteAllText(modelFilePath, modelCode);
                }
            }

            return ExecuteForModelsEventHandler;
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
                var constructorAccessorModifier = hierarchyKind == HierarchyKind.AbstractBase ? "protected" : "public";

                constructorDeclarationStatement = Invariant($"        {constructorAccessorModifier} {modelName}(");
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

                    if (hierarchyKind == HierarchyKind.ConcreteInherited)
                    {
                        var constructorParentParameterName = typeToAddAsProperty.BuildPropertyName(HierarchyKind.AbstractBase, null).ToLowerFirstCharacter();
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

            var abstractStatement = hierarchyKind == HierarchyKind.AbstractBase ? "abstract " : string.Empty;

            var derivativeStatement = hierarchyKind == HierarchyKind.ConcreteInherited ? $"{baseName.BuildModelName(setterKind, HierarchyKind.AbstractBase)}, " : string.Empty;

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

                if (hierarchyKind == HierarchyKind.ConcreteInherited)
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
