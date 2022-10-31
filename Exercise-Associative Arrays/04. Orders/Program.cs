using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace _04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> shoppingList = new Dictionary<string, int>();
            Dictionary<string, double> shoppingListPrices = new Dictionary<string, double>();

            while (true)
            {
                string[] productsToBuy = Console.ReadLine().Split().ToArray();
                if (productsToBuy[0] == "buy")
                {
                    break;
                }
                string nameOfProduct = productsToBuy[0];
                double priceOfProduct = double.Parse(productsToBuy[1]);
                int qtyOfProduct = int.Parse(productsToBuy[2]);

                if (!shoppingList.ContainsKey(nameOfProduct))
                {
                    shoppingList.Add(nameOfProduct, qtyOfProduct);
                    shoppingListPrices.Add(nameOfProduct, priceOfProduct);
                }
                else if (shoppingList.ContainsKey(nameOfProduct))
                {
                    shoppingList[nameOfProduct] += qtyOfProduct;
                    shoppingListPrices[nameOfProduct] = priceOfProduct;
                }
            }
            Dictionary<string, double> buyProducts = 
                shoppingList.ToDictionary(orig => 
                    orig.Key, orig => 
                    orig.Value * shoppingListPrices[orig.Key]); ;

            foreach (var product in buyProducts)
            {
                Console.WriteLine($"{product.Key} -> {product.Value:f2}");
            }
        }
    }
}
