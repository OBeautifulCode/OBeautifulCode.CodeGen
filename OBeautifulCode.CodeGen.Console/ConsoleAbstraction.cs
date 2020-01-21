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
        /// Does some work.
        /// </summary>
        /// <param name="debug">Optional value indicating whether to launch the debugger from inside the application (default is false).</param>
        /// <param name="requiredParameter">A required parameter to the operation.</param>
        [Verb(Aliases = "do", IsDefault = false, Description = "Does some work.")]
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = ObcSuppressBecause.CA1811_AvoidUncalledPrivateCode_MethodIsWiredIntoClapAsVerb)]
        public static void DoSomeWork(
            [Aliases("")] [Description("Launches the debugger.")] [DefaultValue(false)] bool debug,
            [Aliases("")] [Required] [Description("A required parameter to the operation.")] string requiredParameter)
        {
            if (debug)
            {
                Debugger.Launch();
            }

            System.Console.WriteLine(requiredParameter);
        }
    }
}
