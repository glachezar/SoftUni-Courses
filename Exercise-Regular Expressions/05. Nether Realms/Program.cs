using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^\+\-\*\/\.,0-9]";
            string damagePattern = @"-?\d+\.?\d*";
            string multiplyDividePattern = @"[\*\/]";
            string splitPattern = @"[,\s]+";

            string input = Console.ReadLine();
            string[] demons = Regex.Split(input, splitPattern).OrderBy(x=>x).ToArray();

            for (int i = 0; i < demons.Length; i++)
            {
                string curDemon = demons[i];
                var healthMatched = Regex.Matches(curDemon, healthPattern);
                var health = 0;
                foreach (Match match in healthMatched)
                {
                    char curChar = char.Parse(match.ToString());
                    health += curChar;
                }

                double damage = 0;
                var damageMatched = Regex.Matches(curDemon, damagePattern);
                foreach (Match match in damageMatched)
                {
                    double currentDamage = double.Parse(match.ToString());
                    damage += currentDamage;
                }

                var multiplyOrDivide = Regex.Matches(curDemon, multiplyDividePattern);
                foreach (Match match in multiplyOrDivide)
                {
                    char currentOperator = char.Parse(match.ToString());
                    if (currentOperator == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                Console.WriteLine($"{curDemon} - {health} health, {damage:F2} damage");
            }
        }
    }
}
