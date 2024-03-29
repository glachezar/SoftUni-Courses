﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            char dot = '.';
            char dash = '-';
            Dictionary<string, char> translator = new Dictionary<string, char>()
            {
                {string.Concat(dot, dash), 'a'},
                {string.Concat(dash, dot, dot, dot), 'b'},
                {string.Concat(dash, dot, dash, dot), 'c'},
                {string.Concat(dash, dot, dot), 'd'},
                {dot.ToString(), 'e'},
                {string.Concat(dot, dot, dash, dot), 'f'},
                {string.Concat(dash, dash, dot), 'g'},
                {string.Concat(dot, dot, dot, dot), 'h'},
                {string.Concat(dot, dot), 'i'},
                {string.Concat(dot, dash, dash, dash), 'j'},
                {string.Concat(dash, dot, dash), 'k'},
                {string.Concat(dot, dash, dot, dot), 'l'},
                {string.Concat(dash, dash), 'm'},
                {string.Concat(dash, dot), 'n'},
                {string.Concat(dash, dash, dash), 'o'},
                {string.Concat(dot, dash, dash, dot), 'p'},
                {string.Concat(dash, dash, dot, dash),'q'},
                {string.Concat(dot, dash, dot),'r'},
                {string.Concat(dot, dot, dot),'s'},
                {string.Concat(dash), 't'},
                {string.Concat(dot, dot, dash), 'u'},
                {string.Concat(dot, dot, dot, dash), 'v'},
                {string.Concat(dot, dash, dash), 'w'},
                {string.Concat(dash, dot, dot, dash), 'x'},
                {string.Concat(dash, dot, dash, dash), 'y'},
                {string.Concat(dash, dash, dot, dot), 'z'},
                {string.Concat(dash, dash, dash, dash, dash), '0'},
                {string.Concat(dot, dash, dash, dash, dash), '1'},
                {string.Concat(dot, dot, dash, dash, dash),'2'},
                {string.Concat(dot, dot, dot, dash, dash), '3'},
                {string.Concat(dot, dot, dot, dot, dash), '4'},
                {string.Concat(dot, dot, dot, dot, dot), '5'},
                {string.Concat(dash, dot, dot, dot, dot), '6'},
                {string.Concat(dash, dash, dot, dot, dot), '7'},
                {string.Concat(dash, dash, dash, dot, dot), '8'},
                {string.Concat(dash, dash, dash, dash, dot), '9'}
            };

            StringBuilder result = new StringBuilder();

            string input = Console.ReadLine();

            string[] words = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var word in words)
            {
                if (word != "|")
                {
                    result.Append(translator[word]);
                }
                else if (word == "|")
                {
                    result.Append(" ");
                }
            }
            string decodedMessage = result.ToString();
            Console.WriteLine(decodedMessage.ToUpper());
        }
    }
}
