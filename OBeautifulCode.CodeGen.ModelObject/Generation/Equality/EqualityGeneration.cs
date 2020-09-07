// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EqualityGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to equality.
    /// </summary>
    internal static class EqualityGeneration
    {
        /// <summary>
        /// Generates equality methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated equality methods.
        /// </returns>
        public static string GenerateEqualityMethods(
            this ModelType modelType)
        {
            var codeTemplate = typeof(EqualityGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.Model, modelType.EqualsKeyMethodKinds);

            var equalityStatements = modelType
                .PropertiesOfConcern
                .Select(_ => _.GenerateEqualityLogicCodeForProperty())
                .ToList();

            var equalityStatementsCode = modelType.PropertiesOfConcern.Any()
                ? string.Join(Environment.NewLine + "                      && ", equalityStatements)
                : "true";

            var dateTimeUsedAsKeyInDictionaryCheckCode = string.Empty;

            if ((modelType.ClassifiedHierarchyKind == ClassifiedHierarchyKind.Concrete) &&
                (modelType.EqualsKeyMethodKinds == KeyMethodKinds.Generated) &&
                modelType.GenericParametersUsedAsKeyInDictionary.Any())
            {
                dateTimeUsedAsKeyInDictionaryCheckCode =
                    typeof(EqualityGeneration).GetCodeTemplate(ClassifiedHierarchyKind.Concrete, CodeTemplateKind.ModelSnippet, KeyMethodKinds.Declared, CodeSnippetKind.DateTimeUsedAsKeyInDictionaryCheck)
                        .Replace(Tokens.GenericTypeParameterNamesToken, modelType.GenericParametersUsedAsKeyInDictionary.Select(_ => Invariant($"typeof({_.Name})")).ToDelimitedString(", "));
            }

            var result = codeTemplate
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                .Replace(Tokens.ModelTypeNameInXmlDocToken, modelType.TypeNameInXmlDocString)
                .Replace(Tokens.EqualityStatementsToken, equalityStatementsCode)
                .Replace(Tokens.DateTimeUsedAsKeyInDictionaryCheck, dateTimeUsedAsKeyInDictionaryCheckCode);

            return result;
        }

        /// <summary>
        /// Generates fields required to test equality.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated fields required to test equality.
        /// </returns>
        public static string GenerateEqualityTestFields(
            this ModelType modelType)
        {
            var keyMethodKinds = modelType.DeclaresEqualsMethodDirectlyOrInDerivative ||
                                 modelType.DeclaresGetHashCodeMethodDirectlyOrInDerivative
                ? KeyMethodKinds.Declared
                : KeyMethodKinds.Generated;

            string result;

            if (keyMethodKinds == KeyMethodKinds.Declared)
            {
                result = typeof(EqualityGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, keyMethodKinds, CodeSnippetKind.EquatableTestFields)
                    .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString);
            }
            else
            {
                result = modelType.GetEqualityTestFieldsForGeneratedEquality(keyMethodKinds, CodeSnippetKind.EquatableTestFields);
            }

            return result;
        }

        /// <summary>
        /// Generates fields required to test equality in user (non-designer) code.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated fields required to test equality in user (non-designer) code.
        /// </returns>
        public static string GenerateEqualityTestFieldsInUserCode(
            this ModelType modelType)
        {
            var result = modelType.GetEqualityTestFieldsForGeneratedEquality(KeyMethodKinds.Generated, CodeSnippetKind.EquatableTestFieldsInUserCode);

            return result;
        }

        /// <summary>
        /// Generates test methods that test equality.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test equality.
        /// </returns>
        public static string GenerateEqualityTestMethods(
            this ModelType modelType)
        {
            var equalsTestTemplate = typeof(EqualityGeneration).GetCodeTemplate(CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.EqualsTests);

            var equalsItems = new List<string>();

            for (int x = 0; x < modelType.DerivativePathTypesNamesInCodeFromRootToSelf.Count; x++)
            {
                var derivativeTypeNameInCode = modelType.DerivativePathTypesNamesInCodeFromRootToSelf[x];
                var derivativeTypeNameInIdentifier = modelType.DerivativePathTypesNamesInIdentifierFromRootToSelf[x];

                var equalsItem = equalsTestTemplate
                    .Replace(Tokens.ModelTypeNameInCodeToken, derivativeTypeNameInCode)
                    .Replace(Tokens.ModelTypeNameInIdentifierToken, derivativeTypeNameInIdentifier)
                    .Replace(Tokens.CastToken, derivativeTypeNameInCode == modelType.TypeNameInCodeString ? string.Empty : Invariant($"({derivativeTypeNameInCode})"));

                equalsItems.Add(equalsItem);
            }

            var codeTemplate = typeof(EqualityGeneration).GetCodeTemplate(CodeTemplateKind.Test, KeyMethodKinds.Both);

            var result = codeTemplate
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                .Replace(Tokens.ModelTypeNameInIdentifierToken, modelType.TypeNameInIdentifierString)
                .Replace(Tokens.EqualsTestsToken, equalsItems.ToDelimitedString(Environment.NewLine + Environment.NewLine) + Environment.NewLine);

            return result;
        }

        private static string GenerateEqualityLogicCodeForProperty(
            this PropertyOfConcern propertyOfConcern)
        {
            new { propertyOfConcern }.AsArg().Must().NotBeNull();

            var result = (propertyOfConcern.PropertyType == typeof(string))
                ? Invariant($"this.{propertyOfConcern.Name}.IsEqualTo(other.{propertyOfConcern.Name}, StringComparer.Ordinal)")
                : Invariant($"this.{propertyOfConcern.Name}.IsEqualTo(other.{propertyOfConcern.Name})");

            return result;
        }

        private static string GetEqualityTestFieldsForGeneratedEquality(
            this ModelType modelType,
            KeyMethodKinds keyMethodKinds,
            CodeSnippetKind codeSnippetKind)
        {
            var codeTemplate = typeof(EqualityGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.TestSnippet, keyMethodKinds, codeSnippetKind);

            var objectsThatDeriveFromScenarioTypeButAreNotOfSameTypeAsReferenceObject = (modelType.ExampleConcreteDerivativeTypeNamesInCodeStrings.Count() >= 2)
                ? Environment.NewLine + typeof(EqualityGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.TestSnippet, keyMethodKinds, CodeSnippetKind.EquatableTestFieldsScenarioTypeDerivativeThatIsNotSameTypeAsReferenceObject, throwIfDoesNotExist: false)
                : string.Empty;

            var objectsEqualToButNotTheSameAsReferenceObjectMemberCode = modelType.PropertiesOfConcern.Select(_ => new MemberCode(_.Name, "ReferenceObjectForEquatableTestScenarios." + _.Name)).ToList();
            var objectsEqualToButNotTheSameAsReferenceObject = modelType.GenerateModelInstantiation(objectsEqualToButNotTheSameAsReferenceObjectMemberCode, parameterPaddingLength: 32);

            var objectsNotEqualToReferenceObject = modelType.GetObjectsNotEqualToReferenceObject();

            var dummyAncestorConcreteDerivatives = modelType.ExampleAncestorConcreteDerivativeTypeNamesInCodeStrings.Any()
                ? Environment.NewLine + "                        " + modelType.ExampleAncestorConcreteDerivativeTypeNamesInCodeStrings.Select(_ => _.GenerateDummyConstructionCodeForType() + ",").ToDelimitedString(Environment.NewLine + "                        ")
                : string.Empty;

            var result = codeTemplate
                .Replace(Tokens.ScenarioTypeDerivativeThatIsNotSameTypeAsReferenceObjectToken, objectsThatDeriveFromScenarioTypeButAreNotOfSameTypeAsReferenceObject)
                .Replace(Tokens.ObjectsEqualToButNotTheSameAsReferenceObjectToken, objectsEqualToButNotTheSameAsReferenceObject)
                .Replace(Tokens.ObjectsNotEqualToReferenceObjectToken, objectsNotEqualToReferenceObject)
                .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                .Replace(Tokens.DummyAncestorConcreteDerivativesToken, dummyAncestorConcreteDerivatives);

            return result;
        }

        private static string GetObjectsNotEqualToReferenceObject(
            this ModelType modelType)
        {
            var unequalSet = new List<string>();

            var objectNotEqualToReferenceObjectCodeSnippet = typeof(EqualityGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.TestSnippet, KeyMethodKinds.Generated, CodeSnippetKind.EquatableTestFieldsObjectNotEqualToReferenceObject);

            foreach (var property in modelType.PropertiesOfConcern)
            {
                if (modelType.IsAbstractBase)
                {
                    var cast = modelType.DeclaresProperty(property)
                        ? string.Empty
                        : Invariant($"({modelType.TypeNameInCodeString})");

                    var code = objectNotEqualToReferenceObjectCodeSnippet
                        .Replace(Tokens.PropertyNameToken, property.Name)
                        .Replace(Tokens.CastToken, cast);

                    unequalSet.Add(code);
                }
                else
                {
                    if (!modelType.IsMissingCorrespondingConstructorParameter(property))
                    {
                        var propertiesCode = modelType.PropertiesOfConcern.Select(_ =>
                        {
                            var referenceObject = "ReferenceObjectForEquatableTestScenarios." + _.Name;

                            var memberCode = _.Name != property.Name
                                ? referenceObject
                                : objectNotEqualToReferenceObjectCodeSnippet
                                    .Replace(Tokens.PropertyNameToken, property.Name);

                            return new MemberCode(_.Name, memberCode);
                        }).ToList();

                        var code = modelType.GenerateModelInstantiation(propertiesCode, parameterPaddingLength: 32);

                        unequalSet.Add(code);
                    }
                }
            }

            var result = unequalSet.Any()
                ? Environment.NewLine + "                        " + string.Join("," + Environment.NewLine + "                        ", unequalSet) + ","
                : string.Empty;

            return result;
        }
    }
}