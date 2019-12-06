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
    using System.Globalization;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
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

        private const string ConstructingTestMethodsCodeTemplate = @"
        public static class Constructing
        {
            [Fact]
            public static void " + TypeNameToken + @"___Should_implement_IModel___When_reflecting()
            {
                // Arrange
                var type = typeof(" + TypeNameToken + @");
                var expectedModelMethods = typeof(IModel<" + TypeNameToken + @">)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();
                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IModel<" + TypeNameToken + @">));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
            }" + ConstructorTestInflationToken + @"
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
                .Type
                .GetConstructors()
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

                var parameterCode = constructorInfo.GetParameters()
                    .Select(_ => propertyNameToCodeMap[_.Name])
                    .ToDelimitedString("," + Environment.NewLine + parameterPadding);

                result = "new " + modelType.Type.ToStringCompilable() + "(" + Environment.NewLine + parameterPadding + parameterCode + ")";
            }
            else if (modelType.PropertiesOfConcern.All(_ => _.CanWrite))
            {
                var curlyBracketPadding = new string(' ', parameterPaddingLength - 4);

                var maxCharsInAnyPropertyName = memberNames.Select(_ => _.Length).Max();

                var propertyInitializerCode = memberCode.Select(_ => Invariant($"{_.Name.PadRight(maxCharsInAnyPropertyName, ' ')} = {_.Code}")).ToDelimitedString("," + Environment.NewLine + parameterPadding);

                result = "new " + modelType.Type.ToStringCompilable() + Environment.NewLine + curlyBracketPadding + "{" + Environment.NewLine + parameterPadding + propertyInitializerCode + Environment.NewLine + curlyBracketPadding + "}";
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
        public static string GenerateConstructorTestMethods(
            this ModelType modelType)
        {
            new { modelType }.AsArg().Must().NotBeNull();

            var constructorWithParameters = modelType.Type.GetConstructors().SingleOrDefault(_ => _.GetParameters().Length > 0);

            var testMethods = new List<string>();

            if (constructorWithParameters != null)
            {
                // since we have parameters we'll go ahead and pad down.
                testMethods.Add(string.Empty);

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
                                    .Replace(TypeNameToken,             modelType.Type.ToStringCompilable())
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
                                              .Replace(TypeNameToken,             modelType.Type.ToStringCompilable())
                                              .Replace(ConstructorParameterToken, parameter.Name)
                                              .Replace(NewObjectTestToken,        objectInstantiationCode);

                        testMethods.Add(stringTestMethod);
                    }

                    if (parameter.ParameterType.IsSystemCollectionType() || parameter.ParameterType.IsArray)
                    {
                        // add test for empty collection or array
                        var collectionParameterCode = parameters.Select(_ =>
                        {
                            var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                            return new MemberCode(_.Name, _.Name == parameter.Name ? parameter.ParameterType.GenerateSystemTypeInstantiationCode() : referenceObject);
                        }).ToList();

                        objectInstantiationCode = modelType.GenerateModelInstantiation(collectionParameterCode, parameterPaddingLength: 34);

                        var collectionTestMethod = ConstructorTestMethodForCollectionArgumentThatIsEmptyCodeTemplate
                            .Replace(TypeNameToken, modelType.Type.ToStringCompilable())
                            .Replace(ConstructorParameterToken, parameter.Name)
                            .Replace(NewObjectTestToken, objectInstantiationCode);

                        testMethods.Add(collectionTestMethod);

                        // add test for collection or array containing null element
                        // we are specifically EXCLUDING nullable types here
                        var elementType = parameter.ParameterType.IsArray
                            ? parameter.ParameterType.GetElementType()
                            : parameter.ParameterType.GenericTypeArguments[0];

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
                                .Replace(TypeNameToken, modelType.Type.ToStringCompilable())
                                .Replace(ConstructorParameterToken, parameter.Name)
                                .Replace(NewObjectTestToken, objectInstantiationCode);

                            testMethods.Add(collectionTestMethod);
                        }
                    }

                    if (parameter.ParameterType.IsSystemDictionaryType())
                    {
                        // add test for empty dictionary
                        var dictionaryParameterCode = parameters.Select(_ =>
                        {
                            var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                            return new MemberCode(_.Name, _.Name == parameter.Name ? parameter.ParameterType.GenerateSystemTypeInstantiationCode() : referenceObject);
                        }).ToList();

                        objectInstantiationCode = modelType.GenerateModelInstantiation(dictionaryParameterCode, parameterPaddingLength: 34);

                        var dictionaryTestMethod = ConstructorTestMethodForDictionaryArgumentThatIsEmptyCodeTemplate
                            .Replace(TypeNameToken, modelType.Type.ToStringCompilable())
                            .Replace(ConstructorParameterToken, parameter.Name)
                            .Replace(NewObjectTestToken, objectInstantiationCode);

                        testMethods.Add(dictionaryTestMethod);

                        // add test for dictionary containing null value
                        // we are specifically EXCLUDING nullable types here
                        var valueType = parameter.ParameterType.GenericTypeArguments[1];

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
                                .Replace(TypeNameToken, modelType.Type.ToStringCompilable())
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
                                    .Replace(TypeNameToken,              modelType.Type.ToStringCompilable())
                                    .Replace(PropertyNameToken,          parameter.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture))
                                    .Replace(ConstructorParameterToken,  parameter.Name)
                                    .Replace(AssertPropertyGetterToken,  assertPropertyGetterToken)
                                    .Replace(NewObjectForGetterTestToken, newObjectCode);

                    testMethods.Add(testMethod);
                }
            }

            var constructorTestInflationToken = string.Join(Environment.NewLine, testMethods);

            var result = ConstructingTestMethodsCodeTemplate
                        .Replace(TypeNameToken,                 modelType.Type.ToStringCompilable())
                        .Replace(ConstructorTestInflationToken, constructorTestInflationToken);

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
            else if (type.IsSystemCollectionType())
            {
                var elementType = type.GenericTypeArguments[0];

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
            else if (type.IsSystemDictionaryType())
            {
                var keyType = type.GenericTypeArguments[0];

                var valueType = type.GenericTypeArguments[1];

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