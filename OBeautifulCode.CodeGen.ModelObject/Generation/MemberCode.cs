// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MemberCode.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Represents the code for a member.
    /// </summary>
    internal class MemberCode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberCode"/> class.
        /// </summary>
        /// <param name="name">The member name.</param>
        /// <param name="code">The code for the member.</param>
        public MemberCode(
            string name,
            string code)
        {
            new { name }.AsArg().Must().NotBeNullNorWhiteSpace();
            new { sourceCode = code }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Name = name;

            this.Code = code;
        }

        /// <summary>
        /// Gets the property name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the source code for the property.
        /// </summary>
        public string Code { get; }
    }
}
