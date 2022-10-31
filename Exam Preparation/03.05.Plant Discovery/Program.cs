using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._05.Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();
            int numberOfPlants = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPlants; i++)
            {
                string[] input = Console.ReadLine().Split("<->").ToArray();
                string plantName = input[0];
                int plantRarity = int.Parse(input[1]);
                if (!plants.ContainsKey(plantName))
                {
                    plants.Add(plantName, new List<double>());
                    plants[plantName].Add(plantRarity);
                }
                else if (plants.ContainsKey(plantName))
                {
                    plants[plantName].Add(plantRarity);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Exhibition") break;

                string[] tokens = input.Split(": ").ToArray();
                string command = tokens[0];
                if (command == "Rate")
                {
                    string[] parameters = tokens[1].Split(" - ").ToArray();
                    string plant = parameters[0];
                    double rating = double.Parse(parameters[1]);
                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Add(rating);

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Update")
                {
                    //"Update: {plant} - {new_rarity}" – update the rarity of the plant with the new one
                    string[] parameters = tokens[1].Split(" - ").ToArray();
                    string plant = parameters[0];
                    double newRarity = double.Parse(parameters[1]);
                    if (plants.ContainsKey(plant))
                    {
                        plants[plant][0] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Reset")
                {
                    //"Reset: {plant}" – remove all the ratings of the given plant
                    string plant = tokens[1];
                    //double rarity = plants[plant][0];
                    if (plants.ContainsKey(plant))
                    {
                        int count = plants[plant].Count - 1;
                        plants[plant].RemoveRange(1, count);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                int rarity = (int)plant.Value[0];
                plant.Value.RemoveAt(0);
                double averageRating = 0;
                if (plant.Value.Count > 0)
                {
                    averageRating = plant.Value.Average();
                }
                Console.WriteLine($"- {plant.Key}; Rarity: {rarity}; Rating: {averageRating:f2}");
            }


        }
    }
}
