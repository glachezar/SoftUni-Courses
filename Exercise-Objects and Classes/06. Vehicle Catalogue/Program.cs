using System;
using System.Collections.Generic;
using System.Linq;

class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public int Horsepower { get; set; }

    public List<int> carHp = new List<int>();

    public List<int> truckHp = new List<int>();
}

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        string[] command = Console.ReadLine().Split();

        while (command[0] != "End")
        {
            string type = command[0], model = command[1], color = command[2];
            int hp = int.Parse(command[3]);

            Vehicle vehicle = new Vehicle()
            {
                Type = type,
                Model = model,
                Color = color,
                Horsepower = hp
            };

            if (type == "car")
            {
                vehicle.carHp.Add(hp);
            }
            else if (type == "truck")
            {
                vehicle.truckHp.Add(hp);
            }

            vehicles.Add(vehicle);

            command = Console.ReadLine().Split();
        }

        string input = Console.ReadLine();

        while (input != "Close the Catalogue")
        {
            foreach (var v in vehicles.Where(v => v.Model == input))
            {
                Console.WriteLine($"Type: {char.ToUpper(v.Type[0]) + v.Type.Substring(1).ToLower()}");
                Console.WriteLine($"Model: {v.Model}");
                Console.WriteLine($"Color: {v.Color}");
                Console.WriteLine($"Horsepower: {v.Horsepower}");
            }

            input = Console.ReadLine();
        }

        double allCars = 0, carsCount = 0, allTrucks = 0, trucksCount = 0, carsAverage = 0.00, trucksAverage = 0.00;

        foreach (var veh in vehicles.Where(v => v.Type == "car"))
        {
            foreach (var v in veh.carHp)
            {
                allCars += v;
            }
            carsCount++;
        }

        foreach (var veh in vehicles.Where(v => v.Type == "truck"))
        {
            foreach (var v in veh.truckHp)
            {
                allTrucks += v;
            }
            trucksCount++;
        }

        carsAverage = allCars / carsCount;
        trucksAverage = allTrucks / trucksCount;

        if (carsAverage.Equals(double.NaN))
            Console.WriteLine("Cars have average horsepower of: 0.00.");
        else
            Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");

        if (trucksAverage.Equals(double.NaN))
            Console.WriteLine("Trucks have average horsepower of: 0.00.");
        else
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:f2}.");

    }
}