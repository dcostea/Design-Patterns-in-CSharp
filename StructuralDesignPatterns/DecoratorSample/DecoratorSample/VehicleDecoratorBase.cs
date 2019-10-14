using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample
{
    /// <summary>
    /// AbstractDecorator abstract class
    /// </summary>
    public abstract class VehicleDecoratorBase : IVehicle
    {
        private IVehicle _vehicle;

        public VehicleDecoratorBase(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public virtual string Make
        {
            get { return _vehicle.Make; }
        }

        public virtual string Model
        {
            get { return _vehicle.Model; }
        }

        public virtual double HirePrice
        {
            get { return _vehicle.HirePrice; }
        }

        public virtual int HireLaps
        {
            get { return _vehicle.HireLaps; }
        }
    }
}
