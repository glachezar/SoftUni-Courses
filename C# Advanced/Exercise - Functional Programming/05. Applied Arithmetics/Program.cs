using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static Func<int[], int[]> add = n => n.Select(n => n + 1).ToArray();
        static Func<int[], int[]> multiply = n => n.Select(n => n * 2).ToArray();
        static Func<int[], int[]> subtract = n => n.Select(n => n - 1).ToArray();
        static Action<int[]> print = n => Console.WriteLine(String.Join(" ", n));

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            InputLoopByRecursion(Console.ReadLine(), numbers);
        }
        static void InputLoopByRecursion(string input, int[] nums)
        {
            switch (input)
            {
                case "add": nums = add(nums); break;
                case "multiply": nums = multiply(nums); break;
                case "subtract": nums = subtract(nums); break;
                case "print": print(nums); break;
                case "end": return;
            }
            InputLoopByRecursion(Console.ReadLine(), nums);
        }
    }
}
