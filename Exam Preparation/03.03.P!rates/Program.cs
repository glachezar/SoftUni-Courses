using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._03.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Sail") break;
                string[] tokens = input.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string cityName = tokens[0];
                int population = int.Parse(tokens[1]);
                int goldKg = int.Parse(tokens[2]);

                if (!cities.ContainsKey(cityName))
                {
                    cities.Add(cityName, new List<int>());
                    cities[cityName].Add(population);
                    cities[cityName].Add(goldKg);
                }
                else if (cities.ContainsKey(cityName))
                {
                    cities[cityName][0] += population;
                    cities[cityName][1] += goldKg;
                }

            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;

                string[] tokens = input.Split("=>").ToArray();
                string command = tokens[0];

                switch (command)
                {
                    case "Plunder":
                        string townName = tokens[1];
                        int peopleKilled = int.Parse(tokens[2]);
                        int goldStolen = int.Parse(tokens[3]);
                        Punder(townName, peopleKilled, goldStolen, cities);
                        break;
                    case "Prosper":
                        townName = tokens[1];
                        int goldAdded = int.Parse(tokens[2]);
                        Prosper(townName, goldAdded, cities);
                        break;
                }
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        private static void Prosper(string townName, int goldAdded, Dictionary<string, List<int>> cities)
        {
            if (goldAdded > 0)
            {
                cities[townName][1] += goldAdded;
                Console.WriteLine($"{goldAdded} gold added to the city treasury. {townName} now has {cities[townName][1]} gold.");
            }
            else
            {
                Console.WriteLine("Gold added cannot be a negative number!");
            }
        }

        private static void Punder(string townName, int peopleKilled, int goldStolen, Dictionary<string, List<int>> cities)
        {
            if (cities.ContainsKey(townName))
            {
                Console.WriteLine($"{townName} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");
                cities[townName][0] -= peopleKilled;
                cities[townName][1] -= goldStolen;
                if (cities[townName][0] <= 0 || cities[townName][1] <= 0)
                {
                    cities.Remove(townName);
                    Console.WriteLine($"{townName} has been wiped off the map!");
                }
            }
        }
    }
}
