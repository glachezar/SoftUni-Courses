using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._05.Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int caloriesNeededForDay = 2000;
            string pattern = @"(\||#)((?<product>[A-Za-z\s]+)\1(?<date>\d{2}/\d{2}/\d{2})\1(?<calories>\d{1,5}))\1";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            List<Rations> rations = new List<Rations>();
            int totalCal = 0;

            foreach (Match match in matches)
            {
                string product = match.Groups["product"].Value;
                string date = match.Groups["date"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);
                totalCal += calories;
                Rations newRations = new Rations(product, date, calories);
                rations.Add(newRations);
            }

            int numberOfDays = totalCal / caloriesNeededForDay;
            Console.WriteLine($"You have food to last you for: {numberOfDays} days!");
            foreach (var product in rations)
            {
                Console.WriteLine($"Item: {product.Product}, Best before: {product.ExpirationDate}, Nutrition: {product.Calories}");
            }
        }

        class Rations
        {
            public Rations(string product, string date, int calories)
            {
                Product = product;
                ExpirationDate = date;
                Calories = calories;
            }

            public string Product { get; set; }

            public string ExpirationDate { get; set; }

            public int Calories { get; set; }

        }
    }
}
