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
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    using Newtonsoft.Json.Linq;

    using OBeautifulCode.CodeGen.Console.Internal;
    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Reflection.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    /// <summary>
    /// Generates code for a project.
    /// </summary>
    public static class ProjectCodeGenerator
    {
        private const string TempDirectoryPrefix = "OBC.CodeGen";

        /// <summary>
        /// Generate logic for models.
        /// </summary>
        /// <param name="projectDirectory">Directory of the project to work on.</param>
        /// <param name="testProjectDirectory">Directory of the test project associated with the project to work on.</param>
        public static void GenerateCodeForProject(
            string projectDirectory,
            string testProjectDirectory)
        {
            if (!Directory.Exists(projectDirectory))
            {
                throw new ArgumentException("Could not find provided directory: " + projectDirectory);
            }

            var tempDirectoryRootPath = Path.GetTempPath();
            RemoveTempFilesFromPreviousRuns(tempDirectoryRootPath, TempDirectoryPrefix);

            var typesToCheck = ShadowCopyAssembliesLoadAndGetTypesToCheck(projectDirectory, tempDirectoryRootPath);

            var allProjectSourceFiles = Directory.GetFiles(projectDirectory, "*.cs", SearchOption.AllDirectories);
            var allTestProjectSourceFiles = !Directory.Exists(testProjectDirectory) ? new string[0] : Directory.GetFiles(testProjectDirectory, "*.cs", SearchOption.AllDirectories);

            var fileHeaderBuilder = GetFileHeaderBuilder(projectDirectory);
            var dummyFactorySnippets = new List<string>();
            var hasTestProject = !string.IsNullOrEmpty(testProjectDirectory) && Directory.Exists(testProjectDirectory);
            var testNamespace = hasTestProject ? new DirectoryInfo(testProjectDirectory).Name : null;
            foreach (var type in typesToCheck)
            {
                Console.WriteLine("Checking type: " + type.ToStringReadable());
                if (CodeGenerator.TypesThatIndicateCodeGenIsRequired.Any(_ => type.GetInterface(_.Name) != null))
                {
                    var modelDesignerFileContents = type.GenerateForModel(GenerateFor.ModelImplementationPartialClass);
                    var modelTestDesignerFileContents = type.GenerateForModel(GenerateFor.ModelImplementationTestsPartialClassWithSerialization);
                    var dummyFactorySnippet = type.GenerateForModel(GenerateFor.ModelDummyFactorySnippet);

                    // find file
                    var modelFilePath = allProjectSourceFiles.SingleOrDefault(_ => _.EndsWith(type.Name + ".cs", StringComparison.OrdinalIgnoreCase));
                    if (modelFilePath == null)
                    {
                        throw new FileNotFoundException("Expected a source file for type: " + type.ToStringReadable());
                    }

                    var modelDesignerFilePath = modelFilePath.Replace(".cs", ".designer.cs");

                    File.WriteAllText(modelDesignerFilePath, modelDesignerFileContents, Encoding.UTF8);

                    if (hasTestProject)
                    {
                        dummyFactorySnippets.Add(dummyFactorySnippet);
                        var modelTestFilePath = allTestProjectSourceFiles.SingleOrDefault(_ => _.EndsWith(type.Name + "Test.cs", StringComparison.OrdinalIgnoreCase));
                        if (modelTestFilePath == null)
                        {
                            var modelTestTypeName = type.Name + "Test";
                            modelTestFilePath = Path.Combine(testProjectDirectory, modelTestTypeName + ".cs");
                            var modelTestFileHeader = fileHeaderBuilder(modelTestTypeName);
                            var modelTestFileContents = GenerateModelTestFileContents(modelTestFileHeader, testNamespace, modelTestTypeName);

                            File.WriteAllText(modelTestFilePath, modelTestFileContents);
                        }

                        var modelTestDesignerFilePath = modelTestFilePath.Replace(".cs", ".designer.cs");
                        File.WriteAllText(modelTestDesignerFilePath, modelTestDesignerFileContents);
                    }
                }
            }

            if (hasTestProject && dummyFactorySnippets.Any())
            {
                var dummyFactoryFilePath = allTestProjectSourceFiles.SingleOrDefault(_ => !_.Contains(".recipes") && _.EndsWith("DummyFactory.cs", StringComparison.OrdinalIgnoreCase))
                                        ?? Path.Combine(testProjectDirectory, "DummyFactory.cs");

                var dummyFactoryDesignerFilePath = dummyFactoryFilePath.Replace(".cs", ".designer.cs");

                var dummyFactoryTypeName = Path.GetFileName(dummyFactoryFilePath).Replace(".cs", string.Empty);
                if (!File.Exists(dummyFactoryFilePath))
                {
                    var dummyFactoryFileHeader = fileHeaderBuilder(dummyFactoryTypeName);
                    var dummyFactoryFileContents = GenerateDummyFactoryFileContents(dummyFactoryFileHeader, testNamespace, dummyFactoryTypeName);
                    File.WriteAllText(dummyFactoryFilePath, dummyFactoryFileContents);
                }

                var dummyFactoryDesignerFileContents = GenerateDummyFactoryDesignerFileContents(
                    testNamespace,
                    dummyFactoryTypeName,
                    dummyFactorySnippets);

                File.WriteAllText(dummyFactoryDesignerFilePath, dummyFactoryDesignerFileContents);

                var dummyFactoryTestTypeName = dummyFactoryTypeName + "Test";
                var dummyFactoryTestFilePath = allTestProjectSourceFiles.SingleOrDefault(_ => _.EndsWith(dummyFactoryTypeName + "Test.cs", StringComparison.OrdinalIgnoreCase))
                                            ?? Path.Combine(testProjectDirectory, dummyFactoryTestTypeName + ".cs");
                var dummyFactoryTestDesignerFilePath = dummyFactoryTestFilePath.Replace(".cs", ".designer.cs");
                if (!File.Exists(dummyFactoryTestFilePath))
                {
                    var dummyFactoryTestFileHeader = fileHeaderBuilder(dummyFactoryTestTypeName);
                    var dummyFactoryTestFileContents = GenerateDummyFactoryTestFileContents(dummyFactoryTestFileHeader, testNamespace, dummyFactoryTestTypeName);
                    File.WriteAllText(dummyFactoryTestFilePath, dummyFactoryTestFileContents);
                }

                var dummyFactoryTestDesignerFileContents = GenerateDummyFactoryTestDesignerFileContents(testNamespace, dummyFactoryTestTypeName, dummyFactoryTypeName);
                File.WriteAllText(dummyFactoryTestDesignerFilePath, dummyFactoryTestDesignerFileContents);
            }
        }

        private static string GenerateDummyFactoryFileContents(
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
                                         + "    using System.Diagnostics.CodeAnalysis;"
                                         + Environment.NewLine
                                         + "    using System.Linq;"
                                         + Environment.NewLine
                                         + "    using FakeItEasy;"
                                         + Environment.NewLine
                                         + "    using OBeautifulCode.AutoFakeItEasy;"
                                         + Environment.NewLine
                                         + Environment.NewLine
                                         + "    public class "
                                         + typeName
                                         + " : Default"
                                         + typeName
                                         + Environment.NewLine
                                         + "    {"
                                         + Environment.NewLine
                                         + "        public Default" + typeName + "()"
                                         + Environment.NewLine
                                         + "        {"
                                         + Environment.NewLine
                                         + "            /* Add any overriding or custom registrations here. */"
                                         + Environment.NewLine
                                         + "        }"
                                         + Environment.NewLine
                                         + "    }"
                                         + Environment.NewLine
                                         + "}";

            return dummyFactoryFileContents;
        }

        private static string GenerateDummyFactoryDesignerFileContents(
            string typeNamespace,
            string typeName,
            List<string> dummyFactorySnippets)
        {
            var autoGenerateHeader =
                "// --------------------------------------------------------------------------------------------------------------------"
              + Environment.NewLine
              + "// <auto-generated>"
              + Environment.NewLine
              + "//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)"
              + Environment.NewLine
              + "// </auto-generated>"
              + Environment.NewLine
              + "// --------------------------------------------------------------------------------------------------------------------";

            var contents = autoGenerateHeader
                         + Environment.NewLine
                         + "namespace "
                         + typeNamespace
                         + Environment.NewLine
                         + "{"
                         + Environment.NewLine
                         + "    using System;"
                         + Environment.NewLine
                         + "    using System.Diagnostics.CodeAnalysis;"
                         + Environment.NewLine
                         + "    using System.Linq;"
                         + Environment.NewLine
                         + "    using FakeItEasy;"
                         + Environment.NewLine
                         + "    using OBeautifulCode.AutoFakeItEasy;"
                         + Environment.NewLine
                         + Environment.NewLine
                         + "    public abstract class Default" + typeName + " : IDummyFactory"
                         + Environment.NewLine
                         + "    {"
                         + Environment.NewLine
                         + "        public Default" + typeName + "()"
                         + Environment.NewLine
                         + "        {"
                         + dummyFactorySnippets.ToDelimitedString(Environment.NewLine + Environment.NewLine + "        ")
                         + Environment.NewLine
                         + "        }"
                         + Environment.NewLine
                         + Environment.NewLine
                         + "        /// <inheritdoc />"
                         + Environment.NewLine
                         + "        public Priority Priority => new FakeItEasy.Priority(1);"
                         + Environment.NewLine
                         + Environment.NewLine
                         + "        /// <inheritdoc />"
                         + Environment.NewLine
                         + "        public bool CanCreate(Type type)"
                         + Environment.NewLine
                         + "        {"
                         + Environment.NewLine
                         + "            return false;"
                         + Environment.NewLine
                         + "        }"
                         + Environment.NewLine
                         + Environment.NewLine
                         + "        /// <inheritdoc />"
                         + Environment.NewLine
                         + "        public object Create(Type type)"
                         + Environment.NewLine
                         + "        {"
                         + Environment.NewLine
                         + "            return null;"
                         + Environment.NewLine
                         + "        }"
                         + Environment.NewLine
                         + "    }"
                         + Environment.NewLine
                         + "}";

            return contents;
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
                                         + "    using System.Diagnostics.CodeAnalysis;"
                                         + Environment.NewLine
                                         + "    using System.Linq;"
                                         + Environment.NewLine
                                         + "    using FakeItEasy;"
                                         + Environment.NewLine
                                         + "    using OBeautifulCode.AutoFakeItEasy;"
                                         + Environment.NewLine
                                         + Environment.NewLine
                                         + "    public partial class "
                                         + typeName
                                         + Environment.NewLine
                                         + "    {"
                                         + Environment.NewLine
                                         + "    }"
                                         + Environment.NewLine
                                         + "}";

            return dummyFactoryFileContents;
        }

        private static string GenerateDummyFactoryTestDesignerFileContents(
            string typeNamespace,
            string dummyFactoryTestTypeName,
            string dummyFactoryTypeName)
        {
            var autoGenerateHeader =
                "// --------------------------------------------------------------------------------------------------------------------"
              + Environment.NewLine
              + "// <auto-generated>"
              + Environment.NewLine
              + "//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)"
              + Environment.NewLine
              + "// </auto-generated>"
              + Environment.NewLine
              + "// --------------------------------------------------------------------------------------------------------------------";

            var contents = autoGenerateHeader
                         + Environment.NewLine
                         + Environment.NewLine
                         + "namespace "
                         + typeNamespace
                         + Environment.NewLine
                         + "{"
                         + Environment.NewLine
                         + "    using System;"
                         + Environment.NewLine
                         + "    using System.Diagnostics.CodeAnalysis;"
                         + Environment.NewLine
                         + "    using OBeautifulCode.Assertion.Recipes ;"
                         + Environment.NewLine
                         + "    using FakeItEasy;"
                         + Environment.NewLine
                         + "    using Xunit;"
                         + Environment.NewLine
                         + Environment.NewLine
                         + "    public partial class " + dummyFactoryTestTypeName
                         + Environment.NewLine
                         + "    {"
                         + Environment.NewLine
                         + "        [Fact]"
                         + Environment.NewLine
                         + "        public void ConfirmDummyFactorDerivesFromDesigner()"
                         + Environment.NewLine
                         + "        {"
                         + Environment.NewLine
                         + "            typeof(Default" + dummyFactoryTypeName + ").GetInterface(nameof(IDummyFactory)).AsTest().Must().NotBeNull();"
                         + Environment.NewLine
                         + "            typeof(" + dummyFactoryTypeName + ").BaseType.AsTest().Must().BeEqualTo(typeof(Default" + dummyFactoryTypeName + "));"
                         + Environment.NewLine
                         + "        }"
                         + Environment.NewLine
                         + "    }"
                         + Environment.NewLine
                         + "}";

            return contents;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        private static Func<string, string> GetFileHeaderBuilder(
            string projectDirectory)
        {
            var packagesDirectoryPath = Path.Combine(projectDirectory, "../packages");
            var projectDirectoryName = new DirectoryInfo(projectDirectory).Name;
            var buildPackagePrefix = projectDirectoryName.Split('.').FirstOrDefault();
            var buildAnalyzerPackageName = buildPackagePrefix == null ? null : buildPackagePrefix + ".Build.Analyzers";
            var analyzerCandidates = buildAnalyzerPackageName == null
                ? null
                : Directory.GetDirectories(packagesDirectoryPath, buildAnalyzerPackageName + "*", SearchOption.TopDirectoryOnly);
            var analyzerPackageDirectory = analyzerCandidates == null ? null : analyzerCandidates.OrderByDescending(_ => _).FirstOrDefault();
            var styleCopJsonFilePath =
                analyzerPackageDirectory == null ? null : Path.Combine(analyzerPackageDirectory, "analyzers/stylecop.json");
            string fileHeader = null;
            if (styleCopJsonFilePath == null || !File.Exists(styleCopJsonFilePath))
            {
                return typeName => string.Empty;
            }

            var styleCopJsonContents = File.ReadAllText(styleCopJsonFilePath);
            dynamic styleCopJson = JObject.Parse(styleCopJsonContents);
            var companyName = styleCopJson.settings.documentationRules.companyName.ToString();
            var copyrightText = styleCopJson.settings.documentationRules.copyrightText.ToString().Replace("{companyName}", companyName);

            return typeName =>
            {
                fileHeader =
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
            };
        }

        [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadFrom", Justification = "Required to achieve desired functionality.")]
        private static IReadOnlyCollection<Type> ShadowCopyAssembliesLoadAndGetTypesToCheck(
            string projectDirectory,
            string tempDirectoryRootPath)
        {
            var tempDirectoryName = TempDirectoryPrefix + DateTime.UtcNow.ToString("yyyyMMddTHHmmssZ", CultureInfo.InvariantCulture);
            var tempDirectoryPath = tempDirectoryRootPath + tempDirectoryName;

            if (!Directory.Exists(tempDirectoryPath))
            {
                Directory.CreateDirectory(tempDirectoryPath);
            }

            var projectBinDebugFiles = GetProjectBinDebugFiles(projectDirectory);
            var assembliesToLoad = new List<string>();
            foreach (var fileToConsiderLoading in projectBinDebugFiles)
            {
                if (fileToConsiderLoading.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) || fileToConsiderLoading.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) || fileToConsiderLoading.EndsWith(".pdb", StringComparison.OrdinalIgnoreCase))
                {
                    var fileName = Path.GetFileName(fileToConsiderLoading);
                    var newFilePath = Path.Combine(tempDirectoryPath, fileName);
                    File.Copy(fileToConsiderLoading, newFilePath);

                    if (!newFilePath.EndsWith(".pdb", StringComparison.OrdinalIgnoreCase))
                    {
                        assembliesToLoad.Add(newFilePath);
                    }
                }
            }

            foreach (var assemblyToLoad in assembliesToLoad)
            {
                Assembly.LoadFrom(assemblyToLoad);
            }

            var loadedAssemblies = AssemblyLoader.GetLoadedAssemblies();
            loadedAssemblies.ToList().ForEach(_ => Console.WriteLine(_.CodeBase));
            var typesToCheck = loadedAssemblies
                              .Where(_ => _.CodeBase.Contains(tempDirectoryName))
                              .ToList()
                              .GetTypesFromAssemblies();
            return typesToCheck;
        }

        private static string GenerateModelTestFileContents(
            string fileHeader,
            string typeNamespace,
            string typeName)
        {
            var modelTestFileContents = fileHeader
                                 + Environment.NewLine
                                 + Environment.NewLine
                                 + "namespace " + typeNamespace
                                 + Environment.NewLine
                                  + "{"
                                 + Environment.NewLine
                                 + "    public partial class "
                                 + typeName
                                 + Environment.NewLine
                                 + "    {"
                                 + Environment.NewLine
                                 + "    }"
                                 + Environment.NewLine
                                 + "}";

            return modelTestFileContents;
        }

        private static string[] GetProjectBinDebugFiles(
            string projectDirectory)
        {
            var binDebugPath = Path.Combine(projectDirectory, "bin\\debug");

            if (!Directory.Exists(binDebugPath))
            {
                throw new InvalidOperationException("Could not find bin/debug directory (check build): " + binDebugPath);
            }

            var projectBinDebugFiles = Directory.GetFiles(binDebugPath);
            if (projectBinDebugFiles.Length == 0)
            {
                throw new InvalidOperationException("Could not find any files in bin/debug directory (check build): " + binDebugPath);
            }

            return projectBinDebugFiles;
        }

        private static void RemoveTempFilesFromPreviousRuns(
            string tempDirectoryRootPath,
            string tempDirectoryPrefix)
        {
            var priorTempDirectories = Directory.GetDirectories(tempDirectoryRootPath, tempDirectoryPrefix + "*");
            foreach (var priorTempDirectory in priorTempDirectories)
            {
                try
                {
                    Directory.Delete(priorTempDirectory, true);
                }
                catch (Exception)
                {
                    // nothing we can do here because these are locked we will just try and remove via eventual consistency.
                }
            }
        }
    }
}
