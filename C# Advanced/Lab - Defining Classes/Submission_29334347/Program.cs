using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Channels;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "No more tires")
                {
                    break;
                }
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


                Tire[] tire = new Tire[4]
                {
                    new Tire(int.Parse(tokens[0]), double.Parse(tokens[1])),
                    new Tire(int.Parse(tokens[2]), double.Parse(tokens[3])),
                    new Tire(int.Parse(tokens[4]), double.Parse(tokens[5])),
                    new Tire(int.Parse(tokens[6]), double.Parse(tokens[7])),
                };

                tires.Add(tire);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Engines done")
                {
                    break;
                }

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                engines.Add(new Engine(int.Parse(tokens[0]), double.Parse(tokens[1])));
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Show special")
                {
                    break;
                }

                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string make = input[0];
                string model = input[1];

                int year = int.Parse(input[2]);

                double fuelQuantity = double.Parse(input[3]);
                double fuelConsumption = double.Parse(input[4]);

                int engineIndex = int.Parse(input[5]);
                int tiresIndex = int.Parse(input[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));
            }
            List<Car> specialCars = new List<Car>();

            foreach (Car car in cars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330)
                {
                    double tirePressureSum = 0;

                    foreach (Tire tire in car.Tires)
                        tirePressureSum += tire.Pressure;

                    if (tirePressureSum >= 9 && tirePressureSum <= 10)
                        specialCars.Add(car);
                }
            }

            foreach (Car specialCar in specialCars)
            {
                specialCar.Drive(20);
                Console.WriteLine(specialCar.WhoAmI());
            }

        }
    }
}
