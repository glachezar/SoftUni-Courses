using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace _01._Food_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));

            // pear
            // flour
            // pork
            // olive
            Dictionary<string, HashSet<char>> keyWords = new Dictionary<string, HashSet<char>>()
            {
                {"pear", new HashSet<char>()},
                {"flour", new HashSet<char>()},
                {"pork", new HashSet<char>()},
                {"olive", new HashSet<char>()},
            };

            while (consonants.Count > 0)
            {
                char currVowel = vowels.Dequeue();
                char currConsonant = consonants.Pop();

                foreach (var word in keyWords)
                {
                    if (word.Key.Contains(currVowel))
                    {
                        word.Value.Add(currVowel);
                    }
                    if (word.Key.Contains(currConsonant))
                    {
                        word.Value.Add(currConsonant);
                    }
                }

                vowels.Enqueue(currVowel);

            }

            List<string> foundWords = keyWords.Where(w => w.Key.Length == w.Value.Count)
                .Select(w => w.Key)
                .ToList();

            Console.WriteLine($"Words found: {foundWords.Count}");
            foreach (var word in foundWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
