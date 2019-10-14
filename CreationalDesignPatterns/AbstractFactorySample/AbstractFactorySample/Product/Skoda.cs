namespace AbstractFactorySample.Product
{
    /// <summary>
    /// Concrete product class
    /// </summary>
    public class Skoda : ICar
    {
        public string Name()
        {
            return "Skoda";
        }
    }
}