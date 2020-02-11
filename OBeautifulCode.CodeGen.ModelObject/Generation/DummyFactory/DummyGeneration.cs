﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DummyGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System.Linq;

    /// <summary>
    /// Generates code that creates model dummies.
    /// </summary>
    internal static class DummyGeneration
    {
        private const string AddDummyCreatorCodeTemplate = @"            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => [new-dummy-here]);";

        private const string UseRandomConcreteSubclassCodeTemplate = @"
            AutoFixtureBackedDummyFactory.UseRandomConcreteSubclassForDummy<[model-type-name-here]>();";

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
            string result;
            if (modelType.IsAbstractBase)
            {
                result = UseRandomConcreteSubclassCodeTemplate.Replace(Tokens.ModelTypeNameToken, modelType.TypeCompilableString);
            }
            else
            {
                var propertyNameToCodeMap = modelType.PropertiesOfConcern.Select(_ => new MemberCode(_.Name, _.PropertyType.GenerateDummyConstructionCodeForType())).ToList();

                var newDummyToken = modelType.GenerateModelInstantiation(propertyNameToCodeMap, parameterPaddingLength: 33);

                result = AddDummyCreatorCodeTemplate.Replace(Tokens.NewDummyToken, newDummyToken);
            }

            return result;
        }
    }
}