using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));    // 1 5 28 1 4

            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));  // 3 18 1 9 30 4 5

            int wastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                int currCup = cups.Dequeue();

                while (currCup > bottles.Peek())
                {
                    currCup -= bottles.Pop();
                }

                wastedWater += bottles.Pop() - currCup;
                
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
            }
            else if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
