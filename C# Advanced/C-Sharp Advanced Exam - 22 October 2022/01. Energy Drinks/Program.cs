using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Energy_Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> coffeine = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> energyDrink = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int stamatIntake = 0;

            const int stamatMaxCaffeineForADay = 300;

            while (coffeine.Any() && energyDrink.Any())
            {
                int currCaffeine = coffeine.Pop();
                int currEnergyDrink = energyDrink.Dequeue();

                int result = currEnergyDrink * currCaffeine;

                if (result + stamatIntake <= stamatMaxCaffeineForADay)
                {
                    stamatIntake += result;
                }
                else if (result + stamatIntake > stamatMaxCaffeineForADay)
                {
                    energyDrink.Enqueue(currEnergyDrink);
                    if (stamatIntake - 30 >= 0)
                    {
                        stamatIntake -= 30;
                    }

                }
            }

            if (energyDrink.Any()) Console.WriteLine($"Drinks left: {string.Join(", ", energyDrink)}");
            else Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");

            Console.WriteLine($"Stamat is going to sleep with {stamatIntake} mg caffeine.");

        }
    }
}