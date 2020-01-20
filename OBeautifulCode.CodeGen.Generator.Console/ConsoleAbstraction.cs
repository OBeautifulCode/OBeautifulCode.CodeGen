// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleAbstraction.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.Generator.Console
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using CLAP;
    using Newtonsoft.Json.Linq;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Reflection.Recipes;
    using OBeautifulCode.Representation.System;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;
    using static System.FormattableString;

    /// <summary>
    /// Instance for use in CLAP.
    /// </summary>
    public class ConsoleAbstraction
    {
        private static readonly string TempDirectoryPrefix = "OBC.CodeGen";

        /// <summary>
        /// Gets the exception type descriptions to only print message.
        /// </summary>
        /// <value>The exception type descriptions to only print message.</value>
        public static TypeRepresentation[] ExceptionTypeDescriptionsToOnlyPrintMessage => null;

        /// <summary>
        /// Generate logic for models.
        /// </summary>
        /// <param name="debug">Optional indication to launch the debugger from inside the application (default is false).</param>
        /// <param name="projectDirectory">Directory of the project to work on.</param>
        /// <param name="testProjectDirectory">Directory of the test project associated with the project to work on.</param>
        [Verb(Aliases = "model", IsDefault = false, Description = "Runs the generation logic for specified project.")]
        public static void Model(
            [Aliases("")] [Description("Launches the debugger.")] [DefaultValue(false)] bool debug,
            [Aliases("")] [Required] [Description("Directory of the project to work on.")] string projectDirectory,
            [Aliases("")] [Required] [Description("Directory of the test project associated with the project to work on.")] string testProjectDirectory)
        {
            if (debug)
            {
                Debugger.Launch();
            }

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
                if (type.GetInterface(nameof(IModelViaCodeGen)) != null)
                {
                    var modelDesignerFileContents = type.GenerateForModel(GenerateFor.ModelImplementationPartialClass);
                    var modelTestDesignerFileContents = type.GenerateForModel(GenerateFor.ModelImplementationTestsPartialClassWithSerialization);
                    var dummyFactorySnippet = type.GenerateForModel(GenerateFor.ModelDummyFactorySnippet);

                    // find file
                    var modelFilePath = allProjectSourceFiles.SingleOrDefault(_ => _.EndsWith(type.Name + ".cs"));
                    if (modelFilePath == null)
                    {
                        throw new FileNotFoundException("Expected a source file for type: " + type.ToStringReadable());
                    }

                    var modelDesignerFilePath = modelFilePath.Replace(".cs", ".designer.cs");

                    File.WriteAllText(modelDesignerFilePath, modelDesignerFileContents, Encoding.UTF8);

                    if (hasTestProject)
                    {
                        dummyFactorySnippets.Add(dummyFactorySnippet);
                        var modelTestFilePath = allTestProjectSourceFiles.SingleOrDefault(_ => _.EndsWith(type.Name + "Test.cs"));
                        if (modelTestFilePath == null)
                        {
                            var modelTestTypeName = type.Name + "Test";
                            modelTestFilePath = Path.Combine(testProjectDirectory, modelTestTypeName + ".cs");
                            var modelTestFileHeader   = fileHeaderBuilder(modelTestTypeName);
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
                var dummyFactoryFilePath = allTestProjectSourceFiles.SingleOrDefault(_ => !_.Contains(".recipes") && _.EndsWith("DummyFactory.cs"))
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
                var dummyFactoryTestFilePath = allTestProjectSourceFiles.SingleOrDefault(_ => _.EndsWith(dummyFactoryTypeName + "Test.cs"))
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

        /// <summary>
        /// Error method to call from CLAP; a 1 will be returned as the exit code if this is entered since an exception was thrown.
        /// </summary>
        /// <param name="context">Context provided with details.</param>
        [Error]
#pragma warning disable CS3001 // Argument type is not CLS-compliant - needed for CLAP
        public static void Error(ExceptionContext context)
#pragma warning restore CS3001 // Argument type is not CLS-compliant
        {
            new { context }.Must().NotBeNull();
            var typeDescriptionComparer = new TypeComparer(TypeMatchStrategy.NamespaceAndName);

            // change color to red
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            // parser exception or
            if (context.Exception is CommandLineParserException)
            {
                Console.WriteLine("Failure parsing command line arguments.  Run the exe with the 'help' command for usage.");
                Console.WriteLine("   " + context.Exception.Message);
            }
            else if ((ExceptionTypeDescriptionsToOnlyPrintMessage ?? new TypeRepresentation[0]).Any(_ => typeDescriptionComparer.Equals(_, context.Exception.GetType().ToRepresentation())))
            {
                Console.WriteLine("Failure during execution; configured to omit stack trace.");
                Console.WriteLine(string.Empty);
                Console.WriteLine("   " + context.Exception.Message);
            }
            else
            {
                Console.WriteLine("Failure during execution.");
                Console.WriteLine("   " + context.Exception.Message);
                Console.WriteLine(string.Empty);
                Console.WriteLine("   " + context.Exception);
            }

            // restore color
            Console.WriteLine();
            Console.ForegroundColor = originalColor;
        }

        /// <summary>
        /// Help method to call from CLAP.
        /// </summary>
        /// <param name="helpText">Generated help text to display.</param>
        [Empty]
        [Help(Aliases = "h,?,-h,-help")]
        [Verb(Aliases = "Help", IsDefault = true)]
        public static void ShowUsage(string helpText)
        {
            new { helpText }.Must().NotBeNull();

            Console.WriteLine("   Usage");
            Console.Write("   -----");

            // strip out the usage info about help, it's confusing
            helpText = helpText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Skip(3).ToNewLineDelimited();
            Console.WriteLine(helpText);
            Console.WriteLine();
        }

        private static string GenerateDummyFactoryFileContents(
            string fileHeader,
            string typeNamespace,
            string typeName)
        {
            var dummyFactoryFileContents = fileHeader
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

        private static Func<string, string> GetFileHeaderBuilder(
            string projectDirectory)
        {
            var packagesDirectoryPath    = Path.Combine(projectDirectory, "../packages");
            var projectDirectoryName     = new DirectoryInfo(projectDirectory).Name;
            var buildPackagePrefix       = projectDirectoryName.Split('.').FirstOrDefault();
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

            var     styleCopJsonContents = File.ReadAllText(styleCopJsonFilePath);
            dynamic styleCopJson         = JObject.Parse(styleCopJsonContents);
            var     companyName          = styleCopJson.settings.documentationRules.companyName.ToString();
            var     copyrightText        = styleCopJson.settings.documentationRules.copyrightText.ToString().Replace("{companyName}", companyName);

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

        private static IReadOnlyCollection<Type> ShadowCopyAssembliesLoadAndGetTypesToCheck(
            string projectDirectory,
            string tempDirectoryRootPath)
        {
            var tempDirectoryName = TempDirectoryPrefix   + DateTime.UtcNow.ToString("yyyyMMddTHHmmssZ");
            var tempDirectoryPath = tempDirectoryRootPath + tempDirectoryName;

            if (!Directory.Exists(tempDirectoryPath))
            {
                Directory.CreateDirectory(tempDirectoryPath);
            }

            var projectBinDebugFiles = GetProjectBinDebugFiles(projectDirectory);
            var assembliesToLoad     = new List<string>();
            foreach (var fileToConsiderLoading in projectBinDebugFiles)
            {
                if (fileToConsiderLoading.EndsWith(".exe") || fileToConsiderLoading.EndsWith(".dll") || fileToConsiderLoading.EndsWith(".pdb"))
                {
                    var fileName    = Path.GetFileName(fileToConsiderLoading);
                    var newFilePath = Path.Combine(tempDirectoryPath, fileName);
                    File.Copy(fileToConsiderLoading, newFilePath);

                    if (!newFilePath.EndsWith(".pdb"))
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