using System;

namespace FactoryMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle(Vehicle.Scooter);
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle(Vehicle.Bike);
            bike.Drive(20);

            Console.ReadKey();
        }
    }
}
