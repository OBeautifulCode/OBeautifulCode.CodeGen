// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenerationShared.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;

    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Shared methods for generation.
    /// </summary>
    internal static class GenerationShared
    {
        /// <summary>
        /// Gets the Code Gen assembly name.
        /// </summary>
        /// <returns>
        /// The Code Gen assembly name.
        /// </returns>
        public static string GetCodeGenAssemblyName()
        {
            var result = typeof(GenerationShared).Assembly.GetName().Name;

            return result;
        }

        /// <summary>
        /// Gets the Code Gen assembly version.
        /// </summary>
        /// <returns>
        /// The Code Gen assembly version.
        /// </returns>
        public static string GetCodeGenAssemblyVersion()
        {
            var result = typeof(GenerationShared).Assembly.GetName().Version.ToString();

            return result;
        }

        /// <summary>
        /// Generates an assertion equality statement.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="expected">The expected value.</param>
        /// <param name="sameReferenceExpected">A value indicating whether the same reference expected for reference types.</param>
        /// <returns>
        /// Generated assertion equality statement.
        /// </returns>
        public static string GenerateObcAssertionsEqualityStatement(
            this Type type,
            string actual,
            string expected,
            bool sameReferenceExpected)
        {
            string result;

            if ((!type.IsValueType) && sameReferenceExpected)
            {
                result = Invariant($"{actual}.AsTest().Must().BeSameReferenceAs({expected});");
            }
            else
            {
                result = Invariant($"{actual}.AsTest().Must().BeEqualTo({expected});");
            }

            return result;
        }

        /// <summary>
        /// Determines if two dummies of the specified type can not be equal but
        /// result in the same hash code.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// true if two dummies can be created of the specified type, not be equal, but
        /// result in the same hash code, otherwise false.
        /// </returns>
        public static bool CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode(
            this ModelType modelType)
        {
            var result = modelType.PropertiesOfConcern.Any(_ => _.PropertyType.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal());

            return result;
        }

        /// <summary>
        /// Determines if the specified type is a model type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        /// true if the specified type is a model type, otherwise false.
        /// </returns>
        public static bool IsModelType(
            this Type type)
        {
            var result = type.IsAssignableTo(typeof(IModel)) || type.IsAssignableTo(typeof(IModelViaCodeGen));

            return result;
        }

        private static bool CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(
            this Type type)
        {
            // see scenarios in HashCodeHelper where we are forced to hash the
            // enumerable count instead of the elements.
            if (type.IsSystemDictionaryType())
            {
                var keyType = type.GenericTypeArguments.First();

                if (!keyType.IsComparableType())
                {
                    return true;
                }
            }

            if (type.IsSystemUnorderedCollectionType())
            {
                var elementType = type.GenericTypeArguments.First();

                if (!elementType.IsComparableType())
                {
                    return true;
                }
            }

            if (type.IsGenericType)
            {
                var genericTypeArguments = type.GenericTypeArguments;

                if (genericTypeArguments.Any(_ => _.IsModelType() ? new ModelType(_).CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode() : _.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal()))
                {
                    return true;
                }
            }

            if (type.IsModelType())
            {
                var modelType = new ModelType(type);

                if (modelType.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode())
                {
                    return true;
                }
            }

            return false;
        }
    }
}