using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace _03._04.Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> carsAndProperties = new Dictionary<string, List<int>>();
            //"{car}|{mileage}|{fuel}"
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] cars = Console.ReadLine().Split("|").ToArray();
                string car = cars[0];
                int mileage = int.Parse(cars[1]);
                int fuel = int.Parse(cars[2]);
                carsAndProperties.Add(car, new List<int>());
                carsAndProperties[car].Add(mileage);
                carsAndProperties[car].Add(fuel);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop") break;

                string[] tokens = input.Split(" : ").ToArray();
                string command = tokens[0];

                //"Drive : {car} : {distance} : {fuel}"
                if (command == "Drive")
                {
                    string car = tokens[1];
                    int mileage = int.Parse(tokens[2]);
                    int fuelNeeded = int.Parse(tokens[3]);
                    Drive(car, mileage, fuelNeeded, carsAndProperties);
                }
                //"Refuel : {car} : {fuel}"
                else if (command == "Refuel")
                {
                    string car = tokens[1];
                    int fuel = int.Parse(tokens[2]);
                    Refuel(car, fuel, carsAndProperties);
                }
                //"Revert : {car} : {kilometers}"
                else if (command == "Revert")
                {
                    string car = tokens[1];
                    int kilometers = int.Parse(tokens[2]);
                    Revert(car, kilometers, carsAndProperties);
                }
            }

            foreach (var car in carsAndProperties)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }

        private static void Drive(string car, int mileage, int fuelNeeded, Dictionary<string, List<int>> carsAndProperties)
        {
            //"{car}[key] | {mileage}[0] | {fuel}[1]"
            if (carsAndProperties[car][1] - fuelNeeded >=0)
            {
                carsAndProperties[car][0] += mileage;
                carsAndProperties[car][1] -= fuelNeeded;
                Console.WriteLine($"{car} driven for {mileage} kilometers. {fuelNeeded} liters of fuel consumed.");
                if (carsAndProperties[car][0] >= 100000)
                {
                    Console.WriteLine($"Time to sell the {car}!");
                    carsAndProperties.Remove(car);
                }
            }
            else
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
        }

        private static void Refuel(string car, int fuel, Dictionary<string, List<int>> carsAndProperties)
        {
            //"{car}[key] | {mileage}[0] | {fuel}[1]"
            // Max tank capacity 75 l.
            if (carsAndProperties[car][1] + fuel > 75)
            {
                int fuelNeeded = 75 - carsAndProperties[car][1];
                carsAndProperties[car][1] = 75;
                Console.WriteLine($"{car} refueled with {fuelNeeded} liters");
            }
            else
            {
                carsAndProperties[car][1] += fuel;
                Console.WriteLine($"{car} refueled with {fuel} liters");
            }
        }

        private static void Revert(string car, int kilometers, Dictionary<string, List<int>> carsAndProperties)
        {
            //"{car}[key] | {mileage}[0] | {fuel}[1]"
            if (carsAndProperties[car][0] - kilometers < 10000)
            {
                carsAndProperties[car][0] = 10000;
            }
            else
            {
                carsAndProperties[car][0] -= kilometers;
                Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
            }
        }
    }
}
