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

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Reflection.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Represents a type that is a Model type.
    /// </summary>
    [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = ObcSuppressBecause.CA1506_AvoidExcessiveClassCoupling_DisagreeWithAssessment)]
    internal partial class ModelType
    {
        private static readonly IReadOnlyCollection<Type> LoadedTypes = AssemblyLoader.GetLoadedAssemblies().GetTypesFromAssemblies().ToList();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelType"/> class.
        /// </summary>
        /// <param name="type">The model type.</param>
        [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = ObcSuppressBecause.CA1506_AvoidExcessiveClassCoupling_DisagreeWithAssessment)]
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

            // Check the type
            ThrowIfModelTypeNotSupported(type);

            // Hierarchy and Classification
            var hierarchyKind = GetHierarchyKind(type);
            this.HierarchyKind = hierarchyKind;
            this.ClassifiedHierarchyKind = Classify(hierarchyKind);
            this.IsAbstractBase = (hierarchyKind == HierarchyKind.AbstractBaseRoot) || (hierarchyKind == HierarchyKind.AbstractBaseInherited);
            this.IsConcrete = (hierarchyKind == HierarchyKind.ConcreteInherited) || (hierarchyKind == HierarchyKind.Standalone);

            // Properties of Concern
            var propertiesOfConcern = GetPropertiesOfConcernInOrder(type);
            var declaredOnlyPropertiesOfConcern = propertiesOfConcern.Where(_ => _.DeclaringType == type).ToList();

            ThrowIfPropertiesOfConcernNotSupported(type, propertiesOfConcern);

            this.PropertiesOfConcern = propertiesOfConcern.Select(ToPropertyOfConcern).ToList();
            this.DeclaredOnlyPropertiesOfConcern = declaredOnlyPropertiesOfConcern.Select(ToPropertyOfConcern).ToList();
            this.CaseInsensitivePropertyNameToPropertyOfConcernMap = this.PropertiesOfConcern.ToDictionary(_ => _.Name, _ => _, StringComparer.OrdinalIgnoreCase);

            // Conditions About Properties
            this.GenericParametersUsedAsKeyInDictionary = GetGenericParametersUsedAsKeyInDictionary(type, propertiesOfConcern);
            this.CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCode = CanHaveTwoDummiesThatAreNotEqualButHaveTheSameHashCodeInternal(propertiesOfConcern, new HashSet<Type>());

            // Required/Declared/Generated methods
            var requiresComparability = typeof(IComparableViaCodeGen).IsAssignableFrom(type);
            var requiresDeepCloning = typeof(IDeepCloneableViaCodeGen).IsAssignableFrom(type);
            var requiresEquality = typeof(IEquatableViaCodeGen).IsAssignableFrom(type);
            var requiresHashing = typeof(IHashableViaCodeGen).IsAssignableFrom(type);
            var requiresModel = typeof(IModelViaCodeGen).IsAssignableFrom(type);
            var requiresStringRepresentation = typeof(IStringRepresentableViaCodeGen).IsAssignableFrom(type);

            var forsakesDeepCloneWithVariantMethods = typeof(IForsakeDeepCloneWithVariantsViaCodeGen).IsAssignableFrom(type);

            var declaresCompareToMethod = typeof(IDeclareCompareToForRelativeSortOrderMethod<>).MakeGenericType(type).IsAssignableFrom(type);
            var declaresDeepCloneMethod = typeof(IDeclareDeepCloneMethod<>).MakeGenericType(type).IsAssignableFrom(type);
            var declaresEqualsMethod = typeof(IDeclareEqualsMethod<>).MakeGenericType(type).IsAssignableFrom(type);
            var declaresGetHashCodeMethod = typeof(IDeclareGetHashCodeMethod).IsAssignableFrom(type);
            var declaresToStringMethod = typeof(IDeclareToStringMethod).IsAssignableFrom(type);

            ThrowIfRequiredAndDeclaredMethodsNotSupported(type, requiresComparability, declaresCompareToMethod, declaresDeepCloneMethod, declaresEqualsMethod, declaresGetHashCodeMethod, declaresToStringMethod);

            this.RequiresComparability = requiresComparability;
            this.RequiresDeepCloning = requiresDeepCloning;
            this.RequiresEquality = requiresEquality;
            this.RequiresHashing = requiresHashing;
            this.RequiresModel = requiresModel;
            this.RequiresStringRepresentation = requiresStringRepresentation;
            this.ForsakesDeepCloneWithVariantMethods = forsakesDeepCloneWithVariantMethods;
            this.DeclaresCompareToMethod = declaresCompareToMethod;
            this.DeclaresDeepCloneMethod = declaresDeepCloneMethod;
            this.DeclaresEqualsMethod = declaresEqualsMethod;
            this.DeclaresGetHashCodeMethod = declaresGetHashCodeMethod;
            this.DeclaresToStringMethod = declaresToStringMethod;

            this.RequiredInterfaces = DetermineRequiredInterfaces(type, requiresModel, requiresDeepCloning, requiresEquality, requiresHashing, requiresStringRepresentation, requiresComparability);

            this.CompareToKeyMethodKinds = declaresCompareToMethod ? KeyMethodKinds.Declared : KeyMethodKinds.Generated;
            this.DeepCloneKeyMethodKinds = declaresDeepCloneMethod ? KeyMethodKinds.Declared : KeyMethodKinds.Generated;
            this.EqualsKeyMethodKinds = declaresEqualsMethod ? KeyMethodKinds.Declared : KeyMethodKinds.Generated;
            this.GetHashCodeKeyMethodKinds = declaresGetHashCodeMethod ? KeyMethodKinds.Declared : KeyMethodKinds.Generated;
            this.ToStringKeyMethodKinds = declaresToStringMethod ? KeyMethodKinds.Declared : KeyMethodKinds.Generated;

            // Constructor
            var getConstructorResult = GetConstructorAndThrowIfNotSupported(type, propertiesOfConcern, declaredOnlyPropertiesOfConcern, this.CaseInsensitivePropertyNameToPropertyOfConcernMap);
            this.Constructor = getConstructorResult.ConstructorInfo;
            this.PropertyNameToConstructorParameterTypeMap = getConstructorResult.PropertyNameToConstructorParameterTypeMap;

            // Types Names
            this.InheritancePathTypeNamesInCode = type.GetInheritancePath().Reverse().Skip(1).Reverse().Select(_ => _.ToStringReadable()).ToList();
            this.InheritancePathTypeNamesInTestMethodNames = type.GetInheritancePath().Reverse().Skip(1).Reverse().Select(_ => _.GetTypeNameInTestMethodName()).ToList();

            this.DerivativePathTypesNamesInCodeFromRootToSelf = this.InheritancePathTypeNamesInCode.Reverse().Concat(new[] { type.ToStringReadable() }).ToList();
            this.DerivativePathTypesNamesInTestMethodNamesFromRootToSelf = this.InheritancePathTypeNamesInTestMethodNames.Reverse().Concat(new[] { type.GetTypeNameInTestMethodName() }).ToList();
            this.GenericParameters = type.IsGenericType ? type.GetGenericArguments().ToList() : new List<Type>();

            this.TypeNameInCodeString = type.ToStringReadable();
            this.TypeNameInTestMethodNameString = type.GetTypeNameInTestMethodName();
            this.TypeNameInIdentifierString = type.ToStringWithoutGenericComponent();
            this.TypeNameInTestClassNameString = type.GetTestClassName();
            this.TypeNameInXmlDocString = type.ToStringXmlDoc();
            this.TypeNamespace = type.Namespace;

            // Namespaces
            this.NamespacesOfTypesInInheritancePath = GetNamespacesOfTypesInInheritancePath(type);
            this.NamespacesOfTypesInPropertiesOfConcern = GetNamespacesOfTypesInPropertiesOfConcern(propertiesOfConcern);

            // Example Types
            this.ExampleClosedModelType = GetExampleClosedModelType(type);
            this.ExampleConcreteDerivativeTypeNamesInCodeStrings = GetExampleConcreteDerivativeTypeNamesInCodeStrings(type);
            this.ExampleAncestorConcreteDerivativeTypeNamesInCodeStrings = GetExampleAncestorConcreteDerivativeTypeNamesInCodeStrings(type);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = this.underlyingType.ToStringReadable();

            return result;
        }

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

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        private static void ThrowIfModelTypeNotSupported(
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

            // We are OK with other kinds of read-only properties (e.g. expression-bodied properties),
            // but a read-only auto property can be written-to via the constructor, and these properties don't play nice with BSON serialization.
            var publicProperties = type.GetPropertiesFiltered(MemberRelationships.DeclaredInTypeOrAncestorTypes, MemberOwners.Instance, MemberAccessModifiers.Public);

            var readOnlyAutoProperties = publicProperties.Where(_ => _.IsReadOnlyAutoProperty()).ToList();

            if (readOnlyAutoProperties.Any())
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains the following read-only auto properties: {readOnlyAutoProperties.Select(_ => _.Name).ToDelimitedString(", ")}."));
            }
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        private static void ThrowIfPropertiesOfConcernNotSupported(
            Type type,
            IReadOnlyList<PropertyInfo> propertiesOfConcern)
        {
            if (propertiesOfConcern.Any(_ => (!_.SetMethod.IsPublic) && (!_.SetMethod.IsPrivate)))
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; it contains properties of concern that are neither private nor public; only private and public setters are supported."));
            }

            if ((propertiesOfConcern.GroupBy(_ => _.SetMethod.IsPrivate).Count() > 1) || (propertiesOfConcern.GroupBy(_ => _.SetMethod.IsPublic).Count() > 1))
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

        private static IReadOnlyList<PropertyInfo> GetPropertiesOfConcernInOrder(
            Type type)
        {
            var publicProperties = type.GetPropertiesFiltered(MemberRelationships.DeclaredInTypeOrAncestorTypes, MemberOwners.Instance, MemberAccessModifiers.Public, orderMembersBy: OrderMembersBy.DeclaringTypeDerivationPath);

            var result = publicProperties.Where(_ => _.IsWritableProperty()).ToList();

            return result;
        }

        private static PropertyOfConcern ToPropertyOfConcern(
            PropertyInfo propertyInfo)
        {
            var result = new PropertyOfConcern(propertyInfo.PropertyType, propertyInfo.Name, propertyInfo.DeclaringType);

            return result;
        }

        private static void ThrowIfRequiredAndDeclaredMethodsNotSupported(
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
                result = type.HasObjectAsBaseType()
                    ? HierarchyKind.AbstractBaseRoot
                    : HierarchyKind.AbstractBaseInherited;
            }
            else if (type.HasObjectAsBaseType())
            {
                result = HierarchyKind.Standalone;
            }
            else
            {
                result = HierarchyKind.ConcreteInherited;
            }

            return result;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        private static GetConstructorResult GetConstructorAndThrowIfNotSupported(
            Type type,
            IReadOnlyList<PropertyInfo> propertiesOfConcern,
            IReadOnlyList<PropertyInfo> declaredOnlyPropertiesOfConcern,
            IReadOnlyDictionary<string, PropertyOfConcern> caseInsensitivePropertyNameToPropertyOfConcernMap)
        {
            ConstructorInfo constructorInfo;

            var propertyNameToConstructorParameterTypeMap = new Dictionary<string, Type>();

            var publicConstructors = type.GetConstructorsFiltered(MemberRelationships.DeclaredInType, MemberOwners.Instance, MemberAccessModifiers.Public);

            if (type.IsAbstract)
            {
                if (publicConstructors.Any())
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; there is at least one public constructor, but the class is abstract.  Abstract classes should not have public constructors."));
                }

                constructorInfo = null;
            }
            else
            {
                if (!publicConstructors.Any())
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; the class is concrete, but there are no public constructors.  Concrete classes should have at least one public constructor."));
                }

                // We don't want a strict 1:1 match between constructor parameters and properties.  Consider these types:
                // public class BaseClass
                // {
                //    public BaseClass(int property1, string property2) { ... }
                // }
                // public class DerivedClass : BaseClass
                // {
                //    public DerivedClass(string property2) : base(Constants.SomeIntConstant, property2) { ... }
                // }
                var candidateConstructors = type.GetConstructorsMatchedToProperties(propertiesOfConcern, ConstructorsMatchedToPropertiesStrategy.AllConstructorParametersHaveMatchingProperty, MemberAccessModifiers.Public, MemberRelationships.DeclaredInType);

                if (candidateConstructors.Count == 0)
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; none of its public constructors have parameters where all parameters have a matching property by name and type."));
                }

                var maxParameterCount = candidateConstructors.Max(_ => _.GetParameters().Length);

                candidateConstructors = candidateConstructors.Where(_ => _.GetParameters().Length == maxParameterCount).ToList();

                if (candidateConstructors.Count > 1)
                {
                    throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; there are {candidateConstructors.Count} public constructors having the most number of parameters ({maxParameterCount}) where all parameters have a matching property by name type, whereas only 1 was expected."));
                }

                constructorInfo = candidateConstructors.Single();

                if (constructorInfo.IsDefaultConstructor())
                {
                    if (!propertiesOfConcern.All(_ => _.SetMethod.IsPublic))
                    {
                        throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; the public constructor that best matches the properties of concern is the default (parameterless) constructor but one or more of these properties has a non-public setter."));
                    }
                }
                else
                {
                    if (propertiesOfConcern.Any(_ => _.SetMethod.IsPublic))
                    {
                        throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; the public constructor that best matches the properties of concern is parameterized but one or more of these properties has a public setter."));
                    }

                    // all of the declared properties have to appear in the parameter list
                    var constructorParameterNames = new HashSet<string>(constructorInfo.GetParameters().Select(_ => _.Name), StringComparer.OrdinalIgnoreCase);

                    if (declaredOnlyPropertiesOfConcern.Any(_ => !constructorParameterNames.Contains(_.Name)))
                    {
                        throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; the public constructor that best matches the properties of concern is parameterized but one or more of the properties declared on the type (not inherited) does not match a parameter in that constructor."));
                    }

                    foreach (var constructorParameter in constructorInfo.GetParameters())
                    {
                        var propertyOfConcern = caseInsensitivePropertyNameToPropertyOfConcernMap[constructorParameter.Name];

                        propertyNameToConstructorParameterTypeMap.Add(propertyOfConcern.Name, constructorParameter.ParameterType);
                    }
                }
            }

            var result = new GetConstructorResult
            {
                ConstructorInfo = constructorInfo,
                PropertyNameToConstructorParameterTypeMap = propertyNameToConstructorParameterTypeMap,
            };

            return result;
        }

        private static bool IsDictionaryKeyedOnGenericTypeParameter(
            Type type,
            Type genericArgumentType)
        {
            if (type.IsSystemDictionaryType())
            {
                var keyType = type.GetGenericArguments().First();

                if (keyType == genericArgumentType)
                {
                    return true;
                }
            }

            return false;
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
            IReadOnlyList<PropertyInfo> propertiesOfConcern,
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
                        var propertiesOfConcern = GetPropertiesOfConcernInOrder(genericTypeArgument);

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
                var propertiesOfConcern = GetPropertiesOfConcernInOrder(type);

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

        private static IReadOnlyCollection<string> GetExampleConcreteDerivativeTypeNamesInCodeStrings(
            Type type)
        {
            Type typeToUse = type;

            if (type.IsClosedGenericType())
            {
                typeToUse = type.GetGenericTypeDefinition();
            }

            var result = GetConcreteDerivativeTypes(typeToUse)
                .Where(_ => _.Namespace == type.Namespace)
                .Select(_ => GetExampleClosedModelType(_))
                .Where(type.IsAssignableFrom)
                .Select(_ => _.ToStringReadable())
                .OrderBy(_ => _)
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
                .Where(_ => _.Namespace == type.Namespace)
                .Select(_ => GetExampleClosedModelType(_))
                .Select(_ => _.ToStringReadable())
                .OrderBy(_ => _)
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

        private static IReadOnlyList<Type> GetInheritancePathWithInterfacesConvertingGenericsToGenericTypeDefinitions(
            Type type)
        {
            var inheritancePath = GetInheritancePathConvertingGenericsToGenericTypeDefinitions(type);

            var result = inheritancePath.ToList();

            var typesToGetInterfaces = new Type[0]
                .Concat(inheritancePath)
                .Concat(new[] { type })
                .ToList();

            foreach (var typeToGetInterfaces in typesToGetInterfaces)
            {
                var interfaces = typeToGetInterfaces.GetInterfaces().Select(_ => _.IsGenericType ? _.GetGenericTypeDefinition() : _).ToList();

                result.AddRange(interfaces);
            }

            result = result.Distinct().ToList();

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
            IReadOnlyList<PropertyInfo> propertiesOfConcern)
        {
            var types = propertiesOfConcern.Select(_ => _.PropertyType).Distinct().ToList();

            var result = types.SelectMany(GetNamespacesInUse).Distinct().ToList();

            return result;
        }

        private static IReadOnlyCollection<string> GetNamespacesOfTypesInInheritancePath(
            Type type)
        {
            var types = type.GetInheritancePath().Except(new[] { typeof(object) }).ToList();

            var result = types.SelectMany(GetNamespacesInUse).Distinct().ToList();

            return result;
        }

        private static IReadOnlyCollection<string> GetNamespacesInUse(
            Type type)
        {
            var result = new List<string> { type.Namespace };

            if (type.IsGenericType)
            {
                var genericArguments = type.GetGenericArguments();

                foreach (var genericArgument in genericArguments)
                {
                    result.AddRange(GetNamespacesInUse(genericArgument));
                }
            }

            if (type.IsArray)
            {
                result.AddRange(GetNamespacesInUse(type.GetElementType()));
            }

            return result;
        }

        private static Type GetExampleClosedModelTypeOrNull(
            Type type,
            IReadOnlyCollection<Type> previouslySeenTypes)
        {
            Type result;

            try
            {
                result = GetExampleClosedModelType(type, previouslySeenTypes);
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }

        private static Type GetExampleClosedModelType(
            Type type,
            IReadOnlyCollection<Type> previouslySeenTypes = null)
        {
            if ((previouslySeenTypes != null) && previouslySeenTypes.Contains(type))
            {
                throw new InvalidOperationException("This type has already been seen: " + previouslySeenTypes);
            }

            previouslySeenTypes = previouslySeenTypes?.Concat(new[] { type }).ToArray() ?? new Type[0];

            if (!type.ContainsGenericParameters)
            {
                return type;
            }

            var genericArguments = type.GetGenericArguments();

            // first, we get example types for all generic arguments, without consideration for constraints
            var exampleUnconstrainedGenericArguments = GetExampleUnconstrainedGenericArguments(genericArguments);

            // next, we iterate thru each generic argument and attempt to get a type that satisfies all constraints
            // we keep doing this until we have a type that satisfies the constraints of all generic arguments
            // or until we are no longer making progress towards that end.
            var exampleConstrainedGenericArguments = new Type[genericArguments.Length];

            int resolvedGenericArgumentsBefore, resolvedGenericArgumentsAfter;

            do
            {
                resolvedGenericArgumentsBefore = exampleConstrainedGenericArguments.Count(_ => _ != null);

                for (var x = 0; x < genericArguments.Length; x++)
                {
                    if (exampleConstrainedGenericArguments[x] == null)
                    {
                        var genericArgumentToConstrainedGenericArgumentMap = exampleConstrainedGenericArguments.Select((t, i) => new { Type = t, Index = i }).ToDictionary(_ => genericArguments[_.Index], _ => exampleConstrainedGenericArguments[_.Index]);

                        exampleConstrainedGenericArguments[x] = GetExampleTypeThatSatisfiesGenericArgumentConstraints(type, genericArguments[x], exampleUnconstrainedGenericArguments[x], genericArgumentToConstrainedGenericArgumentMap, previouslySeenTypes);
                    }
                }

                resolvedGenericArgumentsAfter = exampleConstrainedGenericArguments.Count(_ => _ != null);
            }
            while ((resolvedGenericArgumentsAfter > resolvedGenericArgumentsBefore) && (resolvedGenericArgumentsAfter != genericArguments.Length));

            if (!type.TryMakeGenericType(out Type result, exampleConstrainedGenericArguments.ToArray()))
            {
                throw new NotSupportedException(Invariant($"This type ({type.ToStringReadable()}) is not supported; cannot find suitable type(s) for the generic argument(s) that satisfy all constraints."));
            }

            return result;
        }

        private static IReadOnlyList<Type> GetExampleUnconstrainedGenericArguments(
            IReadOnlyList<Type> genericArguments)
        {
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
            var result = new List<Type>();

            foreach (var genericArgument in genericArguments)
            {
                Type exampleUnconstrainedGenericArgument;

                var attributes = genericArgument.GenericParameterAttributes;

                var specialConstraints = attributes & GenericParameterAttributes.SpecialConstraintMask;

                if (specialConstraints == GenericParameterAttributes.None)
                {
                    exampleUnconstrainedGenericArgument = typeof(Version);
                }
                else
                {
                    // these are not really mutually exclusive (per documentation above), but we need to pick a single type.
                    if ((specialConstraints & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0)
                    {
                        exampleUnconstrainedGenericArgument = typeof(Guid);
                    }
                    else if ((specialConstraints & GenericParameterAttributes.ReferenceTypeConstraint) != 0)
                    {
                        exampleUnconstrainedGenericArgument = typeof(Version);
                    }
                    else if ((specialConstraints & GenericParameterAttributes.DefaultConstructorConstraint) != 0)
                    {
                        exampleUnconstrainedGenericArgument = typeof(Version);
                    }
                    else
                    {
                        throw new InvalidOperationException("Should not get here.");
                    }
                }

                result.Add(exampleUnconstrainedGenericArgument);
            }

            return result;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "This needs refactoring.  At some point we're going to overhaul this heuristic to be more complete and we can tackle the refactor at that point.")]
        private static Type GetExampleTypeThatSatisfiesGenericArgumentConstraints(
            Type modelType,
            Type genericArgument,
            Type exampleUnconstrainedGenericArgument,
            IReadOnlyDictionary<Type, Type> genericArgumentToExampleConstrainedGenericArgumentMap,
            IReadOnlyCollection<Type> previouslySeenTypes)
        {
            var constraints = genericArgument.GetGenericParameterConstraints();

            var result = exampleUnconstrainedGenericArgument;

            foreach (var constraint in constraints)
            {
                if (constraint.IsClass && (!constraint.IsAbstract))
                {
                    // This is super bad practice.  What does a non-abstract class constraint mean?  Why is the generic argument there to begin with
                    // (instead of just hard-coding the class wherever the generic argument is used)?
                    // Anyways, we don't allow non-abstract models to derive from other non-abstract models.
                    throw new NotSupportedException(Invariant($"This type ({modelType.ToStringReadable()}) is not supported; generic argument '{genericArgument.Name}' is constrained to '{constraint.ToStringReadable()}' which itself is a non-abstract class.  Class constraints should be abstract."));
                }

                // If the constraint is an open type, the only possible generic parameters are the generic parameters
                // of the model type itself (e.g. where T1 : BaseClass<T2>).  So check if the generic parameters in-use
                // already have resolved/example types and close-up the constraint.
                var closedConstraint = constraint;

                if (constraint.ContainsGenericParameters)
                {
                    var genericParametersInUse = GetGenericParametersInUse(constraint);

                    if (genericParametersInUse.Any(_ => genericArgumentToExampleConstrainedGenericArgumentMap[_] == null))
                    {
                        return null;
                    }

                    try
                    {
                        closedConstraint = MakeClosedConstraintType(constraint, genericArgumentToExampleConstrainedGenericArgumentMap);
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }

                // Is the current candidate assignable to the the closed constraint?
                // If not, we need to find a derivative of the closed constraint and make that the new candidate.
                if (!closedConstraint.IsAssignableFrom(result))
                {
                    var candidateTypes = LoadedTypes
                        .Where(_ => _.IsClass)
                        .Where(_ => !_.IsAbstract)
                        .Where(_ => _.Namespace == modelType.Namespace)
                        .ToList();

                    var constraintTypeToSearchForInInheritancePath = closedConstraint.IsGenericType
                        ? closedConstraint.GetGenericTypeDefinition()
                        : closedConstraint;

                    // constraintTypeToSearchForInInheritancePath is an ancestor (interfaces included) of the loaded type?
                    candidateTypes = candidateTypes
                        .Where(_ => GetInheritancePathWithInterfacesConvertingGenericsToGenericTypeDefinitions(_).Contains(constraintTypeToSearchForInInheritancePath))
                        .ToList();

                    var passingTypes = new List<Type>();

                    foreach (var candidateType in candidateTypes)
                    {
                        // The candidate may or may not be closed; get an example closed version
                        var exampleClosedCandidateType = GetExampleClosedModelTypeOrNull(candidateType, previouslySeenTypes);

                        // Is it assignable to the constraint?
                        if ((exampleClosedCandidateType != null) && closedConstraint.IsAssignableFrom(exampleClosedCandidateType))
                        {
                            passingTypes.Add(exampleClosedCandidateType);
                        }
                    }

                    if (!passingTypes.Any())
                    {
                        return null;
                    }

                    // Note that a further improvement would actually test all passing types against the remaining constraints.
                    // Also, we are choosing the type with the most number public properties so that it is more likely that we
                    // can create two dummies of that type that are NOT equal (which we do a lot of in testing).
                    result = passingTypes
                        .Select(_ =>
                            new
                            {
                                Type = _,
                                NumberOfProperties = _.GetPropertiesFiltered(MemberRelationships.DeclaredOrInherited, MemberOwners.Instance, MemberAccessModifiers.Public).Count,
                            })
                        .OrderByDescending(_ => _.NumberOfProperties)
                        .ThenBy(_ => _.Type.Name)
                        .Select(_ => _.Type)
                        .First();
                }
            }

            return result;
        }

        private static IReadOnlyCollection<Type> GetGenericParametersInUse(
            Type type)
        {
            var genericArguments = type.GetGenericArguments();

            var result = new List<Type>();

            foreach (var genericArgument in genericArguments)
            {
                if (genericArgument.IsGenericParameter)
                {
                    result.Add(genericArgument);
                }
                else if (genericArgument.IsGenericType)
                {
                    result.AddRange(GetGenericParametersInUse(genericArgument));
                }
            }

            result = result.Distinct().ToList();

            return result;
        }

        private static Type MakeClosedConstraintType(
            Type type,
            IReadOnlyDictionary<Type, Type> genericArgumentToExampleConstrainedGenericArgumentMap)
        {
            Type result;

            if (type.IsGenericParameter)
            {
                result = genericArgumentToExampleConstrainedGenericArgumentMap[type];
            }
            else if (type.ContainsGenericParameters)
            {
                var genericArguments = type.GetGenericArguments();

                var genericArgumentsToUse = new List<Type>();

                foreach (var genericArgument in genericArguments)
                {
                    var genericArgumentToUse = MakeClosedConstraintType(genericArgument, genericArgumentToExampleConstrainedGenericArgumentMap);

                    genericArgumentsToUse.Add(genericArgumentToUse);
                }

                result = type.GetGenericTypeDefinition().MakeGenericType(genericArgumentsToUse.ToArray());
            }
            else
            {
                result = type;
            }

            return result;
        }

        private static IReadOnlyCollection<Type> GetGenericParametersUsedAsKeyInDictionary(
            Type type,
            IReadOnlyList<PropertyInfo> propertiesOfConcern)
        {
            var genericArguments = type.GetGenericArguments();

            var result = new List<Type>();

            foreach (var genericArgument in genericArguments)
            {
                var dictionaryKeyedOnGenericArgument = propertiesOfConcern.Any(_ => IsOrContainsMatchingType(_.PropertyType, localType => IsDictionaryKeyedOnGenericTypeParameter(localType, genericArgument)));

                if (dictionaryKeyedOnGenericArgument)
                {
                    result.Add(genericArgument);
                }
            }

            return result;
        }

        private class GetConstructorResult
        {
            public ConstructorInfo ConstructorInfo { get; set; }

            public IReadOnlyDictionary<string, Type> PropertyNameToConstructorParameterTypeMap { get; set; }
        }
    }
}
