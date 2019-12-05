// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelType.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.Reflection.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Represents a type that is a Model type.
    /// </summary>
    public class ModelType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelType"/> class.
        /// </summary>
        /// <param name="type">The model type.</param>
        public ModelType(
            Type type)
        {
            new { type }.AsArg().Must().NotBeNull();

            ThrowIfNotSupported(type);

            var hierarchyKind = GetHierarchyKind(type);
            var propertiesOfConcern = GetPropertiesOfConcernFromType(type, hierarchyKind, declaredOnly: false);
            var declaredOnlyPropertiesOfConcern = GetPropertiesOfConcernFromType(type, hierarchyKind, declaredOnly: true);

            ThrowIfNotSupported(type, propertiesOfConcern);

            this.Type = type;
            this.HierarchyKind = hierarchyKind;
            this.PropertiesOfConcern = propertiesOfConcern;
            this.DeclaredOnlyPropertiesOfConcern = declaredOnlyPropertiesOfConcern;
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        public Type Type { get; }

        /// <summary>
        /// Gets the <see cref="HierarchyKind"/> of the model type.
        /// </summary>
        public HierarchyKind HierarchyKind { get; }

        /// <summary>
        /// Gets the properties of concern for the model type.
        /// </summary>
        public IReadOnlyList<PropertyInfo> PropertiesOfConcern { get; }

        /// <summary>
        /// Gets the declared only properties of concern for the model type.
        /// </summary>
        public IReadOnlyList<PropertyInfo> DeclaredOnlyPropertiesOfConcern { get; }

        private static void ThrowIfNotSupported(
            Type type)
        {
            if (type.ContainsGenericParameters)
            {
                throw new NotSupportedException(Invariant($"This type is not supported; it is an open type: {type}."));
            }

            if (!type.IsAssignableTo(typeof(IModelViaCodeGen)))
            {
                throw new NotSupportedException(Invariant($"The type does not implement {nameof(IModelViaCodeGen)}."));
            }

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

            if (type.IsGenericType)
            {
                throw new NotSupportedException(Invariant($"This type is not supported; it is a generic type: {type}."));
            }

            var allTypes = AssemblyLoader.GetLoadedAssemblies().GetTypesFromAssemblies();

            var inheritedTypes = allTypes.Where(_ => (_ != type) && (_.BaseType == type)).ToList();

            if (DoesInheritFromObject(type))
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

        private static void ThrowIfNotSupported(
            Type type,
            IReadOnlyCollection<PropertyInfo> propertiesOfConcern)
        {
            if (propertiesOfConcern.Any(_ => IsOrContainsDictionaryKeyedOnDateTime(_.PropertyType)))
            {
                throw new NotSupportedException(Invariant($"This type contains a property that is OR has within its generic argument tree a Dictionary that is keyed on DateTime; IsEqualTo may do the wrong thing when comparing the keys of two such dictionaries (because it uses dictionary's embedded equality comparer, which is most likely the default comparer, which determines two DateTimes to be equal if they have the same Ticks, regardless of whether they have the same Kind)': {type}."));
            }
        }

        private static HierarchyKind GetHierarchyKind(
            Type type)
        {
            HierarchyKind result;
            if (type.IsAbstract)
            {
                result = HierarchyKind.AbstractBase;
            }
            else if (DoesInheritFromObject(type))
            {
                result = HierarchyKind.None;
            }
            else
            {
                result = HierarchyKind.ConcreteInherited;
            }

            return result;
        }

        private static bool DoesInheritFromObject(
            Type type)
        {
            var result = type.BaseType == typeof(object);

            return result;
        }

        private static IReadOnlyList<PropertyInfo> GetPropertiesOfConcernFromType(
            Type type,
            HierarchyKind hierarchyKind,
            bool declaredOnly)
        {
            type.AsArg(nameof(type)).Must().NotBeNull();

            var bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty;

            IReadOnlyList<PropertyInfo> result;

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

        private static bool IsOrContainsDictionaryKeyedOnDateTime(
            Type type)
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

                foreach (var genericTypeArgument in genericTypeArguments)
                {
                    // if the argument is a model type then move on;
                    // it will be validated when code gen is run for that model
                    if ((!genericTypeArgument.IsModelType()) && IsOrContainsDictionaryKeyedOnDateTime(genericTypeArgument))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
