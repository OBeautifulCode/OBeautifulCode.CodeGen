// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelGenerationExtensions.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
                case SetterKind.GettersOnly:
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
                case SetterKind.GettersOnly:
                    result = string.Empty;
                    break;
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
            else
            {
                result = nameof(Assertion.Recipes.Verifications.NotBeNull);
            }

            return result;
        }

        public static string BuildModelName(
            this string baseName,
            SetterKind setterKind,
            HierarchyKind hierarchyKind,
            string childIdentifier = null)
        {
            var result = Invariant($"{baseName}{setterKind}{hierarchyKind.BuildNameToken()}{childIdentifier}");

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
                case HierarchyKind.Abstract:
                    result = "Parent";
                    break;
                case HierarchyKind.Derivative:
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
            else if (type.IsNullableType())
            {
                result = "Nullable" + Nullable.GetUnderlyingType(type).BuildNameToken();
            }
            else if (type.IsAssignableTo(typeof(IReadOnlyDictionary<,>), treatUnboundGenericAsAssignableTo: true))
            {
                var keyType = type.GetGenericArguments().First();

                var valueType = type.GetGenericArguments().Last();

                result = "ReadOnlyDictionaryOf" + valueType.BuildNameToken();
            }
            else if (type.IsAssignableTo(typeof(IReadOnlyList<>), treatUnboundGenericAsAssignableTo: true))
            {
                var genericType = type.GetGenericArguments().First();

                result = "ReadOnlyListOf" + genericType.BuildNameToken();
            }
            else if (type.IsAssignableTo(typeof(IList<>), treatUnboundGenericAsAssignableTo: true))
            {
                var genericType = type.GetGenericArguments().First();

                result = "ListOf" + genericType.BuildNameToken();
            }
            else if (type.IsAssignableTo(typeof(IReadOnlyCollection<>), treatUnboundGenericAsAssignableTo: true))
            {
                var genericType = type.GetGenericArguments().First();

                result = "ReadOnlyCollectionOf" + genericType.BuildNameToken();
            }
            else if (type.IsAssignableTo(typeof(ICollection<>), treatUnboundGenericAsAssignableTo: true))
            {
                var genericType = type.GetGenericArguments().First();

                result = "CollectionOf" + genericType.BuildNameToken();
            }
            else
            {
                result = type.ToStringReadable().ToUpperFirstCharacter();
            }

            return result;
        }

        public static string GetGeneratedModelsPath(
            this SetterKind setterKind)
        {
            var result = CodeGeneratorTest.GeneratedModelsPath + setterKind + "\\";

            return result;
        }
    }
}
