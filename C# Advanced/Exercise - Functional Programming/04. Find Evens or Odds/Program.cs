using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 == 1 || x % 2 == -1;

            Func<int, Predicate<int>, bool> isValid = (x, condition) => condition(x);

            int[] range = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            string condition = Console.ReadLine();

            List<int> result = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                if (condition == "even" && isValid(i, isEven) ||
                    condition == "odd" && isValid(i, isOdd))
                    result.Add(i);
            }


            Console.WriteLine(String.Join(" ", result));
        }
    }
}
