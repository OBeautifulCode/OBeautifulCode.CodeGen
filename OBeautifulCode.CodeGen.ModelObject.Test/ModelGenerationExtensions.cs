﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelGenerationExtensions.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;

    using static System.FormattableString;

    public static class ModelGenerationExtensions
    {
        public static bool RequiresConstructor(
            this SetterKind setterKind)
        {
            bool result;
            switch (setterKind)
            {
                case SetterKind.None:
                case SetterKind.Private:
                    result = true;
                    break;
                case SetterKind.Public:
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
                case SetterKind.None:
                    result = string.Empty;
                    break;
                case SetterKind.Private:
                    result = "private set; ";
                    break;
                case SetterKind.Public:
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
                case TypeWrapperKind.ReadOnlyCollectionOf:
                    result = typeof(IReadOnlyCollection<>).MakeGenericType(type);
                    break;
                case TypeWrapperKind.ReadOnlyCollectionOfNullable:
                    result = type.ToFullyWrappedType(TypeWrapperKind.Nullable)?.ToFullyWrappedType(TypeWrapperKind.ReadOnlyCollectionOf);
                    break;
                case TypeWrapperKind.ReadOnlyDictionaryOf:
                    result = typeof(IReadOnlyDictionary<,>).MakeGenericType(type, type);
                    break;
                case TypeWrapperKind.ReadOnlyDictionaryOfNullable:
                    result = type.ToFullyWrappedType(TypeWrapperKind.Nullable)?.ToFullyWrappedType(TypeWrapperKind.ReadOnlyDictionaryOf);
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
    }
}
