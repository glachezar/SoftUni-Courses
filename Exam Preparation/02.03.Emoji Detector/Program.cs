using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _02._03.Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";
            string digitPattern = @"\d";

            string text = Console.ReadLine();
            List<string> coolEmojis = new List<string>();
            BigInteger coolOnes = 1;
            int countOfEmoji = 0;

            MatchCollection digits = Regex.Matches(text, digitPattern);
            
            foreach (Match digit in digits)
            {
                coolOnes *= int.Parse(digit.ToString());
            }

            if (Regex.IsMatch(text, emojiPattern))
            {
                MatchCollection emojis = Regex.Matches(text, emojiPattern);
                countOfEmoji = emojis.Count;
                foreach (Match emoji in emojis)
                {
                    char[] chars = emoji.Groups["emoji"].Value.ToCharArray();

                    BigInteger emojiSum = 0;
                    foreach (var ch in chars)
                    {
                        emojiSum += (int)ch;
                    }

                    if (emojiSum >= coolOnes)
                    {
                        coolEmojis.Add(emoji.ToString());
                    }
                }
            }

            Console.WriteLine($"Cool threshold: {coolOnes}");
            Console.WriteLine($"{countOfEmoji} emojis found in the text. The cool ones are:");
            coolEmojis.ForEach(Console.WriteLine);
        }
    }
}
