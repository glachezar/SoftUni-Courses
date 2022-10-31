using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nCars = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int countOfPassedCars = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine($"{countOfPassedCars} cars passed the crossroads.");
                    break;
                }

                if (input == "green")
                {
                    for (int i = 0; i < nCars; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            countOfPassedCars++;
                        }
                    }
                }
                else if (input != "green")
                {
                    queue.Enqueue(input);
                }
            }


        }
    }
}
