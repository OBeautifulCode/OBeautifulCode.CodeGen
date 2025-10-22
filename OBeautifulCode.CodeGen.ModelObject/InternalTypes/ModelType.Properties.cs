// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelType.Properties.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Reflection;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject;
    using OBeautifulCode.Type;

    internal partial class ModelType
    {
        private readonly Type underlyingType;

        /// <summary>
        /// Gets the inheritance path type names as they should be used in generated code.
        /// </summary>
        public IReadOnlyList<string> InheritancePathTypeNamesInCode { get; }

        /// <summary>
        /// Gets the inheritance path types names as they should be used in test method names.
        /// </summary>
        public IReadOnlyList<string> InheritancePathTypeNamesInTestMethodNames { get; }

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
        /// Gets the name of the type as it should be used in the name of a test class.
        /// </summary>
        public string TypeNameInTestClassNameString { get; }

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
        public IReadOnlyList<string> DerivativePathTypesNamesInCodeFromRootToSelf { get; }

        /// <summary>
        /// Gets the names the model's derivative path as they should appear in test method names,
        /// starting at the root type and ending in the model type itself.
        /// </summary>
        public IReadOnlyList<string> DerivativePathTypesNamesInTestMethodNamesFromRootToSelf { get; }

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
        /// Gets a map of property name to the type of it's matching constructor parameter.
        /// </summary>
        public IReadOnlyDictionary<string, Type> PropertyNameToConstructorParameterTypeMap { get; }

        /// <summary>
        /// Gets a map of constructor parameter name to property of concern.
        /// </summary>
        public IReadOnlyDictionary<string, PropertyOfConcern> CaseInsensitivePropertyNameToPropertyOfConcernMap { get; }

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
        /// Gets a value indicating whether the model requires generated code for validation.
        /// </summary>
        public bool RequiresValidation { get; }

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
        /// Gets a value indicating whether the model declares a <see cref="IDeclareGetSelfValidationFailuresMethod.GetSelfValidationFailures"/> method.
        /// </summary>
        public bool DeclaresGetSelfValidationFailuresMethod { get; }

        /// <summary>
        /// Gets a value indicating whether the model implements <see cref="IDeclareGetSelfValidationFailuresMethod"/> directly or indirectly.
        /// </summary>
        public bool DeclaresGetSelfValidationFailuresMethodInSelfOrInheritancePath { get; }

        /// <summary>
        /// Gets a value indicating whether the model forsakes the generation of DeepCloneWith variant methods.
        /// </summary>
        public bool ForsakesDeepCloneWithVariantMethods { get; }

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
        /// Gets the key method kind for the <see cref="IDeclareGetSelfValidationFailuresMethod.GetSelfValidationFailures"/> method.
        /// </summary>
        public KeyMethodKinds ValidationKeyMethodKinds { get; }

        /// <summary>
        /// Gets the namespaces of the types in the properties of concern.
        /// </summary>
        public IReadOnlyCollection<string> NamespacesOfTypesInPropertiesOfConcern { get; }

        /// <summary>
        /// Gets the namespaces of the types in the inheritance path.
        /// </summary>
        public IReadOnlyCollection<string> NamespacesOfTypesInInheritancePath { get; }

        /// <summary>
        /// Gets the namespaces of the types in the example closed model type.
        /// </summary>
        public IReadOnlyCollection<string> NamespacesOfTypesInExampleClosedModelType { get; }

        /// <summary>
        /// Gets the generic parameters.
        /// </summary>
        public IReadOnlyList<Type> GenericParameters { get; }

        /// <summary>
        /// Gets a closed version of the model type.
        /// </summary>
        public Type ExampleClosedModelType { get; }

        /// <summary>
        /// Gets the generic parameters that are used as a key in a dictionary within the model.
        /// </summary>
        public IReadOnlyCollection<Type> GenericParametersUsedAsKeyInDictionary { get; }
    }
}
