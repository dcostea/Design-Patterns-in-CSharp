namespace AbstractFactorySample.Product
{
    /// <summary>
    /// Concrete product class
    /// </summary>
    public class Ferrari : ICar
    {
        public string Name()
        {
            return "Ferrari";
        }
    }
}