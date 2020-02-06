// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test.Test
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    using FakeItEasy;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Math.Recipes;
    using OBeautifulCode.Representation.System;
    using OBeautifulCode.Serialization;
    using OBeautifulCode.Serialization.Bson;
    using OBeautifulCode.Serialization.Json;
    using OBeautifulCode.Type;

    using Xunit;

    using static System.FormattableString;

    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.0.0")]
    public static partial class MyModelComparingPublicSettersParentTest
    {
        private static readonly ComparableTestScenarios<MyModelComparingPublicSettersParent> ComparableTestScenarios = new ComparableTestScenarios<MyModelComparingPublicSettersParent>();

        public static class Structural
        {
            [Fact]
            public static void MyModelComparingPublicSettersParent___Should_implement_IComparableForRelativeSortOrder_of_MyModelComparingPublicSettersParent___When_reflecting()
            {
                // Arrange
                var type = typeof(MyModelComparingPublicSettersParent);

                var expectedModelMethods = typeof(IComparableForRelativeSortOrder<MyModelComparingPublicSettersParent>)
                                          .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                          .ToList();

                var expectedModelMethodHashes = expectedModelMethods.Select(_ => _.GetSignatureHash());

                // Act
                var actualInterfaces = type.GetInterfaces();
                var actualModelMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(_ => _.DeclaringType == type).ToList();
                var actualModelMethodHashes = actualModelMethods.Select(_ => _.GetSignatureHash());

                // Assert
                actualInterfaces.AsTest().Must().ContainElement(typeof(IComparableForRelativeSortOrder<MyModelComparingPublicSettersParent>));
                expectedModelMethodHashes.Except(actualModelMethodHashes).AsTest().Must().BeEmptyEnumerable();
            }
        }

    
    }
}