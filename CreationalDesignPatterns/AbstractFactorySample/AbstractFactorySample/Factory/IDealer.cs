using AbstractFactorySample.Product;

namespace AbstractFactorySample.Factory
{
    /// <summary>
    /// Abstract factory class
    /// </summary>
    public interface IDealer
    {
        ITyre GetTyre(string category);
        ICar GetCar(string category);
    }
}
