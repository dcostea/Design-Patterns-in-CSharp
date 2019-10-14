using AbstractFactorySample.Factory;
using AbstractFactorySample.Product;

namespace AbstractFactorySample.Client
{
    /// <summary>
    /// Client class
    /// </summary>
    class Promotion
    {
        ITyre tyre;
        ICar car;

        public Promotion(IDealer dealer, string category)
        {
            tyre = dealer.GetTyre(category);
            car = dealer.GetCar(category);
        }

        public string GetTyreName()
        {
            return tyre.Name();
        }

        public string GetCarName()
        {
            return car.Name();
        }
    }
}
