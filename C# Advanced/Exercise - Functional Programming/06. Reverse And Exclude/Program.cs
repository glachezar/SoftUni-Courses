using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> isNotDivisible = (num, divider) => num % divider != 0;

            Func<int[], int, int[]> filter = (arr, divider) => arr.Where(x => isNotDivisible(x, divider)).Reverse().ToArray();

            Action<int[]> print = arr => Console.WriteLine(String.Join(" ", arr));

            int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            int divider = int.Parse(Console.ReadLine());

            print(filter(nums, divider));
        }
    }
}
