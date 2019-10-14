using System;

namespace FactoryMethodSample
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(Vehicle type)
        {
            switch (type)
            {
                case Vehicle.Scooter:
                    return new Scooter();

                case Vehicle.Bike:
                    return new Bike();

                default:
                    throw new ApplicationException($"Vehicle '{type}' cannot be created");
            }
        }
    }
}
