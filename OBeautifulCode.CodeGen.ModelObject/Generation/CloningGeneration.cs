// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CloningGeneration.cs" company="OBeautifulCode">
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
    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

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

        private const string CloningMethodsForAbstractTypeCodeTemplate = @"
        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public abstract " + TypeNameToken + " DeepClone();";

        private const string CloningMethodsForConcreteTypeCodeTemplate = @"
        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public " + TypeNameToken + @" DeepClone()
        {
            var result = " + DeepCloneToken + @";

            return result;
        }" + DeepCloneWithInflationToken;

        private const string DeepCloneWithMethodForAbstractTypeCodeTemplate = @"
        /// <summary>
        /// Deep clones this object with a new <see cref=""" + PropertyNameToken + @""" />.
        /// </summary>
        /// <param name=""" + ParameterNameToken + @""">The new <see cref=""" + PropertyNameToken + @""" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref=""" + TypeNameToken + @""" /> using the specified <paramref name=""" + ParameterNameToken + @""" /> for <see cref=""" + PropertyNameToken + @""" /> and a deep clone of every other property.</returns>
        public abstract " + TypeNameToken + @" DeepCloneWith" + PropertyNameToken + @"(" + ParameterTypeNameToken + @" " + ParameterNameToken + @");";

        private const string DeepCloneWithMethodForConcreteTypeCodeTemplate = @"
        /// <summary>
        /// Deep clones this object with a new <see cref=""" + PropertyNameToken + @""" />.
        /// </summary>
        /// <param name=""" + ParameterNameToken + @""">The new <see cref=""" + PropertyNameToken + @""" />.  This object will NOT be deep cloned; it is used as-is.</param>
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
            var result = type.IsAbstract
                ? type.GenerateCloningMethodsForAbstractType()
                : type.GenerateCloningMethodsForConcreteType();

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

        private static string GenerateCloningMethodsForAbstractType(
            this Type type)
        {
            var result = CloningMethodsForAbstractTypeCodeTemplate
                .Replace(TypeNameToken, type.ToStringCompilable());

            return result;
        }

        private static string GenerateCloningMethodsForConcreteType(
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

                    var testMethod = DeepCloneWithMethodForConcreteTypeCodeTemplate
                                    .Replace(TypeNameToken, type.ToStringCompilable())
                                    .Replace(PropertyNameToken, parameter.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture))
                                    .Replace(ParameterNameToken, parameter.Name)
                                    .Replace(NewObjectForDeepCloneWithToken, newObjectCode)
                                    .Replace(ParameterTypeNameToken, parameter.ParameterType.ToStringCompilable());
                    deepCloneWithMethods.Add(testMethod);
                }
            }

            var deepCloneWithInflationToken = string.Join(Environment.NewLine, deepCloneWithMethods);

            var result = CloningMethodsForConcreteTypeCodeTemplate
                .Replace(TypeNameToken, type.ToStringCompilable())
                .Replace(DeepCloneToken, deepCloneToken)
                .Replace(DeepCloneWithInflationToken, deepCloneWithInflationToken);

            return result;
        }

        private static string GenerateCloningLogicCodeForType(
            this Type type,
            string cloneSourceCode,
            int recursionDepth = 0)
        {
            type.AsArg(nameof(type)).Must().NotBeNull();
            recursionDepth++;

            var deepCloneableType = typeof(IDeepCloneable<>).MakeGenericType(type);

            string result;
            if (type.IsAssignableTo(deepCloneableType))
            {
                if (type.IsValueType)
                {
                    result = Invariant($"{cloneSourceCode}.DeepClone()");
                }
                else
                {
                    result = Invariant($"{cloneSourceCode}?.DeepClone()");
                }
            }
            else if (type.IsSystemDictionaryType())
            {
                var genericArguments = type.GetGenericArguments();
                genericArguments.Length.AsOp(Invariant($"Number{nameof(genericArguments)}Of{nameof(type)}.{nameof(type)}For{type.Name}")).Must().BeEqualTo(2);

                var keyType = genericArguments.First();
                var valueType = genericArguments.Last();

                var keyExpressionParameter = "k".ToExpressionParameter(recursionDepth);
                var valueExpressionParameter = "v".ToExpressionParameter(recursionDepth);

                var keyClone = keyType.GenerateCloningLogicCodeForType(Invariant($"{keyExpressionParameter}.Key"), recursionDepth);
                var valueClone = valueType.GenerateCloningLogicCodeForType(Invariant($"{valueExpressionParameter}.Value"), recursionDepth);

                string cast = null;
                if (recursionDepth > 1)
                {
                    cast = "(" + type.ToStringReadable() + ")";
                }

                result = Invariant($"{cast}{cloneSourceCode}?.ToDictionary({keyExpressionParameter} => {keyClone}, {valueExpressionParameter} => {valueClone})");
            }
            else if (type.IsSystemCollectionType())
            {
                var genericArguments = type.GetGenericArguments();

                var valueType = genericArguments.Single();

                var expressionParameter = "i".ToExpressionParameter(recursionDepth);

                var valueClone = valueType.GenerateCloningLogicCodeForType(expressionParameter, recursionDepth);

                string cast = null;
                if (recursionDepth > 1)
                {
                    cast = "(" + type.ToStringReadable() + ")";
                }

                // note: List<T> is assignable to all System collection types except Collection<T> and ReadOnlyCollection<T>.
                // In general no properties of a model should use those types.  If we do want to support this in the future,
                // we need to wrap the List<T>:
                // - cloneSourceCode == null ? null : new Collection<T>(cloneSourceCode.Select(...).ToList())
                // - cloneSourceCode == null ? null : new ReadOnlyCollection<T>(cloneSourceCode.Select(...).ToList())
                result = Invariant($"{cast}{cloneSourceCode}?.Select({expressionParameter} => {valueClone}).ToList()");
            }
            else if (type.IsArray)
            {
                var valueType = type.GetElementType();

                var expressionParameter = "i".ToExpressionParameter(recursionDepth);

                var valueClone = valueType.GenerateCloningLogicCodeForType(expressionParameter, recursionDepth);

                result = Invariant($"{cloneSourceCode}?.Select({expressionParameter} => {valueClone}).ToArray()");
            }
            else if (type == typeof(string))
            {
                // string should be cloned using it's existing interface.
                result = Invariant($"{cloneSourceCode}?.Clone().ToString()");
            }
            else
            {
                if (type.IsNullableType())
                {
                    var underlyingType = Nullable.GetUnderlyingType(type);

                    var deepCloneableUnderlyingType = typeof(IDeepCloneable<>).MakeGenericType(underlyingType);

                    if (underlyingType.IsAssignableTo(deepCloneableUnderlyingType))
                    {
                        result = Invariant($"{cloneSourceCode}?.DeepClone()");
                    }
                    else
                    {
                        result = cloneSourceCode;
                    }
                }
                else if (type.IsValueType)
                {
                    // this is just a copy of the item anyway (like bool, int, Enumerations, structs like DateTime, etc.).
                    result = cloneSourceCode;
                }
                else
                {
                    // assume that we are driving the DeepClone convention and it exists.
                    result = Invariant($"{cloneSourceCode}?.DeepClone()");
                }
            }

            return result;
        }

        private static string ToExpressionParameter(
            this string expressionParameter,
            int recursionDepth)
        {
            string result;
            if (recursionDepth == 1)
            {
                result = expressionParameter;
            }
            else
            {
                result = expressionParameter + recursionDepth;
            }

            return result;
        }
    }
}