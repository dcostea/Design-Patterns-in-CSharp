using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample
{
    /// <summary>
    /// Concrete Component class
    /// </summary>
    public class Ferrari : IVehicle
    {
        public string Make
        {
            get { return "Ferrari"; }
        }

        public string Model
        {
            get { return "360"; }
        }

        public double HirePrice
        {
            get { return 100; }
        }

        public int HireLaps
        {
            get { return 10; }
        }
    }
}
