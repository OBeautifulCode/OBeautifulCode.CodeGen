// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelPublicSetters.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest.GenerateModel()
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    public partial class MyModelPublicSetters : IModelViaCodeGen
    {

        public DateTime DateTimeProperty { get; set; }

        public DateTime? NullableDateTimeProperty { get; set; }

        public DateTime[] ArrayOfDateTimeProperty { get; set; }

        public DateTime?[] ArrayOfNullableDateTimeProperty { get; set; }

        public IReadOnlyCollection<DateTime> ReadOnlyCollectionOfDateTimeProperty { get; set; }

        public IReadOnlyCollection<DateTime?> ReadOnlyCollectionOfNullableDateTimeProperty { get; set; }

        public IReadOnlyList<DateTime> ReadOnlyListOfDateTimeProperty { get; set; }

        public IReadOnlyList<DateTime?> ReadOnlyListOfNullableDateTimeProperty { get; set; }

        public IReadOnlyDictionary<DateTime, DateTime> ReadOnlyDictionaryOfDateTimeProperty { get; set; }

        public IReadOnlyDictionary<DateTime?, DateTime?> ReadOnlyDictionaryOfNullableDateTimeProperty { get; set; }

        public IReadOnlyDictionary<string, IReadOnlyDictionary<DateTime, IReadOnlyDictionary<ModelClass, IReadOnlyList<string>>>> ReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty { get; set; }

        public IReadOnlyList<IReadOnlyDictionary<DateTime, IReadOnlyList<string>>> ReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty { get; set; }
    }
}