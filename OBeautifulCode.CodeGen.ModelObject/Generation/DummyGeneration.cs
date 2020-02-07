// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DummyGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type.Recipes;

    /// <summary>
    /// Generates code that creates model dummies.
    /// </summary>
    internal static class DummyGeneration
    {
        private const string NewDummyToken = "<<<NEWDUMMYLOGICHERE>>>";
        private const string TypeNameToken = "<<<TYPENAMEHERE>>>";

        private const string AddDummyCreatorCodeTemplate = @"            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => " + NewDummyToken + @");";

        private const string UseRandomConcreteSubclassCodeTemplate = @"
            AutoFixtureBackedDummyFactory.UseRandomConcreteSubclassForDummy<" + TypeNameToken + @">();";

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
            if (modelType.HierarchyKind == HierarchyKind.AbstractBaseRoot)
            {
                result = UseRandomConcreteSubclassCodeTemplate.Replace(TypeNameToken, modelType.TypeCompilableString);
            }
            else
            {
                var propertyNameToCodeMap = modelType.PropertiesOfConcern.Select(_ => new MemberCode(_.Name, _.PropertyType.GenerateDummyConstructionCodeForType())).ToList();

                var newDummyToken = modelType.GenerateModelInstantiation(propertyNameToCodeMap, parameterPaddingLength: 33);

                result = AddDummyCreatorCodeTemplate.Replace(NewDummyToken, newDummyToken);
            }

            return result;
        }

        /// <summary>
        /// Generates code that constructs a dummy model.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="thatIsNot">Code to inject into a ThatIsNot qualification.</param>
        /// <returns>
        /// Generated code that constructs a dummy model.
        /// </returns>
        public static string GenerateDummyConstructionCodeForType(
            this Type type,
            string thatIsNot = null)
        {
            type.AsArg(nameof(type)).Must().NotBeNull();

            var result =
                string.IsNullOrWhiteSpace(thatIsNot)
                    ? "A.Dummy<" + type.ToStringCompilable() + ">()"
                    : "A.Dummy<" + type.ToStringCompilable() + ">().ThatIsNot(" + thatIsNot + ")";

            return result;
        }
    }
}