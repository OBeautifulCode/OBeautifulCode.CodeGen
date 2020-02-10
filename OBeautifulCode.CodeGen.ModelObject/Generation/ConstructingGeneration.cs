// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstructingGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Internal;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to constructing a model object.
    /// </summary>
    internal static class ConstructingGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";
        private const string ConstructorParameterToken = "<<<ConstructorParameterUnderTest>>>";
        private const string ConstructorTestInflationToken = "<<<ConstructorTestMethodsInflatedGoesHere>>>";
        private const string NewObjectTestToken = "<<<NewObjectHere>>>";
        private const string PropertyNameToken = "<<<PropertyNameHere>>>";
        private const string AssertPropertyGetterToken = "<<<AssertPropertyGetterHere>>>";
        private const string NewObjectForGetterTestToken = "<<<NewObjectWithOneArgumentFromOtherHere>>>";
        private const string SetDictionaryValueToNullToken = "<<<SetDictionaryValueToNullHere>>>";

        private const string ConstructingTestMethodsCodeTemplate = @"    public static class Constructing
        {" + ConstructorTestInflationToken + @"
        }";

        private const string ConstructorTestMethodForArgumentCodeTemplate = @"
            [Fact]
            public static void Constructor___Should_throw_ArgumentNullException___When_parameter_" + ConstructorParameterToken + @"_is_null()
            {
                // Arrange
                var referenceObject = A.Dummy<" + TypeNameToken + @">();

                // Act
                var actual = Record.Exception(
                    () => " + NewObjectTestToken + @");

                // Assert
                actual.AsTest().Must().BeOfType<ArgumentNullException>();
                actual.Message.AsTest().Must().ContainString(""" + ConstructorParameterToken + @""");
            }";

        private const string ConstructorTestMethodForStringArgumentCodeTemplate = @"
            [Fact]
            public static void Constructor___Should_throw_ArgumentException___When_parameter_" + ConstructorParameterToken + @"_is_white_space()
            {
                // Arrange
                var referenceObject = A.Dummy<" + TypeNameToken + @">();

                // Act
                var actual = Record.Exception(
                    () => " + NewObjectTestToken + @");

                // Assert
                actual.AsTest().Must().BeOfType<ArgumentException>();
                actual.Message.AsTest().Must().ContainString(""" + ConstructorParameterToken + @""");
                actual.Message.AsTest().Must().ContainString(""white space"");
            }";

        private const string ConstructorTestMethodForCollectionArgumentThatIsEmptyCodeTemplate = @"
            [Fact]
            public static void Constructor___Should_throw_ArgumentException___When_parameter_" + ConstructorParameterToken + @"_is_empty()
            {
                // Arrange
                var referenceObject = A.Dummy<" + TypeNameToken + @">();

                // Act
                var actual = Record.Exception(
                    () => " + NewObjectTestToken + @");

                // Assert
                actual.AsTest().Must().BeOfType<ArgumentException>();
                actual.Message.AsTest().Must().ContainString(""" + ConstructorParameterToken + @""");
                actual.Message.AsTest().Must().ContainString(""is an empty enumerable"");
            }";

        private const string ConstructorTestMethodForCollectionArgumentThatContainsNullElementCodeTemplate = @"
            [Fact]
            public static void Constructor___Should_throw_ArgumentException___When_parameter_" + ConstructorParameterToken + @"_contains_a_null_element()
            {
                // Arrange
                var referenceObject = A.Dummy<" + TypeNameToken + @">();

                // Act
                var actual = Record.Exception(
                    () => " + NewObjectTestToken + @");

                // Assert
                actual.AsTest().Must().BeOfType<ArgumentException>();
                actual.Message.AsTest().Must().ContainString(""" + ConstructorParameterToken + @""");
                actual.Message.AsTest().Must().ContainString(""contains at least one null element"");
            }";

        private const string ConstructorTestMethodForDictionaryArgumentThatIsEmptyCodeTemplate = @"
            [Fact]
            public static void Constructor___Should_throw_ArgumentException___When_parameter_" + ConstructorParameterToken + @"_is_empty()
            {
                // Arrange
                var referenceObject = A.Dummy<" + TypeNameToken + @">();

                // Act
                var actual = Record.Exception(
                    () => " + NewObjectTestToken + @");

                // Assert
                actual.AsTest().Must().BeOfType<ArgumentException>();
                actual.Message.AsTest().Must().ContainString(""" + ConstructorParameterToken + @""");
                actual.Message.AsTest().Must().ContainString(""is an empty dictionary"");
            }";

        private const string ConstructorTestMethodForDictionaryArgumentThatContainsNullValueCodeTemplate = @"
            [Fact]
            public static void Constructor___Should_throw_ArgumentException___When_parameter_" + ConstructorParameterToken + @"_contains_a_null_value()
            {
                // Arrange
                var referenceObject = A.Dummy<" + TypeNameToken + @">();

                " + SetDictionaryValueToNullToken + @"
                var randomKey = dictionaryWithNullValue.Keys.ElementAt(ThreadSafeRandom.Next(0, dictionaryWithNullValue.Count));
                dictionaryWithNullValue[randomKey] = null;

                // Act
                var actual = Record.Exception(
                    () => " + NewObjectTestToken + @");

                // Assert
                actual.AsTest().Must().BeOfType<ArgumentException>();
                actual.Message.AsTest().Must().ContainString(""" + ConstructorParameterToken + @""");
                actual.Message.AsTest().Must().ContainString(""contains at least one key-value pair with a null value"");
            }";

        private const string PropertyGetterTestMethodTemplate = @"
            [Fact]
            public static void " + PropertyNameToken + @"___Should_return_same_" + ConstructorParameterToken + @"_parameter_passed_to_constructor___When_getting()
            {
                // Arrange
                var referenceObject = A.Dummy<" + TypeNameToken + @">();

                var systemUnderTest = " + NewObjectForGetterTestToken + @";

                var expected = referenceObject." + PropertyNameToken + @";

                // Act
                var actual = systemUnderTest." + PropertyNameToken + @";

                // Assert
                " + AssertPropertyGetterToken + @"
            }";

        /// <summary>
        /// Generates code that instantiates a model object.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <param name="memberCode">The code for the members.</param>
        /// <param name="parameterPaddingLength">The length of the padding to use for constructor or object initializer parameters.</param>
        /// <returns>
        /// Generated code that instantiates a model object.
        /// </returns>
        public static string GenerateModelInstantiation(
            this ModelType modelType,
            IReadOnlyList<MemberCode> memberCode,
            int parameterPaddingLength)
        {
            new { modelType }.AsArg().Must().NotBeNull();
            new { memberCode }.AsArg().Must().NotBeNull().And().NotContainAnyNullElements();

            string result;

            var memberNames = memberCode.Select(_ => _.Name).ToList();

            var parameterPadding = new string(' ', parameterPaddingLength);

            var constructorInfo = modelType
                .Constructors
                .SingleOrDefault(
                    _ =>
                    {
                        var parameterNames = _.GetParameters().Select(p => p.Name).ToList();

                        var foundMatchingConstructor = !parameterNames.SymmetricDifference(memberNames, StringComparer.OrdinalIgnoreCase).Any();

                        return foundMatchingConstructor;
                    });

            if (constructorInfo != null)
            {
                var propertyNameToCodeMap = memberCode.ToDictionary(_ => _.Name, _ => _.Code, StringComparer.OrdinalIgnoreCase);

                var parameters = constructorInfo.GetParameters();

                var parameterCode =
                    parameters
                    .Select(_ => propertyNameToCodeMap[_.Name])
                    .ToDelimitedString("," + Environment.NewLine + parameterPadding);

                result = "new " + modelType.TypeCompilableString + "(" + (parameters.Any() ? Environment.NewLine + parameterPadding : string.Empty) + parameterCode + ")";
            }
            else if (modelType.PropertiesOfConcern.All(_ => !_.IsGetterOnly))
            {
                var curlyBracketPadding = new string(' ', parameterPaddingLength - 4);

                var maxCharsInAnyPropertyName = memberNames.Any() ? memberNames.Select(_ => _.Length).Max() : 0;

                var propertyInitializerCode = memberCode.Select(_ => Invariant($"{_.Name.PadRight(maxCharsInAnyPropertyName, ' ')} = {_.Code}")).ToDelimitedString("," + Environment.NewLine + parameterPadding);

                result = "new " + modelType.TypeCompilableString + Environment.NewLine + curlyBracketPadding + "{" + Environment.NewLine + parameterPadding + propertyInitializerCode + "," + Environment.NewLine + curlyBracketPadding + "}";
            }
            else
            {
                var propertiesAddIn = string.Join(",", modelType.PropertiesOfConcern.Select(_ => _.Name));

                throw new NotSupportedException("Could not find a constructor to take properties of concern and they are not all settable: " + propertiesAddIn);
            }

            return result;
        }

        /// <summary>
        /// Generates test methods that test a model's constructor.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test a model's constructor.
        /// </returns>
        [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = ObcSuppressBecause.CA_ALL_SeeOtherSuppressionMessages)]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
        public static string GenerateConstructorTestMethods(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            string result = null;

            var constructorWithParameters = modelType.Constructors.SingleOrDefault(_ => _.GetParameters().Length > 0);

            if (constructorWithParameters != null)
            {
                var testMethods = new List<string>();

                var parameters = constructorWithParameters.GetParameters();
                foreach (var parameter in parameters.Where(_ => !_.ParameterType.IsValueType))
                {
                    var parametersCode = parameters.Select(_ =>
                    {
                        var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                        return new MemberCode(_.Name, _.Name == parameter.Name ? "null" : referenceObject);
                    }).ToList();

                    var objectInstantiationCode = modelType.GenerateModelInstantiation(parametersCode, parameterPaddingLength: 34);

                    var testMethod = ConstructorTestMethodForArgumentCodeTemplate
                                    .Replace(TypeNameToken,             modelType.TypeCompilableString)
                                    .Replace(ConstructorParameterToken, parameter.Name)
                                    .Replace(NewObjectTestToken,        objectInstantiationCode);

                    testMethods.Add(testMethod);

                    if (parameter.ParameterType == typeof(string))
                    {
                        var stringParameterCode = parameters.Select(_ =>
                        {
                            var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                            return new MemberCode(_.Name, _.Name == parameter.Name ? "Invariant($\"  {Environment.NewLine}  \")" : referenceObject);
                        }).ToList();

                        objectInstantiationCode = modelType.GenerateModelInstantiation(stringParameterCode, parameterPaddingLength: 34);

                        var stringTestMethod = ConstructorTestMethodForStringArgumentCodeTemplate
                                              .Replace(TypeNameToken,             modelType.TypeCompilableString)
                                              .Replace(ConstructorParameterToken, parameter.Name)
                                              .Replace(NewObjectTestToken,        objectInstantiationCode);

                        testMethods.Add(stringTestMethod);
                    }

                    if (parameter.ParameterType.IsClosedSystemCollectionType() || parameter.ParameterType.IsArray)
                    {
                        // add test for empty collection or array
                        var collectionParameterCode = parameters.Select(_ =>
                        {
                            var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                            return new MemberCode(_.Name, _.Name == parameter.Name ? parameter.ParameterType.GenerateSystemTypeInstantiationCode() : referenceObject);
                        }).ToList();

                        objectInstantiationCode = modelType.GenerateModelInstantiation(collectionParameterCode, parameterPaddingLength: 34);

                        var collectionTestMethod = ConstructorTestMethodForCollectionArgumentThatIsEmptyCodeTemplate
                            .Replace(TypeNameToken, modelType.TypeCompilableString)
                            .Replace(ConstructorParameterToken, parameter.Name)
                            .Replace(NewObjectTestToken, objectInstantiationCode);

                        testMethods.Add(collectionTestMethod);

                        // add test for collection or array containing null element
                        // we are specifically EXCLUDING nullable types here
                        var elementType = parameter.ParameterType.IsArray
                            ? parameter.ParameterType.GetElementType()
                            : parameter.ParameterType.GetClosedSystemCollectionElementType();

                        if (!elementType.IsValueType)
                        {
                            collectionParameterCode = parameters.Select(_ =>
                            {
                                var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                                if (_.Name == parameter.Name)
                                {
                                    referenceObject = Invariant($"new {elementType.ToStringCompilable()}[0].Concat({referenceObject}).Concat(new {elementType.ToStringCompilable()}[] {{ null }}).Concat({referenceObject})");

                                    referenceObject = parameter.ParameterType.IsArray
                                        ? referenceObject + ".ToArray()"
                                        : referenceObject + ".ToList()";

                                    if (parameter.ParameterType.IsGenericType && ((parameter.ParameterType.GetGenericTypeDefinition() == typeof(Collection<>)) || (parameter.ParameterType.GetGenericTypeDefinition() == typeof(ReadOnlyCollection<>))))
                                    {
                                        referenceObject = parameter.ParameterType.GenerateSystemTypeInstantiationCode(referenceObject);
                                    }
                                }

                                return new MemberCode(_.Name, referenceObject);
                            }).ToList();

                            objectInstantiationCode = modelType.GenerateModelInstantiation(collectionParameterCode, parameterPaddingLength: 34);

                            collectionTestMethod = ConstructorTestMethodForCollectionArgumentThatContainsNullElementCodeTemplate
                                .Replace(TypeNameToken, modelType.TypeCompilableString)
                                .Replace(ConstructorParameterToken, parameter.Name)
                                .Replace(NewObjectTestToken, objectInstantiationCode);

                            testMethods.Add(collectionTestMethod);
                        }
                    }

                    if (parameter.ParameterType.IsClosedSystemDictionaryType())
                    {
                        // add test for empty dictionary
                        var dictionaryParameterCode = parameters.Select(_ =>
                        {
                            var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                            return new MemberCode(_.Name, _.Name == parameter.Name ? parameter.ParameterType.GenerateSystemTypeInstantiationCode() : referenceObject);
                        }).ToList();

                        objectInstantiationCode = modelType.GenerateModelInstantiation(dictionaryParameterCode, parameterPaddingLength: 34);

                        var dictionaryTestMethod = ConstructorTestMethodForDictionaryArgumentThatIsEmptyCodeTemplate
                            .Replace(TypeNameToken, modelType.TypeCompilableString)
                            .Replace(ConstructorParameterToken, parameter.Name)
                            .Replace(NewObjectTestToken, objectInstantiationCode);

                        testMethods.Add(dictionaryTestMethod);

                        // add test for dictionary containing null value
                        // we are specifically EXCLUDING nullable types here
                        var valueType = parameter.ParameterType.GetClosedSystemDictionaryValueType();

                        if (!valueType.IsValueType)
                        {
                            dictionaryParameterCode = parameters.Select(_ =>
                            {
                                var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                                if (_.Name == parameter.Name)
                                {
                                    referenceObject = "dictionaryWithNullValue";

                                    if (parameter.ParameterType.IsGenericType && ((parameter.ParameterType.GetGenericTypeDefinition() == typeof(ReadOnlyDictionary<,>)) || (parameter.ParameterType.GetGenericTypeDefinition() == typeof(ConcurrentDictionary<,>))))
                                    {
                                        referenceObject = parameter.ParameterType.GenerateSystemTypeInstantiationCode(referenceObject);
                                    }
                                }

                                return new MemberCode(_.Name, referenceObject);
                            }).ToList();

                            var setDictionaryValueToNullCode = Invariant($"var dictionaryWithNullValue = referenceObject.{parameter.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture)}.ToDictionary(_ => _.Key, _ => _.Value);");

                            objectInstantiationCode = modelType.GenerateModelInstantiation(dictionaryParameterCode, parameterPaddingLength: 34);

                            dictionaryTestMethod = ConstructorTestMethodForDictionaryArgumentThatContainsNullValueCodeTemplate
                                .Replace(SetDictionaryValueToNullToken, setDictionaryValueToNullCode)
                                .Replace(TypeNameToken, modelType.TypeCompilableString)
                                .Replace(ConstructorParameterToken, parameter.Name)
                                .Replace(NewObjectTestToken, objectInstantiationCode);

                            testMethods.Add(dictionaryTestMethod);
                        }
                    }
                }

                foreach (var parameter in parameters)
                {
                    var parameterCode = parameters.Select(_ => new MemberCode(_.Name, "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture))).ToList();

                    var newObjectCode = modelType.GenerateModelInstantiation(parameterCode, parameterPaddingLength: 46);

                    var assertPropertyGetterToken = parameter.ParameterType.GenerateObcAssertionsEqualityStatement(
                        "actual",
                        "expected",
                        sameReferenceExpected: true);

                    var testMethod = PropertyGetterTestMethodTemplate
                                    .Replace(TypeNameToken,              modelType.TypeCompilableString)
                                    .Replace(PropertyNameToken,          parameter.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture))
                                    .Replace(ConstructorParameterToken,  parameter.Name)
                                    .Replace(AssertPropertyGetterToken,  assertPropertyGetterToken)
                                    .Replace(NewObjectForGetterTestToken, newObjectCode);

                    testMethods.Add(testMethod);
                }

                var constructorTestInflationToken = string.Join(Environment.NewLine, testMethods);

                result = ConstructingTestMethodsCodeTemplate
                    .Replace(TypeNameToken, modelType.TypeCompilableString)
                    .Replace(ConstructorTestInflationToken, constructorTestInflationToken);
            }

            return result;
        }

        /// <summary>
        /// Generates the code to instantiate a System type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="constructorParameterCode">The code to inject into the constructor.</param>
        /// <returns>
        /// The code to instantiate a System type.
        /// </returns>
        public static string GenerateSystemTypeInstantiationCode(
            this Type type,
            string constructorParameterCode = null)
        {
            string result;

            if (type.IsArray)
            {
                var elementType = type.GetElementType();

                result = Invariant($"new {elementType.ToStringCompilable()}[0]");
            }
            else if (type.IsClosedSystemCollectionType())
            {
                var elementType = type.GetClosedSystemCollectionElementType();

                if (type.IsInterface || (type.GetGenericTypeDefinition() == typeof(List<>)))
                {
                    result = Invariant($"new List<{elementType.ToStringCompilable()}>({constructorParameterCode})");
                }
                else if (type.GetGenericTypeDefinition() == typeof(Collection<>))
                {
                    result = Invariant($"new Collection<{elementType.ToStringCompilable()}>({constructorParameterCode})");
                }
                else if (type.GetGenericTypeDefinition() == typeof(ReadOnlyCollection<>))
                {
                    constructorParameterCode = constructorParameterCode ?? Invariant($"new List<{elementType.ToStringCompilable()}>()");

                    result = Invariant($"new ReadOnlyCollection<{elementType.ToStringCompilable()}>({constructorParameterCode})");
                }
                else
                {
                    throw new NotSupportedException("This System Collection type is not supported: " + type);
                }
            }
            else if (type.IsClosedSystemDictionaryType())
            {
                var keyType = type.GetClosedSystemDictionaryKeyType();

                var valueType = type.GetClosedSystemDictionaryValueType();

                result = Invariant($"new Dictionary<{keyType.ToStringCompilable()}, {valueType.ToStringCompilable()}>({constructorParameterCode})");

                if (type.GetGenericTypeDefinition() == typeof(ReadOnlyDictionary<,>))
                {
                    constructorParameterCode = constructorParameterCode ?? result;

                    result = Invariant($"new ReadOnlyDictionary<{keyType.ToStringCompilable()}, {valueType.ToStringCompilable()}>({constructorParameterCode})");
                }
                else if (type.GetGenericTypeDefinition() == typeof(ConcurrentDictionary<,>))
                {
                    constructorParameterCode = constructorParameterCode ?? result;

                    result = Invariant($"new ConcurrentDictionary<{keyType.ToStringCompilable()}, {valueType.ToStringCompilable()}>({constructorParameterCode})");
                }
            }
            else
            {
                throw new NotSupportedException("This System type is not supported: " + type);
            }

            return result;
        }
    }
}