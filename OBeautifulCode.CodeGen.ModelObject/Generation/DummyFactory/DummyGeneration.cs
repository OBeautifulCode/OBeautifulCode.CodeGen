// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DummyGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;

    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Reflection.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code that creates model dummies.
    /// </summary>
    internal static class DummyGeneration
    {
        /// <summary>
        /// Generates code for a dummy factory.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated code for a dummy factory.
        /// </returns>
        public static string GenerateCodeForDummyFactory(
            this ModelType modelType)
        {
            var codeTemplate = typeof(DummyGeneration).GetCodeTemplate(modelType.ClassifiedHierarchyKind, CodeTemplateKind.Model, KeyMethodKinds.Both);

            string result;

            if (modelType.IsAbstractBase)
            {
                var concreteDerivativeTypeNamesCode = modelType
                    .ExampleConcreteDerivativeTypeNamesInCodeStrings
                    .Select(_ => Invariant($"typeof({_})"))
                    .ToDelimitedString(Invariant($",{Environment.NewLine}                        "));

                result = codeTemplate
                    .Replace(Tokens.ModelTypeNameInCodeToken, modelType.TypeNameInCodeString)
                    .Replace(Tokens.ConcreteDerivativeTypeNamesInCodeToken, concreteDerivativeTypeNamesCode);
            }
            else
            {
                // Branch on having constructor here because constructor parameter type might be more derived than property type.
                var propertyNameToCodeMap = modelType.Constructor.IsDefaultConstructor()
                    ? modelType.PropertiesOfConcern.Select(_ => new MemberCode(_.Name, _.PropertyType.ToStringReadable().GenerateDummyConstructionCodeForType())).ToList()
                    : modelType.Constructor.GetParameters().Select(_ => new MemberCode(_.Name, _.ParameterType.ToStringReadable().GenerateDummyConstructionCodeForType())).ToList();

                var newDummyToken = modelType.GenerateModelInstantiation(propertyNameToCodeMap, parameterPaddingLength: 33);

                result = codeTemplate.Replace(Tokens.NewDummyToken, newDummyToken);
            }

            return result;
        }
    }
}