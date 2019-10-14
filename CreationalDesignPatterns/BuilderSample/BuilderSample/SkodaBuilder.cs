namespace BuilderSample
{
    /// <summary>
    /// Concrete builder class
    /// </summary>
    class SkodaBuilder : IVehicleBuilder
    {
        Vehicle car = new Vehicle();

        public void SetModel()
        {
            car.Model = "Skoda";
        }

        public void SetEngine()
        {
            car.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            car.Transmission = "120 km/hr";
        }

        public void SetBody()
        {
            car.Body = "Plastic";
        }

        public void SetAccessories()
        {
            car.Accessories.Add("Seat Cover");
            car.Accessories.Add("Rear Mirror");
        }

        public Vehicle GetVehicle()
        {
            return car;
        }
    }
}
