namespace AbstractFactorySample.Product
{
    /// <summary>
    /// Concrete product class
    /// </summary>
    public class Dunlop : ITyre
    {
        public string Name()
        {
            return "Dunlop";
        }
    }
}