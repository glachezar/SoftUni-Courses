using System;
using System.Collections.Generic;
using System.Drawing;

namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    int countOfPeople = queue.Count;
                    Console.WriteLine($"{countOfPeople} people remaining.");
                    break;
                }
                if (input == "Paid")
                {
                    if (queue.Count > 0)
                    {
                        for (int i = queue.Count; i > 0; i--)
                        {
                            Console.WriteLine(queue.Dequeue());
                        }
                    }
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            //Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
