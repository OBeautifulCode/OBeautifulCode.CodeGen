// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstructingGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;
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
        private const string NewObjectForArgumentNullTestToken = "<<<NewObjectWithOneArgumentNullHere>>>";
        private const string NewObjectForArgumentWhiteSpaceTestToken = "<<<NewObjectWithOneArgumentWhiteSpaceHere>>>";
        private const string PropertyNameToken = "<<<PropertyNameHere>>>";
        private const string AssertPropertyGetterToken = "<<<AssertPropertyGetterHere>>>";
        private const string NewObjectForGetterTestToken = "<<<NewObjectWithOneArgumentFromOtherHere>>>";

        private const string ConstructingTestMethodsCodeTemplate = @"
        [SuppressMessage(""Microsoft.Design"", ""CA1034:NestedTypesShouldNotBeVisible"", Justification = ""Grouping construct for unit test runner."")]
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
                // Arrange,
                var referenceObject = A.Dummy<" + TypeNameToken + @">();

                // Act
                var actual = Record.Exception(
                    () => " + NewObjectForArgumentNullTestToken + @");

                // Assert
                actual.AsTest().Must().BeOfType<ArgumentNullException>();
                actual.Message.AsTest().Must().ContainString(""" + ConstructorParameterToken + @""");
            }";

        private const string ConstructorTestMethodForStringArgumentCodeTemplate = @"
            [Fact]
            public static void Constructor___Should_throw_ArgumentException___When_parameter_" + ConstructorParameterToken + @"_is_white_space()
            {
                // Arrange,
                var referenceObject = A.Dummy<" + TypeNameToken + @">();

                // Act
                var actual = Record.Exception(
                    () => " + NewObjectForArgumentWhiteSpaceTestToken + @");

                // Assert
                actual.AsTest().Must().BeOfType<ArgumentException>();
                actual.Message.AsTest().Must().ContainString(""" + ConstructorParameterToken + @""");
                actual.Message.AsTest().Must().ContainString(""white space"");
            }";

        private const string PropertyGetterTestMethodTemplate = @"
            [Fact]
            public static void " + PropertyNameToken + @"___Should_return_same_" + ConstructorParameterToken + @"_parameter_passed_to_constructor___When_getting()
            {
                // Arrange,
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
        /// <param name="type">The model type.</param>
        /// <param name="memberCode">The code for the members.</param>
        /// <param name="parameterPaddingLength">The length of the padding to use for constructor or object initializer parameters.</param>
        /// <returns>
        /// Generated code that instantiates a model object.
        /// </returns>
        public static string GenerateModelInstantiation(
            this Type type,
            IReadOnlyList<MemberCode> memberCode,
            int parameterPaddingLength)
        {
            type.AsArg(nameof(type)).Must().NotBeNull();
            memberCode.AsArg(nameof(memberCode)).Must().NotBeNull().And().NotContainAnyNullElements();

            string result;

            var memberNames = memberCode.Select(_ => _.Name).ToList();

            var parameterPadding = new string(' ', parameterPaddingLength);

            var constructorInfo = type
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

                result = "new " + type.ToStringCompilable() + "(" + Environment.NewLine + parameterPadding + parameterCode + ")";
            }
            else if (type.GetPropertiesOfConcernFromType().All(_ => _.CanWrite))
            {
                var curlyBracketPadding = new string(' ', parameterPaddingLength - 4);

                var maxCharsInAnyPropertyName = memberNames.Select(_ => _.Length).Max();

                var propertyInitializerCode = memberCode.Select(_ => Invariant($"{_.Name.PadRight(maxCharsInAnyPropertyName, ' ')} = {_.Code}")).ToDelimitedString("," + Environment.NewLine + parameterPadding);

                result = "new " + type.ToStringCompilable() + Environment.NewLine + curlyBracketPadding + "{" + Environment.NewLine + parameterPadding + propertyInitializerCode + Environment.NewLine + curlyBracketPadding + "}";
            }
            else
            {
                var propertiesAddIn = string.Join(",", type.GetPropertiesOfConcernFromType().Select(_ => _.Name));

                throw new NotSupportedException("Could not find a constructor to take properties of concern and they are not all settable: " + propertiesAddIn);
            }

            return result;
        }

        /// <summary>
        /// Generates test methods that test a model's constructor.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// Generated test methods that test a model's constructor.
        /// </returns>
        public static string GenerateConstructorTestMethods(
            this Type type)
        {
            type.AsArg(nameof(type)).Must().NotBeNull();

            var constructorWithParameters = type.GetConstructors().SingleOrDefault(_ => _.GetParameters().Length > 0);

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

                    var objectInstantiationCode = type.GenerateModelInstantiation(parametersCode, parameterPaddingLength: 34);

                    var testMethod = ConstructorTestMethodForArgumentCodeTemplate
                                    .Replace(TypeNameToken,                     type.ToStringCompilable())
                                    .Replace(ConstructorParameterToken,         parameter.Name)
                                    .Replace(NewObjectForArgumentNullTestToken, objectInstantiationCode);

                    testMethods.Add(testMethod);

                    if (parameter.ParameterType == typeof(string))
                    {
                        var stringParameterCode = parameters.Select(_ =>
                        {
                            var referenceObject = "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);

                            return new MemberCode(_.Name, _.Name == parameter.Name ? "Invariant($\"  {Environment.NewLine}  \")" : referenceObject);
                        }).ToList();

                        objectInstantiationCode = type.GenerateModelInstantiation(stringParameterCode, parameterPaddingLength: 34);

                        var stringTestMethod = ConstructorTestMethodForStringArgumentCodeTemplate
                                              .Replace(TypeNameToken,                           type.ToStringCompilable())
                                              .Replace(ConstructorParameterToken,               parameter.Name)
                                              .Replace(NewObjectForArgumentWhiteSpaceTestToken, objectInstantiationCode);

                        testMethods.Add(stringTestMethod);
                    }
                }

                foreach (var parameter in parameters)
                {
                    var parameterCode = parameters.Select(_ => new MemberCode(_.Name, "referenceObject." + _.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture))).ToList();

                    var newObjectCode = type.GenerateModelInstantiation(parameterCode, parameterPaddingLength: 46);

                    var assertPropertyGetterToken = parameter.ParameterType.GenerateObcAssertionsEqualityStatement(
                        "actual",
                        "expected",
                        sameReferenceExpected: true);

                    var testMethod = PropertyGetterTestMethodTemplate
                                    .Replace(TypeNameToken,              type.ToStringCompilable())
                                    .Replace(PropertyNameToken,          parameter.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture))
                                    .Replace(ConstructorParameterToken,  parameter.Name)
                                    .Replace(AssertPropertyGetterToken,  assertPropertyGetterToken)
                                    .Replace(NewObjectForGetterTestToken, newObjectCode);

                    testMethods.Add(testMethod);
                }
            }

            var constructorTestInflationToken = string.Join(Environment.NewLine, testMethods);

            var result = ConstructingTestMethodsCodeTemplate
                        .Replace(TypeNameToken,                 type.ToStringCompilable())
                        .Replace(ConstructorTestInflationToken, constructorTestInflationToken);

            return result;
        }
    }
}