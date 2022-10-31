using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");

            string textToFiltre = Console.ReadLine();
            string result = "";

            foreach (var word in bannedWords)
            {
                char ch = '*';
                int repeatCount = word.Length;
                string asterisks = new string(ch, repeatCount);
                textToFiltre = textToFiltre.Replace(word, asterisks);
            }

            Console.WriteLine(textToFiltre);
        }
    }
}
