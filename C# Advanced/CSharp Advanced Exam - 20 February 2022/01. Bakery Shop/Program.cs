using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse));

            Dictionary<string, int> bakedProducts = new Dictionary<string, int>();

            while (flour.Any() && water.Any())
            {
                double currentWater = water.Dequeue();
                double currentFlour = flour.Pop();
                double waterPercentage = currentWater / (currentWater + currentFlour) * 100;
                string bakedProduct;
                switch (waterPercentage)
                {
                    case 50: bakedProduct = "Croissant"; break;

                    case 40: bakedProduct = "Muffin"; break;

                    case 30: bakedProduct = "Baguette"; break;

                    case 20: bakedProduct = "Bagel"; break;

                    default: bakedProduct = "Croissant"; flour.Push(currentFlour - currentWater); break;
                }

                if (!bakedProducts.ContainsKey(bakedProduct))
                {
                    bakedProducts.Add(bakedProduct, 0);
                }
                bakedProducts[bakedProduct]++;
            }

            foreach (var product in bakedProducts.OrderByDescending(v => v.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            if (water.Any()) Console.WriteLine($"Water left: {string.Join(", ", water)}");
            else Console.WriteLine("Water left: None");

            if (flour.Any()) Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            else Console.WriteLine("Flour left: None");

        }
    }
}
