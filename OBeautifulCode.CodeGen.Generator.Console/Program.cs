// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.Generator.Console
{
    using System;
    using CLAP;

    /// <summary>
    /// Main console entry point class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main console entry point method; downstream is managed by CLAP.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns>Exit code; 0 for success and 1 for error.</returns>
        public static int Main(string[] args)
        {
            try
            {
                /*---------------------------------------------------------------------------*
                 * This is just a pass through to the CLAP implementation of the harness,    *
                 * it will parse the command line arguments and provide multiple entry       *
                 * points as configured.                                                     *
                 *---------------------------------------------------------------------------*/
                var exitCode = Parser.Run<ConsoleAbstraction>(args);
                return exitCode;
            }
            catch (Exception ex)
            {
                /*---------------------------------------------------------------------------*
                 * This should never be reached but is here as a last ditch effort to ensure *
                 * errors are not lost.                                                      *
                 *---------------------------------------------------------------------------*/
                Console.WriteLine(string.Empty);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(string.Empty);

                return 1;
            }
        }
    }
}
