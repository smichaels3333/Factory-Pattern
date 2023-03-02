namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfWheels;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the ammount of tires for the vehicle you want to create:");

                input = int.TryParse(Console.ReadLine(), out numberOfWheels);
            }
            while (!input);

            var vehicle = VehicleFactory.GetVehicle(numberOfWheels);
            vehicle.Drive();
        }
    }
}
