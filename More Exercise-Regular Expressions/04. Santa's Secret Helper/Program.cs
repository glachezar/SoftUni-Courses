using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decryptionKey = int.Parse(Console.ReadLine());

            string encryptedMessage = Console.ReadLine();

            //Dictionary<char, string> goodBehaviorKids = new Dictionary<char, string>();
            List<string> goodBehaviorKidsList = new List<string>();
            while (encryptedMessage != "end")
            {
                string decryptedMessage = Decryption(encryptedMessage, decryptionKey);
                //Console.WriteLine(decryptedMessage);
                string pattern = @"[@](?<name>[A-Za-z]+)[^@!:>-]+[!](?<behavior>[G|N])[!]";
                MatchCollection matches = Regex.Matches(decryptedMessage, pattern);
                foreach (Match match in matches)
                {
                    if (match.Groups["behavior"].Value == "G")
                    {
                        goodBehaviorKidsList.Add(match.Groups["name"].Value);
                    }
                }
                encryptedMessage = Console.ReadLine();
            }

            foreach (var kid in goodBehaviorKidsList)
            {
                Console.WriteLine(kid);
            }
        }

        static string Decryption(string message, int key)
        {
            string decryptedMessage = "";

            foreach (var ch in message)
            {
                decryptedMessage += (char)(ch - key);
            }
            return decryptedMessage;
        }
    }
}
