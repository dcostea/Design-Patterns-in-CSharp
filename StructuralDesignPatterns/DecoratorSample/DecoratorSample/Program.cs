using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic vehicle
            Ferrari car = new Ferrari();
            Console.WriteLine("Base price is {0:c} for {1} laps.", car.HirePrice, car.HireLaps);

            // Special offer
            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.ExtraLaps = 2;
            Console.WriteLine("Offer price is {0:c} for {1} laps.", offer.HirePrice, offer.HireLaps);

            // Hire for basic vehicle
            Hireable hire1 = new Hireable(car);
            hire1.Hire("Bob");

            // Hire for vehicle with special offer
            Hireable hire2 = new Hireable(offer);
            hire2.Hire("Bill");

            /* OUTPUT

            Base price is £100.00 for 10 laps.
            Offer price is £75.00 for 12 laps.
            Ferrari 360 hired by Bob at a price of £100.00 for 10 laps.
            Ferrari 360 hired by Bill at a price of £75.00 for 12 laps.

            */

            Console.ReadKey(true);
        }
    }
}
