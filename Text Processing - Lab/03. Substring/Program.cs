using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string input = Console.ReadLine();

            while (input.Contains(wordToRemove))
            {
                int startIndex  = input.IndexOf(wordToRemove);
                int count = wordToRemove.Length;

                input = input.Remove(startIndex, count);
            }
            Console.WriteLine(input);
        }
    }
}
