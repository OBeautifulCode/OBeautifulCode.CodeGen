// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelGenerationExtensions.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    public static class ModelGenerationExtensions
    {
        public static bool RequiresConstructor(
            this SetterKind setterKind)
        {
            bool result;
            switch (setterKind)
            {
                ////case SetterKind.GettersOnly:
                case SetterKind.PrivateSetters:
                    result = true;
                    break;
                case SetterKind.PublicSetters:
                    result = false;
                    break;
                default:
                    throw new NotSupportedException(Invariant($"This {nameof(SetterKind)} is not supported: {setterKind}"));
            }

            return result;
        }

        public static string ToSetterString(
            this SetterKind setterKind)
        {
            string result;
            switch (setterKind)
            {
                ////case SetterKind.GettersOnly:
                ////    result = string.Empty;
                ////    break;
                case SetterKind.PrivateSetters:
                    result = "private set; ";
                    break;
                case SetterKind.PublicSetters:
                    result = "set; ";
                    break;
                default:
                    throw new NotSupportedException(Invariant($"This {nameof(SetterKind)} is not supported: {setterKind}"));
            }

            return result;
        }

        public static Type ToFullyWrappedType(
            this Type type,
            TypeWrapperKind typeWrapperKind)
        {
            Type result;

            switch (typeWrapperKind)
            {
                case TypeWrapperKind.None:
                    result = type;
                    break;
                case TypeWrapperKind.Nullable:
                    result = type.IsValueType ? typeof(Nullable<>).MakeGenericType(type) : null;
                    break;
                case TypeWrapperKind.ArrayOf:
                    result = type.MakeArrayType();
                    break;
                case TypeWrapperKind.ArrayOfNullable:
                    result = type.ToFullyWrappedType(TypeWrapperKind.Nullable)?.ToFullyWrappedType(TypeWrapperKind.ArrayOf);
                    break;
                case TypeWrapperKind.IReadOnlyCollectionOf:
                    result = typeof(IReadOnlyCollection<>).MakeGenericType(type);
                    break;
                case TypeWrapperKind.IReadOnlyCollectionOfNullable:
                    result = type.ToFullyWrappedType(TypeWrapperKind.Nullable)?.ToFullyWrappedType(TypeWrapperKind.IReadOnlyCollectionOf);
                    break;
                case TypeWrapperKind.IReadOnlyListOf:
                    result = typeof(IReadOnlyList<>).MakeGenericType(type);
                    break;
                case TypeWrapperKind.IReadOnlyListOfNullable:
                    result = type.ToFullyWrappedType(TypeWrapperKind.Nullable)?.ToFullyWrappedType(TypeWrapperKind.IReadOnlyListOf);
                    break;
                case TypeWrapperKind.IReadOnlyDictionaryOf:
                    result = typeof(IReadOnlyDictionary<,>).MakeGenericType(type, type);
                    break;
                case TypeWrapperKind.IReadOnlyDictionaryOfNullable:
                    result = type.ToFullyWrappedType(TypeWrapperKind.Nullable)?.ToFullyWrappedType(TypeWrapperKind.IReadOnlyDictionaryOf);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeWrapperKind), typeWrapperKind, null);
            }

            return result;
        }

        public static string GetMustValidationMethodName(
            this Type type)
        {
            string result;

            if (type.IsValueType)
            {
                result = null;
            }
            else if (type == typeof(string))
            {
                result = nameof(Assertion.Recipes.Verifications.NotBeNullNorWhiteSpace);
            }
            else if (type.IsClosedSystemDictionaryType())
            {
                var valueType = type.GetClosedDictionaryValueType();

                result = valueType.IsValueType
                    ? nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyDictionary)
                    : nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyDictionaryNorContainAnyNullValues);
            }
            else if (type.IsClosedSystemCollectionType())
            {
                var elementType = type.GetClosedSystemCollectionElementType();

                result = elementType.IsValueType
                    ? nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyEnumerable)
                    : nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyEnumerableNorContainAnyNulls);
            }
            else if (type.IsArray)
            {
                var elementType = type.GetElementType();

                // ReSharper disable once PossibleNullReferenceException
                result = elementType.IsValueType
                    ? nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyEnumerable)
                    : nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyEnumerableNorContainAnyNulls);
            }
            else
            {
                result = nameof(Assertion.Recipes.Verifications.NotBeNull);
            }

            return result;
        }

        public static string BuildSpecifiedModelName(
            this string baseName,
            SetterKind setterKind,
            string modelNameSuffix)
        {
            var result = Invariant($"{baseName}{setterKind}{modelNameSuffix}");

            return result;
        }

        public static string BuildGeneratedModelName(
            this string baseName,
            GeneratedModelKind generatedModelKind,
            SetterKind setterKind,
            HierarchyKind hierarchyKind,
            string childIdentifier)
        {
            var result = Invariant($"{baseName}{generatedModelKind}{setterKind}{hierarchyKind.BuildNameToken()}{childIdentifier}");

            return result;
        }

        public static string BuildPropertyName(
            this Type type,
            HierarchyKind hierarchyKind,
            string prefix)
        {
            var result = Invariant($"{hierarchyKind.BuildNameToken()}{prefix}{type.BuildNameToken()}Property");

            return result;
        }

        public static string BuildNameToken(
            this HierarchyKind hierarchyKind)
        {
            string result;

            switch (hierarchyKind)
            {
                case HierarchyKind.None:
                    result = string.Empty;
                    break;
                case HierarchyKind.AbstractBaseRoot:
                    result = "Parent";
                    break;
                case HierarchyKind.ConcreteInherited:
                    result = "Child";
                    break;
                default:
                    throw new NotSupportedException("This hierarchy kind is not supported: " + hierarchyKind);
            }

            return result;
        }

        public static string BuildNameToken(
            this Type type)
        {
            string result;

            if (type.IsArray)
            {
                result = "ArrayOf" + type.GetElementType().BuildNameToken();
            }
            else if (type.IsClosedNullableType())
            {
                result = "Nullable" + Nullable.GetUnderlyingType(type).BuildNameToken();
            }
            else if (type.IsClosedSystemCollectionType())
            {
                var elementType = type.GetClosedSystemCollectionElementType();

                var genericTypeDefinition = type.GetGenericTypeDefinition();

                if (genericTypeDefinition == typeof(ICollection<>))
                {
                    result = "CollectionInterfaceOf" + elementType.BuildNameToken();
                }
                else if (genericTypeDefinition == typeof(IReadOnlyCollection<>))
                {
                    result = "ReadOnlyCollectionInterfaceOf" + elementType.BuildNameToken();
                }
                else if (genericTypeDefinition == typeof(IList<>))
                {
                    result = "ListInterfaceOf" + elementType.BuildNameToken();
                }
                else if (genericTypeDefinition == typeof(IReadOnlyList<>))
                {
                    result = "ReadOnlyListInterfaceOf" + elementType.BuildNameToken();
                }
                else if (genericTypeDefinition == typeof(Collection<>))
                {
                    result = "CollectionOf" + elementType.BuildNameToken();
                }
                else if (genericTypeDefinition == typeof(ReadOnlyCollection<>))
                {
                    result = "ReadOnlyCollectionOf" + elementType.BuildNameToken();
                }
                else if (genericTypeDefinition == typeof(List<>))
                {
                    result = "ListOf" + elementType.BuildNameToken();
                }
                else
                {
                    throw new NotSupportedException("This kind of system collection is not supported: " + type);
                }
            }
            else if (type.IsClosedSystemDictionaryType())
            {
                var valueType = type.GetClosedDictionaryValueType();

                var genericTypeDefinition = type.GetGenericTypeDefinition();

                if (genericTypeDefinition == typeof(IDictionary<,>))
                {
                    result = "DictionaryInterfaceOf" + valueType.BuildNameToken();
                }
                else if (genericTypeDefinition == typeof(IReadOnlyDictionary<,>))
                {
                    result = "ReadOnlyDictionaryInterfaceOf" + valueType.BuildNameToken();
                }
                else if (genericTypeDefinition == typeof(Dictionary<,>))
                {
                    result = "DictionaryOf" + valueType.BuildNameToken();
                }
                else if (genericTypeDefinition == typeof(ReadOnlyDictionary<,>))
                {
                    result = "ReadOnlyDictionaryOf" + valueType.BuildNameToken();
                }
                else if (genericTypeDefinition == typeof(ConcurrentDictionary<,>))
                {
                    result = "ConcurrentDictionaryOf" + valueType.BuildNameToken();
                }
                else
                {
                    throw new NotSupportedException("This kind of system dictionary is not supported: " + type);
                }
            }
            else
            {
                result = type.ToStringReadable().ToUpperFirstCharacter();
            }

            return result;
        }

        public static string GetGeneratedModelsDirectoryPath(
            this GenerationKind generationKind,
            GeneratedModelKind generatedModelKind,
            SetterKind setterKind)
        {
            string result;

            switch (generationKind)
            {
                case GenerationKind.Model:
                    result = Settings.GeneratedModelsPath + generatedModelKind + "\\" + setterKind + "\\";
                    break;
                case GenerationKind.Test:
                    result = Settings.GeneratedModelsTestsPath + generatedModelKind + "\\" + setterKind + "\\";
                    break;
                default:
                    throw new NotSupportedException("This generation kind is not supported: " + generationKind);
            }

            return result;
        }

        public static string GetSpecifiedModelsDirectoryPath(
            this SpecifiedModelKind specifiedModelKind,
            SetterKind setterKind,
            GenerationKind generationKind)
        {
            string result;

            switch (generationKind)
            {
                case GenerationKind.Model:
                    result = Settings.SpecifiedModelsPath + specifiedModelKind + "\\" + setterKind + "\\";
                    break;
                case GenerationKind.Test:
                    result = Settings.SpecifiedModelsTestPath + specifiedModelKind + "\\" + setterKind + "\\";
                    break;
                default:
                    throw new NotSupportedException("This kind is not supported: " + generationKind);
            }

            return result;
        }
    }
}
