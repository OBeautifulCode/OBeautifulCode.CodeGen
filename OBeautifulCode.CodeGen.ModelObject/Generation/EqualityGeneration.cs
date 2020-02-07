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
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to equality.
    /// </summary>
    internal static class EqualityGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";
        private const string PropertyNameToken = "<<<PropertyNameHere>>>";
        private const string PropertyTypeNameToken = "<<<PropertyTypeNameHere>>>";
        private const string EqualsMethodToken = "<<<EqualsMethodHere>>>";
        private const string EqualityToken = "<<<EqualityLogicHere>>>";
        private const string NewObjectForEquatableToken = "<<<NewObjectLogicForEquatableHere>>>";
        private const string UnequalObjectsToken = "<<<UnequalObjectsCreationHere>>>";
        private const string ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObjectToken = "<<<ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObjectHere>>>";

        private const string EqualityTestFieldsForDeclaredTypeCodeTemplate = @"    private static readonly EquatableTestScenarios<" + TypeNameToken + @"> EquatableTestScenarios = new EquatableTestScenarios<" + TypeNameToken + @">();";

        private const string EqualityTestFieldsForAbstractBaseTypeCodeTemplate = @"    private static readonly " + TypeNameToken + @" ReferenceObjectForEquatableTestScenarios = A.Dummy<" + TypeNameToken + @">();
            
        private static readonly EquatableTestScenarios<" + TypeNameToken + @"> EquatableTestScenarios = new EquatableTestScenarios<" + TypeNameToken + @">()
            .AddScenario(
                new EquatableTestScenario<" + TypeNameToken + @">
                {
                    Name = ""Code Generated Scenario"",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new " + TypeNameToken + @"[]
                    {
                        ReferenceObjectForEquatableTestScenarios.DeepClone(),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new " + TypeNameToken + @"[]
                    {" + UnequalObjectsToken + @"
                    }," + ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObjectToken + @"
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                    },
                });";

        private const string EqualityTestFieldsForConcreteTypeCodeTemplate = @"    private static readonly " + TypeNameToken + @" ReferenceObjectForEquatableTestScenarios = A.Dummy<" + TypeNameToken + @">();
        
        private static readonly EquatableTestScenarios<" + TypeNameToken + @"> EquatableTestScenarios = new EquatableTestScenarios<" + TypeNameToken + @">()
            .AddScenario(
                new EquatableTestScenario<" + TypeNameToken + @">
                {
                    Name = ""Code Generated Scenario"",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new " + TypeNameToken + @"[]
                    {
                        " + NewObjectForEquatableToken + @",
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new " + TypeNameToken + @"[]
                    {" + UnequalObjectsToken + @"
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                    },
                });";

        private const string UnequalObjectTokenForAbstractBaseTypeCodeTemplate = @"ReferenceObjectForEquatableTestScenarios.DeepCloneWith" + PropertyNameToken + @"(A.Dummy<" + PropertyTypeNameToken + @">().ThatIsNot(ReferenceObjectForEquatableTestScenarios." + PropertyNameToken + @"))";

        private const string ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObjectCodeTemplate = @"
                    ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new " + TypeNameToken + @"[]
                    {
                        A.Dummy<" + TypeNameToken + @">().Whose(_ => _.GetType() != ReferenceObjectForEquatableTestScenarios.GetType()),
                    },";

        private const string EqualsMethodForConcreteTypeCodeTemplate = @"

        /// <inheritdoc />
        public bool Equals(" + TypeNameToken + @" other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = " + EqualityToken + @";

            return result;
        }";

        private const string EqualityMethodsForConcreteTypeCodeTemplate = @"    /// <summary>
        /// Determines whether two objects of type <see cref=""" + TypeNameToken + @"""/> are equal.
        /// </summary>
        /// <param name=""left"">The object to the left of the equality operator.</param>
        /// <param name=""right"">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(" + TypeNameToken + @" left, " + TypeNameToken + @" right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals(right);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref=""" + TypeNameToken + @"""/> are not equal.
        /// </summary>
        /// <param name=""left"">The object to the left of the equality operator.</param>
        /// <param name=""right"">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(" + TypeNameToken + @" left, " + TypeNameToken + @" right) => !(left == right);" + EqualsMethodToken + @"

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as " + TypeNameToken + @");";

        private const string EqualityMethodsForAbstractBaseTypeCodeTemplate = @"    /// <summary>
        /// Determines whether two objects of type <see cref=""" + TypeNameToken + @"""/> are equal.
        /// </summary>
        /// <param name=""left"">The object to the left of the equality operator.</param>
        /// <param name=""right"">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(" + TypeNameToken + @" left, " + TypeNameToken + @" right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals((object)right);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref=""" + TypeNameToken + @"""/> are not equal.
        /// </summary>
        /// <param name=""left"">The object to the left of the equality operator.</param>
        /// <param name=""right"">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(" + TypeNameToken + @" left, " + TypeNameToken + @" right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(" + TypeNameToken + @" other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);";

        private const string EqualityTestMethodsCodeTemplate = @"    public static class Equality
        {
            [Fact]
            public static void EqualsOperator___Should_return_true___When_both_sides_of_operator_are_null()
            {
                // Arrange
                " + TypeNameToken + @" systemUnderTest1 = null;
                " + TypeNameToken + @" systemUnderTest2 = null;

                // Act
                var actual = systemUnderTest1 == systemUnderTest2;

                // Assert
                actual.AsTest().Must().BeTrue();
            }

            [Fact]
            public static void EqualsOperator___Should_return_false___When_one_side_of_operator_is_null_and_the_other_side_is_not_null()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange
                    " + TypeNameToken + @" systemUnderTest = null;

                    // Act
                    var actual1 = systemUnderTest == scenario.ReferenceObject;
                    var actual2 = scenario.ReferenceObject == systemUnderTest;

                    // Assert
                    actual1.AsTest().Must().BeFalse(because: scenario.Id);
                    actual2.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void EqualsOperator___Should_return_true___When_same_object_is_on_both_sides_of_operator()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    #pragma warning disable CS1718 // Comparison made to same variable
                    var actual = scenario.ReferenceObject == scenario.ReferenceObject;
                    #pragma warning restore CS1718 // Comparison made to same variable

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void EqualsOperator___Should_return_false___When_objects_being_compared_derive_from_the_same_type_but_are_not_of_the_same_type()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => scenario.ReferenceObject == _).ToList();
                    var actuals2 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => _ == scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void EqualsOperator___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => scenario.ReferenceObject == _).ToList();
                    var actuals2 = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => _ == scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void EqualsOperator___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject == _).ToList();
                    var actuals2 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => _ == scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_both_sides_of_operator_are_null()
            {
                // Arrange
                " + TypeNameToken + @" systemUnderTest1 = null;
                " + TypeNameToken + @" systemUnderTest2 = null;

                // Act
                var actual = systemUnderTest1 != systemUnderTest2;

                // Assert
                actual.AsTest().Must().BeFalse();
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_true___When_one_side_of_operator_is_null_and_the_other_side_is_not_null()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange
                    " + TypeNameToken + @" systemUnderTest = null;

                    // Act
                    var actual1 = systemUnderTest != scenario.ReferenceObject;
                    var actual2 = scenario.ReferenceObject != systemUnderTest;

                    // Assert
                    actual1.AsTest().Must().BeTrue(because: scenario.Id);
                    actual2.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_same_object_is_on_both_sides_of_operator()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    #pragma warning disable CS1718 // Comparison made to same variable
                    var actual = scenario.ReferenceObject != scenario.ReferenceObject;
                    #pragma warning restore CS1718 // Comparison made to same variable

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_true___When_objects_being_compared_derive_from_the_same_type_but_are_not_of_the_same_type()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => scenario.ReferenceObject != _).ToList();
                    var actuals2 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => _ != scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_true___When_objects_being_compared_have_different_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => scenario.ReferenceObject != _).ToList();
                    var actuals2 = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => _ != scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeTrue(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void NotEqualsOperator___Should_return_false___When_objects_being_compared_have_same_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject != _).ToList();
                    var actuals2 = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => _ != scenario.ReferenceObject).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_" + TypeNameToken + @"___Should_return_false___When_parameter_other_is_null()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange
                    " + TypeNameToken + @" systemUnderTest = null;

                    // Act
                    var actual = scenario.ReferenceObject.Equals(systemUnderTest);

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_" + TypeNameToken + @"___Should_return_true___When_parameter_other_is_same_object()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject.Equals(scenario.ReferenceObject);

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_" + TypeNameToken + @"___Should_return_false___When_parameter_other_is_derived_from_the_same_type_but_is_not_of_the_same_type_as_this_object()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals(_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_" + TypeNameToken + @"___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => scenario.ReferenceObject.Equals(_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_" + TypeNameToken + @"___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals(_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_parameter_other_is_null()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject.Equals((object)null);

                    // Assert
                    actual.AsTest().Must().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_parameter_other_is_not_of_the_same_type()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals1 = scenario.ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals((object)_)).ToList();
                    var actuals2 = scenario.ObjectsThatAreNotOfTheSameTypeAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals((object)_)).ToList();

                    // Assert
                    actuals1.AsTest().Must().Each().BeFalse(because: scenario.Id);
                    actuals2.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_Object___Should_return_true___When_parameter_other_is_same_object()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actual = scenario.ReferenceObject.Equals((object)scenario.ReferenceObject);

                    // Assert
                    actual.AsTest().Must().BeTrue(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_Object___Should_return_false___When_objects_being_compared_have_different_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => scenario.ReferenceObject.Equals((object)_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeFalse(because: scenario.Id);
                }
            }

            [Fact]
            public static void Equals_with_Object___Should_return_true___When_objects_being_compared_have_same_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var actuals = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => scenario.ReferenceObject.Equals((object)_)).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeTrue(because: scenario.Id);
                }
            }
        }";

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
            string result;

            if (modelType.DeclaresEqualsMethodDirectlyOrInDerivative || modelType.DeclaresGetHashCodeMethodDirectlyOrInDerivative)
            {
                result = EqualityTestFieldsForDeclaredTypeCodeTemplate
                    .Replace(TypeNameToken, modelType.TypeCompilableString);

                return result;
            }

            string codeTemplate;
            switch (modelType.HierarchyKind)
            {
                case HierarchyKind.AbstractBaseRoot:
                    var objectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = (modelType.ConcreteDerivativeTypes.Count() >= 2)
                        ? ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObjectCodeTemplate
                        : string.Empty;

                    codeTemplate = EqualityTestFieldsForAbstractBaseTypeCodeTemplate
                        .Replace(ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObjectToken, objectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject);

                    break;
                case HierarchyKind.None:
                case HierarchyKind.ConcreteInherited:
                    codeTemplate = EqualityTestFieldsForConcreteTypeCodeTemplate;
                    break;
                default:
                    throw new NotSupportedException("This kind is not supported: " + modelType.HierarchyKind);
            }

            var unequalSet = new List<string>();

            result = codeTemplate
                .Replace(TypeNameToken, modelType.TypeCompilableString);

            if (modelType.HierarchyKind == HierarchyKind.AbstractBaseRoot)
            {
                foreach (var property in modelType.PropertiesOfConcern)
                {
                    var code = UnequalObjectTokenForAbstractBaseTypeCodeTemplate
                        .Replace(PropertyNameToken, property.Name)
                        .Replace(PropertyTypeNameToken, property.PropertyType.ToStringCompilable());

                    unequalSet.Add(code);
                }
            }
            else
            {
                foreach (var property in modelType.PropertiesOfConcern)
                {
                    var propertiesCode = modelType.PropertiesOfConcern.Select(_ =>
                    {
                        var referenceObject = "ReferenceObjectForEquatableTestScenarios." + _.Name;

                        var memberCode = _.Name != property.Name
                            ? referenceObject
                            : _.PropertyType.GenerateDummyConstructionCodeForType(referenceObject);

                        return new MemberCode(_.Name, memberCode);
                    }).ToList();

                    var code = modelType.GenerateModelInstantiation(propertiesCode, parameterPaddingLength: 32);

                    unequalSet.Add(code);
                }

                var newEquatablePropertiesCode = modelType.PropertiesOfConcern.Select(_ => new MemberCode(_.Name, "ReferenceObjectForEquatableTestScenarios." + _.Name)).ToList();

                var newObjectFromEquatableToken = modelType.GenerateModelInstantiation(newEquatablePropertiesCode, parameterPaddingLength: 32);

                result = result.Replace(NewObjectForEquatableToken, newObjectFromEquatableToken);
            }

            var unequalObjectsCode = unequalSet.Any()
                ? Environment.NewLine + "                        " + string.Join("," + Environment.NewLine + "                        ", unequalSet) + ","
                : string.Empty;

            result = result.Replace(UnequalObjectsToken, unequalObjectsCode);

            return result;
        }

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
            string result;

            if (modelType.HierarchyKind == HierarchyKind.AbstractBaseRoot)
            {
                if (modelType.DeclaresEqualsMethod)
                {
                    throw new NotSupportedException(Invariant($"Abstract type {modelType.TypeReadableString} cannot declare an Equals method."));
                }

                result = EqualityMethodsForAbstractBaseTypeCodeTemplate.Replace(TypeNameToken, modelType.TypeCompilableString);
            }
            else
            {
                var equalityLines = modelType.PropertiesOfConcern.Select(_ => _.GenerateEqualityLogicCodeForProperty()).ToList();

                var equalityToken = modelType.PropertiesOfConcern.Any()
                    ? string.Join(Environment.NewLine + "                      && ", equalityLines)
                    : "true";

                var equalsMethodCode = modelType.DeclaresEqualsMethod
                    ? string.Empty
                    : EqualsMethodForConcreteTypeCodeTemplate;

                result = EqualityMethodsForConcreteTypeCodeTemplate
                    .Replace(EqualsMethodToken, equalsMethodCode)
                    .Replace(TypeNameToken, modelType.TypeCompilableString)
                    .Replace(EqualityToken, equalityToken);
            }

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
            var result = EqualityTestMethodsCodeTemplate
                .Replace(TypeNameToken, modelType.TypeCompilableString);

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
    }
}