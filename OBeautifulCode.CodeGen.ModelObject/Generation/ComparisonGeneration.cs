﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComparisonGeneration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static System.FormattableString;

    /// <summary>
    /// Generates code related to comparisons.
    /// </summary>
    internal static class ComparisonGeneration
    {
        private const string TypeNameToken = "<<<TypeNameHere>>>";
        private const string BaseTypeNameToken = "<<<BaseTypeNameHere>>>";
        private const string OverrideModifierToken = "<<<OverrideModifierHere>>>";

        private const string ComparableOperatorsAndMethodsCodeTemplate = @"    /// <summary>
        /// Determines whether an object of type <see cref=""" + TypeNameToken + @"""/> is less than another object of that type.
        /// </summary>
        /// <param name=""left"">The object to the left of the less-than operator.</param>
        /// <param name=""right"">The object to the right of the less-than operator.</param>
        /// <returns>true if <paramref name=""left""/> is less than <paramref name=""right""/>; otherwise false.</returns>
        public static bool operator <(" + TypeNameToken + @" left, " + TypeNameToken + @" right)
        {
            if (ReferenceEquals(left, right))
            {
                return false;
            }

            if (ReferenceEquals(left, null))
            {
                return true;
            }

            var relativeSortOrder = left.CompareToForRelativeSortOrder(right);

            var result = relativeSortOrder == RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;

            return result;
        }

        /// <summary>
        /// Determines whether an object of type <see cref=""" + TypeNameToken + @"""/> is greater than another object of that type.
        /// </summary>
        /// <param name=""left"">The object to the left of the greater-than operator.</param>
        /// <param name=""right"">The object to the right of the greater-than operator.</param>
        /// <returns>true if <paramref name=""left""/> is greater than <paramref name=""right""/>; otherwise false.</returns>
        public static bool operator >(" + TypeNameToken + @" left, " + TypeNameToken + @" right)
        {
            if (ReferenceEquals(left, right))
            {
                return false;
            }

            if (ReferenceEquals(left, null))
            {
                return false;
            }

            var relativeSortOrder = left.CompareToForRelativeSortOrder(right);

            var result = relativeSortOrder == RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;

            return result;
        }

        /// <summary>
        /// Determines whether an object of type <see cref=""" + TypeNameToken + @"""/> is less than or equal to another object of that type.
        /// </summary>
        /// <param name=""left"">The object to the left of the less-than-or-equal-to operator.</param>
        /// <param name=""right"">The object to the right of the less-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name=""left""/> is less than or equal to <paramref name=""right""/>; otherwise false.</returns>
        public static bool operator <=(" + TypeNameToken + @" left, " + TypeNameToken + @" right) => (left < right) || (!(left > right));

        /// <summary>
        /// Determines whether an object of type <see cref=""" + TypeNameToken + @"""/> is greater than or equal to another object of that type.
        /// </summary>
        /// <param name=""left"">The object to the left of the greater-than-or-equal-to operator.</param>
        /// <param name=""right"">The object to the right of the greater-than-or-equal-to operator.</param>
        /// <returns>true if <paramref name=""left""/> is greater than or equal to <paramref name=""right""/>; otherwise false.</returns>
        public static bool operator >=(" + TypeNameToken + @" left, " + TypeNameToken + @" right) => (left > right) || (!(left < right));      

        /// <inheritdoc />
        public int CompareTo(" + TypeNameToken + @" other)
        {
            if (other == null)
            {
                return 1;
            }

            var relativeSortOrder = this.CompareToForRelativeSortOrder(other);

            switch(relativeSortOrder)
            {
                case RelativeSortOrder.ThisInstancePrecedesTheOtherInstance:
                    return -1;
                case RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance:
                    return 0;
                case RelativeSortOrder.ThisInstanceFollowsTheOtherInstance:
                    return 1;
                default:
                    throw new NotSupportedException(Invariant($""This {nameof(RelativeSortOrder)} is not supported: {relativeSortOrder}.""));
            }
        }";

        private const string ComparableMethodsForConcreteTypeCodeTemplate = @"        
        /// <inheritdoc />
        public " + OverrideModifierToken + @"int CompareTo(object obj)
        {
            if (!(obj is " + TypeNameToken + @" other))
            {
                throw new ArgumentException(Invariant($""Attempting to compare objects of different types.  This object is of type '{nameof(" + TypeNameToken + @")}' whereas the other object is of type '{obj.GetType().ToStringReadable()}'.""));
            }

            var result = this.CompareTo(other);

            return result;
        }";

        private const string ComparableMethodsForInheritedTypeCodeTemplate = @"
        public override RelativeSortOrder CompareToForRelativeSortOrder(" + BaseTypeNameToken + @" other)
        {
            if (!(other is " + TypeNameToken + @" otherAs" + TypeNameToken + @"))
            {
                throw new ArgumentException(Invariant($""Attempting to compare objects of different types.  This object is of type '{nameof(" + TypeNameToken + @")}' whereas the other object is of type '{other.GetType().ToStringReadable()}'.""));
            }

            var result = this.CompareToForRelativeSortOrder(otherAs" + TypeNameToken + @");

            return result;
        }";

        private const string ComparableMethodsForAbstractTypeCodeTemplate = @"    
        /// <inheritdoc />
        public abstract int CompareTo(object obj);

        /// <inheritdoc />
        public abstract RelativeSortOrder CompareToForRelativeSortOrder(" + TypeNameToken + @" other);";

        /// <summary>
        /// Generates comparable methods.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated comparable methods.
        /// </returns>
        public static string GenerateComparableMethods(
            this ModelType modelType)
        {
            string codeTemplate;

            string overrideModifier = null;

            if (modelType.HierarchyKind == HierarchyKind.AbstractBase)
            {
                if (modelType.DeclaresCompareToMethod)
                {
                    throw new NotSupportedException(Invariant($"Abstract type {modelType.TypeReadableString} cannot declare CompareTo method."));
                }

                codeTemplate = ComparableOperatorsAndMethodsCodeTemplate + Environment.NewLine + ComparableMethodsForAbstractTypeCodeTemplate;
            }
            else
            {
                if (!modelType.DeclaresCompareToMethod)
                {
                    throw new NotSupportedException(Invariant($"Type {modelType.TypeReadableString} must declare CompareTo method."));
                }

                codeTemplate = ComparableOperatorsAndMethodsCodeTemplate + Environment.NewLine + ComparableMethodsForConcreteTypeCodeTemplate;

                if (modelType.HierarchyKind == HierarchyKind.ConcreteInherited)
                {
                    overrideModifier = "override ";

                    codeTemplate = codeTemplate + Environment.NewLine + ComparableMethodsForInheritedTypeCodeTemplate;
                }
            }

            var result = codeTemplate
                .Replace(TypeNameToken, modelType.TypeCompilableString)
                .Replace(BaseTypeNameToken, modelType.BaseTypeCompilableString)
                .Replace(OverrideModifierToken, overrideModifier);

            return result;
        }

        /// <summary>
        /// Generates test methods that test comparability.
        /// </summary>
        /// <param name="modelType">The model type.</param>
        /// <returns>
        /// Generated test methods that test comparability.
        /// </returns>
        public static string GenerateComparabilityTestMethods(
            this ModelType modelType)
        {
            var result = ComparableTestMethodsCodeTemplate
                .Replace(TypeNameToken, modelType.TypeCompilableString);

            return result;
        }
    }
}