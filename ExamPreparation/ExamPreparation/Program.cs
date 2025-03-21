using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input car brand: ");
            string brand = Console.ReadLine();
            Console.Write("Input car model: ");
            string model = Console.ReadLine();
            Console.Write("Input car speed: ");
            double speed = double.Parse(Console.ReadLine());

            Car car = new Car
            {
                Brand = brand,
                Model = model,
            };

            double acceleration = car.Acceleration(speed);
            Console.WriteLine($"Car {car.Brand} {car.Model} is Accelerating with {acceleration}");

            double stop = car.Stop(speed);
            Console.WriteLine($"{car.Brand} {car.Model} stops - {stop} km.");

            Console.Write("Input truck brand: ");
            string brandTruck = Console.ReadLine();
            Console.Write("Input truck model: ");
            string modelTruck = Console.ReadLine();
            Console.Write("Input truck speed: ");
            double speedTruck = double.Parse(Console.ReadLine());

            Truck truck = new Truck
            {
                Brand = brandTruck,
                Model = modelTruck
            };

            double accelerationTruck = truck.Acceleration(speedTruck);
            Console.WriteLine($"Truck {truck.Brand} {truck.Model} is Accelerating with {accelerationTruck}");

            double stopTruck = truck.Stop(speedTruck);
            Console.WriteLine($"{truck.Brand} {truck.Model} stops - {stop} km.");
        }
    }
}
