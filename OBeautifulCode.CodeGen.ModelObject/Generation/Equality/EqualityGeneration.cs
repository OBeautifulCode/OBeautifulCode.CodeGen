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
            var codeTemplate = typeof(EqualityGeneration).GetCodeTemplate(modelType.HierarchyKinds.Classify(), CodeTemplateKind.Model, modelType.EqualsKeyMethodKinds);

            var equalityStatements = modelType
                .PropertiesOfConcern
                .Select(_ => _.GenerateEqualityLogicCodeForProperty())
                .ToList();

            var equalityStatementsCode = modelType.PropertiesOfConcern.Any()
                ? string.Join(Environment.NewLine + "                      && ", equalityStatements)
                : "true";

            var result = codeTemplate
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                .Replace(Tokens.EqualityStatementsToken, equalityStatementsCode);

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

            string codeTemplate;
            var objectsThatDeriveFromScenarioTypeButAreNotOfSameTypeAsReferenceObject = string.Empty;
            var objectsEqualToButNotTheSameAsReferenceObject = string.Empty;
            var objectsNotEqualToReferenceObject = string.Empty;
            var dummyAncestorConcreteDerivatives = string.Empty;

            if (keyMethodKinds == KeyMethodKinds.Declared)
            {
                codeTemplate = typeof(EqualityGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, keyMethodKinds, CodeSnippetKind.EquatableTestFields);
            }
            else
            {
                var hierarchyKinds = modelType.HierarchyKinds.Classify();

                codeTemplate = typeof(EqualityGeneration).GetCodeTemplate(hierarchyKinds, CodeTemplateKind.TestSnippet, keyMethodKinds, CodeSnippetKind.EquatableTestFields);

                objectsThatDeriveFromScenarioTypeButAreNotOfSameTypeAsReferenceObject = (modelType.ConcreteDerivativeTypesCompilableStrings.Count() >= 2)
                    ? Environment.NewLine + typeof(EqualityGeneration).GetCodeTemplate(hierarchyKinds, CodeTemplateKind.TestSnippet, keyMethodKinds, CodeSnippetKind.EquatableTestFieldsScenarioTypeDerivativeThatIsNotSameTypeAsReferenceObject, throwIfDoesNotExist: false)
                    : string.Empty;

                var objectsEqualToButNotTheSameAsReferenceObjectMemberCode = modelType.PropertiesOfConcern.Select(_ => new MemberCode(_.Name, "ReferenceObjectForEquatableTestScenarios." + _.Name)).ToList();
                objectsEqualToButNotTheSameAsReferenceObject = modelType.GenerateModelInstantiation(objectsEqualToButNotTheSameAsReferenceObjectMemberCode, parameterPaddingLength: 32);

                objectsNotEqualToReferenceObject = modelType.GetObjectsNotEqualToReferenceObject();

                dummyAncestorConcreteDerivatives = modelType.AncestorConcreteDerivativesCompilableStrings.Any()
                    ? Environment.NewLine + "                        " + modelType.AncestorConcreteDerivativesCompilableStrings.Select(_ => _.GenerateDummyConstructionCodeForType() + ",").ToDelimitedString(Environment.NewLine + "                        ")
                    : string.Empty;
            }

            var result = codeTemplate
                .Replace(Tokens.ScenarioTypeDerivativeThatIsNotSameTypeAsReferenceObjectToken, objectsThatDeriveFromScenarioTypeButAreNotOfSameTypeAsReferenceObject)
                .Replace(Tokens.ObjectsEqualToButNotTheSameAsReferenceObjectToken, objectsEqualToButNotTheSameAsReferenceObject)
                .Replace(Tokens.ObjectsNotEqualToReferenceObjectToken, objectsNotEqualToReferenceObject)
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                .Replace(Tokens.DummyAncestorConcreteDerivativesToken, dummyAncestorConcreteDerivatives);

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
            var equalsTestTemplate = typeof(EqualityGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.TestSnippet, KeyMethodKinds.Both, CodeSnippetKind.EqualsTests);

            var equalsItems = new List<string>();

            foreach (var typeCompilableString in modelType.DerivativePathFromRootToSelfCompilableStrings)
            {
                var equalsItem = equalsTestTemplate
                    .Replace(Tokens.ModelTypeNameToken, typeCompilableString)
                    .Replace(Tokens.CastToken, typeCompilableString == modelType.TypeCompilableString ? string.Empty : Invariant($"({typeCompilableString})"));

                equalsItems.Add(equalsItem);
            }

            var codeTemplate = typeof(EqualityGeneration).GetCodeTemplate(HierarchyKinds.All, CodeTemplateKind.Test, KeyMethodKinds.Both);

            var result = codeTemplate
                .Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString)
                .Replace(Tokens.EqualsTestsToken, equalsItems.ToDelimitedString(Environment.NewLine + Environment.NewLine) + Environment.NewLine);

            return result;
        }

        /// <summary>
        /// Generates an assertion equality statement.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="expected">The expected value.</param>
        /// <param name="sameReferenceExpected">A value indicating whether the same reference expected for reference types.</param>
        /// <returns>
        /// Generated assertion equality statement.
        /// </returns>
        public static string GenerateObcAssertionsEqualityStatement(
            this Type type,
            string actual,
            string expected,
            bool sameReferenceExpected)
        {
            string result;

            if ((!type.IsValueType) && sameReferenceExpected)
            {
                result = Invariant($"{actual}.AsTest().Must().BeSameReferenceAs({expected});");
            }
            else
            {
                result = Invariant($"{actual}.AsTest().Must().BeEqualTo({expected});");
            }

            return result;
        }

        private static string GenerateEqualityLogicCodeForProperty(
            this PropertyOfConcern propertyOfConcern)
        {
            new { propertyOfConcern }.AsArg().Must().NotBeNull();

            var result = (propertyOfConcern.PropertyType == typeof(string))
                ? Invariant($"this.{propertyOfConcern.Name}.Equals(other.{propertyOfConcern.Name}, StringComparison.Ordinal)")
                : Invariant($"this.{propertyOfConcern.Name}.IsEqualTo(other.{propertyOfConcern.Name})");

            return result;
        }

        private static string GetObjectsNotEqualToReferenceObject(
            this ModelType modelType)
        {
            var unequalSet = new List<string>();

            foreach (var property in modelType.PropertiesOfConcern)
            {
                if (modelType.IsAbstractBase)
                {
                    var cast = modelType.DeclaresProperty(property)
                        ? string.Empty
                        : Invariant($"({modelType.TypeCompilableString})");

                    var code = typeof(EqualityGeneration).GetCodeTemplate(modelType.HierarchyKinds.Classify(), CodeTemplateKind.TestSnippet, KeyMethodKinds.Generated, CodeSnippetKind.EquatableTestFieldsObjectNotEqualToReferenceObject)
                        .Replace(Tokens.PropertyNameToken, property.Name)
                        .Replace(Tokens.PropertyTypeNameToken, property.PropertyType.ToStringCompilable())
                        .Replace(Tokens.CastToken, cast);

                    unequalSet.Add(code);
                }
                else
                {
                    var propertiesCode = modelType.PropertiesOfConcern.Select(_ =>
                    {
                        var referenceObject = "ReferenceObjectForEquatableTestScenarios." + _.Name;

                        var memberCode = _.Name != property.Name
                            ? referenceObject
                            : typeof(EqualityGeneration).GetCodeTemplate(modelType.HierarchyKinds.Classify(), CodeTemplateKind.TestSnippet, KeyMethodKinds.Generated, CodeSnippetKind.EquatableTestFieldsObjectNotEqualToReferenceObject)
                                .Replace(Tokens.PropertyNameToken, property.Name)
                                .Replace(Tokens.PropertyTypeNameToken, property.PropertyType.ToStringCompilable());

                        return new MemberCode(_.Name, memberCode);
                    }).ToList();

                    var code = modelType.GenerateModelInstantiation(propertiesCode, parameterPaddingLength: 32);

                    unequalSet.Add(code);
                }
            }

            var result = unequalSet.Any()
                ? Environment.NewLine + "                        " + string.Join("," + Environment.NewLine + "                        ", unequalSet) + ","
                : string.Empty;

            return result;
        }
    }
}