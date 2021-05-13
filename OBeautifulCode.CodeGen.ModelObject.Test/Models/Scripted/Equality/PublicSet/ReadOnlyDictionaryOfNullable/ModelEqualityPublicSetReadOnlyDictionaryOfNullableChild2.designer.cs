﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;

    using global::OBeautifulCode.Cloning.Recipes;
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class ModelEqualityPublicSetReadOnlyDictionaryOfNullableChild2 : IEquatable<ModelEqualityPublicSetReadOnlyDictionaryOfNullableChild2>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ModelEqualityPublicSetReadOnlyDictionaryOfNullableChild2"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ModelEqualityPublicSetReadOnlyDictionaryOfNullableChild2 left, ModelEqualityPublicSetReadOnlyDictionaryOfNullableChild2 right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals(right);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref="ModelEqualityPublicSetReadOnlyDictionaryOfNullableChild2"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ModelEqualityPublicSetReadOnlyDictionaryOfNullableChild2 left, ModelEqualityPublicSetReadOnlyDictionaryOfNullableChild2 right) => !(left == right);

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ModelEqualityPublicSetReadOnlyDictionaryOfNullableChild2);
    }
}