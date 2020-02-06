// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyModelComparingPrivateSetters.cs" company="OBeautifulCode">
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

    public partial class MyModelComparingPrivateSetters : IComparableViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<MyModelComparingPrivateSetters>
    {
        public MyModelComparingPrivateSetters(
            int intProperty)
        {

            this.IntProperty = intProperty;
        }

        public int IntProperty { get; private set; }

        /// <inheritdoc />
        public RelativeSortOrder CompareToForRelativeSortOrder(MyModelComparingPrivateSetters other)
        {
            if (other == null)
            {
                return RelativeSortOrder.ThisInstanceFollowsTheOtherInstance;
            }
            else if (this.IntProperty > other.IntProperty)
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