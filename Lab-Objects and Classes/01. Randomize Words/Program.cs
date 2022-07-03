using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomNumber = rnd.Next(0, words.Length);
                string currentWord = words[i];
                words[i] = words[randomNumber];
                words[randomNumber] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }

    
}
