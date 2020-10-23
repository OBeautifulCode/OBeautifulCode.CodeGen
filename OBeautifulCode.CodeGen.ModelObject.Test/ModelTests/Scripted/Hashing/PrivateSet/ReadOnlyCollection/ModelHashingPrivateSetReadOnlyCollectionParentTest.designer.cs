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

    public static partial class ModelHashingPrivateSetReadOnlyCollectionParentTest
    {
        private static readonly ModelHashingPrivateSetReadOnlyCollectionParent ReferenceObjectForEquatableTestScenarios = A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>();

        private static readonly EquatableTestScenarios<ModelHashingPrivateSetReadOnlyCollectionParent> EquatableTestScenarios = new EquatableTestScenarios<ModelHashingPrivateSetReadOnlyCollectionParent>()
            .AddScenario(() =>
                new EquatableTestScenario<ModelHashingPrivateSetReadOnlyCollectionParent>
                {
                    Name = "Default Code Generated Scenario",
                    ReferenceObject = ReferenceObjectForEquatableTestScenarios,
                    ObjectsThatAreEqualToButNotTheSameAsReferenceObject = new ModelHashingPrivateSetReadOnlyCollectionParent[]
                    {
                        // ReferenceObjectForEquatableTestScenarios.DeepClone(),
                    },
                    ObjectsThatAreNotEqualToReferenceObject = new ModelHashingPrivateSetReadOnlyCollectionParent[]
                    {
                        // DeepCloneWith___() methods implemented in concrete derivates throw NotSupportedException
                        // when the derivative's constructor in-use (by code gen) does not have a parameter that
                        // corresponds with the property who's value is provided in the DeepCloneWith___() method.
                        // We do not know in advance if this will happen.  As such, the following objects are commented out.
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyCollectionInterfaceOfBoolProperty(A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>().Whose(_ => !_.ParentReadOnlyCollectionInterfaceOfBoolProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyCollectionInterfaceOfBoolProperty)).ParentReadOnlyCollectionInterfaceOfBoolProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyCollectionInterfaceOfIntProperty(A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>().Whose(_ => !_.ParentReadOnlyCollectionInterfaceOfIntProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyCollectionInterfaceOfIntProperty)).ParentReadOnlyCollectionInterfaceOfIntProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyCollectionInterfaceOfStringProperty(A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>().Whose(_ => !_.ParentReadOnlyCollectionInterfaceOfStringProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyCollectionInterfaceOfStringProperty)).ParentReadOnlyCollectionInterfaceOfStringProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyCollectionInterfaceOfGuidProperty(A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>().Whose(_ => !_.ParentReadOnlyCollectionInterfaceOfGuidProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyCollectionInterfaceOfGuidProperty)).ParentReadOnlyCollectionInterfaceOfGuidProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyCollectionInterfaceOfDateTimeProperty(A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>().Whose(_ => !_.ParentReadOnlyCollectionInterfaceOfDateTimeProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyCollectionInterfaceOfDateTimeProperty)).ParentReadOnlyCollectionInterfaceOfDateTimeProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyCollectionInterfaceOfCustomEnumProperty(A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>().Whose(_ => !_.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyCollectionInterfaceOfCustomEnumProperty)).ParentReadOnlyCollectionInterfaceOfCustomEnumProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty(A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>().Whose(_ => !_.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty)).ParentReadOnlyCollectionInterfaceOfCustomFlagsEnumProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyCollectionInterfaceOfCustomClassProperty(A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>().Whose(_ => !_.ParentReadOnlyCollectionInterfaceOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyCollectionInterfaceOfCustomClassProperty)).ParentReadOnlyCollectionInterfaceOfCustomClassProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty(A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>().Whose(_ => !_.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty)).ParentReadOnlyCollectionInterfaceOfCustomBaseClassProperty),
                        // ReferenceObjectForEquatableTestScenarios.DeepCloneWithParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty(A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>().Whose(_ => !_.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty.IsEqualTo(ReferenceObjectForEquatableTestScenarios.ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty)).ParentReadOnlyCollectionInterfaceOfCustomGenericClassOfCustomClassProperty),
                    },
                    ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject = new ModelHashingPrivateSetReadOnlyCollectionParent[]
                    {
                        A.Dummy<ModelHashingPrivateSetReadOnlyCollectionParent>().Whose(_ => _.GetType() != ReferenceObjectForEquatableTestScenarios.GetType()),
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
            public static void ModelHashingPrivateSetReadOnlyCollectionParent___Should_implement_IHashable___When_reflecting()
            {
                // Arrange
                var type = typeof(ModelHashingPrivateSetReadOnlyCollectionParent);

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
            public static void ModelHashingPrivateSetReadOnlyCollectionParent___Should_be_attributed_with_Serializable____When_reflecting()
            {
                // Arrange
                var type = typeof(ModelHashingPrivateSetReadOnlyCollectionParent);

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