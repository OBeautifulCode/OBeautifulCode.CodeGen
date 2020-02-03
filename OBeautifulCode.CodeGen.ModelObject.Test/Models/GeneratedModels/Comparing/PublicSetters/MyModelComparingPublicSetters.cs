// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPublicSetters.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced OBeautifulCode.CodeGen.ModelObject.Test.CodeGeneratorTest.GenerateModel()
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using FakeItEasy;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Equality.Recipes;
    using OBeautifulCode.Type;

    public partial class MyModelComparingPublicSetters : IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<MyModelComparingPublicSetters>
    {
        public int IntProperty { get; set; }

        /// <inheritdoc />
        public RelativeSortOrder CompareToForRelativeSortOrder(MyModelComparingPublicSetters other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            if (this.IntProperty > other.IntProperty)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }

            else if (this.IntProperty < other.IntProperty)
            {
                return RelativeSortOrder.ThisInstancePrecedesTheOtherInstance;
            }

            else
            {
                return RelativeSortOrder.ThisInstanceOccursInTheSamePositionAsTheOtherInstance;
            }
        }
    }
}