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
            var propertiesOfConcern = GetPropertiesOfConcernFromType(type, declaredOnly: false);
            var declaredOnlyPropertiesOfConcern = GetPropertiesOfConcernFromType(type, declaredOnly: true);
            var canHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode = CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(propertiesOfConcern);

            ThrowIfNotSupported(type, propertiesOfConcern);

            // note: We are explicitly NOT exposing the passed-in type to avoid some issues:
            // Before the first pass of code-gen, only user-defined model code will exist.
            // On the first pass, we will augment the model code with generated code in
            // a partial class designer file that will add interfaces to the model.
            // Thus, CodeGenerator cannot rely on those interfaces to be in-place on the
            // model and should not drive any logic based on their presence.  It's the same
            // concern when CodeGenerator creates Test code.  We don't know whether the tests
            // are generated alongside the model code or in a follow-up pass so we shouldn't
            // rely on the added interfaces to be in-place.  Along the same lines, we want
            // a second, third, etc. pass (where generated model and test code already exists
            // and is compiling) to produce the same generated code as in a first pass for
            // consistency.  To that end, we contain the usage of the specified type to this
            // class, where we ensure that there are no dependencies on the added interfaces.
            this.ConcreteDerivativeTypes = this.GetConcreteDerivativeTypes(type);
            this.TypeCompilableString = type.ToStringCompilable();
            this.TypeReadableString = type.ToStringReadable();
            this.TypeNamespace = type.Namespace;
            this.BaseTypeCompilableString = type.BaseType?.ToStringCompilable();
            this.BaseTypeReadableString = type.BaseType?.ToStringReadable();
            this.Constructors = type.GetConstructors();
            this.DetermineRequiredAndDeclaredFeatures(type);
            this.HierarchyKind = hierarchyKind;
            this.PropertiesOfConcern = propertiesOfConcern;
            this.DeclaredOnlyPropertiesOfConcern = declaredOnlyPropertiesOfConcern;
            this.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode = canHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode;
            this.DeclaresDeepCloneMethodDirectlyOrInDerivative = this.DetermineIfDeclaresDeepCloneMethodDirectlyOrInDerivative(hierarchyKind, type);
            this.DeclaresEqualsMethodDirectlyOrInDerivative = this.DetermineIfDeclaresEqualsMethodDirectlyOrInDerivative(hierarchyKind, type);
            this.DeclaresGetHashCodeMethodDirectlyOrInDerivative = this.DetermineIfDeclaresGetHashCodeMethodDirectlyOrInDerivative(hierarchyKind, type);
            this.DeclaresToStringMethodDirectlyOrInDerivative = this.DetermineIfDeclaresToStringMethodDirectlyOrInDerivative(hierarchyKind, type);
        }

        /// <summary>
        /// Gets a compilable string representation of the type.
        /// </summary>
        public string TypeCompilableString { get; }

        /// <summary>
        /// Gets a readability-optimized string representation of the type.
        /// </summary>
        public string TypeReadableString { get; }

        /// <summary>
        /// Gets the namespace of the type.
        /// </summary>
        public string TypeNamespace { get; }

        /// <summary>
        /// Gets a compilable string representation of the base type.
        /// </summary>
        public string BaseTypeCompilableString { get; }

        /// <summary>
        /// Gets a readability-optimized string representation of the base type.
        /// </summary>
        public string BaseTypeReadableString { get; }

        /// <summary>
        /// Gets the concrete derivative types.
        /// </summary>
        public IReadOnlyCollection<Type> ConcreteDerivativeTypes { get; }

        /// <summary>
        /// Gets the constructors.
        /// </summary>
        public IReadOnlyList<ConstructorInfo> Constructors { get; }

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
        public IReadOnlyList<PropertyOfConcern> PropertiesOfConcern { get; }

        /// <summary>
        /// Gets the declared only properties of concern for the model type.
        /// </summary>
        public IReadOnlyList<PropertyOfConcern> DeclaredOnlyPropertiesOfConcern { get; }

        /// <summary>
        /// Gets the interfaces that must be applied to the model in generated code.
        /// </summary>
        public IReadOnlyList<Type> RequiredInterfaces { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for comparability.
        /// </summary>
        public bool RequiresComparability { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for deep cloning.
        /// </summary>
        public bool RequiresDeepCloning { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for equality.
        /// </summary>
        public bool RequiresEquality { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for hashing.
        /// </summary>
        public bool RequiresHashing { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for the entire model.
        /// </summary>
        public bool RequiresModel { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model requires generated code for string representation.
        /// </summary>
        public bool RequiresStringRepresentation { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareCompareToForRelativeSortOrderMethod{T}.CompareToForRelativeSortOrder(T)"/> method.
        /// </summary>
        public bool DeclaresCompareToMethod { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareDeepCloneMethod{T}.DeepClone"/> method.
        /// </summary>
        public bool DeclaresDeepCloneMethod { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareEqualsMethod{T}.Equals(T)"/> method.
        /// </summary>
        public bool DeclaresEqualsMethod { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareGetHashCodeMethod.GetHashCode"/> method.
        /// </summary>
        public bool DeclaresGetHashCodeMethod { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareToStringMethod.ToString"/> method.
        /// </summary>
        public bool DeclaresToStringMethod { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareDeepCloneMethod{T}.DeepClone"/> method
        /// or has a derivative that does.
        /// </summary>
        public bool DeclaresDeepCloneMethodDirectlyOrInDerivative { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareEqualsMethod{T}.Equals(T)"/> method
        /// or has a derivative that does.
        /// </summary>
        public bool DeclaresEqualsMethodDirectlyOrInDerivative { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareGetHashCodeMethod.GetHashCode"/> method
        /// or has a derivative that does.
        /// </summary>
        public bool DeclaresGetHashCodeMethodDirectlyOrInDerivative { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareToStringMethod.ToString"/> method
        /// or has a derivative that does.
        /// </summary>
        public bool DeclaresToStringMethodDirectlyOrInDerivative { get; }

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

            var loadedTypes = AssemblyLoader.GetLoadedAssemblies().GetTypesFromAssemblies();

            var inheritedTypes = loadedTypes.Where(_ => (_ != type) && (_.BaseType == type)).ToList();

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
            IReadOnlyCollection<PropertyOfConcern> propertiesOfConcern)
        {
            var dictionaryKeyedOnDateTimeProperties = propertiesOfConcern.Where(_ => IsOrContainsDictionaryKeyedOnDateTime(_.PropertyType)).ToList();

            if (dictionaryKeyedOnDateTimeProperties.Any())
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) contains one or more properties that are OR have within their generic argument tree a Dictionary that is keyed on DateTime; IsEqualTo may do the wrong thing when comparing the keys of two such dictionaries (because it uses dictionary's embedded equality comparer, which is most likely the default comparer, which determines two DateTimes to be equal if they have the same Ticks, regardless of whether they have the same Kind)': {dictionaryKeyedOnDateTimeProperties.Select(_ => _.Name).ToDelimitedString(", ")}."));
            }

            var getterOnlyProperties = propertiesOfConcern.Where(_ => _.IsGetterOnly).ToList();

            if (getterOnlyProperties.Any())
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) contains the following getter-only properties; getter-only properties are not supported: {getterOnlyProperties.Select(_ => _.Name).ToDelimitedString(", ")}."));
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

        private static IReadOnlyList<PropertyOfConcern> GetPropertiesOfConcernFromType(
            Type type,
            bool declaredOnly)
        {
            var bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.DeclaredOnly;

            var result = type.GetProperties(bindingFlags).Select(_ => new PropertyOfConcern(_.PropertyType, _.Name, _.GetSetMethod(true) == null)).ToList();

            if ((!declaredOnly) && type.BaseType != typeof(object))
            {
                // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                result = new PropertyOfConcern[0]
                    .Concat(GetPropertiesOfConcernFromType(type.BaseType, declaredOnly))
                    .Concat(result)
                    .ToList();
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
            IReadOnlyList<PropertyOfConcern> propertiesOfConcern)
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
                        var propertiesOfConcern = GetPropertiesOfConcernFromType(genericTypeArgument, declaredOnly: false);

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
                var propertiesOfConcern = GetPropertiesOfConcernFromType(type, declaredOnly: false);

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
            // per the note in the constructor, we are checking IHashableViaCodeGen in case
            // the type is not yet hashable, but will be after the first pass of code gen on the model
            var result = type.IsAssignableTo(typeof(IHashable)) || type.IsAssignableTo(typeof(IHashableViaCodeGen));

            return result;
        }

        private static bool IsEquatableType(
            Type type)
        {
            // per the note in the constructor, we are checking IEquatableViaCodeGen in case
            // the type is not yet equatable, but will be after the first pass of code gen on the model
            var result = type.IsAssignableTo(typeof(IEquatable<>), treatGenericTypeDefinitionAsAssignableTo: true) || type.IsAssignableTo(typeof(IEquatableViaCodeGen));

            return result;
        }

        private void DetermineRequiredAndDeclaredFeatures(
            Type type)
        {
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

            var requiredInterfaces = new List<Type>();

            if (requiresModel)
            {
                requiredInterfaces.Add(typeof(IModel<>).MakeGenericType(type));
            }
            else
            {
                if (requiresDeepCloning)
                {
                    requiredInterfaces.Add(typeof(IDeepCloneable<>).MakeGenericType(type));
                }

                if (requiresEquality)
                {
                    requiredInterfaces.Add(typeof(IEquatable<>).MakeGenericType(type));
                }

                if (requiresHashing)
                {
                    requiredInterfaces.Add(typeof(IHashable));
                }

                if (requiresStringRepresentation)
                {
                    requiredInterfaces.Add(typeof(IStringRepresentable));
                }
            }

            if (requiresComparability)
            {
                requiredInterfaces.Add(typeof(IComparableForRelativeSortOrder<>).MakeGenericType(type));
            }

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

            this.RequiredInterfaces = requiredInterfaces;
        }

        private bool DetermineIfDeclaresDeepCloneMethodDirectlyOrInDerivative(
            HierarchyKind hierarchyKind,
            Type type)
        {
            var result = this.DeclaresDeepCloneMethod;

            if ((hierarchyKind == HierarchyKind.AbstractBase) || (!result))
            {
                result = AssemblyLoader.GetLoadedAssemblies().GetTypesFromAssemblies().Any(_ =>
                    (_.BaseType == type) &&
                    _.IsAssignableTo(typeof(IDeclareDeepCloneMethod<>).MakeGenericType(_)));
            }

            return result;
        }

        private bool DetermineIfDeclaresEqualsMethodDirectlyOrInDerivative(
            HierarchyKind hierarchyKind,
            Type type)
        {
            var result = this.DeclaresEqualsMethod;

            if ((hierarchyKind == HierarchyKind.AbstractBase) || (!result))
            {
                result = AssemblyLoader.GetLoadedAssemblies().GetTypesFromAssemblies().Any(_ =>
                    (_.BaseType == type) &&
                    _.IsAssignableTo(typeof(IDeclareEqualsMethod<>).MakeGenericType(_)));
            }

            return result;
        }

        private bool DetermineIfDeclaresGetHashCodeMethodDirectlyOrInDerivative(
            HierarchyKind hierarchyKind,
            Type type)
        {
            var result = this.DeclaresGetHashCodeMethod;

            if ((hierarchyKind == HierarchyKind.AbstractBase) || (!result))
            {
                result = AssemblyLoader.GetLoadedAssemblies().GetTypesFromAssemblies().Any(_ =>
                    (_.BaseType == type) &&
                    _.IsAssignableTo(typeof(IDeclareGetHashCodeMethod)));
            }

            return result;
        }

        private bool DetermineIfDeclaresToStringMethodDirectlyOrInDerivative(
            HierarchyKind hierarchyKind,
            Type type)
        {
            var result = this.DeclaresToStringMethod;

            if ((hierarchyKind == HierarchyKind.AbstractBase) || (!result))
            {
                result = AssemblyLoader.GetLoadedAssemblies().GetTypesFromAssemblies().Any(_ =>
                    (_.BaseType == type) &&
                    _.IsAssignableTo(typeof(IDeclareToStringMethod)));
            }

            return result;
        }

        private IReadOnlyCollection<Type> GetConcreteDerivativeTypes(
            Type type)
        {
            var result = AssemblyLoader
                .GetLoadedAssemblies()
                .GetTypesFromAssemblies()
                .Where(_ => _.IsClass)
                .Where(_ => !_.IsAbstract)
                .Where(_ => !_.ContainsGenericParameters)
                .Where(_ => _.IsAssignableTo(type))
                .ToList();

            return result;
        }
    }
}
