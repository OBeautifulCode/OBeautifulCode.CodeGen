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
    public partial class MyModelGettersOnlyChild2 : IModel<MyModelGettersOnlyChild2>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelGettersOnlyChild2"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(MyModelGettersOnlyChild2 left, MyModelGettersOnlyChild2 right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.ParentIntProperty.Equals(right.ParentIntProperty)
                      && left.ParentStringProperty.Equals(right.ParentStringProperty, StringComparison.Ordinal)
                      && left.ParentModelEquatableClassProperty.Equals(right.ParentModelEquatableClassProperty)
                      && left.ParentReadOnlyListOfIntProperty.IsEqualTo(right.ParentReadOnlyListOfIntProperty)
                      && left.ParentReadOnlyListOfStringProperty.IsEqualTo(right.ParentReadOnlyListOfStringProperty)
                      && left.ParentReadOnlyListOfModelEquatableClassProperty.IsEqualTo(right.ParentReadOnlyListOfModelEquatableClassProperty)
                      && left.Child2IntProperty.Equals(right.Child2IntProperty)
                      && left.Child2StringProperty.Equals(right.Child2StringProperty, StringComparison.Ordinal)
                      && left.Child2ModelEquatableClassProperty.Equals(right.Child2ModelEquatableClassProperty)
                      && left.Child2ReadOnlyListOfIntProperty.IsEqualTo(right.Child2ReadOnlyListOfIntProperty)
                      && left.Child2ReadOnlyListOfStringProperty.IsEqualTo(right.Child2ReadOnlyListOfStringProperty)
                      && left.Child2ReadOnlyListOfModelEquatableClassProperty.IsEqualTo(right.Child2ReadOnlyListOfModelEquatableClassProperty);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref="MyModelGettersOnlyChild2"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items not equal; otherwise false.</returns>
        public static bool operator !=(MyModelGettersOnlyChild2 left, MyModelGettersOnlyChild2 right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(MyModelGettersOnlyChild2 other) => this == other;

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as MyModelGettersOnlyChild2);
    
        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ParentIntProperty)
            .Hash(this.ParentStringProperty)
            .Hash(this.ParentModelEquatableClassProperty)
            .Hash(this.ParentReadOnlyListOfIntProperty)
            .Hash(this.ParentReadOnlyListOfStringProperty)
            .Hash(this.ParentReadOnlyListOfModelEquatableClassProperty)
            .Hash(this.Child2IntProperty)
            .Hash(this.Child2StringProperty)
            .Hash(this.Child2ModelEquatableClassProperty)
            .Hash(this.Child2ReadOnlyListOfIntProperty)
            .Hash(this.Child2ReadOnlyListOfStringProperty)
            .Hash(this.Child2ReadOnlyListOfModelEquatableClassProperty)
            .Value;
    
        /// <inheritdoc />
        public new object Clone() => this.DeepClone();

        /// <inheritdoc />
        public override MyModelGettersOnlyParent DeepClone()
        {
            var result = ((IDeepCloneable<MyModelGettersOnlyChild2>)this).DeepClone();

            return result;
        }

        /// <inheritdoc />
        MyModelGettersOnlyChild2 IDeepCloneable<MyModelGettersOnlyChild2>.DeepClone()
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.Child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());

            return result;
        }

        /// <inheritdoc />
        public override MyModelGettersOnlyParent DeepCloneWithParentIntProperty(int parentIntProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 parentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.Child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());
            
            return result;
        }

        /// <inheritdoc />
        public override MyModelGettersOnlyParent DeepCloneWithParentStringProperty(string parentStringProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 parentStringProperty,
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.Child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());
            
            return result;
        }

        /// <inheritdoc />
        public override MyModelGettersOnlyParent DeepCloneWithParentModelEquatableClassProperty(ModelEquatableClass parentModelEquatableClassProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 parentModelEquatableClassProperty,
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.Child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());
            
            return result;
        }

        /// <inheritdoc />
        public override MyModelGettersOnlyParent DeepCloneWithParentReadOnlyListOfIntProperty(IReadOnlyList<int> parentReadOnlyListOfIntProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 parentReadOnlyListOfIntProperty,
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.Child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());
            
            return result;
        }

        /// <inheritdoc />
        public override MyModelGettersOnlyParent DeepCloneWithParentReadOnlyListOfStringProperty(IReadOnlyList<string> parentReadOnlyListOfStringProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 parentReadOnlyListOfStringProperty,
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.Child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());
            
            return result;
        }

        /// <inheritdoc />
        public override MyModelGettersOnlyParent DeepCloneWithParentReadOnlyListOfModelEquatableClassProperty(IReadOnlyList<ModelEquatableClass> parentReadOnlyListOfModelEquatableClassProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 parentReadOnlyListOfModelEquatableClassProperty,
                                 this.Child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());
            
            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Child2IntProperty" />.
        /// </summary>
        /// <param name="child2IntProperty">The new <see cref="Child2IntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelGettersOnlyChild2" /> using the specified <paramref name="child2IntProperty" /> for <see cref="Child2IntProperty" /> and a deep clone of every other property.</returns>
        public MyModelGettersOnlyChild2 DeepCloneWithChild2IntProperty(int child2IntProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());
            
            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Child2StringProperty" />.
        /// </summary>
        /// <param name="child2StringProperty">The new <see cref="Child2StringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelGettersOnlyChild2" /> using the specified <paramref name="child2StringProperty" /> for <see cref="Child2StringProperty" /> and a deep clone of every other property.</returns>
        public MyModelGettersOnlyChild2 DeepCloneWithChild2StringProperty(string child2StringProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.Child2IntProperty,
                                 child2StringProperty,
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());
            
            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Child2ModelEquatableClassProperty" />.
        /// </summary>
        /// <param name="child2ModelEquatableClassProperty">The new <see cref="Child2ModelEquatableClassProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelGettersOnlyChild2" /> using the specified <paramref name="child2ModelEquatableClassProperty" /> for <see cref="Child2ModelEquatableClassProperty" /> and a deep clone of every other property.</returns>
        public MyModelGettersOnlyChild2 DeepCloneWithChild2ModelEquatableClassProperty(ModelEquatableClass child2ModelEquatableClassProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.Child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 child2ModelEquatableClassProperty,
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());
            
            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Child2ReadOnlyListOfIntProperty" />.
        /// </summary>
        /// <param name="child2ReadOnlyListOfIntProperty">The new <see cref="Child2ReadOnlyListOfIntProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelGettersOnlyChild2" /> using the specified <paramref name="child2ReadOnlyListOfIntProperty" /> for <see cref="Child2ReadOnlyListOfIntProperty" /> and a deep clone of every other property.</returns>
        public MyModelGettersOnlyChild2 DeepCloneWithChild2ReadOnlyListOfIntProperty(IReadOnlyList<int> child2ReadOnlyListOfIntProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.Child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 child2ReadOnlyListOfIntProperty,
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());
            
            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Child2ReadOnlyListOfStringProperty" />.
        /// </summary>
        /// <param name="child2ReadOnlyListOfStringProperty">The new <see cref="Child2ReadOnlyListOfStringProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelGettersOnlyChild2" /> using the specified <paramref name="child2ReadOnlyListOfStringProperty" /> for <see cref="Child2ReadOnlyListOfStringProperty" /> and a deep clone of every other property.</returns>
        public MyModelGettersOnlyChild2 DeepCloneWithChild2ReadOnlyListOfStringProperty(IReadOnlyList<string> child2ReadOnlyListOfStringProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.Child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 child2ReadOnlyListOfStringProperty,
                                 this.Child2ReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList());
            
            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Child2ReadOnlyListOfModelEquatableClassProperty" />.
        /// </summary>
        /// <param name="child2ReadOnlyListOfModelEquatableClassProperty">The new <see cref="Child2ReadOnlyListOfModelEquatableClassProperty" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="MyModelGettersOnlyChild2" /> using the specified <paramref name="child2ReadOnlyListOfModelEquatableClassProperty" /> for <see cref="Child2ReadOnlyListOfModelEquatableClassProperty" /> and a deep clone of every other property.</returns>
        public MyModelGettersOnlyChild2 DeepCloneWithChild2ReadOnlyListOfModelEquatableClassProperty(IReadOnlyList<ModelEquatableClass> child2ReadOnlyListOfModelEquatableClassProperty)
        {
            var result = new MyModelGettersOnlyChild2(
                                 this.ParentIntProperty,
                                 this.ParentStringProperty?.Clone().ToString(),
                                 this.ParentModelEquatableClassProperty?.DeepClone(),
                                 this.ParentReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.ParentReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 this.ParentReadOnlyListOfModelEquatableClassProperty?.Select(i => i?.DeepClone()).ToList(),
                                 this.Child2IntProperty,
                                 this.Child2StringProperty?.Clone().ToString(),
                                 this.Child2ModelEquatableClassProperty?.DeepClone(),
                                 this.Child2ReadOnlyListOfIntProperty?.Select(i => i).ToList(),
                                 this.Child2ReadOnlyListOfStringProperty?.Select(i => i?.Clone().ToString()).ToList(),
                                 child2ReadOnlyListOfModelEquatableClassProperty);
            
            return result;
        }
    
        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"{nameof(OBeautifulCode.CodeGen.ModelObject.Test)}.{nameof(MyModelGettersOnlyChild2)}: ParentIntProperty = {this.ParentIntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ParentStringProperty = {this.ParentStringProperty?.ToString() ?? "<null>"}, ParentModelEquatableClassProperty = {this.ParentModelEquatableClassProperty?.ToString() ?? "<null>"}, ParentReadOnlyListOfIntProperty = {this.ParentReadOnlyListOfIntProperty?.ToString() ?? "<null>"}, ParentReadOnlyListOfStringProperty = {this.ParentReadOnlyListOfStringProperty?.ToString() ?? "<null>"}, ParentReadOnlyListOfModelEquatableClassProperty = {this.ParentReadOnlyListOfModelEquatableClassProperty?.ToString() ?? "<null>"}, Child2IntProperty = {this.Child2IntProperty.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Child2StringProperty = {this.Child2StringProperty?.ToString() ?? "<null>"}, Child2ModelEquatableClassProperty = {this.Child2ModelEquatableClassProperty?.ToString() ?? "<null>"}, Child2ReadOnlyListOfIntProperty = {this.Child2ReadOnlyListOfIntProperty?.ToString() ?? "<null>"}, Child2ReadOnlyListOfStringProperty = {this.Child2ReadOnlyListOfStringProperty?.ToString() ?? "<null>"}, Child2ReadOnlyListOfModelEquatableClassProperty = {this.Child2ReadOnlyListOfModelEquatableClassProperty?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}