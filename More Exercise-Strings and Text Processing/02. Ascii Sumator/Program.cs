using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int start = Math.Min(firstChar, secondChar);
            int end = Math.Max(firstChar, secondChar);


            int sum = 0;

            foreach (int currentChar in text)
            {
                if (currentChar > start && currentChar < end)
                {
                    sum += currentChar;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
