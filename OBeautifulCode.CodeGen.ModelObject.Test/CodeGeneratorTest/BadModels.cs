// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BadModels.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Test
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Type;

#pragma warning disable SA1649 // File name should match first type name
#pragma warning disable SA1201 // Elements should appear in the correct order

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class DoesNotImplementInterfaceThatIndicatesCodeGenIsRequired
    {
    }

    public interface IBad : IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public struct Struct : IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public struct GenericStruct<T> : IModelViaCodeGen
    {
    }

    public interface IGenericInterface<T> : IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class GenericClass<T> : IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ConcreteBaseClass : IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class AbstractClassWithConcreteBaseClass : ConcreteBaseClass, IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ConcreteClassWithConcreteBaseClass : ConcreteBaseClass, IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class MissingCodeGenInterfacesParent1
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class MissingCodeGenInterfacesChild1 : MissingCodeGenInterfacesParent1, IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class MissingCodeGenInterfacesGrandchild1 : MissingCodeGenInterfacesChild1, IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class MissingCodeGenInterfacesParent2 : IDeepCloneableViaCodeGen, IStringRepresentableViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class MissingCodeGenInterfacesChild2 : MissingCodeGenInterfacesParent2, IDeepCloneableViaCodeGen, IEquatableViaCodeGen, IStringRepresentableViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class MissingCodeGenInterfacesGrandchild2 : MissingCodeGenInterfacesChild2, IDeepCloneableViaCodeGen, IEquatableViaCodeGen, IStringRepresentableViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class DictionaryKeyedOnDateTimeProperty1 : IModelViaCodeGen
    {
        public IReadOnlyDictionary<DateTime, string> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class DictionaryKeyedOnDateTimeProperty2 : IModelViaCodeGen
    {
        public IList<IList<IDictionary<string, IDictionary<DateTime, string>>>> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class DictionaryKeyedOnDateTimeProperty3 : IModelViaCodeGen
    {
        public IDictionary<DateTime, string>[] Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class DictionaryKeyedOnDateTimeProperty4Base : IModelViaCodeGen
    {
        public IList<IList<IDictionary<IDictionary<DateTime, string>[], string>>>[] Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class DictionaryKeyedOnDateTimeProperty4 : DictionaryKeyedOnDateTimeProperty4Base, IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasEnumerableProperty1 : IModelViaCodeGen
    {
        public IEnumerable<string> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasEnumerableProperty2 : IModelViaCodeGen
    {
        public IList<IList<IDictionary<string, IEnumerable<string>>>> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class HasEnumerableProperty3Base : IModelViaCodeGen
    {
        public IList<IList<IDictionary<IEnumerable<string>[], string>>>[] Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasEnumerableProperty3 : HasEnumerableProperty3Base, IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceCollectionProperty1 : IModelViaCodeGen
    {
        public Collection<string> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceCollectionProperty2 : IModelViaCodeGen
    {
        public ReadOnlyCollection<string> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceCollectionProperty3 : IModelViaCodeGen
    {
        public List<string> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceCollectionProperty4 : IModelViaCodeGen
    {
        public IList<IList<IDictionary<string, Collection<string>>>> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class HasNonInterfaceCollectionProperty5Base : IModelViaCodeGen
    {
        public IList<IList<IDictionary<ReadOnlyCollection<string>[], string>>>[] Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceCollectionProperty5 : HasNonInterfaceCollectionProperty5Base, IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceCollectionProperty6 : IModelViaCodeGen
    {
        public IList<IList<IDictionary<string, List<string>>>> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceDictionaryProperty1 : IModelViaCodeGen
    {
        public Dictionary<string, string> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceDictionaryProperty2 : IModelViaCodeGen
    {
        public ReadOnlyDictionary<string, string> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceDictionaryProperty3 : IModelViaCodeGen
    {
        public ConcurrentDictionary<string, string> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceDictionaryProperty4 : IModelViaCodeGen
    {
        public IList<IList<IDictionary<string, Dictionary<string, string>>>> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class HasNonInterfaceDictionaryProperty5Base : IModelViaCodeGen
    {
        public IList<IList<IDictionary<ReadOnlyDictionary<string, string>[], string>>>[] Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceDictionaryProperty5 : HasNonInterfaceDictionaryProperty5Base, IModelViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class HasNonInterfaceDictionaryProperty6 : IModelViaCodeGen
    {
        public IList<IList<IDictionary<string, ConcurrentDictionary<string, string>>>> Property1 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class AbstractDeclaredCompareTo : IModelViaCodeGen, IDeclareCompareToForRelativeSortOrderMethod<AbstractDeclaredCompareTo>
    {
        public RelativeSortOrder CompareToForRelativeSortOrder(AbstractDeclaredCompareTo other)
        {
            throw new NotImplementedException();
        }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class AbstractDeclaredDeepClone : IModelViaCodeGen, IDeclareDeepCloneMethod<AbstractDeclaredDeepClone>
    {
        public AbstractDeclaredDeepClone DeepClone()
        {
            throw new NotImplementedException();
        }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class AbstractDeclaredEquals : IModelViaCodeGen, IDeclareEqualsMethod<AbstractDeclaredEquals>
    {
        public bool Equals(AbstractDeclaredEquals other)
        {
            throw new NotImplementedException();
        }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class AbstractDeclaredGetHashCode : IModelViaCodeGen, IDeclareGetHashCodeMethod
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class AbstractDeclaredToString : IModelViaCodeGen, IDeclareToStringMethod
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ComparableViaCodeGenWithoutDeclaredCompareTo : IComparableViaCodeGen
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ReadOnlyAutoProperties1 : IModelViaCodeGen
    {
        public string Property1 { get; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ReadOnlyAutoProperties2 : IModelViaCodeGen
    {
        public ReadOnlyAutoProperties2(
            string property1,
            string property2)
        {
            this.Property1 = property1;

            this.Property2 = property2;
        }

        public string Property1 { get; }

        public string Property2 { get; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class ReadOnlyAutoPropertiesBase : IModelViaCodeGen
    {
        protected ReadOnlyAutoPropertiesBase(
            string property1,
            string property2)
        {
            this.Property1 = property1;

            this.Property2 = property2;
        }

        public string Property1 { get; }

        public string Property2 { get; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ReadOnlyAutoProperties3 : ReadOnlyAutoPropertiesBase, IModelViaCodeGen
    {
        public ReadOnlyAutoProperties3(
            string property1,
            string property2)
        : base(property1, property2)
        {
        }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ReadOnlyAutoProperties4 : IModelViaCodeGen
    {
        public DateTime Property1 { get; } = DateTime.Now;
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class NotPrivateNotPublicProperties1 : IModelViaCodeGen
    {
        public string Property1 { get; set; }

        public string Property2 { get; protected set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class NotPrivateNotPublicPropertiesBase1 : IModelViaCodeGen
    {
        public string Property1 { get; set; }

        public string Property2 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class NotPrivateNotPublicProperties2 : NotPrivateNotPublicPropertiesBase1, IModelViaCodeGen
    {
        public string Property3 { get; protected set; }

        public string Property4 { get; protected set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class NotPrivateNotPublicPropertiesBase2 : IModelViaCodeGen
    {
        public string Property1 { get; protected set; }

        public string Property2 { get; protected set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class NotPrivateNotPublicProperties3 : NotPrivateNotPublicPropertiesBase2, IModelViaCodeGen
    {
        public string Property3 { get; set; }

        public string Property4 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class MixedAccessProperties1 : IModelViaCodeGen
    {
        public string Property1 { get; set; }

        public string Property2 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class MixedAccessPropertiesBase1 : IModelViaCodeGen
    {
        public string Property1 { get; set; }

        public string Property2 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class MixedAccessProperties2 : MixedAccessPropertiesBase1, IModelViaCodeGen
    {
        public string Property3 { get; private set; }

        public string Property4 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class MixedAccessPropertiesBase2 : IModelViaCodeGen
    {
        public string Property1 { get; private set; }

        public string Property2 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class MixedAccessProperties3 : MixedAccessPropertiesBase2, IModelViaCodeGen
    {
        public string Property3 { get; set; }

        public string Property4 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class AbstractClassWithConstructor1 : IModelViaCodeGen
    {
        public AbstractClassWithConstructor1()
        {
        }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class AbstractClassWithConstructor2 : IModelViaCodeGen
    {
        public AbstractClassWithConstructor2(
            string test)
        {
            this.Test = test;
        }

        public string Test { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ConcreteClassWithNonPublicConstructor1 : IModelViaCodeGen
    {
        internal ConcreteClassWithNonPublicConstructor1()
        {
        }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ConcreteClassWithNonPublicConstructor2 : IModelViaCodeGen
    {
        protected ConcreteClassWithNonPublicConstructor2(
            string test)
        {
            this.Test = test;
        }

        public string Test { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ConstructorParameterWithoutMatchingProperty1 : IModelViaCodeGen
    {
        public ConstructorParameterWithoutMatchingProperty1(string property1, string property3)
        {
            this.Property1 = property1;
        }

        public ConstructorParameterWithoutMatchingProperty1(string property1, string property2, string property3)
        {
            this.Property1 = property1;
            this.Property2 = property2;
        }

        public string Property1 { get; private set; }

        public string Property2 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class ConstructorParameterWithoutMatchingPropertyBase : IModelViaCodeGen
    {
        protected ConstructorParameterWithoutMatchingPropertyBase()
        {
        }

        protected ConstructorParameterWithoutMatchingPropertyBase(string property1)
        {
            this.Property1 = property1;
        }

        protected ConstructorParameterWithoutMatchingPropertyBase(string property1, string property2)
        {
            this.Property1 = property1;
            this.Property2 = property2;
        }

        public string Property1 { get; private set; }

        public string Property2 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ConstructorParameterWithoutMatchingProperty2 : ConstructorParameterWithoutMatchingPropertyBase, IModelViaCodeGen
    {
        public ConstructorParameterWithoutMatchingProperty2(DateTime property5)
            : base()
        {
        }

        public ConstructorParameterWithoutMatchingProperty2(string property1, string property3, DateTime property4)
        : base(property1)
        {
            this.Property4 = property4;
        }

        public ConstructorParameterWithoutMatchingProperty2(string property1, string property2, string property3, DateTime property4)
        : base(property1, property2)
        {
            this.Property4 = property4;
        }

        public DateTime Property4 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ConstructorParameterWithoutMatchingProperty3 : IModelViaCodeGen
    {
        public ConstructorParameterWithoutMatchingProperty3(string property1, DateTime property2)
        {
            this.Property1 = property1;
        }

        public ConstructorParameterWithoutMatchingProperty3(DateTime property1, string property2)
        {
            this.Property2 = property2;
        }

        public string Property1 { get; private set; }

        public string Property2 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ConstructorParameterWithoutMatchingProperty4 : ConstructorParameterWithoutMatchingPropertyBase, IModelViaCodeGen
    {
        public ConstructorParameterWithoutMatchingProperty4(DateTime property1, string property2, DateTime property3)
            : base()
        {
            this.Property3 = property3;
        }

        public ConstructorParameterWithoutMatchingProperty4(string property1, DateTime property2, DateTime property3)
            : base()
        {
            this.Property3 = property3;
        }

        public DateTime Property3 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class MultipleCandidateConstructors1 : IModelViaCodeGen
    {
        public MultipleCandidateConstructors1(string property1, string property2, DateTime property3)
        {
            this.Property1 = property1;
            this.Property2 = property2;
            this.Property3 = property3;
        }

        public MultipleCandidateConstructors1(string property2, DateTime property3, DateTime property4)
        {
            this.Property2 = property2;
            this.Property3 = property3;
            this.Property4 = property4;
        }

        public string Property1 { get; private set; }

        public string Property2 { get; private set; }

        public DateTime Property3 { get; private set; }

        public DateTime Property4 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class MultipleCandidateConstructorsBase : IModelViaCodeGen
    {
        protected MultipleCandidateConstructorsBase()
        {
        }

        protected MultipleCandidateConstructorsBase(string property1, string property2, DateTime property3)
        {
            this.Property1 = property1;
            this.Property2 = property2;
            this.Property3 = property3;
        }

        protected MultipleCandidateConstructorsBase(string property2, DateTime property3, DateTime property4)
        {
            this.Property2 = property2;
            this.Property3 = property3;
            this.Property4 = property4;
        }

        public string Property1 { get; private set; }

        public string Property2 { get; private set; }

        public DateTime Property3 { get; private set; }

        public DateTime Property4 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class MultipleCandidateConstructors2 : MultipleCandidateConstructorsBase, IModelViaCodeGen
    {
        public MultipleCandidateConstructors2(string property1, string property2, DateTime property3)
            : base(property1, property2, property3)
        {
        }

        public MultipleCandidateConstructors2(string property2, DateTime property3, DateTime property4)
            : base(property2, property3, property4)
        {
        }

        public MultipleCandidateConstructors2(DateTime property5, DateTime property6, DateTime property7)
            : base()
        {
            this.Property5 = property5;
            this.Property6 = property6;
            this.Property7 = property7;
        }

        public DateTime Property5 { get; private set; }

        public DateTime Property6 { get; private set; }

        public DateTime Property7 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class DefaultConstructorWithPrivateSetters : IModelViaCodeGen
    {
        public DefaultConstructorWithPrivateSetters()
        {
        }

        public string Property1 { get; private set; }

        public DateTime Property2 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class ParameterizedConstructorWithPublicSetters : IModelViaCodeGen
    {
        public ParameterizedConstructorWithPublicSetters(
            string property1,
            DateTime property2)
        {
            this.Property1 = property1;
            this.Property2 = property2;
        }

        public string Property1 { get; set; }

        public DateTime Property2 { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class DeclaredPropertyNotInConstructor : IModelViaCodeGen
    {
        public DeclaredPropertyNotInConstructor(string property1, string property2)
        {
            this.Property1 = property1;
            this.Property2 = property2;
        }

        public string Property1 { get; private set; }

        public string Property2 { get; private set; }

        public DateTime Property3 { get; private set; }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class NonAbstractBaseClass
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class BaseClassWithNoDerivatives
    {
    }

    [GeneratedCode("ignore", "ignore")]
    public interface IInterfaceWithNoImplementers
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public abstract class BaseClassForGenericArgumentWithConstraintsThatCannotBeSatisfied
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class DerivativeClassForGenericArgumentWithConstraintsThatCannotBeSatisfied : BaseClassForGenericArgumentWithConstraintsThatCannotBeSatisfied
    {
        public DerivativeClassForGenericArgumentWithConstraintsThatCannotBeSatisfied(int whatever)
        {
        }
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class GenericClassWithNonAbstractBaseClassConstraint<T1, T2> : IModelViaCodeGen
        where T2 : NonAbstractBaseClass
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class GenericClassWithConstraintHavingNoLoadedAssignableTypes1<T1, T2> : IModelViaCodeGen
        where T2 : BaseClassWithNoDerivatives
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class GenericClassWithConstraintHavingNoLoadedAssignableTypes2<T1, T2> : IModelViaCodeGen
        where T2 : IInterfaceWithNoImplementers
    {
    }

    [ExcludeFromCodeCoverage]
    [GeneratedCode("ignore", "ignore")]
    public class GenericClassWithConstraintsThatCannotBeSatisfied<T1, T2> : IModelViaCodeGen
        where T2 : BaseClassForGenericArgumentWithConstraintsThatCannotBeSatisfied, new()
    {
    }
#pragma warning restore SA1201 // Elements should appear in the correct order
#pragma warning restore SA1649 // File name should match first type name
}
