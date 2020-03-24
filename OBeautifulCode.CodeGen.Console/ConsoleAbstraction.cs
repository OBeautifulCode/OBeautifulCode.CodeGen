// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleAbstraction.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.Console
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;

    using CLAP;

    using OBeautifulCode.Bootstrapper.Recipes;
    using OBeautifulCode.CodeGen.Console.Internal;

    /// <inheritdoc />
    [SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = ObcSuppressBecause.CA1812_AvoidUninstantiatedInternalClasses_ClassIsWiredIntoClapInProgramCs)]
    internal class ConsoleAbstraction : ConsoleAbstractionBase
    {
        /// <summary>
        /// Generate logic for models.
        /// </summary>
        /// <param name="debug">Optional indication to launch the debugger from inside the application (default is false).</param>
        /// <param name="projectDirectory">Directory of the project to work on.</param>
        /// <param name="testProjectDirectory">Directory of the test project associated with the project to work on.</param>
        /// <param name="projectOutputDirectory">Directory where project outputs built files (e.g. ...\\bin\\debug\\).</param>
        /// <param name="includeSerializationTesting">Optional value indicating whether to include serialization testing (default is true).</param>
        [Verb(Aliases = "model", IsDefault = false, Description = "Runs the generation logic for specified project.")]
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = ObcSuppressBecause.CA1811_AvoidUncalledPrivateCode_MethodIsWiredIntoClapAsVerb)]
        public static void Model(
            [Aliases("")] [Description("Launches the debugger.")] [DefaultValue(false)] bool debug,
            [Aliases("")] [Required] [Description("Directory of the project to work on.")] string projectDirectory,
            [Aliases("")] [Required] [Description("Directory of the test project associated with the project to work on.")] string testProjectDirectory,
            [Aliases("")] [Required] [Description("Directory where project outputs built files (e.g. ...\\bin\\debug\\).")] string projectOutputDirectory,
            [Aliases("")] [Description("Indicates whether to include serialization testing.")] [DefaultValue(true)] bool includeSerializationTesting)
        {
            if (debug)
            {
                Debugger.Launch();
            }

            ProjectCodeGenerator.GenerateCodeForProject(projectDirectory, testProjectDirectory, projectOutputDirectory, includeSerializationTesting);
        }
    }
}
