using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, Dictionary<string, double>> shopsAndPrices = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "Revision")
                {
                    break;
                }


                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);
                if (!shopsAndPrices.ContainsKey(shop))
                {
                    shopsAndPrices.Add(shop, new Dictionary<string, double>());
                }
                shopsAndPrices[shop].Add(product, price);


            }

            foreach (var shop in shopsAndPrices)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
