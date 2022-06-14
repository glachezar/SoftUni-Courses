using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string repeat = Console.ReadLine();

            Console.WriteLine(StringInterpolation(input, repeat));
        }

        static string StringInterpolation(string input, string repeat)
        {
            int repeater = int.Parse(repeat);
            string result = String.Empty;
            for (int i = 0; i < repeater; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
