using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split().ToArray();
            int numberOfPasses = int.Parse(Console.ReadLine());
            Queue<string> kidsInQue = new Queue<string>(kids);
            int tosses = 1;
            while (kidsInQue.Count > 1)
            {
                string currentKid = kidsInQue.Dequeue();
                if (tosses == numberOfPasses)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    tosses = 1;
                    continue;
                }

                tosses++;
                kidsInQue.Enqueue(currentKid);
            }

            Console.WriteLine($"Last is {kidsInQue.Dequeue()}");

        }
    }
}
