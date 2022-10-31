using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            double result = 0;
            foreach (var currentString in input)
            {
                double digits = double.Parse(currentString.Substring(1, currentString.Length -2));
                
                double letterPosition = 0;
                char firstLetter = currentString[0];
                char secondLetter = currentString.Last();
                    
                if (char.IsUpper(firstLetter))
                {
                    letterPosition = LetterAlphabetPosition(firstLetter);
                    result += digits / letterPosition;
                }
                else if (char.IsLower(firstLetter))
                {
                    letterPosition = LetterAlphabetPosition(firstLetter);

                    result += digits * letterPosition;
                }
                
                if (char.IsUpper(secondLetter))
                {
                    letterPosition = LetterAlphabetPosition(secondLetter);
                    result -= letterPosition;
                }
                else if (char.IsLower(secondLetter))
                {
                    letterPosition = LetterAlphabetPosition(secondLetter);

                    result += letterPosition;
                }
            }

            Console.WriteLine($"{result:F2}");
        }
        static int LetterAlphabetPosition(char letter)
        {
            int result = 0;
            if (char.IsUpper(letter))
            {
                result = letter - 64;
            }
            else if (char.IsLower(letter))
            {
                char letterToUpper = char.ToUpper(letter);
                result = letterToUpper - 64;
            }
            return result;
        }
    }
}
