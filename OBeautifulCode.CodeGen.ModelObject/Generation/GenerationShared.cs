﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenerationShared.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Reflection.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Shared methods for generation.
    /// </summary>
    internal static class GenerationShared
    {
        /// <summary>
        /// Throws if the specified type is not supported for code gen.
        /// </summary>
        /// <param name="type">The type.</param>
        public static void ThrowIfNotSupported(
            this Type type)
        {
            new { type }.AsArg().Must().NotBeNull();

            // checks if not a class - but still could be a delegate, or a type parameter in the definition of a generic type or generic method.
            if (!type.IsClass)
            {
                throw new NotSupportedException(Invariant($"This type is not supported; it is a value type or interface type: {type}."));
            }

            // check that it's not a delegate
            if (type.IsSubclassOf(typeof(Delegate)))
            {
                throw new NotSupportedException(Invariant($"This type is not supported; it is a delegate: {type}."));
            }

            // check that the type is not a type generic type parameter
            if (type.IsGenericParameter)
            {
                throw new NotSupportedException(Invariant($"This type is not supported; it is a generic parameter: {type}."));
            }

            if (type.IsConstructedGenericType)
            {
                throw new NotSupportedException(Invariant($"This type is not supported; it is a constructed generic type: {type}."));
            }

            if (type.IsGenericType)
            {
                throw new NotSupportedException(Invariant($"This type is not supported; it is a generic type: {type}."));
            }

            var allTypes = AssemblyLoader.GetLoadedAssemblies().GetTypesFromAssemblies();

            var inheritedTypes = allTypes.Where(_ => (_ != type) && (_.BaseType == type)).ToList();

            if (type.InheritFromObject())
            {
                if (inheritedTypes.Any() && (!type.IsAbstract))
                {
                    throw new NotSupportedException(Invariant($"This type is not supported; base classes must be abstract: {type}."));
                }
            }
            else
            {
                if (type.IsAbstract)
                {
                    throw new NotSupportedException(Invariant($"This type is not supported; inherited classes cannot be abstract: {type}."));
                }

                if (inheritedTypes.Any())
                {
                    throw new NotSupportedException(Invariant($"This type is not supported; inherited classes cannot also be base classes: {type}."));
                }
            }

            if (type.ContainsDictionaryKeyedOnDateTime())
            {
                throw new NotSupportedException(Invariant($"This type contains a property that is OR has within its generic argument tree a Dictionary that is keyed on DateTime; IsEqualTo may do the wrong thing when comparing the keys of two such dictionaries (because it uses dictionary's embedded equality comparer, which is most likely the default comparer, which determines two DateTimes to be equal if they have the same Ticks, regardless of whether they have the same Kind)': {type}."));
            }
        }

        /// <summary>
        /// Determines how a user-defined class participates in a hierarchy.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>A value indicating how a user-defined class participates in a hierarchy.</returns>
        public static HierarchyKind GetHierarchyKind(
            this Type type)
        {
            new { type }.AsArg().Must().NotBeNull();

            HierarchyKind result;
            if (type.IsAbstract)
            {
                result = HierarchyKind.AbstractBase;
            }
            else if (type.InheritFromObject())
            {
                result = HierarchyKind.None;
            }
            else
            {
                result = HierarchyKind.ConcreteInherited;
            }

            return result;
        }

        /// <summary>
        /// Determines if the specified type inherits from <see cref="object"/>.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>true if the type inherits from object, otherwise false.</returns>
        public static bool InheritFromObject(
            this Type type)
        {
            new { type }.AsArg().Must().NotBeNull();

            var result = type.BaseType == typeof(object);

            return result;
        }

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
        /// Gets the properties of concern from a type.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <param name="declaredOnly">Optional value indicating whether only declared members should be included (i.e. ignore inherited members).  Default is false; inherited members will be included.</param>
        /// <returns>
        /// The properties of concern for the specified type.
        /// </returns>
        public static IReadOnlyList<PropertyInfo> GetPropertiesOfConcernFromType(
            this Type type,
            bool declaredOnly = false)
        {
            type.AsArg(nameof(type)).Must().NotBeNull();

            var bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty;

            IReadOnlyList<PropertyInfo> result;

            var hierarchyKind = type.GetHierarchyKind();

            if ((hierarchyKind == HierarchyKind.ConcreteInherited) && (!declaredOnly))
            {
                // this is an effort to get base type properties to appear before this type's properties
                var properties = type.GetProperties(bindingFlags);

                // ReSharper disable once PossibleNullReferenceException
                var baseTypeProperties = type.BaseType.GetProperties(bindingFlags);

                var baseTypePropertyNames = new HashSet<string>(baseTypeProperties.Select(_ => _.Name));

                result = baseTypeProperties.Concat(properties.Where(p => !baseTypePropertyNames.Contains(p.Name))).ToList();
            }
            else
            {
                bindingFlags = bindingFlags | BindingFlags.DeclaredOnly;

                result = type.GetProperties(bindingFlags);
            }

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
        /// Determines if the model type contains a dictionary keyed on DateTime.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// true if the model type contains a dictionary keyed on DateTime, otherwise false.
        /// </returns>
        public static bool ContainsDictionaryKeyedOnDateTime(
            this Type type)
        {
            var properties = type.GetPropertiesOfConcernFromType();

            var result = properties.Any(_ => _.PropertyType.IsOrContainsDictionaryKeyedOnDateTime());

            return result;
        }

        /// <summary>
        /// Determines if two dummies of the specified type can not be equal but
        /// result in the same hash code.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// true if two dummies can be created of the specified type, not be equal, but
        /// result in the same hash code, otherwise false.
        /// </returns>
        public static bool CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode(
            this Type type)
        {
            var properties = type.GetPropertiesOfConcernFromType();

            var result = properties.Any(_ => _.PropertyType.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal());

            return result;
        }

        private static bool IsOrContainsDictionaryKeyedOnDateTime(
            this Type type)
        {
            if (type.IsSystemDictionaryType())
            {
                var keyType = type.GenericTypeArguments.First();

                if ((keyType == typeof(DateTime)) || (keyType == typeof(DateTime?)))
                {
                    return true;
                }
            }

            if (type.IsGenericType)
            {
                var genericTypeArguments = type.GenericTypeArguments;

                if (genericTypeArguments.Any(_ => _.IsAssignableTo(typeof(IModel)) ? _.ContainsDictionaryKeyedOnDateTime() : _.IsOrContainsDictionaryKeyedOnDateTime()))
                {
                    return true;
                }
            }

            if (type.IsAssignableTo(typeof(IModel)))
            {
                if (type.ContainsDictionaryKeyedOnDateTime())
                {
                    return true;
                }
            }

            return false;
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

                if (genericTypeArguments.Any(_ => _.IsAssignableTo(typeof(IModel)) ? _.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode() : _.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal()))
                {
                    return true;
                }
            }

            if (type.IsAssignableTo(typeof(IModel)))
            {
                if (type.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode())
                {
                    return true;
                }
            }

            return false;
        }
    }
}