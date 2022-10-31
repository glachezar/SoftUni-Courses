using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Message_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            string pattern00 = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<string>[A-Za-z]{8,})\]";

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern00);

                if (regex.IsMatch(input))
                {
                    Match matches = regex.Match(input);
                    string commando = matches.Groups["command"].Value;
                    string mesageTocharArr = matches.Groups["string"].Value;
                    List<string> charToNumsB = new List<string>();
                    foreach (var leetter in mesageTocharArr)
                    {
                        int charNum = (int)leetter;
                        string numToStr = charNum.ToString();
                        charToNumsB.Add(numToStr);
                    }

                    
                    Console.WriteLine($"{commando}: {string.Join(" ", charToNumsB)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
