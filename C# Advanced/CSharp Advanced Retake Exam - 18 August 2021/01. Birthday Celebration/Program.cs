using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace _01._Birthday_Celebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guests = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int wasteFood = 0;

            while (guests.Any() && plates.Any())
            {
                int currGueast = guests.Peek();
                int currPlate = plates.Pop();

                if (currGueast > currPlate)
                {
                    while (currPlate < currGueast && plates.Any())
                    {

                        currGueast -= currPlate;
                        currPlate = plates.Pop();
                    }

                }
                if (currGueast <= currPlate)
                {
                    currPlate -= currGueast;
                    wasteFood += currPlate;
                    guests.Dequeue();
                }
            }

            if (guests.Any()) Console.WriteLine($"Guests: {string.Join(" ", guests)}");
            
            else if (plates.Any()) Console.WriteLine($"Plates: {string.Join(" ", plates)}");

            Console.WriteLine($"Wasted grams of food: {wasteFood}");
            
            
        }
    }
}
