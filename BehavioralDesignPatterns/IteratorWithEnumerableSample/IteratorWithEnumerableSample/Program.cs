using System;
using System.Collections;

namespace IteratorWithEnumerableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate.Add("One");
            aggregate.Add("Two");
            aggregate.Add("Three");
            aggregate.Add("Four");
            aggregate.Add("Five");

            IEnumerator iterator = aggregate.GetEnumerator();

            iterator.Reset();

            while (iterator.MoveNext())
            {
                string item = (string)iterator.Current;
                Console.WriteLine(item);
            }


            Console.ReadKey(true);
        }
    }
}
