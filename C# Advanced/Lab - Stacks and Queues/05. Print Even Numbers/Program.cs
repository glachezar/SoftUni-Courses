using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queOfEven = new Queue<int>();

            foreach (var number in num)
            {
                if (number % 2 == 0)
                {
                   queOfEven.Enqueue(number);
                }
            }

            Console.WriteLine(string.Join(", ", queOfEven));
        }
    }
}
