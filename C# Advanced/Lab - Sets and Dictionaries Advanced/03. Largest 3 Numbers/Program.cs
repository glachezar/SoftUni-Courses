using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();

            var orderdList = myList.OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", orderdList));
        }
    }
}
