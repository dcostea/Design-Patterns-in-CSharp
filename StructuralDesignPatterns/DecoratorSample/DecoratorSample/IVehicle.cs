using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample
{
    /// <summary>
    /// IComponent interface
    /// </summary>
    public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        double HirePrice { get; }
        int HireLaps { get; }
    }
}
