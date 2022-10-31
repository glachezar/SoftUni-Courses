using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Meal_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> meals = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray());
            Stack<int> calories = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int mealCouter = 0;
            Dictionary<string, int> mealsCalories = new Dictionary<string, int>
            {
                { "salad", 350 },
                { "soup", 490 },
                { "pasta", 680 },
                { "steak", 790 }

            };



            while (meals.Any() && calories.Any() && calories.Peek() > 0)
            {
                int currCalories = calories.Pop();
                string currMeal = meals.Dequeue();
                mealCouter++;

                int currMealCalories = mealsCalories[currMeal];
                currCalories -= currMealCalories;

                while (currCalories <= 0)
                {
                    if (!calories.Any()) break;
                    currCalories += calories.Pop();
                }

                calories.Push(currCalories);
            }

            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {mealCouter} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {mealCouter} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }
    }
}
