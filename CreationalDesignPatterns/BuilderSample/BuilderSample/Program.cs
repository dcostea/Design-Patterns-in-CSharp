using static System.Console;

namespace BuilderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleCreator = new VehicleCreator(new SkodaBuilder());
            vehicleCreator.CreateVehicle();

            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            WriteLine("---------------------------------------------");

            vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.CreateVehicle();

            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();


            Write("Press any key to continue...");
            ReadKey();
        }
    }
}
