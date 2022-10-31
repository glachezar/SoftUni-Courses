using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._01.Mirror_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@|#)(?<word1>[A-Za-z]{3,})\1{2}(?<word2>[A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);
            string inputString = Console.ReadLine();
            Dictionary<string, string> validMatches = new Dictionary<string, string>();
            string word1 = "";
            string word2 = "";
            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                    word1 = match.Groups["word1"].Value;
                    word2 = match.Groups["word2"].Value;
                    string reversedWord = Reverce(word2);
                    if (word1 == reversedWord)
                    {
                        validMatches.Add(word1, word2);
                    }
            }
            if (!regex.IsMatch(inputString))
            {
                Console.WriteLine("No word pairs found!");
            }
            else if (regex.IsMatch(inputString))
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            if (validMatches.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else if (validMatches.Count > 0)
            {
                List<string> result = new List<string>();
                Console.WriteLine($"The mirror words are:");
                foreach (var kVP in validMatches)
                {
                    result.Add($"{kVP.Key} <=> {kVP.Value}");
                }
                Console.WriteLine($"{string.Join(", ", result)}");
            }
        }
        static string Reverce(string word2)
        {
            char[] cArray = word2.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

    }
}
