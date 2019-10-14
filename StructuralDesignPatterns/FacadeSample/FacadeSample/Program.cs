using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Fly fly = new Fly();
            fly.TakeOff();

            Console.ReadKey(true);
        }
    }
}
