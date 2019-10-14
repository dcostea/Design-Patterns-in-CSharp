using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample
{
    /// <summary>
    /// Concrete Decorator Class
    /// </summary>
    public class SpecialOffer : VehicleDecoratorBase
    {
        public SpecialOffer(IVehicle vehicle) : base(vehicle) { }

        public int DiscountPercentage { get; set; }
        public int ExtraLaps { get; set; }

        public override double HirePrice
        {
            get
            {
                double price = base.HirePrice;
                int percentage = 100 - DiscountPercentage;
                return Math.Round((price * percentage) / 100, 2);
            }
        }

        public override int HireLaps
        {
            get
            {
                return base.HireLaps + ExtraLaps;
            }
        }
    }
}
