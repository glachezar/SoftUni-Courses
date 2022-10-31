using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredient = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> freshnessLevel = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            SortedDictionary<string, int> coockedFood = new SortedDictionary<string, int>();

            while (ingredient.Any() && freshnessLevel.Any())
            {
                if (ingredient.Peek() == 0)
                {
                    ingredient.Dequeue();
                    continue;
                }

                int coockingResult = ingredient.Peek() * freshnessLevel.Peek();

                string result = "";
                switch (coockingResult)
                {
                    case 150: result = "Dipping sauce";
                        ingredient.Dequeue();
                        freshnessLevel.Pop();
                        break;
                    case 250: result = "Green salad";
                        ingredient.Dequeue();
                        freshnessLevel.Pop();
                        break;
                    case 300: result = "Chocolate cake"; 
                        ingredient.Dequeue();
                        freshnessLevel.Pop(); 
                        break;
                    case 400: result = "Lobster";
                        ingredient.Dequeue();
                        freshnessLevel.Pop();
                        break;
                    default:
                        int toQue = ingredient.Dequeue() + 5;
                        ingredient.Enqueue(toQue);
                        freshnessLevel.Pop();
                        break;
                }

                if (!coockedFood.ContainsKey(result) && result != "")
                {
                    coockedFood.Add(result, 0);
                    coockedFood[result]++;
                }
                else if (coockedFood.ContainsKey(result))
                {
                    coockedFood[result]++;
                }
            }

            if (coockedFood.Count >= 4) Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            
            else Console.WriteLine("You were voted off. Better luck next year.");

            if (ingredient.Any()) Console.WriteLine($"Ingredients left: {ingredient.Sum()}");

            foreach (var dish in coockedFood) Console.WriteLine($" # {dish.Key} --> {dish.Value}");
            
        }
        
    }
}
