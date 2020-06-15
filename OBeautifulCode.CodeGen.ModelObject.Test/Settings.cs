// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Settings.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;

    using OBeautifulCode.CodeGen.ModelObject.Test.Internal;
    using OBeautifulCode.Enum.Recipes;

    public static class Settings
    {
        public const string ModelBaseName = "Model";

        public const string TestNameSuffix = "Test";

        public const string Comment = "////";

        public const string CommentOutFileExtension = ".commented-out";

        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly Encoding Encoding = Encoding.UTF8;

        public static readonly string SourceRoot = "d:\\src\\OBeautifulCode\\OBeautifulCode.CodeGen\\OBeautifulCode.CodeGen.ModelObject.Test\\";

        // ReSharper disable once InconsistentNaming
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyList<string> ChildIdentifiers = new[] { "1", "2" };

        public static readonly string ModelsPath = SourceRoot + "Models\\";

        public static readonly string SpecifiedModelsPath = ModelsPath + "Specified\\";

        public static readonly string ScriptedModelsPath = ModelsPath + "Scripted\\";

        public static readonly string TestsPath = SourceRoot + "ModelTests\\";

        public static readonly string SpecifiedModelsTestPath = TestsPath + "Specified\\";

        public static readonly string ScriptedModelsTestsPath = TestsPath + "Scripted\\";

        public static readonly string DummyFactoryFilePath = SourceRoot + "CodeGenDummyFactory.designer.cs";

        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification = ObcSuppressBecause.CA2104_DoNotDeclareReadOnlyMutableReferenceTypes_TypeIsImmutable)]
        public static readonly IReadOnlyList<Type> TypesToWrap = new[]
        {
            typeof(bool),
            typeof(int),
            typeof(string),
            typeof(Guid),
            typeof(DateTime),
            typeof(CustomEnum),
            typeof(CustomFlagsEnum),
            typeof(CustomClass),
            typeof(CustomBaseClass),

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
            typeof(IList<string>),
            typeof(IReadOnlyCollection<ICollection<string>>),
            typeof(ICollection<IReadOnlyList<string>>),
            typeof(IList<ICollection<string>>),
            typeof(IReadOnlyList<IList<string>>),
            typeof(IDictionary<string, IReadOnlyList<DateTime>>),
            typeof(IReadOnlyDictionary<string, ICollection<DateTime>>),
            typeof(IReadOnlyList<IReadOnlyDictionary<string, IReadOnlyList<DateTime>>>),
            typeof(IReadOnlyDictionary<string, IReadOnlyDictionary<string, IDictionary<CustomClass, IReadOnlyList<DateTime>>>>),
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
