using System;
using System.Linq;
using static System.StringSplitOptions;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startWithCapital = w => char.IsUpper(w[0]);

            Console.WriteLine(string.Join("\r\n", Array
                .FindAll(Console.ReadLine()
                    .Split(" ", RemoveEmptyEntries), startWithCapital)));

        }
    }
}
