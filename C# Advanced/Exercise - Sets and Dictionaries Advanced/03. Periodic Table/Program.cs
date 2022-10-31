using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            SortedSet<string> uniqueElements = new SortedSet<string>();

            for (int i = 0; i < length; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                uniqueElements.UnionWith(input);
            }

            Console.WriteLine(String.Join(" ", uniqueElements));
        }
    }
}
