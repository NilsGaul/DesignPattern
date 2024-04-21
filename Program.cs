// See https://aka.ms/new-console-template for more information

// Why Factory Design Pattern
    // Factories can make your code flexible by reducing too many conditional statements (if...else).
    // Factories enforce SRP. If you are not familiar with the SOLID principle, you should do your research on it, but it is not mandatory for design patterns.
    // Factories also help you avoid tight coupling codes.
    // Factories enforce the Open/Closed principle: You can create new products without breaking existing client code.
    // Factories help you avoid rebuilding your code anytime there are requirement changes; you just reuse objects.

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an Factory Design Pattern.");
            Console.WriteLine("A Factory design pattern is a creational pattern.");

            IVehicle vehicle = VehicleFactory.CreateVehicle("bike");
            vehicle.Drive();

            IVehicle anotherVehicle = VehicleFactory.CreateVehicle("car");
            anotherVehicle.Drive();

            IVehicle finalVehicle = VehicleFactory.CreateVehicle("final");
            finalVehicle.Drive();
        }
    }

    //Class ProductInterface
    public interface IVehicle
    {
        void Drive();
    }

    //Product Classes that implement ProductInterface
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    public class Bike: IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is driving.");
        }
    }

    //Creator class with factory method
    public class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType)
        {
            Console.WriteLine($"Create new: {vehicleType} in vehiclefactory.");
            switch(vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                default:
                    throw new ArgumentException("Invalid vehicle type", nameof(vehicleType)); 
            }
        }
    }

}

