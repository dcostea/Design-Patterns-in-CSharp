using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    class Client
    {
        static void Main(string[] args)
        {
            ICar car = new DrivablePlane();
            car.Drive();

            Console.ReadKey(true);
        }
    }
}
