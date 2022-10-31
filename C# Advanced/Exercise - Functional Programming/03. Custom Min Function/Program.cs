using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> takeTheSmalestNumber = x => x.Min();

            Console.WriteLine(takeTheSmalestNumber(Console.ReadLine().Split().Select(int.Parse).ToArray()));

        }
    }
}
