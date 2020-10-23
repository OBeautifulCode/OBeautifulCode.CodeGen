﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;
    using global::System.Reflection;

    using global::FakeItEasy;

    using global::OBeautifulCode.Assertion.Recipes;
    using global::OBeautifulCode.AutoFakeItEasy;
    using global::OBeautifulCode.CodeGen.ModelObject.Recipes;
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Math.Recipes;
    using global::OBeautifulCode.Reflection.Recipes;
    using global::OBeautifulCode.Representation.System;
    using global::OBeautifulCode.Serialization;
    using global::OBeautifulCode.Serialization.Recipes;
    using global::OBeautifulCode.Type;

    using global::Xunit;

    using static global::System.FormattableString;

    public static partial class ModelHashingPublicSetMiscParentTest
    {
        private static readonly ModelHashingPublicSetMiscParent ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPublicSetMiscParent>();

        private static readonly EquatableTestScenarios<ModelHashingPublicSetMiscParent> EquatableTestScenarios = new EquatableTestScenarios<ModelHashingPublicSetMiscParent>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPublicSetMiscParent>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPublicSetMiscParent[]
                    {
                        // ReferenceObjectForEquatableTestScenarios.DeepClone(),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPublicSetMiscParent[]
                    {
                        // DeepCloneWith___() methods implemented in concrete derivates throw NotSupportedException
                        // when the derivative's constructor in-use (by code gen) does not have a parameter that
                        // corresponds with the property who's value is provided in the DeepCloneWith___() method.
                        // We do not know in advance if this will happen.  As such, the following objects are commented out.
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentCollectionInterfaceOfStringProperty(A.Dummy<ModelHashingPublicSetMiscParent>().Whose(_ => !_.ParentCollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentCollectionInterfaceOfStringProperty)).ParentCollectionInterfaceOfStringProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentListInterfaceOfStringProperty(A.Dummy<ModelHashingPublicSetMiscParent>().Whose(_ => !_.ParentListInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentListInterfaceOfStringProperty)).ParentListInterfaceOfStringProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty(A.Dummy<ModelHashingPublicSetMiscParent>().Whose(_ => !_.ParentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty)).ParentReadOnlyCollectionInterfaceOfCollectionInterfaceOfStringProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty(A.Dummy<ModelHashingPublicSetMiscParent>().Whose(_ => !_.ParentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty)).ParentCollectionInterfaceOfReadOnlyListInterfaceOfStringProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentListInterfaceOfCollectionInterfaceOfStringProperty(A.Dummy<ModelHashingPublicSetMiscParent>().Whose(_ => !_.ParentListInterfaceOfCollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentListInterfaceOfCollectionInterfaceOfStringProperty)).ParentListInterfaceOfCollectionInterfaceOfStringProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyListInterfaceOfListInterfaceOfStringProperty(A.Dummy<ModelHashingPublicSetMiscParent>().Whose(_ => !_.ParentReadOnlyListInterfaceOfListInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfListInterfaceOfStringProperty)).ParentReadOnlyListInterfaceOfListInterfaceOfStringProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty(A.Dummy<ModelHashingPublicSetMiscParent>().Whose(_ => !_.ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)).ParentDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty(A.Dummy<ModelHashingPublicSetMiscParent>().Whose(_ => !_.ParentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty)).ParentReadOnlyDictionaryInterfaceOfCollectionInterfaceOfDateTimeProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty(A.Dummy<ModelHashingPublicSetMiscParent>().Whose(_ => !_.ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)).ParentReadOnlyListInterfaceOfReadOnlyDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty(A.Dummy<ModelHashingPublicSetMiscParent>().Whose(_ => !_.ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty)).ParentReadOnlyDictionaryInterfaceOfReadOnlyDictionaryInterfaceOfDictionaryInterfaceOfReadOnlyListInterfaceOfDateTimeProperty),
                    },
                    ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new ModelHashingPublicSetMiscParent[]
                    {
                        A.Dummy<ModelHashingPublicSetMiscParent>().Whose(_ => _.GetType() != ReferenceObjectForEquatableTestScenarios.GetType()),
                    },
                    ObjectsThatAreNotOfTheSameTypeAsReferenceObject = new object[]
                    {
                        A.Dummy<object>(),
                        A.Dummy<string>(),
                        A.Dummy<int>(),
                        A.Dummy<int?>(),
                        A.Dummy<Guid>(),
                    },
                });

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
        public static class Structural
        {
            [Fact]
            [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
            [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
            [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
            [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
            [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
            [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
            public static void ModelHashingPublicSetMiscParent___Should_implement_IHashable___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelHashingPublicSetMiscParent);

                var expectedModelMethods = typeof(IHashable).GetInterfaceDeclaredAndImplementedMethods();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlagsFor.PublicDeclaredAndInheritedInstanceMembers).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IHashable));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
            }

            [Fact]
            [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
            [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
            [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
            [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
            [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
            [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
            public static void ModelHashingPublicSetMiscParent___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelHashingPublicSetMiscParent);

                // Act
                var actualAttributes = type.GetCustomAttributes(typeof(SerializableAttribute), false);

                // Assert
                actualAttributes.AsTest().Must().NotBeEmptyEnumerable();
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
        public static class Hashing
        {
            [Fact(Skip = "It's possible (and even probable after a few runs of this test) that two dummy, unequal models will have the same hash code.  The model being tested contains at least one property who's type (or a type nested within the generic type, or a property of the IModel type) is a dictionary with keys that are not comparable or an unordered collection with elements that are not comparable.  In these cases the hashing method cannot hash the elements and must resort to hashing the element count.  Two dummies could easily have the same element count for such a type.")]
            [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
            [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
            [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
            [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
            [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
            [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
            public static void GetHashCode___Should_not_be_equal_for_two_objects___When_objects_have_different_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var unexpected = scenario.ReferenceObject.GetHashCode();

                    var actuals = scenario.ObjectsThatAreNotEqualToReferenceObject.Select(_ => _.GetHashCode()).ToList();

                    // Assert
                    actuals.AsTest().Must().NotContainElement(unexpected, because: scenario.Id);
                }
            }

            [Fact]
            [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
            [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
            [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
            [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
            [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
            [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
            [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
            [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
            [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
            public static void GetHashCode___Should_be_equal_for_two_objects___When_objects_have_the_same_property_values()
            {
                var scenarios = EquatableTestScenarios.ValidateAndPrepareForTesting();

                foreach (var scenario in scenarios)
                {
                    // Arrange, Act
                    var expected = scenario.ReferenceObject.GetHashCode();

                    var actuals = scenario.ObjectsThatAreEqualToButNotTheSameAsReferenceObject.Select(_ => _.GetHashCode()).ToList();

                    // Assert
                    actuals.AsTest().Must().Each().BeEqualTo(expected, because: scenario.Id);
                }
            }
        }
    }
}