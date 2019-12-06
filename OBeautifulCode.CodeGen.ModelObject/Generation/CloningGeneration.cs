// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CloningGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
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
        private const string BaseTypeNameToken = "<<<BaseTypeNameToken>>>";

        private const string DeepCloneToken = "<<<DeepCloneHere>>>";
        private const string DeepCloneWithInflationToken = "<<<DeepCloneWithInflationHere>>>";
        private const string DeepCloneWithModelInstantiationToken = "<<<DeepCloneWithModelInstantiationHere>>>";

        private const string PropertyNameToken = "<<<PropertyNameHere>>>";
        private const string ParameterNameToken = "<<<ParameterNameHere>>>";
        private const string ParameterTypeNameToken = "<<<ParameterTypeNameHere>>>";

        private const string DeepCloneWithTestAssertLogicToken = "<<<DeepCloneWithTestAssertLogicHere>>>";
        private const string AssertDeepCloneToken = "<<<AssertDeepCloneHere>>>";
        private const string DeepCloneWithTestInflationToken = "<<<DeepCloneWithTestInflationHere>>>";

        private const string CloningMethodsForAbstractBaseTypeCodeTemplate = @"
        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public abstract " + TypeNameToken + " DeepClone();" + DeepCloneWithInflationToken;

        private const string CloningMethodsForConcreteInheritedTypeCodeTemplate = @"
        /// <inheritdoc />
        public new object Clone() => this.DeepClone();

        /// <inheritdoc />
        public override " + BaseTypeNameToken + @" DeepClone()
        {
            var result = ((IDeepCloneable<" + TypeNameToken + @">)this).DeepClone();

            return result;
        }

        /// <inheritdoc />
        " + TypeNameToken + @" IDeepCloneable<" + TypeNameToken + @">.DeepClone()
        {
            var result = " + DeepCloneToken + @";

            return result;
        }" + DeepCloneWithInflationToken;

        private const string CloningMethodsForNonHierarchicalTypeCodeTemplate = @"
        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public " + TypeNameToken + @" DeepClone()
        {
            var result = " + DeepCloneToken + @";

            return result;
        }" + DeepCloneWithInflationToken;

        private const string DeepCloneWithMethodForAbstractBaseTypeCodeTemplate = @"
        /// <summary>
        /// Deep clones this object with a new <see cref=""" + PropertyNameToken + @""" />.
        /// </summary>
        /// <param name=""" + ParameterNameToken + @""">The new <see cref=""" + PropertyNameToken + @""" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref=""" + TypeNameToken + @""" /> using the specified <paramref name=""" + ParameterNameToken + @""" /> for <see cref=""" + PropertyNameToken + @""" /> and a deep clone of every other property.</returns>
        public abstract " + TypeNameToken + @" DeepCloneWith" + PropertyNameToken + @"(" + ParameterTypeNameToken + @" " + ParameterNameToken + @");";

        private const string DeepCloneWithMethodForInheritedPropertyCodeTemplate = @"
        /// <inheritdoc />
        public override " + BaseTypeNameToken + @" DeepCloneWith" + PropertyNameToken + @"(" + ParameterTypeNameToken + @" " + ParameterNameToken + @")
        {
            var result = " + DeepCloneWithModelInstantiationToken + @";
            
            return result;
        }";

        private const string DeepCloneWithMethodForNonInheritedPropertyCodeTemplate = @"
        /// <summary>
        /// Deep clones this object with a new <see cref=""" + PropertyNameToken + @""" />.
        /// </summary>
        /// <param name=""" + ParameterNameToken + @""">The new <see cref=""" + PropertyNameToken + @""" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref=""" + TypeNameToken + @""" /> using the specified <paramref name=""" + ParameterNameToken + @""" /> for <see cref=""" + PropertyNameToken + @""" /> and a deep clone of every other property.</returns>
        public " + TypeNameToken + @" DeepCloneWith" + PropertyNameToken + @"(" + ParameterTypeNameToken + @" " + ParameterNameToken + @")
        {
            var result = " + DeepCloneWithModelInstantiationToken + @";
            
            return result;
        }";

        private const string CloningTestMethodsForNonInheritedTypeCodeTemplate = @"
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
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);" + AssertDeepCloneToken + @"
            }" + DeepCloneWithTestInflationToken + @"
        }";

        private const string CloningTestMethodsForConcreteInheritedTypeCodeTemplate = @"
        public static class Cloning
        {
            [Fact]
            public static void DeepClone_override___Should_deep_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<" + TypeNameToken + @">();

                // Act
                var actual = (" + TypeNameToken + @")systemUnderTest.DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);" + AssertDeepCloneToken + @"
            }

            [Fact]
            public static void DeepClone_explicit_interface___Should_deep_clone_object___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<" + TypeNameToken + @">();

                // Act
                var actual = ((IDeepCloneable<" + TypeNameToken + @">)systemUnderTest).DeepClone();

                // Assert
                actual.AsTest().Must().BeEqualTo(systemUnderTest);
                actual.AsTest().Must().NotBeSameReferenceAs(systemUnderTest);" + AssertDeepCloneToken + @"
            }" + DeepCloneWithTestInflationToken + @"
        }";

        private const string DeepCloneWithTestMethodForDeclaredPropertyCodeTemplate = @"
            [Fact]
            public static void DeepCloneWith" + PropertyNameToken + @"___Should_deep_clone_object_and_replace_" + PropertyNameToken + @"_with_the_provided_" + ParameterNameToken + @"___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<" + TypeNameToken + @">();

                var referenceObject = A.Dummy<" + TypeNameToken + @">().ThatIsNot(systemUnderTest);
                
                // Act
                var actual = systemUnderTest.DeepCloneWith" + PropertyNameToken + @"(referenceObject." + PropertyNameToken + @");

                // Assert
                " + DeepCloneWithTestAssertLogicToken + @"
            }";

        private const string DeepCloneWithTestMethodForNonDeclaredPropertyCodeTemplate = @"
            [Fact]
            public static void DeepCloneWith" + PropertyNameToken + @"___Should_deep_clone_object_and_replace_" + PropertyNameToken + @"_with_the_provided_" + ParameterNameToken + @"___When_called()
            {
                // Arrange
                var systemUnderTest = A.Dummy<" + TypeNameToken + @">();

                var referenceObject = A.Dummy<" + TypeNameToken + @">().ThatIsNot(systemUnderTest);
                
                // Act
                var actual = (" + TypeNameToken + @")systemUnderTest.DeepCloneWith" + PropertyNameToken + @"(referenceObject." + PropertyNameToken + @");

                // Assert
                " + DeepCloneWithTestAssertLogicToken + @"
            }";

        /// <summary>
        /// Generates cloning methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated cloning methods.
        /// </returns>
        public static string GenerateCloningMethods(
            this ModelType modelType)
        {
            string cloningMethodsTemplate;
            switch (modelType.HierarchyKind)
            {
                case HierarchyKind.None:
                    cloningMethodsTemplate = CloningMethodsForNonHierarchicalTypeCodeTemplate;
                    break;
                case HierarchyKind.AbstractBase:
                    cloningMethodsTemplate = CloningMethodsForAbstractBaseTypeCodeTemplate;
                    break;
                case HierarchyKind.ConcreteInherited:
                    cloningMethodsTemplate = CloningMethodsForConcreteInheritedTypeCodeTemplate;
                    break;
                default:
                    throw new NotSupportedException("This kind is not supported: " + modelType.HierarchyKind);
            }

            var result = cloningMethodsTemplate
                .Replace(TypeNameToken, modelType.Type.ToStringCompilable())
                .Replace(BaseTypeNameToken, modelType.Type.BaseType.ToStringCompilable());

            if (modelType.HierarchyKind != HierarchyKind.AbstractBase)
            {
                var deepCloneCodeForEachProperty = modelType
                    .PropertiesOfConcern
                    .Select(_ => new MemberCode(_.Name, _.PropertyType.GenerateCloningLogicCodeForType("this." + _.Name)))
                    .ToList();

                var deepCloneCode = modelType.GenerateModelInstantiation(deepCloneCodeForEachProperty, parameterPaddingLength: 33);

                result = result.Replace(DeepCloneToken, deepCloneCode);
            }

            var deepCloneWithMethods = new List<string>();
            if (modelType.PropertiesOfConcern.Any())
            {
                deepCloneWithMethods.Add(string.Empty);

                var declaredProperties = modelType.DeclaredOnlyPropertiesOfConcern;

                foreach (var property in modelType.PropertiesOfConcern)
                {
                    string deepCloneWithMethodTemplate;
                    if (modelType.HierarchyKind == HierarchyKind.AbstractBase)
                    {
                        deepCloneWithMethodTemplate = DeepCloneWithMethodForAbstractBaseTypeCodeTemplate;
                    }
                    else if (declaredProperties.Contains(property))
                    {
                        deepCloneWithMethodTemplate = DeepCloneWithMethodForNonInheritedPropertyCodeTemplate;
                    }
                    else
                    {
                        deepCloneWithMethodTemplate = DeepCloneWithMethodForInheritedPropertyCodeTemplate;
                    }

                    var deepCloneWithMethod = deepCloneWithMethodTemplate
                        .Replace(TypeNameToken, modelType.Type.ToStringCompilable())
                        .Replace(BaseTypeNameToken, modelType.Type.BaseType.ToStringCompilable())
                        .Replace(PropertyNameToken, property.Name)
                        .Replace(ParameterNameToken, property.Name.ToLowerFirstCharacter(CultureInfo.InvariantCulture))
                        .Replace(ParameterTypeNameToken, property.PropertyType.ToStringCompilable());

                    if (modelType.HierarchyKind != HierarchyKind.AbstractBase)
                    {
                        var propertiesCode = modelType.PropertiesOfConcern.Select(_ =>
                        {
                            var referenceItemCloned = _.PropertyType.GenerateCloningLogicCodeForType("this." + _.Name);

                            var code = _.Name == property.Name
                                ? property.Name.ToLowerFirstCharacter(CultureInfo.InvariantCulture)
                                : referenceItemCloned;

                            return new MemberCode(_.Name, code);
                        }).ToList();

                        var modelInstantiationCode = modelType.GenerateModelInstantiation(propertiesCode, parameterPaddingLength: 33);

                        deepCloneWithMethod = deepCloneWithMethod.Replace(DeepCloneWithModelInstantiationToken, modelInstantiationCode);
                    }

                    deepCloneWithMethods.Add(deepCloneWithMethod);
                }
            }

            var deepCloneWithInflationCode = string.Join(Environment.NewLine, deepCloneWithMethods);

            result = result.Replace(DeepCloneWithInflationToken, deepCloneWithInflationCode);

            return result;
        }

        /// <summary>
        /// Generates test methods that test cloning.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test cloning.
        /// </returns>
        public static string GenerateCloningTestMethods(
            this ModelType modelType)
        {
            var declaredPropertyNames = new HashSet<string>(modelType.DeclaredOnlyPropertiesOfConcern.Select(_ => _.Name));

            var assertDeepCloneSet = modelType.PropertiesOfConcern.Where(_ => !_.PropertyType.IsValueType && _.PropertyType != typeof(string)).Select(_ => Invariant($"actual.{_.Name}.AsTest().Must().NotBeSameReferenceAs(systemUnderTest.{_.Name});")).ToList();

            var assertDeepCloneToken = assertDeepCloneSet.Any() ? Environment.NewLine + "                " + string.Join(Environment.NewLine + "                ", assertDeepCloneSet) : string.Empty;

            var deepCloneWithTestMethods = new List<string>();

            if (modelType.PropertiesOfConcern.Any())
            {
                // since we have parameters we'll go ahead and pad down.
                deepCloneWithTestMethods.Add(string.Empty);

                foreach (var property in modelType.PropertiesOfConcern)
                {
                    var assertDeepCloneWithSet =
                        modelType
                            .PropertiesOfConcern
                            .Select(
                                _ =>
                                {
                                    var sourceName = _.Name == property.Name ? "referenceObject" : "systemUnderTest";

                                    var resultAssert = _.PropertyType.GenerateObcAssertionsEqualityStatement(
                                        Invariant($"actual.{_.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture)}"),
                                        Invariant($"{sourceName}.{_.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture)}"),
                                        sameReferenceExpected: false);

                                    if (_.Name != property.Name && !_.PropertyType.IsValueType && _.PropertyType != typeof(string))
                                    {
                                        resultAssert += Environment.NewLine + Invariant($"                actual.{_.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture)}.AsTest().Must().NotBeSameReferenceAs({sourceName}.{_.Name.ToUpperFirstCharacter(CultureInfo.InvariantCulture)});");
                                    }

                                    return resultAssert;
                                })
                            .ToList();

                    var assertDeepCloneWithToken = string.Join(Environment.NewLine + "                ", assertDeepCloneWithSet);

                    var deepCloneWithTestMethodCodeTemplate = declaredPropertyNames.Contains(property.Name)
                        ? DeepCloneWithTestMethodForDeclaredPropertyCodeTemplate
                        : DeepCloneWithTestMethodForNonDeclaredPropertyCodeTemplate;

                    var testMethod = deepCloneWithTestMethodCodeTemplate
                                    .Replace(TypeNameToken,                     modelType.Type.ToStringCompilable())
                                    .Replace(PropertyNameToken,                 property.Name)
                                    .Replace(ParameterNameToken,                property.Name.ToLowerFirstCharacter(CultureInfo.InvariantCulture))
                                    .Replace(DeepCloneWithTestAssertLogicToken, assertDeepCloneWithToken);

                    deepCloneWithTestMethods.Add(testMethod);
                }
            }

            var deepCloneWithTestInflationToken = string.Join(Environment.NewLine, deepCloneWithTestMethods);

            string cloningTestMethodsCodeTemplate;

            switch (modelType.HierarchyKind)
            {
                case HierarchyKind.None:
                case HierarchyKind.AbstractBase:
                    cloningTestMethodsCodeTemplate = CloningTestMethodsForNonInheritedTypeCodeTemplate;
                    break;
                case HierarchyKind.ConcreteInherited:
                    cloningTestMethodsCodeTemplate = CloningTestMethodsForConcreteInheritedTypeCodeTemplate;
                    break;
                default:
                    throw new NotSupportedException("This kind is not supported: " + modelType.HierarchyKind);
            }

            var result = cloningTestMethodsCodeTemplate
                .Replace(TypeNameToken,                   modelType.Type.ToStringCompilable())
                .Replace(AssertDeepCloneToken,            assertDeepCloneToken)
                .Replace(DeepCloneWithTestInflationToken, deepCloneWithTestInflationToken);

            return result;
        }

        private static string GenerateCloningLogicCodeForType(
            this Type type,
            string cloneCode,
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
                    result = Invariant($"{cloneCode}.DeepClone()");
                }
                else
                {
                    result = Invariant($"{cloneCode}?.DeepClone()");
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

                result = Invariant($"{cast}{cloneCode}?.ToDictionary({keyExpressionParameter} => {keyClone}, {valueExpressionParameter} => {valueClone})");
            }
            else if (type.IsSystemCollectionType())
            {
                var elementType = type.GenericTypeArguments[0];

                var expressionParameter = "i".ToExpressionParameter(recursionDepth);

                var valueClone = elementType.GenerateCloningLogicCodeForType(expressionParameter, recursionDepth);

                string cast = null;
                if (recursionDepth > 1)
                {
                    cast = "(" + type.ToStringReadable() + ")";
                }

                // note: List<T> is assignable to all System collection types except Collection<T> and ReadOnlyCollection<T>.
                // In general no properties of a model should use those types.  If we do want to support this in the future,
                // we need to wrap the List<T>:
                // - cloneCode == null ? null : new Collection<T>(cloneCode.Select(...).ToList())
                // - cloneCode == null ? null : new ReadOnlyCollection<T>(cloneCode.Select(...).ToList())
                result = Invariant($"{cast}{cloneCode}?.Select({expressionParameter} => {valueClone}).ToList()");

                if ((type.GetGenericTypeDefinition() == typeof(Collection<>)) || (type.GetGenericTypeDefinition() == typeof(ReadOnlyCollection<>)))
                {
                    result = type.GenerateSystemTypeInstantiationCode(result);
                }
            }
            else if (type.IsArray)
            {
                var elementType = type.GetElementType();

                var expressionParameter = "i".ToExpressionParameter(recursionDepth);

                var valueClone = elementType.GenerateCloningLogicCodeForType(expressionParameter, recursionDepth);

                result = Invariant($"{cloneCode}?.Select({expressionParameter} => {valueClone}).ToArray()");
            }
            else if (type == typeof(string))
            {
                // string should be cloned using it's existing interface.
                result = Invariant($"{cloneCode}?.Clone().ToString()");
            }
            else
            {
                if (type.IsNullableType())
                {
                    var underlyingType = Nullable.GetUnderlyingType(type);

                    var deepCloneableUnderlyingType = typeof(IDeepCloneable<>).MakeGenericType(underlyingType);

                    if (underlyingType.IsAssignableTo(deepCloneableUnderlyingType))
                    {
                        result = Invariant($"{cloneCode}?.DeepClone()");
                    }
                    else
                    {
                        result = cloneCode;
                    }
                }
                else if (type.IsValueType)
                {
                    // this is just a copy of the item anyway (like bool, int, Enumerations, structs like DateTime, etc.).
                    result = cloneCode;
                }
                else
                {
                    // assume that we are driving the DeepClone convention and it exists.
                    result = Invariant($"{cloneCode}?.DeepClone()");
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
                result = expressionParameter + recursionDepth.ToString(CultureInfo.InvariantCulture);
            }

            return result;
        }
    }
}