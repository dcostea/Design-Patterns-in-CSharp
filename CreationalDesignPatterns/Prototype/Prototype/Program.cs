using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalA = new ConcretePrototypeA();
            var originalB = new ConcretePrototypeB();
            var cloneA = originalA.Clone() as ConcretePrototypeA;
            var cloneB = originalB.Clone() as ConcretePrototypeB;
        }

        public interface IPrototype
        {
            IPrototype Clone();
        }

        public class ConcretePrototypeA : IPrototype
        {
            public IPrototype Clone()
            {
                // Shallow Copy: only top-level objects are duplicated
                return (IPrototype)MemberwiseClone();

                // Deep Copy: all depending objects are duplicated
                //var clone = (IPrototype)MemberwiseClone();
                // //go deeper on depedencies and clone them all
                //return clone;
            }
        }

        public class ConcretePrototypeB : IPrototype
        {
            public IPrototype Clone()
            {
                // Shallow Copy: only top-level objects are duplicated
                return (IPrototype)MemberwiseClone();

                // Deep Copy: all objects are duplicated
                //var clone = (IPrototype)MemberwiseClone();
                // //go deeper on depedencies and clone them all
                //return clone;
            }
        }
    }
}
