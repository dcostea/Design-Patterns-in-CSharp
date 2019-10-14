using System.Collections.Generic;
using static System.Console;

namespace BuilderSample
{
    /// <summary>
    /// Concrete product class
    /// </summary>
    public class Vehicle
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Body { get; set; }
        public List<string> Accessories { get; set; }

        public Vehicle()
        {
            Accessories = new List<string>();
        }

        public void ShowInfo()
        {
            WriteLine("Model: {0}", Model);
            WriteLine("Engine: {0}", Engine);
            WriteLine("Body: {0}", Body);
            WriteLine("Transmission: {0}", Transmission);
            WriteLine("Accessories:");
            foreach (var accessory in Accessories)
            {
                WriteLine("\t{0}", accessory);
            }
        }
    }
}
