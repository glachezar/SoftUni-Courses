using System;
using System.ComponentModel.Design;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            foreach (var ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else if (!char.IsLetterOrDigit(ch))
                {
                    others.Append(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                
            }

            Console.WriteLine(digits.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(others.ToString());
        }
    }
}
