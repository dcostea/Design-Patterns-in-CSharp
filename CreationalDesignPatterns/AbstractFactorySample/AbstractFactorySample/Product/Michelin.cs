namespace AbstractFactorySample.Product
{
    /// <summary>
    /// Concrete product class
    /// </summary>
    public class Michelin : ITyre
    {
        public string Name()
        {
            return "Michelin";
        }
    }
}