// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectCodeGenerator.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.Console
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Text;

    using Newtonsoft.Json.Linq;

    using OBeautifulCode.CodeGen.Console.Internal;
    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Reflection.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code for a project.
    /// </summary>
    public static class ProjectCodeGenerator
    {
        private static readonly Encoding Encoding = Encoding.UTF8;

        /// <summary>
        /// Generate logic for models.
        /// </summary>
        /// <param name="projectDirectory">Directory of the project to work on.</param>
        /// <param name="testProjectDirectory">Directory of the test project associated with the project to work on.</param>
        /// <param name="projectOutputDirectory">Directory where project outputs built files (e.g. ...\\bin\\debug\\)..</param>
        /// <param name="includeSerializationTesting">A value indicating whether to include serialization testing.</param>
        /// <param name="recipeConditionalCompilationSymbol">The conditional compilation symbol to use for recipes.</param>
        public static void GenerateCodeForProject(
            string projectDirectory,
            string testProjectDirectory,
            string projectOutputDirectory,
            bool includeSerializationTesting,
            string recipeConditionalCompilationSymbol)
        {
            if (!Directory.Exists(projectDirectory))
            {
                throw new ArgumentException("Could not find project directory: " + projectDirectory);
            }

            if (!Directory.Exists(projectOutputDirectory))
            {
                throw new ArgumentException("Could not find project output directory: " + projectOutputDirectory);
            }

            var projectName = new DirectoryInfo(projectDirectory).Name;

            var runningDirectory = Path.GetDirectoryName(typeof(ProjectCodeGenerator).Assembly.GetCodeBaseAsPathInsteadOfUri());

            var hasTestProject = !string.IsNullOrEmpty(testProjectDirectory) && Directory.Exists(testProjectDirectory);

            var projectSourceFilePaths = Directory.GetFiles(projectDirectory, "*.cs", SearchOption.AllDirectories).Where(_ => !_.Contains(".recipes")).ToArray();

            var testProjectSourceFilePaths = hasTestProject
                ? Directory.GetFiles(testProjectDirectory, "*.cs", SearchOption.AllDirectories).Where(_ => !_.Contains(".recipes")).ToArray()
                : new string[0];

            var testNamespace = hasTestProject
                ? new DirectoryInfo(testProjectDirectory).Name
                : null;

            var dummyFactoryFilePath = testProjectSourceFilePaths.SingleOrDefault(_ => _.EndsWith("DummyFactory.cs", StringComparison.OrdinalIgnoreCase));

            var hasDummyFactory = dummyFactoryFilePath != null;

            var fileHeaderBuilder = GetFileHeaderBuilder(projectName, projectDirectory);

            CopyMissingAssembliesFromProjectOutputDirectoryToRunningDirectory(projectOutputDirectory, runningDirectory);

            using (AssemblyLoader.CreateAndLoadFromDirectory(runningDirectory))
            {
                var typesToCheck = AssemblyLoader
                    .GetLoadedAssemblies()
                    .Where(_ => (_.GetName().Name ?? string.Empty).StartsWith(projectName, StringComparison.Ordinal))
                    .ToList()
                    .GetTypesFromAssemblies()
                    .ToList();

                var typesForDummyFactory = new List<Type>();

                foreach (var type in typesToCheck)
                {
                    Console.WriteLine("Checking type: " + type.ToStringReadable());

                    var shouldGenerateCode =
                        CodeGenerator.TypesThatIndicateCodeGenIsRequired.Any(_ => _.IsAssignableFrom(type)) &&
                        !type.IsInterface;

                    if (shouldGenerateCode)
                    {
                        Console.WriteLine("Generating code for type: " + type.ToStringReadable());

                        WriteModelFile(type, projectSourceFilePaths);

                        if (hasTestProject)
                        {
                            WriteTestFiles(type, testProjectDirectory, testProjectSourceFilePaths, testNamespace, fileHeaderBuilder, includeSerializationTesting);
                        }

                        if (typeof(IModelViaCodeGen).IsAssignableFrom(type))
                        {
                            typesForDummyFactory.Add(type);
                        }
                    }
                }

                if (hasDummyFactory)
                {
                    WriteDummyFactoryFile(typesForDummyFactory, dummyFactoryFilePath, testNamespace, testProjectDirectory, testProjectSourceFilePaths, fileHeaderBuilder, recipeConditionalCompilationSymbol);
                }
            }
        }

        private static void CopyMissingAssembliesFromProjectOutputDirectoryToRunningDirectory(
            string projectOutputDirectory,
            string runningDirectory)
        {
            var projectOutputFiles = Directory.GetFiles(projectOutputDirectory);

            if (projectOutputFiles.Length == 0)
            {
                throw new InvalidOperationException("Could not find any files in project output directory (check build): " + projectOutputDirectory);
            }

            foreach (var projectOutputFile in projectOutputFiles)
            {
                if (projectOutputFile.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) ||
                    projectOutputFile.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
                {
                    var runningDirectoryOutputFile = Path.Combine(runningDirectory, Path.GetFileName(projectOutputFile));

                    if (!File.Exists(runningDirectoryOutputFile))
                    {
                        File.Copy(projectOutputFile, runningDirectoryOutputFile);
                    }
                }
            }
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        private static Func<string, string> GetFileHeaderBuilder(
            string projectName,
            string projectDirectory)
        {
            var packagesDirectoryPath = Path.Combine(projectDirectory, "../packages");

            var buildPackagePrefix = projectName.Split('.').FirstOrDefault();

            var buildAnalyzerPackageName = buildPackagePrefix == null ? null : buildPackagePrefix + ".Build.Analyzers";

            var analyzerCandidates = buildAnalyzerPackageName == null
                ? null
                : Directory.GetDirectories(packagesDirectoryPath, buildAnalyzerPackageName + "*", SearchOption.TopDirectoryOnly);

            var analyzerPackageDirectory = analyzerCandidates?.OrderByDescending(_ => _).FirstOrDefault();

            var styleCopJsonFilePath = analyzerPackageDirectory == null ? null : Path.Combine(analyzerPackageDirectory, "analyzers/stylecop.json");

            if (styleCopJsonFilePath == null || !File.Exists(styleCopJsonFilePath))
            {
                return typeName => string.Empty;
            }

            var styleCopJsonContents = File.ReadAllText(styleCopJsonFilePath);

            dynamic styleCopJson = JObject.Parse(styleCopJsonContents);

            var companyName = styleCopJson.settings.documentationRules.companyName.ToString();

            var copyrightText = styleCopJson.settings.documentationRules.copyrightText.ToString().Replace("{companyName}", companyName);

            string Result(string typeName)
            {
                var fileHeader =
                    "// --------------------------------------------------------------------------------------------------------------------"
                  + Environment.NewLine
                  + "// <copyright file=\""
                  + typeName
                  + ".cs\" company=\""
                  + companyName
                  + "\">"
                  + Environment.NewLine
                  + "// "
                  + copyrightText
                  + Environment.NewLine
                  + "// </copyright>"
                  + Environment.NewLine
                  + "// --------------------------------------------------------------------------------------------------------------------";

                return fileHeader;
            }

            return Result;
        }

        private static void WriteModelFile(
            Type type,
            IReadOnlyCollection<string> projectSourceFilePaths)
        {
            var modelPartialClassContents = type.GenerateForModel(GenerateFor.ModelImplementationPartialClass);

            var modelFileName = type.ToStringXmlDoc() + ".cs";

            var modelFilePaths = projectSourceFilePaths.Where(_ => Path.GetFileName(_).Equals(modelFileName, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!modelFilePaths.Any())
            {
                throw new FileNotFoundException(Invariant($"Expected a source file for type {type.ToStringReadable()} named {modelFileName}"));
            }

            if (modelFilePaths.Count > 1)
            {
                throw new FileNotFoundException(Invariant($"Found multiple source files for type {type.ToStringReadable()} named {modelFileName}:{Environment.NewLine}{modelFilePaths.ToNewLineDelimited()}"));
            }

            var modelDesignerFilePath = GetDesignerFilePath(modelFilePaths.Single());

            WriteFileWithWindowsNewLines(modelDesignerFilePath, modelPartialClassContents);
        }

        private static void WriteTestFiles(
            Type type,
            string testProjectDirectory,
            IReadOnlyCollection<string> testProjectSourceFilePaths,
            string testNamespace,
            Func<string, string> fileHeaderBuilder,
            bool includeSerializationTesting)
        {
            var modelTestFileNameWithoutExtension = type.ToStringXmlDoc() + "Test";

            var modelTestFileName = modelTestFileNameWithoutExtension + ".cs";

            var modelTestFilePaths = testProjectSourceFilePaths.Where(_ => Path.GetFileName(_).Equals(modelTestFileName, StringComparison.OrdinalIgnoreCase)).ToList();

            if (modelTestFilePaths.Count > 1)
            {
                throw new FileNotFoundException(Invariant($"Found multiple test files for type {type.ToStringReadable()} named {modelTestFileName}:{Environment.NewLine}{modelTestFilePaths.ToNewLineDelimited()}"));
            }

            var modelTestFilePath = modelTestFilePaths.SingleOrDefault();

            if (modelTestFilePath == null)
            {
                var modelTestTypeName = type.ToStringWithoutGenericComponent() + "Test";

                modelTestFilePath = Path.Combine(testProjectDirectory, modelTestFileName);

                var modelTestFileHeader = fileHeaderBuilder(modelTestFileNameWithoutExtension);

                var modelTestFileContents = GenerateModelTestFileContents(modelTestFileHeader, testNamespace, modelTestTypeName);

                WriteFileWithWindowsNewLines(modelTestFilePath, modelTestFileContents);
            }

            var modelTestDesignerFilePath = GetDesignerFilePath(modelTestFilePath);

            var testPartialClassContents = type.GenerateForModel(includeSerializationTesting ? GenerateFor.ModelImplementationTestsPartialClassWithSerialization : GenerateFor.ModelImplementationTestsPartialClassWithoutSerialization);

            WriteFileWithWindowsNewLines(modelTestDesignerFilePath, testPartialClassContents);
        }

        private static string GetDesignerFilePath(
            string filePath)
        {
            var result = filePath.Replace(".cs", ".designer.cs");

            return result;
        }

        private static string GenerateModelTestFileContents(
            string fileHeader,
            string typeNamespace,
            string typeName)
        {
            var result = fileHeader
                         + Environment.NewLine
                         + Environment.NewLine
                         + "namespace " + typeNamespace
                         + Environment.NewLine
                         + "{"
                         + Environment.NewLine
                         + "    using System;"
                         + Environment.NewLine
                         + Environment.NewLine
                         + "    using FakeItEasy;"
                         + Environment.NewLine
                         + Environment.NewLine
                         + "    using OBeautifulCode.AutoFakeItEasy;"
                         + Environment.NewLine
                         + Environment.NewLine
                         + "    using Xunit;"
                         + Environment.NewLine
                         + Environment.NewLine
                         + "    public static partial class "
                         + typeName
                         + Environment.NewLine
                         + "    {"
                         + Environment.NewLine
                         + "    }"
                         + Environment.NewLine
                         + "}";

            return result;
        }

        private static void WriteDummyFactoryFile(
            IReadOnlyCollection<Type> typesForDummyFactory,
            string dummyFactoryFilePath,
            string testNamespace,
            string testProjectDirectory,
            IReadOnlyCollection<string> testProjectSourceFilePaths,
            Func<string, string> fileHeaderBuilder,
            string recipeConditionalCompilationSymbol)
        {
            var dummyFactoryDesignerFilePath = GetDesignerFilePath(dummyFactoryFilePath);

            // ReSharper disable once PossibleNullReferenceException
            var dummyFactoryTypeName = Path.GetFileName(dummyFactoryFilePath).Replace(".cs", string.Empty);

            var dummyFactoryDesignerFileContents = CodeGenerator.GenerateDummyFactory(typesForDummyFactory, testNamespace, dummyFactoryTypeName, recipeConditionalCompilationSymbol);

            WriteFileWithWindowsNewLines(dummyFactoryDesignerFilePath, dummyFactoryDesignerFileContents);

            var dummyFactoryTestTypeName = dummyFactoryTypeName + "Test";

            var dummyFactoryTestFilePath = testProjectSourceFilePaths.SingleOrDefault(_ => _.EndsWith(dummyFactoryTypeName + "Test.cs", StringComparison.OrdinalIgnoreCase)) ?? Path.Combine(testProjectDirectory, dummyFactoryTestTypeName + ".cs");

            if (!File.Exists(dummyFactoryTestFilePath))
            {
                var dummyFactoryTestFileHeader = fileHeaderBuilder(dummyFactoryTestTypeName);

                var dummyFactoryTestFileContents = GenerateDummyFactoryTestFileContents(dummyFactoryTestFileHeader, testNamespace, dummyFactoryTestTypeName);

                WriteFileWithWindowsNewLines(dummyFactoryTestFilePath, dummyFactoryTestFileContents);
            }

            var dummyFactoryTestDesignerFilePath = GetDesignerFilePath(dummyFactoryTestFilePath);

            var dummyFactoryTestDesignerFileContents = CodeGenerator.GenerateDummyFactoryTests(testNamespace, dummyFactoryTypeName);

            WriteFileWithWindowsNewLines(dummyFactoryTestDesignerFilePath, dummyFactoryTestDesignerFileContents);
        }

        private static string GenerateDummyFactoryTestFileContents(
            string fileHeader,
            string typeNamespace,
            string typeName)
        {
            var dummyFactoryFileContents = fileHeader
                                           + Environment.NewLine
                                           + Environment.NewLine
                                           + "namespace "
                                           + typeNamespace
                                           + Environment.NewLine
                                           + "{"
                                           + Environment.NewLine
                                           + "    using System;"
                                           + Environment.NewLine
                                           + Environment.NewLine
                                           + "    using FakeItEasy;"
                                           + Environment.NewLine
                                           + Environment.NewLine
                                           + "    using OBeautifulCode.AutoFakeItEasy;"
                                           + Environment.NewLine
                                           + Environment.NewLine
                                           + "    using Xunit;"
                                           + Environment.NewLine
                                           + Environment.NewLine
                                           + "    public static partial class "
                                           + typeName
                                           + Environment.NewLine
                                           + "    {"
                                           + Environment.NewLine
                                           + "    }"
                                           + Environment.NewLine
                                           + "}";

            return dummyFactoryFileContents;
        }

        private static void WriteFileWithWindowsNewLines(
            string filePath,
            string contents)
        {
            contents = contents.Replace("\r\n", "\n").Replace('\r', '\n').Replace("\n", "\r\n");

            File.WriteAllText(filePath, contents, Encoding);
        }
    }
}
