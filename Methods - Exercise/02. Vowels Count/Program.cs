using System;
using System.Collections.Generic;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(VowelsCount(input));
        }

        static string VowelsCount(string input)
        {
            int counter = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    counter++;
                }
            }

            return counter.ToString();
        }
    }
}
