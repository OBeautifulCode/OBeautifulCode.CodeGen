// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CloningGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using OBeautifulCode.Reflection.Recipes;
    using OBeautifulCode.Representation.System.Recipes;
    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Validation.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to cloning.
    /// </summary>
    internal static class CloningGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";
        private const string DeepCloneToken = "<<<DeepCloneLogicHere>>>";
        private const string DeepCloneWithInflationToken = "<<<DeepCloneInflationHere>>>";
        private const string NewObjectForDeepCloneWithToken = "<<<DeepCloneWithNewObjectHere>>>";
        private const string DeepCloneWithAssertLogicToken = "<<<DeepCloneWithTestAssertionsHere>>>";
        private const string AssertDeepCloneToken = "<<<AssertDeepCloneHere>>>";
        private const string DeepCloneWithTestInflationToken = "<<<DeepCloneTestInflationHere>>>";
        private const string PropertyNameToken = "<<<PropertyNameHere>>>";
        private const string ParameterNameToken = "<<<ParameterNameHere>>>";
        private const string ParameterTypeNameToken = "<<<ParameterTypeNameHere>>>";

        private const string CloningMethodsCodeTemplate = @"
        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public " + TypeNameToken + @" DeepClone()
        {
            var result = " + DeepCloneToken + @";

            return result;
        }" + DeepCloneWithInflationToken;

        private const string DeepCloneWithMethodCodeTemplate = @"
        /// <summary>
        /// Deep clones this object with a new <see cref=""" + PropertyNameToken + @""" />.
        /// </summary>
        /// <param name=""" + ParameterNameToken + @""">The new <see cref=""" + PropertyNameToken + @""" />.</param>
        /// <returns>New <see cref=""" + TypeNameToken + @""" /> using the specified <paramref name=""" + ParameterNameToken + @""" /> for <see cref=""" + PropertyNameToken + @""" /> and a deep clone of every other property.</returns>
        public " + TypeNameToken + @" DeepCloneWith" + PropertyNameToken + @"(" + ParameterTypeNameToken + @" " + ParameterNameToken + @")
        {
            var result = " + NewObjectForDeepCloneWithToken + @";
            return result;
        }";

        private const string CloningTestMethodsCodeTemplate = @"
        [SuppressMessage(""Microsoft.Design"", ""CA1034:NestedTypesShouldNotBeVisible"", Justification = ""Grouping construct for unit test runner."")]
        public static class Cloning
        {
            [Fact]
            public static void DeepClone___Should_deep_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<" + TypeNameToken + @">();

                // Act
                var actual = systemUnderTest.DeepClone();

                // Assert
               actual.Should().Be(systemUnderTest);
               actual.Should().NotBeSameAs(systemUnderTest);" + AssertDeepCloneToken + @"
            }" + DeepCloneWithTestInflationToken + @"
        }";

        private const string DeepCloneWithTestMethodCodeTemplate = @"
            [Fact]
            public static void DeepCloneWith" + PropertyNameToken + @"___Should_deep_clone_object_and_replace_" + PropertyNameToken + @"_with_the_provided_" + ParameterNameToken + @"___When_called()
            {
                // Arrange,
                var systemUnderTest = A.Dummy<" + TypeNameToken + @">();
                var referenceObject = A.Dummy<" + TypeNameToken + @">().ThatIsNot(systemUnderTest);
                
                // Act
                var actual = systemUnderTest.DeepCloneWith" + PropertyNameToken + @"(referenceObject." + PropertyNameToken + @");

                // Assert
                " + DeepCloneWithAssertLogicToken + @"
            }";

        /// <summary>
        /// Generates cloning methods.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// Generated cloning methods.
        /// </returns>
        public static string GenerateCloningMethods(
            this Type type)
        {
            var properties = type.GetPropertiesOfConcernFromType();

            var propertyNameToCloneMethodMap = properties.ToDictionary(
                k => k.Name,
                v => v.PropertyType.GenerateCloningLogicCodeForType("this." + v.Name));

            var deepCloneToken = type.GenerateModelInstantiation(propertyNameToCloneMethodMap);

            var parameters = type.GetConstructors().SingleOrDefault(_ => _.GetParameters().Length > 1)?.GetParameters().ToList();
            var deepCloneWithMethods = new List<string>();
            if (parameters != null)
            {
                // since we have parameters we'll go ahead and pad down.
                deepCloneWithMethods.Add(string.Empty);

                foreach (var parameter in parameters)
                {
                    var propertyNameToSourceCodeMap = parameters.ToDictionary(
                        k => k.Name,
                        v =>
                        {
                            var referenceObject = "this." + v.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture);
                            var referenceItemCloned = v.ParameterType.GenerateCloningLogicCodeForType(referenceObject);
                            return v.Name == parameter.Name ? parameter.Name : referenceItemCloned;
                        });

                    var newObjectCode = type.GenerateModelInstantiation(propertyNameToSourceCodeMap);

                    var testMethod = DeepCloneWithMethodCodeTemplate
                                    .Replace(TypeNameToken,                  type.ToStringCompilable())
                                    .Replace(PropertyNameToken,                  parameter.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture))
                                    .Replace(ParameterNameToken,                  parameter.Name)
                                    .Replace(NewObjectForDeepCloneWithToken, newObjectCode)
                                    .Replace(ParameterTypeNameToken, parameter.ParameterType.ToStringCompilable());
                    deepCloneWithMethods.Add(testMethod);
                }
            }

            var deepCloneWithInflationToken = string.Join(Environment.NewLine, deepCloneWithMethods);

            var result = CloningMethodsCodeTemplate.Replace(TypeNameToken, type.ToStringCompilable())
                                                   .Replace(DeepCloneToken, deepCloneToken)
                                                   .Replace(DeepCloneWithInflationToken, deepCloneWithInflationToken);

            return result;
        }

        /// <summary>
        /// Generates test methods that test cloning.
        /// </summary>
        /// <param name="type">The model type.</param>
        /// <returns>
        /// Generated test methods that test cloning.
        /// </returns>
        public static string GenerateCloningTestMethods(
            this Type type)
        {
            var properties = type.GetPropertiesOfConcernFromType();
            var assertDeepCloneSet = properties.Where(_ => !_.PropertyType.IsValueType && _.PropertyType != typeof(string)).Select(_ => Invariant($"actual.{_.Name}.Should().NotBeSameAs(systemUnderTest.{_.Name});")).ToList();
            var assertDeepCloneToken = assertDeepCloneSet.Any() ? Environment.NewLine + "               " + string.Join(Environment.NewLine + "               ", assertDeepCloneSet) : string.Empty;

            var parameters = type.GetConstructors().SingleOrDefault(_ => _.GetParameters().Length > 1)?.GetParameters().ToList();
            var deepCloneWithTestMethods = new List<string>();
            if (parameters != null)
            {
                // since we have parameters we'll go ahead and pad down.
                deepCloneWithTestMethods.Add(string.Empty);

                foreach (var parameter in parameters)
                {
                    var assertDeepCloneWithSet = parameters.Select(
                                                                _ =>
                                                                {
                                                                    var sourceName = _.Name == parameter.Name ? "referenceObject" : "systemUnderTest";
                                                                    var resultAssert = _.ParameterType.GenerateFluentAssertionsEqualityStatement(
                                                                        Invariant($"actual.{_.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture)}"),
                                                                        Invariant($"{sourceName}.{_.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture)}"));
                                                                    if (_.Name != parameter.Name && !_.ParameterType.IsValueType && _.ParameterType != typeof(string))
                                                                    {
                                                                        resultAssert +=
                                                                            Environment.NewLine
                                                                          + Invariant(
                                                                                $"               actual.{_.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture)}.Should().NotBeSameAs({sourceName}.{_.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture)});");
                                                                    }

                                                                    return resultAssert;
                                                                })
                                                           .ToList();
                    var assertDeepCloneWithToken = string.Join(Environment.NewLine + "               ", assertDeepCloneWithSet);

                    var testMethod = DeepCloneWithTestMethodCodeTemplate
                                    .Replace(TypeNameToken,                  type.ToStringCompilable())
                                    .Replace(PropertyNameToken,              parameter.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture))
                                    .Replace(ParameterNameToken,             parameter.Name)
                                    .Replace(DeepCloneWithAssertLogicToken, assertDeepCloneWithToken);
                    deepCloneWithTestMethods.Add(testMethod);
                }
            }

            var deepCloneWithTestInflationToken = string.Join(Environment.NewLine, deepCloneWithTestMethods);

            var result = CloningTestMethodsCodeTemplate.Replace(TypeNameToken, type.ToStringCompilable())
                                                       .Replace(AssertDeepCloneToken, assertDeepCloneToken)
                                                       .Replace(DeepCloneWithTestInflationToken, deepCloneWithTestInflationToken);

            return result;
        }

        private static string GenerateCloningLogicCodeForType(
            this Type type,
            string cloneSourceCode)
        {
            type.Named(nameof(type)).Must().NotBeNull();

            string result;
            if (type.IsSystemDictionaryType())
            {
                var genericArguments = type.GetGenericArguments();
                genericArguments.Length.Named(Invariant($"Number{nameof(genericArguments)}Of{nameof(type)}.{nameof(type)}For{type.Name}"))
                                .Must()
                                .BeEqualTo(2);

                var keyType = genericArguments.First();
                var valueType = genericArguments.Last();
                var keyClone = keyType.GenerateCloningLogicCodeForType("k.Key");
                var valueClone = valueType.GenerateCloningLogicCodeForType("v.Value");
                result = Invariant($"{cloneSourceCode}?.ToDictionary(k => {keyClone}, v => {valueClone})");
            }
            else if (type.IsSystemCollectionType())
            {
                var genericArguments = type.GetGenericArguments();
                var valueType = genericArguments.Single();
                var valueClone = valueType.GenerateCloningLogicCodeForType("_");
                result = Invariant($"{cloneSourceCode}?.Select(_ => {valueClone}).ToList()");
            }
            else if (type == typeof(string))
            {
                // string should be cloned using it's existing interface.
                result = Invariant($"{cloneSourceCode}?.Clone().ToString()");
            }
            else if (!type.IsValueType)
            {
                // assume that we are driving the DeepClone convention and it exists.
                result = Invariant($"{cloneSourceCode}?.DeepClone()");
            }
            else
            {
                // this is just a copy of the item anyway (like bool, int, Enumerations, structs like DateTime, etc.).
                result = cloneSourceCode;
            }

            return result;
        }
    }
}