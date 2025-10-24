// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetValidationFailuresTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System.Collections.Generic;
    using System.Linq;
    using FakeItEasy;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Enum.Recipes;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;
    using Xunit;
    using static System.FormattableString;

    public static class GetValidationFailuresTest
    {
        public static readonly ValidatableObject InvalidSystemUnderTest = new ValidatableObject
        {
            ValidatableNumber1 = new ValidatableNumeric
            {
                NumericValue = -1,
            },
            ValidatableText1 = new ValidatableString
            {
                StringValue = "bad string 1",
            },
            ValidatableNumbers1 = new[]
            {
                new ValidatableNumeric
                {
                    NumericValue = -2,
                },
                new ValidatableNumeric
                {
                    NumericValue = -3,
                },
            },
            ValidatableTexts1 = new[]
            {
                new ValidatableString
                {
                    StringValue = "bad string 2",
                },
                new ValidatableString
                {
                    StringValue = "bad string 3",
                },
            },
            ValidatableTexts2 = new ValidatableString[0],
        };

        [Fact]
        public static void GetValidationFailures___Should_return_empty_list___When_object_is_valid_regardless_of_options()
        {
            // Arrange
            var systemUnderTest = new ValidatableObject
            {
                ValidatableNumber1 = new ValidatableNumeric
                {
                    NumericValue = 5,
                },
                ValidatableText1 = new ValidatableString
                {
                    StringValue = ValidatableString.GoodStringValue,
                },
                ValidatableNumber2 = new ValidatableNumeric
                {
                    NumericValue = 5,
                },
                ValidatableText2 = new ValidatableString
                {
                    StringValue = ValidatableString.GoodStringValue,
                },
                ValidatableNumbers1 = new[]
                {
                    new ValidatableNumeric
                    {
                        NumericValue = 10,
                    },
                    new ValidatableNumeric
                    {
                        NumericValue = 20,
                    },
                },
                ValidatableTexts1 = new[]
                {
                    new ValidatableString
                    {
                        StringValue = ValidatableString.GoodStringValue,
                    },
                    new ValidatableString
                    {
                        StringValue = ValidatableString.GoodStringValue,
                    },
                },
                ValidatableNumbers2 = new[]
                {
                    new ValidatableNumeric
                    {
                        NumericValue = 10,
                    },
                    new ValidatableNumeric
                    {
                        NumericValue = 20,
                    },
                },
                ValidatableTexts2 = new[]
                {
                    new ValidatableString
                    {
                        StringValue = ValidatableString.GoodStringValue,
                    },
                    new ValidatableString
                    {
                        StringValue = ValidatableString.GoodStringValue,
                    },
                },
            };

            // Act
            var actuals = new List<IReadOnlyList<ValidationFailure>>();

            foreach (var validateUntil in EnumExtensions.GetAllPossibleEnumValues<ValidateUntil>())
            {
                foreach (var validationOrder in EnumExtensions.GetAllPossibleEnumValues<ValidationOrder>())
                {
                    foreach (var validationScope in EnumExtensions.GetAllPossibleEnumValues<ValidationScope>())
                    {
                        var actual = systemUnderTest.GetValidationFailures(
                            new ValidationOptions
                            {
                                ValidateUntil = validateUntil,
                                ValidationOrder = validationOrder,
                                ValidationScope = validationScope,
                            });

                        actuals.Add(actual);
                    }
                }
            }

            // Assert
            actuals.AsTest().Must().Each().BeEmptyEnumerable();
        }

        [Fact]
        public static void GetValidationFailures___Should_return_expected_failures___When_ValidateUntil_is_FullyTraversed_ValidationOrder_is_SelfThenProperties_and_ValidationScope_is_SelfAndProperties()
        {
            // Arrange
            var systemUnderTest = InvalidSystemUnderTest;

            var expected = new[]
            {
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumber2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumber2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableText2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableText2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumbers2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumbers2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableTexts2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableTexts2)}') is an empty enumerable.")),
                new ValidationFailure(typeof(ValidatableNumeric).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableNumber1)}.{nameof(ValidatableNumeric.NumericValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableNumeric.NumericValue)}') is not greater than the comparison value using Comparer<T>.Default, where T: int.  Provided value is '-1'.  Specified 'comparisonValue' is '0'.")),
                new ValidationFailure(typeof(ValidatableString).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableText1)}.{nameof(ValidatableString.StringValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableString.StringValue)}') is not equal to the comparison value using EqualityExtensions.IsEqualTo<T>, where T: string.  Provided value is 'bad string 1'.  Specified 'comparisonValue' is 'good-string-value'.")),
                new ValidationFailure(typeof(ValidatableNumeric).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableNumbers1)}[0].{nameof(ValidatableNumeric.NumericValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableNumeric.NumericValue)}') is not greater than the comparison value using Comparer<T>.Default, where T: int.  Provided value is '-2'.  Specified 'comparisonValue' is '0'.")),
                new ValidationFailure(typeof(ValidatableNumeric).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableNumbers1)}[1].{nameof(ValidatableNumeric.NumericValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableNumeric.NumericValue)}') is not greater than the comparison value using Comparer<T>.Default, where T: int.  Provided value is '-3'.  Specified 'comparisonValue' is '0'.")),
                new ValidationFailure(typeof(ValidatableString).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableTexts1)}[0].{nameof(ValidatableString.StringValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableString.StringValue)}') is not equal to the comparison value using EqualityExtensions.IsEqualTo<T>, where T: string.  Provided value is 'bad string 2'.  Specified 'comparisonValue' is 'good-string-value'.")),
                new ValidationFailure(typeof(ValidatableString).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableTexts1)}[1].{nameof(ValidatableString.StringValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableString.StringValue)}') is not equal to the comparison value using EqualityExtensions.IsEqualTo<T>, where T: string.  Provided value is 'bad string 3'.  Specified 'comparisonValue' is 'good-string-value'.")),
            };

            // Act
            var actual = systemUnderTest.GetValidationFailures(
                new ValidationOptions
                {
                    ValidateUntil = ValidateUntil.FullyTraversed,
                    ValidationOrder = ValidationOrder.SelfThenProperties,
                    ValidationScope = ValidationScope.SelfAndProperties,
                });

            // Assert
            actual.AsTest().Must().BeSequenceEqualTo(expected);
        }

        [Fact]
        public static void GetValidationFailures___Should_return_expected_failures___When_ValidateUntil_is_FullyTraversed_ValidationOrder_is_SelfThenProperties_and_ValidationScope_is_SelfOnly()
        {
            // Arrange
            var systemUnderTest = InvalidSystemUnderTest;

            var expected = new[]
            {
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumber2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumber2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableText2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableText2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumbers2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumbers2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableTexts2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableTexts2)}') is an empty enumerable.")),
            };

            // Act
            var actual = systemUnderTest.GetValidationFailures(
                new ValidationOptions
                {
                    ValidateUntil = ValidateUntil.FullyTraversed,
                    ValidationOrder = ValidationOrder.SelfThenProperties,
                    ValidationScope = ValidationScope.SelfOnly,
                });

            // Assert
            actual.AsTest().Must().BeSequenceEqualTo(expected);
        }

        [Fact]
        public static void GetValidationFailures___Should_return_expected_failures___When_ValidateUntil_is_FullyTraversed_ValidationOrder_is_PropertiesThenSelf_and_ValidationScope_is_SelfAndProperties()
        {
            // Arrange
            var systemUnderTest = InvalidSystemUnderTest;

            var expected = new[]
            {
                new ValidationFailure(typeof(ValidatableNumeric).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableNumber1)}.{nameof(ValidatableNumeric.NumericValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableNumeric.NumericValue)}') is not greater than the comparison value using Comparer<T>.Default, where T: int.  Provided value is '-1'.  Specified 'comparisonValue' is '0'.")),
                new ValidationFailure(typeof(ValidatableString).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableText1)}.{nameof(ValidatableString.StringValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableString.StringValue)}') is not equal to the comparison value using EqualityExtensions.IsEqualTo<T>, where T: string.  Provided value is 'bad string 1'.  Specified 'comparisonValue' is 'good-string-value'.")),
                new ValidationFailure(typeof(ValidatableNumeric).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableNumbers1)}[0].{nameof(ValidatableNumeric.NumericValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableNumeric.NumericValue)}') is not greater than the comparison value using Comparer<T>.Default, where T: int.  Provided value is '-2'.  Specified 'comparisonValue' is '0'.")),
                new ValidationFailure(typeof(ValidatableNumeric).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableNumbers1)}[1].{nameof(ValidatableNumeric.NumericValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableNumeric.NumericValue)}') is not greater than the comparison value using Comparer<T>.Default, where T: int.  Provided value is '-3'.  Specified 'comparisonValue' is '0'.")),
                new ValidationFailure(typeof(ValidatableString).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableTexts1)}[0].{nameof(ValidatableString.StringValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableString.StringValue)}') is not equal to the comparison value using EqualityExtensions.IsEqualTo<T>, where T: string.  Provided value is 'bad string 2'.  Specified 'comparisonValue' is 'good-string-value'.")),
                new ValidationFailure(typeof(ValidatableString).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableTexts1)}[1].{nameof(ValidatableString.StringValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableString.StringValue)}') is not equal to the comparison value using EqualityExtensions.IsEqualTo<T>, where T: string.  Provided value is 'bad string 3'.  Specified 'comparisonValue' is 'good-string-value'.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumber2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumber2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableText2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableText2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumbers2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumbers2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableTexts2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableTexts2)}') is an empty enumerable.")),
            };

            // Act
            var actual = systemUnderTest.GetValidationFailures(
                new ValidationOptions
                {
                    ValidateUntil = ValidateUntil.FullyTraversed,
                    ValidationOrder = ValidationOrder.PropertiesThenSelf,
                    ValidationScope = ValidationScope.SelfAndProperties,
                });

            // Assert
            actual.AsTest().Must().BeSequenceEqualTo(expected);
        }

        [Fact]
        public static void GetValidationFailures___Should_return_expected_failures___When_ValidateUntil_is_FullyTraversed_ValidationOrder_is_PropertiesThenSelf_and_ValidationScope_is_SelfOnly()
        {
            // Arrange
            var systemUnderTest = InvalidSystemUnderTest;

            var expected = new[]
            {
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumber2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumber2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableText2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableText2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumbers2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumbers2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableTexts2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableTexts2)}') is an empty enumerable.")),
            };

            // Act
            var actual = systemUnderTest.GetValidationFailures(
                new ValidationOptions
                {
                    ValidateUntil = ValidateUntil.FullyTraversed,
                    ValidationOrder = ValidationOrder.PropertiesThenSelf,
                    ValidationScope = ValidationScope.SelfOnly,
                });

            // Assert
            actual.AsTest().Must().BeSequenceEqualTo(expected);
        }

        [Fact]
        public static void GetValidationFailures___Should_return_expected_failures___When_ValidateUntil_is_FirstInvalidObject_ValidationOrder_is_SelfThenProperties_and_ValidationScope_is_SelfAndProperties()
        {
            // Arrange
            var systemUnderTest = InvalidSystemUnderTest;

            var expected = new[]
            {
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumber2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumber2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableText2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableText2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumbers2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumbers2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableTexts2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableTexts2)}') is an empty enumerable.")),
            };

            // Act
            var actual = systemUnderTest.GetValidationFailures(
                new ValidationOptions
                {
                    ValidateUntil = ValidateUntil.FirstInvalidObject,
                    ValidationOrder = ValidationOrder.SelfThenProperties,
                    ValidationScope = ValidationScope.SelfAndProperties,
                });

            // Assert
            actual.AsTest().Must().BeSequenceEqualTo(expected);
        }

        [Fact]
        public static void GetValidationFailures___Should_return_expected_failures___When_ValidateUntil_is_FirstInvalidObject_ValidationOrder_is_SelfThenProperties_and_ValidationScope_is_SelfOnly()
        {
            // Arrange
            var systemUnderTest = InvalidSystemUnderTest;

            var expected = new[]
            {
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumber2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumber2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableText2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableText2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumbers2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumbers2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableTexts2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableTexts2)}') is an empty enumerable.")),
            };

            // Act
            var actual = systemUnderTest.GetValidationFailures(
                new ValidationOptions
                {
                    ValidateUntil = ValidateUntil.FirstInvalidObject,
                    ValidationOrder = ValidationOrder.SelfThenProperties,
                    ValidationScope = ValidationScope.SelfOnly,
                });

            // Assert
            actual.AsTest().Must().BeSequenceEqualTo(expected);
        }

        [Fact]
        public static void GetValidationFailures___Should_return_expected_failures___When_ValidateUntil_is_FirstInvalidObject_ValidationOrder_is_PropertiesThenSelf_and_ValidationScope_is_SelfAndProperties()
        {
            // Arrange
            var systemUnderTest = InvalidSystemUnderTest;

            var expected = new[]
            {
                new ValidationFailure(typeof(ValidatableNumeric).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableNumber1)}.{nameof(ValidatableNumeric.NumericValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableNumeric.NumericValue)}') is not greater than the comparison value using Comparer<T>.Default, where T: int.  Provided value is '-1'.  Specified 'comparisonValue' is '0'.")),
            };

            // Act
            var actual = systemUnderTest.GetValidationFailures(
                new ValidationOptions
                {
                    ValidateUntil = ValidateUntil.FirstInvalidObject,
                    ValidationOrder = ValidationOrder.PropertiesThenSelf,
                    ValidationScope = ValidationScope.SelfAndProperties,
                });

            // Assert
            actual.AsTest().Must().BeSequenceEqualTo(expected);
        }

        [Fact]
        public static void GetValidationFailures___Should_return_expected_failures___When_ValidateUntil_is_FirstInvalidObject_ValidationOrder_is_PropertiesThenSelf_and_ValidationScope_is_SelfOnly()
        {
            // Arrange
            var systemUnderTest = InvalidSystemUnderTest;

            var expected = new[]
            {
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumber2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumber2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableText2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableText2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableNumbers2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableNumbers2)}') is null.")),
                new ValidationFailure(typeof(ValidatableObject).ToStringReadable(), nameof(ValidatableObject.ValidatableTexts2), Invariant($"Provided value (name: '{nameof(ValidatableObject.ValidatableTexts2)}') is an empty enumerable.")),
            };

            // Act
            var actual = systemUnderTest.GetValidationFailures(
                new ValidationOptions
                {
                    ValidateUntil = ValidateUntil.FirstInvalidObject,
                    ValidationOrder = ValidationOrder.PropertiesThenSelf,
                    ValidationScope = ValidationScope.SelfOnly,
                });

            // Assert
            actual.AsTest().Must().BeSequenceEqualTo(expected);
        }

        [Fact]
        public static void GetValidationFailures___Should_stop_on_first_invalid_object_in_collection___When_ValidateUntil_is_FirstInvalidObject_ValidationOrder_is_PropertiesThenSelf_and_ValidationScope_is_SelfAndProperties()
        {
            // Arrange
            var systemUnderTest = new ValidatableObject
            {
                ValidatableNumber1 = new ValidatableNumeric
                {
                    NumericValue = 5,
                },
                ValidatableText1 = new ValidatableString
                {
                    StringValue = ValidatableString.GoodStringValue,
                },
                ValidatableNumber2 = new ValidatableNumeric
                {
                    NumericValue = 5,
                },
                ValidatableText2 = new ValidatableString
                {
                    StringValue = ValidatableString.GoodStringValue,
                },
                ValidatableNumbers1 = new[]
                {
                    new ValidatableNumeric
                    {
                        NumericValue = 10,
                    },
                    new ValidatableNumeric
                    {
                        NumericValue = 20,
                    },
                },
                ValidatableTexts1 = new[]
                {
                    new ValidatableString
                    {
                        StringValue = ValidatableString.GoodStringValue,
                    },
                    new ValidatableString
                    {
                        StringValue = "bad string 1",
                    },
                },
                ValidatableNumbers2 = new[]
                {
                    new ValidatableNumeric
                    {
                        NumericValue = -10,
                    },
                    new ValidatableNumeric
                    {
                        NumericValue = -20,
                    },
                },
                ValidatableTexts2 = new[]
                {
                    new ValidatableString
                    {
                        StringValue = "bad string 2",
                    },
                    new ValidatableString
                    {
                        StringValue = "bad string 3",
                    },
                },
            };

            var expected = new[]
            {
                new ValidationFailure(typeof(ValidatableString).ToStringReadable(), Invariant($"{nameof(ValidatableObject.ValidatableTexts1)}[1].{nameof(ValidatableString.StringValue)}"), Invariant($"Provided value (name: '{nameof(ValidatableString.StringValue)}') is not equal to the comparison value using EqualityExtensions.IsEqualTo<T>, where T: string.  Provided value is 'bad string 1'.  Specified 'comparisonValue' is 'good-string-value'.")),
            };

            // Act
            var actual = systemUnderTest.GetValidationFailures(
                new ValidationOptions
                {
                    ValidateUntil = ValidateUntil.FirstInvalidObject,
                    ValidationOrder = ValidationOrder.PropertiesThenSelf,
                    ValidationScope = ValidationScope.SelfAndProperties,
                });

            // Assert
            actual.AsTest().Must().BeSequenceEqualTo(expected);
        }

        [Fact]
        public static void GetValidationFailures___Should_format_multi_property_failure_into_ValidationFailure_Path____When_a_single_SelfValidationFailure_has_multiple_properties()
        {
            // Arrange
            var systemUnderTest = new ValidatableComboProperties();

            var expected = new ValidationFailure(
                typeof(ValidatableComboProperties).ToStringReadable(),
                Invariant($"({nameof(ValidatableComboProperties.StringValue1)}|{nameof(ValidatableComboProperties.StringValue2)})"),
                ValidatableComboProperties.FailureMessage);

            // Act
            var actual = systemUnderTest.GetValidationFailures(A.Dummy<ValidationOptions>());

            // Assert
            actual.Single().AsTest().Must().BeEqualTo(expected);
        }
    }
}
