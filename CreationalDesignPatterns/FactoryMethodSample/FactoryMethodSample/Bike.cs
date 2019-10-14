using System;

namespace FactoryMethodSample
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + " km");
        }
    }
}
