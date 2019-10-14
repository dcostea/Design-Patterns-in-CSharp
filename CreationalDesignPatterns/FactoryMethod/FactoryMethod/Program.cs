using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCreator creator = new ConcreteCreator();
            creator.FactoryMethod(Type.A).DoSomething();
            creator.FactoryMethod(Type.B).DoSomething();
        }
    }

    interface IProduct {
        void DoSomething();
    }

    enum Type
    {
        A,
        B
    }

    class ConcreteProductA : IProduct
    {
        public void DoSomething()
        {
        }
    }

    class ConcreteProductB : IProduct
    {
        public void DoSomething()
        {
        }
    }

    abstract class AbstractCreator
    {
        public abstract IProduct FactoryMethod(Type type);
    }

    class ConcreteCreator : AbstractCreator
    {
        public override IProduct FactoryMethod(Type type)
        {
            switch (type)
            {
                case Type.A: return new ConcreteProductA();
                case Type.B: return new ConcreteProductB();
                default: throw new ArgumentException("Invalid type", $"{type}");
            }
        }
    }
}
