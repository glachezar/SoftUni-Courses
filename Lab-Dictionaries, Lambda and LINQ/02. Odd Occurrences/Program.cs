using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();

            Dictionary<string, int> countOfWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!countOfWords.ContainsKey(word))
                {
                    countOfWords.Add(word, 1);
                }
                else
                {
                    countOfWords[word]++;
                }
            }

            foreach (var word in countOfWords)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
