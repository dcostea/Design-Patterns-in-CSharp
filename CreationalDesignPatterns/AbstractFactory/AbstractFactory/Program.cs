using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractFactory factoryA = new ConcreteFactoryA();
            IAbstractFactory factoryB = new ConcreteFactoryB();
            Client client1 = new Client(factoryA);
            Client client2 = new Client(factoryB);
        }

        public interface IAbstractProductX
        {
        }

        public interface IAbstractProductY
        {
        }

        public interface IAbstractFactory
        {
            IAbstractProductX CreateProductX();
            IAbstractProductY CreateProductY();
        }

        public class ProductX1 : IAbstractProductX
        {
        }

        public class ProductX2 : IAbstractProductX
        {
        }

        public class ProductY1 : IAbstractProductY
        {
        }

        public class ProductY2 : IAbstractProductY
        {
        }

        public class ConcreteFactoryA : IAbstractFactory
        {
            public IAbstractProductX CreateProductX()
            {
                return new ProductX1();
            }

            public IAbstractProductY CreateProductY()
            {
                return new ProductY1();
            }
        }

        public class ConcreteFactoryB : IAbstractFactory
        {
            public IAbstractProductX CreateProductX()
            {
                return new ProductX2();
            }

            public IAbstractProductY CreateProductY()
            {
                return new ProductY2();
            }
        }

        public class Client
        {
            private IAbstractProductX productX;
            private IAbstractProductY productY;

            public Client(IAbstractFactory factory)
            {
                productX = factory.CreateProductX();
                productY = factory.CreateProductY();
            }
        }
    }
}
