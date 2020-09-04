// --------------------------------------------------------------------------------------------------------------------
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
        private static readonly IReadOnlyCollection<Type> LoadedTypes = AssemblyLoader.GetLoadedAssemblies().GetTypesFromAssemblies();

        private readonly Type underlyingType;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelType"/> class.
        /// </summary>
        /// <param name="type">The model type.</param>
        public ModelType(
            Type type)
        {
            new { type }.AsArg().Must().NotBeNull();

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

            ThrowIfNotSupported(type);

            var hierarchyKind = GetHierarchyKind(type);
            var propertiesOfConcernResult = GetPropertiesOfConcernFromType(type, declaredOnly: false);
            var declaredOnlyPropertiesOfConcern = GetPropertiesOfConcernFromType(type, declaredOnly: true).PropertiesOfConcern;

            ThrowIfNotSupported(type, propertiesOfConcernResult);

            var propertiesOfConcern = propertiesOfConcernResult.PropertiesOfConcern;
            var canHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode = CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(propertiesOfConcern, new HashSet<Type>());
            var constructor = GetConstructorAndThrowIfNotSupported(type, propertiesOfConcern, declaredOnlyPropertiesOfConcern);

            var requiresComparability = typeof(IComparableViaCodeGen).IsAssignableFrom(type);
            var requiresDeepCloning = typeof(IDeepCloneableViaCodeGen).IsAssignableFrom(type);
            var requiresEquality = typeof(IEquatableViaCodeGen).IsAssignableFrom(type);
            var requiresHashing = typeof(IHashableViaCodeGen).IsAssignableFrom(type);
            var requiresModel = typeof(IModelViaCodeGen).IsAssignableFrom(type);
            var requiresStringRepresentation = typeof(IStringRepresentableViaCodeGen).IsAssignableFrom(type);

            var declaresCompareToMethod = typeof(IDeclareCompareToForRelativeSortOrderMethod<>).MakeGenericType(type).IsAssignableFrom(type);
            var declaresDeepCloneMethod = typeof(IDeclareDeepCloneMethod<>).MakeGenericType(type).IsAssignableFrom(type);
            var declaresEqualsMethod = typeof(IDeclareEqualsMethod<>).MakeGenericType(type).IsAssignableFrom(type);
            var declaresGetHashCodeMethod = typeof(IDeclareGetHashCodeMethod).IsAssignableFrom(type);
            var declaresToStringMethod = typeof(IDeclareToStringMethod).IsAssignableFrom(type);

            ThrowIfNotSupported(type, requiresComparability, declaresCompareToMethod, declaresDeepCloneMethod, declaresEqualsMethod, declaresGetHashCodeMethod, declaresToStringMethod);

            this.InheritancePathTypeNamesInCode = type.GetInheritancePath().Reverse().Skip(1).Reverse().Select(_ => _.ToStringReadable()).ToList();
            this.DerivativePathTypesNamesInCodeFromRootToSelf = this.InheritancePathTypeNamesInCode.Reverse().Concat(new[] { type.ToStringReadable() }).ToList();
            this.GenericParameters = type.IsGenericType ? type.GetGenericArguments().ToList() : new List<Type>();

            this.TypeNameInCodeString = type.ToStringReadable();
            this.TypeNameInTestMethodNameString = type.ToStringWithoutGenericComponent();
            this.TypeNameInIdentifierString = type.ToStringWithoutGenericComponent();
            this.TypeNameInXmlDocString = type.ToStringXmlDoc();
            this.TypeNamespace = type.Namespace;

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

            this.ExampleClosedModelType = GetExampleClosedModelType(type);
            this.ExampleConcreteDerivativeTypeNamesInCodeStrings = GetExampleConcreteDerivativeTypeNamesInCodeStrings(this.ExampleClosedModelType);
            this.ExampleAncestorConcreteDerivativeTypeNamesInCodeStrings = GetExampleAncestorConcreteDerivativeTypeNamesInCodeStrings(type);

            this.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode = canHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode;

            this.NamespacesOfTypesInPropertiesOfConcern = GetNamespacesOfTypesInPropertiesOfConcern(propertiesOfConcern);
        }

        /// <summary>
        /// Gets the inheritance path as compilable string representations of the type.
        /// </summary>
        public IReadOnlyList<string> InheritancePathTypeNamesInCode { get; }

        /// <summary>
        /// Gets the name of the type as it should be used in generated code.
        /// </summary>
        public string TypeNameInCodeString { get; }

        /// <summary>
        /// Gets the name of the type as it should be used in a test method name.
        /// </summary>
        public string TypeNameInTestMethodNameString { get; }

        /// <summary>
        /// Gets the name of the type as it should be used in an identifier.
        /// </summary>
        public string TypeNameInIdentifierString { get; }

        /// <summary>
        /// Gets the name of the type as it should be used in XML doc.
        /// </summary>
        public string TypeNameInXmlDocString { get; }

        /// <summary>
        /// Gets the namespace of the type.
        /// </summary>
        public string TypeNamespace { get; }

        /// <summary>
        /// Gets the compilable string representations of this model type's concrete derivative types.
        /// </summary>
        public IReadOnlyCollection<string> ExampleConcreteDerivativeTypeNamesInCodeStrings { get; }

        /// <summary>
        /// Gets the compilable string representations of this model's derivative path, starting
        /// at the root type and ending in the model type itself.
        /// </summary>
        public IReadOnlyCollection<string> DerivativePathTypesNamesInCodeFromRootToSelf { get; }

        /// <summary>
        /// Gets the compilable string representations of this model type's ancestors' concrete derivative types
        /// (excluding this model type).
        /// </summary>
        public IReadOnlyCollection<string> ExampleAncestorConcreteDerivativeTypeNamesInCodeStrings { get; }

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
        /// Gets the namespaces of the types in the properties of concern.
        /// </summary>
        public IReadOnlyCollection<string> NamespacesOfTypesInPropertiesOfConcern { get; }

        /// <summary>
        /// Gets the generic parameters.
        /// </summary>
        public IReadOnlyList<Type> GenericParameters { get; }

        /// <summary>
        /// Gets a closed version of the model type.
        /// </summary>
        public Type ExampleClosedModelType { get; }

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
            if (type.ContainsGenericParameters && (!type.IsGenericTypeDefinition))
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it is an open type, but not a generic type definition."));
            }

            if (!IsCodeGeneratedType(type))
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it does not implement one of the following interfaces: {CodeGenerator.TypesThatIndicateCodeGenIsRequired.Select(_ => _.ToStringReadable()).ToCsv()}."));
            }

            if (!type.IsClass)
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it is a value type or interface type."));
            }

            var directDerivativeTypes = LoadedTypes.Where(_ => (_ != type) && (_.BaseType == type)).ToList();

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

            var codeGenTypesUsed = CodeGenerator.TypesThatIndicateCodeGenIsRequired.Where(_ => _.IsAssignableFrom(type)).ToList();

            foreach (var inheritedType in inheritancePathExcludingObject)
            {
                if (!codeGenTypesUsed.All(_ => _.IsAssignableFrom(inheritedType)))
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

            var enumerableProperties = propertiesOfConcern.Where(_ => IsOrContainsMatchingType(_.PropertyType, t => t.IsSystemEnumerableType())).ToList();

            if (enumerableProperties.Any())
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains one or more properties that are OR have within their generic argument tree or array element type an IEnumerable<T>; enumerables may have unintended side-effects when iterating (e.g. fetch objects from a database): {enumerableProperties.Select(_ => _.Name).ToDelimitedString(", ")}."));
            }

            var systemCollectionNonInterfaceProperties = propertiesOfConcern.Where(_ => IsOrContainsMatchingType(_.PropertyType, IsSystemCollectionNonInterfaceType)).ToList();

            if (systemCollectionNonInterfaceProperties.Any())
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains one or more properties that are OR have within their generic argument tree or array element type a System Collection type that is not an interface; it's a best practice to use interfaces for these types: {systemCollectionNonInterfaceProperties.Select(_ => _.Name).ToDelimitedString(", ")}."));
            }

            var systemDictionaryNonInterfaceProperties = propertiesOfConcern.Where(_ => IsOrContainsMatchingType(_.PropertyType, IsSystemDictionaryNonInterfaceType)).ToList();

            if (systemDictionaryNonInterfaceProperties.Any())
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains one or more properties that are OR have within their generic argument tree or array element type a System Dictionary type that is not an interface; it's a best practice to use interfaces for these types: {systemDictionaryNonInterfaceProperties.Select(_ => _.Name).ToDelimitedString(", ")}."));
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

        private static bool IsSystemCollectionNonInterfaceType(
            Type type)
        {
            if (type.IsSystemCollectionType())
            {
                if (!type.IsInterface)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsSystemDictionaryNonInterfaceType(
            Type type)
        {
            if (type.IsSystemDictionaryType())
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
            var result = typeof(IHashable).IsAssignableFrom(type) || typeof(IHashableViaCodeGen).IsAssignableFrom(type);

            return result;
        }

        private static bool IsCodeGeneratedType(
            Type type)
        {
            var result = CodeGenerator.TypesThatIndicateCodeGenIsRequired.Any(_ => _.IsAssignableFrom(type));

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
            // We want to use the generic type definition here because we don't so much care
            // to identify the specific closed derivatives; we want to know to know if any
            // derivative implements methodInterfaceType.
            if (type.IsClosedGenericType())
            {
                type = type.GetGenericTypeDefinition();
            }

            // per ThrowIfNotSupported, declared methods can only go in concrete types
            var typesToCheck = type.IsAbstract ? GetConcreteDerivativeTypes(type) : new[] { type };

            var result = typesToCheck.Any(_ => _.GetInterfaces().Contains(
                methodInterfaceType.IsGenericTypeDefinition
                ? methodInterfaceType.MakeGenericType(_)
                : methodInterfaceType));

            return result;
        }

        private static IReadOnlyCollection<string> GetExampleConcreteDerivativeTypeNamesInCodeStrings(
            Type type)
        {
            Type typeToUse = type;

            if (type.IsClosedGenericType())
            {
                typeToUse = type.GetGenericTypeDefinition();
            }

            var result = GetConcreteDerivativeTypes(typeToUse)
                .Select(GetExampleClosedModelType)
                .Where(type.IsAssignableFrom)
                .Select(_ => _.ToStringReadable())
                .ToList();

            return result;
        }

        private static IReadOnlyCollection<string> GetExampleAncestorConcreteDerivativeTypeNamesInCodeStrings(
            Type type)
        {
            if (type.IsClosedGenericType())
            {
                type = type.GetGenericTypeDefinition();
            }

            var result = GetAncestorConcreteDerivatives(type)
                .Select(GetExampleClosedModelType)
                .Select(_ => _.ToStringReadable())
                .ToList();

            return result;
        }

        private static IReadOnlyCollection<Type> GetConcreteDerivativeTypes(
            Type type)
        {
            var result = LoadedTypes
                    .Where(_ => _.IsClass)
                    .Where(_ => !_.IsAbstract)
                    .Where(_ => GetInheritancePathConvertingGenericsToGenericTypeDefinitions(_).Contains(type))
                    .ToList();

            return result;
        }

        private static IReadOnlyCollection<Type> GetAncestorConcreteDerivatives(
            Type type)
        {
            var oldestAncestorType =
                GetInheritancePathConvertingGenericsToGenericTypeDefinitions(type)
                    .Reverse()
                    .Skip(1) // typeof(object)
                    .FirstOrDefault();

            var result = oldestAncestorType == null
                ? (IReadOnlyCollection<Type>)new Type[0]
                : GetConcreteDerivativeTypes(oldestAncestorType).Where(_ => _ != type).ToList();

            return result;
        }

        private static IReadOnlyList<Type> GetInheritancePathConvertingGenericsToGenericTypeDefinitions(
            Type type)
        {
            var result = type.GetInheritancePath().Select(_ => _.IsGenericType ? _.GetGenericTypeDefinition() : _).ToList();

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

        private static IReadOnlyCollection<string> GetNamespacesOfTypesInPropertiesOfConcern(
            IReadOnlyList<PropertyOfConcern> propertiesOfConcern)
        {
            var types = propertiesOfConcern.Select(_ => _.PropertyType).Distinct().ToList();

            var result = types.SelectMany(GetNamespacesOfTypesInPropertiesOfConcern).Distinct().ToList();

            return result;
        }

        private static IReadOnlyCollection<string> GetNamespacesOfTypesInPropertiesOfConcern(
            Type type)
        {
            var result = new List<string> { type.Namespace };

            if (type.IsGenericType)
            {
                var genericArguments = type.GetGenericArguments();

                foreach (var genericArgument in genericArguments)
                {
                    result.AddRange(GetNamespacesOfTypesInPropertiesOfConcern(genericArgument));
                }
            }

            if (type.IsArray)
            {
                result.AddRange(GetNamespacesOfTypesInPropertiesOfConcern(type.GetElementType()));
            }

            return result;
        }

        private static Type GetExampleClosedModelType(
            Type type)
        {
            if (!type.ContainsGenericParameters)
            {
                return type;
            }

            var genericArguments = type.GetGenericArguments();

            // see: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
            // class Test1<T> where T : struct
            //    GenericParameterAttributes.NotNullableValueTypeConstraint, GenericParameterAttributes.DefaultConstructorConstraint | System.ValueType
            //    works with T as one of { Guid }
            // class Test2<T> where T : class
            //    GenericParameterAttributes.ReferenceTypeConstraint | <none>
            //    works with T as one of { System.Version, string }
            // class Test3<T> where T : notnull
            //    GenericParameterAttributes.None | <none>
            //    works with T as one of { System.Version, Guid, string }
            // class Test4<T> where T : unmanaged
            //    GenericParameterAttributes.NotNullableValueTypeConstraint, GenericParameterAttributes.DefaultConstructorConstraint | System.ValueType
            //    works with T as one of { Guid }
            // class Test5<T> where T : new()
            //    GenericParameterAttributes.DefaultConstructorConstraint | <none>
            //    works with T as one of { System.Version, Guid }
            // class Test6<T> where T : SomeBaseClass
            //    GenericParameterAttributes.None | SomeBaseClass
            //    works with T as one of { types assignable to SomeBaseClass }
            // valid combos:  class, new()
            // valid combos: notnull, new() - seems to allow Exception which is nullable so not sure
            var resolvedGenericArguments = new List<Type>();

            foreach (var genericArgument in genericArguments)
            {
                Type thisGenericArgumentType;

                var attributes = genericArgument.GenericParameterAttributes;

                var specialConstraints = attributes & GenericParameterAttributes.SpecialConstraintMask;

                if (specialConstraints == GenericParameterAttributes.None)
                {
                    thisGenericArgumentType = typeof(Version);
                }
                else
                {
                    // these are not really mutually exclusive (per documentation above), but we need to pick a single type.
                    if ((specialConstraints & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0)
                    {
                        thisGenericArgumentType = typeof(Guid);
                    }
                    else if ((specialConstraints & GenericParameterAttributes.ReferenceTypeConstraint) != 0)
                    {
                        thisGenericArgumentType = typeof(Version);
                    }
                    else if ((specialConstraints & GenericParameterAttributes.DefaultConstructorConstraint) != 0)
                    {
                        thisGenericArgumentType = typeof(Version);
                    }
                    else
                    {
                        throw new InvalidOperationException("Should not get here.");
                    }
                }

                var constraints = genericArgument.GetGenericParameterConstraints();

                foreach (var constraint in constraints)
                {
                    if (constraint.ContainsGenericParameters)
                    {
                        throw new NotSupportedException(Invariant($"Cannot generate code for generic type '{type.ToStringReadable()}' because generic argument '{genericArgument.Name}' is constrained to '{constraint.ToStringReadable()}' which itself is an open generic type and this kind of constraint is not supported."));
                    }

                    if (!constraint.IsAssignableFrom(thisGenericArgumentType))
                    {
                        // need to find another type that will work
                        throw new NotSupportedException("test");
                    }
                }

                resolvedGenericArguments.Add(thisGenericArgumentType);
            }

            var result = type.MakeGenericType(resolvedGenericArguments.ToArray());

            return result;
        }

        private class PropertiesOfConcernResult
        {
            public IReadOnlyList<PropertyOfConcern> PropertiesOfConcern { get; set; }

            public IReadOnlyList<PropertyInfo> GetterOnlyProperties { get; set; }
        }
    }
}
