using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Use a nested dictionary (string  (Dictionary  List<string>)) .
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentsAndCountries = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentsAndCountries.ContainsKey(continent))
                {
                    continentsAndCountries.Add(continent, new Dictionary<string, List<string>>());
                }
                if (continentsAndCountries.ContainsKey(continent) && !continentsAndCountries[continent].ContainsKey(country))
                {
                    continentsAndCountries[continent].Add(country, new List<string>());
                }
                continentsAndCountries[continent][country].Add(city);
            }

            foreach (var continent in continentsAndCountries)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    //Bulgaria -> Sofia, Plovdiv

                    Console.WriteLine($"  {country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}
