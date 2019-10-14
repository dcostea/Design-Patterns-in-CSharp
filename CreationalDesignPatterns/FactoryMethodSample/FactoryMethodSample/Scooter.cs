using System;
namespace FactoryMethodSample
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class Scooter : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine($"Drive the Scooter: {km} km");
        }
    }
}
