using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, int, bool> isValid = (name, number) => name.Sum(ch => ch) >= number;

            Func<List<string>, Func<string, int, bool>, string> findName = (names, isValidName) => names.Find(x => isValidName(x, baseNumber));

            string result = findName(names, isValid);

            Console.WriteLine(result);
        }
    }
}
