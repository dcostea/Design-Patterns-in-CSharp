using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SingletonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var onlyNonThreadSafe = NotThreadSafe.Singleton.GetInstance;
            var onlyThreadSafe = ThreadSafe.Singleton.GetInstance;
            var onlyThreadSafeDoubleCheck = ThreadSafeDoubleCheck.Singleton.GetInstance;

            var rexOnlyOne = NotThreadSafe.Rex.Itself;
            WriteLine($"Rex instances: {NotThreadSafe.Rex.Counter}");

            var rexSecondOne = NotThreadSafe.Rex.Itself;
            WriteLine($"Rex instances: {NotThreadSafe.Rex.Counter}");

            Write("Press any key to continue...");
            ReadKey(true);
        }
    }
}
