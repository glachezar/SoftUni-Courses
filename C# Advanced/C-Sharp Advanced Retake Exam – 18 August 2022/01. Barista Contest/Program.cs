using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Barista_Contest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> coffee = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Stack<int> milk = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Dictionary<int, string> values = new Dictionary<int, string>
            {
                //{"Cortado", 50 },
                //{"Espresso", 75},
                //{"Capuccino", 100},
                //{"Americano", 150},
                //{"Latte", 200},

                {50, "Cortado"},
                {75, "Espresso"},
                {100, "Capuccino"},
                {150, "Americano"},
                {200, "Latte"},
            };
            Dictionary<string, int> productsMade = new Dictionary<string, int>
            {
                {"Cortado", 0 },
                {"Espresso", 0},
                {"Capuccino", 0},
                {"Americano", 0},
                {"Latte", 0},
            };

            while (coffee.Count != 0 && milk.Count != 0)
            {
                int currCoffee = coffee.Dequeue();
                int currMilk = milk.Pop();

                int sum = currCoffee + currMilk;

                if (values.ContainsKey(sum))
                {
                    productsMade[values[sum]] ++;
                }
                else
                {
                    currMilk = currMilk - 5;
                    milk.Push(currMilk);
                }
            }

            if (coffee.Count == 0 && milk.Count == 0)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
                Console.WriteLine("Coffee left: none");
                Console.WriteLine("Milk left: none");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");

                if (coffee.Count > 0) Console.WriteLine($"Coffee left: {string.Join(", ", coffee)}");
                else Console.WriteLine("Coffee left: none");

                if (milk.Count > 0) Console.WriteLine($"Milk left: {string.Join(", ", milk)}");
                else Console.WriteLine("Milk left: none");


            }

            IEnumerable<KeyValuePair<string, int>> drinksMade = productsMade.Where(v => v.Value > 0);

            foreach (var drink in drinksMade.OrderBy(d => d.Value).ThenByDescending(d => d.Key))
            {

                Console.WriteLine($"{drink.Key}: {drink.Value}");
            }
        }
    }
}
