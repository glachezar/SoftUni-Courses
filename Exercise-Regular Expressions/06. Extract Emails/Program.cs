using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-][A-Za-z]+)+))(\b|(?=\s))";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            if (regex.IsMatch(input))
            {
                foreach (Match email in matches)
                {
                    Console.WriteLine(email);
                }
            }
        }
    }
}
