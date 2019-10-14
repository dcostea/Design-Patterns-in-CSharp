namespace BuilderSample
{
    /// <summary>
    /// Concrete builder class
    /// </summary>
    class HondaBuilder : IVehicleBuilder
    {
        Vehicle bike = new Vehicle();

        public void SetModel()
        {
            bike.Model = "Honda";
        }

        public void SetEngine()
        {
            bike.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            bike.Transmission = "125 Km/hr";
        }

        public void SetBody()
        {
            bike.Body = "Plastic";
        }

        public void SetAccessories()
        {
            bike.Accessories.Add("Seat Cover");
            bike.Accessories.Add("Rear Mirror");
            bike.Accessories.Add("Helmet");
        }

        public Vehicle GetVehicle()
        {
            return bike;
        }
    }
}
