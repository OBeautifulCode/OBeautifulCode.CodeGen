// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InnerModel.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Validation.Recipes;

    public partial class InnerModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InnerModel"/> class.
        /// </summary>
        /// <param name="booleanProperty">The boolean value.</param>
        /// <param name="integerProperty">The integer value.</param>
        /// <param name="stringProperty">The string value.</param>
        /// <param name="readOnlyDictionaryOfStringString">The dictionary of string/string value.</param>
        /// <param name="readOnlyCollectionOfString">The read only collection of string value.</param>
        public InnerModel(
            bool booleanProperty,
            int integerProperty,
            string stringProperty,
            IReadOnlyDictionary<string, string> readOnlyDictionaryOfStringString,
            IReadOnlyCollection<string> readOnlyCollectionOfString)
        {
            new { stringProperty }.Must().NotBeNullNorWhiteSpace();
            new { readOnlyDictionaryOfStringString }.Must().NotBeNull();
            new { readOnlyCollectionOfString }.Must().NotBeNull();

            this.BooleanProperty = booleanProperty;
            this.IntegerProperty = integerProperty;
            this.StringProperty = stringProperty;
            this.ReadOnlyDictionaryOfStringString = readOnlyDictionaryOfStringString;
            this.ReadOnlyCollectionOfString = readOnlyCollectionOfString;
        }

        /// <summary>
        /// Gets a value indicating whether the boolean is true or false.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "integer", Justification = "Name/spelling is correct.")]
        public bool BooleanProperty { get; }

        /// <summary>
        /// Gets the integer.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "integer", Justification = "Name/spelling is correct.")]
        public int IntegerProperty { get; }

        /// <summary>
        /// Gets the string.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "integer", Justification = "Name/spelling is correct.")]
        public string StringProperty { get; }

        /// <summary>
        /// Gets the dictionary of string/string.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "integer", Justification = "Name/spelling is correct.")]
        public IReadOnlyDictionary<string, string> ReadOnlyDictionaryOfStringString { get; }

        /// <summary>
        /// Gets the read-only collection of string.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "integer", Justification = "Name/spelling is correct.")]
        public IReadOnlyCollection<string> ReadOnlyCollectionOfString { get; }
    }
}
