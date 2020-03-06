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
        public static void GenerateCodeForProject(
            string projectDirectory,
            string testProjectDirectory,
            string projectOutputDirectory)
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
                    .GetTypesFromAssemblies()
                    .Where(_ => (_.Namespace ?? string.Empty).StartsWith(projectName, StringComparison.Ordinal))
                    .ToList();

                var dummyFactorySnippets = new List<string>();

                foreach (var type in typesToCheck)
                {
                    Console.WriteLine("Checking type: " + type.ToStringReadable());

                    var shouldGenerateCode =
                        !type.ContainsGenericParameters &&
                        CodeGenerator.TypesThatIndicateCodeGenIsRequired.Any(_ => type.IsAssignableTo(_)) &&
                        !type.IsInterface;

                    if (shouldGenerateCode)
                    {
                        Console.WriteLine("Generating code for type: " + type.ToStringReadable());

                        WriteModelFile(type, projectSourceFilePaths);

                        if (hasTestProject)
                        {
                            WriteTestFiles(type, testProjectDirectory, testProjectSourceFilePaths, testNamespace, fileHeaderBuilder);
                        }

                        if (type.IsAssignableTo(typeof(IModelViaCodeGen)))
                        {
                            var dummyFactorySnippet = type.GenerateForModel(GenerateFor.ModelDummyFactorySnippet);

                            dummyFactorySnippets.Add(dummyFactorySnippet);
                        }
                    }
                }

                if (hasDummyFactory)
                {
                    WriteDummyFactoryFile(dummyFactoryFilePath, testNamespace, dummyFactorySnippets, testProjectDirectory, testProjectSourceFilePaths, fileHeaderBuilder);
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

            var modelFileName = type.Name + ".cs";

            // ReSharper disable once PossibleNullReferenceException
            var modelFilePath = projectSourceFilePaths.SingleOrDefault(_ => Path.GetFileName(_).Equals(modelFileName, StringComparison.OrdinalIgnoreCase));

            if (modelFilePath == null)
            {
                throw new FileNotFoundException(Invariant($"Expected a source file for type {type.ToStringReadable()} named {modelFileName}"));
            }

            var modelDesignerFilePath = GetDesignerFilePath(modelFilePath);

            File.WriteAllText(modelDesignerFilePath, modelPartialClassContents, Encoding);
        }

        private static void WriteTestFiles(
            Type type,
            string testProjectDirectory,
            IReadOnlyCollection<string> testProjectSourceFilePaths,
            string testNamespace,
            Func<string, string> fileHeaderBuilder)
        {
            var modelTestFileName = type.Name + "Test.cs";

            // ReSharper disable once PossibleNullReferenceException
            var modelTestFilePath = testProjectSourceFilePaths.SingleOrDefault(_ => Path.GetFileName(_).Equals(modelTestFileName, StringComparison.OrdinalIgnoreCase));

            if (modelTestFilePath == null)
            {
                var modelTestTypeName = type.Name + "Test";

                modelTestFilePath = Path.Combine(testProjectDirectory, modelTestTypeName + ".cs");

                var modelTestFileHeader = fileHeaderBuilder(modelTestTypeName);

                var modelTestFileContents = GenerateModelTestFileContents(modelTestFileHeader, testNamespace, modelTestTypeName);

                File.WriteAllText(modelTestFilePath, modelTestFileContents, Encoding);
            }

            var modelTestDesignerFilePath = GetDesignerFilePath(modelTestFilePath);

            var testPartialClassContents = type.GenerateForModel(GenerateFor.ModelImplementationTestsPartialClassWithSerialization);

            File.WriteAllText(modelTestDesignerFilePath, testPartialClassContents, Encoding);
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
            string dummyFactoryFilePath,
            string testNamespace,
            IReadOnlyList<string> snippets,
            string testProjectDirectory,
            IReadOnlyCollection<string> testProjectSourceFilePaths,
            Func<string, string> fileHeaderBuilder)
        {
            var dummyFactoryDesignerFilePath = GetDesignerFilePath(dummyFactoryFilePath);

            // ReSharper disable once PossibleNullReferenceException
            var dummyFactoryTypeName = Path.GetFileName(dummyFactoryFilePath).Replace(".cs", string.Empty);

            var dummyFactoryDesignerFileContents = CodeGenerator.GenerateDummyFactory(testNamespace, dummyFactoryTypeName, snippets);

            File.WriteAllText(dummyFactoryDesignerFilePath, dummyFactoryDesignerFileContents, Encoding);

            var dummyFactoryTestTypeName = dummyFactoryTypeName + "Test";

            var dummyFactoryTestFilePath = testProjectSourceFilePaths.SingleOrDefault(_ => _.EndsWith(dummyFactoryTypeName + "Test.cs", StringComparison.OrdinalIgnoreCase)) ?? Path.Combine(testProjectDirectory, dummyFactoryTestTypeName + ".cs");

            if (!File.Exists(dummyFactoryTestFilePath))
            {
                var dummyFactoryTestFileHeader = fileHeaderBuilder(dummyFactoryTestTypeName);

                var dummyFactoryTestFileContents = GenerateDummyFactoryTestFileContents(dummyFactoryTestFileHeader, testNamespace, dummyFactoryTestTypeName);

                File.WriteAllText(dummyFactoryTestFilePath, dummyFactoryTestFileContents, Encoding);
            }

            var dummyFactoryTestDesignerFilePath = GetDesignerFilePath(dummyFactoryTestFilePath);

            var dummyFactoryTestDesignerFileContents = CodeGenerator.GenerateDummyFactoryTests(testNamespace, dummyFactoryTypeName);

            File.WriteAllText(dummyFactoryTestDesignerFilePath, dummyFactoryTestDesignerFileContents, Encoding);
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
    }
}
