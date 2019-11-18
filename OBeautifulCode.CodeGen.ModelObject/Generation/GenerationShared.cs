// --------------------------------------------------------------------------------------------------------------------
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

            type.ThrowIfNotSupported();

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
        /// Generates a FluentAssertions equality statement.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="expected">The expected value.</param>
        /// <returns>
        /// Generated FluentAssertions equality statement.
        /// </returns>
        public static string GenerateFluentAssertionsEqualityStatement(
            this Type type,
            string actual,
            string expected)
        {
            // NOTE: doesn't handle arrays - need to fix up
            var result = Invariant($"{actual}.Should().{(type.IsSystemDictionaryType() || type.IsSystemCollectionType() ? "Equal" : "Be")}({expected});");

            return result;
        }
    }
}