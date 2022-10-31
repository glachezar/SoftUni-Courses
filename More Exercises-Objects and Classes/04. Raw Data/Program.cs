using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numberOfVehicles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfVehicles; i++)
            {
                cars.Add(new Car(Console.ReadLine().Split()));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.CargoType == "fragile" && c.Cargo.CargoWeight < 1000))
                {
                    Console.WriteLine($"{car.CarModel}");
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.Power > 250))
                {
                    Console.WriteLine($"{car.CarModel}");
                }
            }
        }
    }

    class Car
    {
        public Car(string[] carInfo)
        {
            CarModel = carInfo[0];
            Engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
            Cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
        }
        public string CarModel { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }

    class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get; set; }
        public int Power { get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string cargoType)
        {
            CargoWeight = weight;  
            CargoType = cargoType;
        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
