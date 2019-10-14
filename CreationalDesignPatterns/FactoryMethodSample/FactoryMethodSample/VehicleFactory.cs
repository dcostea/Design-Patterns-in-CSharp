using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(Vehicle vehicle);
    }
}
