using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];

                if (currChar == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    result.Append(currChar);
                }
                else if (power == 0 )
                {
                    result.Append(currChar);
                }
                else
                {
                    power--;
                }
            }
            Console.WriteLine(result.ToString());

        }
    }
}
