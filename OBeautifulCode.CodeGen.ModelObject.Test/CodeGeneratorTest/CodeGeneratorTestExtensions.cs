// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CodeGeneratorTestExtensions.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.String.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    public static class CodeGeneratorTestExtensions
    {
        public static bool RequiresConstructor(
            this SetterKind setterKind)
        {
            bool result;
            switch (setterKind)
            {
                ////case SetterKind.ReadOnlyAuto:
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
                ////case SetterKind.ReadOnlyAuto:
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
                case TypeWrapperKind.NotWrapped:
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

        public static string GetMustValidationMethodCall(
            this Type type)
        {
            string result;

            var enumTypeToCheck = type.IsNullableType()
                ? Nullable.GetUnderlyingType(type)
                : type;

            if (enumTypeToCheck.IsEnum && (!enumTypeToCheck.IsFlagsEnum()))
            {
                if (enumTypeToCheck.GetAllPossibleEnumValues().Select(_ => Enum.GetName(enumTypeToCheck, _)).Contains("Unknown"))
                {
                    if (type.IsNullableType())
                    {
                        result = Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeEqualTo)}(({type.ToStringReadable()}){enumTypeToCheck.ToStringReadable()}.Unknown)");
                    }
                    else
                    {
                        result = Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeEqualTo)}({enumTypeToCheck.ToStringReadable()}.Unknown)");
                    }
                }
                else
                {
                    result = null;
                }
            }
            else if (type.IsValueType)
            {
                result = null;
            }
            else if (type == typeof(string))
            {
                result = Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeNullNorWhiteSpace)}()");
            }
            else if (type.IsClosedSystemDictionaryType())
            {
                var valueType = type.GetClosedDictionaryValueType();

                result = valueType.IsValueType
                    ? Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyDictionary)}()")
                    : Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyDictionaryNorContainAnyNullValues)}()");
            }
            else if (type.IsClosedSystemCollectionType())
            {
                var elementType = type.GetClosedSystemCollectionElementType();

                result = elementType.IsValueType
                    ? Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyEnumerable)}()")
                    : Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyEnumerableNorContainAnyNulls)}()");
            }
            else if (type.IsArray)
            {
                var elementType = type.GetElementType();

                // ReSharper disable once PossibleNullReferenceException
                result = elementType.IsValueType
                    ? Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyEnumerable)}()")
                    : Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeNullNorEmptyEnumerableNorContainAnyNulls)}()");
            }
            else
            {
                result = Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeNull)}()");
            }

            return result;
        }

        public static string GetMustEachValidationMethodCall(
            this Type type)
        {
            string result = null;

            if (type.IsClosedSystemDictionaryType())
            {
                // no-op for now
            }
            else if (type.IsClosedSystemCollectionType())
            {
                var elementType = type.GetClosedSystemCollectionElementType();

                result = elementType == typeof(string)
                    ? Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeNullNorWhiteSpace)}()")
                    : null;
            }
            else if (type.IsArray)
            {
                var elementType = type.GetElementType();

                // ReSharper disable once PossibleNullReferenceException
                result = elementType == typeof(string)
                    ? Invariant($"{nameof(Assertion.Recipes.Verifications.NotBeNullNorWhiteSpace)}()")
                    : null;
            }

            return result;
        }

        public static string BuildSpecifiedModelName(
            this SetterKind setterKind,
            string modelNameSuffix)
        {
            var result = Invariant($"{Settings.ModelBaseName}{setterKind.BuildNameToken()}{modelNameSuffix}");

            return result;
        }

        public static string BuildScriptedModelName(
            this DeclaredKeyMethod declaredKeyMethod,
            SetterKind setterKind,
            HierarchyKind hierarchyKind,
            TypeWrapperKind typeWrapperKind,
            string childIdentifier)
        {
            var result = Invariant($"{Settings.ModelBaseName}{declaredKeyMethod.BuildNameToken()}{setterKind.BuildNameToken()}{typeWrapperKind.BuildNameToken()}{hierarchyKind.BuildNameToken()}{childIdentifier}");

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
            new { hierarchyKind }.AsArg().Must().NotBeEqualTo(HierarchyKind.NotApplicable);

            switch (hierarchyKind)
            {
                case HierarchyKind.Standalone:
                    return string.Empty;
                case HierarchyKind.AbstractBaseRoot:
                    return "Parent";
                case HierarchyKind.ConcreteInherited:
                    return "Child";
                default:
                    throw new NotSupportedException("This hierarchy kind is not supported: " + hierarchyKind);
            }
        }

        public static string BuildNameToken(
            this TypeWrapperKind typeWrapperKind)
        {
            new { typeWrapperKind }.AsArg().Must().NotBeEqualTo(TypeWrapperKind.NotApplicable);

            switch (typeWrapperKind)
            {
                case TypeWrapperKind.AdditionalTypes:
                    return "Misc";
                case TypeWrapperKind.ArrayOf:
                    return "Array";
                case TypeWrapperKind.ArrayOfNullable:
                    return "ArrayOfNullable";
                case TypeWrapperKind.IReadOnlyCollectionOf:
                    return "ReadOnlyCollection";
                case TypeWrapperKind.IReadOnlyCollectionOfNullable:
                    return "ReadOnlyCollectionOfNullable";
                case TypeWrapperKind.IReadOnlyDictionaryOf:
                    return "ReadOnlyDictionary";
                case TypeWrapperKind.IReadOnlyDictionaryOfNullable:
                    return "ReadOnlyDictionaryOfNullable";
                case TypeWrapperKind.IReadOnlyListOf:
                    return "ReadOnlyList";
                case TypeWrapperKind.IReadOnlyListOfNullable:
                    return "ReadOnlyListOfNullable";
                case TypeWrapperKind.NotWrapped:
                    return "None";
                case TypeWrapperKind.Nullable:
                    return "Nullable";
                default:
                    throw new NotSupportedException("this type wrapper kind is not supported: " + typeWrapperKind);
            }
        }

        public static string BuildNameToken(
            this DeclaredKeyMethod declaredKeyMethod)
        {
            new { declaredKeyMethod }.AsArg().Must().NotBeEqualTo(DeclaredKeyMethod.NotApplicable);

            switch (declaredKeyMethod)
            {
                case DeclaredKeyMethod.NoneDeclared:
                    return "All";
                default:
                    return declaredKeyMethod.ToString();
            }
        }

        public static string BuildNameToken(
            this SetterKind setterKind)
        {
            switch (setterKind)
            {
                case SetterKind.PrivateSetters:
                    return "PrivateSet";
                case SetterKind.PublicSetters:
                    return "PublicSet";
                default:
                    throw new NotSupportedException("this setter kind is not supported: " + setterKind);
            }
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

                if (type.IsGenericType)
                {
                    result = result.Replace("<", "Of");

                    result = result.Replace(">", string.Empty);
                }
            }

            return result;
        }

        public static string GetScriptedModelsDirectoryPath(
            this ModelOrTest modelOrTest,
            DeclaredKeyMethod declaredKeyMethod,
            SetterKind setterKind,
            TypeWrapperKind typeWrapperKind)
        {
            string result;

            switch (modelOrTest)
            {
                case ModelOrTest.Model:
                    result = Settings.ScriptedModelsPath + declaredKeyMethod.BuildNameToken() + "\\" + setterKind.BuildNameToken() + "\\" + typeWrapperKind.BuildNameToken() + "\\";
                    break;
                case ModelOrTest.Test:
                    result = Settings.ScriptedModelsTestsPath + declaredKeyMethod.BuildNameToken() + "\\" + setterKind.BuildNameToken() + "\\" + typeWrapperKind.BuildNameToken() + "\\";
                    break;
                default:
                    throw new NotSupportedException("This model or test is not supported: " + modelOrTest);
            }

            return result;
        }

        public static string GetSpecifiedModelsDirectoryPath(
            this SpecifiedModelKind specifiedModelKind,
            SetterKind setterKind,
            ModelOrTest modelOrTest)
        {
            string result;

            switch (modelOrTest)
            {
                case ModelOrTest.Model:
                    result = Settings.SpecifiedModelsPath + specifiedModelKind + "\\" + setterKind.BuildNameToken() + "\\";
                    break;
                case ModelOrTest.Test:
                    result = Settings.SpecifiedModelsTestPath + specifiedModelKind + "\\" + setterKind.BuildNameToken() + "\\";
                    break;
                default:
                    throw new NotSupportedException("This kind is not supported: " + modelOrTest);
            }

            return result;
        }

        public static IReadOnlyCollection<Type> GetModelTypes()
        {
            var result = typeof(CodeGeneratorTest)
                .Assembly
                .GetTypes()
                .Where(_ => _.Name.StartsWith(Settings.ModelBaseName, StringComparison.Ordinal))
                .Where(_ => !_.Name.EndsWith(Settings.TestNameSuffix, StringComparison.Ordinal))
                .ToList();

            return result;
        }

        public static string GetUserCodeFilePath(
            this string modelName,
            ModelOrTest modelOrTest,
            string directoryPath)
        {
            var className = modelName.GetFileNameWithoutExtension(modelOrTest);

            var result = Path.Combine(directoryPath, className + ".cs");

            return result;
        }

        public static string GetDesignerFilePath(
            this string modelName,
            ModelOrTest modelOrTest,
            string directoryPath)
        {
            var className = modelName.GetFileNameWithoutExtension(modelOrTest);

            var result = Path.Combine(directoryPath, className + ".designer.cs");

            return result;
        }

        public static string GetFileNameWithoutExtension(
            this string modelName,
            ModelOrTest modelOrTest)
        {
            modelName = modelName.Replace(" ", string.Empty);

            var result = modelOrTest == ModelOrTest.Model
                ? modelName
                : modelName + Settings.TestNameSuffix;

            return result;
        }

        public static Type GetModelType(
            this string modelName)
        {
            var genericParameterRegex = new Regex("{(.*?)}$");

            var genericParameterMatch = genericParameterRegex.Match(modelName);

            if (genericParameterMatch.Success)
            {
                var numberOfGenericParameters = genericParameterMatch.Groups[1].ToString().Split(',').Length;

                modelName = genericParameterRegex.Replace(modelName, Invariant($"`{numberOfGenericParameters}"));
            }

            var result = typeof(CodeGeneratorTest).Assembly.GetTypes().Single(_ => _.Name == modelName);

            return result;
        }

        public static void CommentOutFile(
            this string filePath)
        {
            // this approach results in stylecop errors, so we are just going to move the file to a temp file
            ////var lines = File.ReadAllLines(filePath);

            ////if (lines.Any())
            ////{
            ////    var commentedOutLines = lines.Select(_ => _.StartsWith(Settings.Comment) ? _ : (Settings.Comment + _)).ToList().ToNewLineDelimited();

            ////    File.WriteAllText(filePath, commentedOutLines, Settings.Encoding);
            ////}
            var tempFilePath = filePath + Settings.CommentOutFileExtension;

            if (File.ReadAllBytes(filePath).Any())
            {
                File.Move(filePath, tempFilePath);

                File.WriteAllBytes(filePath, new byte[0]);
            }
        }

        public static void UncommentFile(
            this string filePath)
        {
            // this approach results in stylecop errors, so we are just going to move the file to a temp file
            ////var lines = File.ReadAllLines(filePath);

            ////if (lines.Any())
            ////{
            ////    var uncommentedLines = lines.Select(_ => _.StartsWith(Settings.Comment) ? _.Substring(Settings.Comment.Length, _.Length - Settings.Comment.Length) : _).ToList().ToNewLineDelimited();

            ////    File.WriteAllText(filePath, uncommentedLines, Settings.Encoding);
            ////}
            var tempFilePath = filePath + Settings.CommentOutFileExtension;

            if (File.Exists(tempFilePath))
            {
                File.Delete(filePath);

                File.Move(tempFilePath, filePath);
            }
        }

        public static string GetFileHeader(
            this string fileNameWithoutExtension)
        {
            var lines = new List<string>
            {
                "// --------------------------------------------------------------------------------------------------------------------",
                Invariant($"// <copyright file=\"{fileNameWithoutExtension}.cs\" company=\"OBeautifulCode\">"),
                "//   Copyright (c) OBeautifulCode 2018. All rights reserved.",
                "// </copyright>",
                "// <auto-generated>",
                "//   Sourced from OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest",
                "// </auto-generated>",
                "// --------------------------------------------------------------------------------------------------------------------",
                string.Empty,
            };

            var result = lines.ToNewLineDelimited();

            return result;
        }
    }
}
