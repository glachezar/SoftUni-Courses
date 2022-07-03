using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split("/");
                string carOrTruck = tokens[0];
                string make = tokens[1];
                string model = tokens[2];
                int powerOrWeight = int.Parse(tokens[3]);

                switch (carOrTruck)
                {
                    case "Car":
                        Cars cars = new Cars
                        {
                            Brand = make,
                            Model = model,
                            HorsePower = powerOrWeight
                        };
                        catalog.Cars.Add(cars);
                        break;
                    case "Truck":
                        Trucks truck = new Trucks
                        {
                            Brand = make,
                            Model = model,
                            Weight = powerOrWeight
                        };
                        catalog.Trucks.Add(truck);
                        break;
                }
            }

            if (catalog.Cars.Count > 0)
            {
                List<Cars> alphabethicalOrder = catalog.Cars.OrderBy(car => car.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (var car in alphabethicalOrder)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                List<Trucks> alphabethicalOrder = catalog.Trucks.OrderBy(t => t.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (var truck in alphabethicalOrder)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        class Cars
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }

        class Trucks
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }

        class Catalog
        {
            public Catalog()
            {
                this.Cars = new List<Cars>();
                this.Trucks = new List<Trucks>();
            }
            public List<Cars> Cars { get; set; }
            public List<Trucks> Trucks { get; set; }
        }
    }
}
