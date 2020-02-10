// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PropertyOfConcern.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;

    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Represents a property on a model that should included in code generation.
    /// </summary>
    public class PropertyOfConcern
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyOfConcern"/> class.
        /// </summary>
        /// <param name="propertyType">The type of the property.</param>
        /// <param name="name">The name of the property.</param>
        /// <param name="declaringType">The declaring type.</param>
        /// <param name="isGetterOnly">A value indicating whether this is a getter-only property.</param>
        public PropertyOfConcern(
            Type propertyType,
            string name,
            Type declaringType,
            bool isGetterOnly)
        {
            new { propertyType }.Must().NotBeNull();
            new { name }.Must().NotBeNullNorWhiteSpace();
            new { declaringType }.Must().NotBeNull();

            this.PropertyType = propertyType;
            this.Name = name;
            this.DeclaringType = declaringType;
            this.IsGetterOnly = isGetterOnly;
        }

        /// <summary>
        /// Gets the type of the property.
        /// </summary>
        public Type PropertyType { get; }

        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the declaring type.
        /// </summary>
        public Type DeclaringType { get; }

        /// <summary>
        /// Gets a value indicating whether this is a getter-only property.
        /// </summary>
        public bool IsGetterOnly { get; }
    }
}
