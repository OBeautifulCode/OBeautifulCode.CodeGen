// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.0.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;

    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    using static System.FormattableString;

    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.0.0")]
    public partial class MyModelPrivateSettersParent : IModel<MyModelPrivateSettersParent>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersParent"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelPrivateSettersParent left, MyModelPrivateSettersParent right)
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
        /// Determines whether two objects of type <see cref="MyModelPrivateSettersParent"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(MyModelPrivateSettersParent left, MyModelPrivateSettersParent right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelPrivateSettersParent other) => this == other;

        /// <inheritdoc />
        public abstract override bool Equals(object obj);
    
        /// <inheritdoc />
        public abstract override int GetHashCode();
    
        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public abstract MyModelPrivateSettersParent DeepClone();

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentDateTimeProperty" />.
        /// </summary>
        /// <param name="parentDateTimeProperty">The new <see cref="ParentDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentDateTimeProperty" /> for <see cref="ParentDateTimeProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentDateTimeProperty(DateTime parentDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentNullableDateTimeProperty" />.
        /// </summary>
        /// <param name="parentNullableDateTimeProperty">The new <see cref="ParentNullableDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentNullableDateTimeProperty" /> for <see cref="ParentNullableDateTimeProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentNullableDateTimeProperty(DateTime? parentNullableDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentArrayOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentArrayOfDateTimeProperty">The new <see cref="ParentArrayOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentArrayOfDateTimeProperty" /> for <see cref="ParentArrayOfDateTimeProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentArrayOfDateTimeProperty(DateTime[] parentArrayOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentArrayOfNullableDateTimeProperty" />.
        /// </summary>
        /// <param name="parentArrayOfNullableDateTimeProperty">The new <see cref="ParentArrayOfNullableDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentArrayOfNullableDateTimeProperty" /> for <see cref="ParentArrayOfNullableDateTimeProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentArrayOfNullableDateTimeProperty(DateTime?[] parentArrayOfNullableDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyCollectionOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyCollectionOfDateTimeProperty">The new <see cref="ParentReadOnlyCollectionOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentReadOnlyCollectionOfDateTimeProperty" /> for <see cref="ParentReadOnlyCollectionOfDateTimeProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentReadOnlyCollectionOfDateTimeProperty(IReadOnlyCollection<DateTime> parentReadOnlyCollectionOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyCollectionOfNullableDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyCollectionOfNullableDateTimeProperty">The new <see cref="ParentReadOnlyCollectionOfNullableDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentReadOnlyCollectionOfNullableDateTimeProperty" /> for <see cref="ParentReadOnlyCollectionOfNullableDateTimeProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentReadOnlyCollectionOfNullableDateTimeProperty(IReadOnlyCollection<DateTime?> parentReadOnlyCollectionOfNullableDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyListOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyListOfDateTimeProperty">The new <see cref="ParentReadOnlyListOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentReadOnlyListOfDateTimeProperty" /> for <see cref="ParentReadOnlyListOfDateTimeProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentReadOnlyListOfDateTimeProperty(IReadOnlyList<DateTime> parentReadOnlyListOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyListOfNullableDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyListOfNullableDateTimeProperty">The new <see cref="ParentReadOnlyListOfNullableDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentReadOnlyListOfNullableDateTimeProperty" /> for <see cref="ParentReadOnlyListOfNullableDateTimeProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentReadOnlyListOfNullableDateTimeProperty(IReadOnlyList<DateTime?> parentReadOnlyListOfNullableDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryOfDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryOfDateTimeProperty">The new <see cref="ParentReadOnlyDictionaryOfDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentReadOnlyDictionaryOfDateTimeProperty" /> for <see cref="ParentReadOnlyDictionaryOfDateTimeProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentReadOnlyDictionaryOfDateTimeProperty(IReadOnlyDictionary<DateTime, DateTime> parentReadOnlyDictionaryOfDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryOfNullableDateTimeProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryOfNullableDateTimeProperty">The new <see cref="ParentReadOnlyDictionaryOfNullableDateTimeProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentReadOnlyDictionaryOfNullableDateTimeProperty" /> for <see cref="ParentReadOnlyDictionaryOfNullableDateTimeProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentReadOnlyDictionaryOfNullableDateTimeProperty(IReadOnlyDictionary<DateTime?, DateTime?> parentReadOnlyDictionaryOfNullableDateTimeProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty">The new <see cref="ParentReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty" /> for <see cref="ParentReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty(IReadOnlyDictionary<string, IReadOnlyDictionary<DateTime, IReadOnlyDictionary<ModelClass, IReadOnlyList<string>>>> parentReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyDictionaryOfReadOnlyListOfStringProperty);

        /// <summary>
        /// Deep clones this object with a new <see cref="ParentReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty" />.
        /// </summary>
        /// <param name="parentReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty">The new <see cref="ParentReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelPrivateSettersParent" /> using the specified <paramref name="parentReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty" /> for <see cref="ParentReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty" /> and a deep clone of every other property.</returns>
        public abstract MyModelPrivateSettersParent DeepCloneWithParentReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty(IReadOnlyList<IReadOnlyDictionary<DateTime, IReadOnlyList<string>>> parentReadOnlyListOfReadOnlyDictionaryOfReadOnlyListOfStringProperty);
    
        /// <inheritdoc />
        public abstract override string ToString();
    }
}