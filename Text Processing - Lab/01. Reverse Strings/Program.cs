using System;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();

                if (word == "end")
                {
                    break;
                }

                string revercedWord = "";

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    revercedWord += word[i];
                }
                Console.WriteLine($"{word} = {revercedWord}");
            }
        }
    }
}
