using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            FindMiddleCharacter(text);
        }

        private static void FindMiddleCharacter(string text)
        {
            char midChar = '0';
            if (text.Length % 2 == 0)
            {
                Console.WriteLine(text.Substring((text.Length / 2) - 1, 2));
            }
            else
            {
                Console.WriteLine(text[text.Length / 2]);
            }
        }
        
    }
}
