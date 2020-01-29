﻿// --------------------------------------------------------------------------------------------------------------------
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
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Reflection.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Represents a type that is a Model type.
    /// </summary>
    internal class ModelType
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
            var canHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode = CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(propertiesOfConcern);

            ThrowIfNotSupported(type, propertiesOfConcern);

            var requiresComparability = type.IsAssignableTo(typeof(IComparableViaCodeGen));
            var requiresDeepCloning = type.IsAssignableTo(typeof(IDeepCloneableViaCodeGen));
            var requiresEquality = type.IsAssignableTo(typeof(IEquatableViaCodeGen));
            var requiresHashing = type.IsAssignableTo(typeof(IHashableViaCodeGen));
            var requiresModel = type.IsAssignableTo(typeof(IModelViaCodeGen));
            var requiresStringRepresentation = type.IsAssignableTo(typeof(IStringRepresentableViaCodeGen));

            var declaresCompareToMethod = type.IsAssignableTo(typeof(IDeclareCompareToForRelativeSortOrderMethod<>).MakeGenericType(type));
            var declaresDeepCloneMethod = type.IsAssignableTo(typeof(IDeclareDeepCloneMethod<>).MakeGenericType(type));
            var declaresEqualsMethod = type.IsAssignableTo(typeof(IDeclareEqualsMethod<>).MakeGenericType(type));
            var declaresGetHashCodeMethod = type.IsAssignableTo(typeof(IDeclareGetHashCodeMethod));
            var declaresToStringMethod = type.IsAssignableTo(typeof(IDeclareToStringMethod));

            this.Type = type;
            this.HierarchyKind = hierarchyKind;
            this.PropertiesOfConcern = propertiesOfConcern;
            this.DeclaredOnlyPropertiesOfConcern = declaredOnlyPropertiesOfConcern;
            this.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode = canHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode;
            this.RequiresComparability = requiresComparability;
            this.RequiresDeepCloning = requiresDeepCloning;
            this.RequiresEquality = requiresEquality;
            this.RequiresHashing = requiresHashing;
            this.RequiresModel = requiresModel;
            this.RequiresStringRepresentation = requiresStringRepresentation;
            this.DeclaresCompareToMethod = declaresCompareToMethod;
            this.DeclaresDeepCloneMethod = declaresDeepCloneMethod;
            this.DeclaresEqualsMethod = declaresEqualsMethod;
            this.DeclaresGetHashCodeMethod = declaresGetHashCodeMethod;
            this.DeclaresToStringMethod = declaresToStringMethod;
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
        /// Gets a value indicating whether two dummies of this model type
        /// can not be equal but result in the same hash code.
        /// </summary>
        public bool CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode { get; }

        /// <summary>
        /// Gets the properties of concern for the model type.
        /// </summary>
        public IReadOnlyList<PropertyInfo> PropertiesOfConcern { get; }

        /// <summary>
        /// Gets the declared only properties of concern for the model type.
        /// </summary>
        public IReadOnlyList<PropertyInfo> DeclaredOnlyPropertiesOfConcern { get; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for comparability.
        /// </summary>
        public bool RequiresComparability { get; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for deep cloning.
        /// </summary>
        public bool RequiresDeepCloning { get; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for equality.
        /// </summary>
        public bool RequiresEquality { get; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for hashing.
        /// </summary>
        public bool RequiresHashing { get; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for the entire model.
        /// </summary>
        public bool RequiresModel { get; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for string representation.
        /// </summary>
        public bool RequiresStringRepresentation { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareCompareToForRelativeSortOrderMethod{T}.CompareToForRelativeSortOrder(T)"/> method.
        /// </summary>
        public bool DeclaresCompareToMethod { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareDeepCloneMethod{T}.DeepClone"/> method.
        /// </summary>
        public bool DeclaresDeepCloneMethod { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareEqualsMethod{T}.Equals(T)"/> method.
        /// </summary>
        public bool DeclaresEqualsMethod { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareGetHashCodeMethod.GetHashCode"/> method.
        /// </summary>
        public bool DeclaresGetHashCodeMethod { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareToStringMethod.ToString"/> method.
        /// </summary>
        public bool DeclaresToStringMethod { get; }

        private static void ThrowIfNotSupported(
            Type type)
        {
            if (type.ContainsGenericParameters)
            {
                throw new NotSupportedException(Invariant($"This type is not supported; it is an open type: {type}."));
            }

            if (CodeGenerator.TypesThatIndicateCodeGenIsRequired.All(_ => type.GetInterface(_.Name) == null))
            {
                // this really should be checked via: (!type.IsAssignableTo(typeof(IModelViaCodeGen))) but since this can be called using reflected types
                //    we are using a less strict check which does not require it to be truly assignable but instead merely the presence of a version of the interface
                throw new NotSupportedException(Invariant($"The type does not implement one of the following interfaces: {CodeGenerator.TypesThatIndicateCodeGenIsRequired.Select(_ => _.ToStringReadable()).ToCsv()}."));
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

            if (propertiesOfConcern.Any(_ => _.GetSetMethod(true) == null))
            {
                throw new NotSupportedException(Invariant($"This type contains a getter-only property; getter-only properties are not supported: {type}."));
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
            if (type.IsClosedSystemDictionaryType())
            {
                var keyType = type.GetClosedSystemDictionaryKeyType();

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
                    if ((!IsEquatableType(genericTypeArgument)) && IsOrContainsDictionaryKeyedOnDateTime(genericTypeArgument))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(
            IReadOnlyList<PropertyInfo> propertiesOfConcern)
        {
            var result = propertiesOfConcern.Any(_ => CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(_.PropertyType));

            return result;
        }

        private static bool CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(
            Type type)
        {
            // see scenarios in HashCodeHelper where we are forced to hash the
            // enumerable count instead of the elements.
            if (type.IsClosedSystemDictionaryType())
            {
                var keyType = type.GetClosedSystemDictionaryKeyType();

                if (!keyType.HasWorkingDefaultComparer())
                {
                    return true;
                }
            }

            if (type.IsClosedSystemUnorderedCollectionType())
            {
                var elementType = type.GetClosedSystemCollectionElementType();

                if (!elementType.HasWorkingDefaultComparer())
                {
                    return true;
                }
            }

            if (type.IsGenericType)
            {
                var genericTypeArguments = type.GenericTypeArguments;

                foreach (var genericTypeArgument in genericTypeArguments)
                {
                    if (IsHashableType(genericTypeArgument))
                    {
                        var hierarchyKind = GetHierarchyKind(genericTypeArgument);

                        var propertiesOfConcern = GetPropertiesOfConcernFromType(genericTypeArgument, hierarchyKind, declaredOnly: false);

                        if (CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(propertiesOfConcern))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(genericTypeArgument))
                        {
                            return true;
                        }
                    }
                }
            }

            if (IsHashableType(type))
            {
                var hierarchyKind = GetHierarchyKind(type);

                var propertiesOfConcern = GetPropertiesOfConcernFromType(type, hierarchyKind, declaredOnly: false);

                if (CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(propertiesOfConcern))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsHashableType(
            Type type)
        {
            var result = type.IsAssignableTo(typeof(IHashable)) || type.IsAssignableTo(typeof(IHashableViaCodeGen));

            return result;
        }

        private static bool IsEquatableType(
            Type type)
        {
            var result = type.IsAssignableTo(typeof(IEquatable<>), treatGenericTypeDefinitionAsAssignableTo: true) || type.IsAssignableTo(typeof(IEquatableViaCodeGen));

            return result;
        }
    }
}
