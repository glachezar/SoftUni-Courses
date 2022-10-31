using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();
            char[] userInput = Console.ReadLine().Trim().ToCharArray();

            foreach (var character in userInput)
            {
                if (!letterCount.ContainsKey(character))
                {
                    letterCount.Add(character, 1);
                }
                else
                {
                    letterCount[character]++;
                }
            }
            foreach (var element in letterCount.Where(x => x.Key != ' '))
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
