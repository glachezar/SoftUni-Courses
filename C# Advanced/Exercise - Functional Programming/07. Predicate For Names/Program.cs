using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Predicate<string> isValidLengthName = x => x.Length <= length;

            Console.WriteLine(string.Join(Environment.NewLine, names.Where(x => isValidLengthName(x))));
        }
    }
}
