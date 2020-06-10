// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Settings.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Enum.Recipes;

    public static class Settings
    {
        public const string ModelBaseName = "MyModel";

        public const string TestNameSuffix = "Test";

        public static readonly string SourceRoot = "d:\\src\\OBeautifulCode\\OBeautifulCode.CodeGen\\OBeautifulCode.CodeGen.ModelObject.Test\\";

        // ReSharper disable once InconsistentNaming
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyList<string> ChildIdentifiers = new[] { "1", "2" };

        public static readonly string ModelsPath = SourceRoot + "Models\\";

        public static readonly string SpecifiedModelsPath = ModelsPath + "SpecifiedModels\\";

        public static readonly string GeneratedModelsPath = ModelsPath + "GeneratedModels\\";

        public static readonly string TestsPath = SourceRoot + "ModelTests\\";

        public static readonly string SpecifiedModelsTestPath = TestsPath + "SpecifiedModels\\";

        public static readonly string GeneratedModelsTestsPath = TestsPath + "GeneratedModels\\";

        public static readonly string DummyFactoryFilePath = SourceRoot + "DummyFactory.cs";

        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyList<Type> TypesToWrap = new[]
        {
            typeof(bool),
            typeof(int),
            typeof(string),
            typeof(Guid),
            typeof(DateTime),
            typeof(ModelEnum),
            typeof(ModelFlagsEnum),
            typeof(ModelClass),

            // OBC.Serialization doesn't support structs
            // typeof(ModelStruct),
        };

        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyList<Type> ComparabilityTypes = new[]
        {
            typeof(int),
        };

        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyList<TypeWrapperKind> TypeWrapperKinds = EnumExtensions.GetDefinedEnumValues<TypeWrapperKind>().Where(_ => _ != TypeWrapperKind.NotApplicable).ToList();

        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyList<Type> AdditionalTypes = new[]
        {
            typeof(ICollection<string>), // elements must be comparable for generated hashing unequal test to NOT be skipped
            typeof(Collection<ICollection<string>>),
            typeof(IList<ICollection<string>>),
            typeof(List<ICollection<string>>),
            typeof(ReadOnlyCollection<ICollection<string>>),
            typeof(IDictionary<string, IReadOnlyList<DateTime>>),
            typeof(Dictionary<string, IReadOnlyList<DateTime>>),
            typeof(ReadOnlyDictionary<string, IReadOnlyList<DateTime>>),
            typeof(ConcurrentDictionary<string, IReadOnlyList<DateTime>>),
            typeof(IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>>),
            typeof(IReadOnlyDictionary<string, IReadOnlyDictionary<string, ReadOnlyDictionary<ModelClass, IReadOnlyList<DateTime>>>>),
        };

        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyList<Type> BlacklistTypes = new[]
        {
            typeof(IReadOnlyDictionary<DateTime, DateTime>),
            typeof(IReadOnlyDictionary<DateTime?, DateTime?>),
        };

        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyDictionary<SpecifiedModelKind, IReadOnlyCollection<string>> SpecifiedModelKindToModelNameSuffixMap = new Dictionary<SpecifiedModelKind, IReadOnlyCollection<string>>
        {
            {
                SpecifiedModelKind.Empty,
                new[] { "EmptyParentEmptyChild", "EmptyParentNotEmptyChild", "EmptyParent", "Empty", "NotEmptyParentEmptyChild", "NotEmptyParent" }
            },
            {
                SpecifiedModelKind.Multilevel,
                new[] { "MultilevelParent", "MultilevelChild1", "MultilevelChild2", "MultilevelGrandchild1A", "MultilevelGrandchild1B", "MultilevelGrandchild2A", "MultilevelGrandchild2B" }
            },
            {
                SpecifiedModelKind.ExpressionBody,
                new[] { "ExpressionBody", "ExpressionBodyParent", "ExpressionBodyChild1", "ExpressionBodyChild2" }
            },
            {
                SpecifiedModelKind.MultipleConstructors,
                new[] { "MultipleConstructors", "MultipleConstructorsParent", "MultipleConstructorsChild1", "MultipleConstructorsChild2" }
            },
            {
                SpecifiedModelKind.ConstructorMissingProperty,
                new[] { "ConstructorMissingPropertyParent", "ConstructorMissingPropertyChild1", "ConstructorMissingPropertyChild2", "ConstructorMissingPropertyChild3" }
            },
        };
    }
}
