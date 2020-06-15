﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelType.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.CodeGen.ModelObject.Internal;
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
        private readonly Type underlyingType;

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
            var propertiesOfConcernResult = GetPropertiesOfConcernFromType(type, declaredOnly: false);
            var declaredOnlyPropertiesOfConcern = GetPropertiesOfConcernFromType(type, declaredOnly: true).PropertiesOfConcern;

            ThrowIfNotSupported(type, propertiesOfConcernResult);

            var propertiesOfConcern = propertiesOfConcernResult.PropertiesOfConcern;
            var canHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode = CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(propertiesOfConcern, new HashSet<Type>());
            var constructor = GetConstructorAndThrowIfNotSupported(type, propertiesOfConcern, declaredOnlyPropertiesOfConcern);

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

            ThrowIfNotSupported(type, requiresComparability, declaresCompareToMethod, declaresDeepCloneMethod, declaresEqualsMethod, declaresGetHashCodeMethod, declaresToStringMethod);

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
            this.underlyingType = type;
            this.InheritancePathCompilableStrings = type.GetInheritancePath().Reverse().Skip(1).Reverse().Select(_ => _.ToStringCompilable()).ToList();
            this.ConcreteDerivativeTypesCompilableStrings = GetConcreteDerivativeTypes(type).Select(_ => _.ToStringCompilable()).ToList();
            this.AncestorConcreteDerivativesCompilableStrings = GetAncestorConcreteDerivatives(type).Select(_ => _.ToStringCompilable()).ToList();
            this.DerivativePathFromRootToSelfCompilableStrings = this.InheritancePathCompilableStrings.Reverse().Concat(new[] { type.ToStringCompilable() }).ToList();

            this.TypeCompilableString = type.ToStringCompilable();
            this.TypeReadableString = type.ToStringReadable();
            this.TypeNamespace = type.Namespace;
            this.BaseTypeCompilableString = type.BaseType?.ToStringCompilable();
            this.BaseTypeReadableString = type.BaseType?.ToStringReadable();

            this.HierarchyKind = hierarchyKind;
            this.ClassifiedHierarchyKind = Classify(hierarchyKind);
            this.IsAbstractBase = (hierarchyKind == HierarchyKind.AbstractBaseRoot) || (hierarchyKind == HierarchyKind.AbstractBaseInherited);
            this.IsConcrete = (hierarchyKind == HierarchyKind.ConcreteInherited) || (hierarchyKind == HierarchyKind.Standalone);
            this.PropertiesOfConcern = propertiesOfConcern;
            this.DeclaredOnlyPropertiesOfConcern = declaredOnlyPropertiesOfConcern;
            this.Constructor = constructor;

            this.RequiresComparability = requiresComparability;
            this.RequiresDeepCloning = requiresDeepCloning;
            this.RequiresEquality = requiresEquality;
            this.RequiresHashing = requiresHashing;
            this.RequiresModel = requiresModel;
            this.RequiresStringRepresentation = requiresStringRepresentation;

            this.RequiredInterfaces = DetermineRequiredInterfaces(type, requiresModel, requiresDeepCloning, requiresEquality, requiresHashing, requiresStringRepresentation, requiresComparability);

            this.DeclaresCompareToMethod = declaresCompareToMethod;
            this.DeclaresDeepCloneMethod = declaresDeepCloneMethod;
            this.DeclaresEqualsMethod = declaresEqualsMethod;
            this.DeclaresGetHashCodeMethod = declaresGetHashCodeMethod;
            this.DeclaresToStringMethod = declaresToStringMethod;

            this.CompareToKeyMethodKinds = declaresCompareToMethod ? KeyMethodKinds.Declared : KeyMethodKinds.Generated;
            this.DeepCloneKeyMethodKinds = declaresDeepCloneMethod ? KeyMethodKinds.Declared : KeyMethodKinds.Generated;
            this.EqualsKeyMethodKinds = declaresEqualsMethod ? KeyMethodKinds.Declared : KeyMethodKinds.Generated;
            this.GetHashCodeKeyMethodKinds = declaresGetHashCodeMethod ? KeyMethodKinds.Declared : KeyMethodKinds.Generated;
            this.ToStringKeyMethodKinds = declaresToStringMethod ? KeyMethodKinds.Declared : KeyMethodKinds.Generated;

            this.DeclaresDeepCloneMethodDirectlyOrInDerivative = DetermineIfDeclaresMethodDirectlyOrInDerivative(type, typeof(IDeclareDeepCloneMethod<>));
            this.DeclaresEqualsMethodDirectlyOrInDerivative = DetermineIfDeclaresMethodDirectlyOrInDerivative(type, typeof(IDeclareEqualsMethod<>));
            this.DeclaresGetHashCodeMethodDirectlyOrInDerivative = DetermineIfDeclaresMethodDirectlyOrInDerivative(type, typeof(IDeclareGetHashCodeMethod));
            this.DeclaresToStringMethodDirectlyOrInDerivative = DetermineIfDeclaresMethodDirectlyOrInDerivative(type, typeof(IDeclareToStringMethod));

            this.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode = canHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode;
        }

        /// <summary>
        /// Gets the inheritance path as compilable string representations of the type.
        /// </summary>
        public IReadOnlyList<string> InheritancePathCompilableStrings { get; }

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
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = ObcSuppressBecause.CA1811_AvoidUncalledPrivateCode_PropertyExistsForCompleteness)]
        public string BaseTypeCompilableString { get; }

        /// <summary>
        /// Gets a readability-optimized string representation of the base type.
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = ObcSuppressBecause.CA1811_AvoidUncalledPrivateCode_PropertyExistsForCompleteness)]
        public string BaseTypeReadableString { get; }

        /// <summary>
        /// Gets the compilable string representations of this model type's concrete derivative types.
        /// </summary>
        public IReadOnlyCollection<string> ConcreteDerivativeTypesCompilableStrings { get; }

        /// <summary>
        /// Gets the compilable string representations of this model's derivative path, starting
        /// at the root type and ending in the model type itself.
        /// </summary>
        public IReadOnlyCollection<string> DerivativePathFromRootToSelfCompilableStrings { get; }

        /// <summary>
        /// Gets the compilable string representations of this model type's ancestors' concrete derivative types
        /// (excluding this model type).
        /// </summary>
        public IReadOnlyCollection<string> AncestorConcreteDerivativesCompilableStrings { get; }

        /// <summary>
        /// Gets the constructor or null if there is no constructor.
        /// </summary>
        public ConstructorInfo Constructor { get; }

        /// <summary>
        /// Gets the <see cref="HierarchyKind"/> of the model type.
        /// </summary>
        public HierarchyKind HierarchyKind { get; }

        /// <summary>
        /// Gets the <see cref="ClassifiedHierarchyKind"/> of the model type.
        /// </summary>
        public ClassifiedHierarchyKind ClassifiedHierarchyKind { get; }

        /// <summary>
        /// Gets a value indicating whether the model is an abstract base type.
        /// </summary>
        public bool IsAbstractBase { get; }

        /// <summary>
        /// Gets a value indicating whether the model is a concrete type.
        /// </summary>
        public bool IsConcrete { get; }

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
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = ObcSuppressBecause.CA1811_AvoidUncalledPrivateCode_PropertyExistsForCompleteness)]
        public IReadOnlyList<PropertyOfConcern> DeclaredOnlyPropertiesOfConcern { get; }

        /// <summary>
        /// Gets the interfaces that must be applied to the model in generated code.
        /// </summary>
        public IReadOnlyList<Type> RequiredInterfaces { get; }

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
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = ObcSuppressBecause.CA1811_AvoidUncalledPrivateCode_PropertyExistsForCompleteness)]
        public bool DeclaresCompareToMethod { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareDeepCloneMethod{T}.DeepClone"/> method.
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = ObcSuppressBecause.CA1811_AvoidUncalledPrivateCode_PropertyExistsForCompleteness)]
        public bool DeclaresDeepCloneMethod { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareEqualsMethod{T}.Equals(T)"/> method.
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = ObcSuppressBecause.CA1811_AvoidUncalledPrivateCode_PropertyExistsForCompleteness)]
        public bool DeclaresEqualsMethod { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareGetHashCodeMethod.GetHashCode"/> method.
        /// </summary>
        public bool DeclaresGetHashCodeMethod { get; }

        /// <summary>
        /// Gets a value indicating whether the model declares a <see cref="IDeclareToStringMethod.ToString"/> method.
        /// </summary>
        public bool DeclaresToStringMethod { get; }

        /// <summary>
        /// Gets the key method kind for the <see cref="IDeclareCompareToForRelativeSortOrderMethod{T}.CompareToForRelativeSortOrder(T)"/> method.
        /// </summary>
        public KeyMethodKinds CompareToKeyMethodKinds { get; }

        /// <summary>
        /// Gets the key method kind for the <see cref="IDeclareDeepCloneMethod{T}.DeepClone"/> method.
        /// </summary>
        public KeyMethodKinds DeepCloneKeyMethodKinds { get; }

        /// <summary>
        /// Gets the key method kind for the <see cref="IDeclareEqualsMethod{T}.Equals(T)"/> method.
        /// </summary>
        public KeyMethodKinds EqualsKeyMethodKinds { get; }

        /// <summary>
        /// Gets the key method kind for the <see cref="IDeclareGetHashCodeMethod.GetHashCode"/> method.
        /// </summary>
        public KeyMethodKinds GetHashCodeKeyMethodKinds { get; }

        /// <summary>
        /// Gets the key method kind for the <see cref="IDeclareToStringMethod.ToString"/> method.
        /// </summary>
        public KeyMethodKinds ToStringKeyMethodKinds { get; }

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
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = ObcSuppressBecause.CA1811_AvoidUncalledPrivateCode_PropertyExistsForCompleteness)]
        public bool DeclaresToStringMethodDirectlyOrInDerivative { get; }

        /// <summary>
        /// Determines if the specified property is declared by this model type.
        /// </summary>
        /// <param name="propertyOfConcern">The property.</param>
        /// <returns>
        /// true if the specified property is declared by this model type; otherwise false.
        /// </returns>
        public bool DeclaresProperty(
            PropertyOfConcern propertyOfConcern)
        {
            var result = propertyOfConcern.DeclaringType == this.underlyingType;

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = this.underlyingType.ToStringReadable();

            return result;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        private static void ThrowIfNotSupported(
            Type type)
        {
            if (type.ContainsGenericParameters)
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it is an open type."));
            }

            if (!IsCodeGeneratedType(type))
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it does not implement one of the following interfaces: {CodeGenerator.TypesThatIndicateCodeGenIsRequired.Select(_ => _.ToStringReadable()).ToCsv()}."));
            }

            if (!type.IsClass)
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it is a value type or interface type."));
            }

            if (type.IsGenericType)
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it is a generic type."));
            }

            var loadedTypes = AssemblyLoader.GetLoadedAssemblies().GetTypesFromAssemblies();

            var directDerivativeTypes = loadedTypes.Where(_ => (_ != type) && (_.BaseType == type)).ToList();

            if (directDerivativeTypes.Any() && (!type.IsAbstract))
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it is a base class of one or more other classes but it is not abstract."));
            }

            var inheritancePathExcludingObject = type.GetInheritancePath().Reverse().Skip(1).Reverse().ToList();

            if (type.IsAbstract && inheritancePathExcludingObject.Any(_ => !_.IsAbstract))
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it is abstract but has a concrete type in its inheritance path (excluding Object)."));
            }

            if ((!type.IsAbstract) && inheritancePathExcludingObject.Any(_ => !_.IsAbstract))
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it is concrete and has a concrete type in its inheritance path (excluding Object)."));
            }

            var codeGenTypesUsed = CodeGenerator.TypesThatIndicateCodeGenIsRequired.Where(_ => type.IsAssignableTo(_)).ToList();

            foreach (var inheritedType in inheritancePathExcludingObject)
            {
                if (!codeGenTypesUsed.All(_ => inheritedType.IsAssignableTo(_)))
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; there is a type in its inheritance path ({inheritedType.ToStringReadable()}) that does not implement all of the following code gen interfaces which are implemented by this type: {codeGenTypesUsed.Select(_ => _.ToStringReadable()).ToDelimitedString(", ")}."));
                }
            }
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        private static void ThrowIfNotSupported(
            Type type,
            PropertiesOfConcernResult propertiesOfConcernResult)
        {
            if (propertiesOfConcernResult.GetterOnlyProperties.Any())
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains the following getter-only properties: {propertiesOfConcernResult.GetterOnlyProperties.Select(_ => _.Name).ToDelimitedString(", ")}."));
            }

            var propertiesOfConcern = propertiesOfConcernResult.PropertiesOfConcern;

            if (propertiesOfConcern.Any(_ => (!_.HasPublicSetter) && (!_.HasPrivateSetter)))
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains properties of concern are neither private nor public; only private and public setters are supported."));
            }

            if ((propertiesOfConcern.GroupBy(_ => _.HasPrivateSetter).Count() > 1) || (propertiesOfConcern.GroupBy(_ => _.HasPublicSetter).Count() > 1))
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains properties of concern with inconsistent access modifiers on its setters."));
            }

            var dictionaryKeyedOnDateTimeProperties = propertiesOfConcern.Where(_ => IsOrContainsMatchingType(_.PropertyType, IsDictionaryKeyedOnDateTime)).ToList();

            if (dictionaryKeyedOnDateTimeProperties.Any())
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains one or more properties that are OR have within their generic argument tree or array element type a Dictionary that is keyed on DateTime; IsEqualTo may do the wrong thing when comparing the keys of two such dictionaries (because it uses dictionary's embedded equality comparer, which is most likely the default comparer, which determines two DateTimes to be equal if they have the same Ticks, regardless of whether they have the same Kind): {dictionaryKeyedOnDateTimeProperties.Select(_ => _.Name).ToDelimitedString(", ")}."));
            }

            var enumerableProperties = propertiesOfConcern.Where(_ => IsOrContainsMatchingType(_.PropertyType, t => t.IsClosedSystemEnumerableType())).ToList();

            if (enumerableProperties.Any())
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains one or more properties that are OR have within their generic argument tree or array element type an IEnumerable<T>; enumerables may have unintended side-effects when iterating (e.g. fetch objects from a database): {enumerableProperties.Select(_ => _.Name).ToDelimitedString(", ")}."));
            }

            var closedSystemCollectionNonInterfaceProperties = propertiesOfConcern.Where(_ => IsOrContainsMatchingType(_.PropertyType, IsClosedSystemCollectionNonInterfaceType)).ToList();

            if (closedSystemCollectionNonInterfaceProperties.Any())
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains one or more properties that are OR have within their generic argument tree or array element type a closed System Collection type that is not an interface; it's a best practice to use interfaces for these types: {closedSystemCollectionNonInterfaceProperties.Select(_ => _.Name).ToDelimitedString(", ")}."));
            }

            var closedSystemDictionaryNonInterfaceProperties = propertiesOfConcern.Where(_ => IsOrContainsMatchingType(_.PropertyType, IsClosedSystemDictionaryNonInterfaceType)).ToList();

            if (closedSystemDictionaryNonInterfaceProperties.Any())
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains one or more properties that are OR have within their generic argument tree or array element type a closed System Dictionary type that is not an interface; it's a best practice to use interfaces for these types: {closedSystemDictionaryNonInterfaceProperties.Select(_ => _.Name).ToDelimitedString(", ")}."));
            }
        }

        private static void ThrowIfNotSupported(
            Type type,
            bool requiresComparability,
            bool declaresCompareToMethod,
            bool declaresDeepCloneMethod,
            bool declaresEqualsMethod,
            bool declaresGetHashCodeMethod,
            bool declaresToStringMethod)
        {
            if (declaresCompareToMethod || declaresDeepCloneMethod || declaresEqualsMethod || declaresGetHashCodeMethod || declaresToStringMethod)
            {
                if (type.IsAbstract)
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it is an abstract class that implements one or more of the IDeclare... interfaces."));
                }
            }

            if (requiresComparability)
            {
                if ((!type.IsAbstract) && (!declaresCompareToMethod))
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it is a concrete class that implements IComparableViaCodeGen but does not implement IDeclareCompareToForRelativeSortOrderMethod."));
                }
            }
        }

        private static HierarchyKind GetHierarchyKind(
            Type type)
        {
            HierarchyKind result;
            if (type.IsAbstract)
            {
                result = DoesInheritFromObject(type)
                    ? HierarchyKind.AbstractBaseRoot
                    : HierarchyKind.AbstractBaseInherited;
            }
            else if (DoesInheritFromObject(type))
            {
                result = HierarchyKind.Standalone;
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

        private static PropertiesOfConcernResult GetPropertiesOfConcernFromType(
            Type type,
            bool declaredOnly)
        {
            var bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.DeclaredOnly;

            var properties = type.GetProperties(bindingFlags);

            var getterOnlyProperties = properties
                .Where(_ => _.GetSetMethod(true) == null) // no set method
                .Where(IsAutoPropertyBasedOnGetter) // is an auto-property (e.g. int MyProperty { get; }).  expression body properties are NOT auto-properties
                .ToList();

            var result = new PropertiesOfConcernResult
            {
                GetterOnlyProperties = getterOnlyProperties,
                PropertiesOfConcern = properties
                    .Where(_ => _.GetSetMethod(true) != null) // requires a setter.  based on the logic above, this will filter out expression body properties (e.g. int MyProperty => 5)
                    .Select(_ => new PropertyOfConcern(_.PropertyType, _.Name, type, _.GetSetMethod(true).IsPrivate, _.GetSetMethod(true).IsPublic))
                    .ToList(),
            };

            if ((!declaredOnly) && (type.BaseType != typeof(object)))
            {
                // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                var baseTypePropertiesOfConcernResult = GetPropertiesOfConcernFromType(type.BaseType, declaredOnly);

                result.PropertiesOfConcern = new PropertyOfConcern[0].Concat(baseTypePropertiesOfConcernResult.PropertiesOfConcern).Concat(result.PropertiesOfConcern).ToList();

                result.GetterOnlyProperties = new PropertyInfo[0].Concat(baseTypePropertiesOfConcernResult.GetterOnlyProperties).Concat(result.GetterOnlyProperties).ToList();
            }

            return result;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        private static ConstructorInfo GetConstructorAndThrowIfNotSupported(
            Type type,
            IReadOnlyList<PropertyOfConcern> propertiesOfConcern,
            IReadOnlyList<PropertyOfConcern> declaredOnlyPropertiesOfConcern)
        {
            var constructors = type.GetConstructors();

            // no constructors?
            if (!constructors.Any())
            {
                return null;
            }

            if (type.IsAbstract)
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; there is at least one public constructor, but the class is abstract.  Abstract classes should not have public constructors."));
            }

            // only has default constructor?
            ConstructorInfo result;

            if ((constructors.Length == 1) && constructors.Single().IsDefaultConstructor())
            {
                result = constructors.Single();
            }
            else
            {
                var constructorsMatchingPropertiesOfConcern =
                    constructors
                    .Where(
                        _ =>
                        {
                            var propertyNameTypeMap = propertiesOfConcern.ToDictionary(p => p.Name, p => p.PropertyType, StringComparer.OrdinalIgnoreCase);

                            var parameters = _.GetParameters();

                            foreach (var parameter in parameters)
                            {
                                // property matching parameter by name?
                                if (!propertyNameTypeMap.ContainsKey(parameter.Name))
                                {
                                    return false;
                                }

                                var propertyType = propertyNameTypeMap[parameter.Name];

                                // property matches parameter by type?
                                if (propertyType != parameter.ParameterType)
                                {
                                    return false;
                                }
                            }

                            return true;
                        })
                    .ToList();

                if (constructorsMatchingPropertiesOfConcern.Count == 0)
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; none of its public constructors have parameters where all parameters have a matching property by name and type."));
                }

                var maxParameterCount = constructorsMatchingPropertiesOfConcern.Max(_ => _.GetParameters().Length);

                var candidateConstructors = constructorsMatchingPropertiesOfConcern.Where(_ => _.GetParameters().Length == maxParameterCount).ToList();

                if (candidateConstructors.Count > 1)
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; there are {candidateConstructors.Count} public constructors having {maxParameterCount} parameters that have a matching property by name type, whereas only 1 was expected."));
                }

                result = candidateConstructors.Single();
            }

            if (result.IsDefaultConstructor())
            {
                if (declaredOnlyPropertiesOfConcern.Any(_ => _.HasPrivateSetter))
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; the constructor to use is the default constructor but there are properties declared on the type that have private setters."));
                }
            }
            else
            {
                if (declaredOnlyPropertiesOfConcern.Any(_ => _.HasPublicSetter))
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; the constructor to use is parameterized but there are properties declared on the type with a public setter."));
                }

                // all of the declared properties have to appear in the parameter list
                var constructorParameterNames = new HashSet<string>(result.GetParameters().Select(_ => _.Name), StringComparer.OrdinalIgnoreCase);

                if (declaredOnlyPropertiesOfConcern.Any(_ => !constructorParameterNames.Contains(_.Name)))
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; the constructor to use is parameterized but one or more of the properties declared on the type does not match a parameter in that constructor."));
                }
            }

            return result;
        }

        private static bool IsDictionaryKeyedOnDateTime(
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

            return false;
        }

        private static bool IsClosedSystemCollectionNonInterfaceType(
            Type type)
        {
            if (type.IsClosedSystemCollectionType())
            {
                if (!type.IsInterface)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsClosedSystemDictionaryNonInterfaceType(
            Type type)
        {
            if (type.IsClosedSystemDictionaryType())
            {
                if (!type.IsInterface)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsOrContainsMatchingType(
            Type type,
            Func<Type, bool> isMatchingType)
        {
            var visitedTypes = new HashSet<Type>();

            var result = IsOrContainsMatchingType(type, visitedTypes, isMatchingType);

            return result;
        }

        private static bool IsOrContainsMatchingType(
            Type type,
            HashSet<Type> visitedTypes,
            Func<Type, bool> isMatchingType)
        {
            visitedTypes.Add(type);

            if (isMatchingType(type))
            {
                return true;
            }

            if (type.IsGenericType)
            {
                var genericTypeArguments = type.GenericTypeArguments;

                foreach (var genericTypeArgument in genericTypeArguments)
                {
                    // if the argument is a code generated type then move on;
                    // it will be validated when code gen is run for that type
                    if ((!visitedTypes.Contains(genericTypeArgument)) && (!IsCodeGeneratedType(genericTypeArgument)) && IsOrContainsMatchingType(genericTypeArgument, visitedTypes, isMatchingType))
                    {
                        return true;
                    }
                }
            }

            if (type.IsArray)
            {
                var elementType = type.GetElementType();

                // if the argument is a code generated type then move on;
                // it will be validated when code gen is run for that type
                if ((!visitedTypes.Contains(elementType)) && (!IsCodeGeneratedType(elementType)) && IsOrContainsMatchingType(elementType, visitedTypes, isMatchingType))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(
            IReadOnlyList<PropertyOfConcern> propertiesOfConcern,
            HashSet<Type> visitedTypes)
        {
            var result = propertiesOfConcern.Where(_ => !visitedTypes.Contains(_.PropertyType)).Any(_ => CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(_.PropertyType, visitedTypes));

            return result;
        }

        private static bool CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(
            Type type,
            HashSet<Type> visitedTypes)
        {
            visitedTypes.Add(type);

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
                        var propertiesOfConcern = GetPropertiesOfConcernFromType(genericTypeArgument, declaredOnly: false).PropertiesOfConcern;

                        if (CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(propertiesOfConcern, visitedTypes))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if ((!visitedTypes.Contains(genericTypeArgument)) && CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(genericTypeArgument, visitedTypes))
                        {
                            return true;
                        }
                    }
                }
            }

            if (IsHashableType(type))
            {
                var propertiesOfConcern = GetPropertiesOfConcernFromType(type, declaredOnly: false).PropertiesOfConcern;

                if (CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(propertiesOfConcern, visitedTypes))
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

        private static bool IsCodeGeneratedType(
            Type type)
        {
            var result = CodeGenerator.TypesThatIndicateCodeGenIsRequired.Any(_ => type.IsAssignableTo(_));

            return result;
        }

        private static IReadOnlyList<Type> DetermineRequiredInterfaces(
            Type type,
            bool requiresModel,
            bool requiresDeepCloning,
            bool requiresEquality,
            bool requiresHashing,
            bool requiresStringRepresentation,
            bool requiresComparability)
        {
            var result = new List<Type>();

            if (requiresModel)
            {
                result.Add(typeof(IModel<>).MakeGenericType(type));
            }
            else
            {
                if (requiresDeepCloning)
                {
                    result.Add(typeof(IDeepCloneable<>).MakeGenericType(type));
                }

                if (requiresEquality)
                {
                    result.Add(typeof(IEquatable<>).MakeGenericType(type));
                }

                if (requiresHashing)
                {
                    result.Add(typeof(IHashable));
                }

                if (requiresStringRepresentation)
                {
                    result.Add(typeof(IStringRepresentable));
                }
            }

            if (requiresComparability)
            {
                result.Add(typeof(IComparableForRelativeSortOrder<>).MakeGenericType(type));
            }

            return result;
        }

        private static bool DetermineIfDeclaresMethodDirectlyOrInDerivative(
            Type type,
            Type methodInterfaceType)
        {
            var result = AssemblyLoader.GetLoadedAssemblies().GetTypesFromAssemblies().Any(_ =>
                (!_.ContainsGenericParameters) &&
                _.IsAssignableTo(type) &&
                _.IsAssignableTo(methodInterfaceType.IsGenericTypeDefinition ? methodInterfaceType.MakeGenericType(_) : methodInterfaceType));

            return result;
        }

        private static IReadOnlyCollection<Type> GetConcreteDerivativeTypes(
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

        private static IReadOnlyCollection<Type> GetAncestorConcreteDerivatives(
            Type type)
        {
            var oldestAncestorType = type
                .GetInheritancePath()
                .Reverse()
                .Skip(1) // typeof(object)
                .FirstOrDefault();

            var result = new List<Type>();

            if (oldestAncestorType != null)
            {
                result = GetConcreteDerivativeTypes(oldestAncestorType).Where(_ => _ != type).ToList();
            }

            return result;
        }

        private static bool IsAutoPropertyBasedOnGetter(
            PropertyInfo propertyInfo)
        {
            new { propertyInfo }.Must().NotBeNull();

            // see: https://stackoverflow.com/a/60638810/356790
            var result = propertyInfo.GetGetMethod().GetCustomAttribute(typeof(CompilerGeneratedAttribute)) != null;

            return result;
        }

        private static ClassifiedHierarchyKind Classify(
            HierarchyKind hierarchyKind)
        {
            switch (hierarchyKind)
            {
                case HierarchyKind.AbstractBaseInherited:
                case HierarchyKind.AbstractBaseRoot:
                    return ClassifiedHierarchyKind.Abstract;
                case HierarchyKind.ConcreteInherited:
                case HierarchyKind.Standalone:
                    return ClassifiedHierarchyKind.Concrete;
                default:
                    throw new NotSupportedException("This hierarchy kind is not supported: " + hierarchyKind);
            }
        }

        private class PropertiesOfConcernResult
        {
            public IReadOnlyList<PropertyOfConcern> PropertiesOfConcern { get; set; }

            public IReadOnlyList<PropertyInfo> GetterOnlyProperties { get; set; }
        }
    }
}
