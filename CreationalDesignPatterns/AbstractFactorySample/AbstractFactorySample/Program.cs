using AbstractFactorySample.Factory;
using AbstractFactorySample.Client;
using static System.Console;
using System;

namespace AbstractFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            IDealer cluj = new Autoland();
            Promotion offer;
            WriteLine(Environment.NewLine + "******* promotion from Autoland Cluj **********");

            offer = new Promotion(cluj, "Regular");
            WriteLine(offer.GetTyreName());
            WriteLine(offer.GetCarName());

            offer = new Promotion(cluj, "Sports");
            WriteLine(offer.GetTyreName());
            WriteLine(offer.GetCarName());

            IDealer bucharest = new Compexit();
            Promotion companyOffer;
            WriteLine(Environment.NewLine + "******* promotion from Compexit Bucharest **********");

            companyOffer = new Promotion(bucharest, "Regular");
            WriteLine(companyOffer.GetTyreName());
            WriteLine(companyOffer.GetCarName());

            companyOffer = new Promotion(bucharest, "Sports");
            WriteLine(companyOffer.GetTyreName());
            WriteLine(companyOffer.GetCarName());

            Write(Environment.NewLine + "Press any key to continue...");
            ReadKey(true);
        }
    }
}
